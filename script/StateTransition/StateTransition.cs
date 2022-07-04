using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRCPhotoArrange.StateTransition
{
    /// <summary>
    /// State transition when analyzing.
    /// </summary>
    class AnalysisStateTransition
    {
        private bool _initState = true;
        private bool _standbyState = false;
        private bool _analysisState = false;
        private bool _waitForAnalysisMessageresponseState = false;
        private bool _copingState = false;
        private bool _waitForCopymessageResponseState = false;
        
        public bool InitState
        {
            set { _initState = value; }
            get { return _initState; }
        }

        public bool StandbyState
        {
            set { _standbyState = value; }
            get { return _standbyState; }
        }

        public bool AnalysisState
        {
            set { _analysisState = value; }
            get { return _analysisState; }
        }

        public bool WaitForAnalysisMessageResponseState
        {
            set { _waitForAnalysisMessageresponseState = value; }
            get { return _waitForAnalysisMessageresponseState; }
        }

        public bool CopingState
        {
            set { _copingState = value; }
            get { return _copingState; }
        }

        public bool WaitForCopyMessageResponseState
        {
            set { _waitForCopymessageResponseState = value; }
            get { return _waitForCopymessageResponseState; }
        }


        public string OutputState()
        {
            if (InitState && !StandbyState && !AnalysisState && !WaitForAnalysisMessageResponseState && !CopingState && !WaitForCopyMessageResponseState)
            { return "定期VRCイベントを選択してください。"; }
            else if(!InitState && StandbyState && !AnalysisState && !WaitForAnalysisMessageResponseState && !CopingState && !WaitForCopyMessageResponseState)
            { return "開始ボタンを押してください。"; }
            else if (!InitState && !StandbyState && AnalysisState && !WaitForAnalysisMessageResponseState && !CopingState && !WaitForCopyMessageResponseState)
            { return "解析中..."; }
            else if (!InitState && !StandbyState && !AnalysisState && WaitForAnalysisMessageResponseState && !CopingState && !WaitForCopyMessageResponseState)
            { return "解析終了！"; }
            else if (!InitState && !StandbyState && !AnalysisState && !WaitForAnalysisMessageResponseState && CopingState && !WaitForCopyMessageResponseState)
            { return "コピー中..."; }
            else if (!InitState && !StandbyState && !AnalysisState && !WaitForAnalysisMessageResponseState && !CopingState && WaitForCopyMessageResponseState)
            { return "コピー終了！"; }
            else { throw new InvalidOperationException(); }
        }
    }
}
