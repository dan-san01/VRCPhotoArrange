using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VRCPhotoArrange.StateTransition;
using VRCPhotoArrange.Process;

namespace VRCPhotoArrange
{
    public partial class FormMain : Form
    {
        StringTransformProcess StringTransformProcess = new StringTransformProcess();
        AnalysisStateTransition AnalysisStateTransition = new AnalysisStateTransition();

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize WindowsForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            //Init state label
            StateLabel.Text = AnalysisStateTransition.OutputState();

            //Init progress bar
            CopingProgressBar.MarqueeAnimationSpeed = 0;

            //Init textbox color
            InputPathTextBox.BackColor = Color.White;
            OutputPathTextBox.BackColor = Color.White;

            //Get current directory.
            var OutputDefaultPath = Directory.GetCurrentDirectory() + @"\Output";
            OutputPathTextBox.Text = OutputDefaultPath;
            OutputFolderNameLabel.Text = StringTransformProcess.TransformOutputFolderLabel(Path.GetFileName(OutputDefaultPath));
        }


        /// <summary>
        /// The Operation of D&D to InputPathTextBox. 
        /// 1. Reset textbox.
        /// 2. Write textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputPathTextBox_DragDrop(object sender, DragEventArgs e)
        {
            //1. Reset textbox
            InputPathTextBox.ResetText();

            //2. Write textbox
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string folderPath = files[0];
            InputPathTextBox.Text = folderPath;
            InputFolderNameLabel.Text = StringTransformProcess.TransformInputFolderLabel(Path.GetFileName(folderPath));
        }


        /// <summary>
        /// The Effect of InputPathTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputPathTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }


