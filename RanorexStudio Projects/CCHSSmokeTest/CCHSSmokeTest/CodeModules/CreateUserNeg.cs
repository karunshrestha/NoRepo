/*
 * Created by Ranorex
 * User: Karun Shrestha
 * Date: 1/13/2017
 * Time: 3:58 PM
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
using Ranorex.Core.Repository;

namespace CCHSSmokeTest.CodeModules
{
	/// <summary>
	/// Description of CreateUserNeg.
	/// </summary>
	[TestModule("F0AA5631-895F-4C14-8200-C9976B447EBD", ModuleType.UserCode, 1)]
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
			
			var repo = SmokeTestRepositoryKS.Instance; //Object Repository Instance
			
			for (int i = 0; i < 5; i++ ) {
				
				//form fields
				var firstName = repo.NewOceanAdminPortal.Member.FirstName;
				var lastName = repo.NewOceanAdminPortal.Member.LastName;
				var organization = repo.NewOceanAdminPortal.Member.Organization;
				var newOcean = repo.NewOceanAdminPortal.Member.NewOcean;
				var emailAddress = repo.NewOceanAdminPortal.Member.EmailAddress;
				var roles = repo.NewOceanAdminPortal.Users.Roles;
				
				
				
				
//	            List<WebElement> fields = new List<WebElement>();
//	            fields.Add(firstName);
//	            fields.Add(lastName);
//	            fields.Add(organization);
//	            fields.Add(newOcean);
//	            fields.Add(emailAddress);
//	            fields.Add(roles);
//
//	            foreach(List<WebElement> field in fields){
//
//	            }
				
				var save = repo.NewOceanAdminPortal.Member.Save;
				
				fillInputField(firstName, i==1 ? "" : "John");
				fillInputField(lastName, i==2 ? "" : "Doe");
				
				if (i != 0 ) {
					organization.Click();
					newOcean.Click();
				}
				
				fillInputField(emailAddress, i==3 ? "" : "usertest440@sharklasers.com");
				
				roles.Click();
				if(i==4){
					roles.Options[0].Selected = true;
				}
				else {
					roles.Options[1].Selected = true;
				}
				
				save.Click();
				
				var errorMessages = repo.NewOceanAdminPortal.Users.ErrorValidationMsg;
				
				if (i==0) {
					Validate.Attribute(errorMessages.OrgnRegValidationMsgInfo, "InnerText", "Organization is required.");
									
				}
				
				Validate.Attribute(errorMessages.GenericAlertInfo, "InnerText", "Stop!");
				
				if (i==1) {
					Validate.Attribute(errorMessages.FNReqValidationMsgInfo, "InnerText", "First name is required.");

					}
				
				if (i==2) {
					Validate.Attribute(errorMessages.LNReqValidationMsgInfo, "InnerText", "Last name is required.");

					}
				if (i==3) {
					Validate.Attribute(errorMessages.EmailReqValidationMsgInfo, "InnerText", "This field is required.");

					}
				if (i==4) {
					Validate.Attribute(errorMessages.RoleReqValidationMsgInfo, "InnerText", "This field is required.");

					}
				
			}
			
			
		}
		
		public void fillInputField(InputTag inputTagName, String value){
			inputTagName.Click();
			inputTagName.InnerText = ""; // clear
			inputTagName.PressKeys(value);
		}
	}
}
