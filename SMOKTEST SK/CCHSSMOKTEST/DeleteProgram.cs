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
    ///The DeleteProgram recording.
    /// </summary>
    [TestModule("7cbf444f-b55c-4245-a5af-3bed6d391330", ModuleType.Recording, 1)]
    public partial class DeleteProgram : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SMOKTEST_SKRepository repository.
        /// </summary>
        public static SMOKTEST_SKRepository repo = SMOKTEST_SKRepository.Instance;

        static DeleteProgram instance = new DeleteProgram();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteProgram()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteProgram Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Forms.Delete' at 50;16.", repo.LoginCCHSPortal.Forms.DeleteInfo, new RecordItemIndex(0));
            repo.LoginCCHSPortal.Forms.Delete.Click("50;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Create_Member.DeleteYes_button' at 34;17.", repo.LoginCCHSPortal.Create_Member.DeleteYes_buttonInfo, new RecordItemIndex(1));
            repo.LoginCCHSPortal.Create_Member.DeleteYes_button.Click("34;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginCCHSPortal.Create_Member.ToastToastSuccess'.", repo.LoginCCHSPortal.Create_Member.ToastToastSuccessInfo, new RecordItemIndex(2));
            Validate.Exists(repo.LoginCCHSPortal.Create_Member.ToastToastSuccessInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
