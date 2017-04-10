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

namespace CCHSSMOKTEST
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EditHealthTracker recording.
    /// </summary>
    [TestModule("d19c6c8d-d6f5-4906-ad98-f01e96a585a0", ModuleType.Recording, 1)]
    public partial class EditHealthTracker : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SMOKTEST_SKRepository repository.
        /// </summary>
        public static SMOKTEST_SKRepository repo = SMOKTEST_SKRepository.Instance;

        static EditHealthTracker instance = new EditHealthTracker();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditHealthTracker()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditHealthTracker Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Forms.SomeDivTag.Click_on_Globe_Icon_HT_Name_' at 6;14.", repo.LoginCCHSPortal.Forms.SomeDivTag.Click_on_Globe_Icon_HT_Name_Info, new RecordItemIndex(0));
            repo.LoginCCHSPortal.Forms.SomeDivTag.Click_on_Globe_Icon_HT_Name_.Click("6;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Health_Trackers.Title_English' at 245;15.", repo.LoginCCHSPortal.Health_Trackers.Title_EnglishInfo, new RecordItemIndex(1));
            repo.LoginCCHSPortal.Health_Trackers.Title_English.Click("245;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'LoginCCHSPortal.Health_Trackers.Title_English'.", repo.LoginCCHSPortal.Health_Trackers.Title_EnglishInfo, new RecordItemIndex(2));
            Keyboard.PrepareFocus(repo.LoginCCHSPortal.Health_Trackers.Title_English);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'LoginCCHSPortal.Health_Trackers.Title_English'.", repo.LoginCCHSPortal.Health_Trackers.Title_EnglishInfo, new RecordItemIndex(3));
            repo.LoginCCHSPortal.Health_Trackers.Title_English.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '3451 Health Tracker Test' with focus on 'LoginCCHSPortal.Health_Trackers.Title_English'.", repo.LoginCCHSPortal.Health_Trackers.Title_EnglishInfo, new RecordItemIndex(4));
            repo.LoginCCHSPortal.Health_Trackers.Title_English.PressKeys("3451 Health Tracker Test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Forms.SomeDivTag.Click_on_Globe_Icon_HT_Name_' at 5;8.", repo.LoginCCHSPortal.Forms.SomeDivTag.Click_on_Globe_Icon_HT_Name_Info, new RecordItemIndex(5));
            repo.LoginCCHSPortal.Forms.SomeDivTag.Click_on_Globe_Icon_HT_Name_.Click("5;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute TagValue to '3595b5' on item 'LoginCCHSPortal.Health_Trackers.Select_Color_Field_'.", repo.LoginCCHSPortal.Health_Trackers.Select_Color_Field_Info, new RecordItemIndex(6));
            repo.LoginCCHSPortal.Health_Trackers.Select_Color_Field_.Element.SetAttributeValue("TagValue", "3595b5");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Member_Demographics.Save_button' at 23;12.", repo.LoginCCHSPortal.Member_Demographics.Save_buttonInfo, new RecordItemIndex(7));
            repo.LoginCCHSPortal.Member_Demographics.Save_button.Click("23;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginCCHSPortal.Create_Member.ToastToastSuccess'.", repo.LoginCCHSPortal.Create_Member.ToastToastSuccessInfo, new RecordItemIndex(8));
            Validate.Exists(repo.LoginCCHSPortal.Create_Member.ToastToastSuccessInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
