﻿using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using ns1;
using OpsMoi.Models;
using OpsMoi.User_Interfaces.Finance;
using OpsMoi.User_Interfaces.Reports;
using OpsMoi.Utilities;

namespace OpsMoi.User_Interfaces
{
    public partial class UsrCtrl_Reports : UserControl, ICustomControl
    {
        public UsrCtrl_Reports() => load();
        public UsrCtrl_Reports(Enums.report_tabState report_TabState)
        {
            load();
            switch (report_TabState)
            {
                case Enums.report_tabState.مهام:
                    TileButtons_Click(Todos_TileButton, EventArgs.Empty); break;
                case Enums.report_tabState.مالية:
                    TileButtons_Click(Financial_Tilebutton, EventArgs.Empty); break;
                case Enums.report_tabState.ملاحظات:
                    TileButtons_Click(Notes_TileButton, EventArgs.Empty); break;
            }
        }
        void load()
        {
            InitializeByResolution();
            HM_Manager.IControlInit(this, Reports_Tabcontrol, TileButtons_Panel);
            Reports_Span_Combobox.DataSource = Enum.GetValues(typeof(Enums.Span));
        }
        public void Set_Tags()
        {
            TodosDonedate_Column.GroupKeyGetter = delegate (object rowObject)
            {
                if (((Todos)rowObject).done_date.HasValue)
                    return DateTime.Parse(((Todos)rowObject).done_date.Value.ToString("d"));
                else return DateTime.MaxValue;
            };
            TodosAddeddate_Column.GroupKeyGetter = delegate (object rowObject) { return DateTime.Parse(((Todos)rowObject).added_date.ToString("d")); };
            TodosDuedate_Column.GroupKeyGetter = delegate (object rowObject) { return DateTime.Parse(((Todos)rowObject).due_date.ToString("d")); };
            TodosDonedate_Column.GroupKeyToTitleConverter = TodosAddeddate_Column.GroupKeyToTitleConverter = TodosDuedate_Column.GroupKeyToTitleConverter = delegate (object groupKey) { return ((DateTime)groupKey).ToString("dddd, dd MMMM,yyyy", System.Globalization.CultureInfo.GetCultureInfo("ar-EG")); };
            TodosDuration_Column.AspectToStringConverter = delegate (object rowObject) { return HM_Manager.MinutesToDuration(rowObject); };

            FinancialDonedate_Column.GroupKeyGetter = delegate (object rowObject)
            {
                if (((Finances)rowObject).done_date.HasValue)
                    return DateTime.Parse(((Finances)rowObject).done_date.Value.ToString("d"));
                else return DateTime.MaxValue;
            };
            FinancialDuedate_Column.GroupKeyGetter = delegate (object rowObject) { return DateTime.Parse(((Finances)rowObject).due_date.ToString("d")); };
            FinancialDonedate_Column.GroupKeyToTitleConverter = FinancialDuedate_Column.GroupKeyToTitleConverter = delegate (object groupKey) { return ((DateTime)groupKey).ToString("dddd, dd MMMM,yyyy", System.Globalization.CultureInfo.GetCultureInfo("ar-EG")); };
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

        private Enums.report_tabState _state;
        public Enums.Span Span { get { Enums.Span _span; Enum.TryParse(Reports_Span_Combobox.Text.ToString(), out _span); return _span; } }
        public DateTime _From { get { return Reports_From_Datetimepicker.Value; } }
        public DateTime _To { get { return Reports_To_Datetimepicker.Value; } }
        private void Statistics_Item_Changed(object sender, EventArgs e) => Sync();
        public void Sync()
        {
            Listviews_UPDATE();
            Reports_Processor.UpdateLiveChart(Reports_Chart, _state, _From, _To, Span, Reports_Label);
        }
        private void TileButtons_Click(object sender, EventArgs e) =>
            HM_Manager.TabButtonsClick(Reports_Tabcontrol, TileButtons_Panel, sender as BunifuTileButton, SidePanel1, delegate () { Sync(); });


        private void UpdatePie(CreateGroupsEventArgs groupCollection) => Reports_Processor.UpdatePieChart(Reports_PieChart, groupCollection);

        private void LoadFinance_Listview(DateTime from, DateTime to) { HM_Manager.Update_OLV(Reports_Processor.FinancesList(from, to), Finances_Objectlistview);/* Reports_Processor.UpdatePieChart(Reports_PieChart, Finances_Objectlistview.Groups);*/ }
        private void LoadTodos_Listview(DateTime from, DateTime to) { HM_Manager.Update_OLV(Reports_Processor.TodosList(from, to), Todos_Objectlistview); }
        private void LoadNotes_Listview(string SearchTerm) { HM_Manager.Update_OLV(Reports_Processor.NotesList(SearchTerm), Notes_Objectlistview); }
        private void LoadHR_Listview(DateTime from, DateTime to) { /*HM_Manager.Update_OLV(Reports_Processor.hrList(from, to), HR_Objectlistview);*/ }

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
            DateTimePicker dtPickerFrom = Controls.Find(btn.Name.Replace("SearchButton", "From_Datetimepicker"), true).First() as DateTimePicker;
            DateTimePicker dtPickerTo = Controls.Find(btn.Name.Replace("SearchButton", "To_Datetimepicker"), true).First() as DateTimePicker;
            btn.Enabled = dtPickerTo.Value >= dtPickerFrom.Value;
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
                group.Header = string.Format($"{tempHeader} :: عدد المهام المطلوبة : {count}  بإجمالي فترة مستغرقة : {HM_Manager.MinutesToDuration(totalDuration)}");
                if (e.Parameters.PrimarySort.Tag.ToString() == "double" || e.Parameters.PrimarySort.Tag.ToString() == "int" || e.Parameters.PrimarySort.Tag.ToString() == "decimal") group.Tag = group.Items.Sum(p => int.Parse(p.GetSubItem(e.Parameters.PrimarySort.Index).ModelValue.ToString()));
                else group.Tag = count;
            }
            if (e.Parameters.PrimarySortOrder == SortOrder.Descending) e.Groups = e.Groups.OrderByDescending(p => (p.Tag as int?).Value).ToList();
            else e.Groups = e.Groups.OrderBy(p => (p.Tag as int?).Value).ToList();
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
        }

