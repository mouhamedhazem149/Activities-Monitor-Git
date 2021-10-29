using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ns1;
using OpsMoi.Forms;
using OpsMoi.User_Interfaces;
using OpsMoi.Utilities;

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
            }
        }

        public Color mainColor = Color.Transparent;
        public Color secColor = Color.Transparent;
        public static string tabPageName = "tabPage";
        public static string todoPageName = "تبويب المهام:";
        public static string fncPageName = "تبويب المالية:";
        public static string notPageName = "تبويب الملاحظات:";
        private Control _clipboardControl = null;
        public Control clippedControl
        {
            get => _clipboardControl;
            set => _clipboardControl = HM_Manager.CtrlVariableDuplicate(value);
        }

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
        public void Click_Reports(Enums.report_tabState argument) => Reports_TileButton_Click(prepareRportUsrCtrl(argument), EventArgs.Empty);
        public void Click_Settings(Enums.settingsArgument argument, string eventArgs = "") => Settings_TileButton_Click(prepareSettingsUsrCtrl(argument, eventArgs), EventArgs.Empty);
        //93,93,93 Main , 126,126,126 Second
        public void Change_Color(Color mClr, Color sClr)
        {
            HM_Manager.UpdateConfiguration(new List<Tuple<string, string>> { new Tuple<string, string>("primaryColor", $"{mClr.R},{mClr.G},{mClr.B}"), new Tuple<string, string>("secondaryColor", $"{sClr.R},{sClr.G},{sClr.B}") });
            mainColor = mClr; secColor = sClr;
            MainForm_Handler.ChangeColor(mClr, sClr, new List<Control>() { Header_Panel }, new List<Control>() { TileButtons_Panel }, new List<Control>() { SidePanel1, UserInterfaces_Panel,ActiveTabs_Tabcontrol }, TileButtons_Panel.Controls.OfType<ns1.BunifuTileButton>().ToList());
        }
        private void Shutdown_ImageButton_Click(object sender, EventArgs e) => MainForm_Handler.HandleExit();

        private void Dashboard_TileButton_Click(object sender, EventArgs e) => Tilebutton_Click_Handle<UsrCtrl_Dashboard>(Dashboard_TileButton);
        
        private void Todo_TileButton_Click(object sender, EventArgs e)
        {
            PreapreToAdd(Todo_TileButton);
            foreach (Control ctrl in UserInterfaces_Panel.Controls) ctrl.Dispose();
            UsrCtrl_Todo item;
            if (sender is UsrCtrl_Todo) item = sender as UsrCtrl_Todo;
            else item = sender is Enums.todoArgument ? prepareTodoUsrCtrl((sender as Enums.todoArgument?).Value) : prepareTodoUsrCtrl(Enums.todoArgument.none);

            ActiveTabs_Tabcontrol.TabPages.Add($"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count + 1}",$"{todoPageName}"/* {ActiveTabs_Tabcontrol.TabPages.OfType<TabPage>().Where(p => p.Text.Contains(todoPageName)).Count() + 1}"*/ );
            ActiveTabs_Tabcontrol.TabPages[$"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count}"].Controls.Add(item);
            item.Dock = DockStyle.Fill;
            ActiveTabs_Tabcontrol.TabPages[$"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count}"].BackColor = secColor;
            ActiveTabs_Tabcontrol.TabPages[$"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count}"].Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            ActiveTabs_Tabcontrol.PageColor = ActiveTabs_Tabcontrol.HeaderBackgroundColor = ActiveTabs_Tabcontrol.BorderColor = secColor;
            ActiveTabs_Tabcontrol.Visible = true;
            ActiveTabs_Tabcontrol.SelectedIndex = ActiveTabs_Tabcontrol.TabCount - 1;
            TileButtons_Panel.Enabled = true;

            //EndAdd(item);
        }
        private UsrCtrl_Todo prepareTodoUsrCtrl(Enums.todoArgument Arg, int? e_ID = null) => new UsrCtrl_Todo(Arg, e_ID);

        private void Finances_TileButton_Click(object sender, EventArgs e)
        {
            PreapreToAdd(Finances_TileButton);
            foreach (Control ctrl in UserInterfaces_Panel.Controls) ctrl.Dispose();
            UsrCtrl_Finances item;
            if (sender is UsrCtrl_Finances) item = sender as UsrCtrl_Finances;
            else item = sender is Enums.financeArgument ? prepareFNCUsrCtrl((sender as Enums.financeArgument?).Value) : prepareFNCUsrCtrl(Enums.financeArgument.none);
            ActiveTabs_Tabcontrol.TabPages.Add($"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count + 1}", $"{fncPageName}" /*{ActiveTabs_Tabcontrol.TabPages.OfType<TabPage>().Where(p => p.Text.Contains(fncPageName)).Count() + 1}"*/);
            ActiveTabs_Tabcontrol.TabPages[$"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count}"].Controls.Add(item);
            item.Dock = DockStyle.Fill;
            ActiveTabs_Tabcontrol.TabPages[$"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count}"].BackColor = secColor;
            ActiveTabs_Tabcontrol.TabPages[$"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count}"].Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            ActiveTabs_Tabcontrol.Width = 1685;
            ActiveTabs_Tabcontrol.PageColor = ActiveTabs_Tabcontrol.HeaderBackgroundColor = ActiveTabs_Tabcontrol.BorderColor = secColor;
            ActiveTabs_Tabcontrol.Visible = true;
            ActiveTabs_Tabcontrol.SelectedIndex = ActiveTabs_Tabcontrol.TabCount - 1;
            TileButtons_Panel.Enabled = true;
            //EndAdd(item);
        }
        private UsrCtrl_Finances prepareFNCUsrCtrl(Enums.financeArgument LoadArg, int? e_ID = null) => new UsrCtrl_Finances(LoadArg, e_ID);

        private void Notes_TileButton_Click(object sender, EventArgs e)
        {
            PreapreToAdd(Notes_TileButton);
            foreach (Control ctrl in UserInterfaces_Panel.Controls) ctrl.Dispose();
            UsrCtrl_Notes item;
            if (sender is UsrCtrl_Notes) item = sender as UsrCtrl_Notes;
            else item = sender is Enums.noteArgument? prepareNotUsrCtrl((sender as Enums.noteArgument?).Value): prepareNotUsrCtrl(Enums.noteArgument.none);

            ActiveTabs_Tabcontrol.TabPages.Add($"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count + 1}",$"{notPageName}"/* {ActiveTabs_Tabcontrol.TabPages.OfType<TabPage>().Where(p => p.Text.Contains(notPageName)).Count() + 1}"*/);
            ActiveTabs_Tabcontrol.TabPages[$"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count}"].Controls.Add(item);
            item.Dock = DockStyle.Fill;
            ActiveTabs_Tabcontrol.TabPages[$"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count}"].BackColor = secColor;
            ActiveTabs_Tabcontrol.TabPages[$"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count}"].Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            ActiveTabs_Tabcontrol.Width = 1685;
            ActiveTabs_Tabcontrol.PageColor = ActiveTabs_Tabcontrol.HeaderBackgroundColor = ActiveTabs_Tabcontrol.BorderColor = secColor;
            ActiveTabs_Tabcontrol.Visible = true;
            ActiveTabs_Tabcontrol.SelectedIndex = ActiveTabs_Tabcontrol.TabCount - 1;
            TileButtons_Panel.Enabled = true;
            //EndAdd(item);
        }


        private UsrCtrl_Notes prepareNotUsrCtrl(Enums.noteArgument LoadArg, string MethodArg = null) => new UsrCtrl_Notes(LoadArg, MethodArg);

        private void Reports_TileButton_Click(object sender, EventArgs e)
        {
            PreapreToAdd(Reports_TileButton);
            ActiveTabs_Tabcontrol.Visible = false;
            UsrCtrl_Reports item;
            if (sender is UsrCtrl_Reports) item = sender as UsrCtrl_Reports;
            else item = sender is Enums.report_tabState ? prepareRportUsrCtrl((sender as Enums.report_tabState?).Value) : prepareRportUsrCtrl(Enums.report_tabState.مهام);
            EndAdd(item);
        }
        private UsrCtrl_Reports prepareRportUsrCtrl(Enums.report_tabState LoadArg) => new UsrCtrl_Reports(LoadArg);

        private void Settings_TileButton_Click(object sender, EventArgs e) 
        {
            PreapreToAdd(Settings_TileButton);
            ActiveTabs_Tabcontrol.Visible = false;
            foreach (Control ctrl in UserInterfaces_Panel.Controls)  ctrl.Dispose();
            foreach (TabPage pag in ActiveTabs_Tabcontrol.TabPages) pag.Dispose();
            UsrCtrl_Settings item;
            if (sender is UsrCtrl_Settings) item = sender as UsrCtrl_Settings;
            else item = prepareSettingsUsrCtrl(Enums.settingsArgument.none);
            EndAdd(item);
        }
        private UsrCtrl_Settings prepareSettingsUsrCtrl(Enums.settingsArgument LoadArg, string MethodArg = "") => new UsrCtrl_Settings(LoadArg, MethodArg);
            

        void Tilebutton_Click_Handle<T>(BunifuTileButton btn) where T : Control, new()
        {
            PreapreToAdd(btn);
            ActiveTabs_Tabcontrol.Visible = false;
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

        private void Minimize_ImageButton_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void ActiveTabs_Tabcontrol_DoubleClick(object sender, EventArgs e) => ActiveTabs_Tabcontrol_KeyDown(null, new KeyEventArgs(Keys.R));

        private void ActiveTabs_Tabcontrol_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    if (ActiveTabs_Tabcontrol.SelectedTab != null) ActiveTabs_Tabcontrol.TabPages.Remove(ActiveTabs_Tabcontrol.SelectedTab);
                    break;
                case Keys.R:
                    if (e.Modifiers == Keys.Control)
                        if (ActiveTabs_Tabcontrol.SelectedTab != null)
                        {
                            var selected = ActiveTabs_Tabcontrol.SelectedTab;
                            Rectangle rect = ActiveTabs_Tabcontrol.GetTabRect(ActiveTabs_Tabcontrol.TabPages.IndexOf(selected));
                            ModdedControls.ModdedTextBox nameEdit = new ModdedControls.ModdedTextBox()
                            {
                                Bounds = new Rectangle(rect.X, ActiveTabs_Tabcontrol.Location.Y, rect.Width, rect.Height),
                                Placeholder = "أدخل اسم التبويب",
                                Font = ActiveTabs_Tabcontrol.Font,
                                Text = ActiveTabs_Tabcontrol.SelectedTab.Text
                            };
                            ActiveTabs_Tabcontrol.Parent.Controls.Add(nameEdit);
                            nameEdit.BringToFront(); nameEdit.Focus();
                            nameEdit.LostFocus += NameEdit_LostFocus;
                        }
                    break;
            }
        }
        private void NameEdit_LostFocus(object sender, EventArgs e)
        {
            ActiveTabs_Tabcontrol.SelectedTab.Text = (sender as ModdedControls.ModdedTextBox).Text;
            (sender as ModdedControls.ModdedTextBox).Dispose();
        }

        private void ActiveTabs_Tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActiveTabs_Tabcontrol.SelectedTab != null)
                if (ActiveTabs_Tabcontrol.SelectedTab.Controls.OfType<UsrCtrl_Finances>().Count() > 0) { PreapreToAdd(Finances_TileButton); TileButtons_Panel.Enabled = true; }
                else if (ActiveTabs_Tabcontrol.SelectedTab.Controls.OfType<UsrCtrl_Todo>().Count() > 0) { PreapreToAdd(Todo_TileButton); TileButtons_Panel.Enabled = true; }
                else if (ActiveTabs_Tabcontrol.SelectedTab.Controls.OfType<UsrCtrl_Notes>().Count() > 0) { PreapreToAdd(Notes_TileButton); TileButtons_Panel.Enabled = true; }
        }
    }
}
