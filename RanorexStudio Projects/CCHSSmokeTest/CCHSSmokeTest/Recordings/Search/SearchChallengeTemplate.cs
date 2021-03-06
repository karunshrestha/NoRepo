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

namespace CCHSSmokeTest.Recordings.Search
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SearchChallengeTemplate recording.
    /// </summary>
    [TestModule("792c4b1a-913b-4fd3-9972-60a5a406959b", ModuleType.Recording, 1)]
    public partial class SearchChallengeTemplate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CCHSSmokeTest.SmokeTestRepositoryKS repository.
        /// </summary>
        public static CCHSSmokeTest.SmokeTestRepositoryKS repo = CCHSSmokeTest.SmokeTestRepositoryKS.Instance;

        static SearchChallengeTemplate instance = new SearchChallengeTemplate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SearchChallengeTemplate()
        {
            varGetFirstElement = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SearchChallengeTemplate Instance
        {
            get { return instance; }
        }

#region Variables

        string _varGetFirstElement;

        /// <summary>
        /// Gets or sets the value of variable varGetFirstElement.
        /// </summary>
        [TestVariable("24d57269-3ed1-4f69-896b-3b9d81b3f65a")]
        public string varGetFirstElement
        {
            get { return _varGetFirstElement; }
            set { _varGetFirstElement = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'NewOceanAdminPortal.Content.SecondChallengeTemplate' and assigning its value to variable 'varGetFirstElement'.", repo.NewOceanAdminPortal.Content.SecondChallengeTemplateInfo, new RecordItemIndex(0));
            varGetFirstElement = repo.NewOceanAdminPortal.Content.SecondChallengeTemplate.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(1));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "User", varGetFirstElement, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Activities.SearchBox' at 17;18.", repo.NewOceanAdminPortal.Activities.SearchBoxInfo, new RecordItemIndex(3));
            repo.NewOceanAdminPortal.Activities.SearchBox.Click("17;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$varGetFirstElement' with focus on 'NewOceanAdminPortal.Activities.SearchBox'.", repo.NewOceanAdminPortal.Activities.SearchBoxInfo, new RecordItemIndex(4));
            repo.NewOceanAdminPortal.Activities.SearchBox.PressKeys(varGetFirstElement);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewOceanAdminPortal.Content.FirstChallengeTemplate' at Center.", repo.NewOceanAdminPortal.Content.FirstChallengeTemplateInfo, new RecordItemIndex(5));
            repo.NewOceanAdminPortal.Content.FirstChallengeTemplate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (TagValue>$varGetFirstElement) on item 'NewOceanAdminPortal.Other.Name'.", repo.NewOceanAdminPortal.Other.NameInfo, new RecordItemIndex(6));
            Validate.Attribute(repo.NewOceanAdminPortal.Other.NameInfo, "TagValue", new Regex(Regex.Escape(varGetFirstElement)));
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
