using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DailyCompanionV2.Models;
using DailyCompanionV2.User_Interfaces.Reports;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2.User_Interfaces
{
    public partial class UsrCtrl_Todo
    {
        public DateTime aux_From { get { return TODO_AuxFrom_Datetimepicker.Value; } }
        public DateTime aux_To { get { return TODO_AuxTo_Datetimepicker.Value; } }

        private Enums.todoAuxState _aux_state = Enums.todoAuxState.none;
        public Enums.todoAuxState Aux_state
        {
            get => _aux_state;
            set
            {
                switch (value)
                {
                    case Enums.todoAuxState.none:
                        {
                            Aux_Panel.Visible = false;
                            break;
                        }
                    case Enums.todoAuxState.required:
                        {
                            AuxPanel_Init();
                            TodoReq_Groupbox.Visible = true; Timeline_Groupbox.Visible = false;
                            Timeline_Groupbox.Dock = DockStyle.None; TodoReq_Groupbox.Dock = DockStyle.Fill;
                            break;
                        }
                    case Enums.todoAuxState.timeline:
                        {
                            AuxPanel_Init();
                            TodoReq_Groupbox.Visible = false; Timeline_Groupbox.Visible = true;
                            TodoReq_Groupbox.Dock = DockStyle.None; Timeline_Groupbox.Dock = DockStyle.Fill;
                            break;
                        }
                }
                _aux_state = value;
            }
        }
        private void AuxPanel_Init()
        { // - (1.54 * 3) width, - (2.5 * 10 + 15) pixel هاتها من التابل بانل شوف عاوز تخلي الكونترول تغطي من انهي صفوف
            Aux_Panel.Size = new Size((int)(all_TablePanel.ClientRectangle.Width * .95), (int)(all_TablePanel.ClientRectangle.Height * .78));
            Aux_Panel.Top = AddTodo_Groupbox.Bottom - Aux_Panel.Height;
            Aux_Panel.Left = AddTodo_Groupbox.Left;
            Aux_Panel.Visible = true;
            Aux_Panel.BringToFront();
            Aux_Panel.Focus();
        }
        private void LoadReqTODOs(DateTime From, DateTime To)
        {
            if (To < From) return;
            HM_Manager.Update_OLV(Reports_Processor.TodosList(From, To,"").Where(p => p.done_date.HasValue == false).ToList(), reqTODO_Objectlistview);
        }
        private void LoadTimelineTODOs(DateTime From, DateTime To)
        {
            List<Timeline> timeLines = new List<Timeline>();
            int totalCount = 0; double totalDuration = 0;
            Todo_Timeline_Control.Entrys.Clear();
            Todo_Timeline_Control.Visible = false;
            foreach (var todo in Reports_Processor.TodosList(From, To,""))
            {
                if (todo.done_date.HasValue) Todo_Timeline_Control.Entrys.Add(new MaterialWinforms.Controls.MaterialTimeLineEntry() { Title = $"[{todo.id.ToString()}]  {todo.todo}", AdditionalInfo = todo.category, Time = todo.done_date.Value, UserName = todo.dueto, Text = "" });
                else Todo_Timeline_Control.Entrys.Add(new MaterialWinforms.Controls.MaterialTimeLineEntry() { Title = $"[{todo.id.ToString()}]  {todo.todo}", AdditionalInfo = todo.category, Time = todo.due_date, UserName = todo.dueto, Text = "غير مكتملة" });
                totalCount += 1; totalDuration += todo.duration;
                if (todo.chkpoint_list != null && todo.chkpoint_list.Count > 0)
                    foreach (Checkpoint chk in todo.chkpoint_list)
                    {
                        totalCount += 1; Todo_Timeline_Control.Entrys.Add(new MaterialWinforms.Controls.MaterialTimeLineEntry() { Title = $"[{todo.id.ToString()}]  {todo.todo}", AdditionalInfo = todo.category, Time = chk.Chk_Date, UserName = todo.dueto, Text = chk.ChkName });
                    }
                /* if (todo.done_date.HasValue) timeLines.Add(new Timeline() { Category = todo.category, Title = todo.todo, date = todo.done_date.Value, Mission = "", DueTo = todo.dueto });
                 else timeLines.Add(new Timeline() { Category = todo.category, Title = todo.todo, date = todo.due_date, Mission = "غير مكتملة", DueTo = todo.dueto });
                 if (todo.chkpoint_list != null && todo.chkpoint_list.Count > 0)
                     foreach (Checkpoint chk in todo.chkpoint_list)
                         timeLines.Add(new Timeline() { Category = todo.category, Title = todo.todo, date = chk.Chk_Date, Mission = chk.ChkName, DueTo = todo.dueto });*/
            }
            Todo_Timeline_Control.SkinManager.ColorScheme = new MaterialWinforms.ColorScheme(MaterialWinforms.Primary.Amber500, MaterialWinforms.Primary.Amber700, MaterialWinforms.Primary.Amber100, MaterialWinforms.Accent.Amber200, MaterialWinforms.TextShade.WHITE);
            Todo_Timeline_Control.Visible = true;
            HM_Manager.Success_addition(AuxComment_Label, $"إجمالي عدد المهام {totalCount} بإجمالي فترة زمنية: {HM_Manager.MinutesToDuration(totalDuration)}");
        }
        private void TODO_SearchButton_Click(object sender, EventArgs e)
        {
            switch (Aux_state)
            {
                case Enums.todoAuxState.required:
                    LoadReqTODOs(aux_From, aux_To);
                    break;
                case Enums.todoAuxState.timeline:
                    LoadTimelineTODOs(aux_From, aux_To);
                    break;
            }
        }
        private void reqTODO_Objectlistview_DoubleClick(object sender, EventArgs e) => Program.WorkingForm.Click_TODO(Enums.todoArgument.loadTodoItem, (reqTODO_Objectlistview.SelectedObject as Todos).id);
        private void reqTODO_Objectlistview_AboutToCreateGroups(object sender, BrightIdeasSoftware.CreateGroupsEventArgs e)
        {
            foreach (BrightIdeasSoftware.OLVGroup group in e.Groups)
            {
                int count = group.Items.Count;
                string tempHeader = group.Header == null ? "" : group.Header;
                group.Header = string.Format($"{tempHeader} :: عدد المهام المطلوبة : {count}");
                group.Tag = count;
            }
            if (e.Parameters.PrimarySortOrder == SortOrder.Descending) e.Groups = e.Groups.OrderByDescending(p => (p.Tag as int?).Value).ToList();
            else e.Groups = e.Groups.OrderBy(p => (p.Tag as int?).Value).ToList();
        }
        private void reqTODO_Objectlistview_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e) => e.Item.BackColor = Color.Pink;
        private void Timeline_Button_Click(object sender, EventArgs e)
        {
            Aux_state = Aux_state == Enums.todoAuxState.timeline ? Enums.todoAuxState.none : Enums.todoAuxState.timeline;
            AuxComment_Label.Text = "";
        }

        private void ReqTODOs_Button_Click(object sender, EventArgs e)
        {
            Aux_state = Aux_state == Enums.todoAuxState.required ? Enums.todoAuxState.none : Enums.todoAuxState.required;
            AuxComment_Label.Text = "";
        }

        private void aux_Panel_Leave(object sender, EventArgs e) => Aux_state = Enums.todoAuxState.none;
    }
}
