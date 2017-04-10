/*
 * Created by Ranorex
 * User: Karun Shrestha
 * Date: 2/11/2017
 * Time: 2:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace CCHSSmokeTest.CodeModules
{
	/// <summary>
	/// Description of CodeHelper.
	/// </summary>
	public class CodeHelper
	{
		public CodeHelper()
		{
		}
		
		public static void fillInputField(InputTag inputTagName, String value){
			inputTagName.Click();
			inputTagName.InnerText = ""; // clear
			inputTagName.PressKeys(value);
			
		}
	}
}
