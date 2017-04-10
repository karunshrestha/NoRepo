/*
 * Created by Ranorex
 * User: Karun Shrestha
 * Date: 10/6/2016
 * Time: 2:41 PM
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

namespace CCHSSmokeTest
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("BF6B6DE9-E83F-4DC3-B0FD-A40CB0AC1167", ModuleType.UserCode, 1)]
    public class Accept_Consent : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Accept_Consent()
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
            
            if (repo.NewOceanAdminPortal.Login.AcceptInfo.Exists ()) {
            	
            	repo.NewOceanAdminPortal.Login.Accept.Click();
            }
            
            else
            {
            	Report.Info ("Consent accepted already");
            }


        }
    }
}
