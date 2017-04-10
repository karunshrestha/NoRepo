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

namespace CCHSSmokeTest.Recordings.Challenges
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ChallengeTypeTraditional recording.
    /// </summary>
    [TestModule("cb6cad4b-53fe-4888-989a-b47f0a3d54dc", ModuleType.Recording, 1)]
    public partial class ChallengeTypeTraditional : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static ChallengeTypeTraditional instance = new ChallengeTypeTraditional();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ChallengeTypeTraditional()
        {
            varChallengeType = "4";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ChallengeTypeTraditional Instance
        {
            get { return instance; }
        }

#region Variables

        string _varChallengeType;

        /// <summary>
        /// Gets or sets the value of variable varChallengeType.
        /// </summary>
        [TestVariable("3f41bed8-8705-46d4-a034-66647f54d891")]
        public string varChallengeType
        {
            get { return _varChallengeType; }
            set { _varChallengeType = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.SystemComObject.TypeRequired' at 69;9.", repo.NewOceanAdminPortal.SystemComObject.TypeRequiredInfo, new RecordItemIndex(0));
            repo.NewOceanAdminPortal.SystemComObject.TypeRequired.Click("69;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(1));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Down}{Down}'.", new RecordItemIndex(2));
            Keyboard.Press("{Down}{Down}{Down}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
