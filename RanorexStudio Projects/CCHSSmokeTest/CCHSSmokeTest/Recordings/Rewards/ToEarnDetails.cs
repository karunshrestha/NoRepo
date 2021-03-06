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

namespace CCHSSmokeTest.Recordings.Rewards
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ToEarnDetails recording.
    /// </summary>
    [TestModule("c2cb50c7-804f-4670-b1e9-561fdc4e3b94", ModuleType.Recording, 1)]
    public partial class ToEarnDetails : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static ToEarnDetails instance = new ToEarnDetails();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ToEarnDetails()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ToEarnDetails Instance
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

            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'NewOceanAdminPortal.Condition.ButtonTagEdit' at 35;13.", repo.NewOceanAdminPortal.Condition.ButtonTagEditInfo, new RecordItemIndex(0));
                repo.NewOceanAdminPortal.Condition.ButtonTagEdit.Click("35;13");
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 8s.", new RecordItemIndex(1));
            Delay.Duration(8000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.IconIconGlobeIconLarge' at 8;7.", repo.NewOceanAdminPortal.IconIconGlobeIconLargeInfo, new RecordItemIndex(2));
            repo.NewOceanAdminPortal.IconIconGlobeIconLarge.Click("8;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_En' at 51;21.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EnInfo, new RecordItemIndex(3));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_En.Click("51;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Self Reported' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_En'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EnInfo, new RecordItemIndex(4));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_En.PressKeys("Self Reported");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es' at 36;16.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EsInfo, new RecordItemIndex(5));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es.Click("36;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EsInfo, new RecordItemIndex(6));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.IconIconGlobeIconLarge' at 6;5.", repo.NewOceanAdminPortal.IconIconGlobeIconLargeInfo, new RecordItemIndex(7));
            repo.NewOceanAdminPortal.IconIconGlobeIconLarge.Click("6;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Condition.IconIconGlobeIconLarge1' at 7;4.", repo.NewOceanAdminPortal.Condition.IconIconGlobeIconLarge1Info, new RecordItemIndex(8));
            repo.NewOceanAdminPortal.Condition.IconIconGlobeIconLarge1.Click("7;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_En' at 56;17.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EnInfo, new RecordItemIndex(9));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_En.Click("56;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Self Reported' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_En'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EnInfo, new RecordItemIndex(10));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_En.PressKeys("Self Reported");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es' at 47;20.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EsInfo, new RecordItemIndex(11));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es.Click("47;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Test' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EsInfo, new RecordItemIndex(12));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es.PressKeys("Test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Condition.IconIconGlobeIconLarge1' at 11;5.", repo.NewOceanAdminPortal.Condition.IconIconGlobeIconLarge1Info, new RecordItemIndex(13));
            repo.NewOceanAdminPortal.Condition.IconIconGlobeIconLarge1.Click("11;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Condition.ButtonTagSelectAnActivity' at 926;12.", repo.NewOceanAdminPortal.Condition.ButtonTagSelectAnActivityInfo, new RecordItemIndex(14));
            repo.NewOceanAdminPortal.Condition.ButtonTagSelectAnActivity.Click("926;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Condition.Text2' at 55;11.", repo.NewOceanAdminPortal.Condition.Text2Info, new RecordItemIndex(15));
            repo.NewOceanAdminPortal.Condition.Text2.Click("55;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'weight' with focus on 'NewOceanAdminPortal.Condition.Text2'.", repo.NewOceanAdminPortal.Condition.Text2Info, new RecordItemIndex(16));
            repo.NewOceanAdminPortal.Condition.Text2.PressKeys("weight");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(17));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Condition.Unconfigured' at 30;8.", repo.NewOceanAdminPortal.Condition.UnconfiguredInfo, new RecordItemIndex(18));
            repo.NewOceanAdminPortal.Condition.Unconfigured.Click("30;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Challenges.PleaseSelectFrequencyDropDown' at 125;5.", repo.NewOceanAdminPortal.Challenges.PleaseSelectFrequencyDropDownInfo, new RecordItemIndex(19));
            repo.NewOceanAdminPortal.Challenges.PleaseSelectFrequencyDropDown.Click("125;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.SystemComObject.KoUnique16' at 6;6.", repo.NewOceanAdminPortal.SystemComObject.KoUnique16Info, new RecordItemIndex(20));
            repo.NewOceanAdminPortal.SystemComObject.KoUnique16.Click("6;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Challenges.Close' at 14;10.", repo.NewOceanAdminPortal.Challenges.CloseInfo, new RecordItemIndex(21));
            repo.NewOceanAdminPortal.Challenges.Close.Click("14;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(22));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}{Tab}{Tab}{Tab}'.", new RecordItemIndex(23));
            Keyboard.Press("{Tab}{Tab}{Tab}{Tab}{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(24));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Condition.ButtonTagClose' at 40;16.", repo.NewOceanAdminPortal.Condition.ButtonTagCloseInfo, new RecordItemIndex(25));
            repo.NewOceanAdminPortal.Condition.ButtonTagClose.Click("40;16");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
