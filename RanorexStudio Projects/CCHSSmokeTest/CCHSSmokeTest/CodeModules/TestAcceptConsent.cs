/*
 * Created by Ranorex
 * User: Karun Shrestha
 * Date: 2/7/2017
 * Time: 11:34 AM
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

namespace CCHSSmokeTest.CodeModules
{
    /// <summary>
    /// Description of TestAcceptConsent.
    /// </summary>
    [TestModule("C43D7AA5-1B4E-4D34-A0CD-CC4E26ECBE63", ModuleType.UserCode, 1)]
    public class TestAcceptConsent : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TestAcceptConsent()
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
            
          
            	
        }
    }
}
