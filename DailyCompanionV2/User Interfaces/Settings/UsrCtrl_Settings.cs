using System;
using System.Linq;
using System.Windows.Forms;
using DailyCompanionV2.Models;
using DailyCompanionV2.User_Interfaces.Settings;
using DailyCompanionV2.Utilities;
using System.Collections.Generic;
using Shortcut = DailyCompanionV2.Models.Shortcut;
using System.Drawing;

namespace DailyCompanionV2.User_Interfaces
{
    public partial class UsrCtrl_Settings : UserControl, ICustomControl
    {
        public UsrCtrl_Settings() => InitialLoad();
        public void SetState(Enums.settingsState Arg, string MethodArg)
        {
            State = Arg;
            switch (Arg)
            {
                case Enums.settingsState.finance:
                    Wallet_name_Textbox.SelectedItem = Wallet_name_Textbox.Text = MethodArg;
                    break;
                default:
                    break;
            }
        }
        void InitialLoad()
        {
            InitializeByResolution();
            HM_Manager.IControlInit(this, null, null);
            UsrCtrl_TgleBtn.BackColor = prc_ToogleButton.BackColor = Program.WorkingForm.secColor;
        }
        public void Set_Tags()
        {
            Add_Wallet_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.إضافة, Title = "إضافة محافظ", color = Enums.addColor };
            Modify_Wallet_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.تعديل, Title = "تعديل محافظ", color = Enums.modColor };
            Del_Wallet_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.حذف, Title = "تعديل محافظ", color = Enums.modColor };

            Add_PRC_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.إضافة, Title = "Add Process", color = Enums.addColor };
            Del_PRC_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.تعديل, Title = "Edit Process", color = Enums.modColor };

            Shrtcuts_Objectlistview.CanExpandGetter = delegate (object rowObject) { return ((rowObject as Models.Shortcut).childrenShrtcuts != null && (rowObject as Models.Shortcut).childrenShrtcuts.Count > 0); };
            Shrtcuts_Objectlistview.ChildrenGetter = delegate (object rowObject) { return ((Models.Shortcut)rowObject).childrenShrtcuts; };

            Notif_done_Column.AspectToStringConverter = delegate (object rowObject) { return ((bool)rowObject) ? "منتهي" : "غير منتهي"; };
            Notif_repeatInt_Column.AspectToStringConverter = delegate (object rowObject) { return ((int)rowObject) == 0 ? "دائم" : ((int?)rowObject).Value.ToString(); };
            Notif_Complete_Column.AspectToStringConverter = delegate (object rowObject) { return ((bool)rowObject) ? "مكتمل" : "غير مكتمل"; };
            Notif_donedate_Column.AspectToStringConverter = delegate (object rowObject) { return ((DateTime?)rowObject).HasValue ? ((DateTime?)rowObject).Value.ToString("dddd, dd-MMMM-yyyy -- hh:mm tt") : "لم يتم الانهاء بعد"; };
        }
        public void InitializeByResolution()
        {
            switch (Program.currentResolution)
            {
                case Enums.Resolution.A_1920x1080:
                    InitializeComponent();
                    break;
            }
        }
        private Enums.settingsState _state = Enums.settingsState.none;
        public Enums.settingsState State
        {
            get => _state;
            set
            {
                if (State != Enums.settingsState.none && value != Enums.settingsState.none) State = Enums.settingsState.none;
                switch (value)
                {
                    case Enums.settingsState.general:
                        {
                            generalSettings_Panel.Visible = true;
                            break;
                        }
                    case Enums.settingsState.finance:
                        {
                            financeSettings_Panel.Visible = true;
                            break;
                        }
                    case Enums.settingsState.login:
                        {
                            loginSettings_Panel.Visible = true;
                            break;
                        }
                    case Enums.settingsState.shortcut:
                        {
                            shortcutSettings_Panel.Visible = true;
                            HM_Manager.Update_OLV(Program.Shortcuts_List, Shrtcuts_Objectlistview);
                            tempShortcut = Program.Shortcuts_List;
                            tempShortcutDelete.Clear();
                            break;
                        }
                    case Enums.settingsState.notification:
                        {
                            Notification_Panel.Visible = true;
                            HM_Manager.Update_OLV(Program.Notifications_List, Notificatons_Objectlistview);
                            tempNotification = Program.Notifications_List;
                            tempNotificationDelete.Clear();
                            break;
                        }
                    case Enums.settingsState.none:
                        {
                            generalSettings_Panel.Visible = Notification_Panel.Visible = financeSettings_Panel.Visible = loginSettings_Panel.Visible = shortcutSettings_Panel.Visible = false;
                            break;
                        }
                    default:
                        break;
                }
                _state = value;
            }
        }
        private Enums.usrctrlState _prcstate = Enums.usrctrlState.add;
        public Enums.usrctrlState processState
        {
            get => _prcstate;
            set
            {
                switch (value)
                {
                    case Enums.usrctrlState.mod:
                        {
                            shortcutsProcess_Groupbox.ForeColor = Add_PRC_Button.ForeColor = Enums.modColor;
                            shortcutsProcess_Groupbox.Text = Add_PRC_Button.Text = "Edit Process";
                            prc_ToogleButton.Checked = Del_PRC_Button.Visible = true;
                            Add_PRC_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.تعديل, Title = "Edit Process", color = Enums.modColor };
                            break;
                        }
                    case Enums.usrctrlState.add:
                        {
                            shortcutsProcess_Groupbox.ForeColor = Add_PRC_Button.ForeColor = Enums.addColor;
                            shortcutsProcess_Groupbox.Text = Add_PRC_Button.Text = "Add Process";
                            prc_ToogleButton.Checked = Del_PRC_Button.Visible = false;
                            Add_PRC_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.إضافة, Title = "Add Process", color = Enums.addColor };
                            break;
                        }
                }
                _prcstate = value;
            }
        }
        private Enums.usrctrlState _wltstate = Enums.usrctrlState.add;
        public Enums.usrctrlState walletState
        {
            get => _wltstate;
            set
            {
                switch (value)
                {
                    case Enums.usrctrlState.mod:
                        {
                            Wallets_Groupbox.ForeColor = Add_Wallet_Button.ForeColor = Enums.modColor;
                            Wallets_Groupbox.Text = Add_Wallet_Button.Text = "تعديل محافظ";
                            UsrCtrl_TgleBtn.Checked = Del_Wallet_Button.Visible = true;
                            Add_Wallet_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.تعديل, Title = "تعديل محافظ", color = Enums.modColor };
                            break;
                        }
                    case Enums.usrctrlState.add:
                        {
                            Wallets_Groupbox.ForeColor = Add_Wallet_Button.ForeColor = Enums.addColor;
                            Wallets_Groupbox.Text = Add_Wallet_Button.Text = "إضافة محافظ";
                            UsrCtrl_TgleBtn.Checked = Del_Wallet_Button.Visible = false;
                            Add_Wallet_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.إضافة, Title = "إضافة محافظ", color = Enums.addColor };
                            break;
                        }
                }
                _wltstate = value;
            }
        }
        private Wallet activeWallet = null;
        private Process activeProcess = null;
        private List<Shortcut> tempShortcut = new List<Shortcut>();
        private List<Shortcut> tempShortcutDelete = new List<Shortcut>();
        private List<Notification> tempNotification = new List<Notification>();
        private List<Notification> tempNotificationDelete = new List<Notification>();
        // // // // // // // TEXTBOXES SECTION // // // // // // //
        private void TODO_id_Textbox_TextChanged(object sender, EventArgs e) => HM_Manager.CheckTxtBoxDecimal(sender as ModdedControls.ModdedTextBox, Wallet_Label);
        private void Wallet_name_Textbox_SelectedItemChanged(object sender, EventArgs e)
        {
            if (Wallet_name_Textbox.Text != "") { walletState = Enums.usrctrlState.mod; Wallet_Button_Click("loadData", null); }
        }
        // // // // // // // BUTTONS SECTION // // // // // // //
        private void Wallet_Button_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                decimal credit = decimal.TryParse(Wallet_credit_Textbox.Text, out credit) ? decimal.Parse(Wallet_credit_Textbox.Text) : 0;
                Settings_Processor.HandleWallet(((sender as Button).Tag as settingsButtonTag_Item?).Value.handleType, Wallets_Groupbox
                    , Wallet_name_Textbox.Text, credit, Wallet_Label, ((sender as Button).Tag as settingsButtonTag_Item?).Value.Title, ((sender as Button).Tag as settingsButtonTag_Item?).Value.color
                    , activeWallet);
                activeWallet = null;
            }
            else
            {
                Settings_Processor.HandleWallet(Enums.genericHandle_Type.تحميل_البيانات, Wallets_Groupbox
                    , "", 0, Wallet_Label, (Modify_Wallet_Button.Tag as settingsButtonTag_Item?).Value.Title, (Modify_Wallet_Button.Tag as settingsButtonTag_Item?).Value.color
                    , Program.Wallets_List.Where(item => item.name == Wallet_name_Textbox.Text).FirstOrDefault());
                activeWallet = Program.Wallets_List.Where(item => item.name == Wallet_name_Textbox.Text).FirstOrDefault();
            }
            Sync();
        }
        private void Process_Button_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Settings_Processor.HandleProcess(((sender as Button).Tag as settingsButtonTag_Item?).Value.handleType, shortcutsProcess_Groupbox
                    , PRC_name_Textbox.Text, PRC_processname_Textbox.Text, PRC_Label, ((sender as Button).Tag as settingsButtonTag_Item?).Value.Title, ((sender as Button).Tag as settingsButtonTag_Item?).Value.color
                    , activeProcess);
                activeProcess = null;
            }
            else
            {
                Settings_Processor.HandleProcess(Enums.genericHandle_Type.تحميل_البيانات, shortcutsProcess_Groupbox
                    , "", "", PRC_Label, (Del_PRC_Button.Tag as settingsButtonTag_Item?).Value.Title, (Del_PRC_Button.Tag as settingsButtonTag_Item?).Value.color
                    , Program.Processs_List.Where(item => item.name == PRC_name_Textbox.Text).FirstOrDefault());
                activeProcess = Program.Processs_List.Where(item => item.name == PRC_name_Textbox.Text).FirstOrDefault();
            }
            Sync();
        }
        // // // // // // // COMBOBOXES SECTION // // // // // // //
        public void Sync()
        {
            Wallet_name_Textbox.Values = Program.Wallets_List.Select(p => p.name).ToArray();
            PRC_name_Textbox.Values = Program.Processs_List.Select(p => p.name).ToArray();
            recentTDOcount_UpDown.Value = int.Parse(System.Configuration.ConfigurationManager.AppSettings["recentTODOcount"].ToString());
            recentFNCcount_UpDown.Value = int.Parse(System.Configuration.ConfigurationManager.AppSettings["recentFNCcount"].ToString());
            recentNOTcount_UpDown.Value = int.Parse(System.Configuration.ConfigurationManager.AppSettings["recentNOTEcount"].ToString());
            notificationRefresh_UpDown.Value = int.Parse(System.Configuration.ConfigurationManager.AppSettings["notificationRefresh"].ToString());
            sendNotification_Checkbox.Checked = bool.Parse(System.Configuration.ConfigurationManager.AppSettings["sendNotification"].ToString());
        }
        private void PickColor_Button_Click(object sender, EventArgs e)
        {
            Color tempPrimary = Color.FromArgb(93, 93, 93);
            Color tempSecondary = Color.FromArgb(126, 126, 126);
            switch (MessageBox.Show("اختار لون رئيسي", "إخطار", MessageBoxButtons.OKCancel))
            {

                case DialogResult.OK:
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {
                        tempPrimary = colorDialog1.Color;
                        if (MessageBox.Show("اختار لون ثانوي. في حالة التخطي يتم اختيار درجة لون افتح من اللون الرئيسي", "إخطار", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            if (colorDialog1.ShowDialog() == DialogResult.OK)
                            {
                                tempSecondary = colorDialog1.Color;
                                Program.WorkingForm.Change_Color(tempPrimary, tempSecondary);
                            }
                            else tempSecondary = ControlPaint.Light(tempPrimary, 0.42F);
                    }
                    break;
                case DialogResult.Cancel:
                    break;
            }
            Program.WorkingForm.Change_Color(tempPrimary, tempSecondary);
        }
        private void Backup_Button_Click(object sender, EventArgs e) => BackupHelperManager.BackUp(Restore_Label);
        private void Restore_Button_Click(object sender, EventArgs e) => BackupHelperManager.Restore(Restore_Label);
        private void recentTDOcount_UpDown_ValueChanged(object sender, EventArgs e) =>
            HM_Manager.UpdateConfiguration(new List<Tuple<string, string>>() { new Tuple<string, string>("recentTODOcount", recentTDOcount_UpDown.Value.ToString()) });
        private void recentFNCcount_UpDown_ValueChanged(object sender, EventArgs e) =>
            HM_Manager.UpdateConfiguration(new List<Tuple<string, string>>() { new Tuple<string, string>("recentFNCcount", recentFNCcount_UpDown.Value.ToString()) });
        private void recentNOTcount_UpDown_ValueChanged(object sender, EventArgs e) =>
            HM_Manager.UpdateConfiguration(new List<Tuple<string, string>>() { new Tuple<string, string>("recentNOTEcount", recentNOTcount_UpDown.Value.ToString()) });
        private void notificationRefresh_UpDown_ValueChanged(object sender, EventArgs e)
        {
            HM_Manager.UpdateConfiguration(new List<Tuple<string, string>>() { new Tuple<string, string>("notificationRefresh", notificationRefresh_UpDown.Value.ToString()) });
            Program.WorkingForm.UpdateNotificationTimer(null);
        }
        private void sendNotification_Checkbox_CheckedChanged(object sender, EventArgs e) =>
            HM_Manager.UpdateConfiguration(new List<Tuple<string, string>>() { new Tuple<string, string>("sendNotification", sendNotification_Checkbox.Checked.ToString()) });
        private void UsrCtrl_TgleBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (HM_Manager.CheckIfContainWrittenEntries(Wallets_Groupbox))
                if (MessageBox.Show("هل تريد حذف المدخلات الحالية ؟", "إخطار تغيير حالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    HM_Manager.Reset_Groupbox_Controls(Wallets_Groupbox);
            if (UsrCtrl_TgleBtn.Checked) walletState = Enums.usrctrlState.mod;
            else walletState = Enums.usrctrlState.add;
        }
        private void generalSettings_Button_MouseClick(object sender, MouseEventArgs e) => State = Enums.settingsState.general;
        private void walletContainer_Button_MouseClick(object sender, MouseEventArgs e) => State = Enums.settingsState.finance;
        private void loginSettings_Button_MouseClick(object sender, MouseEventArgs e) => State = Enums.settingsState.login;
        private void Notificaiton_Button_Click(object sender, EventArgs e) => State = Enums.settingsState.notification;
        private void AddShortcut_Button_Click(object sender, EventArgs e)
        {
            if (Shrtcuts_Objectlistview.SelectedObject != null && Shrtcuts_Objectlistview.SelectedObjects.Count == 1)
            {
                var tempSht = (Shrtcuts_Objectlistview.SelectedObject as Shortcut);
                if (tempSht.childrenShrtcuts != null)
                    tempSht.childrenShrtcuts.Add(new Shortcut() { parent = tempSht, name = "", shortcut = "", process = tempSht.process });
                else tempSht.childrenShrtcuts = new List<Shortcut>() { new Shortcut() { parent = tempSht, name = "", shortcut = "", process = tempSht.process } };
                
                Shrtcuts_Objectlistview.RefreshObject(tempSht);
            }
            else Shrtcuts_Objectlistview.AddObject(new Shortcut() { name = "", shortcut = "" });
        }
        private void prc_ToogleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HM_Manager.CheckIfContainWrittenEntries(shortcutsProcess_Groupbox))
                if (MessageBox.Show("هل تريد حذف المدخلات الحالية ؟", "إخطار تغيير حالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    HM_Manager.Reset_Groupbox_Controls(shortcutsProcess_Groupbox);
            if (prc_ToogleButton.Checked) processState = Enums.usrctrlState.mod;
            else processState = Enums.usrctrlState.add;
        }
        private void shrtcutSavechanges_Button_Click(object sender, EventArgs e)
        {
            foreach (var root in Shrtcuts_Objectlistview.Roots)
            {
                Shortcut _new = (Shortcut)root; Shortcut _old = tempShortcut.Where(p => p.id == _new.id).FirstOrDefault();
                if (_old != null)
                    if (_old.Equals((Shortcut)root))
                        continue;
                    else
                        Settings_Processor.HandleShortcut(Enums.genericHandle_Type.تعديل, shortcutsProcess_Groupbox, _new.name, _new.shortcut, _new.process, _new.children,
                            Shortcut_Label, shortcutsProcess_Groupbox.Text, shortcutsProcess_Groupbox.ForeColor, _old,true);
                else
                    Settings_Processor.HandleShortcut(Enums.genericHandle_Type.إضافة, shortcutsProcess_Groupbox, _new.name, _new.shortcut, _new.process, _new.children,
                Shortcut_Label, shortcutsProcess_Groupbox.Text, shortcutsProcess_Groupbox.ForeColor, null, true);
            }
            tempShortcutDelete.Where(p => tempShortcut.Where(t => t.id == p.id).FirstOrDefault() != null).ToList().ForEach(p => Settings_Processor.HandleShortcut(Enums.genericHandle_Type.حذف, shortcutsProcess_Groupbox, "", "", 0, "",
                Shortcut_Label, shortcutsProcess_Groupbox.Text, shortcutsProcess_Groupbox.ForeColor, p, true));
            tempShortcutDelete.Clear();
        }
        private void shortcutsSettings_Button_Click(object sender, EventArgs e) => State = Enums.settingsState.shortcut;
        private void PRC_name_Textbox_SelectedItemChanged(object sender, EventArgs e)
        { if (PRC_name_Textbox.Text != "") { processState = Enums.usrctrlState.mod; Process_Button_Click("loadData", null); } }
        private void Del_Shortcut_Button_Click(object sender, EventArgs e)
        {
            foreach (Shortcut shtCut in Shrtcuts_Objectlistview.SelectedObjects.Cast<Shortcut>())
            {
                var tempParent = shtCut.parent;
                if (tempParent == null)
                { Shrtcuts_Objectlistview.RemoveObject(shtCut); tempShortcutDelete.Add(shtCut); }
                else
                { tempParent.childrenShrtcuts.Remove(shtCut); Shrtcuts_Objectlistview.RefreshObject(tempParent); }
            }
        }
        private void Shrtcuts_Objectlistview_SelectionChanged(object sender, EventArgs e) =>
            Del_Shortcut_Button.Enabled = Shrtcuts_Objectlistview.SelectedObjects != null && Shrtcuts_Objectlistview.SelectedObjects.Count > 0;
        private void Shrtcuts_Objectlistview_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e) =>
            Del_Shortcut_Button.Enabled = (Shrtcuts_Objectlistview.Items.Count > 0 && Shrtcuts_Objectlistview.SelectedObjects != null && Shrtcuts_Objectlistview.SelectedObjects.Count > 0);


        private void Objectlistview_CellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Column == Notif_freqDInt_Column && ((Notification)e.RowObject).frequency != Enums.notifFrequency.آخر) { e.Cancel = true; return; }
            if (e.Column == Notif_repeatInt_Column && ((Notification)e.RowObject).repeat != Enums.notifRepeat.محدد) { e.NewValue = null; e.Cancel = true; return; }
            if (e.Column.Tag != null)
                switch (e.Column.Tag.ToString())
                {
                    case "decimal":
                        NumericUpDown nud = new NumericUpDown()
                        {
                            Bounds = e.CellBounds,
                            Minimum = decimal.MinValue,
                            Maximum = decimal.MaxValue,
                            Value = decimal.Parse(e.Value.ToString()),
                            DecimalPlaces = 5
                        };
                        e.Control = nud;
                        break;
                    case "date":
                        DateTimePicker dtpThis = new DateTimePicker()
                        {
                            Bounds = e.CellBounds,
                            Value = DateTime.Parse(e.Value.ToString()),
                            Checked = true,
                            CustomFormat = "dddd, dd-MMMM-yyyy -- hh:mm tt",
                            Format = DateTimePickerFormat.Custom,
                            ShowUpDown = true
                        };
                        e.Control = dtpThis;
                        break;
                    case "date_nullable":
                        dtpThis = new DateTimePicker()
                        {
                            Bounds = e.CellBounds,
                            Value = e.Value is DateTime ? (e.Value as DateTime?).Value : DateTime.Now,
                            Checked = e.Value is DateTime,
                            CustomFormat = "dddd, dd-MMMM-yyyy -- hh:mm tt",
                            Format = DateTimePickerFormat.Custom,
                            ShowCheckBox = true,
                            ShowUpDown = true
                        };
                        e.Control = dtpThis;
                        break;
                    case "enum":
                        ComboBox cmboBx = new ComboBox()
                        {
                            Bounds = e.CellBounds,
                            DropDownStyle = ComboBoxStyle.DropDownList,
                            AutoCompleteSource = AutoCompleteSource.CustomSource,
                            DataSource = Enum.GetValues(e.Value.GetType()).OfType<Enum>().Select(enm => enm.GetDisplayName()).ToList(),
                            FormattingEnabled = true
                        };
                        e.Control = cmboBx;
                        break;
                    case "process_combobox":
                        cmboBx = new ComboBox()
                        {
                            Bounds = e.CellBounds,
                            DropDownStyle = ComboBoxStyle.DropDownList,
                            AutoCompleteSource = AutoCompleteSource.CustomSource,
                            FormattingEnabled = true
                        };
                        HM_Manager.Update_Combobox(cmboBx, Program.Processs_List, "name", "id");
                        e.Control = cmboBx;
                        break;
                }

            e.Control.Location = e.CellBounds.Location;
            e.Control.Size = e.CellBounds.Size;
        }
        private void Objectlistview_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Column == Notif_freqDInt_Column && ((Notification)e.RowObject).frequency != Enums.notifFrequency.آخر) { e.Cancel = true; return; }
            if (e.Column == Notif_repeatInt_Column && ((Notification)e.RowObject).repeat != Enums.notifRepeat.محدد) { e.NewValue = null; e.Cancel = true; return; }
            if (e.Column.Tag != null)
                switch (e.Column.Tag.ToString())
                {
                    case "enum":
                        e.NewValue = Enums.GetValueFromName(e.Value as Enum, e.NewValue.ToString());
                        break;
                    case "date_nullable":
                        if (((DateTimePicker)e.Control).Checked == false)
                            e.NewValue = null;
                        else e.NewValue = (e.NewValue as DateTime?).Value;
                        break;
                    case "decimal":
                        ((Notification)e.RowObject).freqDInt = (decimal)e.NewValue;
                        break;
                    case "process_combobox":
                        ((Shortcut)e.RowObject).process = (int)e.NewValue;
                        break;
                }
        }
        private void AddNotification_Button_Click(object sender, EventArgs e) => Notificatons_Objectlistview.AddObject(new Notification());
        private void Del_Notification_Button_Click(object sender, EventArgs e)
        {
            if (Notificatons_Objectlistview.SelectedObjects != null && Notificatons_Objectlistview.SelectedObjects.Count > 0)
                Notificatons_Objectlistview.SelectedObjects.Cast<Notification>().ToList().ForEach(o => { Notificatons_Objectlistview.RemoveObject(o); tempNotificationDelete.Add(o); });
        }
        private void notificationSavechanges_Button_Click(object sender, EventArgs e)
        {
            foreach (var notification in Notificatons_Objectlistview.Objects)
            {
                Notification _new = (Notification)notification; Notification _old = tempNotification.Where(p => p.id == _new.id).FirstOrDefault();
                if (_old != null)
                    if (_old.Equals(_new))
                        continue;
                    else
                        Settings_Processor.HandleNotification(Enums.genericHandle_Type.تعديل, null, _new.title,_new.description,_new.category,_new.notif_Date,_new.frequency,_new.freqDInt,_new.repeat,_new.repeatInt,_new.done_date
                            ,Notification_Label, "", Color.White, _old, true);
                else
                    Settings_Processor.HandleNotification(Enums.genericHandle_Type.إضافة, null, _new.title, _new.description, _new.category, _new.notif_Date, _new.frequency, _new.freqDInt, _new.repeat, _new.repeatInt, _new.done_date
                , Notification_Label, "", Color.White, null, true);
            }
            tempNotificationDelete.Where(p => tempNotification.Where(t => t.id == p.id).FirstOrDefault() != null).ToList().ForEach(p => Settings_Processor.HandleNotification(Enums.genericHandle_Type.حذف, null, "", "","",DateTime.Now,Enums.notifFrequency.آخر, 0,Enums.notifRepeat.محدد,0,DateTime.Now,
                Notification_Label, "", Color.White, p, true));
            tempNotificationDelete.Clear();
            
            Program.WorkingForm.Notify_Sync();
        }
        private void Notificatons_Objectlistview_ItemsChanged(object sender, BrightIdeasSoftware.ItemsChangedEventArgs e) =>
            Del_Notification_Button.Enabled = Notificatons_Objectlistview.SelectedObjects != null && Notificatons_Objectlistview.SelectedObjects.Count > 0;
        private void Notificatons_Objectlistview_SelectionChanged(object sender, EventArgs e)=>
            Del_Notification_Button.Enabled = Notificatons_Objectlistview.SelectedObjects != null && Notificatons_Objectlistview.SelectedObjects.Count > 0;
        private void Notificatons_Objectlistview_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            switch (((Notification)e.Model).completed)
            {
                case true:
                    switch (((Notification)e.Model).done)
                    {
                        case true:
                            e.Item.BackColor = Color.DarkGreen;
                            break;
                        case false:
                            e.Item.BackColor = Color.LightPink;
                            break;
                    }
                    break;
                case false:
                    switch (((Notification)e.Model).done)
                    {
                        case true:
                            e.Item.BackColor = Color.LightGreen;
                            break;
                        case false:
                            e.Item.BackColor = Color.DarkRed;
                            break;
                    }
                    break;
            }
        }
        private void Notificatons_Objectlistview_ButtonClick(object sender, BrightIdeasSoftware.CellClickEventArgs e)
        {
            ((Notification)e.Item.RowObject).done_date = DateTime.Now;
            Notificatons_Objectlistview.RefreshObject(e.Item.RowObject);
        }

    }
}
