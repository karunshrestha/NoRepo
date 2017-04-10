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
    ///The Activities recording.
    /// </summary>
    [TestModule("1686836e-35c1-4701-968c-3b768a27dcea", ModuleType.Recording, 1)]
    public partial class Activities : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSMOKTEST.SMOKTEST_SKRepository repository.
        /// </summary>
        public static CCHSSMOKTEST.SMOKTEST_SKRepository repo = CCHSSMOKTEST.SMOKTEST_SKRepository.Instance;

        static Activities instance = new Activities();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Activities()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Activities Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Activities' at 71;9.", repo.LoginCCHSPortal.ActivitiesInfo, new RecordItemIndex(0));
            repo.LoginCCHSPortal.Activities.Click("71;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Health_Trackers.Search_HT_' at 244;27.", repo.LoginCCHSPortal.Health_Trackers.Search_HT_Info, new RecordItemIndex(2));
            repo.LoginCCHSPortal.Health_Trackers.Search_HT_.Click("244;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1Orgtest' with focus on 'LoginCCHSPortal.Health_Trackers.Search_HT_'.", repo.LoginCCHSPortal.Health_Trackers.Search_HT_Info, new RecordItemIndex(3));
            repo.LoginCCHSPortal.Health_Trackers.Search_HT_.PressKeys("1Orgtest");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
