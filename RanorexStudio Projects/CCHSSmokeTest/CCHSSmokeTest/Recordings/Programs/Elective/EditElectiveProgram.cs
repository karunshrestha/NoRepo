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

namespace CCHSSmokeTest.Recordings.Programs.Elective
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EditElectiveProgram recording.
    /// </summary>
    [TestModule("b6da9a8b-fc56-425b-b8c3-6323c677d4ab", ModuleType.Recording, 1)]
    public partial class EditElectiveProgram : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static EditElectiveProgram instance = new EditElectiveProgram();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditElectiveProgram()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditElectiveProgram Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Content.FormControl' at 511;20.", repo.NewOceanAdminPortal.Content.FormControlInfo, new RecordItemIndex(0));
            repo.NewOceanAdminPortal.Content.FormControl.Click("511;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(1));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'NewOceanAdminPortal.Content.FormControl'.", repo.NewOceanAdminPortal.Content.FormControlInfo, new RecordItemIndex(2));
            repo.NewOceanAdminPortal.Content.FormControl.PressKeys("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'NewOceanAdminPortal.Content.FormControl'.", repo.NewOceanAdminPortal.Content.FormControlInfo, new RecordItemIndex(3));
            repo.NewOceanAdminPortal.Content.FormControl.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}