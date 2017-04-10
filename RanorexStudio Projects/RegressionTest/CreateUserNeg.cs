/*
 * Created by Ranorex
 * User: Karun Shrestha
 * Date: 1/13/2017
 * Time: 3:56 PM
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

namespace RegressionTest
{
    /// <summary>
    /// Description of CreateUserNeg.
    /// </summary>
    [TestModule("AC3D2818-C164-45E0-B593-54376A48ED0B", ModuleType.UserCode, 1)]
    public class CreateUserNeg : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CreateUserNeg()
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
