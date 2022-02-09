using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ns1;
using DailyCompanionV2.Forms;
using DailyCompanionV2.User_Interfaces;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Program.WorkingForm = this;
            InitializeByResolution(); LoadUserInfo();
            
            Change_Color(Color.FromArgb(int.Parse(ConfigurationManager.AppSettings["primaryColor"].Split(',')[0]), int.Parse(ConfigurationManager.AppSettings["primaryColor"].Split(',')[1]), int.Parse(ConfigurationManager.AppSettings["primaryColor"].Split(',')[2])), Color.FromArgb(int.Parse(ConfigurationManager.AppSettings["secondaryColor"].Split(',')[0]), int.Parse(ConfigurationManager.AppSettings["secondaryColor"].Split(',')[1]), int.Parse(ConfigurationManager.AppSettings["secondaryColor"].Split(',')[2])));
            Notify_Sync(); notifCtState = Enums.addedCtrls.inactive;
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
        public void Notify_Sync()
        {
            int count = Program.Notifications_List.Where(p => !p.done).Count();
            Notification_Label.Text = count.ToString();
        }
        private Enums.addedCtrls _notifCtState = Enums.addedCtrls.inactive;
        public Enums.addedCtrls notifCtState
        {
            get => _notifCtState;
            set
            {
                switch (value)
                {
                    case Enums.addedCtrls.active:
                        notification_Panel.BackColor = secColor;
                        UsrCtrl_Notification toAdd = new UsrCtrl_Notification(mainColor);
                        Controls.Add(toAdd);
                        var tempLocation = this.PointToClient(Header_Panel.PointToScreen(notification_Panel.Location));
                        toAdd.Location = new Point(tempLocation.X, tempLocation.Y + notification_Panel.Height);
                        toAdd.BringToFront();
                        break;
                    case Enums.addedCtrls.inactive:
                        notification_Panel.BackColor = Program.Notifications_List.Where(p => !p.done).Count() > 0 ? Color.DarkRed : Color.Green;
                        if (Controls.OfType<UsrCtrl_Notification>() != null && Controls.OfType<UsrCtrl_Notification>().Count() > 0)
                            Controls.OfType<UsrCtrl_Notification>().ToList().ForEach(p => p.Dispose());
                        Notify_Sync();
                        break;
                }
                _notifCtState = value;
            }
        }
        private Enums.addedCtrls _shrtCtState = Enums.addedCtrls.inactive;
        public Enums.addedCtrls shrtCtState
        {
            get => _shrtCtState;
            set
            {
                switch (value)
                {
                    case Enums.addedCtrls.active:
                        Shortcut_ImageButton.BackColor = secColor;
                        UsrCtrl_Shortcut toAdd = new UsrCtrl_Shortcut(mainColor);
                        Controls.Add(toAdd);
                        var tempLocation = this.PointToClient(Header_Panel.PointToScreen(Shortcut_ImageButton.Location));
                        toAdd.Location = new Point(tempLocation.X, tempLocation.Y + Shortcut_ImageButton.Height);
                        toAdd.BringToFront();
                        break;
                    case Enums.addedCtrls.inactive:
                        Shortcut_ImageButton.BackColor = mainColor;
                        if (Controls.OfType<UsrCtrl_Shortcut>() != null && Controls.OfType<UsrCtrl_Shortcut>().Count() > 0)
                            Controls.OfType<UsrCtrl_Shortcut>().ToList().ForEach(p => p.Dispose());
                        break;
                }
                _shrtCtState = value;
            }
        }
        private Enums.mainformState _state = Enums.mainformState.dashboard;
        public Enums.mainformState State
        {
            get => _state;
            set
            {
                switch (State)
                {
                    case Enums.mainformState.dashboard:
                        break;
                    case Enums.mainformState.todo:
                        break;
                    case Enums.mainformState.finance:
                        break;
                    case Enums.mainformState.note:
                        break;
                    case Enums.mainformState.reports:
                        break;
                    case Enums.mainformState.settings:
                        break;
                    default:
                        break;
                }
                _state = value;
            }
        }
        public Color mainColor = Color.Transparent;
        public Color secColor = Color.Transparent;
        public static string tabPageName = "tabPage";
        public static string todoPageName = "تبويب المهام:";
        public static string fncPageName = "تبويب المالية:";
        public static string notPageName = "تبويب الملاحظات:";
        public static string rprtPageName = "تبويب التقارير:";

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
        public void Click_Note(Enums.noteArgument argument, string argLists) => Notes_TileButton_Click(prepareNotUsrCtrl(argument, argLists), EventArgs.Empty);
        public void Click_Note(Enums.noteArgument argument, int argLists) => Notes_TileButton_Click(prepareNotUsrCtrl(argument, argLists), EventArgs.Empty);
        public void Click_Reports(Enums.report_tabState argument) => Reports_TileButton_Click(prepareRportUsrCtrl(argument), EventArgs.Empty);
        public void Click_Settings(Enums.settingsState argument, string eventArgs = "") => Settings_TileButton_Click(prepareSettingsUsrCtrl(argument, eventArgs), EventArgs.Empty);
        //93,93,93 Main , 126,126,126 Second
        public void Change_Color(Color mClr, Color sClr)
        {
            HM_Manager.UpdateConfiguration(new List<Tuple<string, string>> { new Tuple<string, string>("primaryColor", $"{mClr.R},{mClr.G},{mClr.B}"), new Tuple<string, string>("secondaryColor", $"{sClr.R},{sClr.G},{sClr.B}") });
            mainColor = mClr; secColor = sClr;
            MainForm_Handler.ChangeColor(mClr, sClr, new List<Control>() { Header_Panel,Main_SplitContainer }, new List<Control>() { TileButtons_Panel }, new List<Control>() { SidePanel1, UserInterfaces_Panel,ActiveTabs_Tabcontrol }, TileButtons_Panel.Controls.OfType<ns1.BunifuTileButton>().ToList());
        }
        private void Shutdown_ImageButton_Click(object sender, EventArgs e) => Program.WorkingForm.Close();

        private void Dashboard_TileButton_Click(object sender, EventArgs e) => Tilebutton_Click_Handle<UsrCtrl_Dashboard>(Dashboard_TileButton);

        private void Todo_TileButton_Click(object sender, EventArgs e)
        {
            UsrCtrl_Todo item = sender is UsrCtrl_Todo ? sender as UsrCtrl_Todo : sender is Enums.todoArgument
                       ? prepareTodoUsrCtrl((sender as Enums.todoArgument?).Value)
                       : prepareTodoUsrCtrl(Enums.todoArgument.none);
            Tilebutton_Click_Handle(Todo_TileButton, todoPageName, item);
        }
        private UsrCtrl_Todo prepareTodoUsrCtrl(Enums.todoArgument Arg, int? e_ID = null) => new UsrCtrl_Todo(Arg, e_ID);

        private void Finances_TileButton_Click(object sender, EventArgs e)
        {
            UsrCtrl_Finances item = sender is UsrCtrl_Finances ? sender as UsrCtrl_Finances : sender is Enums.financeArgument
                     ? prepareFNCUsrCtrl((sender as Enums.financeArgument?).Value)
                     : prepareFNCUsrCtrl(Enums.financeArgument.none);
            Tilebutton_Click_Handle(Finances_TileButton, fncPageName, item);
        }
        private UsrCtrl_Finances prepareFNCUsrCtrl(Enums.financeArgument LoadArg, int? e_ID = null) => new UsrCtrl_Finances(LoadArg, e_ID);

        private void Notes_TileButton_Click(object sender, EventArgs e)
        {
            UsrCtrl_Notes item = sender is UsrCtrl_Notes ? sender as UsrCtrl_Notes : sender is Enums.noteArgument
                   ? prepareNotUsrCtrl((sender as Enums.noteArgument?).Value)
                   : prepareNotUsrCtrl(Enums.noteArgument.none);
            Tilebutton_Click_Handle(Notes_TileButton, notPageName, item);
        }
        private UsrCtrl_Notes prepareNotUsrCtrl(Enums.noteArgument LoadArg, string MethodArg = null) => new UsrCtrl_Notes(LoadArg, MethodArg);
        private UsrCtrl_Notes prepareNotUsrCtrl(Enums.noteArgument LoadArg, int MethodArg) => new UsrCtrl_Notes(LoadArg, MethodArg);

        private void Reports_TileButton_Click(object sender, EventArgs e)
        {
            UsrCtrl_Reports item = sender is UsrCtrl_Reports ? sender as UsrCtrl_Reports : sender is Enums.report_tabState
                   ? prepareRportUsrCtrl((sender as Enums.report_tabState?).Value)
                   : prepareRportUsrCtrl(Enums.report_tabState.مهام);
            Tilebutton_Click_Handle(Reports_TileButton, rprtPageName, item);
        }
        private UsrCtrl_Reports prepareRportUsrCtrl(Enums.report_tabState LoadArg) => new UsrCtrl_Reports(LoadArg);

        private void Settings_TileButton_Click(object sender, EventArgs e)
        {
           // Tilebutton_Click_Handle<UsrCtrl_Settings>(Settings_TileButton);
            PreapreToAdd(Settings_TileButton);
            ActiveTabs_Tabcontrol.Visible = false;
            foreach (Control ctrl in UserInterfaces_Panel.Controls)  ctrl.Dispose();
            foreach (TabPage pag in ActiveTabs_Tabcontrol.TabPages) pag.Dispose();
            UsrCtrl_Settings item;
            if (sender is UsrCtrl_Settings) item = sender as UsrCtrl_Settings;
            else item = prepareSettingsUsrCtrl(Enums.settingsState.none);
            EndAdd(item);
        }
        private UsrCtrl_Settings prepareSettingsUsrCtrl(Enums.settingsState LoadArg, string MethodArg = "") => new UsrCtrl_Settings(LoadArg, MethodArg);
            

        void Tilebutton_Click_Handle<T>(BunifuTileButton btn) where T : Control, new()
        {
            PreapreToAdd(btn);
            ActiveTabs_Tabcontrol.Visible = false;
            foreach (Control ctrl in UserInterfaces_Panel.Controls) ctrl.Dispose();
            T item = new T(); EndAdd(item);
        }
        void Tilebutton_Click_Handle(BunifuTileButton tileBtn,string pgName,UserControl item)
        {
            PreapreToAdd(tileBtn);
            foreach (Control ctrl in UserInterfaces_Panel.Controls) ctrl.Dispose();
            ActiveTabs_Tabcontrol.TabPages.Add($"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count + 1}", $"{pgName}");
            ActiveTabs_Tabcontrol.TabPages[$"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count}"].Controls.Add(item);
            item.Dock = DockStyle.Fill;
            ActiveTabs_Tabcontrol.TabPages[$"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count}"].BackColor = secColor;
            ActiveTabs_Tabcontrol.PageColor = ActiveTabs_Tabcontrol.HeaderBackgroundColor = ActiveTabs_Tabcontrol.BorderColor = secColor;
            ActiveTabs_Tabcontrol.Visible = true;
            ActiveTabs_Tabcontrol.SelectedIndex = ActiveTabs_Tabcontrol.TabCount - 1;
            TileButtons_Panel.Enabled = true;
        }
        void PreapreToAdd(BunifuTileButton btn)
        {
            if (btn == null) return;
            SidePanel1.Height = btn.Height; SidePanel1.Top = btn.Top;
            TileButtons_Panel.Enabled = false;
            SidePanel1.BringToFront();
        }
        void EndAdd(Control item) { TileButtons_Panel.Enabled = true; UserInterfaces_Panel.Controls.Add(item); item.BringToFront(); }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) 
        {
            if (MessageBox.Show("هل تريد الخروج من البرنامج ؟", "خروج من البرنامج", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
            else
                HM_Manager.HandleHistory(new string[] { "المستخدمين", "تسجيل خروج", $"اسم المستخدم: {Program.mainSettings.name}" });
        }
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
                    if (ActiveTabs_Tabcontrol.SelectedTab != null)
                        if (MessageBox.Show("سيتم حذف التبويب الحالي. تأكيد ؟","إخطار",MessageBoxButtons.OKCancel) == DialogResult.OK)
                            ActiveTabs_Tabcontrol.TabPages.Remove(ActiveTabs_Tabcontrol.SelectedTab);
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

        private void Shortcut_ImageButton_Click(object sender, EventArgs e) => 
            shrtCtState = shrtCtState == Enums.addedCtrls.active ? Enums.addedCtrls.inactive : Enums.addedCtrls.active;
        private void Notification_ImageButton_Click(object sender, EventArgs e) =>
            notifCtState = notifCtState == Enums.addedCtrls.active ? Enums.addedCtrls.inactive : Enums.addedCtrls.active;

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {// 0x210 is WM_PARENTNOTIFY    // 513 is WM_LBUTTONCLICK
            if (m.Msg == 0x210 && m.WParam.ToInt32() == 513)
            {
                // get the clicked position
                var x = (int)(m.LParam.ToInt32() & 0xFFFF); var y = (int)(m.LParam.ToInt32() >> 16);
                Control childControl = this.GetChildAtPoint(new Point(x, y));// get the clicked control
                OnClick(EventArgs.Empty);// call onClick (which fires Click event)
                if (shrtCtState == Enums.addedCtrls.active
                    && !Controls.OfType<UsrCtrl_Shortcut>().First().ClientRectangle.Contains(x - Controls.OfType<UsrCtrl_Shortcut>().First().Location.X, y - Controls.OfType<UsrCtrl_Shortcut>().First().Location.Y))
                    shrtCtState = Enums.addedCtrls.inactive;
                if (notifCtState == Enums.addedCtrls.active
                        && !Controls.OfType<UsrCtrl_Notification>().First().ClientRectangle.Contains(x - Controls.OfType<UsrCtrl_Notification>().First().Location.X, y - Controls.OfType<UsrCtrl_Notification>().First().Location.Y))
                    notifCtState = Enums.addedCtrls.inactive;
            }
            base.WndProc(ref m);
        }
    }
}
