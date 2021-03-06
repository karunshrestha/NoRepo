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
    ///The NewMember recording.
    /// </summary>
    [TestModule("75685009-13f4-4d49-aa0d-59a02918ce9a", ModuleType.Recording, 1)]
    public partial class NewMember : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SMOKTEST_SKRepository repository.
        /// </summary>
        public static SMOKTEST_SKRepository repo = SMOKTEST_SKRepository.Instance;

        static NewMember instance = new NewMember();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NewMember()
        {
            Email = "automationtest@cchs.com";
            EditEmail = "automat@xxchs.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NewMember Instance
        {
            get { return instance; }
        }

#region Variables

        string _Email;

        /// <summary>
        /// Gets or sets the value of variable Email.
        /// </summary>
        [TestVariable("5b890ec9-02da-4a06-846a-e4fb2df894e0")]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        string _EditEmail;

        /// <summary>
        /// Gets or sets the value of variable EditEmail.
        /// </summary>
        [TestVariable("1fb2b9c3-ba88-4198-a633-d29a22939c5d")]
        public string EditEmail
        {
            get { return _EditEmail; }
            set { _EditEmail = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Create_Member.New_Button' at 44;30.", repo.LoginCCHSPortal.Create_Member.New_ButtonInfo, new RecordItemIndex(0));
            repo.LoginCCHSPortal.Create_Member.New_Button.Click("44;30");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Member_Demographics.Search_Ln.FirstName' at Center.", repo.LoginCCHSPortal.Member_Demographics.Search_Ln.FirstNameInfo, new RecordItemIndex(1));
            repo.LoginCCHSPortal.Member_Demographics.Search_Ln.FirstName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Test' with focus on 'LoginCCHSPortal.Member_Demographics.Search_Ln.FirstName'.", repo.LoginCCHSPortal.Member_Demographics.Search_Ln.FirstNameInfo, new RecordItemIndex(2));
            repo.LoginCCHSPortal.Member_Demographics.Search_Ln.FirstName.PressKeys("Test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Member_Demographics.Search_Ln.LastName' at Center.", repo.LoginCCHSPortal.Member_Demographics.Search_Ln.LastNameInfo, new RecordItemIndex(3));
            repo.LoginCCHSPortal.Member_Demographics.Search_Ln.LastName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Rec' with focus on 'LoginCCHSPortal.Member_Demographics.Search_Ln.LastName'.", repo.LoginCCHSPortal.Member_Demographics.Search_Ln.LastNameInfo, new RecordItemIndex(4));
            repo.LoginCCHSPortal.Member_Demographics.Search_Ln.LastName.PressKeys("Rec");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Create_Member.Address' at Center.", repo.LoginCCHSPortal.Create_Member.AddressInfo, new RecordItemIndex(5));
            repo.LoginCCHSPortal.Create_Member.Address.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Addr1' with focus on 'LoginCCHSPortal.Create_Member.Address'.", repo.LoginCCHSPortal.Create_Member.AddressInfo, new RecordItemIndex(6));
            repo.LoginCCHSPortal.Create_Member.Address.PressKeys("Addr1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Create_Member.City' at Center.", repo.LoginCCHSPortal.Create_Member.CityInfo, new RecordItemIndex(7));
            repo.LoginCCHSPortal.Create_Member.City.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'city' with focus on 'LoginCCHSPortal.Create_Member.City'.", repo.LoginCCHSPortal.Create_Member.CityInfo, new RecordItemIndex(8));
            repo.LoginCCHSPortal.Create_Member.City.PressKeys("city");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Create_Member.State' at Center.", repo.LoginCCHSPortal.Create_Member.StateInfo, new RecordItemIndex(9));
            repo.LoginCCHSPortal.Create_Member.State.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '12345' with focus on 'LoginCCHSPortal.Create_Member.Zipcode'.", repo.LoginCCHSPortal.Create_Member.ZipcodeInfo, new RecordItemIndex(10));
            repo.LoginCCHSPortal.Create_Member.Zipcode.PressKeys("12345");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Create_Member.MemberId' at Center.", repo.LoginCCHSPortal.Create_Member.MemberIdInfo, new RecordItemIndex(11));
            repo.LoginCCHSPortal.Create_Member.MemberId.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '123' with focus on 'LoginCCHSPortal.Create_Member.MemberId'.", repo.LoginCCHSPortal.Create_Member.MemberIdInfo, new RecordItemIndex(12));
            repo.LoginCCHSPortal.Create_Member.MemberId.PressKeys("123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Email' at 182;26.", repo.LoginCCHSPortal.EmailInfo, new RecordItemIndex(13));
            repo.LoginCCHSPortal.Email.Click("182;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Email' with focus on 'LoginCCHSPortal.Email'.", repo.LoginCCHSPortal.EmailInfo, new RecordItemIndex(14));
            repo.LoginCCHSPortal.Email.PressKeys(Email);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Create_Member.Conditions' at Center.", repo.LoginCCHSPortal.Create_Member.ConditionsInfo, new RecordItemIndex(15));
            repo.LoginCCHSPortal.Create_Member.Conditions.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set Value", "Setting attribute TagValue to '1' on item 'LoginCCHSPortal.Create_Member.Conditions'.", repo.LoginCCHSPortal.Create_Member.ConditionsInfo, new RecordItemIndex(16));
            repo.LoginCCHSPortal.Create_Member.Conditions.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Member_Demographics.Save_button' at 26;16.", repo.LoginCCHSPortal.Member_Demographics.Save_buttonInfo, new RecordItemIndex(17));
            repo.LoginCCHSPortal.Member_Demographics.Save_button.Click("26;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Email' at 180;14.", repo.LoginCCHSPortal.EmailInfo, new RecordItemIndex(18));
            repo.LoginCCHSPortal.Email.Click("180;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'LoginCCHSPortal.Email'.", repo.LoginCCHSPortal.EmailInfo, new RecordItemIndex(19));
            Keyboard.PrepareFocus(repo.LoginCCHSPortal.Email);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'LoginCCHSPortal.Email'.", repo.LoginCCHSPortal.EmailInfo, new RecordItemIndex(20));
            repo.LoginCCHSPortal.Email.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$EditEmail' with focus on 'LoginCCHSPortal.Email'.", repo.LoginCCHSPortal.EmailInfo, new RecordItemIndex(21));
            repo.LoginCCHSPortal.Email.PressKeys(EditEmail);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '@cchs.com' with focus on 'LoginCCHSPortal.Email'.", repo.LoginCCHSPortal.EmailInfo, new RecordItemIndex(22));
            repo.LoginCCHSPortal.Email.PressKeys("@cchs.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'LoginCCHSPortal.Email'.", repo.LoginCCHSPortal.EmailInfo, new RecordItemIndex(23));
            repo.LoginCCHSPortal.Email.PressKeys("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Member_Demographics.Save_button' at 26;16.", repo.LoginCCHSPortal.Member_Demographics.Save_buttonInfo, new RecordItemIndex(24));
            repo.LoginCCHSPortal.Member_Demographics.Save_button.Click("26;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Create_Member.Actions' at 60;13.", repo.LoginCCHSPortal.Create_Member.ActionsInfo, new RecordItemIndex(25));
            repo.LoginCCHSPortal.Create_Member.Actions.Click("60;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Create_Member.Delete_button' at 64;11.", repo.LoginCCHSPortal.Create_Member.Delete_buttonInfo, new RecordItemIndex(26));
            repo.LoginCCHSPortal.Create_Member.Delete_button.Click("64;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Create_Member.DeleteYes_button' at 22;14.", repo.LoginCCHSPortal.Create_Member.DeleteYes_buttonInfo, new RecordItemIndex(27));
            repo.LoginCCHSPortal.Create_Member.DeleteYes_button.Click("22;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginCCHSPortal.Create_Member.ToastToastSuccess'.", repo.LoginCCHSPortal.Create_Member.ToastToastSuccessInfo, new RecordItemIndex(28));
            Validate.Exists(repo.LoginCCHSPortal.Create_Member.ToastToastSuccessInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
