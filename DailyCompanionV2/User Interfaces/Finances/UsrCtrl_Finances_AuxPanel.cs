using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DailyCompanionV2.Models;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2
{
    public partial class UsrCtrl_Finances
    {
        public DateTime Aux_From { get { return FNC_AuxFrom_Datetimepicker.Value; } }
        public DateTime Aux_To { get { return FNC_AuxTo_Datetimepicker.Value; } }
        
        private Enums.financeAuxState _aux_state = Enums.financeAuxState.none;
        public Enums.financeAuxState Aux_state
        {
            get => _aux_state;
            set
            {
                switch (value)
                {
                    case Enums.financeAuxState.none:
                        {
                            Aux_Panel.Visible = false;
                            break;
                        }
                    case Enums.financeAuxState.required:
                        {
                            AuxPanel_Init();
                            FNCReq_Groupbox.Visible = true; FNCWallets_Groupbox.Visible = false;
                            FNCWallets_Groupbox.Dock = DockStyle.None; FNCReq_Groupbox.Dock = DockStyle.Fill;
                            break;
                        }
                    case Enums.financeAuxState.wallets:
                        {
                            AuxPanel_Init();
                            FNCReq_Groupbox.Visible = false; FNCWallets_Groupbox.Visible = true;
                            FNCReq_Groupbox.Dock = DockStyle.None; FNCWallets_Groupbox.Dock = DockStyle.Fill;
                            LoadWltsSearch();
                            break;
                        }
                }
                _aux_state = value;
            }
        }
        private void AuxPanel_Init()
        { // - (1.54 * 3) width, - (2.5 * 10 + 15) pixel هاتها من التابل بانل شوف عاوز تخلي الكونترول تغطي من انهي صفوف
            Aux_Panel.Size = new Size((int)(all_TablePanel.ClientRectangle.Width * .95), (int)(all_TablePanel.ClientRectangle.Height * .78));
            Aux_Panel.Top = AddFinance_Groupbox.Bottom - Aux_Panel.Height;
            Aux_Panel.Left = AddFinance_Groupbox.Left;
            Aux_Panel.Visible = true;
            Aux_Panel.BringToFront();
            Aux_Panel.Focus();
        }
        private void LoadReqFNCs(DateTime From, DateTime To)
        {
            if (To < From) return;
            HM_Manager.Update_OLV(User_Interfaces.Reports.Reports_Processor.FinancesList(From, To).Where(p => p.done_date.HasValue == false).ToList(), reqFNC_Objectlistview);
        }
        private void LoadWltsOps(DateTime From, DateTime To)
        {
            if (To < From) return;
            List<int> Ids = Wlts_Search_Objectlistview.SelectedObjects != null ? Wlts_Search_Objectlistview.SelectedObjects.OfType<Wallet>().Select(p => p.id).ToList() : new List<int>();
            HM_Manager.Update_OLV(Program.Finances_List.Where(fnc => (fnc.due_date.IsBetween(From, To) || fnc.done_date.IsBetween(From, To)) && Ids.Contains(fnc.wallet)).ToList(), Wlts_Objectlistview);
        }
        private void LoadWltsSearch()
        {
            HM_Manager.Update_OLV(Program.Wallets_List, Wlts_Search_Objectlistview);
            HM_Manager.Success_addition(WalletsSearch_Label, $"تم تحميل المحافظ بنجاح. إجمالي الرصيد المتاح في جميع المحافظ: {Program.Wallets_List.Sum(p => p.credit)}");
        }
        private void Wlts_Objectlistview_DoubleClick(object sender, EventArgs e)
        {
            if (Wlts_Objectlistview.SelectedObjects != null && Wlts_Objectlistview.SelectedObjects.Count == 1)
                Program.WorkingForm.Click_FNC(Enums.financeArgument.loadFinanceItem, (Wlts_Objectlistview.SelectedObject as Finances).id);
        }
        private void Wlts_Objectlistview_AboutToCreateGroups(object sender, BrightIdeasSoftware.CreateGroupsEventArgs e)
        {
            foreach (BrightIdeasSoftware.OLVGroup group in e.Groups)
            {
                int count = group.Items.Count;
                double totalIncome = group.Items.Where(p => ((Finances)p.RowObject).type == Enums.financeType.دخل).Sum(p => ((Finances)p.RowObject).paid);
                double totalPaid = group.Items.Sum(p => ((Finances)p.RowObject).paid) - totalIncome;
                double totalNet = totalIncome - totalPaid;
                string tempHeader = string.IsNullOrEmpty(group.Header) ? "" : group.Header;
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
        private void Wlts_Search_Objectlistview_DoubleClick(object sender, EventArgs e)
        {
            if (Wlts_Search_Objectlistview.SelectedObjects != null && Wlts_Search_Objectlistview.SelectedObjects.Count == 1)
                Program.WorkingForm.Click_Settings(Enums.settingsState.finance, (Wlts_Search_Objectlistview.SelectedObject as Wallet).name);
        }
        private void FNCreq_SearchButton_Click(object sender, EventArgs e) => LoadReqFNCs(Aux_From, Aux_To);
        private void reqFNC_Objectlistview_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e) => e.Item.BackColor = Color.Pink;
        private void reqFNC_Objectlistview_DoubleClick(object sender, EventArgs e) => Program.WorkingForm.Click_FNC(Enums.financeArgument.loadFinanceItem, (reqFNC_Objectlistview.SelectedObject as Finances).id);
        private void Wlts_Search_Objectlistview_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e) =>
               e.Item.BackColor = ControlPaint.Dark(Color.FromArgb(int.Parse("f8edeb", System.Globalization.NumberStyles.HexNumber)), (float)((e.Item.RowObject as Wallet).credit / Program.Wallets_List.Sum(p => p.credit) / 5));

        private void FNC_Aux_SearchButton_Click(object sender, EventArgs e)
        {
            switch (Aux_state)
            {
                case Enums.financeAuxState.required:
                    LoadReqFNCs(Aux_From, Aux_To);
                    break;
                case Enums.financeAuxState.wallets:
                    LoadWltsOps(Aux_From, Aux_To);
                    break;
            }
        }
        private void FNC_Wallets_Button_Click(object sender, EventArgs e)
        {
            Aux_state = Aux_state == Enums.financeAuxState.wallets ? Enums.financeAuxState.none : Enums.financeAuxState.wallets;
            AuxComment_Label.Text = "";
        }
        private void ReqFNC_Button_Click(object sender, EventArgs e)
        {
            Aux_state = Aux_state == Enums.financeAuxState.required ? Enums.financeAuxState.none : Enums.financeAuxState.required;
            AuxComment_Label.Text = "";
        }
        private void Aux_Panel_Leave(object sender, EventArgs e) => Aux_state = Enums.financeAuxState.none;
    }
}
