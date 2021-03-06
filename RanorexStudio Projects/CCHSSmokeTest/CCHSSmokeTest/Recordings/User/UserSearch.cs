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
    ///The UserSearch recording.
    /// </summary>
    [TestModule("4294a8e7-50a0-4a11-bad8-5fb05c5f2a13", ModuleType.Recording, 1)]
    public partial class UserSearch : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static UserSearch instance = new UserSearch();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserSearch()
        {
            varUserSearchFN = "srujana";
            varUserSearchLN = "katta";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UserSearch Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varUserSearchFN.
        /// </summary>
        [TestVariable("f3a5e8dd-9146-4ea1-92a3-f52cce07bf5c")]
        public string varUserSearchFN
        {
            get { return repo.varUserSearchFN; }
            set { repo.varUserSearchFN = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varUserSearchLN.
        /// </summary>
        [TestVariable("17404ad1-45d6-4b03-8619-889fdd56f283")]
        public string varUserSearchLN
        {
            get { return repo.varUserSearchLN; }
            set { repo.varUserSearchLN = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(0));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Users.Administration' at Center.", repo.NewOceanAdminPortal.Users.AdministrationInfo, new RecordItemIndex(1));
            repo.NewOceanAdminPortal.Users.Administration.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Users.Users' at 61;14.", repo.NewOceanAdminPortal.Users.UsersInfo, new RecordItemIndex(2));
            repo.NewOceanAdminPortal.Users.Users.Click("61;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(3));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.FirstName' at 52;22.", repo.NewOceanAdminPortal.Member.FirstNameInfo, new RecordItemIndex(4));
            repo.NewOceanAdminPortal.Member.FirstName.Click("52;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varUserSearchFN' with focus on 'NewOceanAdminPortal.Member.FirstName'.", repo.NewOceanAdminPortal.Member.FirstNameInfo, new RecordItemIndex(5));
            repo.NewOceanAdminPortal.Member.FirstName.PressKeys(varUserSearchFN);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Users.Search' at 30;14.", repo.NewOceanAdminPortal.Users.SearchInfo, new RecordItemIndex(6));
            repo.NewOceanAdminPortal.Users.Search.Click("30;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$varUserSearchFN) on item 'NewOceanAdminPortal.Users.TopFirstNamefromTable'.", repo.NewOceanAdminPortal.Users.TopFirstNamefromTableInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.NewOceanAdminPortal.Users.TopFirstNamefromTableInfo, "InnerText", varUserSearchFN);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.FirstName' at Center.", repo.NewOceanAdminPortal.Member.FirstNameInfo, new RecordItemIndex(8));
            repo.NewOceanAdminPortal.Member.FirstName.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'NewOceanAdminPortal.Member.FirstName'.", repo.NewOceanAdminPortal.Member.FirstNameInfo, new RecordItemIndex(9));
            Keyboard.PrepareFocus(repo.NewOceanAdminPortal.Member.FirstName);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'NewOceanAdminPortal.Member.FirstName'.", repo.NewOceanAdminPortal.Member.FirstNameInfo, new RecordItemIndex(10));
            repo.NewOceanAdminPortal.Member.FirstName.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Member.LastName' at 42;16.", repo.NewOceanAdminPortal.Member.LastNameInfo, new RecordItemIndex(11));
            repo.NewOceanAdminPortal.Member.LastName.Click("42;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varUserSearchLN' with focus on 'NewOceanAdminPortal.Member.LastName'.", repo.NewOceanAdminPortal.Member.LastNameInfo, new RecordItemIndex(12));
            repo.NewOceanAdminPortal.Member.LastName.PressKeys(varUserSearchLN);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Users.Search' at 34;12.", repo.NewOceanAdminPortal.Users.SearchInfo, new RecordItemIndex(13));
            repo.NewOceanAdminPortal.Users.Search.Click("34;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$varUserSearchLN) on item 'NewOceanAdminPortal.Users.TopLastNamefromTable'.", repo.NewOceanAdminPortal.Users.TopLastNamefromTableInfo, new RecordItemIndex(14));
            Validate.Attribute(repo.NewOceanAdminPortal.Users.TopLastNamefromTableInfo, "InnerText", varUserSearchLN);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
