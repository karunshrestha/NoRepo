/*
 * Created by Ranorex
 * User: Karun Shrestha
 * Date: 1/13/2017
 * Time: 12:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("0B3CDF69-00AF-4404-9AAE-4175DB85C2CB", ModuleType.UserCode, 1)]
    public class UserCodeModule1 : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserCodeModule1()
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
            
            //var mySearchVariable = Host.Local.Find("xxx");
            
            for(int i = 0; i<10;i++){
            	IList<TdTag> tdTags = Host.Local.Find<Ranorex.TdTag>("/dom[@domain='qa.carecamhealthsystems.com']//div[#'applicationHost']/section/div/div[4]/div/div/div[2]/div[2]/div//table/tbody/tr[" + i + "]/td[2]") ;
            	foreach(Ranorex.TdTag td in tdTags){
            		td.InnerText.Equals("Shrestha");
            		// further stuff;
            		
            		Report.Info(td.InnerText);
            	}
            }
            
            
            	//Report.Info(tr.InnerText);
           
            //tempRow.ToString();
            //tempRow.ToString();
            //Report.Info(tempRow.ToString());
        }
    }
}
