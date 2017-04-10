/*
 * Created by Ranorex
 * User: Karun Shrestha
 * Date: 4/7/2017
 * Time: 2:07 PM
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
    /// Description of FPSecurityAnswer.
    /// </summary>
    [TestModule("272A80D7-127D-4082-9FA5-7F44C183012E", ModuleType.UserCode, 1)]
    public class FPSecurityAnswer : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FPSecurityAnswer()
        {
            // Do not delete - a parameterless constructor is required!
        }

        
        string _varSecAns = "";
        [TestVariable("f4421950-79d5-436d-8555-3fa5de56daf6")] // declared module variable for Security Answer
        public string varSecAns
        {
        	get { return _varSecAns; }
        	set { _varSecAns = value; }
        }
        
        string _varPassOne = "";
        [TestVariable("fa59d702-6d1c-4b40-b0d2-73a8d1f1f271")]  // declared module variable for Password
        public string varPassOne
        {
        	get { return _varPassOne; }
        	set { _varPassOne = value; }
        }
        
        string _varPassTwo = "";
        [TestVariable("6aa9904c-371e-4fb0-b30c-d34a7639229c")]  // declared module variable for Confirm Password
        public string varPassTwo
        {
        	get { return _varPassTwo; }
        	set { _varPassTwo = value; }
        }
        
        string _varDomainName = "";
        [TestVariable("e999dd7a-4be7-4599-b12a-d0870a236aac")]
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
			
			var answer = repo.NewOceanAdminPortal.Reset_Password.Answer;
			var passwordOne = repo.NewOceanAdminPortal.Reset_Password.NewPassword;
			var passwordTwo = repo.NewOceanAdminPortal.Reset_Password.ConfirmNewPassword;
			var changePass = repo.NewOceanAdminPortal.Reset_Password.ChangePasswordBtn;
			
			fillInput (answer, _varSecAns);
			fillInput (passwordOne, _varPassOne);
			fillInput (passwordTwo, _varPassTwo);
			Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.");
            Keyboard.Press("{Tab}"); // press tab Ctrl+A
            Delay.Milliseconds(1200);
			changePass.Click(); // click login button
			Delay.Milliseconds(2000);
			
			int currentIndex = TestCaseNode.Current.DataContext.CurrentRowIndex;
			Report.Info ("Current Index: " + currentIndex);
			
			switch (currentIndex) {
					
				case 1: // All Blank
					
					alertMsg ();
					
					Ranorex.SpanTag mySpanTagOne = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'answerVal']/span[@innertext~'^The\\ Challenge\\ Question\\ an']");
					Report.Info(mySpanTagOne.InnerText);
					Validate.IsTrue(mySpanTagOne.InnerText.Contains("Challenge"));
					
					Ranorex.SpanTag mySpanTagTwo = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'newPasswordVal']/span[@innertext~'^The\\ New\\ Password\\ is\\ requi']");
					Report.Info(mySpanTagTwo.InnerText);
					Validate.IsTrue(mySpanTagTwo.InnerText.Contains("The New"));
					
					Ranorex.SpanTag mySpanTagThree = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'confirmNewPasswordVal']/span[@innertext~'^The\\ Confirm\\ New\\ Password']");
					Report.Info(mySpanTagThree.InnerText);
					Validate.IsTrue(mySpanTagThree.InnerText.Contains("Confirm"));
					break;
					
				case 2: // Sec Answer= B | NP = V | CP = V
					Ranorex.DivTag alertDiv = Host.Local.FindSingle <Ranorex.DivTag> ("/dom[@domain= $_varDomainName]//div[#'loginAlert']");
					Report.Info(alertDiv.InnerText);
					Validate.IsTrue(alertDiv.InnerText.Contains("Please correct"));
					
					Ranorex.SpanTag mySpanTagFour = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'answerVal']/span[@innertext~'^The\\ Challenge\\ Question\\ an']");
					Report.Info(mySpanTagFour.InnerText);
					Validate.IsTrue(mySpanTagFour.InnerText.Contains("Challenge"));
					break;
					
				case 3: // Sec Answer= IC | NP = V | CP = V
					Ranorex.DivTag alertDivOne = Host.Local.FindSingle <Ranorex.DivTag> ("/dom[@domain= $_varDomainName]//div[#'loginAlert']");
					Report.Info(alertDivOne.InnerText);
					Validate.IsTrue(alertDivOne.InnerText.Contains("The answer"));
					break;
					
				case 4: // Sec Answer = C | NP and CP Nonmatch
					
					alertMsg ();
					
					
					Ranorex.SpanTag mySpanTagFive = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'confirmNewPasswordVal']/span[@innertext~'^The\\ new\\ passwords\\ must\\ ma']");
					Report.Info(mySpanTagFive.InnerText);
					Validate.IsTrue(mySpanTagFive.InnerText.Contains("The new"));
					break;
					
				case 5: // Sec Answer = C | NP and CP less than 8 characters
					
					alertMsg ();
					
					
					Ranorex.SpanTag mySpanTagSix = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'newPasswordVal']/span[@innertext~'^Please\\ enter\\ at\\ least\\ 8\\ c']");
					Report.Info(mySpanTagSix.InnerText);
					Validate.IsTrue(mySpanTagSix.InnerText.Contains("Please enter"));
					
					
					Ranorex.SpanTag mySpanTagSeven = Host.Local.FindSingle <Ranorex.SpanTag> ("/dom[@domain=$_varDomainName]//span[#'confirmNewPasswordVal']/span[@innertext~'^Please\\ enter\\ at\\ least\\ 8\\ c']");
					Report.Info(mySpanTagSeven.InnerText);
					Validate.IsTrue(mySpanTagSeven.InnerText.Contains("Please enter"));
					break;
					
				case 6: // Sec Ans = C | NP and CP Criteria Non Meeting
					
					Ranorex.DivTag alertDivTwo = Host.Local.FindSingle <Ranorex.DivTag> ("/dom[@domain= $_varDomainName]//div[#'loginAlert']");
					Report.Info(alertDivTwo.InnerText);
					Validate.IsTrue(alertDivTwo.InnerText.Contains("Please try"));
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
        
        public void alertMsg () { // login alert Please correct validation error
        	Ranorex.DivTag alertDivOne = Host.Local.FindSingle <Ranorex.DivTag> ("/dom[@domain= $_varDomainName]//div[#'loginAlert']");
			Report.Info(alertDivOne.InnerText);
			Validate.IsTrue(alertDivOne.InnerText.Contains("Please correct"));
        }
    }
}
