using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using ns1;
using DailyCompanionV2.Models;
using DailyCompanionV2.User_Interfaces.Finance;
using DailyCompanionV2.User_Interfaces.Reports;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2.User_Interfaces
{
    public partial class UsrCtrl_Reports : UserControl, ICustomControl
    {
        public UsrCtrl_Reports() => InitialLoad();
        public UsrCtrl_Reports(Enums.report_tabState report_TabState)
        {
            InitialLoad();
            State = report_TabState;
        }
        void InitialLoad()
        {
            InitializeByResolution();
            HM_Manager.IControlInit(this, null, null);
            Charts_AuxPanel.BackColor = Splitter_Label.BackColor = Program.WorkingForm.mainColor;
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
            FinanceType_Column.AspectToStringConverter = delegate (object rowObject) { return (rowObject as Enum).GetDisplayName(); };
            FinanceWallet_Column.AspectToStringConverter = delegate (object rowObject) { return Program.Wallets_List.Where(p => p.id == (rowObject as int?).Value).First().name; };
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
        
        private CreateGroupsEventArgs pieGroupArgs = null;
        private Enums.report_tabState _state;
        public Enums.report_tabState State
        {
            get => _state;
            set
            {
                switch (value)
                {
                    case Enums.report_tabState.مهام:
                        {
                            Todos_Objectlistview.Visible = true; Notes_Objectlistview.Visible = Finances_Objectlistview.Visible = false;
                            todosTAB_ImageButton.BackColor = Splitter_Label.BackColor; financeTAB_ImageButton.BackColor = notesTAB_ImageButton.BackColor = Color.Transparent;
                            break;
                        }
                    case Enums.report_tabState.مالية:
                        {
                            Finances_Objectlistview.Visible = true; Notes_Objectlistview.Visible = Todos_Objectlistview.Visible = false;
                            financeTAB_ImageButton.BackColor = Splitter_Label.BackColor; todosTAB_ImageButton.BackColor = notesTAB_ImageButton.BackColor = Color.Transparent;
                            break;
                        }
                    case Enums.report_tabState.ملاحظات:
                        {
                            Notes_Objectlistview.Visible = true; Todos_Objectlistview.Visible = Finances_Objectlistview.Visible = false;
                            notesTAB_ImageButton.BackColor = Splitter_Label.BackColor; financeTAB_ImageButton.BackColor = todosTAB_ImageButton.BackColor = Color.Transparent;
                            break;
                        }
                }
                _state = value;
            }
        }
        public Enums.Span Span { get { Enums.Span _span; Enum.TryParse(Reports_Span_Combobox.Text.ToString(), out _span); return _span; } }
        public int dSpan => (int)Reports_Span_Updown.Value;
        public DateTime _From { get { return Reports_From_Datetimepicker.Value; } }
        public DateTime _To { get { return Reports_To_Datetimepicker.Value; } }
        public string searchTerm => Report_Search_Textbox.Text;
        private void Statistics_Item_Changed(object sender, EventArgs e) => Sync();
        public void Sync()
        {
            Listviews_UPDATE();
            if (Reports_PieChart.Visible)
                UpdatePie(pieGroupArgs);
            if (Reports_Chart.Visible || Reports_SplineChart.Visible)
                Reports_Processor.UpdateLiveChart(Reports_Chart, State, _From, _To, Span,dSpan ,Reports_Label, Reports_SplineChart, pieGroupArgs);
        }
        private void UpdatePie(CreateGroupsEventArgs groupCollection) => Reports_Processor.UpdatePieChart(Reports_PieChart, groupCollection);

        private void LoadFinance_Listview(DateTime from, DateTime to) { HM_Manager.Update_OLV(Reports_Processor.FinancesList(from, to, searchTerm), Finances_Objectlistview);/* Reports_Processor.UpdatePieChart(Reports_PieChart, Finances_Objectlistview.Groups);*/ }
        private void LoadTodos_Listview(DateTime from, DateTime to) { HM_Manager.Update_OLV(Reports_Processor.TodosList(from, to, searchTerm), Todos_Objectlistview); }
        private void LoadNotes_Listview(string SearchTerm) { HM_Manager.Update_OLV(Reports_Processor.NotesList(SearchTerm), Notes_Objectlistview); }

        private void Listviews_UPDATE()
        {
            switch (State)
            {
                case Enums.report_tabState.مهام:
                    LoadTodos_Listview(_From, _To);
                    break;
                case Enums.report_tabState.مالية:
                    LoadFinance_Listview(_From, _To); 
                    break;
                case Enums.report_tabState.ملاحظات:
                    LoadNotes_Listview(searchTerm); 
                    break;
            }
        }

        private void Datetimepicker_ValueChanged(object sender, EventArgs e) => Check_FromTo_Button((sender as DateTimePicker).Tag as Button);
        private void Check_FromTo_Button(Button btn)
        {
            DateTimePicker dtPickerFrom = Controls.Find(btn.Name.Replace("SearchButton", "From_Datetimepicker"), true).First() as DateTimePicker;
            DateTimePicker dtPickerTo = Controls.Find(btn.Name.Replace("SearchButton", "To_Datetimepicker"), true).First() as DateTimePicker;
            btn.Enabled = dtPickerTo.Value >= dtPickerFrom.Value;
        }
        private void Finances_Objectlistview_AboutToCreateGroups(object sender, CreateGroupsEventArgs e)
        {
            pieGroupArgs = e;
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
            if (e.Parameters.PrimarySortOrder == SortOrder.Descending) e.Groups = e.Groups.OrderByDescending(p => (p.Tag as int?).Value).ToList();
            else e.Groups = e.Groups.OrderBy(p => (p.Tag as int?).Value).ToList();
        }
        private void TODOs_Objectlistview_AboutToCreateGroups(object sender, CreateGroupsEventArgs e)
        {
            pieGroupArgs = e;
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
            pieGroupArgs = e;
            foreach (OLVGroup group in e.Groups)
            {
                int count = group.Items.Count;
                int length = group.Items.Sum(p => ((Models.Notes)p.RowObject).strNote.Length);
                string tempHeader = (group.Header == null || group.Header == "{null}") ? "" : group.Header;
                group.Header = string.Format($"{tempHeader} :: طول الملاحظات الملاحظات:{length}");
                group.Tag = count;
            }
            if (e.Parameters.PrimarySortOrder == SortOrder.Descending) e.Groups = e.Groups.OrderByDescending(p => (p.Tag as int?).Value).ToList();
            else e.Groups = e.Groups.OrderBy(p => (p.Tag as int?).Value).ToList();
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
            if ((e.Model as Finances).type == Enums.financeType.تحويل_أرصدة) e.Item.BackColor = Color.Gray;
            if ((e.Model as Finances).done_date.HasValue)
                if ((e.Model as Finances).due <= (e.Model as Finances).paid)
                {
                    if ((e.Model as Finances).type == Enums.financeType.دخل) e.Item.BackColor = Color.Green;
                    else if ((e.Model as Finances).type == Enums.financeType.مدفوعات) e.Item.BackColor = Color.HotPink;
                }
                else
                {
                    if ((e.Model as Finances).type == Enums.financeType.دخل) e.Item.BackColor = Color.LimeGreen;
                    else if ((e.Model as Finances).type == Enums.financeType.مدفوعات) e.Item.BackColor = Color.LightPink;
                }
            else if ((e.Model as Finances).due_date > DateTime.Now) e.Item.BackColor = Color.Yellow;
            else e.Item.BackColor = Color.Red;
        }

        private void Objectlistview_CellEditStarting(object sender, CellEditEventArgs e)
        {
            if (e.Column.Tag != null)
                switch (e.Column.Tag.ToString())
                {
                    case "date_nullable":
                        DateTimePicker dtpThis = new DateTimePicker()
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
                    case "date":
                        dtpThis = new DateTimePicker()
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
                    case "fnc_wlt_combobox":
                        cmboBx = new ComboBox()
                        {
                            Bounds = e.CellBounds,
                            DropDownStyle = ComboBoxStyle.DropDownList,
                            AutoCompleteSource = AutoCompleteSource.CustomSource,
                            FormattingEnabled = true
                        };
                        HM_Manager.Update_Combobox(cmboBx, Program.Wallets_List, "name", "id");
                        e.Control = cmboBx;
                        break;
                }
        }
        private void Objectlistview_CellEditFinishing(object sender, CellEditEventArgs e)
        {
            if (e.Column.Tag != null)
                switch (e.Column.Tag.ToString())
                {
                    case "date_nullable":
                        if (((DateTimePicker)e.Control).Checked == false)
                            e.NewValue = null;
                        else e.NewValue = (e.NewValue as DateTime?).Value.ToString();
                        break;
                    case "enum":
                        e.NewValue = Enums.GetValueFromName(e.Value as Enum, e.NewValue.ToString());
                        break;
                    case "fnc_wlt_combobox":
                        e.NewValue = ((ComboBox)e.Control).SelectedValue;
                        break;
                }
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
            switch (State)
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
                       , selectesFncs.relatedentity, selectesFncs.type,selectesFncs.wallet ,selectesFncs.category, selectesFncs.due, selectesFncs.paid, selectesFncs.due_date, selectesFncs.done_date.HasValue, selectesFncs.done_date.GetValueOrDefault(), selectesFncs.notes
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
        private void PieChart_Button_Click(object sender, EventArgs e) =>
            Aux_state = Aux_state == Enums.reportAuxState.Pie ? Enums.reportAuxState.none : Enums.reportAuxState.Pie;
        private void ColumnChart_Column_Click(object sender, EventArgs e) => 
            Aux_state = Aux_state == Enums.reportAuxState.Line ? Enums.reportAuxState.none : Enums.reportAuxState.Line;

        Enums.reportAuxState tempState;
        private void Piechart_Spline_Button_Click(object sender, EventArgs e)
        {
            if (Aux_state != Enums.reportAuxState.spLine)
            {
                tempState = Aux_state;
                Aux_state = Enums.reportAuxState.spLine;
            }
            else { Aux_state = tempState; }
        }
        private void Reports_Span_Combobox_SelectedIndexChanged(object sender, EventArgs e) => Reports_Span_Updown.Visible = Span == Enums.Span.أخرى;

        private void financeTAB_ImageButton_Click(object sender, EventArgs e) => State = Enums.report_tabState.مالية;
        private void notesTAB_ImageButton_Click(object sender, EventArgs e) => State = Enums.report_tabState.ملاحظات;
        private void todosTAB_ImageButton_Click(object sender, EventArgs e) => State = Enums.report_tabState.مهام;
    }
}
