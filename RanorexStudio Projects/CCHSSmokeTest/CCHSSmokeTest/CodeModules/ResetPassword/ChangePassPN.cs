/*
 * Created by Ranorex
 * User: Karun Shrestha
 * Date: 4/9/2017
 * Time: 12:34 PM
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

namespace CCHSSmokeTest.CodeModules.ResetPassword
{
    /// <summary>
    /// Description of ChangePassPN.
    /// </summary>
    [TestModule("515884B0-197E-4966-BDBC-278C642E4304", ModuleType.UserCode, 1)]
    public class ChangePassPN : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ChangePassPN()
        {
            // Do not delete - a parameterless constructor is required!
        }

        
      
      string _varEmail = "";
      [TestVariable("0dead773-8199-48ea-b695-cbb253b4c7d6")]
      public string varEmail
      {
      	get { return _varEmail; }
      	set { _varEmail = value; }
      }
      
        
        string _varOldPass = "";
        [TestVariable("a05c1f1d-80ce-4b91-8561-0f9a3e2490e1")]
        public string varOldPass
        {
        	get { return _varOldPass; }
        	set { _varOldPass = value; }
        }
        
        string _varNewPassOne = "";
        [TestVariable("ecf8a8b7-a838-4e49-a1a3-c61caf73bd60")]
        public string varNewPassOne
        {
        	get { return _varNewPassOne; }
        	set { _varNewPassOne = value; }
        }
        
        string _varNewPassTwo = "";
        [TestVariable("7221b7ee-ea59-4068-a651-f8a88d079b98")]
        public string varNewPassTwo
        {
        	get { return _varNewPassTwo; }
        	set { _varNewPassTwo = value; }
        }
        
        string _varDomainName = "";
        [TestVariable("48180cb0-1c61-4213-b35d-4eaf70c62b7e")]
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
			
			
			var emailField = repo.NewOceanAdminPortal.Login.Email;
			var oldPass = repo.NewOceanAdminPortal.Reset_Password.OldPassword;
			var passwordOne = repo.NewOceanAdminPortal.Reset_Password.NewPassword;
			var passwordTwo = repo.NewOceanAdminPortal.Reset_Password.ConfirmNewPassword;
			var changePassOne = repo.NewOceanAdminPortal.Login.ContinueButton;
			
			fillInput (emailField, _varEmail);
			fillInput (oldPass, _varOldPass);
			fillInput (passwordOne, _varNewPassOne);
			fillInput (passwordTwo, _varNewPassTwo);
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.");
            Keyboard.Press("{Tab}"); // press tab Ctrl+A
            Delay.Milliseconds(1200);
			changePassOne.Click(); // click login button
			Delay.Milliseconds(2000);
			
			int currentIndex = TestCaseNode.Current.DataContext.CurrentRowIndex;
			Report.Info ("Current Index: " + currentIndex);
			
			switch (currentIndex) {
					
				case 1: // All Blank
					
					
					Ranorex.DivTag alertDivOne = Host.Local.FindSingle <Ranorex.DivTag> ("/dom[@domain= $_varDomainName]//div[#'loginAlert']");
					Report.Info(alertDivOne.InnerText);
					Validate.IsTrue(alertDivOne.InnerText.Contains("Please correct"));
					
					Ranorex.SpanTag mySpanTagOne = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'emailVal']/span[@innertext~'^Email\\ Address']");
					Report.Info(mySpanTagOne.InnerText);
					Validate.IsTrue(mySpanTagOne.InnerText.Contains("Email"));
					
					Ranorex.SpanTag mySpanTagTwo = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'oldPasswordVal']/span[@innertext~'^The\\ Old']");
					Report.Info(mySpanTagTwo.InnerText);
					Validate.IsTrue(mySpanTagTwo.InnerText.Contains("The Old"));
					
					Ranorex.SpanTag mySpanTagThree = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'newPasswordVal']/span[@innertext~'^The\\ New']");
					Report.Info(mySpanTagThree.InnerText);
					Validate.IsTrue(mySpanTagThree.InnerText.Contains("The New"));
					
					Ranorex.SpanTag mySpanTagFour = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'confirmNewPasswordVal']/span[@innertext~'^The\\ Confirm\\ New\\ Password']");
					Report.Info(mySpanTagFour.InnerText);
					Validate.IsTrue(mySpanTagFour.InnerText.Contains("Confirm"));
					break;
					
				case 2: // Email= Incorrect | OP = V| NP = V | CP = V
					Ranorex.DivTag alertDivTwo = Host.Local.FindSingle <Ranorex.DivTag> ("/dom[@domain= $_varDomainName]//div[#'loginAlert']");
					Report.Info(alertDivTwo.InnerText);
					Validate.IsTrue(alertDivTwo.InnerText.Contains("The email"));
					break;
										
				case 3: // Email= V | OP = Incorrect | NP = V | CP = V
					Ranorex.DivTag alertDivThree = Host.Local.FindSingle <Ranorex.DivTag> ("/dom[@domain= $_varDomainName]//div[#'loginAlert']");
					Report.Info(alertDivThree.InnerText);
					Validate.IsTrue(alertDivThree.InnerText.Contains("Invalid username"));
					break;
					
					
				case 4: // Email= V | OP = V| NP = <8 | CP = <8 
					Ranorex.SpanTag mySpanTagFive = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'newPasswordVal']/span[@innertext~'^Please\\ enter\\ at\\ least\\ 8\\ c']");
					Report.Info(mySpanTagFive.InnerText);
					Validate.IsTrue(mySpanTagFive.InnerText.Contains("Please enter"));
					
					
					Ranorex.SpanTag mySpanTagSix = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'confirmNewPasswordVal']/span[@innertext~'^Please\\ enter\\ at\\ least\\ 8\\ c']");
					Report.Info(mySpanTagSix.InnerText);
					Validate.IsTrue(mySpanTagSix.InnerText.Contains("Please enter"));
					break;
					
				case 5: // Email= V | OP = V| NP = Criteria Not Met | CP = Criteria Not Met
					Ranorex.DivTag alertDivFour = Host.Local.FindSingle <Ranorex.DivTag> ("/dom[@domain= $_varDomainName]//div[#'loginAlert']");
					Report.Info(alertDivFour.InnerText);
					Validate.IsTrue(alertDivFour.InnerText.Contains("The password"));
					break;
					
				case 6: // Email= V | OP = V| NP = NonMatch | CP = NonMatch
					Ranorex.SpanTag mySpanTagSeven = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'confirmNewPasswordVal']/span[@innertext~'^Passwords\\ must']");
					Report.Info(mySpanTagSeven.InnerText);
					Validate.IsTrue(mySpanTagSeven.InnerText.Contains("Passwords must"));
					break;
					
				}
			
			   }
        
        
        public void fillInput (InputTag inputTag, String value) {
        	inputTag.Click();
        	Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
			Delay.Milliseconds(300);
			Keyboard.Press("{Delete}");
			Delay.Milliseconds(300);
			inputTag.PressKeys(value);
        }
            
        }
    }

