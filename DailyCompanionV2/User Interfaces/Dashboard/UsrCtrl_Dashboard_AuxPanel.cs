using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DailyCompanionV2.Models;
using DailyCompanionV2.User_Interfaces.Dashboard;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2
{
    public partial class UsrCtrl_Dashboard
    {
        public DateTime Aux_From { get { return History_From_Datetimepicker.Value; } }
        public DateTime Aux_To { get { return History_To_Datetimepicker.Value; } }
        private void LoadHistory(DateTime From, DateTime To)
        {
            if (To < From) return;
            HM_Manager.Update_OLV(Dashboard_Processor.LoadHistory(From, To), history_Objectlistview);
        }
        private void History_SearchButton_Click(object sender, EventArgs e) => LoadHistory(Aux_From, Aux_To);
        
        private Enums.dashboardAuxState _aux_state = Enums.dashboardAuxState.none;
        public Enums.dashboardAuxState Aux_state
        {
            get => _aux_state;
            set
            {
                switch (value)
                {
                    case Enums.dashboardAuxState.none:
                        {
                            Aux_Panel.Visible = false;
                            break;
                        }
                    case Enums.dashboardAuxState.history:
                        {
                            AuxPanel_Init();
                            break;
                        }
                }
                _aux_state = value;
            }
        }
        private void AuxPanel_Init()
        { // - (1.54 * 3) width, - (2.5 * 10 + 15) pixel هاتها من التابل بانل شوف عاوز تخلي الكونترول تغطي من انهي صفوف
            Aux_Panel.Size = new Size((int)(splitContainer1.Panel1.ClientRectangle.Width * .95), (int)(splitContainer1.Panel1.ClientRectangle.Height * .78));
            Aux_Panel.Top = splitContainer1.Panel1.Bottom - Aux_Panel.Height;
            Aux_Panel.Left = splitContainer1.Panel1.Left;
            Aux_Panel.Visible = true;
            Aux_Panel.BringToFront();
            Aux_Panel.Focus();
        }
        private void DSB_History_Button_Click(object sender, EventArgs e)
        {
            Aux_state = Aux_state == Enums.dashboardAuxState.history ? Enums.dashboardAuxState.none : Enums.dashboardAuxState.history;
            AuxComment_Label.Text = "";
        }
        private void Aux_Panel_Leave(object sender, EventArgs e) => Aux_state = Enums.dashboardAuxState.none;
    }
}
