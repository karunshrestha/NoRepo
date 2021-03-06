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
    ///The Add_Form recording.
    /// </summary>
    [TestModule("0c603577-54f2-4495-90e6-377d716b885c", ModuleType.Recording, 1)]
    public partial class Add_Form : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSMOKTEST.SMOKTEST_SKRepository repository.
        /// </summary>
        public static CCHSSMOKTEST.SMOKTEST_SKRepository repo = CCHSSMOKTEST.SMOKTEST_SKRepository.Instance;

        static Add_Form instance = new Add_Form();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Add_Form()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Add_Form Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.AddActivity' at 27;4.", repo.LoginCCHSPortal.AddActivityInfo, new RecordItemIndex(0));
            repo.LoginCCHSPortal.AddActivity.Click("27;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(1));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Forms.SomeDivTag.Active_Yes_Button' at 26;20.", repo.LoginCCHSPortal.Forms.SomeDivTag.Active_Yes_ButtonInfo, new RecordItemIndex(2));
            repo.LoginCCHSPortal.Forms.SomeDivTag.Active_Yes_Button.Click("26;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Forms.FormName' at 81;19.", repo.LoginCCHSPortal.Forms.FormNameInfo, new RecordItemIndex(3));
            repo.LoginCCHSPortal.Forms.FormName.Click("81;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'QA Test Form' with focus on 'LoginCCHSPortal.Forms.FormName'.", repo.LoginCCHSPortal.Forms.FormNameInfo, new RecordItemIndex(4));
            repo.LoginCCHSPortal.Forms.FormName.PressKeys("QA Test Form");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Forms.SomeDivTag.Form_URL' at 72;22.", repo.LoginCCHSPortal.Forms.SomeDivTag.Form_URLInfo, new RecordItemIndex(5));
            repo.LoginCCHSPortal.Forms.SomeDivTag.Form_URL.Click("72;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'TestForm.com' with focus on 'LoginCCHSPortal.Forms.SomeDivTag.Form_URL'.", repo.LoginCCHSPortal.Forms.SomeDivTag.Form_URLInfo, new RecordItemIndex(6));
            repo.LoginCCHSPortal.Forms.SomeDivTag.Form_URL.PressKeys("TestForm.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Member_Demographics.Save_button' at 27;17.", repo.LoginCCHSPortal.Member_Demographics.Save_buttonInfo, new RecordItemIndex(7));
            repo.LoginCCHSPortal.Member_Demographics.Save_button.Click("27;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginCCHSPortal.Forms.Toast_Message'.", repo.LoginCCHSPortal.Forms.Toast_MessageInfo, new RecordItemIndex(8));
            Validate.Exists(repo.LoginCCHSPortal.Forms.Toast_MessageInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 6s.", new RecordItemIndex(9));
            Delay.Duration(6000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
