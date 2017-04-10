/*
 * Created by Ranorex
 * User: Karun Shrestha
 * Date: 2/11/2017
 * Time: 2:52 PM
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
    /// Description of CodeHelpe.
    /// </summary>
    [TestModule("C0887AE5-C156-4A9F-B652-ADAA68D76A0B", ModuleType.UserCode, 1)]
    public class CodeHelpe : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CodeHelpe()
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
