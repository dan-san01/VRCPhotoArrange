namespace VRCPhotoArrange
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.RunButton = new System.Windows.Forms.Button();
            this.StartHourSelectComboBox = new System.Windows.Forms.ComboBox();
            this.StartMinuteSelectComboBox = new System.Windows.Forms.ComboBox();
            this.WeekSelectComboBox = new System.Windows.Forms.ComboBox();
            this.InputPathTextBox = new System.Windows.Forms.TextBox();
            this.InputPathBrowseButton = new System.Windows.Forms.Button();
            this.SelectRegularEventComboBox = new System.Windows.Forms.ComboBox();
            this.explanationLabel = new System.Windows.Forms.Label();
            this.explainationInputPathLabel = new System.Windows.Forms.Label();
            this.explainationOutputPathLabel = new System.Windows.Forms.Label();
            this.OutputPathTextBox = new System.Windows.Forms.TextBox();
            this.OutputPathBrowseButton = new System.Windows.Forms.Button();
            this.explainationHourLabel = new System.Windows.Forms.Label();
            this.explanationMinuteLabel = new System.Windows.Forms.Label();
            this.explanationWeekLabel = new System.Windows.Forms.Label();
            this.EndHourSelectComboBox = new System.Windows.Forms.ComboBox();
            this.EndMinuteSelectComboBox = new System.Windows.Forms.ComboBox();
            this.StateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputFolderNameLabel = new System.Windows.Forms.Label();
            this.OutputFolderNameLabel = new System.Windows.Forms.Label();
            this.CopingProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.explainationToolLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(488, 393);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(88, 24);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "開始";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // StartHourSelectComboBox
            // 
            this.StartHourSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartHourSelectComboBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.StartHourSelectComboBox.FormattingEnabled = true;
            this.StartHourSelectComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.StartHourSelectComboBox.Location = new System.Drawing.Point(253, 182);
            this.StartHourSelectComboBox.Name = "StartHourSelectComboBox";
            this.StartHourSelectComboBox.Size = new System.Drawing.Size(44, 24);
            this.StartHourSelectComboBox.TabIndex = 1;
            // 
            // StartMinuteSelectComboBox
            // 
            this.StartMinuteSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartMinuteSelectComboBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.StartMinuteSelectComboBox.FormattingEnabled = true;
            this.StartMinuteSelectComboBox.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.StartMinuteSelectComboBox.Location = new System.Drawing.Point(327, 183);
            this.StartMinuteSelectComboBox.Name = "StartMinuteSelectComboBox";
            this.StartMinuteSelectComboBox.Size = new System.Drawing.Size(44, 24);
            this.StartMinuteSelectComboBox.TabIndex = 2;
            // 
            // WeekSelectComboBox
            // 
            this.WeekSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WeekSelectComboBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.WeekSelectComboBox.FormattingEnabled = true;
            this.WeekSelectComboBox.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Everyday"});
            this.WeekSelectComboBox.Location = new System.Drawing.Point(394, 210);
            this.WeekSelectComboBox.Name = "WeekSelectComboBox";
            this.WeekSelectComboBox.Size = new System.Drawing.Size(108, 24);
            this.WeekSelectComboBox.TabIndex = 3;
            this.WeekSelectComboBox.UseWaitCursor = false;
            // 
            // InputPathTextBox
            // 
            this.InputPathTextBox.AllowDrop = true;
            this.InputPathTextBox.Location = new System.Drawing.Point(48, 60);
            this.InputPathTextBox.Name = "InputPathTextBox";
            this.InputPathTextBox.ReadOnly = true;
            this.InputPathTextBox.Size = new System.Drawing.Size(486, 19);
            this.InputPathTextBox.TabIndex = 4;
            this.InputPathTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputPathTextBox_DragDrop);
            this.InputPathTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputPathTextBox_DragEnter);
            // 
            // InputPathBrowseButton
            // 
            this.InputPathBrowseButton.Location = new System.Drawing.Point(549, 59);
            this.InputPathBrowseButton.Name = "InputPathBrowseButton";
            this.InputPathBrowseButton.Size = new System.Drawing.Size(27, 21);
            this.InputPathBrowseButton.TabIndex = 5;
            this.InputPathBrowseButton.Text = "...";
            this.InputPathBrowseButton.UseVisualStyleBackColor = true;
            this.InputPathBrowseButton.Click += new System.EventHandler(this.InputPathBrowseButton_Click);
            // 
            // SelectRegularEventComboBox
            // 
            this.SelectRegularEventComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.SelectRegularEventComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectRegularEventComboBox.FormattingEnabled = true;
            this.SelectRegularEventComboBox.Items.AddRange(new object[] {
            "手動入力",
            "VRCモーニングカフェ会"
            });
            this.SelectRegularEventComboBox.Location = new System.Drawing.Point(267, 124);
            this.SelectRegularEventComboBox.Name = "SelectRegularEventComboBox";
            this.SelectRegularEventComboBox.Size = new System.Drawing.Size(162, 20);
            this.SelectRegularEventComboBox.TabIndex = 6;
            this.SelectRegularEventComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectRegularEventComboBox_SelectedIndexChanged);
            // 
            // explanationLabel
            // 
            this.explanationLabel.AutoSize = true;
            this.explanationLabel.Location = new System.Drawing.Point(136, 127);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(113, 12);
            this.explanationLabel.TabIndex = 7;
            this.explanationLabel.Text = "定期VRCイベント選択";
            // 
            // explainationInputPathLabel
            // 
            this.explainationInputPathLabel.AutoSize = true;
            this.explainationInputPathLabel.Location = new System.Drawing.Point(46, 45);
            this.explainationInputPathLabel.Name = "explainationInputPathLabel";
            this.explainationInputPathLabel.Size = new System.Drawing.Size(83, 12);
            this.explainationInputPathLabel.TabIndex = 8;
            this.explainationInputPathLabel.Text = "入力フォルダパス";
            // 
            // explainationOutputPathLabel
            // 
            this.explainationOutputPathLabel.AutoSize = true;
            this.explainationOutputPathLabel.Location = new System.Drawing.Point(46, 310);
            this.explainationOutputPathLabel.Name = "explainationOutputPathLabel";
            this.explainationOutputPathLabel.Size = new System.Drawing.Size(83, 12);
            this.explainationOutputPathLabel.TabIndex = 9;
            this.explainationOutputPathLabel.Text = "出力フォルダパス";
            // 
            // OutputPathTextBox
            // 
            this.OutputPathTextBox.AllowDrop = true;
            this.OutputPathTextBox.Location = new System.Drawing.Point(48, 325);
            this.OutputPathTextBox.Name = "OutputPathTextBox";
            this.OutputPathTextBox.ReadOnly = true;
            this.OutputPathTextBox.Size = new System.Drawing.Size(486, 19);
            this.OutputPathTextBox.TabIndex = 10;
            this.OutputPathTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.OutputPathTextBox_DragDrop);
            this.OutputPathTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.OutputPathTextBox_DragEnter);
            // 
            // OutputPathBrowseButton
            // 
            this.OutputPathBrowseButton.Location = new System.Drawing.Point(549, 325);
            this.OutputPathBrowseButton.Name = "OutputPathBrowseButton";
            this.OutputPathBrowseButton.Size = new System.Drawing.Size(27, 21);
            this.OutputPathBrowseButton.TabIndex = 11;
            this.OutputPathBrowseButton.Text = "...";
            this.OutputPathBrowseButton.UseVisualStyleBackColor = true;
            this.OutputPathBrowseButton.Click += new System.EventHandler(this.OutputPathBrowseButton_Click);
            // 
            // explainationHourLabel
            // 
            this.explainationHourLabel.AutoSize = true;
            this.explainationHourLabel.Location = new System.Drawing.Point(265, 167);
            this.explainationHourLabel.Name = "explainationHourLabel";
            this.explainationHourLabel.Size = new System.Drawing.Size(17, 12);
            this.explainationHourLabel.TabIndex = 13;
            this.explainationHourLabel.Text = "時";
            // 
            // explanationMinuteLabel
            // 
            this.explanationMinuteLabel.AutoSize = true;
            this.explanationMinuteLabel.Location = new System.Drawing.Point(342, 167);
            this.explanationMinuteLabel.Name = "explanationMinuteLabel";
            this.explanationMinuteLabel.Size = new System.Drawing.Size(17, 12);
            this.explanationMinuteLabel.TabIndex = 14;
            this.explanationMinuteLabel.Text = "分";
            // 
            // explanationWeekLabel
            // 
            this.explanationWeekLabel.AutoSize = true;
            this.explanationWeekLabel.Location = new System.Drawing.Point(433, 194);
            this.explanationWeekLabel.Name = "explanationWeekLabel";
            this.explanationWeekLabel.Size = new System.Drawing.Size(29, 12);
            this.explanationWeekLabel.TabIndex = 15;
            this.explanationWeekLabel.Text = "曜日";
            // 
            // EndHourSelectComboBox
            // 
            this.EndHourSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndHourSelectComboBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.EndHourSelectComboBox.FormattingEnabled = true;
            this.EndHourSelectComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.EndHourSelectComboBox.Location = new System.Drawing.Point(253, 245);
            this.EndHourSelectComboBox.Name = "EndHourSelectComboBox";
            this.EndHourSelectComboBox.Size = new System.Drawing.Size(44, 24);
            this.EndHourSelectComboBox.TabIndex = 18;
            // 
            // EndMinuteSelectComboBox
            // 
            this.EndMinuteSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndMinuteSelectComboBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.EndMinuteSelectComboBox.FormattingEnabled = true;
            this.EndMinuteSelectComboBox.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.EndMinuteSelectComboBox.Location = new System.Drawing.Point(327, 245);
            this.EndMinuteSelectComboBox.Name = "EndMinuteSelectComboBox";
            this.EndMinuteSelectComboBox.Size = new System.Drawing.Size(44, 24);
            this.EndMinuteSelectComboBox.TabIndex = 19;
            // 
            // StateLabel
            // 
            this.StateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(3, 6);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StateLabel.Size = new System.Drawing.Size(184, 12);
            this.StateLabel.TabIndex = 20;
            this.StateLabel.Text = "定期VRCイベントを選択してください。";
            this.StateLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "イベント開始時刻";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "イベント終了時刻";
            // 
            // InputFolderNameLabel
            // 
            this.InputFolderNameLabel.AutoSize = true;
            this.InputFolderNameLabel.Location = new System.Drawing.Point(46, 82);
            this.InputFolderNameLabel.Name = "InputFolderNameLabel";
            this.InputFolderNameLabel.Size = new System.Drawing.Size(192, 12);
            this.InputFolderNameLabel.TabIndex = 24;
            this.InputFolderNameLabel.Text = "入力フォルダパスの入力を待っています。";
            // 
            // OutputFolderNameLabel
            // 
            this.OutputFolderNameLabel.AutoSize = true;
            this.OutputFolderNameLabel.Location = new System.Drawing.Point(46, 347);
            this.OutputFolderNameLabel.Name = "OutputFolderNameLabel";
            this.OutputFolderNameLabel.Size = new System.Drawing.Size(192, 12);
            this.OutputFolderNameLabel.TabIndex = 25;
            this.OutputFolderNameLabel.Text = "出力フォルダパスの入力を待っています。";
            // 
            // CopingProgressBar
            // 
            this.CopingProgressBar.Location = new System.Drawing.Point(48, 394);
            this.CopingProgressBar.Name = "CopingProgressBar";
            this.CopingProgressBar.Size = new System.Drawing.Size(217, 23);
            this.CopingProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.CopingProgressBar.TabIndex = 26;
            this.CopingProgressBar.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.StateLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(289, 392);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(190, 25);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // explainationToolLabel
            // 
            this.explainationToolLabel.AutoSize = true;
            this.explainationToolLabel.Location = new System.Drawing.Point(12, 9);
            this.explainationToolLabel.Name = "explainationToolLabel";
            this.explainationToolLabel.Size = new System.Drawing.Size(298, 12);
            this.explainationToolLabel.TabIndex = 28;
            this.explainationToolLabel.Text = "フォルダからVRChatイベントで撮った写真を取得するツール(仮)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.explainationToolLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CopingProgressBar);
            this.Controls.Add(this.OutputFolderNameLabel);
            this.Controls.Add(this.InputFolderNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndMinuteSelectComboBox);
            this.Controls.Add(this.EndHourSelectComboBox);
            this.Controls.Add(this.explanationWeekLabel);
            this.Controls.Add(this.explanationMinuteLabel);
            this.Controls.Add(this.explainationHourLabel);
            this.Controls.Add(this.OutputPathBrowseButton);
            this.Controls.Add(this.OutputPathTextBox);
            this.Controls.Add(this.explainationOutputPathLabel);
            this.Controls.Add(this.explainationInputPathLabel);
            this.Controls.Add(this.explanationLabel);
            this.Controls.Add(this.SelectRegularEventComboBox);
            this.Controls.Add(this.InputPathBrowseButton);
            this.Controls.Add(this.InputPathTextBox);
            this.Controls.Add(this.WeekSelectComboBox);
            this.Controls.Add(this.StartMinuteSelectComboBox);
            this.Controls.Add(this.StartHourSelectComboBox);
            this.Controls.Add(this.RunButton);
            this.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "あのときの思い出を。(仮)";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.ComboBox StartHourSelectComboBox;
        private System.Windows.Forms.ComboBox StartMinuteSelectComboBox;
        private System.Windows.Forms.ComboBox WeekSelectComboBox;
        private System.Windows.Forms.TextBox InputPathTextBox;
        private System.Windows.Forms.Button InputPathBrowseButton;
        private System.Windows.Forms.ComboBox SelectRegularEventComboBox;
        private System.Windows.Forms.Label explanationLabel;
        private System.Windows.Forms.Label explainationInputPathLabel;
        private System.Windows.Forms.Label explainationOutputPathLabel;
        private System.Windows.Forms.TextBox OutputPathTextBox;
        private System.Windows.Forms.Button OutputPathBrowseButton;
        private System.Windows.Forms.Label explainationHourLabel;
        private System.Windows.Forms.Label explanationMinuteLabel;
        private System.Windows.Forms.Label explanationWeekLabel;
        private System.Windows.Forms.ComboBox EndHourSelectComboBox;
        private System.Windows.Forms.ComboBox EndMinuteSelectComboBox;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label InputFolderNameLabel;
        private System.Windows.Forms.Label OutputFolderNameLabel;
        private System.Windows.Forms.ProgressBar CopingProgressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label explainationToolLabel;
    }
}

