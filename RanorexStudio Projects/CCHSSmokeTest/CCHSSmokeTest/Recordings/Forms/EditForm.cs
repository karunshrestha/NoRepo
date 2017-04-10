﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace CCHSSmokeTest.Recordings.Forms
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EditForm recording.
    /// </summary>
    [TestModule("8f1c3840-7e07-4066-832b-b9531a3fbcad", ModuleType.Recording, 1)]
    public partial class EditForm : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSMOKTEST.SMOKTEST_SKRepository repository.
        /// </summary>
        public static CCHSSMOKTEST.SMOKTEST_SKRepository repo = CCHSSMOKTEST.SMOKTEST_SKRepository.Instance;

        static EditForm instance = new EditForm();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditForm()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditForm Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Forms.FormName' at 174;26.", repo.LoginCCHSPortal.Forms.FormNameInfo, new RecordItemIndex(0));
            repo.LoginCCHSPortal.Forms.FormName.Click("174;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'LoginCCHSPortal.Forms.FormName'.", repo.LoginCCHSPortal.Forms.FormNameInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.LoginCCHSPortal.Forms.FormName);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'LoginCCHSPortal.Forms.FormName'.", repo.LoginCCHSPortal.Forms.FormNameInfo, new RecordItemIndex(2));
            repo.LoginCCHSPortal.Forms.FormName.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '124Test Form' with focus on 'LoginCCHSPortal.Forms.FormName'.", repo.LoginCCHSPortal.Forms.FormNameInfo, new RecordItemIndex(3));
            repo.LoginCCHSPortal.Forms.FormName.PressKeys("124Test Form");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'LoginCCHSPortal.Forms.FormName'.", repo.LoginCCHSPortal.Forms.FormNameInfo, new RecordItemIndex(4));
            repo.LoginCCHSPortal.Forms.FormName.PressKeys("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Member_Demographics.Save_button' at 29;12.", repo.LoginCCHSPortal.Member_Demographics.Save_buttonInfo, new RecordItemIndex(5));
            repo.LoginCCHSPortal.Member_Demographics.Save_button.Click("29;12");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'LoginCCHSPortal.Member_Demographics.Toast_Message'.", repo.LoginCCHSPortal.Member_Demographics.Toast_MessageInfo, new RecordItemIndex(6));
                Validate.Exists(repo.LoginCCHSPortal.Member_Demographics.Toast_MessageInfo, Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 6s.", new RecordItemIndex(7));
            Delay.Duration(6000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}