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
    ///The MemberSearchNeg recording.
    /// </summary>
    [TestModule("72b85c73-396a-4fb9-8c4a-e961aca0fd4f", ModuleType.Recording, 1)]
    public partial class MemberSearchNeg : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static MemberSearchNeg instance = new MemberSearchNeg();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MemberSearchNeg()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MemberSearchNeg Instance
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

            // All Fields blank search
            Report.Log(ReportLevel.Info, "Section", "All Fields blank search", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.SearchButton' at 31;14.", repo.NewOceanAdminPortal.Member.SearchButtonInfo, new RecordItemIndex(1));
            repo.NewOceanAdminPortal.Member.SearchButton.Click("31;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(2));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>' Please enter at least one search criteria') on item 'NewOceanAdminPortal.Alert'.", repo.NewOceanAdminPortal.AlertInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.NewOceanAdminPortal.AlertInfo, "InnerText", new Regex(Regex.Escape(" Please enter at least one search criteria")));
            Delay.Milliseconds(100);
            
            // Search FN = Non-existing
            Report.Log(ReportLevel.Info, "Section", "Search FN = Non-existing", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.FirstName' at 37;17.", repo.NewOceanAdminPortal.Member.FirstNameInfo, new RecordItemIndex(5));
            repo.NewOceanAdminPortal.Member.FirstName.Click("37;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'zz11' with focus on 'NewOceanAdminPortal.Member.FirstName'.", repo.NewOceanAdminPortal.Member.FirstNameInfo, new RecordItemIndex(6));
            repo.NewOceanAdminPortal.Member.FirstName.PressKeys("zz11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.SearchButton' at 26;13.", repo.NewOceanAdminPortal.Member.SearchButtonInfo, new RecordItemIndex(7));
            repo.NewOceanAdminPortal.Member.SearchButton.Click("26;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(8));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>' No members were found with the given criteria') on item 'NewOceanAdminPortal.Alert'.", repo.NewOceanAdminPortal.AlertInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.NewOceanAdminPortal.AlertInfo, "InnerText", new Regex(Regex.Escape(" No members were found with the given criteria")));
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.FirstName' at 115;18.", repo.NewOceanAdminPortal.Member.FirstNameInfo, new RecordItemIndex(10));
            repo.NewOceanAdminPortal.Member.FirstName.Click("115;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'NewOceanAdminPortal.Member.FirstName'.", repo.NewOceanAdminPortal.Member.FirstNameInfo, new RecordItemIndex(11));
            Keyboard.PrepareFocus(repo.NewOceanAdminPortal.Member.FirstName);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'NewOceanAdminPortal.Member.FirstName'.", repo.NewOceanAdminPortal.Member.FirstNameInfo, new RecordItemIndex(12));
            repo.NewOceanAdminPortal.Member.FirstName.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            // Search LN = Non-existing
            Report.Log(ReportLevel.Info, "Section", "Search LN = Non-existing", new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.LastName' at 56;19.", repo.NewOceanAdminPortal.Member.LastNameInfo, new RecordItemIndex(14));
            repo.NewOceanAdminPortal.Member.LastName.Click("56;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'zz11' with focus on 'NewOceanAdminPortal.Member.LastName'.", repo.NewOceanAdminPortal.Member.LastNameInfo, new RecordItemIndex(15));
            repo.NewOceanAdminPortal.Member.LastName.PressKeys("zz11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.SearchButton' at 34;9.", repo.NewOceanAdminPortal.Member.SearchButtonInfo, new RecordItemIndex(16));
            repo.NewOceanAdminPortal.Member.SearchButton.Click("34;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(17));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>' No members were found with the given criteria') on item 'NewOceanAdminPortal.Alert'.", repo.NewOceanAdminPortal.AlertInfo, new RecordItemIndex(18));
            Validate.Attribute(repo.NewOceanAdminPortal.AlertInfo, "InnerText", new Regex(Regex.Escape(" No members were found with the given criteria")));
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.LastName' at 50;20.", repo.NewOceanAdminPortal.Member.LastNameInfo, new RecordItemIndex(19));
            repo.NewOceanAdminPortal.Member.LastName.Click("50;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'NewOceanAdminPortal.Member.LastName'.", repo.NewOceanAdminPortal.Member.LastNameInfo, new RecordItemIndex(20));
            Keyboard.PrepareFocus(repo.NewOceanAdminPortal.Member.LastName);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'NewOceanAdminPortal.Member.LastName'.", repo.NewOceanAdminPortal.Member.LastNameInfo, new RecordItemIndex(21));
            repo.NewOceanAdminPortal.Member.LastName.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            // Search DOB = Future Date
            Report.Log(ReportLevel.Info, "Section", "Search DOB = Future Date", new RecordItemIndex(22));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.InputTagDob' at 46;17.", repo.NewOceanAdminPortal.InputTagDobInfo, new RecordItemIndex(23));
            repo.NewOceanAdminPortal.InputTagDob.Click("46;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1/1/2020{Return}' with focus on 'NewOceanAdminPortal.InputTagDob'.", repo.NewOceanAdminPortal.InputTagDobInfo, new RecordItemIndex(24));
            repo.NewOceanAdminPortal.InputTagDob.PressKeys("1/1/2020{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.SearchButton' at 39;20.", repo.NewOceanAdminPortal.Member.SearchButtonInfo, new RecordItemIndex(25));
            repo.NewOceanAdminPortal.Member.SearchButton.Click("39;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(26));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Date of birth must be in the past') on item 'LoginCCHSPortal.DateOfBirthMustBeInThePast'.", repo.LoginCCHSPortal.DateOfBirthMustBeInThePastInfo, new RecordItemIndex(27));
            Validate.Attribute(repo.LoginCCHSPortal.DateOfBirthMustBeInThePastInfo, "InnerText", new Regex(Regex.Escape("Date of birth must be in the past")));
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.InputTagDob' at 98;16.", repo.NewOceanAdminPortal.InputTagDobInfo, new RecordItemIndex(28));
            repo.NewOceanAdminPortal.InputTagDob.Click("98;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'NewOceanAdminPortal.InputTagDob'.", repo.NewOceanAdminPortal.InputTagDobInfo, new RecordItemIndex(29));
            Keyboard.PrepareFocus(repo.NewOceanAdminPortal.InputTagDob);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}{Return}' with focus on 'NewOceanAdminPortal.InputTagDob'.", repo.NewOceanAdminPortal.InputTagDobInfo, new RecordItemIndex(30));
            repo.NewOceanAdminPortal.InputTagDob.PressKeys("{Delete}{Return}");
            Delay.Milliseconds(0);
            
            // Activation Start Date Only
            Report.Log(ReportLevel.Info, "Section", "Activation Start Date Only", new RecordItemIndex(31));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.ActivateDtBegin' at 56;16.", repo.LoginCCHSPortal.ActivateDtBeginInfo, new RecordItemIndex(32));
            repo.LoginCCHSPortal.ActivateDtBegin.Click("56;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1/1/2017{Return}' with focus on 'LoginCCHSPortal.ActivateDtBegin'.", repo.LoginCCHSPortal.ActivateDtBeginInfo, new RecordItemIndex(33));
            repo.LoginCCHSPortal.ActivateDtBegin.PressKeys("1/1/2017{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.SearchButton' at 34;20.", repo.NewOceanAdminPortal.Member.SearchButtonInfo, new RecordItemIndex(34));
            repo.NewOceanAdminPortal.Member.SearchButton.Click("34;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(35));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Activation end date is required when activation start date is specified') on item 'LoginCCHSPortal.ActivationEndDateIsRequiredWhenAct'.", repo.LoginCCHSPortal.ActivationEndDateIsRequiredWhenActInfo, new RecordItemIndex(36));
            Validate.Attribute(repo.LoginCCHSPortal.ActivationEndDateIsRequiredWhenActInfo, "InnerText", new Regex(Regex.Escape("Activation end date is required when activation start date is specified")));
            Delay.Milliseconds(100);
            
            // Activation Start Date Greater than End Date
            Report.Log(ReportLevel.Info, "Section", "Activation Start Date Greater than End Date", new RecordItemIndex(37));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.ActivateDtEnd' at 44;17.", repo.LoginCCHSPortal.ActivateDtEndInfo, new RecordItemIndex(38));
            repo.LoginCCHSPortal.ActivateDtEnd.Click("44;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1/1/2016{Return}' with focus on 'LoginCCHSPortal.ActivateDtEnd'.", repo.LoginCCHSPortal.ActivateDtEndInfo, new RecordItemIndex(39));
            repo.LoginCCHSPortal.ActivateDtEnd.PressKeys("1/1/2016{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.SearchButton' at 33;19.", repo.NewOceanAdminPortal.Member.SearchButtonInfo, new RecordItemIndex(40));
            repo.NewOceanAdminPortal.Member.SearchButton.Click("33;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(41));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'End Date must be greater then Start date') on item 'LoginCCHSPortal.EndDateMustBeGreaterThenStartDate'.", repo.LoginCCHSPortal.EndDateMustBeGreaterThenStartDateInfo, new RecordItemIndex(42));
            Validate.Attribute(repo.LoginCCHSPortal.EndDateMustBeGreaterThenStartDateInfo, "InnerText", new Regex(Regex.Escape("End Date must be greater then Start date")));
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.ActivateDtBegin' at 93;19.", repo.LoginCCHSPortal.ActivateDtBeginInfo, new RecordItemIndex(43));
            repo.LoginCCHSPortal.ActivateDtBegin.Click("93;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}{Delete}' with focus on 'LoginCCHSPortal.ActivateDtBegin'.", repo.LoginCCHSPortal.ActivateDtBeginInfo, new RecordItemIndex(44));
            repo.LoginCCHSPortal.ActivateDtBegin.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.ActivateDtEnd' at 124;16.", repo.LoginCCHSPortal.ActivateDtEndInfo, new RecordItemIndex(45));
            repo.LoginCCHSPortal.ActivateDtEnd.Click("124;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'LoginCCHSPortal.ActivateDtEnd'.", repo.LoginCCHSPortal.ActivateDtEndInfo, new RecordItemIndex(46));
            Keyboard.PrepareFocus(repo.LoginCCHSPortal.ActivateDtEnd);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'LoginCCHSPortal.ActivateDtEnd'.", repo.LoginCCHSPortal.ActivateDtEndInfo, new RecordItemIndex(47));
            repo.LoginCCHSPortal.ActivateDtEnd.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'LoginCCHSPortal.ActivateDtEnd'.", repo.LoginCCHSPortal.ActivateDtEndInfo, new RecordItemIndex(48));
            repo.LoginCCHSPortal.ActivateDtEnd.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            // Search Invaid Email
            Report.Log(ReportLevel.Info, "Section", "Search Invaid Email", new RecordItemIndex(49));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.EmailAddress' at 87;14.", repo.NewOceanAdminPortal.Member.EmailAddressInfo, new RecordItemIndex(50));
            repo.NewOceanAdminPortal.Member.EmailAddress.Click("87;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'abc@' with focus on 'NewOceanAdminPortal.Member.EmailAddress'.", repo.NewOceanAdminPortal.Member.EmailAddressInfo, new RecordItemIndex(51));
            repo.NewOceanAdminPortal.Member.EmailAddress.PressKeys("abc@");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.SearchButton' at 32;10.", repo.NewOceanAdminPortal.Member.SearchButtonInfo, new RecordItemIndex(52));
            repo.NewOceanAdminPortal.Member.SearchButton.Click("32;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(53));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Please enter a proper email address') on item 'LoginCCHSPortal.PleaseEnterAProperEmailAddress'.", repo.LoginCCHSPortal.PleaseEnterAProperEmailAddressInfo, new RecordItemIndex(54));
            Validate.Attribute(repo.LoginCCHSPortal.PleaseEnterAProperEmailAddressInfo, "InnerText", new Regex(Regex.Escape("Please enter a proper email address")));
            Delay.Milliseconds(100);
            
            // Search Non Existing Email
            Report.Log(ReportLevel.Info, "Section", "Search Non Existing Email", new RecordItemIndex(55));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.EmailAddress' at 85;16.", repo.NewOceanAdminPortal.Member.EmailAddressInfo, new RecordItemIndex(56));
            repo.NewOceanAdminPortal.Member.EmailAddress.Click("85;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'abc.com' with focus on 'NewOceanAdminPortal.Member.EmailAddress'.", repo.NewOceanAdminPortal.Member.EmailAddressInfo, new RecordItemIndex(57));
            repo.NewOceanAdminPortal.Member.EmailAddress.PressKeys("abc.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.SearchButton' at 26;16.", repo.NewOceanAdminPortal.Member.SearchButtonInfo, new RecordItemIndex(58));
            repo.NewOceanAdminPortal.Member.SearchButton.Click("26;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.SearchButton' at 26;16.", repo.NewOceanAdminPortal.Member.SearchButtonInfo, new RecordItemIndex(59));
            repo.NewOceanAdminPortal.Member.SearchButton.Click("26;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(60));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>' No members were found with the given criteria') on item 'NewOceanAdminPortal.Alert'.", repo.NewOceanAdminPortal.AlertInfo, new RecordItemIndex(61));
            Validate.Attribute(repo.NewOceanAdminPortal.AlertInfo, "InnerText", new Regex(Regex.Escape(" No members were found with the given criteria")));
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
