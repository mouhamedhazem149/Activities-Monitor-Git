using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DailyCompanionV2.Forms;
using DailyCompanionV2.User_Interfaces;
using DailyCompanionV2.Utilities;
using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace DailyCompanionV2
{
    public partial class Form1 : Form
    {
        System.Threading.Timer notificationTimer;
        public Form1()
        {
            Program.WorkingForm = this;
            InitializeByResolution();
            LoadUserInfo();
            Change_Color(Color.FromArgb(int.Parse(ConfigurationManager.AppSettings["primaryColor"].Split(',')[0]), int.Parse(ConfigurationManager.AppSettings["primaryColor"].Split(',')[1]), int.Parse(ConfigurationManager.AppSettings["primaryColor"].Split(',')[2])), Color.FromArgb(int.Parse(ConfigurationManager.AppSettings["secondaryColor"].Split(',')[0]), int.Parse(ConfigurationManager.AppSettings["secondaryColor"].Split(',')[1]), int.Parse(ConfigurationManager.AppSettings["secondaryColor"].Split(',')[2])));
            State = Enums.mainformState.dashboard;
            //dele = new WinEventDelegate(WinEventProc);
           // IntPtr m_hhook = SetWinEventHook(EVENT_SYSTEM_FOREGROUND, EVENT_SYSTEM_FOREGROUND, IntPtr.Zero, dele, 0, 0, WINEVENT_OUTOFCONTEXT);
        }
        //WinEventDelegate dele = null; 

        void InitializeByResolution()
        {
            switch (Program.currentResolution)
            {
                case Enums.Resolution.A_1920x1080:
                    InitializeComponent();
                    break;
            }
        }
        public void SetTaskbarOverlay(string Text, Font customFont, Brush customBackColor, Brush customTextColor)
        {
            RectangleF rectF = new RectangleF(0, 0, 20, 20);
            Bitmap bitmap = new Bitmap(20, 20, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(bitmap);
            g.FillRectangle(customBackColor, rectF);
            g.DrawString(Text, new Font(customFont.FontFamily, 12F, customFont.Style), customTextColor, rectF, new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });

            IntPtr Hicon = bitmap.GetHicon();
            Icon taskIcon = Icon.FromHandle(Hicon);
            
            try { TaskbarManager.Instance.SetOverlayIcon(taskIcon, Text + "تنبيهات"); }
            catch (Exception ex) { }
        }
        public void SendNotification(string title, string description)
        {
            new ToastContentBuilder()
                .AddText(title)
                .AddText(description)
                .Show();
        }
        public void UpdateNotificationTimer(Enums.addedCtrls? notifState = Enums.addedCtrls.inactive)
        {
            notificationTimer = new System.Threading.Timer(arg => Notify_Sync(), null, TimeSpan.Zero, TimeSpan.FromMinutes(int.Parse(ConfigurationManager.AppSettings["notificationRefresh"].ToString())));
            if (notifState != null) notifCtState = notifState.Value;
        }
        public void Notify_Sync()
        {
            int count = Program.Notifications_List.Where(p => !p.done).Count();
            if (notifCtState == Enums.addedCtrls.inactive)
                notification_Panel.BackColor = count > 0 ? Color.DarkRed : Color.Green;

            SetTaskbarOverlay(count.ToString(), Notification_Label.Font, new SolidBrush(notification_Panel.BackColor), new SolidBrush(Notification_Label.ForeColor));
            if (Boolean.Parse(ConfigurationManager.AppSettings["sendNotification"])) 
                if (count > 0 && Notification_Label.Text != count.ToString())
                SendNotification(ProductName, $"عدد التنبيهات المطلوبة : {count}");
            
            HM_Manager.SetText(count.ToString(), Notification_Label);
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
                switch (value)
                {
                    case Enums.mainformState.dashboard:
                        CleanState(); 
                        ActiveTabs_Tabcontrol.Visible = false;
                        UserInterfaces_Panel.Visible = true;
                        Buttons_Panel.Enabled = false;
                        UsrCtrl_Dashboard dsBoard = UserInterfaces_Panel.Controls.OfType<UsrCtrl_Dashboard>().FirstOrDefault();
                        if (dsBoard != null)
                        {
                            (dsBoard as Models.ICustomControl).Sync();
                            var dashboard = UserInterfaces_Panel.Controls.OfType<UsrCtrl_Dashboard>().First();
                            dashboard.BringToFront();
                            dashboard.Sync();
                        }
                        else
                            dsBoard = new UsrCtrl_Dashboard();
                        EndAdd(dsBoard);
                        Dashboard_Button.BackColor = secColor;
                        _state = value; 
                        break;

                    case Enums.mainformState.settings:
                        switch (MessageBox.Show("سيتم حذف جميع التبويبات الحالية. هل تريد الاستمرار ؟", "تحذير", MessageBoxButtons.YesNoCancel))
                        {
                            case DialogResult.Yes:
                                foreach (TabPage pag in ActiveTabs_Tabcontrol.TabPages) pag.Dispose();
                                goto case DialogResult.No;
                            case DialogResult.No:
                                CleanState(); 
                                Buttons_Panel.Enabled = false;
                                ActiveTabs_Tabcontrol.Visible = false;
                                UserInterfaces_Panel.Visible = true;
                                UsrCtrl_Settings settingsCtrl = UserInterfaces_Panel.Controls.OfType<UsrCtrl_Settings>().FirstOrDefault();
                                if (settingsCtrl != null)
                                {
                                    (settingsCtrl as Models.ICustomControl).Sync();
                                    var settings = UserInterfaces_Panel.Controls.OfType<UsrCtrl_Settings>().First();
                                    settings.BringToFront();
                                    settings.Sync();
                                }
                                else
                                {
                                    Buttons_Panel.Enabled = false;
                                    settingsCtrl = new UsrCtrl_Settings();
                                }
                                EndAdd(settingsCtrl);
                                Settings_Button.BackColor = secColor;
                                _state = value; 
                                break;
                            case DialogResult.Cancel:
                                break;
                        }
                        break;
                    case Enums.mainformState.addtab:
                        if (ActiveTabs_Tabcontrol.TabCount > 0 || (tempControl != null && tempTabName != ""))
                        {
                            CleanState();
                            Buttons_Panel.Enabled = UserInterfaces_Panel.Visible = false;
                            TabPage_Handle(ref tempTabName, ref tempControl);
                            _state = value; Buttons_Panel.Enabled = ActiveTabs_Tabcontrol.Visible = true;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        void CleanState()
        {
            Dashboard_Button.BackColor = Settings_Button.BackColor = ControlPaint.Dark(mainColor, 0.01F);
            UserInterfaces_Panel.Controls.Cast<Control>().ToList().ForEach(p => p.Visible = false);
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

        UserControl tempControl = null;string tempTabName = "";
        //93,93,93 Main , 126,126,126 Second
        public void Change_Color(Color mClr, Color sClr)
        {
            HM_Manager.UpdateConfiguration(new List<Tuple<string, string>> { new Tuple<string, string>("primaryColor", $"{mClr.R},{mClr.G},{mClr.B}"), new Tuple<string, string>("secondaryColor", $"{sClr.R},{sClr.G},{sClr.B}") });
            mainColor = mClr; secColor = sClr;
            MainForm_Handler.ChangeColor(mClr, sClr, new List<Control>() { Header_Panel,Main_SplitContainer }, new List<Control>() { Buttons_Panel }, new List<Control>() {  UserInterfaces_Panel,ActiveTabs_Tabcontrol });
        }
        private void Shutdown_ImageButton_Click(object sender, EventArgs e) => Program.WorkingForm.Close();

        private void Dashboard_Button_Click(object sender, EventArgs e) => State = Enums.mainformState.dashboard;
        
        private void Todo_Button_Click(object sender, EventArgs e) => Click_TODO(null,null);
        private UsrCtrl_Todo prepareTodoUsrCtrl(Enums.todoArgument Arg, int? e_ID = null) => new UsrCtrl_Todo(Arg, e_ID);
        public void Click_TODO(Enums.todoArgument? Arg, int? ID)
        {
            if (ID.HasValue) tempControl = prepareTodoUsrCtrl(Arg.Value, ID.Value);
            else if (Arg.HasValue) tempControl = prepareTodoUsrCtrl(Arg.Value, null);
            else   tempControl = prepareTodoUsrCtrl(Enums.todoArgument.none);
            tempTabName = todoPageName;
            State = Enums.mainformState.addtab;
        }

        private void Finances_Button_Click(object sender, EventArgs e) => Click_FNC(null, null);
        private UsrCtrl_Finances prepareFNCUsrCtrl(Enums.financeArgument LoadArg, int? e_ID = null) => new UsrCtrl_Finances(LoadArg, e_ID);
        public void Click_FNC(Enums.financeArgument? argument, int? ID)
        {
            if (ID.HasValue) tempControl = prepareFNCUsrCtrl(argument.Value, ID.Value);
            else if (argument.HasValue) tempControl = prepareFNCUsrCtrl(argument.Value, null);
            else tempControl = prepareFNCUsrCtrl(Enums.financeArgument.none);
            tempTabName = fncPageName;
            State = Enums.mainformState.addtab;
        }
        
        private void Notes_Button_Click(object sender, EventArgs e)=> Click_Note(null,null);
        private UsrCtrl_Notes prepareNotUsrCtrl(Enums.noteArgument LoadArg, object MethodArg) => MethodArg is string
            ? new UsrCtrl_Notes(LoadArg, MethodArg as string)
            : (MethodArg is int?) ? new UsrCtrl_Notes(LoadArg, (MethodArg as int?).Value) : new UsrCtrl_Notes();
        public void Click_Note(Enums.noteArgument? argument, object argLists) 
        {
            if (argLists != null) tempControl = prepareNotUsrCtrl(argument.Value, argLists);
            else if (argument.HasValue) tempControl = prepareNotUsrCtrl(argument.Value, null);
            else tempControl = prepareNotUsrCtrl(Enums.noteArgument.none,null);
            tempTabName = notPageName;
            State = Enums.mainformState.addtab;
        }
        //public void Click_Note(Enums.noteArgument argument, int argLists) { tempControl = prepareNotUsrCtrl(argument, argLists); State = Enums.mainformState.note; }

        private void Reports_Button_Click(object sender, EventArgs e) => Click_Reports(null);
        private UsrCtrl_Reports prepareRportUsrCtrl(Enums.report_tabState LoadArg) => new UsrCtrl_Reports(LoadArg);
        public void Click_Reports(Enums.report_tabState? argument)
        {
            tempControl = argument.HasValue ? prepareRportUsrCtrl(argument.Value): prepareRportUsrCtrl(Enums.report_tabState.مهام);
            tempTabName = rprtPageName;
            State = Enums.mainformState.addtab;
        }
       
        private void Settings_Button_Click(object sender, EventArgs e) => State = Enums.mainformState.settings;
        public void Click_Settings(Enums.settingsState argument, string eventArgs = "")
        {
            State = Enums.mainformState.settings;
            UsrCtrl_Settings settings = UserInterfaces_Panel.Controls.OfType<UsrCtrl_Settings>().First();
            settings.SetState(argument, eventArgs);
        }
        
        void TabPage_Handle(ref string pgName,ref UserControl item)
        {
            if (pgName != "" && item != null)
            {
                UserInterfaces_Panel.Visible = false;
                ActiveTabs_Tabcontrol.TabPages.Add($"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count + 1}", $"{pgName}");
                ActiveTabs_Tabcontrol.TabPages[$"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count}"].Controls.Add(item);
                item.Dock = DockStyle.Fill;
                ActiveTabs_Tabcontrol.TabPages[$"{tabPageName}{ActiveTabs_Tabcontrol.TabPages.Count}"].BackColor = secColor;
                ActiveTabs_Tabcontrol.PageColor = ActiveTabs_Tabcontrol.HeaderBackgroundColor = ActiveTabs_Tabcontrol.BorderColor = secColor;
                ActiveTabs_Tabcontrol.Visible = true;
                ActiveTabs_Tabcontrol.SelectedIndex = ActiveTabs_Tabcontrol.TabCount - 1;
                item = null; pgName = "";
            }
        }

        void EndAdd(Control item) { Buttons_Panel.Enabled = true; item.Visible = true; UserInterfaces_Panel.Controls.Add(item); item.BringToFront(); }
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
           /* if (ActiveTabs_Tabcontrol.SelectedTab != null)
                if (ActiveTabs_Tabcontrol.SelectedTab.Controls.OfType<UsrCtrl_Finances>().Count() > 0) { PreapreToAdd(Finances_TileButton); TileButtons_Panel.Enabled = true; }
                else if (ActiveTabs_Tabcontrol.SelectedTab.Controls.OfType<UsrCtrl_Todo>().Count() > 0) { PreapreToAdd(Todo_TileButton); TileButtons_Panel.Enabled = true; }
                else if (ActiveTabs_Tabcontrol.SelectedTab.Controls.OfType<UsrCtrl_Notes>().Count() > 0) { PreapreToAdd(Notes_TileButton); TileButtons_Panel.Enabled = true; }*/
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
        private void Tabs_Button_Click(object sender, EventArgs e)
        {
            TabButtons_Panel.Visible = !TabButtons_Panel.Visible;
            Tabs_Button.BackColor = TabButtons_Panel.Visible ? secColor : mainColor;
            State = Enums.mainformState.addtab;
        }
        private void Form1_Shown(object sender, EventArgs e) => UpdateNotificationTimer();

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (HM_Manager.CheckUser(Login_Password_Textbox.Text, Login_Label, "نافذة الحماية المؤقتة", ref Program.mainSettings))
            {
                Main_SplitContainer.Dock = DockStyle.Fill;
                Main_SplitContainer.Visible = true;
                tempLock_Panel.Dock = DockStyle.None; tempLock_Panel.Visible = false;
            }
        }
        private async void ForgetPassword_Button_Click(object sender, EventArgs e) => await System.Threading.Tasks.Task.Run(() => LoginForm_Handler.ForgetPassword_Handle(Login_Label));
        
        FormWindowState LastWindowState = FormWindowState.Minimized;
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;
                switch (WindowState)
                {
                    case FormWindowState.Maximized:
                        break;
                    case FormWindowState.Minimized:
                        Main_SplitContainer.Dock = DockStyle.None;
                        Main_SplitContainer.Visible = false;
                        tempLock_Panel.Dock = DockStyle.Fill; Login_Password_Textbox.Text = ""; tempLock_Panel.Visible = true;
                        break;
                    case FormWindowState.Normal:
                        break;
                }
            }

        }

        #region ACTIVE_WINDOW_Changed
        delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);
        [DllImport("user32.dll")]
        static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

        private const uint WINEVENT_OUTOFCONTEXT = 0;
        private const uint EVENT_SYSTEM_FOREGROUND = 3;

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, System.Text.StringBuilder text, int count);

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            IntPtr handle = IntPtr.Zero;
            System.Text.StringBuilder Buff = new System.Text.StringBuilder(nChars);
            handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        public void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            if (GetForegroundWindow() != Handle)
                WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
