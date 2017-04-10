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

namespace CCHSSmokeTest.Recordings.Entity_Testing
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MemberSearchEntity recording.
    /// </summary>
    [TestModule("16ff6013-30be-4ff6-be7d-a7e6bae108a9", ModuleType.Recording, 1)]
    public partial class MemberSearchEntity : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSMOKTEST.SMOKTEST_SKRepository repository.
        /// </summary>
        public static CCHSSMOKTEST.SMOKTEST_SKRepository repo = CCHSSMOKTEST.SMOKTEST_SKRepository.Instance;

        static MemberSearchEntity instance = new MemberSearchEntity();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MemberSearchEntity()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MemberSearchEntity Instance
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(0));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Sidebars.Click_on_Members_Side_Menu_Item' at 29;7.", repo.LoginCCHSPortal.Sidebars.Click_on_Members_Side_Menu_ItemInfo, new RecordItemIndex(1));
            repo.LoginCCHSPortal.Sidebars.Click_on_Members_Side_Menu_Item.Click("29;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Sidebars.Click_On_Search_Menu_Item' at 52;7.", repo.LoginCCHSPortal.Sidebars.Click_On_Search_Menu_ItemInfo, new RecordItemIndex(2));
            repo.LoginCCHSPortal.Sidebars.Click_On_Search_Menu_Item.Click("52;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstName' at 94;17.", repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstNameInfo, new RecordItemIndex(3));
            repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstName.Click("94;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'orgtest' with focus on 'LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstName'.", repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstNameInfo, new RecordItemIndex(4));
            repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.FirstName.PressKeys("orgtest");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Member_Demographics.Member_Search_Results.Search_Button' at 30;13.", repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.Search_ButtonInfo, new RecordItemIndex(5));
            repo.LoginCCHSPortal.Member_Demographics.Member_Search_Results.Search_Button.Click("30;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(6));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}