        private void Todos_Objectlistview_FormatRow(object sender, FormatRowEventArgs e)
        {
            if ((e.Model as Todos).done_date.HasValue) e.Item.BackColor = Color.LimeGreen;
            else if ((e.Model as Todos).due_date > DateTime.Now) e.Item.BackColor = Color.Yellow;
            else e.Item.BackColor = Color.Red;
        }
        private void Finances_Objectlistview_FormatRow(object sender, FormatRowEventArgs e)
        {
            if ((e.Model as Finances).done_date.HasValue)
                if ((e.Model as Finances).due <= (e.Model as Finances).paid)
                    if ((e.Model as Finances).type == Enums.financeType.دخل) e.Item.BackColor = Color.Green;
                    else e.Item.BackColor = Color.DeepPink;
                else
                {
                    if ((e.Model as Finances).type == Enums.financeType.دخل) e.Item.BackColor = Color.LimeGreen;
                    else e.Item.BackColor = Color.LightPink;
                }
            else if ((e.Model as Finances).due_date > DateTime.Now) e.Item.BackColor = Color.Yellow;
            else e.Item.BackColor = Color.Red;
        }

        private void Objectlistview_CellEditStarting(object sender, CellEditEventArgs e)
        {
            DateTime temp;
            if (e.Column.Tag != null)
                switch (e.Column.Tag.ToString())
                {
                    case "date_nullable":
                        DateTimePicker dtpThis = new DateTimePicker()
                        {
                            Bounds = e.CellBounds,
                            Value = DateTime.TryParse(e.Value.ToString(), out temp) ? DateTime.Parse(e.Value.ToString()) : DateTime.Now,
                            Checked = DateTime.TryParse(e.Value.ToString(), out temp),
                            CustomFormat = "dd MMMM yyyy",
                            Format = DateTimePickerFormat.Custom,
                            ShowCheckBox = true,
                            ShowUpDown = true
                        };
                        e.Control = dtpThis;
                        break;
                    case "date":
                        dtpThis = new DateTimePicker()
                        {
                            Bounds = e.CellBounds,
                            Value = DateTime.Parse(e.Value.ToString()),
                            Checked = true,
                            CustomFormat = "dd MMMM yyyy",
                            Format = DateTimePickerFormat.Custom,
                            ShowUpDown = true
                        };
                        e.Control = dtpThis;
                        break;
                    case "decimal":
                        NumericUpDown nud = new NumericUpDown()
                        {
                            Bounds = e.CellBounds,
                            Minimum = decimal.MinValue,
                            Maximum = decimal.MaxValue,
                            Value = decimal.Parse(e.Value.ToString())
                        };
                        e.Control = nud;
                        break;
                }
        }

