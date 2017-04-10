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

namespace CCHSSmokeTest.Recordings.Activities
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddActivity recording.
    /// </summary>
    [TestModule("01986fd2-63e7-46ab-b497-291729e8fe70", ModuleType.Recording, 1)]
    public partial class AddActivity : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static AddActivity instance = new AddActivity();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddActivity()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddActivity Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.AddActivityNewButton' at 22;8.", repo.NewOceanAdminPortal.Activities.AddActivityNewButtonInfo, new RecordItemIndex(0));
            repo.NewOceanAdminPortal.Activities.AddActivityNewButton.Click("22;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(1));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.ActiveYes' at Center.", repo.NewOceanAdminPortal.Activities.ActiveYesInfo, new RecordItemIndex(2));
            repo.NewOceanAdminPortal.Activities.ActiveYes.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.DisplayName' at 92;20.", repo.NewOceanAdminPortal.Activities.DisplayNameInfo, new RecordItemIndex(3));
            repo.NewOceanAdminPortal.Activities.DisplayName.Click("92;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '12345 Auto' with focus on 'NewOceanAdminPortal.Activities.DisplayName'.", repo.NewOceanAdminPortal.Activities.DisplayNameInfo, new RecordItemIndex(4));
            repo.NewOceanAdminPortal.Activities.DisplayName.PressKeys("12345 Auto");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge' at 6;4.", repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLargeInfo, new RecordItemIndex(5));
            repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge.Click("6;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_En' at 71;13.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EnInfo, new RecordItemIndex(6));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_En.Click("71;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_En'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EnInfo, new RecordItemIndex(7));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_En.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es' at 62;17.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EsInfo, new RecordItemIndex(8));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es.Click("62;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EsInfo, new RecordItemIndex(9));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge' at 4;5.", repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLargeInfo, new RecordItemIndex(10));
            repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge.Click("4;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge1' at 6;5.", repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge1Info, new RecordItemIndex(11));
            repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge1.Click("6;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_En' at 64;21.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EnInfo, new RecordItemIndex(12));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_En.Click("64;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_En'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EnInfo, new RecordItemIndex(13));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_En.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es' at 54;17.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EsInfo, new RecordItemIndex(14));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es.Click("54;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EsInfo, new RecordItemIndex(15));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge1' at 5;6.", repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge1Info, new RecordItemIndex(16));
            repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge1.Click("5;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge2' at 6;3.", repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge2Info, new RecordItemIndex(17));
            repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge2.Click("6;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_2_Es' at 63;30.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_EsInfo, new RecordItemIndex(18));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_Es.Click("63;30");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_2_Es'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_EsInfo, new RecordItemIndex(19));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_Es.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_2_En' at 40;36.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_EnInfo, new RecordItemIndex(20));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_En.Click("40;36");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_2_En'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_EnInfo, new RecordItemIndex(21));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_En.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge2' at 5;5.", repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge2Info, new RecordItemIndex(22));
            repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge2.Click("5;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge3' at 9;6.", repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge3Info, new RecordItemIndex(23));
            repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge3.Click("9;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_2_Es' at 51;28.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_EsInfo, new RecordItemIndex(24));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_Es.Click("51;28");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_2_Es'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_EsInfo, new RecordItemIndex(25));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_Es.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_2_En' at 37;28.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_EnInfo, new RecordItemIndex(26));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_En.Click("37;28");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_2_En'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_EnInfo, new RecordItemIndex(27));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_En.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge3' at 8;3.", repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge3Info, new RecordItemIndex(28));
            repo.NewOceanAdminPortal.SystemComObject.IconIconGlobeIconLarge3.Click("8;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute TagValue to 'activity_icon_alcohol.png' on item 'NewOceanAdminPortal.Activities.ActivityIcon'.", repo.NewOceanAdminPortal.Activities.ActivityIconInfo, new RecordItemIndex(29));
            repo.NewOceanAdminPortal.Activities.ActivityIcon.Element.SetAttributeValue("TagValue", "activity_icon_alcohol.png");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute TagValue to 'completed_activity_icon_alcohol.png' on item 'NewOceanAdminPortal.Activities.ActivityCompletedIcon'.", repo.NewOceanAdminPortal.Activities.ActivityCompletedIconInfo, new RecordItemIndex(30));
            repo.NewOceanAdminPortal.Activities.ActivityCompletedIcon.Element.SetAttributeValue("TagValue", "completed_activity_icon_alcohol.png");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute TagValue to '050_Ab%20Attack.jpg' on item 'NewOceanAdminPortal.SystemComObject.ActivityPicture'.", repo.NewOceanAdminPortal.SystemComObject.ActivityPictureInfo, new RecordItemIndex(31));
            repo.NewOceanAdminPortal.SystemComObject.ActivityPicture.Element.SetAttributeValue("TagValue", "050_Ab%20Attack.jpg");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute TagValue to 'EFC75E' on item 'NewOceanAdminPortal.Activities.ActivityHeaderColor'.", repo.NewOceanAdminPortal.Activities.ActivityHeaderColorInfo, new RecordItemIndex(32));
            repo.NewOceanAdminPortal.Activities.ActivityHeaderColor.Element.SetAttributeValue("TagValue", "EFC75E");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute TagValue to 'A6A6A6' on item 'NewOceanAdminPortal.Activities.ActivityCompletedHeaderColor'.", repo.NewOceanAdminPortal.Activities.ActivityCompletedHeaderColorInfo, new RecordItemIndex(33));
            repo.NewOceanAdminPortal.Activities.ActivityCompletedHeaderColor.Element.SetAttributeValue("TagValue", "A6A6A6");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.SystemComObject.ButtonTagSelectAnInstructionalVideo' at 752;14.", repo.NewOceanAdminPortal.SystemComObject.ButtonTagSelectAnInstructionalVideoInfo, new RecordItemIndex(34));
            repo.NewOceanAdminPortal.SystemComObject.ButtonTagSelectAnInstructionalVideo.Click("752;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(35));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}'.", new RecordItemIndex(36));
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(37));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}'.", new RecordItemIndex(38));
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(39));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(40));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(41));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.SystemComObject.SelectForm' at 2;1.", repo.NewOceanAdminPortal.SystemComObject.SelectFormInfo, new RecordItemIndex(42));
            repo.NewOceanAdminPortal.SystemComObject.SelectForm.Click("2;1");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(43));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}'.", new RecordItemIndex(44));
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}'.", new RecordItemIndex(45));
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}'.", new RecordItemIndex(46));
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}'.", new RecordItemIndex(47));
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(48));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(49));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.Save' at 25;11.", repo.NewOceanAdminPortal.Member.SaveInfo, new RecordItemIndex(50));
            repo.NewOceanAdminPortal.Member.Save.Click("25;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=' The changes have been successfully saved.') on item 'NewOceanAdminPortal.Validations.DivTagTheChangesHaveBeenSuccessfull'.", repo.NewOceanAdminPortal.Validations.DivTagTheChangesHaveBeenSuccessfullInfo, new RecordItemIndex(51));
            Validate.Attribute(repo.NewOceanAdminPortal.Validations.DivTagTheChangesHaveBeenSuccessfullInfo, "InnerText", " The changes have been successfully saved.");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}