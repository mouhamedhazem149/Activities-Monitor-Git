﻿using OpsMoi.Forms;
using OpsMoi.Utilities;
using ns1;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OpsMoi.User_Interfaces;

namespace OpsMoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Program.WorkingForm = this;
            InitializeByResolution(); LoadUserInfo();
            Change_Color(Color.FromArgb(int.Parse(ConfigurationManager.AppSettings["primaryColor"].Split(',')[0]), int.Parse(ConfigurationManager.AppSettings["primaryColor"].Split(',')[1]), int.Parse(ConfigurationManager.AppSettings["primaryColor"].Split(',')[2])), Color.FromArgb(int.Parse(ConfigurationManager.AppSettings["secondaryColor"].Split(',')[0]), int.Parse(ConfigurationManager.AppSettings["secondaryColor"].Split(',')[1]), int.Parse(ConfigurationManager.AppSettings["secondaryColor"].Split(',')[2])));
            Dashboard_TileButton_Click(Dashboard_TileButton, EventArgs.Empty);
        }
        void InitializeByResolution()
        {
            switch (Program.currentResolution)
            {
                case Enums.Resolution.A_1920x1080:
                    InitializeComponent();
                    break;
                /*case Enums.Resolution.B_1366x768:
                    InitializeComponent1366x768();
                    break;
                case Enums.Resolution.C_1280x1040:
                    InitializeComponent1280x1040();
                    break;*/
            }
        }
        public Color mainColor = Color.Transparent;
        public Color secColor = Color.Transparent;
        public void LoadUserInfo()
        {
            HM_Manager.ScaleFontforLabel(CompanyName_Label, Program.companyName);
            MainForm_Handler.LoadUserInfo(User_Name_Label);
            if (Program.mainSettings == null) Environment.Exit(0);
        }

        public void Click_TODO(Enums.todoArgument Arg, int? ID) 
        { 
            if (ID.HasValue) Todo_TileButton_Click(prepareTodoUsrCtrl(Arg, ID.Value), EventArgs.Empty); 
            else Todo_TileButton_Click(prepareTodoUsrCtrl(Arg, null), EventArgs.Empty);
        }
        public void Click_FNC(Enums.financeArgument argument, int? ID)
        {
            if (ID.HasValue) Finances_TileButton_Click(prepareFNCUsrCtrl(argument, ID.Value), EventArgs.Empty);
            else Finances_TileButton_Click(prepareFNCUsrCtrl(argument, null), EventArgs.Empty);
        }
        public void Click_Note(Enums.noteArgument argument, string argLists) { Notes_TileButton_Click(prepareNotUsrCtrl(argument,argLists), EventArgs.Empty); }
        public void Click_Reports(string argument) => Reports_TileButton_Click(argument, EventArgs.Empty);
        public void Click_Settings(string argument, string eventArgs = "") => Settings_TileButton_Click(prepareSettingsUsrCtrl(argument, eventArgs), EventArgs.Empty);
        //93,93,93 Main , 126,126,126 Second
        public void Change_Color(Color mClr, Color sClr)
        {
            HM_Manager.UpdateConfiguration(new List<Tuple<string, string>> { new Tuple<string, string>("primaryColor", $"{mClr.R},{mClr.G},{mClr.B}"), new Tuple<string, string>("secondaryColor", $"{sClr.R},{sClr.G},{sClr.B}") });
            mainColor = mClr; secColor = sClr;
            MainForm_Handler.ChangeColor(mClr, sClr, new List<Control>() { Header_Panel }, new List<Control>() { TileButtons_Panel }, new List<Control>() { SidePanel1, UserInterfaces_Panel }, TileButtons_Panel.Controls.OfType<ns1.BunifuTileButton>().ToList());
        }
        private void Shutdown_ImageButton_Click(object sender, EventArgs e) => MainForm_Handler.HandleExit();

        private void Dashboard_TileButton_Click(object sender, EventArgs e) { } /*=> Tilebutton_Click_Handle<UsrCtrl_Dashboard>(Dashboard_TileButton);*/
        
        private void Todo_TileButton_Click(object sender, EventArgs e)
        {
            PreapreToAdd(Todo_TileButton);
            UsrCtrl_Todo item;
            if (sender is UsrCtrl_Todo) item = sender as UsrCtrl_Todo;
            else item = sender is Enums.todoArgument ? prepareTodoUsrCtrl((sender as Enums.todoArgument?).Value) : prepareTodoUsrCtrl(Enums.todoArgument.none);
            EndAdd(item);
        }
        private UsrCtrl_Todo prepareTodoUsrCtrl(Enums.todoArgument Arg, int? e_ID = null) => new UsrCtrl_Todo(Arg, e_ID);

        private void Finances_TileButton_Click(object sender, EventArgs e)
        {
            PreapreToAdd(Finances_TileButton);
            UsrCtrl_Finances item;
            if (sender is UsrCtrl_Finances) item = sender as UsrCtrl_Finances;
            else item = sender is Enums.financeArgument? prepareFNCUsrCtrl((sender as Enums.financeArgument?).Value): prepareFNCUsrCtrl(Enums.financeArgument.none);
            EndAdd(item);
        }
        private UsrCtrl_Finances prepareFNCUsrCtrl(Enums.financeArgument LoadArg, int? e_ID = null) => new UsrCtrl_Finances(LoadArg, e_ID);

        private void Notes_TileButton_Click(object sender, EventArgs e)
        {
            PreapreToAdd(Notes_TileButton);
            UsrCtrl_Notes item;
            if (sender is UsrCtrl_Notes) item = sender as UsrCtrl_Notes;
            else item = sender is Enums.noteArgument? prepareNotUsrCtrl((sender as Enums.noteArgument?).Value): prepareNotUsrCtrl(Enums.noteArgument.none);
            EndAdd(item);
        }
        private UsrCtrl_Notes prepareNotUsrCtrl(Enums.noteArgument LoadArg, string MethodArg = null) => new UsrCtrl_Notes(LoadArg, MethodArg);

        private void Reports_TileButton_Click(object sender, EventArgs e) => Tilebutton_Click_Handle<UsrCtrl_Reports>(Reports_TileButton);
        
        private void Settings_TileButton_Click(object sender, EventArgs e) 
        {
            PreapreToAdd(Settings_TileButton);
            foreach (Control ctrl in UserInterfaces_Panel.Controls) ctrl.Dispose();
            UsrCtrl_Settings item;
            if (sender is UsrCtrl_Settings) item = sender as UsrCtrl_Settings;
            else item = prepareSettingsUsrCtrl();
            EndAdd(item);
        }
        private UsrCtrl_Settings prepareSettingsUsrCtrl(string LoadArg = "",string MethodArg = "")
        {
            UsrCtrl_Settings item = new UsrCtrl_Settings(LoadArg, MethodArg);
            return item;
        }

        void Tilebutton_Click_Handle<T>(BunifuTileButton btn) where T : Control, new()
        {
            PreapreToAdd(btn);
            foreach (Control ctrl in UserInterfaces_Panel.Controls) ctrl.Dispose();
            T item = new T(); EndAdd(item);
        }

        void PreapreToAdd(BunifuTileButton btn)
        {
            if (btn == null) return;
            SidePanel1.Height = btn.Height; SidePanel1.Top = btn.Top;
            TileButtons_Panel.Enabled = false;
            SidePanel1.BringToFront();
        }
        void EndAdd(Control item) { TileButtons_Panel.Enabled = true; UserInterfaces_Panel.Controls.Add(item); item.BringToFront(); }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => HM_Manager.HandleHistory(new string[] { "المستخدمين", "تسجيل خروج", $"اسم المستخدم: {Program.mainSettings.name}" });

        private void FacebookLink_ImageButton_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(Program.WebpageLink);

        private void ScreenShot_Button_Click(object sender, EventArgs e) => HM_Manager.SaveScreenShot(Program.WorkingForm,Screenshot_Label);

        private void Refresh_Button_Click(object sender, EventArgs e) => HM_Manager.SyncAll(Program.WorkingForm, Screenshot_Label);

    }
}