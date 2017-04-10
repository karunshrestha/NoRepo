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

namespace CCHSSmokeTest.Recordings.Home_Page
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The PaginationHomePage recording.
    /// </summary>
    [TestModule("0a9c2bd3-3391-4110-9e76-de772e42a93e", ModuleType.Recording, 1)]
    public partial class PaginationHomePage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static PaginationHomePage instance = new PaginationHomePage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PaginationHomePage()
        {
            varPagination1 = "";
            varPagination2 = "";
            varPagination3 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PaginationHomePage Instance
        {
            get { return instance; }
        }

#region Variables

        string _varPagination1;

        /// <summary>
        /// Gets or sets the value of variable varPagination1.
        /// </summary>
        [TestVariable("32408bb8-ffb4-45f0-987c-621b32f3228d")]
        public string varPagination1
        {
            get { return _varPagination1; }
            set { _varPagination1 = value; }
        }

        string _varPagination2;

        /// <summary>
        /// Gets or sets the value of variable varPagination2.
        /// </summary>
        [TestVariable("87985916-45e9-4b01-b0e5-750450d68c2a")]
        public string varPagination2
        {
            get { return _varPagination2; }
            set { _varPagination2 = value; }
        }

        string _varPagination3;

        /// <summary>
        /// Gets or sets the value of variable varPagination3.
        /// </summary>
        [TestVariable("c81a469f-1317-4210-9280-50821ed2984b")]
        public string varPagination3
        {
            get { return _varPagination3; }
            set { _varPagination3 = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'NewOceanAdminPortal.Home.FirstMemberName_HomeScreen' and assigning its value to variable 'varPagination1'.", repo.NewOceanAdminPortal.Home.FirstMemberName_HomeScreenInfo, new RecordItemIndex(0));
            varPagination1 = repo.NewOceanAdminPortal.Home.FirstMemberName_HomeScreen.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", varPagination1, new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Home.Page_2' at 12;14.", repo.NewOceanAdminPortal.Home.Page_2Info, new RecordItemIndex(2));
            repo.NewOceanAdminPortal.Home.Page_2.Click("12;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'NewOceanAdminPortal.Home.FirstMemberName_HomeScreen' and assigning its value to variable 'varPagination2'.", repo.NewOceanAdminPortal.Home.FirstMemberName_HomeScreenInfo, new RecordItemIndex(3));
            varPagination2 = repo.NewOceanAdminPortal.Home.FirstMemberName_HomeScreen.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", varPagination2, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeNotContains (InnerText!>$varPagination1) on item 'NewOceanAdminPortal.Home.FirstMemberName_HomeScreen'.", repo.NewOceanAdminPortal.Home.FirstMemberName_HomeScreenInfo, new RecordItemIndex(5));
            Validate.Attribute(repo.NewOceanAdminPortal.Home.FirstMemberName_HomeScreenInfo, "InnerText", new Regex("^((?!("+Regex.Escape(varPagination1)+"))(.|\n))*$"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Home.Page_3' at 14;14.", repo.NewOceanAdminPortal.Home.Page_3Info, new RecordItemIndex(6));
            repo.NewOceanAdminPortal.Home.Page_3.Click("14;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'NewOceanAdminPortal.Home.FirstMemberName_HomeScreen' and assigning its value to variable 'varPagination3'.", repo.NewOceanAdminPortal.Home.FirstMemberName_HomeScreenInfo, new RecordItemIndex(7));
            varPagination3 = repo.NewOceanAdminPortal.Home.FirstMemberName_HomeScreen.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", varPagination3, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeNotContains (InnerText!>$varPagination2) on item 'NewOceanAdminPortal.Home.FirstMemberName_HomeScreen'.", repo.NewOceanAdminPortal.Home.FirstMemberName_HomeScreenInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.NewOceanAdminPortal.Home.FirstMemberName_HomeScreenInfo, "InnerText", new Regex("^((?!("+Regex.Escape(varPagination2)+"))(.|\n))*$"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
