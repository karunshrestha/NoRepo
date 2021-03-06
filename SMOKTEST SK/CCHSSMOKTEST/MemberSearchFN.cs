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
    ///The MemberSearchFN recording.
    /// </summary>
    [TestModule("f454f334-51b3-4138-928d-d80ea35631de", ModuleType.Recording, 1)]
    public partial class MemberSearchFN : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SMOKTEST_SKRepository repository.
        /// </summary>
        public static SMOKTEST_SKRepository repo = SMOKTEST_SKRepository.Instance;

        static MemberSearchFN instance = new MemberSearchFN();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MemberSearchFN()
        {
            FirstName = "John";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MemberSearchFN Instance
        {
            get { return instance; }
        }

#region Variables

        string _FirstName;

        /// <summary>
        /// Gets or sets the value of variable FirstName.
        /// </summary>
        [TestVariable("6519aeae-dbf6-4266-b17e-b839d079a38c")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Sidebars.Click_on_Members_Side_Menu_Item' at 43;6.", repo.LoginCCHSPortal.Sidebars.Click_on_Members_Side_Menu_ItemInfo, new RecordItemIndex(0));
            repo.LoginCCHSPortal.Sidebars.Click_on_Members_Side_Menu_Item.Click("43;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Sidebars.Click_On_Search_Menu_Item' at 68;11.", repo.LoginCCHSPortal.Sidebars.Click_On_Search_Menu_ItemInfo, new RecordItemIndex(1));
            repo.LoginCCHSPortal.Sidebars.Click_On_Search_Menu_Item.Click("68;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Member_Demographics.Search_Ln.FirstName' at 244;16.", repo.LoginCCHSPortal.Member_Demographics.Search_Ln.FirstNameInfo, new RecordItemIndex(2));
            repo.LoginCCHSPortal.Member_Demographics.Search_Ln.FirstName.Click("244;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'John' with focus on 'LoginCCHSPortal.Member_Demographics.Search_Ln.FirstName'.", repo.LoginCCHSPortal.Member_Demographics.Search_Ln.FirstNameInfo, new RecordItemIndex(3));
            repo.LoginCCHSPortal.Member_Demographics.Search_Ln.FirstName.PressKeys("John");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginCCHSPortal.Member_Demographics.Search_Fn.Search_Button' at 39;19.", repo.LoginCCHSPortal.Member_Demographics.Search_Fn.Search_ButtonInfo, new RecordItemIndex(4));
            repo.LoginCCHSPortal.Member_Demographics.Search_Fn.Search_Button.Click("39;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='JOHN') on item 'LoginCCHSPortal.Member_Demographics.Search_Fn.Validation_for_FN_John'.", repo.LoginCCHSPortal.Member_Demographics.Search_Fn.Validation_for_FN_JohnInfo, new RecordItemIndex(5));
            Validate.Attribute(repo.LoginCCHSPortal.Member_Demographics.Search_Fn.Validation_for_FN_JohnInfo, "InnerText", "JOHN");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
