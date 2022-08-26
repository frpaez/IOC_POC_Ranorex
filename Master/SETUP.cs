/*
 * Created by Ranorex
 * User: cromansantillan
 * Date: 8/26/2022
 * Time: 11:32 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
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

namespace Master
{
    /// <summary>
    /// Description of SETUP.
    /// </summary>
    [TestModule("9AEDA189-62AB-4588-990A-71BADC55B200", ModuleType.UserCode, 1)]
    public class SETUP : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SETUP()
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
