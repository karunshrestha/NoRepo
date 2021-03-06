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

namespace CCHSSmokeTest.Recordings.Reward_Group_Template
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Level recording.
    /// </summary>
    [TestModule("12111b15-9a3a-4a9b-914d-c5f7c31c4b4d", ModuleType.Recording, 1)]
    public partial class Level : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static Level instance = new Level();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Level()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Level Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.RewardGroupTemplates.Level' at 32;14.", repo.NewOceanAdminPortal.RewardGroupTemplates.LevelInfo, new RecordItemIndex(0));
            repo.NewOceanAdminPortal.RewardGroupTemplates.Level.Click("32;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.RewardGroupTemplates.NewLevel' at 48;11.", repo.NewOceanAdminPortal.RewardGroupTemplates.NewLevelInfo, new RecordItemIndex(1));
            repo.NewOceanAdminPortal.RewardGroupTemplates.NewLevel.Click("48;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.RewardGroupTemplates.GlobeIconRewardsLevel' at 4;3.", repo.NewOceanAdminPortal.RewardGroupTemplates.GlobeIconRewardsLevelInfo, new RecordItemIndex(2));
            repo.NewOceanAdminPortal.RewardGroupTemplates.GlobeIconRewardsLevel.Click("4;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_En' at 69;20.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EnInfo, new RecordItemIndex(3));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_En.Click("69;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Label 1' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_En'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EnInfo, new RecordItemIndex(4));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_En.PressKeys("Label 1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es' at 61;15.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EsInfo, new RecordItemIndex(5));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es.Click("61;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EsInfo, new RecordItemIndex(6));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.RewardGroupTemplates.GlobeIconRewardsLevel' at 4;5.", repo.NewOceanAdminPortal.RewardGroupTemplates.GlobeIconRewardsLevelInfo, new RecordItemIndex(7));
            repo.NewOceanAdminPortal.RewardGroupTemplates.GlobeIconRewardsLevel.Click("4;5");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
