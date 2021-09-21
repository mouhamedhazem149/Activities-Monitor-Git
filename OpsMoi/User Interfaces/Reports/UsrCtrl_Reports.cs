﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using OpsMoi.Utilities;
using OpsMoi.User_Interfaces.Reports;
using ns1;
using OpsMoi.Models;

namespace OpsMoi.User_Interfaces
{
    public partial class UsrCtrl_Reports : UserControl, ICustomControl
    {
        public UsrCtrl_Reports()
        {
            InitializeByResolution(); 
            HM_Manager.IControlInit(this, Reports_Tabcontrol, TileButtons_Panel);
            Reports_Span_Combobox.DataSource = Enum.GetValues(typeof(Enums.Span));
        }
        public void SetButton_Tags() { }
        public void InitializeByResolution()
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
        
        private Enums.report_tabState _state;
        public Enums.Span Span { get { Enums.Span _span; Enum.TryParse(Reports_Span_Combobox.Text.ToString(), out _span); return _span; } }
        public DateTime _From { get { return Reports_From_Datetimepicker.Value; } }
        public DateTime _To { get { return Reports_To_Datetimepicker.Value; } }
        private void Statistics_Item_Changed(object sender, EventArgs e) => Sync();
        public void Sync()
        {
            Listviews_UPDATE();
            Reports_Processor.UpdateLiveChart(Reports_Chart,_state ,_From, _To, Span, Reports_Label);
        }
        private void TileButtons_Click(object sender, EventArgs e) => 
            HM_Manager.TabButtonsClick(Reports_Tabcontrol, TileButtons_Panel, sender as BunifuTileButton, SidePanel1, delegate () { Sync(); });

       
        private void UpdatePie(CreateGroupsEventArgs groupCollection) => Reports_Processor.UpdatePieChart(Reports_PieChart, groupCollection);
        
        private void LoadFinance_Listview(DateTime from, DateTime to) { HM_Manager.Update_OLV(Reports_Processor.FinancesList(from, to), Finances_Objectlistview);/* Reports_Processor.UpdatePieChart(Reports_PieChart, Finances_Objectlistview.Groups);*/ }
        private void LoadTodos_Listview(DateTime from, DateTime to) { HM_Manager.Update_OLV(Reports_Processor.TodosList(from, to), Todos_Objectlistview); }
        private void LoadNotes_Listview(string SearchTerm) { HM_Manager.Update_OLV(Reports_Processor.NotesList(SearchTerm), Notes_Objectlistview); }
        private void LoadHR_Listview(DateTime from, DateTime to) { HM_Manager.Update_OLV(Reports_Processor.hrList(from, to), HR_Objectlistview); }

        private void Listviews_UPDATE()
        {
            if (Reports_Tabcontrol.SelectedTab == financial_Tabpage) LoadFinance_Listview(_From, _To);
            else if (Reports_Tabcontrol.SelectedTab == Todos_Tabpage) LoadTodos_Listview(_From, _To);
            else if (Reports_Tabcontrol.SelectedTab == Notes_Tabpage) LoadNotes_Listview(ReportNOT_Search_Textbox.Text);
            else if (Reports_Tabcontrol.SelectedTab == HR_Tabpage) LoadHR_Listview(_From, _To);
        }
        
        private void Datetimepicker_ValueChanged(object sender, EventArgs e) => Check_FromTo_Button((sender as DateTimePicker).Tag as Button);
        private void Check_FromTo_Button(Button btn)
        {
            DateTimePicker dtPickerFrom = Controls.Find(btn.Name.Replace("SearchButton", "From_Datetimepicker"),true).First() as DateTimePicker;
            DateTimePicker dtPickerTo = Controls.Find(btn.Name.Replace("SearchButton", "To_Datetimepicker"), true).First() as DateTimePicker;
            btn.Enabled = dtPickerTo.Value >= dtPickerFrom.Value;
        }

        private void Finances_Objectlistview_FormatRow(object sender, FormatRowEventArgs e)
        {
           
        }

        

        private void Reports_Tabcontrol_SelectedIndexChanged(object sender, EventArgs e) 
        {
            int tempIndex = -1;
            if (Reports_Tabcontrol.SelectedIndex >= 0)
            {
                tempIndex = Reports_Tabcontrol.SelectedIndex;
                _state = (Enums.report_tabState)tempIndex;
            }
        }

