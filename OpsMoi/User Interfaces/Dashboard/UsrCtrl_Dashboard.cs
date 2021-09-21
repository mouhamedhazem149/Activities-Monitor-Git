using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OpsMoi.Models;
using OpsMoi.User_Interfaces.Dashboard;
using OpsMoi.Utilities;
using ns1;

namespace OpsMoi
{
    public partial class UsrCtrl_Dashboard : UserControl, ICustomControl
    {
        public UsrCtrl_Dashboard()
        {
            InitializeByResolution();
            HM_Manager.IControlInit(this, Dashboard_Tabcontrol, TileButtons_Panel);
        }
        public void SetButton_Tags() { }
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
                    /*case Enums.Resolution.B_1366x768:
                        InitializeComponent1366x768();
                        break;
                    case Enums.Resolution.C_1280x1040:
                        InitializeComponent1280x1040();
                        break;*/
            }
        }
        private DateTime _From { get { return History_From_Datetimepicker.Value; } }
        private DateTime _To { get { return History_To_Datetimepicker.Value; } }
        private void LoadHistory(DateTime From, DateTime To)
        {
            if (To < From) return;
            List<History> history_Lst = Dashboard_Processor.LoadHistory(From, To);
            HM_Manager.Update_OLV(history_Lst, history_Objectlistview);
        }

        private void TileButton_Click(object sender, EventArgs e) =>
           HM_Manager.TabButtonsClick(Dashboard_Tabcontrol, TileButtons_Panel, sender as BunifuTileButton, SidePanel1);

        private async void LoadDashboardElements()
        {
            /*await Dashboard_Processor.LoadDashboardElements();
            List<Control> firstCtrl = new List<Control> { this };
            var children = GetChildren(firstCtrl[0]);
            while (firstCtrl.Count > 0)
            {
                firstCtrl.ForEach(p => p.Controls.OfType<Label>().ToList().ForEach(lbl => HandleLabels(lbl)));
                firstCtrl = firstCtrl.Where(p => p.HasChildren).Select(ctrl => ctrl.Controls.OfType<Control>()).SelectMany(child => child).ToList();
            }*/
        }
        private List<Control> GetChildren(Control control)
        {
            List<Control> childrenGround = new List<Control>();
            foreach (var ctrl in control.Controls.OfType<Control>().ToList().Where(ctrl => ctrl.HasChildren))
                childrenGround.AddRange(ctrl.Controls.OfType<Control>());
            return childrenGround;
        }
        private void HandleLabels(Label lbl)
        {
            if (Dashboard_Processor.Dashboard_Elements.Keys.Contains(lbl.Name.Replace("_Label", "").ToString()))
                lbl.Text = Dashboard_Processor.Dashboard_Elements[lbl.Name.Replace("_Label", "").ToString()];
        }
        private void History_SearchButton_Click(object sender, EventArgs e) => LoadHistory(_From, _To);
        // // // // // // // // // // // // // // // // // // // // // // // //
        private void Handle_TODO_Section(object sender, EventArgs e) => Dashboard_Processor.Handle_TODO_Button();
        private void Handle_Installment_Section(object sender, EventArgs e) => Dashboard_Processor.Handle_Installment_Button();
        // // // // // // // // // // // // // // // // // // // // // // // //
        private void Handle_openFNC_Section(object sender, EventArgs e) => Program.WorkingForm.Click_FNC(Enums.financeArgument.showFinanceManager, null);
        private void Handle_searchMTN_Section(object sender, EventArgs e) { }/* => Program.WorkingForm.Click_MaintenanceService(Enums.financeArgument.search, null);*/
        // // // // // // // // // // // // // // // // // // // // // // // //
        private void button5_Click(object sender, EventArgs e) => Program.WorkingForm.Click_Reports("goal");
        // // // // // // // // // // // // // // // // // // // // // // // //
        private void Handle_openNotes_Button(object sender ,EventArgs e) => Program.WorkingForm.Click_Note(Enums.noteArgument.showNoteManager, null);
        // // // // // // // // // // // // // // // // // // // // // // // //
        private void AdjustListview()
        {
            Date_Column.GroupKeyGetter = delegate (object rowObject) { History history = (History)rowObject; return new DateTime(history.datetime.Year, history.datetime.Month, history.datetime.Day); };
            Date_Column.GroupKeyToTitleConverter = delegate (object groupKey) { return ((DateTime)groupKey).ToString("dddd, dd MMMM,yyyy"); };
        }

        private void Dashboard_Tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Dashboard_Tabcontrol.SelectedTab == history_Tabpage) LoadHistory(_From, _To);
        }

    }
}
