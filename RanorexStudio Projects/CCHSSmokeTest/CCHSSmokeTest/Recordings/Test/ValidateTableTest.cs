/*
 * Created by Ranorex
 * User: Karun Shrestha
 * Date: 1/10/2017
 * Time: 11:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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

namespace CCHSSmokeTest.Recordings.Test
{
    /// <summary>
    /// Description of ValidateTableTest.
    /// </summary>
    [TestModule("E98DD889-143F-4CFC-A459-801AB1E07E80", ModuleType.UserCode, 1)]
    public class ValidateTableTest : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateTableTest()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            SmokeTestRepositoryKS repo = SmokeTestRepositoryKS.Instance;
                      
           	Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Active') on item 'LoginCCHSPortal.DivTagRow'.", repo.NewOceanAdminPortal.Other.ProgramSearchResultsInfo, new RecordItemIndex(6));
            Validate.Attribute(repo.NewOceanAdminPortal.Other.ProgramSearchResultsInfo, "InnerText", "Active");
            Delay.Milliseconds(0);
           
        }
    }
}
