/*
 * Created by Ranorex
 * User: Karun Shrestha
 * Date: 4/7/2017
 * Time: 12:19 PM
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

namespace CCHSSmokeTest.CodeModules.Member
{
    /// <summary>
    /// Description of AddMemberPN.
    /// </summary>
    [TestModule("16D7CF74-E064-4305-B47F-E5CFEC7B60D9", ModuleType.UserCode, 1)]
    public class AddMemberPN : ITestModule
    {
    string _varFirstName = "";
    [TestVariable("d3db5c18-13da-42f9-8a44-dd69c03b2f93")]
    public string varFirstName
    {
    	get { return _varFirstName; }
    	set { _varFirstName = value; }
    }
    
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddMemberPN()
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
