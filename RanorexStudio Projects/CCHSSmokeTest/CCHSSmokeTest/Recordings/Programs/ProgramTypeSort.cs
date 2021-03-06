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

namespace CCHSSmokeTest.Recordings.Programs
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ProgramTypeSort recording.
    /// </summary>
    [TestModule("cb75fa4a-30f5-4293-b5fa-9c9419b5ec76", ModuleType.Recording, 1)]
    public partial class ProgramTypeSort : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static ProgramTypeSort instance = new ProgramTypeSort();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ProgramTypeSort()
        {
            varSortProgmTitle1 = "myProgmTitle1";
            varSortProgmTitle2 = "myProgmTitle2";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ProgramTypeSort Instance
        {
            get { return instance; }
        }

#region Variables

        string _varSortProgmTitle1;

        /// <summary>
        /// Gets or sets the value of variable varSortProgmTitle1.
        /// </summary>
        [TestVariable("1724f01b-a56d-45eb-baf7-7552fc1b5bca")]
        public string varSortProgmTitle1
        {
            get { return _varSortProgmTitle1; }
            set { _varSortProgmTitle1 = value; }
        }

        string _varSortProgmTitle2;

        /// <summary>
        /// Gets or sets the value of variable varSortProgmTitle2.
        /// </summary>
        [TestVariable("30f13860-7170-406b-838a-4fc9d87c2376")]
        public string varSortProgmTitle2
        {
            get { return _varSortProgmTitle2; }
            set { _varSortProgmTitle2 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Content.ProgramType' at 77;12.", repo.NewOceanAdminPortal.Content.ProgramTypeInfo, new RecordItemIndex(0));
            repo.NewOceanAdminPortal.Content.ProgramType.Click("77;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'NewOceanAdminPortal.Content.ProgramTypeCareplan' and assigning its value to variable 'varSortProgmTitle1'.", repo.NewOceanAdminPortal.Content.ProgramTypeCareplanInfo, new RecordItemIndex(1));
            varSortProgmTitle1 = repo.NewOceanAdminPortal.Content.ProgramTypeCareplan.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", varSortProgmTitle1, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Content.ProgramType' at 109;9.", repo.NewOceanAdminPortal.Content.ProgramTypeInfo, new RecordItemIndex(3));
            repo.NewOceanAdminPortal.Content.ProgramType.Click("109;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'NewOceanAdminPortal.Content.ProgramTypeElective' and assigning its value to variable 'varSortProgmTitle2'.", repo.NewOceanAdminPortal.Content.ProgramTypeElectiveInfo, new RecordItemIndex(4));
            varSortProgmTitle2 = repo.NewOceanAdminPortal.Content.ProgramTypeElective.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", varSortProgmTitle2, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeNotContains (InnerText!>$varSortProgmTitle1) on item 'NewOceanAdminPortal.Content.ProgramTypeElective'.", repo.NewOceanAdminPortal.Content.ProgramTypeElectiveInfo, new RecordItemIndex(6));
            Validate.Attribute(repo.NewOceanAdminPortal.Content.ProgramTypeElectiveInfo, "InnerText", new Regex("^((?!("+Regex.Escape(varSortProgmTitle1)+"))(.|\n))*$"));
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
