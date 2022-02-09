using System.Drawing;
using DailyCompanionV2.User_Interfaces.Reports;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2.User_Interfaces
{
    public partial class UsrCtrl_Reports
    {
        private Enums.reportAuxState _aux_state = Enums.reportAuxState.none;
        public Enums.reportAuxState Aux_state
        {
            get => _aux_state;
            set
            {
                switch (value)
                {
                    case Enums.reportAuxState.none:
                        {
                            Charts_AuxPanel.Visible = false;
                            break;
                        }
                    case Enums.reportAuxState.Pie:
                        {
                            AuxPanel_Init();
                            Reports_Chart.Visible = Reports_SplineChart.Visible = false;
                            if (pieGroupArgs != null) UpdatePie(pieGroupArgs);
                            Reports_PieChart.Visible = true;
                            break;
                        }
                    case Enums.reportAuxState.Line:
                        {
                            AuxPanel_Init();
                            Reports_PieChart.Visible = Reports_SplineChart.Visible = false;
                            Reports_Processor.UpdateLiveChart(Reports_Chart, State, _From, _To, Span, dSpan, Reports_Label);
                            Reports_Chart.Visible = true;
                            break;
                        }
                    case Enums.reportAuxState.spLine:
                        {
                            if (pieGroupArgs != null)
                            {
                                UpdatePie(pieGroupArgs);
                                Reports_Processor.UpdateLiveChart(Reports_Chart, _state, _From, _To, Span, dSpan, Reports_Label, Reports_SplineChart, pieGroupArgs);
                            }
                            Reports_SplineChart.Visible = true;
                        }
                        break;
                }
                _aux_state = value;
            }
        }
        private void AuxPanel_Init()
        { // - (1.54 * 3) width, - (2.5 * 10 + 15) pixel هاتها من التابل بانل شوف عاوز تخلي الكونترول تغطي من انهي صفوف
            Charts_AuxPanel.Size = new Size((int)(all_TablePanel.ClientRectangle.Width * .95), (int)(all_TablePanel.ClientRectangle.Height * .78));
            Charts_AuxPanel.Top = splitContainer1.Panel1.Bottom - Charts_AuxPanel.Height;
            Charts_AuxPanel.Left = splitContainer1.Panel1.Left;
            Charts_AuxPanel.Visible = true;
            Charts_AuxPanel.BringToFront();
            Charts_AuxPanel.Focus();
            Piechart_Spline_Button.BringToFront();
        }
    }
}
