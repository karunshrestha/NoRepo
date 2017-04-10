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
    ///The Focuses recording.
    /// </summary>
    [TestModule("3c2154e5-4491-4928-9054-7439dd6b3b38", ModuleType.Recording, 1)]
    public partial class Focuses : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SMOKTEST_SKRepository repository.
        /// </summary>
        public static SMOKTEST_SKRepository repo = SMOKTEST_SKRepository.Instance;

        static Focuses instance = new Focuses();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Focuses()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Focuses Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Focus.Focuses_Menu_Item' at 67;6.", repo.LoginCCHSPortal.Focus.Focuses_Menu_ItemInfo, new RecordItemIndex(0));
            repo.LoginCCHSPortal.Focus.Focuses_Menu_Item.Click("67;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginCCHSPortal.Focus.Validate_Focus_List'.", repo.LoginCCHSPortal.Focus.Validate_Focus_ListInfo, new RecordItemIndex(1));
            Validate.Exists(repo.LoginCCHSPortal.Focus.Validate_Focus_ListInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Focus.DepressionPrevention_Focus_' at 55;8.", repo.LoginCCHSPortal.Focus.DepressionPrevention_Focus_Info, new RecordItemIndex(2));
            repo.LoginCCHSPortal.Focus.DepressionPrevention_Focus_.Click("55;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Depression Prevention ') on item 'LoginCCHSPortal.Health_Trackers.Name'.", repo.LoginCCHSPortal.Health_Trackers.NameInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.LoginCCHSPortal.Health_Trackers.NameInfo, "Value", "Depression Prevention ");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}