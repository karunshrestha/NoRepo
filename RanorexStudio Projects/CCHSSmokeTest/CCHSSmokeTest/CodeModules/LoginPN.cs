/*
 * Created by Ranorex
 * User: Karun Shrestha
 * Date: 2/11/2017
 * Time: 1:27 PM
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
	/// Description of LoginPN.
	/// </summary>
	[TestModule("F985BEC5-BE91-4140-B4EA-7B068EF1F5ED", ModuleType.UserCode, 1)]
	public class LoginPN : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public LoginPN()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _varPassword = "Password1";
		[TestVariable("00b98c81-4cec-42b8-9d5a-202df95c47dc")]
		public string varPassword
		{
			get { return _varPassword; }
			set { _varPassword = value; }
		}


		string _varLogin = "karun.shrestha@newoceanhealth.com";
		[TestVariable("66b6f84b-e388-4894-be89-10fcb088b9c1")]
		public string varLogin
		{
			get { return _varLogin; }
			set { _varLogin = value; }
		}
		
		
		string _varDomainName = "";
		[TestVariable("178751f1-a738-44b9-8ade-7446414ff120")]
		public string varDomainName
		{
			get { return _varDomainName; }
			set { _varDomainName = value; }
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
			
			var repo = SmokeTestRepositoryKS.Instance;
			
			var email = repo.NewOceanAdminPortal.Login.Email;
			var password = repo.NewOceanAdminPortal.Login.Password;
			var loginButton = repo.NewOceanAdminPortal.Login.ContinueButton;
			
			fillInputField (email, _varLogin); // click, clear and enter email
			fillInputField (password, _varPassword); // click, clear and enter password
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.");
            Keyboard.Press("{Tab}"); // press tab Ctrl+A
            Delay.Milliseconds(1200);
			loginButton.Click(); // click login button
			Delay.Milliseconds(2000);
			
			
			// Validations for each loop starts from below
			
			
			int currentIndex = TestCaseNode.Current.DataContext.CurrentRowIndex;
			Report.Info ("Current Index: " + currentIndex);
			
			
			if(currentIndex == 1) //both Email and Password blank
				
			{
				Ranorex.DivTag alertDiv = Host.Local.FindSingle <Ranorex.DivTag> ("/dom[@domain= $_varDomainName]//div[#'loginAlert']");
				Report.Info(alertDiv.InnerText);
				Validate.IsTrue(alertDiv.InnerText.Contains("Please correct"));
				
				Ranorex.SpanTag mySpanTag = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'emailVal']/span[@innertext~'^Email\\ Address\\ is\\ required']");
				Report.Info(mySpanTag.InnerText);
				Validate.IsTrue(mySpanTag.InnerText.Contains("Email Address"));
				
				
				Ranorex.SpanTag mySpanTagPassword = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'passwordVal']/span[@innertext='The Password is required.']");
				Report.Info(mySpanTagPassword.InnerText);
				Validate.IsTrue(mySpanTagPassword.InnerText.Contains("The Password"));
				
			}
			
			else if (currentIndex == 2)  //Email blank
			{
				Ranorex.DivTag alertDiv = Host.Local.FindSingle <Ranorex.DivTag> ("/dom[@domain=$_varDomainName]//div[#'loginAlert']");
				Report.Info(alertDiv.InnerText);
				Validate.IsTrue(alertDiv.InnerText.Contains("Please correct"));
				
				Ranorex.SpanTag mySpanTag = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'emailVal']/span[@innertext~'^Email\\ Address\\ is\\ required']");
				Report.Info(mySpanTag.InnerText);
				Validate.IsTrue(mySpanTag.InnerText.Contains("Email Address"));
			}
			
			else if (currentIndex == 3)  // Password blank
				
			{
				Ranorex.DivTag alertDiv = Host.Local.FindSingle <Ranorex.DivTag> ("/dom[@domain=$_varDomainName]//div[#'loginAlert']");
				Report.Info(alertDiv.InnerText);
				Validate.IsTrue(alertDiv.InnerText.Contains("Please correct"));
				
				Ranorex.SpanTag mySpanTagPassword = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'passwordVal']/span[@innertext='The Password is required.']");
				Report.Info(mySpanTagPassword.InnerText);
				Validate.IsTrue(mySpanTagPassword.InnerText.Contains("The Password"));
			}
			
			else if (currentIndex == 4 || currentIndex ==5) // 4 Correct Email and Incorrect Password // 5 Incorrect Email and Correct Password
			{
				
				Ranorex.DivTag loginAlert = Host.Local.FindSingle <Ranorex.DivTag> ("/dom[@domain=$_varDomainName]//div[#'loginAlert']");
				Report.Info(loginAlert.InnerText);
				Validate.IsTrue(loginAlert.InnerText.Contains("credentials"));
			}
			
			else if (currentIndex == 6)
			{
				//repo.NewOceanAdminPortal.Login.AcceptInfo.Exists ()
				if (repo.NewOceanAdminPortal.Home.HomeInfo.Exists())
				{
				var home = repo.NewOceanAdminPortal.Home.Home;
				Report.Info(home.InnerText);
				Validate.IsTrue(home.InnerText.Contains("Home"));
				}
				
				else if (repo.NewOceanAdminPortal.Login.AcceptInfo.Exists ()) 
				{
					repo.NewOceanAdminPortal.Login.Accept.Click();
				}
			}
			
		}
		
		public void fillInputField(InputTag inputTagName, String value){
			inputTagName.Click();
						//inputTagName.Value = ""; // clear
			Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
			Delay.Milliseconds(300);
			Keyboard.Press("{Delete}");
			Delay.Milliseconds(300);
			inputTagName.PressKeys(value);
		}
		
	}
	
}

