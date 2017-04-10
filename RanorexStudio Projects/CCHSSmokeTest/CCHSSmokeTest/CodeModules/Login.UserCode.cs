﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
// 
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace CCHSSmokeTest.CodeModules
{
    public partial class Login
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_LoginBtn(RepoItemInfo buttontagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'buttontagInfo' at 199;17.", buttontagInfo);
            buttontagInfo.FindAdapter<ButtonTag>().Click("199;17");
        }

        public void Key_Sequence_Password(RepoItemInfo inputtagInfo)
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '$Password' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys(Password);
        }

        public void Mouse_Click_Password(RepoItemInfo inputtagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo' at 53;20.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().Click("53;20");
        }

        public void Key_Sequence_Email(RepoItemInfo inputtagInfo)
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LoginEmail' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().PressKeys(LoginEmail);
        }

        public void Mouse_Click_Email(RepoItemInfo inputtagInfo)
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'inputtagInfo' at 34;16.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().Click("34;16");
        }

        public void DoDelay()
        {
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.");
            Delay.Duration(4000, false);
        }
    }
}