        private void Objectlistview_CellEditFinishing(object sender, CellEditEventArgs e)
        {
            if (e.Column.Tag != null)
                if (e.Column.Tag.ToString() == "date_nullable")
                    if (((DateTimePicker)e.Control).Checked == false)
                        e.NewValue = null;
                    else e.NewValue = (e.NewValue as DateTime?).Value.ToString();
        }

        private void Reports_Edit_Button_Click(object sender, EventArgs e)
        {
            var selectedItem = Finances_Objectlistview.SelectedObject != null ? Finances_Objectlistview.SelectedObject : Notes_Objectlistview.SelectedObject != null ? Notes_Objectlistview.SelectedObject : Todos_Objectlistview.SelectedObject;
            switch (selectedItem)
            {
                case Todos selectesTDs:
                    Program.WorkingForm.Click_TODO(Enums.todoArgument.loadTodoItem, selectesTDs.id);
                    break;
                case Finances selectesFncs:
                    Program.WorkingForm.Click_FNC(Enums.financeArgument.loadFinanceItem, selectesFncs.id);
                    break;
                case Models.Notes selectedNots:
                    Program.WorkingForm.Click_Note(Enums.noteArgument.loadNoteItem, selectedNots.title);
                    break;
            }
        }
        private void Reports_SaveChanges_Button_Click(object sender, EventArgs e)
        {
            switch (_state)
            {
                case Enums.report_tabState.مهام:
                    foreach (Todos selectesTDs in Todos_Objectlistview.Objects)
                    {
                        var old = Program.Todos_List.Where(p => p.id == selectesTDs.id).FirstOrDefault();
                        if (!selectesTDs.Equals(old))
                            Todo_Processor.HandleTODO(Enums.genericHandle_Type.تعديل, new GroupBox()
                            , selectesTDs.duefrom, selectesTDs.dueto, selectesTDs.todo, selectesTDs.category,selectesTDs.start_date ,selectesTDs.due_date, selectesTDs.done_date.HasValue, selectesTDs.done_date.GetValueOrDefault(),selectesTDs.added_date ,selectesTDs.duration, selectesTDs.notes,selectesTDs.chkpoint_list
                            , Reports_OLV_Label, "", Color.White, old, true);
                    }
                    break;
                case Enums.report_tabState.مالية:
                    foreach (Finances selectesFncs in Finances_Objectlistview.Objects)
                    {
                        var old = Program.Finances_List.Where(p => p.id == selectesFncs.id).FirstOrDefault();
                        if (!selectesFncs.Equals(old))
                            Finances_Processor.HandleFNC(Enums.genericHandle_Type.تعديل, new GroupBox()
                       , selectesFncs.relatedentity, selectesFncs.type, selectesFncs.category, selectesFncs.due, selectesFncs.paid, selectesFncs.due_date, selectesFncs.done_date.HasValue, selectesFncs.done_date.GetValueOrDefault(), selectesFncs.notes
                       , Reports_OLV_Label, "", Color.White, old, true);
                    }
                    break;
                case Enums.report_tabState.ملاحظات:
                    foreach (Models.Notes selectedNots in Notes_Objectlistview.Objects)
                    {
                        var old = Program.Notes_List.Where(p => p.id == selectedNots.id).FirstOrDefault();
                        if (!selectedNots.Equals(old))
                            Notes.Notes_Processor.Handle_Note(Enums.genericHandle_Type.تعديل, new GroupBox()
                        , selectedNots.title, selectedNots.strNote
                        , Reports_OLV_Label, "", Color.White, old, true);
                    }
                    break;
            }
        }
    }
}
