using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ns1;
using OpsMoi.Models;
using OpsMoi.User_Interfaces.Dashboard;
using OpsMoi.Utilities;

namespace OpsMoi
{
    public partial class UsrCtrl_Dashboard : UserControl, ICustomControl
    {
        public UsrCtrl_Dashboard()
        {
            InitializeByResolution();
            HM_Manager.IControlInit(this, Dashboard_Tabcontrol, TileButtons_Panel);
        }
        public void Set_Tags()
        {
            TODOs_TotalCount_Label.Tag = Enums.DashboardField.إجمالي_عدد_المهام_المطلوبة;
            TODOs_MonthCount_Label.Tag = Enums.DashboardField.عدد_المهام_المطلوبة_هذا_الشهر;
            TODOs_AverageCount_Label.Tag = Enums.DashboardField.متوسط_عدد_المهام_الشهر;
            TODOs_TotalDuration_Label.Tag = Enums.DashboardField.إجمالي_المدة_المستغرقة;
            TODOs_MonthDuration_Label.Tag = Enums.DashboardField.إجمالي_المدة_المستغرقة_هذا_الشهر;
            TODOs_AverageDuration_Label.Tag = Enums.DashboardField.متوسط_المدة_المستغرقة_الشهر;

            FNC_TotalCount_Label.Tag = Enums.DashboardField.إجمالي_عدد_العمليات_المالية_;
            FNC_MonthCount_Label.Tag = Enums.DashboardField.عدد_العمليات_المالية_هذا_الشهر;
            FNC_AverageCount_Label.Tag = Enums.DashboardField.متوسط_عدد_العمليات_المالية__الشهر;
            FNC_TotalPaid_Label.Tag = Enums.DashboardField.إجمالي_قيمة_العمليات_المالية;
            FNC_MonthPaid_Label.Tag = Enums.DashboardField.قيمة_العمليات_المالية_هذا_الشهر;
            FNC_AveragePaid_Label.Tag = Enums.DashboardField.متوسط_قيمة_العمليات_المالية_الشهر;

            NOT_TotalCount_Label.Tag = Enums.DashboardField.إجمالي_عدد_الملاحظات;
            NOT_TotalLength_Label.Tag = Enums.DashboardField.إجمالي_طول_الملاحظات;
            NOT_AverageLength_Label.Tag = Enums.DashboardField.متوسط_طول_الملاحظات;
        }
        public void Sync()
        {
            AdjustListview();
            LoadDashboardElements();
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
        private DateTime _From { get { return History_From_Datetimepicker.Value; } }
        private DateTime _To { get { return History_To_Datetimepicker.Value; } }
        private void LoadHistory(DateTime From, DateTime To)
        {
            if (To < From) return;
            HM_Manager.Update_OLV(Dashboard_Processor.LoadHistory(From, To), history_Objectlistview);
        }

        private void TileButton_Click(object sender, EventArgs e) => HM_Manager.TabButtonsClick(Dashboard_Tabcontrol, TileButtons_Panel, sender as BunifuTileButton, SidePanel1);

        private async void LoadDashboardElements()
        {
            await Dashboard_Processor.LoadDashboardElements();
            List<Control> firstCtrl = new List<Control> { this };
            var children = GetChildren(firstCtrl[0]);
            while (firstCtrl.Count > 0)
            {
                firstCtrl.ForEach(p => p.Controls.OfType<Label>().ToList().ForEach(lbl => HandleLabels(lbl)));
                firstCtrl = firstCtrl.Where(p => p.HasChildren).Select(ctrl => ctrl.Controls.OfType<Control>()).SelectMany(child => child).ToList();
            }
        }
        private List<Control> GetChildren(Control control)
        {
            List<Control> childrenGround = new List<Control>();
            foreach (var ctrl in control.Controls.OfType<Control>().ToList().Where(ctrl => ctrl.HasChildren))
                childrenGround.AddRange(ctrl.Controls.OfType<Control>());
            return childrenGround;
        }
        private void HandleLabels(Label lbl) { if (lbl.Tag != null && lbl.Tag.GetType().Equals(typeof(Enums.DashboardField))) lbl.Text = Dashboard_Processor.Dashboard_Elements[(lbl.Tag as Enums.DashboardField?).Value]; }
        private void History_SearchButton_Click(object sender, EventArgs e) => LoadHistory(_From, _To);
        // // // // // // // // // // // // // // // // // // // // // // // //
        private void AdjustListview()
        {
            Date_Column.GroupKeyGetter = delegate (object rowObject) { History history = (History)rowObject; return new DateTime(history.datetime.Year, history.datetime.Month, history.datetime.Day); };
            Date_Column.GroupKeyToTitleConverter = delegate (object groupKey) { return ((DateTime)groupKey).ToString("dddd, dd MMMM,yyyy"); };
        }

        private void Dashboard_Tabcontrol_SelectedIndexChanged(object sender, EventArgs e) { if (Dashboard_Tabcontrol.SelectedTab == history_Tabpage) LoadHistory(_From, _To); }

        private void DB_ShwTodo_Button_Click(object sender, EventArgs e) => Dashboard_Processor.Show_TODO_Button();
        private void DB_AddTodo_Button_Click(object sender, EventArgs e) => Dashboard_Processor.Add_TODO_Button();
        private void DB_AddFnc_Button_Click(object sender, EventArgs e) => Dashboard_Processor.Add_FNC_Button();
        private void DB_ShwFnc_Button_Click(object sender, EventArgs e) => Dashboard_Processor.Show_FNC_Button();
        private void DB_AddNot_Button_Click(object sender, EventArgs e) => Dashboard_Processor.Add_NOT_Button();
        private void DB_ShwNot_Button_Click(object sender, EventArgs e) => Dashboard_Processor.Show_NOT_Button();
    }
}
