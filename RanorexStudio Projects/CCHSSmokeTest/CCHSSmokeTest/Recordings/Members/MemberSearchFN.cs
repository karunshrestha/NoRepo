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

namespace CCHSSmokeTest.Recordings.Members
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MemberSearchFN recording.
    /// </summary>
    [TestModule("c0580c88-b559-4c45-ada4-7a4e7d7bcce4", ModuleType.Recording, 1)]
    public partial class MemberSearchFN : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSMOKTEST.SMOKTEST_SKRepository repository.
        /// </summary>
        public static CCHSSMOKTEST.SMOKTEST_SKRepository repo = CCHSSMOKTEST.SMOKTEST_SKRepository.Instance;

        static MemberSearchFN instance = new MemberSearchFN();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MemberSearchFN()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MemberSearchFN Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Sidebars.Click_On_Search_Menu_Item' at 68;11.", repo.LoginCCHSPortal.Sidebars.Click_On_Search_Menu_ItemInfo, new RecordItemIndex(0));
            repo.LoginCCHSPortal.Sidebars.Click_On_Search_Menu_Item.Click("68;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstName' at 244;16.", repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstNameInfo, new RecordItemIndex(1));
            repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstName.Click("244;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'John' with focus on 'LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstName'.", repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstNameInfo, new RecordItemIndex(2));
            repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstName.PressKeys("John");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Member_Demographics.Member_Search_Results.Search_Button' at 39;19.", repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.Search_ButtonInfo, new RecordItemIndex(3));
            repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.Search_Button.Click("39;19");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'LoginCCHSPortal.Member_Demographics.Member_Search_Results.Validation_FN'.", repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.Validation_FNInfo, new RecordItemIndex(4));
                Validate.Exists(repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.Validation_FNInfo, Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstName' at 244;16.", repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstNameInfo, new RecordItemIndex(5));
            repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstName.Click("244;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(7));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}'.", new RecordItemIndex(8));
            Keyboard.Press("{Delete}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
