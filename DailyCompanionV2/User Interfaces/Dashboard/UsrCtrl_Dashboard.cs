using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DailyCompanionV2.Models;
using DailyCompanionV2.User_Interfaces.Dashboard;
using DailyCompanionV2.Utilities;
using Microsoft.VisualBasic;

namespace DailyCompanionV2
{
    public partial class UsrCtrl_Dashboard : UserControl, ICustomControl
    {
        public UsrCtrl_Dashboard()
        {
            InitializeByResolution();
            HM_Manager.IControlInit(this, null, null);
        }
        public void Set_Tags()
        {
            DS_TD_Total_Label.Tag = Enums.DashboardField.الإجمالي_مهام;
            DS_TD_required_Label.Tag = Enums.DashboardField.مطلوب_مهام;
            DS_TD_month_Label.Tag = Enums.DashboardField.إجمالي_الشهر_مهام;
            DS_TD_average_Label.Tag = Enums.DashboardField.متوسط_مهام;

            DS_FN_Total_Label.Tag = Enums.DashboardField.الإجمالي_مالية;
            DS_FN_required_Label.Tag = Enums.DashboardField.مطلوب_مالية;
            DS_FN_month_Label.Tag = Enums.DashboardField.إجمالي_الشهر_مالية;
            DS_FN_average_Label.Tag = Enums.DashboardField.متوسط_مالية;

            DS_NT_total_Label.Tag = Enums.DashboardField.الإجمالي_ملاحظات;
            DS_NT_average_Label.Tag = Enums.DashboardField.متوسط_ملاحظات;
        }
        public void Sync()
        {
            AdjustListview();
            LoadDashboardElements();
            Dashboard_Processor.Update_DS_FNC_Chart(FNC_CartiseanChart);
            Dashboard_Processor.Update_TD_Charts(TD_CartiseanChart,TD_PieChart);
        }
        public void InitializeByResolution() => InitializeComponent();
        private async void LoadDashboardElements()
        {
            START:
            await Dashboard_Processor.LoadDashboardElements();
            if (Dashboard_Processor.Dashboard_Elements.Keys.Count < Enum.GetNames(typeof(Enums.DashboardField)).Length) goto START;
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
        private void HandleLabels(Label lbl)
        {
            if (lbl.Tag != null && lbl.Tag.GetType().Equals(typeof(Enums.DashboardField)))
                lbl.Text = Dashboard_Processor.Dashboard_Elements[(lbl.Tag as Enums.DashboardField?).Value];
        }
        // // // // // // // // // // // // // // // // // // // // // // // //
        private void AdjustListview()
        {
            Date_Column.GroupKeyGetter = delegate (object rowObject) { History history = (History)rowObject; return new DateTime(history.datetime.Year, history.datetime.Month, history.datetime.Day); };
            Date_Column.GroupKeyToTitleConverter = delegate (object groupKey) { return ((DateTime)groupKey).ToString("dddd, dd MMMM,yyyy"); };
        }
        private void History_Clear_Button_Click(object sender, EventArgs e)
        {
            int historyCount = Program.History_List.Count;
            int tempNum = 0;
        GETNUM:
            try
            {
                tempNum = int.Parse(Interaction.InputBox($"عدد سجلات العمليات ({historyCount}). برجاء إدخال رقم أقل من {(int)(.8 * historyCount)}", "إخطار"));
                if (tempNum > .8 * historyCount || tempNum < 0) throw new Exception();
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("برجاء إدخال رقم صحيح أو اضغط إلغاء لإلغاء العملية", "خطأ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK) goto GETNUM;
                else return;
            }
            var temp = Program.History_List.OrderBy(p => p.datetime).Take(tempNum).ToList();
            int min = temp.Select(p => p.id).Min(); int max = temp.Select(p => p.id).Max();
            string SQL = $"DELETE FROM history where id <= {max} AND id >= {min};";
            if (MessageBox.Show($"سيتم حذف {Program.History_List.Where(p => p.id <= max && p.id >= min).Count()} سجل. هل أنت متأكد ؟","إخطار", MessageBoxButtons.OKCancel) == DialogResult.OK)
                DBHelper.Execute<object>(SQL);
        }
    }
}
