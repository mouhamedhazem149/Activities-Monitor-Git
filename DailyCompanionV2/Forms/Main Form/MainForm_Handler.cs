using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2.Forms
{
    public static class MainForm_Handler
    {
        public static void LoadUserInfo(Label usernameLabel)
        {
            Program.mainSettings = DBHelper.Load_Data<Models.Settings>("settings", new List<string> { "*" }).FirstOrDefault();
            usernameLabel.Text = Program.mainSettings.name;
        }
        public static void HandleExit()
        {
            try { HM_Manager.HandleHistory(new string[] { "المستخدمين", "تسجيل خروج", $"اسم المستخدم: {Program.mainSettings.name}" }); Environment.Exit(0); }
            catch (Exception) { Console.WriteLine("error Occured"); }
        }
        public static void User_Interface_Button_Handle<T>(ref bool clicked, ns1.BunifuImageButton ImageButton, Panel UserInterfaces_Panel, Panel Header_Panel,params object[] parameters) where T: Control
        {
            clicked = !clicked;
            if (clicked)
            {
                var myConstructor = Utilities.HM_Manager.CreateConstructor(typeof(T), parameters.Select(parmeter => parmeter.GetType()).ToArray());
                var myControl = myConstructor(parameters);
                (myControl as Control).Location = new Point(ImageButton.Location.X, (myControl as Control).Location.Y); UserInterfaces_Panel.Controls.Add((myControl as Control));
                ImageButton.BackColor = Color.FromArgb(UserInterfaces_Panel.BackColor.R + 30, UserInterfaces_Panel.BackColor.G + 30, UserInterfaces_Panel.BackColor.B + 30);
                (myControl as Control).BringToFront();
            }
            else
            {
                ImageButton.BackColor = Header_Panel.BackColor;
                foreach (Control ctrl in UserInterfaces_Panel.Controls.OfType<T>())
                    ctrl.Dispose();
            }
        }

        public static void ChangeColor(Color new_mainColor, Color new_secColor, List<Control> mainPanels, List<Control> mainAuxPanels, List<Control> secPanels, List<ns1.BunifuTileButton> ColorAndActivecolor)
        {
            foreach (Control ctrl in mainPanels) ctrl.BackColor = new_mainColor;
            foreach (Control ctrl in mainAuxPanels) ctrl.BackColor = ControlPaint.Dark(new_mainColor, 0.01F);
            foreach (Control ctrl in secPanels) ctrl.BackColor = new_secColor;
            foreach (ns1.BunifuTileButton button in ColorAndActivecolor) { button.color = ControlPaint.Dark(new_mainColor, 0.01F); button.colorActive = new_secColor; }
        }
    }
}
