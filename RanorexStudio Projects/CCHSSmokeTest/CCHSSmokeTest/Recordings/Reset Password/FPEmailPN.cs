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

namespace CCHSSmokeTest.Recordings.Reset_Password
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FPEmailPN recording.
    /// </summary>
    [TestModule("39648988-3b97-4818-b86e-0ea7c4fcd6b1", ModuleType.Recording, 1)]
    public partial class FPEmailPN : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static FPEmailPN instance = new FPEmailPN();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FPEmailPN()
        {
            varFPEmail = "iecchs123@gmail.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FPEmailPN Instance
        {
            get { return instance; }
        }

#region Variables

        string _varFPEmail;

        /// <summary>
        /// Gets or sets the value of variable varFPEmail.
        /// </summary>
        [TestVariable("bb12abe2-9f4e-484d-aa2e-5e31f1ffaa1e")]
        public string varFPEmail
        {
            get { return _varFPEmail; }
            set { _varFPEmail = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Reset_Password.Forgot' at 64;18.", repo.NewOceanAdminPortal.Reset_Password.ForgotInfo, new RecordItemIndex(0));
            repo.NewOceanAdminPortal.Reset_Password.Forgot.Click("64;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Login.ContinueButton' at 190;16.", repo.NewOceanAdminPortal.Login.ContinueButtonInfo, new RecordItemIndex(1));
            repo.NewOceanAdminPortal.Login.ContinueButton.Click("190;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>' Please correct the validation errors below.') on item 'NewOceanAdminPortal.LoginAlert'.", repo.NewOceanAdminPortal.LoginAlertInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.NewOceanAdminPortal.LoginAlertInfo, "InnerText", new Regex(Regex.Escape(" Please correct the validation errors below.")));
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Email Address is required.') on item 'NewOceanAdminPortal.EmailAddressIsRequired'.", repo.NewOceanAdminPortal.EmailAddressIsRequiredInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.NewOceanAdminPortal.EmailAddressIsRequiredInfo, "InnerText", new Regex(Regex.Escape("Email Address is required.")));
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Login.Email' at 71;20.", repo.NewOceanAdminPortal.Login.EmailInfo, new RecordItemIndex(4));
            repo.NewOceanAdminPortal.Login.Email.Click("71;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test@' with focus on 'NewOceanAdminPortal.Login.Email'.", repo.NewOceanAdminPortal.Login.EmailInfo, new RecordItemIndex(5));
            repo.NewOceanAdminPortal.Login.Email.PressKeys("test@");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Login.ContinueButton' at 192;12.", repo.NewOceanAdminPortal.Login.ContinueButtonInfo, new RecordItemIndex(7));
            repo.NewOceanAdminPortal.Login.ContinueButton.Click("192;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(8));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>' The email address specified is not recognized.') on item 'NewOceanAdminPortal.LoginAlert'.", repo.NewOceanAdminPortal.LoginAlertInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.NewOceanAdminPortal.LoginAlertInfo, "InnerText", new Regex(Regex.Escape(" The email address specified is not recognized.")));
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Login.Email' at 195;22.", repo.NewOceanAdminPortal.Login.EmailInfo, new RecordItemIndex(10));
            repo.NewOceanAdminPortal.Login.Email.Click("195;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'NewOceanAdminPortal.Login.Email'.", repo.NewOceanAdminPortal.Login.EmailInfo, new RecordItemIndex(11));
            Keyboard.PrepareFocus(repo.NewOceanAdminPortal.Login.Email);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'NewOceanAdminPortal.Login.Email'.", repo.NewOceanAdminPortal.Login.EmailInfo, new RecordItemIndex(12));
            repo.NewOceanAdminPortal.Login.Email.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varFPEmail' with focus on 'NewOceanAdminPortal.Login.Email'.", repo.NewOceanAdminPortal.Login.EmailInfo, new RecordItemIndex(13));
            repo.NewOceanAdminPortal.Login.Email.PressKeys(varFPEmail);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(14));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Login.ContinueButton' at Center.", repo.NewOceanAdminPortal.Login.ContinueButtonInfo, new RecordItemIndex(15));
            repo.NewOceanAdminPortal.Login.ContinueButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}