using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ns1;
using OpsMoi.Models;
using OpsMoi.User_Interfaces.Finance;
using OpsMoi.User_Interfaces.Settings;
using OpsMoi.Utilities;

namespace OpsMoi
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
                    if (e_ID.HasValue) FNC_id_Textbox.SelectedItem = FNC_id_Textbox.Text = e_ID.Value.ToString();
                    break;
                case Enums.financeArgument.showFinanceManager:
                    TileButton_Click(FNCManager_TileButton, EventArgs.Empty);
                    break;
                default:
                    break;
            }
        }
        void InitialLoad()
        {
            InitializeByResolution(); 
            HM_Manager.IControlInit(this, FNC_TabControl, TileButtons_Panel);
            FNC_type_Combobox.DataSource = Enum.GetValues(typeof(Enums.financeType)).OfType<Enums.financeType>().Select(enm => enm.GetDisplayName()).ToList();
            HM_Manager.Update_Combobox(FNC_wallet_Combobox, Program.Wallets_List, "name", "id");
        }
        public DateTime Wlts_From { get { return WltsOps_From_Datetimepicker.Value; } }
        public DateTime Wlts_To { get { return WltsOps_To_Datetimepicker.Value; } }
        private void LoadWltsOps(DateTime From, DateTime To)
        {
            if (To < From) return;
            List<int> Ids = Wlts_Search_Objectlistview.SelectedObjects != null ? Wlts_Search_Objectlistview.SelectedObjects.OfType<Wallet>().Select(p => p.id).ToList() : new List<int>();
            HM_Manager.Update_OLV(Program.Finances_List.Where(p => p.done_date.HasValue && p.done_date.Value >= From && p.done_date.Value <= To && Ids.Contains(p.wallet)).ToList(), Wlts_Objectlistview);
        }
        private void LoadWltsSearch()
        {
            HM_Manager.Update_OLV(Program.Wallets_List, Wlts_Search_Objectlistview);
            HM_Manager.Success_addition(WalletsSearch_Label, $"تم تحميل المحافظ بنجاح. إجمالي الرصيد المتاح في جميع المحافظ: {Program.Wallets_List.Sum(p => p.credit)}");
        }
        public void Sync()
        {
            FNC_id_Textbox.Values = Program.Finances_List.Select(tdo => tdo.id.ToString()).ToArray();
            FNC_relatedentity_Textbox.Values = HM_Manager.commonEntities;
            FNC_category_Textbox.Values = HM_Manager.commonCategories;
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
            Modify_FNC_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.تعديل, Title = "تعديل عملية مالية", color = Enums.modColor };
            Del_FNC_Button.Tag = new settingsButtonTag_Item() { handleType = Enums.genericHandle_Type.حذف, Title = "تعديل عملية مالية", color = Enums.modColor };
        }

        private void UpdateRelatedWallets() => HM_Manager.Update_Combobox(FNC_relatedentity_Combobox, Program.Wallets_List.Where(p => p != FNC_wallet_Combobox.SelectedValue).ToList(), "name", "id");
        
        private void FNC_Button_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                double tempDue = double.TryParse(FNC_due_Textbox.Text, out tempDue) ? double.Parse(FNC_due_Textbox.Text) : 0;
                double tempPaid = double.TryParse(FNC_paid_Textbox.Text, out tempPaid) ? double.Parse(FNC_paid_Textbox.Text) : 0;
                Finances_Processor.HandleFNC(((sender as Button).Tag as settingsButtonTag_Item?).Value.handleType, AddFinance_Groupbox
                    , FNC_relatedentity_Textbox.Text,Enums.GetValueFromName<Enums.financeType>(FNC_type_Combobox.Text) /*(Enums.financeType)Enum.Parse(typeof(Enums.financeType), FNC_type_Combobox.Text)*/,(FNC_wallet_Combobox.SelectedValue as int?).Value, FNC_category_Textbox.Text, tempDue, tempPaid, FNC_due_date_Datetimepicker.Value, FNC_done_date_Datetimepicker.Checked, FNC_done_date_Datetimepicker.Value, FNC_notes_Textbox.Text
                    , FNC_Label, ((sender as Button).Tag as settingsButtonTag_Item?).Value.Title, ((sender as Button).Tag as settingsButtonTag_Item?).Value.color
                    , Program.Finances_List.Where(item => item.id.ToString() == FNC_id_Textbox.Text).FirstOrDefault());
            }
            else
                Finances_Processor.HandleFNC(Enums.genericHandle_Type.تحميل_البيانات, AddFinance_Groupbox
                    , "", Enums.financeType.دخل,0, "", 0,0 ,DateTime.Now,false ,DateTime.Now, "", FNC_Label, (Modify_FNC_Button.Tag as settingsButtonTag_Item?).Value.Title, (Modify_FNC_Button.Tag as settingsButtonTag_Item?).Value.color
                    , Program.Finances_List.Where(item => item.id.ToString() == FNC_id_Textbox.Text).FirstOrDefault());
            Sync();
        }

        private void TileButton_Click(object sender, EventArgs e) =>
           HM_Manager.TabButtonsClick(FNC_TabControl, TileButtons_Panel, sender as BunifuTileButton, SidePanel1);


        private void id_Textbox_TextChanged(object sender, EventArgs e) => HM_Manager.CheckTxtBoxInt(sender as TextBox, id_Label);

        private void FNC_id_Textbox_SelectedItemChanged(object sender, EventArgs e)
        {
            if (FNC_id_Textbox.Text != "")
                FNC_Button_Click("loadData", null);
        }

        private void AddFNC_Groupbox_ForeColorChanged(object sender, EventArgs e) { HM_Manager.Reset_Groupbox_Controls(sender as GroupBox); FNC_id_Textbox.Enabled = (sender as GroupBox).ForeColor == Enums.modColor;/* editControls.ForEach(ctrl => ctrl.Visible = */ }

        private void FNC_value_Textbox_TextChanged(object sender, EventArgs e) { HM_Manager.CheckTxtBoxDecimal(sender as ModdedControls.ModdedTextBox, FNC_Label); CheckValidWalletPaid(); }

        private void FNC_wallet_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckValidWalletPaid();
            if (FNC_relatedentity_Combobox.Visible) UpdateRelatedWallets();
        }

        private void FNC_type_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enums.GetValueFromName<Enums.financeType>(FNC_type_Combobox.Text) == Enums.financeType.تحويل_أرصدة) { FNC_relatedentity_Textbox.Visible = false; FNC_relatedentity_Combobox.Visible = true; }
            else { FNC_relatedentity_Textbox.Visible = true; FNC_relatedentity_Combobox.Visible = false; }
            CheckValidWalletPaid();
        }
        private void CheckValidWalletPaid()
        {
            decimal temp = 0;
            if ((FNC_type_Combobox.Text == Enums.financeType.مدفوعات.GetDisplayName() || FNC_type_Combobox.Text == Enums.financeType.تحويل_أرصدة.GetDisplayName()))
                if (decimal.TryParse(FNC_paid_Textbox.Text, out temp))
                    if (AddFinance_Groupbox.ForeColor == Enums.addColor)
                    { 
                        if (temp > Program.Wallets_List.Where(p => p.id == (FNC_wallet_Combobox.SelectedValue as int?).Value).First().credit)
                        {
                            FNC_paid_Textbox.Text = Program.Wallets_List.Where(p => p.id == (FNC_wallet_Combobox.SelectedValue as int?).Value).First().credit.ToString();
                            HM_Manager.Fail_addition(FNC_Label, "لا يمكن ان تكون القيمة المدفوعة اكبر من رصيد المحفظة");
                        } 
                    }
                    else
                    {
                        if (temp > Program.Wallets_List.Where(p => p.id == (FNC_wallet_Combobox.SelectedValue as int?).Value).First().credit + (decimal)Program.Finances_List.Where(p => p.id.ToString() == FNC_id_Textbox.Text).First().paid)
                        {
                            FNC_paid_Textbox.Text = Program.Wallets_List.Where(p => p.id == (FNC_wallet_Combobox.SelectedValue as int?).Value).First().credit.ToString();
                            HM_Manager.Fail_addition(FNC_Label, "لا يمكن ان تكون القيمة المدفوعة اكبر من رصيد المحفظة");
                        }
                    }
        }

        private void FNC_relatedwallet_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FNC_relatedentity_Combobox.Visible) { FNC_relatedentity_Textbox.Text = FNC_relatedentity_Combobox.Text; UpdateRelatedWallets(); }
        }

        private void Wlts_Objectlistview_DoubleClick(object sender, EventArgs e)
        {
            if (Wlts_Objectlistview.SelectedObjects != null && Wlts_Objectlistview.SelectedObjects.Count == 1)
                Program.WorkingForm.Click_FNC(Enums.financeArgument.loadFinanceItem, (Wlts_Objectlistview.SelectedObject as Finances).id);
        }

        private void FNC_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FNC_TabControl.SelectedTab == SearchOps_Wlt_Tabpage)
            {
                LoadWltsSearch();
                LoadWltsOps(Wlts_From, Wlts_To);
            }
        }

        private void Wlts_Objectlistview_AboutToCreateGroups(object sender, BrightIdeasSoftware.CreateGroupsEventArgs e)
        {
            foreach (BrightIdeasSoftware.OLVGroup group in e.Groups)
            {
                int count = group.Items.Count;
                double totalIncome = group.Items.Where(p => ((Finances)p.RowObject).type == Enums.financeType.دخل).Sum(p => ((Finances)p.RowObject).paid);
                double totalPaid = group.Items.Sum(p => ((Finances)p.RowObject).paid) - totalIncome;
                double totalNet = totalIncome - totalPaid;
                string tempHeader = group.Header == null ? "" : group.Header;
                group.Header = string.Format($"{tempHeader} :: عدد العمليات المالية : {count}  بإجمالي مدفوعات : {totalPaid.ToString("N2")} وإجمالي دخل : {totalIncome.ToString("N2")} بصافي دخل : {totalNet}");
                group.Tag = count;
            }
            if (e.Parameters.PrimarySortOrder == SortOrder.Descending) e.Groups = e.Groups.OrderByDescending(p => (p.Tag as int?).Value).ToList();
            else e.Groups = e.Groups.OrderBy(p => (p.Tag as int?).Value).ToList();
        }

        private void Wlts_Objectlistview_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            if ((e.Item.RowObject as Finances).type == Enums.financeType.دخل)
                e.Item.BackColor = Color.Green;
            else if ((e.Item.RowObject as Finances).type == Enums.financeType.مدفوعات)
                e.Item.BackColor = Color.Yellow;
            else if ((e.Item.RowObject as Finances).type == Enums.financeType.تحويل_أرصدة)
                e.Item.BackColor = Color.Gray;
        }

        private void WltsOps_Search_Button_Click(object sender, EventArgs e) => LoadWltsOps(Wlts_From, Wlts_To);

        private void Wlts_Search_Objectlistview_DoubleClick(object sender, EventArgs e)
        {
            if (Wlts_Search_Objectlistview.SelectedObjects != null && Wlts_Search_Objectlistview.SelectedObjects.Count == 1)
                Program.WorkingForm.Click_Settings(Enums.settingsArgument.openWalletManager, (Wlts_Search_Objectlistview.SelectedObject as Wallet).name);
        }
    }
}
