using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DailyCompanionV2.Models;
using DailyCompanionV2.User_Interfaces.Finance;
using DailyCompanionV2.User_Interfaces.Settings;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2
{
    public partial class UsrCtrl_Finances : UserControl, ICustomControl
    {
        public static string fncLoadArg = "LoadFinances";
        public UsrCtrl_Finances() => InitialLoad();
        public UsrCtrl_Finances(Enums.financeArgument LoadArg, int? e_ID)
        {
            InitialLoad();
            switch (LoadArg)
            {
                case Enums.financeArgument.loadFinanceItem:
                    if (e_ID.HasValue)
                    { State = Enums.usrctrlState.mod; FNC_id_Textbox.SelectedItem = FNC_id_Textbox.Text = e_ID.Value.ToString(); }
                    break;
                case Enums.financeArgument.showFinanceManager:
                    { State = Enums.usrctrlState.add; Aux_state = Enums.financeAuxState.none; }
                    break;
                default:
                    break;
            }
        }
        private ModdedControls.ModdedTextBox focusedTextbox = null;
        void InitialLoad()
        {
            InitializeByResolution();
            UsrCtrl_TgleBtn.BackColor = Program.WorkingForm.secColor;
            aux_TablePanel.BackColor = Program.WorkingForm.mainColor;
            HM_Manager.IControlInit(this, null, Side_Panel);
            FNC_type_Combobox.DataSource = Enum.GetValues(typeof(Enums.financeType)).OfType<Enums.financeType>().Select(enm => enm.GetDisplayName()).ToList();
            HM_Manager.Update_Combobox(FNC_wallet_Combobox, Program.Wallets_List, "name", "id");
        }
        public void Sync()
        {
            FNC_id_Textbox.Values = Program.Finances_List.Select(tdo => tdo.id.ToString()).ToArray();
            FNC_relatedentity_Textbox.Values = HM_Manager.commonEntities;
            FNC_category_Textbox.Values = HM_Manager.commonCategories;
            PrepareSidePanel();
        }
        private Enums.usrctrlState _state = Enums.usrctrlState.add;
        public Enums.usrctrlState State
        {
            get => _state;
            set
            {
                switch (value)
                {
                    case Enums.usrctrlState.mod:
                        {
                            AddFinance_Groupbox.ForeColor = Add_FNC_Button.ForeColor = Enums.modColor;
                            AddFinance_Groupbox.Text = Add_FNC_Button.Text = "تعديل عملية مالية";
                            UsrCtrl_TgleBtn.Checked = Del_FNC_Button.Visible = FNC_id_Textbox.Visible = true;
                            Add_FNC_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.تعديل, Title = "تعديل مهام", color = Enums.modColor };
                            break;
                        }
                    case Enums.usrctrlState.add:
                        {
                            AddFinance_Groupbox.ForeColor = Add_FNC_Button.ForeColor = Enums.addColor;
                            AddFinance_Groupbox.Text = Add_FNC_Button.Text = "إضافة عملية مالية";
                            UsrCtrl_TgleBtn.Checked = Del_FNC_Button.Visible = FNC_id_Textbox.Visible = FNC_id_Label.Visible = false;
                            Add_FNC_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.إضافة, Title = "إضافة مهام", color = Enums.addColor };
                            break;
                        }
                }
                _state = value;
            }
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
        public void Set_Tags()
        {
            Add_FNC_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.إضافة, Title = "إضافة عملية مالية", color = Enums.addColor };
            Del_FNC_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.حذف, Title = "تعديل عملية مالية", color = Enums.modColor };

            TypFNC_Column.AspectToStringConverter = delegate (object rowObject) { return (rowObject as Enum).GetDisplayName(); };
            finalFNC_Column.GroupKeyGetter = delegate (object rowObject) { return DateTime.Parse(((Finances)rowObject).due_date.ToString("d")); };
            finalFNC_Column.GroupKeyToTitleConverter = delegate (object groupKey) { return ((DateTime)groupKey).ToString("dddd, dd MMMM,yyyy", System.Globalization.CultureInfo.GetCultureInfo("ar-EG")); };

            AddFinance_Groupbox.ContextMenuStrip = Tabcontrol_contextMenuStrip;
        }
        private void UpdateRelatedWallets() => HM_Manager.Update_Combobox(FNC_relatedentity_Combobox, Program.Wallets_List.Where(p => p.id != (FNC_wallet_Combobox.SelectedValue as int?).Value).ToList(), "name", "id");
        private void FNC_Button_Click(object sender, EventArgs e)
        {
            if (sender is Button || sender is ns1.BunifuImageButton)
            {
                double tempDue = double.TryParse(FNC_due_Textbox.Text, out tempDue) ? double.Parse(FNC_due_Textbox.Text) : 0;
                double tempPaid = double.TryParse(FNC_paid_Textbox.Text, out tempPaid) ? double.Parse(FNC_paid_Textbox.Text) : 0;
                Finances_Processor.HandleFNC(((sender as Control).Tag as settingsButtonTag_Item?).Value.handleType, AddFinance_Groupbox
                    , FNC_relatedentity_Textbox.Text, Enums.GetValueFromName<Enums.financeType>(FNC_type_Combobox.Text) /*(Enums.financeType)Enum.Parse(typeof(Enums.financeType), FNC_type_Combobox.Text)*/, (FNC_wallet_Combobox.SelectedValue as int?).Value, FNC_category_Textbox.Text, tempDue, tempPaid, FNC_due_date_Datetimepicker.Value, FNC_done_date_Datetimepicker.Checked, FNC_done_date_Datetimepicker.Value, FNC_notes_Textbox.Text
                    , FNC_Label, ((sender as Control).Tag as settingsButtonTag_Item?).Value.Title, ((sender as Control).Tag as settingsButtonTag_Item?).Value.color
                    , Program.Finances_List.Where(item => item.id.ToString() == FNC_id_Textbox.Text).FirstOrDefault());
            }
            else
                Finances_Processor.HandleFNC(Enums.genericHandle_Type.تحميل_البيانات, AddFinance_Groupbox
                    , "", Enums.financeType.دخل, 0, "", 0, 0, DateTime.Now, false, DateTime.Now, "", FNC_Label, (Del_FNC_Button.Tag as settingsButtonTag_Item?).Value.Title, (Del_FNC_Button.Tag as settingsButtonTag_Item?).Value.color
                    , Program.Finances_List.Where(item => item.id.ToString() == FNC_id_Textbox.Text).FirstOrDefault());
            Sync();
        }
        private void id_Textbox_TextChanged(object sender, EventArgs e) => HM_Manager.CheckTxtBoxInt(sender as TextBox, FNC_id_Label);
        private void FNC_id_Textbox_SelectedItemChanged(object sender, EventArgs e)
        {
            if (FNC_id_Textbox.Text != "")
            {
                FNC_Button_Click("loadData", null);
                if (Parent is TabPage)
                    (Parent as TabPage).Text = FNC_id_Textbox.Text;
                else Tag = FNC_id_Textbox.Text;
            }
        }
        private void FNC_value_Textbox_TextChanged(object sender, EventArgs e) { HM_Manager.CheckTxtBoxDecimal(sender as ModdedControls.ModdedTextBox, FNC_Label); CheckValidWalletPaid(); }
        private void FNC_wallet_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboboxWlt != null) HM_Manager.Success_addition(FNC_WltCrdt_Label, $"رصيد المحفظة : {cmboboxWlt.credit} جنيه");
            else FNC_WltCrdt_Label.Visible = false;
            CheckValidWalletPaid();
            if (FNC_relatedentity_Combobox.Visible) UpdateRelatedWallets();
        }
        private void FNC_type_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Enums.GetValueFromName<Enums.financeType>(FNC_type_Combobox.Text))
            {
                case Enums.financeType.تحويل_أرصدة:
                    FNC_type_Panel.BackColor = Color.Blue;
                    FNC_relatedentity_Textbox.Visible = false;
                    FNC_relatedentity_Combobox.Visible = true; FNC_relatedentity_Combobox.Dock = DockStyle.Fill;
                    UpdateRelatedWallets();
                    break;
                case Enums.financeType.مدفوعات:
                    FNC_type_Panel.BackColor = Color.Red;
                    FNC_relatedentity_Textbox.Visible = true; FNC_relatedentity_Textbox.Dock = DockStyle.Fill;
                    FNC_relatedentity_Combobox.Visible = false;
                    break;
                case Enums.financeType.دخل:
                    FNC_type_Panel.BackColor = Color.Green; 
                    FNC_relatedentity_Textbox.Visible = true; FNC_relatedentity_Textbox.Dock = DockStyle.Fill;
                    FNC_relatedentity_Combobox.Visible = false;
                    break;
            }
            CheckValidWalletPaid();
        }
        private Wallet cmboboxWlt => Program.Wallets_List.Where(p => p.id == (FNC_wallet_Combobox.SelectedValue as int?).Value).FirstOrDefault();
        private void CheckValidWalletPaid()
        {
            decimal temp = 0;
            if ((FNC_type_Combobox.Text == Enums.financeType.مدفوعات.GetDisplayName() || FNC_type_Combobox.Text == Enums.financeType.تحويل_أرصدة.GetDisplayName()))
                if (decimal.TryParse(FNC_paid_Textbox.Text, out temp))
                    if (AddFinance_Groupbox.ForeColor == Enums.addColor)
                    {
                        if (temp > cmboboxWlt.credit)
                        {
                            FNC_paid_Textbox.Text = cmboboxWlt.credit.ToString();
                            HM_Manager.Fail_addition(FNC_Label, "لا يمكن ان تكون القيمة المدفوعة اكبر من رصيد المحفظة");
                        }
                    }
                    else
                    {
                        if (temp > cmboboxWlt.credit + (decimal)Program.Finances_List.Where(p => p.id.ToString() == FNC_id_Textbox.Text).First().paid)
                        {
                            FNC_paid_Textbox.Text = cmboboxWlt.credit.ToString();
                            HM_Manager.Fail_addition(FNC_Label, "لا يمكن ان تكون القيمة المدفوعة اكبر من رصيد المحفظة");
                        }
                    }
        }
        private void FNC_relatedwallet_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FNC_relatedentity_Combobox.Visible) FNC_relatedentity_Textbox.Text = FNC_relatedentity_Combobox.Text;
        }
        private void pasteToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                if (Program.WorkingForm.clippedControl != null) HM_Manager.Copy(Program.WorkingForm.clippedControl, Tabcontrol_contextMenuStrip.SourceControl);
        }
        private void copyToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            { Program.WorkingForm.clippedControl = Tabcontrol_contextMenuStrip.SourceControl; pasteToolStripMenuItem.Enabled = true; }
        }
        private void nowToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                (DTPicker_contextMenuStrip.SourceControl as DateTimePicker).Value = DateTime.Now;
        }
        private void FNC_Textbox_cmnFlr_SelectedItemChanged(object sender, EventArgs e)
        {
            if ((sender as ModdedControls.ModdedTextBox).SelectedItem != null && (sender as ModdedControls.ModdedTextBox).SelectedItem != "")
            {
                Finances cmnFlr = HM_Manager.commonFiller(Program.Finances_List.Where(p => p.GetType().GetProperty(HM_Manager.Propertyfromcontrol(sender as ModdedControls.ModdedTextBox)).GetValue(p).ToString() == (sender as ModdedControls.ModdedTextBox).SelectedItem).ToList());
                if (cmnFlr != null)
                {
                    HM_Manager.SetControlsFromModel(AddFinance_Groupbox, cmnFlr);
                    LoadFNCSimilarNode();
                    if (Parent is TabPage)
                        (Parent as TabPage).Text = (sender as ModdedControls.ModdedTextBox).Text;
                }
            }
            else (Parent as TabPage).Text = "";
        }
        private void UsrCtrl_TgleBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (HM_Manager.CheckIfContainWrittenEntries(AddFinance_Groupbox))
                if (MessageBox.Show("هل تريد حذف المدخلات الحالية ؟", "إخطار تغيير حالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    HM_Manager.Reset_Groupbox_Controls(AddFinance_Groupbox);
            if (UsrCtrl_TgleBtn.Checked) State = Enums.usrctrlState.mod;
            else State = Enums.usrctrlState.add;
        }

        private void FNC_Textbox_Enter(object sender, EventArgs e)
        {
            if (sender is ModdedControls.ModdedTextBox && (sender as Control).Focused)
            {
                focusedTextbox = sender as ModdedControls.ModdedTextBox;
                LoadFNCPreviousNode();
                if (focusedTextbox.SelectedItem == focusedTextbox.Text && focusedTextbox.SelectedItem != null) LoadFNCSimilarNode();
            }
        }
    }
}
