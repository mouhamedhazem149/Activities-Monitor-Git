using System.Windows.Forms;

namespace DailyCompanionV2
{
    partial class UsrCtrl_Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DB_TD_Groupbox = new System.Windows.Forms.GroupBox();
            this.DS_TD_required_Label = new System.Windows.Forms.Label();
            this.DS_TD_required_Adj_Label = new System.Windows.Forms.Label();
            this.DS_TD_average_Label = new System.Windows.Forms.Label();
            this.DS_TD_average_Adj_Label = new System.Windows.Forms.Label();
            this.DS_TD_month_Label = new System.Windows.Forms.Label();
            this.DS_TD_month_Adj_Label = new System.Windows.Forms.Label();
            this.DS_TD_Total_Label = new System.Windows.Forms.Label();
            this.DS_TD_total_Adj_Label = new System.Windows.Forms.Label();
            this.History_Groupbox = new System.Windows.Forms.GroupBox();
            this.HistoryAux_TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.AuxComment_Label = new System.Windows.Forms.Label();
            this.history_Objectlistview = new BrightIdeasSoftware.ObjectListView();
            this.index_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.table_Affected_column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Date_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.operation_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Extra_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.History_SearchButton = new System.Windows.Forms.Button();
            this.DB_AuxTo_Adj_Label = new System.Windows.Forms.Label();
            this.DB_AuxFrom_Adj_Label = new System.Windows.Forms.Label();
            this.History_From_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.History_To_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.History_Clear_Button = new System.Windows.Forms.Button();
            this.DB_NT_Groupbox = new System.Windows.Forms.GroupBox();
            this.DS_NT_average_Label = new System.Windows.Forms.Label();
            this.DS_NT_average_Adj_Label = new System.Windows.Forms.Label();
            this.DS_NT_total_Label = new System.Windows.Forms.Label();
            this.DS_NT_total_Adj_Label = new System.Windows.Forms.Label();
            this.dashboard_Panel = new System.Windows.Forms.Panel();
            this.charts_TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.TD_PieChart = new LiveCharts.WinForms.PieChart();
            this.FNC_CartiseanChart = new LiveCharts.WinForms.CartesianChart();
            this.DS_TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.DB_FN_Groupbox = new System.Windows.Forms.GroupBox();
            this.DS_FN_required_Label = new System.Windows.Forms.Label();
            this.DS_FN_required_Adj_Label = new System.Windows.Forms.Label();
            this.DS_FN_average_Label = new System.Windows.Forms.Label();
            this.DS_FN_average_Adj_Label = new System.Windows.Forms.Label();
            this.DS_FN_month_Label = new System.Windows.Forms.Label();
            this.DS_FN_month_Adj_Label = new System.Windows.Forms.Label();
            this.DS_FN_Total_Label = new System.Windows.Forms.Label();
            this.DS_FN_total_Adj_Label = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Aux_Panel = new System.Windows.Forms.Panel();
            this.DSB_History_Button = new ns1.BunifuImageButton();
            this.DB_TD_Groupbox.SuspendLayout();
            this.History_Groupbox.SuspendLayout();
            this.HistoryAux_TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.history_Objectlistview)).BeginInit();
            this.DB_NT_Groupbox.SuspendLayout();
            this.dashboard_Panel.SuspendLayout();
            this.charts_TablePanel.SuspendLayout();
            this.DS_TablePanel.SuspendLayout();
            this.DB_FN_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Aux_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSB_History_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // DB_TD_Groupbox
            // 
            this.DB_TD_Groupbox.BackColor = System.Drawing.Color.Transparent;
            this.DB_TD_Groupbox.Controls.Add(this.DS_TD_required_Label);
            this.DB_TD_Groupbox.Controls.Add(this.DS_TD_required_Adj_Label);
            this.DB_TD_Groupbox.Controls.Add(this.DS_TD_average_Label);
            this.DB_TD_Groupbox.Controls.Add(this.DS_TD_average_Adj_Label);
            this.DB_TD_Groupbox.Controls.Add(this.DS_TD_month_Label);
            this.DB_TD_Groupbox.Controls.Add(this.DS_TD_month_Adj_Label);
            this.DB_TD_Groupbox.Controls.Add(this.DS_TD_Total_Label);
            this.DB_TD_Groupbox.Controls.Add(this.DS_TD_total_Adj_Label);
            this.DB_TD_Groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DB_TD_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_TD_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.DB_TD_Groupbox.Location = new System.Drawing.Point(1120, 3);
            this.DB_TD_Groupbox.Name = "DB_TD_Groupbox";
            this.DB_TD_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DB_TD_Groupbox.Size = new System.Drawing.Size(552, 486);
            this.DB_TD_Groupbox.TabIndex = 10;
            this.DB_TD_Groupbox.TabStop = false;
            this.DB_TD_Groupbox.Text = "المهام";
            // 
            // DS_TD_required_Label
            // 
            this.DS_TD_required_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_TD_required_Label.Font = new System.Drawing.Font("Cairo", 9.3F);
            this.DS_TD_required_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.DS_TD_required_Label.Location = new System.Drawing.Point(3, 414);
            this.DS_TD_required_Label.Name = "DS_TD_required_Label";
            this.DS_TD_required_Label.Size = new System.Drawing.Size(546, 65);
            this.DS_TD_required_Label.TabIndex = 29;
            this.DS_TD_required_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DS_TD_required_Adj_Label
            // 
            this.DS_TD_required_Adj_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_TD_required_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.DS_TD_required_Adj_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.DS_TD_required_Adj_Label.Location = new System.Drawing.Point(3, 369);
            this.DS_TD_required_Adj_Label.Name = "DS_TD_required_Adj_Label";
            this.DS_TD_required_Adj_Label.Size = new System.Drawing.Size(546, 45);
            this.DS_TD_required_Adj_Label.TabIndex = 28;
            this.DS_TD_required_Adj_Label.Text = "المطلوب";
            this.DS_TD_required_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DS_TD_average_Label
            // 
            this.DS_TD_average_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_TD_average_Label.Font = new System.Drawing.Font("Cairo", 9.3F);
            this.DS_TD_average_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.DS_TD_average_Label.Location = new System.Drawing.Point(3, 304);
            this.DS_TD_average_Label.Name = "DS_TD_average_Label";
            this.DS_TD_average_Label.Size = new System.Drawing.Size(546, 65);
            this.DS_TD_average_Label.TabIndex = 27;
            this.DS_TD_average_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DS_TD_average_Adj_Label
            // 
            this.DS_TD_average_Adj_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_TD_average_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.DS_TD_average_Adj_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.DS_TD_average_Adj_Label.Location = new System.Drawing.Point(3, 259);
            this.DS_TD_average_Adj_Label.Name = "DS_TD_average_Adj_Label";
            this.DS_TD_average_Adj_Label.Size = new System.Drawing.Size(546, 45);
            this.DS_TD_average_Adj_Label.TabIndex = 26;
            this.DS_TD_average_Adj_Label.Text = "المتوسط";
            this.DS_TD_average_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DS_TD_month_Label
            // 
            this.DS_TD_month_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_TD_month_Label.Font = new System.Drawing.Font("Cairo", 9.3F);
            this.DS_TD_month_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.DS_TD_month_Label.Location = new System.Drawing.Point(3, 194);
            this.DS_TD_month_Label.Name = "DS_TD_month_Label";
            this.DS_TD_month_Label.Size = new System.Drawing.Size(546, 65);
            this.DS_TD_month_Label.TabIndex = 25;
            this.DS_TD_month_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DS_TD_month_Adj_Label
            // 
            this.DS_TD_month_Adj_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_TD_month_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.DS_TD_month_Adj_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.DS_TD_month_Adj_Label.Location = new System.Drawing.Point(3, 149);
            this.DS_TD_month_Adj_Label.Name = "DS_TD_month_Adj_Label";
            this.DS_TD_month_Adj_Label.Size = new System.Drawing.Size(546, 45);
            this.DS_TD_month_Adj_Label.TabIndex = 24;
            this.DS_TD_month_Adj_Label.Text = "هذا الشهر";
            this.DS_TD_month_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DS_TD_Total_Label
            // 
            this.DS_TD_Total_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_TD_Total_Label.Font = new System.Drawing.Font("Cairo", 9.3F);
            this.DS_TD_Total_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.DS_TD_Total_Label.Location = new System.Drawing.Point(3, 84);
            this.DS_TD_Total_Label.Name = "DS_TD_Total_Label";
            this.DS_TD_Total_Label.Size = new System.Drawing.Size(546, 65);
            this.DS_TD_Total_Label.TabIndex = 23;
            this.DS_TD_Total_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DS_TD_total_Adj_Label
            // 
            this.DS_TD_total_Adj_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_TD_total_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.DS_TD_total_Adj_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.DS_TD_total_Adj_Label.Location = new System.Drawing.Point(3, 39);
            this.DS_TD_total_Adj_Label.Name = "DS_TD_total_Adj_Label";
            this.DS_TD_total_Adj_Label.Size = new System.Drawing.Size(546, 45);
            this.DS_TD_total_Adj_Label.TabIndex = 17;
            this.DS_TD_total_Adj_Label.Text = "الإجمالي";
            this.DS_TD_total_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // History_Groupbox
            // 
            this.History_Groupbox.Controls.Add(this.HistoryAux_TablePanel);
            this.History_Groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.History_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.History_Groupbox.Location = new System.Drawing.Point(0, 0);
            this.History_Groupbox.Name = "History_Groupbox";
            this.History_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.History_Groupbox.Size = new System.Drawing.Size(1364, 621);
            this.History_Groupbox.TabIndex = 10;
            this.History_Groupbox.TabStop = false;
            this.History_Groupbox.Text = "تاريخ العمليات";
            // 
            // HistoryAux_TablePanel
            // 
            this.HistoryAux_TablePanel.ColumnCount = 33;
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.HistoryAux_TablePanel.Controls.Add(this.AuxComment_Label, 2, 4);
            this.HistoryAux_TablePanel.Controls.Add(this.history_Objectlistview, 0, 7);
            this.HistoryAux_TablePanel.Controls.Add(this.History_SearchButton, 27, 1);
            this.HistoryAux_TablePanel.Controls.Add(this.DB_AuxTo_Adj_Label, 14, 1);
            this.HistoryAux_TablePanel.Controls.Add(this.DB_AuxFrom_Adj_Label, 2, 1);
            this.HistoryAux_TablePanel.Controls.Add(this.History_From_Datetimepicker, 3, 1);
            this.HistoryAux_TablePanel.Controls.Add(this.History_To_Datetimepicker, 15, 1);
            this.HistoryAux_TablePanel.Controls.Add(this.History_Clear_Button, 26, 30);
            this.HistoryAux_TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryAux_TablePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.HistoryAux_TablePanel.Location = new System.Drawing.Point(3, 39);
            this.HistoryAux_TablePanel.Name = "HistoryAux_TablePanel";
            this.HistoryAux_TablePanel.RowCount = 32;
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.4600919F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.4600919F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.4600919F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.HistoryAux_TablePanel.Size = new System.Drawing.Size(1358, 579);
            this.HistoryAux_TablePanel.TabIndex = 19;
            // 
            // AuxComment_Label
            // 
            this.HistoryAux_TablePanel.SetColumnSpan(this.AuxComment_Label, 29);
            this.AuxComment_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuxComment_Label.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuxComment_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.AuxComment_Label.Location = new System.Drawing.Point(90, 42);
            this.AuxComment_Label.Name = "AuxComment_Label";
            this.AuxComment_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HistoryAux_TablePanel.SetRowSpan(this.AuxComment_Label, 2);
            this.AuxComment_Label.Size = new System.Drawing.Size(1183, 38);
            this.AuxComment_Label.TabIndex = 21;
            this.AuxComment_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // history_Objectlistview
            // 
            this.history_Objectlistview.AllColumns.Add(this.index_Column);
            this.history_Objectlistview.AllColumns.Add(this.table_Affected_column);
            this.history_Objectlistview.AllColumns.Add(this.Date_Column);
            this.history_Objectlistview.AllColumns.Add(this.operation_Column);
            this.history_Objectlistview.AllColumns.Add(this.Extra_Column);
            this.history_Objectlistview.CellEditUseWholeCell = false;
            this.history_Objectlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index_Column,
            this.table_Affected_column,
            this.Date_Column,
            this.operation_Column,
            this.Extra_Column});
            this.HistoryAux_TablePanel.SetColumnSpan(this.history_Objectlistview, 33);
            this.history_Objectlistview.Cursor = System.Windows.Forms.Cursors.Default;
            this.history_Objectlistview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history_Objectlistview.Font = new System.Drawing.Font("El Messiri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_Objectlistview.FullRowSelect = true;
            this.history_Objectlistview.HideSelection = false;
            this.history_Objectlistview.Location = new System.Drawing.Point(3, 85);
            this.history_Objectlistview.Name = "history_Objectlistview";
            this.history_Objectlistview.RightToLeftLayout = true;
            this.HistoryAux_TablePanel.SetRowSpan(this.history_Objectlistview, 23);
            this.history_Objectlistview.SelectColumnsOnRightClick = false;
            this.history_Objectlistview.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.history_Objectlistview.ShowCommandMenuOnRightClick = true;
            this.history_Objectlistview.ShowItemCountOnGroups = true;
            this.history_Objectlistview.Size = new System.Drawing.Size(1352, 431);
            this.history_Objectlistview.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.history_Objectlistview.SpaceBetweenGroups = 3;
            this.history_Objectlistview.TabIndex = 13;
            this.history_Objectlistview.UseCompatibleStateImageBehavior = false;
            this.history_Objectlistview.UseFiltering = true;
            this.history_Objectlistview.UseHotControls = false;
            this.history_Objectlistview.View = System.Windows.Forms.View.Details;
            // 
            // index_Column
            // 
            this.index_Column.AspectName = "id";
            this.index_Column.MaximumWidth = 25;
            this.index_Column.MinimumWidth = 25;
            this.index_Column.Text = "م";
            this.index_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.index_Column.Width = 25;
            // 
            // table_Affected_column
            // 
            this.table_Affected_column.AspectName = "table_affected";
            this.table_Affected_column.MaximumWidth = 185;
            this.table_Affected_column.MinimumWidth = 185;
            this.table_Affected_column.Text = "مجموعة البيانات التي تم تغييرها";
            this.table_Affected_column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.table_Affected_column.Width = 185;
            // 
            // Date_Column
            // 
            this.Date_Column.AspectName = "DT_String";
            this.Date_Column.AspectToStringFormat = "";
            this.Date_Column.MaximumWidth = 180;
            this.Date_Column.MinimumWidth = 180;
            this.Date_Column.Text = "التاريخ";
            this.Date_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Date_Column.Width = 180;
            // 
            // operation_Column
            // 
            this.operation_Column.AspectName = "operation";
            this.operation_Column.MaximumWidth = 210;
            this.operation_Column.MinimumWidth = 210;
            this.operation_Column.Text = "العملية";
            this.operation_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.operation_Column.Width = 210;
            // 
            // Extra_Column
            // 
            this.Extra_Column.AspectName = "add_info";
            this.Extra_Column.MaximumWidth = 500;
            this.Extra_Column.MinimumWidth = 500;
            this.Extra_Column.Text = "معلومات إضافية";
            this.Extra_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Extra_Column.Width = 500;
            // 
            // History_SearchButton
            // 
            this.HistoryAux_TablePanel.SetColumnSpan(this.History_SearchButton, 4);
            this.History_SearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.History_SearchButton.ForeColor = System.Drawing.Color.DarkRed;
            this.History_SearchButton.Location = new System.Drawing.Point(89, 5);
            this.History_SearchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.History_SearchButton.Name = "History_SearchButton";
            this.HistoryAux_TablePanel.SetRowSpan(this.History_SearchButton, 3);
            this.History_SearchButton.Size = new System.Drawing.Size(160, 34);
            this.History_SearchButton.TabIndex = 18;
            this.History_SearchButton.Text = "بحث";
            this.History_SearchButton.UseVisualStyleBackColor = true;
            this.History_SearchButton.Click += new System.EventHandler(this.History_SearchButton_Click);
            // 
            // DB_AuxTo_Adj_Label
            // 
            this.DB_AuxTo_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DB_AuxTo_Adj_Label.Font = new System.Drawing.Font("El Messiri", 10.5F);
            this.DB_AuxTo_Adj_Label.Location = new System.Drawing.Point(745, 2);
            this.DB_AuxTo_Adj_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DB_AuxTo_Adj_Label.Name = "DB_AuxTo_Adj_Label";
            this.HistoryAux_TablePanel.SetRowSpan(this.DB_AuxTo_Adj_Label, 2);
            this.DB_AuxTo_Adj_Label.Size = new System.Drawing.Size(37, 38);
            this.DB_AuxTo_Adj_Label.TabIndex = 17;
            this.DB_AuxTo_Adj_Label.Text = "إلى";
            this.DB_AuxTo_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DB_AuxFrom_Adj_Label
            // 
            this.DB_AuxFrom_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DB_AuxFrom_Adj_Label.Font = new System.Drawing.Font("El Messiri", 10.5F);
            this.DB_AuxFrom_Adj_Label.Location = new System.Drawing.Point(1237, 2);
            this.DB_AuxFrom_Adj_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DB_AuxFrom_Adj_Label.Name = "DB_AuxFrom_Adj_Label";
            this.HistoryAux_TablePanel.SetRowSpan(this.DB_AuxFrom_Adj_Label, 2);
            this.DB_AuxFrom_Adj_Label.Size = new System.Drawing.Size(37, 38);
            this.DB_AuxFrom_Adj_Label.TabIndex = 16;
            this.DB_AuxFrom_Adj_Label.Text = "من";
            this.DB_AuxFrom_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // History_From_Datetimepicker
            // 
            this.History_From_Datetimepicker.CalendarFont = new System.Drawing.Font("El Messiri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryAux_TablePanel.SetColumnSpan(this.History_From_Datetimepicker, 9);
            this.History_From_Datetimepicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.History_From_Datetimepicker.Font = new System.Drawing.Font("El Messiri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History_From_Datetimepicker.Location = new System.Drawing.Point(868, 5);
            this.History_From_Datetimepicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.History_From_Datetimepicker.Name = "History_From_Datetimepicker";
            this.HistoryAux_TablePanel.SetRowSpan(this.History_From_Datetimepicker, 2);
            this.History_From_Datetimepicker.Size = new System.Drawing.Size(365, 39);
            this.History_From_Datetimepicker.TabIndex = 14;
            this.History_From_Datetimepicker.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            // 
            // History_To_Datetimepicker
            // 
            this.History_To_Datetimepicker.CalendarFont = new System.Drawing.Font("El Messiri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryAux_TablePanel.SetColumnSpan(this.History_To_Datetimepicker, 9);
            this.History_To_Datetimepicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.History_To_Datetimepicker.Font = new System.Drawing.Font("El Messiri", 12F);
            this.History_To_Datetimepicker.Location = new System.Drawing.Point(376, 5);
            this.History_To_Datetimepicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.History_To_Datetimepicker.Name = "History_To_Datetimepicker";
            this.HistoryAux_TablePanel.SetRowSpan(this.History_To_Datetimepicker, 2);
            this.History_To_Datetimepicker.Size = new System.Drawing.Size(365, 39);
            this.History_To_Datetimepicker.TabIndex = 15;
            this.History_To_Datetimepicker.Value = new System.DateTime(2025, 7, 2, 0, 0, 0, 0);
            // 
            // History_Clear_Button
            // 
            this.HistoryAux_TablePanel.SetColumnSpan(this.History_Clear_Button, 7);
            this.History_Clear_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.History_Clear_Button.Location = new System.Drawing.Point(3, 522);
            this.History_Clear_Button.Name = "History_Clear_Button";
            this.HistoryAux_TablePanel.SetRowSpan(this.History_Clear_Button, 2);
            this.History_Clear_Button.Size = new System.Drawing.Size(286, 54);
            this.History_Clear_Button.TabIndex = 22;
            this.History_Clear_Button.Text = "حذف تاريخ العمليات";
            this.History_Clear_Button.UseVisualStyleBackColor = true;
            this.History_Clear_Button.Click += new System.EventHandler(this.History_Clear_Button_Click);
            // 
            // DB_NT_Groupbox
            // 
            this.DB_NT_Groupbox.BackColor = System.Drawing.Color.Transparent;
            this.DB_NT_Groupbox.Controls.Add(this.DS_NT_average_Label);
            this.DB_NT_Groupbox.Controls.Add(this.DS_NT_average_Adj_Label);
            this.DB_NT_Groupbox.Controls.Add(this.DS_NT_total_Label);
            this.DB_NT_Groupbox.Controls.Add(this.DS_NT_total_Adj_Label);
            this.DB_NT_Groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DB_NT_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_NT_Groupbox.ForeColor = System.Drawing.Color.DarkGreen;
            this.DB_NT_Groupbox.Location = new System.Drawing.Point(3, 3);
            this.DB_NT_Groupbox.Name = "DB_NT_Groupbox";
            this.DB_NT_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DB_NT_Groupbox.Size = new System.Drawing.Size(553, 486);
            this.DB_NT_Groupbox.TabIndex = 12;
            this.DB_NT_Groupbox.TabStop = false;
            this.DB_NT_Groupbox.Text = "الملاحظات";
            // 
            // DS_NT_average_Label
            // 
            this.DS_NT_average_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_NT_average_Label.Font = new System.Drawing.Font("Cairo", 9.3F);
            this.DS_NT_average_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.DS_NT_average_Label.Location = new System.Drawing.Point(3, 194);
            this.DS_NT_average_Label.Name = "DS_NT_average_Label";
            this.DS_NT_average_Label.Size = new System.Drawing.Size(547, 65);
            this.DS_NT_average_Label.TabIndex = 33;
            this.DS_NT_average_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DS_NT_average_Adj_Label
            // 
            this.DS_NT_average_Adj_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_NT_average_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.DS_NT_average_Adj_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.DS_NT_average_Adj_Label.Location = new System.Drawing.Point(3, 149);
            this.DS_NT_average_Adj_Label.Name = "DS_NT_average_Adj_Label";
            this.DS_NT_average_Adj_Label.Size = new System.Drawing.Size(547, 45);
            this.DS_NT_average_Adj_Label.TabIndex = 32;
            this.DS_NT_average_Adj_Label.Text = "المتوسط";
            this.DS_NT_average_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DS_NT_total_Label
            // 
            this.DS_NT_total_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_NT_total_Label.Font = new System.Drawing.Font("Cairo", 9.3F);
            this.DS_NT_total_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.DS_NT_total_Label.Location = new System.Drawing.Point(3, 84);
            this.DS_NT_total_Label.Name = "DS_NT_total_Label";
            this.DS_NT_total_Label.Size = new System.Drawing.Size(547, 65);
            this.DS_NT_total_Label.TabIndex = 29;
            this.DS_NT_total_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DS_NT_total_Adj_Label
            // 
            this.DS_NT_total_Adj_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_NT_total_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.DS_NT_total_Adj_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.DS_NT_total_Adj_Label.Location = new System.Drawing.Point(3, 39);
            this.DS_NT_total_Adj_Label.Name = "DS_NT_total_Adj_Label";
            this.DS_NT_total_Adj_Label.Size = new System.Drawing.Size(547, 45);
            this.DS_NT_total_Adj_Label.TabIndex = 28;
            this.DS_NT_total_Adj_Label.Text = "الإجمالي";
            this.DS_NT_total_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dashboard_Panel
            // 
            this.dashboard_Panel.AutoScroll = true;
            this.dashboard_Panel.Controls.Add(this.charts_TablePanel);
            this.dashboard_Panel.Controls.Add(this.DS_TablePanel);
            this.dashboard_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard_Panel.Location = new System.Drawing.Point(0, 0);
            this.dashboard_Panel.Name = "dashboard_Panel";
            this.dashboard_Panel.Size = new System.Drawing.Size(1675, 851);
            this.dashboard_Panel.TabIndex = 53;
            // 
            // charts_TablePanel
            // 
            this.charts_TablePanel.ColumnCount = 2;
            this.charts_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.charts_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.charts_TablePanel.Controls.Add(this.TD_PieChart, 0, 0);
            this.charts_TablePanel.Controls.Add(this.FNC_CartiseanChart, 1, 0);
            this.charts_TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charts_TablePanel.Location = new System.Drawing.Point(0, 492);
            this.charts_TablePanel.Name = "charts_TablePanel";
            this.charts_TablePanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.charts_TablePanel.RowCount = 1;
            this.charts_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.charts_TablePanel.Size = new System.Drawing.Size(1675, 359);
            this.charts_TablePanel.TabIndex = 13;
            // 
            // TD_PieChart
            // 
            this.TD_PieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TD_PieChart.Location = new System.Drawing.Point(925, 3);
            this.TD_PieChart.Name = "TD_PieChart";
            this.TD_PieChart.Size = new System.Drawing.Size(747, 353);
            this.TD_PieChart.TabIndex = 12;
            this.TD_PieChart.Text = "pieChart1";
            // 
            // FNC_CartiseanChart
            // 
            this.FNC_CartiseanChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_CartiseanChart.Location = new System.Drawing.Point(3, 3);
            this.FNC_CartiseanChart.Name = "FNC_CartiseanChart";
            this.FNC_CartiseanChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FNC_CartiseanChart.Size = new System.Drawing.Size(916, 353);
            this.FNC_CartiseanChart.TabIndex = 13;
            this.FNC_CartiseanChart.Text = "cartesianChart1";
            // 
            // DS_TablePanel
            // 
            this.DS_TablePanel.ColumnCount = 3;
            this.DS_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DS_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DS_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.DS_TablePanel.Controls.Add(this.DB_FN_Groupbox, 1, 0);
            this.DS_TablePanel.Controls.Add(this.DB_TD_Groupbox, 0, 0);
            this.DS_TablePanel.Controls.Add(this.DB_NT_Groupbox, 2, 0);
            this.DS_TablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_TablePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.DS_TablePanel.Location = new System.Drawing.Point(0, 0);
            this.DS_TablePanel.Name = "DS_TablePanel";
            this.DS_TablePanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DS_TablePanel.RowCount = 1;
            this.DS_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DS_TablePanel.Size = new System.Drawing.Size(1675, 492);
            this.DS_TablePanel.TabIndex = 11;
            // 
            // DB_FN_Groupbox
            // 
            this.DB_FN_Groupbox.BackColor = System.Drawing.Color.Transparent;
            this.DB_FN_Groupbox.Controls.Add(this.DS_FN_required_Label);
            this.DB_FN_Groupbox.Controls.Add(this.DS_FN_required_Adj_Label);
            this.DB_FN_Groupbox.Controls.Add(this.DS_FN_average_Label);
            this.DB_FN_Groupbox.Controls.Add(this.DS_FN_average_Adj_Label);
            this.DB_FN_Groupbox.Controls.Add(this.DS_FN_month_Label);
            this.DB_FN_Groupbox.Controls.Add(this.DS_FN_month_Adj_Label);
            this.DB_FN_Groupbox.Controls.Add(this.DS_FN_Total_Label);
            this.DB_FN_Groupbox.Controls.Add(this.DS_FN_total_Adj_Label);
            this.DB_FN_Groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DB_FN_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_FN_Groupbox.ForeColor = System.Drawing.Color.Blue;
            this.DB_FN_Groupbox.Location = new System.Drawing.Point(562, 3);
            this.DB_FN_Groupbox.Name = "DB_FN_Groupbox";
            this.DB_FN_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DB_FN_Groupbox.Size = new System.Drawing.Size(552, 486);
            this.DB_FN_Groupbox.TabIndex = 13;
            this.DB_FN_Groupbox.TabStop = false;
            this.DB_FN_Groupbox.Text = "العمليات المالية";
            // 
            // DS_FN_required_Label
            // 
            this.DS_FN_required_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_FN_required_Label.Font = new System.Drawing.Font("Cairo", 8.3F);
            this.DS_FN_required_Label.ForeColor = System.Drawing.Color.Navy;
            this.DS_FN_required_Label.Location = new System.Drawing.Point(3, 414);
            this.DS_FN_required_Label.Name = "DS_FN_required_Label";
            this.DS_FN_required_Label.Size = new System.Drawing.Size(546, 65);
            this.DS_FN_required_Label.TabIndex = 29;
            this.DS_FN_required_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DS_FN_required_Adj_Label
            // 
            this.DS_FN_required_Adj_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_FN_required_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.DS_FN_required_Adj_Label.ForeColor = System.Drawing.Color.Navy;
            this.DS_FN_required_Adj_Label.Location = new System.Drawing.Point(3, 369);
            this.DS_FN_required_Adj_Label.Name = "DS_FN_required_Adj_Label";
            this.DS_FN_required_Adj_Label.Size = new System.Drawing.Size(546, 45);
            this.DS_FN_required_Adj_Label.TabIndex = 28;
            this.DS_FN_required_Adj_Label.Text = "المطلوب";
            this.DS_FN_required_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DS_FN_average_Label
            // 
            this.DS_FN_average_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_FN_average_Label.Font = new System.Drawing.Font("Cairo", 8.3F);
            this.DS_FN_average_Label.ForeColor = System.Drawing.Color.Navy;
            this.DS_FN_average_Label.Location = new System.Drawing.Point(3, 304);
            this.DS_FN_average_Label.Name = "DS_FN_average_Label";
            this.DS_FN_average_Label.Size = new System.Drawing.Size(546, 65);
            this.DS_FN_average_Label.TabIndex = 27;
            this.DS_FN_average_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DS_FN_average_Adj_Label
            // 
            this.DS_FN_average_Adj_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_FN_average_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.DS_FN_average_Adj_Label.ForeColor = System.Drawing.Color.Navy;
            this.DS_FN_average_Adj_Label.Location = new System.Drawing.Point(3, 259);
            this.DS_FN_average_Adj_Label.Name = "DS_FN_average_Adj_Label";
            this.DS_FN_average_Adj_Label.Size = new System.Drawing.Size(546, 45);
            this.DS_FN_average_Adj_Label.TabIndex = 26;
            this.DS_FN_average_Adj_Label.Text = "المتوسط";
            this.DS_FN_average_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DS_FN_month_Label
            // 
            this.DS_FN_month_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_FN_month_Label.Font = new System.Drawing.Font("Cairo", 8.3F);
            this.DS_FN_month_Label.ForeColor = System.Drawing.Color.Navy;
            this.DS_FN_month_Label.Location = new System.Drawing.Point(3, 194);
            this.DS_FN_month_Label.Name = "DS_FN_month_Label";
            this.DS_FN_month_Label.Size = new System.Drawing.Size(546, 65);
            this.DS_FN_month_Label.TabIndex = 25;
            this.DS_FN_month_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DS_FN_month_Adj_Label
            // 
            this.DS_FN_month_Adj_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_FN_month_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.DS_FN_month_Adj_Label.ForeColor = System.Drawing.Color.Navy;
            this.DS_FN_month_Adj_Label.Location = new System.Drawing.Point(3, 149);
            this.DS_FN_month_Adj_Label.Name = "DS_FN_month_Adj_Label";
            this.DS_FN_month_Adj_Label.Size = new System.Drawing.Size(546, 45);
            this.DS_FN_month_Adj_Label.TabIndex = 24;
            this.DS_FN_month_Adj_Label.Text = "هذا الشهر";
            this.DS_FN_month_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DS_FN_Total_Label
            // 
            this.DS_FN_Total_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_FN_Total_Label.Font = new System.Drawing.Font("Cairo", 8.3F);
            this.DS_FN_Total_Label.ForeColor = System.Drawing.Color.Navy;
            this.DS_FN_Total_Label.Location = new System.Drawing.Point(3, 84);
            this.DS_FN_Total_Label.Name = "DS_FN_Total_Label";
            this.DS_FN_Total_Label.Size = new System.Drawing.Size(546, 65);
            this.DS_FN_Total_Label.TabIndex = 23;
            this.DS_FN_Total_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DS_FN_total_Adj_Label
            // 
            this.DS_FN_total_Adj_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.DS_FN_total_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.DS_FN_total_Adj_Label.ForeColor = System.Drawing.Color.Navy;
            this.DS_FN_total_Adj_Label.Location = new System.Drawing.Point(3, 39);
            this.DS_FN_total_Adj_Label.Name = "DS_FN_total_Adj_Label";
            this.DS_FN_total_Adj_Label.Size = new System.Drawing.Size(546, 45);
            this.DS_FN_total_Adj_Label.TabIndex = 17;
            this.DS_FN_total_Adj_Label.Text = "الإجمالي";
            this.DS_FN_total_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dashboard_Panel);
            this.splitContainer1.Panel1.Controls.Add(this.Aux_Panel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DSB_History_Button);
            this.splitContainer1.Size = new System.Drawing.Size(1675, 930);
            this.splitContainer1.SplitterDistance = 851;
            this.splitContainer1.TabIndex = 0;
            // 
            // Aux_Panel
            // 
            this.Aux_Panel.Controls.Add(this.History_Groupbox);
            this.Aux_Panel.Location = new System.Drawing.Point(0, 230);
            this.Aux_Panel.Name = "Aux_Panel";
            this.Aux_Panel.Size = new System.Drawing.Size(1364, 621);
            this.Aux_Panel.TabIndex = 34;
            this.Aux_Panel.Visible = false;
            this.Aux_Panel.Leave += new System.EventHandler(this.Aux_Panel_Leave);
            // 
            // DSB_History_Button
            // 
            this.DSB_History_Button.BackColor = System.Drawing.Color.Transparent;
            this.DSB_History_Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.DSB_History_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DSB_History_Button.Image = global::DailyCompanionV2.Properties.Resources.history;
            this.DSB_History_Button.ImageActive = null;
            this.DSB_History_Button.Location = new System.Drawing.Point(0, 0);
            this.DSB_History_Button.Name = "DSB_History_Button";
            this.DSB_History_Button.Size = new System.Drawing.Size(70, 75);
            this.DSB_History_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DSB_History_Button.TabIndex = 76;
            this.DSB_History_Button.TabStop = false;
            this.DSB_History_Button.Zoom = 10;
            this.DSB_History_Button.Click += new System.EventHandler(this.DSB_History_Button_Click);
            // 
            // UsrCtrl_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UsrCtrl_Dashboard";
            this.Size = new System.Drawing.Size(1675, 930);
            this.DB_TD_Groupbox.ResumeLayout(false);
            this.History_Groupbox.ResumeLayout(false);
            this.HistoryAux_TablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.history_Objectlistview)).EndInit();
            this.DB_NT_Groupbox.ResumeLayout(false);
            this.dashboard_Panel.ResumeLayout(false);
            this.charts_TablePanel.ResumeLayout(false);
            this.DS_TablePanel.ResumeLayout(false);
            this.DB_FN_Groupbox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Aux_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSB_History_Button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox DB_TD_Groupbox;
        private GroupBox History_Groupbox;
        private Button History_SearchButton;
        private Label DB_AuxTo_Adj_Label;
        private Label DB_AuxFrom_Adj_Label;
        private DateTimePicker History_To_Datetimepicker;
        private DateTimePicker History_From_Datetimepicker;
        private BrightIdeasSoftware.ObjectListView history_Objectlistview;
        private BrightIdeasSoftware.OLVColumn index_Column;
        private BrightIdeasSoftware.OLVColumn table_Affected_column;
        private BrightIdeasSoftware.OLVColumn Date_Column;
        private BrightIdeasSoftware.OLVColumn operation_Column;
        private BrightIdeasSoftware.OLVColumn Extra_Column;
        private GroupBox DB_NT_Groupbox;
        private Panel dashboard_Panel;
        private SplitContainer splitContainer1;
        private ns1.BunifuImageButton DSB_History_Button;
        private Label DS_TD_Total_Label;
        private Label DS_TD_total_Adj_Label;
        private TableLayoutPanel DS_TablePanel;
        private Label DS_TD_required_Label;
        private Label DS_TD_required_Adj_Label;
        private Label DS_TD_average_Label;
        private Label DS_TD_average_Adj_Label;
        private Label DS_TD_month_Label;
        private Label DS_TD_month_Adj_Label;
        private Label DS_NT_average_Label;
        private Label DS_NT_average_Adj_Label;
        private Label DS_NT_total_Label;
        private Label DS_NT_total_Adj_Label;
        private TableLayoutPanel charts_TablePanel;
        private LiveCharts.WinForms.PieChart TD_PieChart;
        private LiveCharts.WinForms.CartesianChart FNC_CartiseanChart;
        private GroupBox DB_FN_Groupbox;
        private Label DS_FN_required_Label;
        private Label DS_FN_required_Adj_Label;
        private Label DS_FN_average_Label;
        private Label DS_FN_average_Adj_Label;
        private Label DS_FN_month_Label;
        private Label DS_FN_month_Adj_Label;
        private Label DS_FN_Total_Label;
        private Label DS_FN_total_Adj_Label;
        private Panel Aux_Panel;
        private TableLayoutPanel HistoryAux_TablePanel;
        private Label AuxComment_Label;
        private Button History_Clear_Button;
    }
}
