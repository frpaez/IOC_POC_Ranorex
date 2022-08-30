﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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

namespace Master.Login
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LoginFailed recording.
    /// </summary>
    [TestModule("2355019d-e925-4e99-a639-54f1fb726a50", ModuleType.Recording, 1)]
    public partial class LoginFailed : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Master.MasterRepository repository.
        /// </summary>
        public static global::Master.MasterRepository repo = global::Master.MasterRepository.Instance;

        static LoginFailed instance = new LoginFailed();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LoginFailed()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LoginFailed Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://katalon-demo-cura.herokuapp.com/' with browser 'Chrome' in maximized mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://katalon-demo-cura.herokuapp.com/", "Chrome", "", false, true, false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CURAHealthcareService.BtnMakeAppointment' at 128;22.", repo.CURAHealthcareService.BtnMakeAppointmentInfo, new RecordItemIndex(1));
            repo.CURAHealthcareService.BtnMakeAppointment.Click("128;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CURAHealthcareService.TxtUsername' at 126;17.", repo.CURAHealthcareService.TxtUsernameInfo, new RecordItemIndex(2));
            repo.CURAHealthcareService.TxtUsername.Click("126;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'John Doe' with focus on 'CURAHealthcareService.TxtUsername'.", repo.CURAHealthcareService.TxtUsernameInfo, new RecordItemIndex(3));
            repo.CURAHealthcareService.TxtUsername.PressKeys("John Doe");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CURAHealthcareService.TxtPassword' at 109;14.", repo.CURAHealthcareService.TxtPasswordInfo, new RecordItemIndex(4));
            repo.CURAHealthcareService.TxtPassword.Click("109;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Thi' with focus on 'CURAHealthcareService.TxtPassword'.", repo.CURAHealthcareService.TxtPasswordInfo, new RecordItemIndex(5));
            repo.CURAHealthcareService.TxtPassword.PressKeys("Thi");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 's' with focus on 'CURAHealthcareService.TxtPassword'.", repo.CURAHealthcareService.TxtPasswordInfo, new RecordItemIndex(6));
            repo.CURAHealthcareService.TxtPassword.PressKeys("s");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'is' with focus on 'CURAHealthcareService.TxtPassword'.", repo.CURAHealthcareService.TxtPasswordInfo, new RecordItemIndex(7));
            repo.CURAHealthcareService.TxtPassword.PressKeys("is");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Not' with focus on 'CURAHealthcareService.TxtPassword'.", repo.CURAHealthcareService.TxtPasswordInfo, new RecordItemIndex(8));
            repo.CURAHealthcareService.TxtPassword.PressKeys("Not");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'aPassword' with focus on 'CURAHealthcareService.TxtPassword'.", repo.CURAHealthcareService.TxtPasswordInfo, new RecordItemIndex(9));
            repo.CURAHealthcareService.TxtPassword.PressKeys("aPassword");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CURAHealthcareService.BtnLogin' at 46;8.", repo.CURAHealthcareService.BtnLoginInfo, new RecordItemIndex(10));
            repo.CURAHealthcareService.BtnLogin.Click("46;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CURAHealthcareService.LoginFailedPleaseEnsureTheUsername' at 524;19.", repo.CURAHealthcareService.LoginFailedPleaseEnsureTheUsernameInfo, new RecordItemIndex(11));
            repo.CURAHealthcareService.LoginFailedPleaseEnsureTheUsername.Click("524;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'CURAHealthcareService.LoginFailedPleaseEnsureTheUsername' at 524;18.", repo.CURAHealthcareService.LoginFailedPleaseEnsureTheUsernameInfo, new RecordItemIndex(12));
            repo.CURAHealthcareService.LoginFailedPleaseEnsureTheUsername.Click(System.Windows.Forms.MouseButtons.Right, "524;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CURAHealthcareService.LoginFailedPleaseEnsureTheUsername' at 512;18.", repo.CURAHealthcareService.LoginFailedPleaseEnsureTheUsernameInfo, new RecordItemIndex(13));
            repo.CURAHealthcareService.LoginFailedPleaseEnsureTheUsername.Click("512;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'CURAHealthcareService'.", repo.CURAHealthcareService.SelfInfo, new RecordItemIndex(14));
            Host.Current.CloseApplication(repo.CURAHealthcareService.Self, 1000);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}