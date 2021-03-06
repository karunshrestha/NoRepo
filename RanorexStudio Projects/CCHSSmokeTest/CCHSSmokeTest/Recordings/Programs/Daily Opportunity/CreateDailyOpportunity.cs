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

namespace CCHSSmokeTest.Recordings.Programs.Daily_Opportunity
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CreateDailyOpportunity recording.
    /// </summary>
    [TestModule("da23e0cb-8b4b-43bb-8d1d-02e61ee47b5d", ModuleType.Recording, 1)]
    public partial class CreateDailyOpportunity : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static CreateDailyOpportunity instance = new CreateDailyOpportunity();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateDailyOpportunity()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CreateDailyOpportunity Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Users.New_Button' at 28;15.", repo.NewOceanAdminPortal.Users.New_ButtonInfo, new RecordItemIndex(0));
            repo.NewOceanAdminPortal.Users.New_Button.Click("28;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 7s.", new RecordItemIndex(1));
            Delay.Duration(7000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Content.TurnActive' at 15;12.", repo.NewOceanAdminPortal.Content.TurnActiveInfo, new RecordItemIndex(2));
            repo.NewOceanAdminPortal.Content.TurnActive.Click("15;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Content.Glob_Icon_1' at 4;3.", repo.NewOceanAdminPortal.Content.Glob_Icon_1Info, new RecordItemIndex(3));
            repo.NewOceanAdminPortal.Content.Glob_Icon_1.Click("4;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_En' at 24;17.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EnInfo, new RecordItemIndex(4));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_En.Click("24;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'QA  Automation DO' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_En'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EnInfo, new RecordItemIndex(5));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_En.PressKeys("QA  Automation DO");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es' at 29;18.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EsInfo, new RecordItemIndex(6));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es.Click("29;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'QA  Automation DO' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_EsInfo, new RecordItemIndex(7));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_1_Es.PressKeys("QA  Automation DO");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Content.Glob_Icon_1' at 5;5.", repo.NewOceanAdminPortal.Content.Glob_Icon_1Info, new RecordItemIndex(8));
            repo.NewOceanAdminPortal.Content.Glob_Icon_1.Click("5;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Content.Glob_Icon_2' at 6;6.", repo.NewOceanAdminPortal.Content.Glob_Icon_2Info, new RecordItemIndex(9));
            repo.NewOceanAdminPortal.Content.Glob_Icon_2.Click("6;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_2_Es' at 31;26.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_EsInfo, new RecordItemIndex(10));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_Es.Click("31;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'QA  Automation DO' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_2_Es'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_EsInfo, new RecordItemIndex(11));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_Es.PressKeys("QA  Automation DO");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.Globe_Text_Box_2_En' at 73;33.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_EnInfo, new RecordItemIndex(12));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_En.Click("73;33");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'QA  Automation DO' with focus on 'NewOceanAdminPortal.Activities.Globe_Text_Box_2_En'.", repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_EnInfo, new RecordItemIndex(13));
            repo.NewOceanAdminPortal.Activities.Globe_Text_Box_2_En.PressKeys("QA  Automation DO");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Content.Glob_Icon_2' at 3;0.", repo.NewOceanAdminPortal.Content.Glob_Icon_2Info, new RecordItemIndex(14));
            repo.NewOceanAdminPortal.Content.Glob_Icon_2.Click("3;0");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Content.Select_Focus' at 11;9.", repo.NewOceanAdminPortal.Content.Select_FocusInfo, new RecordItemIndex(15));
            repo.NewOceanAdminPortal.Content.Select_Focus.Click("11;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Content.Focus' at 31;16.", repo.NewOceanAdminPortal.Content.FocusInfo, new RecordItemIndex(16));
            repo.NewOceanAdminPortal.Content.Focus.Click("31;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Focus.Enter_Tags_Included' at 17;9.", repo.NewOceanAdminPortal.Focus.Enter_Tags_IncludedInfo, new RecordItemIndex(17));
            repo.NewOceanAdminPortal.Focus.Enter_Tags_Included.Click("17;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Content.Select_Nutrition_Focus' at 47;10.", repo.NewOceanAdminPortal.Content.Select_Nutrition_FocusInfo, new RecordItemIndex(18));
            repo.NewOceanAdminPortal.Content.Select_Nutrition_Focus.Click("47;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Focus.Close_Button_Focus' at 27;15.", repo.NewOceanAdminPortal.Focus.Close_Button_FocusInfo, new RecordItemIndex(19));
            repo.NewOceanAdminPortal.Focus.Close_Button_Focus.Click("27;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute TagValue to 'activity_icon_alcohol.png' on item 'NewOceanAdminPortal.Activities.ActivityIcon'.", repo.NewOceanAdminPortal.Activities.ActivityIconInfo, new RecordItemIndex(20));
            repo.NewOceanAdminPortal.Activities.ActivityIcon.Element.SetAttributeValue("TagValue", "activity_icon_alcohol.png");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute TagValue to 'completed_activity_icon_alcohol-2.png' on item 'NewOceanAdminPortal.Activities.ActivityCompletedIcon'.", repo.NewOceanAdminPortal.Activities.ActivityCompletedIconInfo, new RecordItemIndex(21));
            repo.NewOceanAdminPortal.Activities.ActivityCompletedIcon.Element.SetAttributeValue("TagValue", "completed_activity_icon_alcohol-2.png");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute TagValue to 'EFC75E' on item 'NewOceanAdminPortal.Activities.ActivityHeaderColor'.", repo.NewOceanAdminPortal.Activities.ActivityHeaderColorInfo, new RecordItemIndex(22));
            repo.NewOceanAdminPortal.Activities.ActivityHeaderColor.Element.SetAttributeValue("TagValue", "EFC75E");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute TagValue to 'A6A6A6' on item 'NewOceanAdminPortal.Activities.ActivityCompletedHeaderColor'.", repo.NewOceanAdminPortal.Activities.ActivityCompletedHeaderColorInfo, new RecordItemIndex(23));
            repo.NewOceanAdminPortal.Activities.ActivityCompletedHeaderColor.Element.SetAttributeValue("TagValue", "A6A6A6");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute TagValue to '1' on item 'NewOceanAdminPortal.Content.Select_Type_for_Program'.", repo.NewOceanAdminPortal.Content.Select_Type_for_ProgramInfo, new RecordItemIndex(24));
            repo.NewOceanAdminPortal.Content.Select_Type_for_Program.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Content.TypeToSearchPrograms' at 41;7.", repo.NewOceanAdminPortal.Content.TypeToSearchProgramsInfo, new RecordItemIndex(25));
            repo.NewOceanAdminPortal.Content.TypeToSearchPrograms.Click("41;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(26));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 't'.", new RecordItemIndex(27));
            Keyboard.Press("t");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(28));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}'.", new RecordItemIndex(29));
            Keyboard.Press("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(30));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(31));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(32));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Focus.Content1' at 46;24.", repo.NewOceanAdminPortal.Focus.Content1Info, new RecordItemIndex(33));
            repo.NewOceanAdminPortal.Focus.Content1.Click("46;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(34));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'NewOceanAdminPortal.Other.OpportunityBox' at 253;22.", repo.NewOceanAdminPortal.Other.OpportunityBoxInfo, new RecordItemIndex(35));
            repo.NewOceanAdminPortal.Other.OpportunityBox.MoveTo("253;22");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'NewOceanAdminPortal.Other.OpportunityBox' at 261;14.", repo.NewOceanAdminPortal.Other.OpportunityBoxInfo, new RecordItemIndex(36));
            repo.NewOceanAdminPortal.Other.OpportunityBox.MoveTo("261;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'NewOceanAdminPortal.Other.Drag_New_Items_Here' at 253;22.", repo.NewOceanAdminPortal.Other.Drag_New_Items_HereInfo, new RecordItemIndex(37));
            repo.NewOceanAdminPortal.Other.Drag_New_Items_Here.MoveTo("253;22");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(38));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Other.Checkbox_Select_Daily_Opp' at 4;6.", repo.NewOceanAdminPortal.Other.Checkbox_Select_Daily_OppInfo, new RecordItemIndex(39));
            repo.NewOceanAdminPortal.Other.Checkbox_Select_Daily_Opp.Click("4;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Other.ModalClose' at 26;8.", repo.NewOceanAdminPortal.Other.ModalCloseInfo, new RecordItemIndex(40));
            repo.NewOceanAdminPortal.Other.ModalClose.Click("26;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.Save' at 29;14.", repo.NewOceanAdminPortal.Member.SaveInfo, new RecordItemIndex(41));
            repo.NewOceanAdminPortal.Member.Save.Click("29;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=' The changes have been successfully saved.') on item 'NewOceanAdminPortal.Validations.DivTagTheChangesHaveBeenSuccessfull'.", repo.NewOceanAdminPortal.Validations.DivTagTheChangesHaveBeenSuccessfullInfo, new RecordItemIndex(42));
            Validate.Attribute(repo.NewOceanAdminPortal.Validations.DivTagTheChangesHaveBeenSuccessfullInfo, "InnerText", " The changes have been successfully saved.");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