        private void Finances_Objectlistview_AboutToCreateGroups(object sender, CreateGroupsEventArgs e)
        {
            UpdatePie(e);
            foreach (OLVGroup group in e.Groups)
            {
                int count = group.Items.Count;
                double totalDue = group.Items.Sum(p => ((Finances)p.RowObject).due);
                double totalPaid = group.Items.Sum(p => ((Finances)p.RowObject).paid);
                string percent = totalDue != 0 ? (totalPaid / totalDue * 100).ToString("F2") : "غير محددة";
                string tempHeader = group.Header == null ? "" : group.Header;
                group.Header = string.Format($"{tempHeader} :: عدد العمليات المالية : {count}  بإجمالي مطلوب : {totalDue.ToString("N2")} وإجمالي مدفوع : {totalPaid.ToString("N2")} بنسبة : {percent}");
                group.Tag = count;
            }
            e.Groups = e.Groups.OrderByDescending(p => (p.Tag as int?).Value).ToList();
        }
        private void TODOs_Objectlistview_AboutToCreateGroups(object sender, CreateGroupsEventArgs e)
        {
            UpdatePie(e);
            foreach (OLVGroup group in e.Groups)
            {
                int count = group.Items.Count;
                double totalDuration = group.Items.Sum(p => ((Todos)p.RowObject).duration);
                string tempHeader = group.Header == null ? "" : group.Header;
                group.Header = string.Format($"{tempHeader} :: عدد المهام المطلوبة : {count}  بإجمالي فترة مستغرقة : {totalDuration}");
                group.Tag = count;
            }
            e.Groups = e.Groups.OrderByDescending(p => (p.Tag as int?).Value).ToList();
        }
        private void Notes_Objectlistview_AboutToCreateGroups(object sender, CreateGroupsEventArgs e)
        {
            UpdatePie(e);
            foreach (OLVGroup group in e.Groups)
            {
                int count = group.Items.Count;
                int length = group.Items.Sum(p => ((Models.Notes)p.RowObject).strNote.Length);
                string tempHeader = (group.Header == null || group.Header == "{null}") ? "" : group.Header;
                group.Header = string.Format($"{tempHeader} :: طول الملاحظات الملاحظات:{length}");
                group.Tag = count;
            }
            e.Groups = e.Groups.OrderByDescending(p => (p.Tag as int?).Value).ToList();
        }

        private void HR_Objectlistview_AboutToCreateGroups(object sender, CreateGroupsEventArgs e)
        {
            UpdatePie(e);
            foreach (OLVGroup group in e.Groups)
            {
                int count = group.Items.Count;
                int totalOperations = group.Items.Sum(p => ((HR_Item_Struct)p.RowObject).operationsCount);
                decimal totalBills = group.Items.Sum(p => ((HR_Item_Struct)p.RowObject).paid_bills);
                string tempHeader = group.Header == null ? "" : group.Header;
                group.Header = string.Format($"{tempHeader} :: العدد:{count}  إجمالي عدد العمليات:{totalOperations} وإجمالي الفواتير المتعلقة: {totalBills}");
                group.Tag = count;
            }
            e.Groups = e.Groups.OrderByDescending(p => (p.Tag as int?).Value).ToList();
        }

        private void HR_Objectlistview_DoubleClick(object sender, EventArgs e) { }

        private void TODO_Objectlistview_DoubleClick(object sender, EventArgs e) => Program.WorkingForm.Click_TODO(Enums.todoArgument.loadTodoItem, ((Todos)Todos_Objectlistview.SelectedObject).id);

        private void FNC_Objectlistview_DoubleClick(object sender, EventArgs e) => Program.WorkingForm.Click_FNC(Enums.financeArgument.loadFinanceItem, ((Finances)Finances_Objectlistview.SelectedObject).id);

        private void Notes_Objectlistview_DoubleClick(object sender, EventArgs e) => Program.WorkingForm.Click_Note(Enums.noteArgument.loadNoteItem, ((Models.Notes)Notes_Objectlistview.SelectedObject).title);
    }
}
