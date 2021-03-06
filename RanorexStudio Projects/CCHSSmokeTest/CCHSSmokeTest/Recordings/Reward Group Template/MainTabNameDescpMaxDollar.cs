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
    ///The MainTabNameDescpMaxDollar recording.
    /// </summary>
    [TestModule("87ba80cb-5564-44ea-ace5-3be91c319c0e", ModuleType.Recording, 1)]
    public partial class MainTabNameDescpMaxDollar : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static MainTabNameDescpMaxDollar instance = new MainTabNameDescpMaxDollar();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MainTabNameDescpMaxDollar()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MainTabNameDescpMaxDollar Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Other.TemplateTitle' at 89;9.", repo.NewOceanAdminPortal.Other.TemplateTitleInfo, new RecordItemIndex(0));
            repo.NewOceanAdminPortal.Other.TemplateTitle.Click("89;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'QA  Automation Reward Template' with focus on 'NewOceanAdminPortal.Other.TemplateTitle'.", repo.NewOceanAdminPortal.Other.TemplateTitleInfo, new RecordItemIndex(1));
            repo.NewOceanAdminPortal.Other.TemplateTitle.PressKeys("QA  Automation Reward Template");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.RewardGroupTemplates.TemplateDescription' at 73;22.", repo.NewOceanAdminPortal.RewardGroupTemplates.TemplateDescriptionInfo, new RecordItemIndex(2));
            repo.NewOceanAdminPortal.RewardGroupTemplates.TemplateDescription.Click("73;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Test' with focus on 'NewOceanAdminPortal.RewardGroupTemplates.TemplateDescription'.", repo.NewOceanAdminPortal.RewardGroupTemplates.TemplateDescriptionInfo, new RecordItemIndex(3));
            repo.NewOceanAdminPortal.RewardGroupTemplates.TemplateDescription.PressKeys("Test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.RewardGroupTemplates.MaxDollarAmount' at 49;18.", repo.NewOceanAdminPortal.RewardGroupTemplates.MaxDollarAmountInfo, new RecordItemIndex(4));
            repo.NewOceanAdminPortal.RewardGroupTemplates.MaxDollarAmount.Click("49;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '100' with focus on 'NewOceanAdminPortal.RewardGroupTemplates.MaxDollarAmount'.", repo.NewOceanAdminPortal.RewardGroupTemplates.MaxDollarAmountInfo, new RecordItemIndex(5));
            repo.NewOceanAdminPortal.RewardGroupTemplates.MaxDollarAmount.PressKeys("100");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
