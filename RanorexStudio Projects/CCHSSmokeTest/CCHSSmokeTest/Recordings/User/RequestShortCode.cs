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

namespace CCHSSmokeTest.Recordings.User
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The RequestShortCode recording.
    /// </summary>
    [TestModule("343e4298-9822-435f-b8f2-4781f8fde657", ModuleType.Recording, 1)]
    public partial class RequestShortCode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static RequestShortCode instance = new RequestShortCode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RequestShortCode()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RequestShortCode Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.ActivateAccount' at 246;17.", repo.NewOceanAdminPortal.ActivateAccountInfo, new RecordItemIndex(0));
            repo.NewOceanAdminPortal.ActivateAccount.Click("246;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Login.Email' at 27;19.", repo.NewOceanAdminPortal.Login.EmailInfo, new RecordItemIndex(2));
            repo.NewOceanAdminPortal.Login.Email.Click("27;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'usertest@cchs.com' with focus on 'NewOceanAdminPortal.Login.Email'.", repo.NewOceanAdminPortal.Login.EmailInfo, new RecordItemIndex(3));
            repo.NewOceanAdminPortal.Login.Email.PressKeys("usertest@cchs.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Login.ContinueButton' at 133;19.", repo.NewOceanAdminPortal.Login.ContinueButtonInfo, new RecordItemIndex(4));
            repo.NewOceanAdminPortal.Login.ContinueButton.Click("133;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(5));
            Delay.Duration(10000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
