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

namespace CCHSSmokeTest.Recordings.Delete
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DeleteItem recording.
    /// </summary>
    [TestModule("33f46103-08f7-44f3-a91c-e1906700ecc4", ModuleType.Recording, 1)]
    public partial class DeleteItem : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static DeleteItem instance = new DeleteItem();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteItem()
        {
            GetToastMsg = "test";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteItem Instance
        {
            get { return instance; }
        }

#region Variables

        string _GetToastMsg;

        /// <summary>
        /// Gets or sets the value of variable GetToastMsg.
        /// </summary>
        [TestVariable("538efb01-d162-4bd0-a73e-e8fb30750e4c")]
        public string GetToastMsg
        {
            get { return _GetToastMsg; }
            set { _GetToastMsg = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Buttons.Delete' at 47;11.", repo.NewOceanAdminPortal.Buttons.DeleteInfo, new RecordItemIndex(0));
            repo.NewOceanAdminPortal.Buttons.Delete.Click("47;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Users.DeleteYes' at 16;10.", repo.NewOceanAdminPortal.Users.DeleteYesInfo, new RecordItemIndex(1));
            repo.NewOceanAdminPortal.Users.DeleteYes.Click("16;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'NewOceanAdminPortal.Activities.ItemSuccessfullyDeleted_ToastMessage' and assigning its value to variable 'GetToastMsg'.", repo.NewOceanAdminPortal.Activities.ItemSuccessfullyDeleted_ToastMessageInfo, new RecordItemIndex(2));
            GetToastMsg = repo.NewOceanAdminPortal.Activities.ItemSuccessfullyDeleted_ToastMessage.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", GetToastMsg, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'has been successfully deleted') on item 'NewOceanAdminPortal.Activities.ItemSuccessfullyDeleted_ToastMessage'.", repo.NewOceanAdminPortal.Activities.ItemSuccessfullyDeleted_ToastMessageInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.NewOceanAdminPortal.Activities.ItemSuccessfullyDeleted_ToastMessageInfo, "InnerText", new Regex(Regex.Escape("has been successfully deleted")));
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