        /// <summary>
        /// The motion after run bottun click.
        /// 1. Change analysis state.
        /// 2. Get PNG infomation.
        /// 3. Calculate file size.
        /// 4. Change WaitForAnalysisMessageResponse State.
        /// 5. Run copy.
        /// 6. Cahnge Standby State.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void RunButton_Click(object sender, EventArgs e)
        {
            if (InputPathTextBox.Text == "" ||
                OutputPathTextBox.Text == "" ||
                StartHourSelectComboBox.Text == "" ||
                StartMinuteSelectComboBox.Text == "" ||
                WeekSelectComboBox.Text == "" ||
                EndHourSelectComboBox.Text == "" ||
                EndMinuteSelectComboBox.Text == ""
                )
            {
                string message = "必要な情報が入力されていません。";
                string caption = "警告";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //1. Change analysis state
                AnalysisStateTransition.StandbyState = false;
                AnalysisStateTransition.AnalysisState = true;
                StateLabel.Text = AnalysisStateTransition.OutputState();
                await Task.Delay(500);


                //2. Get PNG infomation
                string readFilePath = InputPathTextBox.Text;
                string specifiedStartTime = StartHourSelectComboBox.Text + ":" + StartMinuteSelectComboBox.Text;
                string specifiedEndTime = EndHourSelectComboBox.Text + ":" + EndMinuteSelectComboBox.Text;
                string specifiedWeekday = WeekSelectComboBox.Text;

                var classificationProcess = new ClassificationProcess();
                var images = classificationProcess.ClassifyImages(readFilePath,
                    specifiedStartTime, specifiedEndTime, specifiedWeekday);


                //3. Calculate filesize.
                long filesizeSum = 0;
                foreach (var image in images)
                {
                    filesizeSum += image.Length;
                }
                long filesizeSumMB = filesizeSum / 1024 / 1024;
                float filesizeSumGB = filesizeSumMB / 1024;

                //4. Change WaitForAnalysisMessageResponse state
                AnalysisStateTransition.AnalysisState = false;
                AnalysisStateTransition.WaitForAnalysisMessageResponseState = true;
                StateLabel.Text = AnalysisStateTransition.OutputState();

                string message = "";
                if (filesizeSumGB < 1)
                {
                    message = "コピーするファイルサイズの合計が " + filesizeSumMB.ToString() + " MBです。" + "画像をコピーしますか？";
                }
                else
                {
                    message = "コピーするファイルサイズの合計が " + filesizeSumGB.ToString() + " GBです。" + "画像をコピーしますか？";
                }
                string caption = "コピーするファイルサイズの確認";
                DialogResult dialogResult = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                //5. Run copy
                if (dialogResult == DialogResult.OK)
                {
                    //Change state
                    AnalysisStateTransition.WaitForAnalysisMessageResponseState = false;
                    AnalysisStateTransition.CopingState = true;
                    StateLabel.Text = AnalysisStateTransition.OutputState();
                    await Task.Delay(500);

                    //Start copy and displaying the progressbar
                    var copyPhotoProcess = new CopyPhotoProcess();
                    CopingProgressBar.Visible = true;
                    CopingProgressBar.MarqueeAnimationSpeed = 20;
                    await copyPhotoProcess.CopyPhotos(OutputPathTextBox.Text, images);
                    CopingProgressBar.MarqueeAnimationSpeed = 0;
                    CopingProgressBar.Visible = false;

                    //Change state
                    AnalysisStateTransition.CopingState = false;
                    AnalysisStateTransition.WaitForCopyMessageResponseState = true;
                    StateLabel.Text = AnalysisStateTransition.OutputState();
                    await Task.Delay(500);

                    string EndMessage = "コピーが終了しました。";
                    string EndCaption = "コピーの終了";
                    MessageBox.Show(EndMessage, EndCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //6. Change standby state
                AnalysisStateTransition.StandbyState = true;
                AnalysisStateTransition.WaitForAnalysisMessageResponseState = false;
                AnalysisStateTransition.WaitForCopyMessageResponseState = false;
                StateLabel.Text = AnalysisStateTransition.OutputState();
            }
        }


        /// <summary>
        /// The event when user change SelectedComboBox.
        /// 1. Select index of combobox.
        /// 2. Change standby state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectRegularEventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1. Select index of combobox.
            if (SelectRegularEventComboBox.Text == "手動入力")
            {
                StartHourSelectComboBox.Text = "0";
                StartMinuteSelectComboBox.Text = "00";
                WeekSelectComboBox.Text = "Sunday";
                EndHourSelectComboBox.Text = "0";
                EndMinuteSelectComboBox.Text = "00";

                //Change output directory.
                string outputFolderPath = Directory.GetCurrentDirectory() + @"\Output";
                OutputPathTextBox.ResetText();
                OutputPathTextBox.Text = outputFolderPath;
                OutputFolderNameLabel.Text = StringTransformProcess.TransformOutputFolderLabel(Path.GetFileName(outputFolderPath));
            }
            else if(SelectRegularEventComboBox.Text == "VRCモーニングカフェ会")
            {
                StartHourSelectComboBox.Text = "7";
                StartMinuteSelectComboBox.Text = "30";
                WeekSelectComboBox.Text = "Sunday";
                EndHourSelectComboBox.Text = "9";
                EndMinuteSelectComboBox.Text = "00";

                //Change output directory.
                string outputFolderPath = Directory.GetCurrentDirectory() + @"\VRCモーニングカフェ会";
                OutputPathTextBox.ResetText();
                OutputPathTextBox.Text = outputFolderPath;
                OutputFolderNameLabel.Text = StringTransformProcess.TransformOutputFolderLabel(Path.GetFileName(outputFolderPath));
            }
            else if (SelectRegularEventComboBox.Text == "VRCラジオ体操")
            {
                StartHourSelectComboBox.Text = "6";
                StartMinuteSelectComboBox.Text = "00";
                WeekSelectComboBox.Text = "Everyday";
                EndHourSelectComboBox.Text = "7";
                EndMinuteSelectComboBox.Text = "30";

                //Change output directory.
                string outputFolderPath = Directory.GetCurrentDirectory() + @"\VRCラジオ体操";
                OutputPathTextBox.ResetText();
                OutputPathTextBox.Text = outputFolderPath;
                OutputFolderNameLabel.Text = StringTransformProcess.TransformOutputFolderLabel(Path.GetFileName(outputFolderPath));
            }
            //2. Change standby state.
            AnalysisStateTransition.InitState = false;
            AnalysisStateTransition.StandbyState = true;
            StateLabel.Text = AnalysisStateTransition.OutputState();
        }


        /// <summary>
        /// Change the input box by the browse button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputPathBrowseButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            //Dialog description.
            folderBrowserDialog.Description = "フォルダを選択してください。";
            //Specifying the default folder.
            folderBrowserDialog.SelectedPath = Directory.GetCurrentDirectory();
            //Display the "Create a new folder" button.
            folderBrowserDialog.ShowNewFolderButton = true;
            //Display a dialog to select a folder.
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                InputPathTextBox.Text = folderPath;
                InputFolderNameLabel.Text = StringTransformProcess.TransformInputFolderLabel(Path.GetFileName(folderPath));
            }
        }


        /// <summary>
        /// Change the output box by the browse button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutputPathBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //Dialog description.
            folderBrowserDialog.Description = "フォルダを選択してください。";
            //Specifying the default folder.
            folderBrowserDialog.SelectedPath = Directory.GetCurrentDirectory();
            //Display the "Create a new folder" button.
            folderBrowserDialog.ShowNewFolderButton = true;
            //Display a dialog to select a folder.
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                OutputPathTextBox.Text = folderPath;
                OutputFolderNameLabel.Text = StringTransformProcess.TransformOutputFolderLabel(Path.GetFileName(folderPath));
            }
        }


        /// <summary>
        /// The Operation of D&D to OutputPathTextBox. 
        /// 1. Reset textbox.
        /// 2. Write textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutputPathTextBox_DragDrop(object sender, DragEventArgs e)
        {
            //1. Reset textbox.
            OutputPathTextBox.ResetText();

            //2. Write textbox.
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string folderPath = files[0];
            OutputPathTextBox.Text = folderPath;
            OutputFolderNameLabel.Text = StringTransformProcess.TransformInputFolderLabel(Path.GetFileName(folderPath));
        }


        /// <summary>
        /// The Effect of OutputPathTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutputPathTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}
