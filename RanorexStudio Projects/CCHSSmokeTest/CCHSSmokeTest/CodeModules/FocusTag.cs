/*
 * Created by Ranorex
 * User: Karun Shrestha
 * Date: 1/29/2017
 * Time: 11:05 AM
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
	/// Description of FocusTag.
	/// </summary>
	[TestModule("ECBCFD57-E9E3-4AB1-8980-3DC16A0A8EDE", ModuleType.UserCode, 1)]
	public class FocusTag : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public FocusTag()
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
			
			// Boolean temp = false;
			
			while (true) {
				
				// Report.Log(ReportLevel.Info, "Mouse", "xxx Left Click item 'itagInfo' at Center.");
        
				repo.NewOceanAdminPortal.Focus.ExpandFocus.Click();

				if (repo.NewOceanAdminPortal.Focus.Close_Button_FocusInfo.Exists()) {
					
					break;
				}
				
			}
		}
	}
}
