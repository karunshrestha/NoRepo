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
    ///The SelectContent recording.
    /// </summary>
    [TestModule("4ba9127c-c455-49e4-ac6b-cacd32988eaa", ModuleType.Recording, 1)]
    public partial class SelectContent : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static SelectContent instance = new SelectContent();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectContent()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectContent Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Other.Checkbox_Select_Daily_Opp' at 4;5.", repo.NewOceanAdminPortal.Other.Checkbox_Select_Daily_OppInfo, new RecordItemIndex(0));
            repo.NewOceanAdminPortal.Other.Checkbox_Select_Daily_Opp.Click("4;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Other.ModalClose' at 27;14.", repo.NewOceanAdminPortal.Other.ModalCloseInfo, new RecordItemIndex(1));
            repo.NewOceanAdminPortal.Other.ModalClose.Click("27;14");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
