using System.Windows.Forms;

namespace OpsMoi
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
            this.DB_CS_Groupbox = new System.Windows.Forms.GroupBox();
            this.Todos_TablelayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TODOs_AverageDuration_Label = new System.Windows.Forms.Label();
            this.TODOs_MonthDuration_Label = new System.Windows.Forms.Label();
            this.TODOs_TotalDuration_Label = new System.Windows.Forms.Label();
            this.TODOs_AverageCount_Label = new System.Windows.Forms.Label();
            this.TODOs_MonthCount_Label = new System.Windows.Forms.Label();
            this.TODOs_TotalCount_Label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DB_ShwTodo_Button = new System.Windows.Forms.Button();
            this.DB_AddTodo_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Dashboard_Tabcontrol = new TransparentTabControl();
            this.dashboard_Tabpage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.NOT_AverageLength_Label = new System.Windows.Forms.Label();
            this.NOT_TotalLength_Label = new System.Windows.Forms.Label();
            this.NOT_TotalCount_Label = new System.Windows.Forms.Label();
            this.DB_ShwNot_Button = new System.Windows.Forms.Button();
            this.DB_AddNot_Button = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FNC_AveragePaid_Label = new System.Windows.Forms.Label();
            this.FNC_MonthPaid_Label = new System.Windows.Forms.Label();
            this.FNC_TotalPaid_Label = new System.Windows.Forms.Label();
            this.FNC_AverageCount_Label = new System.Windows.Forms.Label();
            this.FNC_MonthCount_Label = new System.Windows.Forms.Label();
            this.FNC_TotalCount_Label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DB_ShwFnc_Button = new System.Windows.Forms.Button();
            this.DB_AddFnc_Button = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.history_Tabpage = new System.Windows.Forms.TabPage();
            this.History_Groupbox = new System.Windows.Forms.GroupBox();
            this.History_SearchButton = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.History_To_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.History_From_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.history_Objectlistview = new BrightIdeasSoftware.ObjectListView();
            this.index_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.table_Affected_column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Date_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.operation_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Extra_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TileButtons_Panel = new System.Windows.Forms.Panel();
            this.History_Tilebutton = new ns1.BunifuTileButton();
            this.SidePanel1 = new System.Windows.Forms.Panel();
            this.Dashboard_Tilebutton = new ns1.BunifuTileButton();
            this.DB_CS_Groupbox.SuspendLayout();
            this.Todos_TablelayoutPanel.SuspendLayout();
            this.Dashboard_Tabcontrol.SuspendLayout();
            this.dashboard_Tabpage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.history_Tabpage.SuspendLayout();
            this.History_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.history_Objectlistview)).BeginInit();
            this.TileButtons_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DB_CS_Groupbox
            // 
            this.DB_CS_Groupbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DB_CS_Groupbox.BackColor = System.Drawing.Color.Transparent;
            this.DB_CS_Groupbox.Controls.Add(this.Todos_TablelayoutPanel);
            this.DB_CS_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_CS_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.DB_CS_Groupbox.Location = new System.Drawing.Point(861, 13);
            this.DB_CS_Groupbox.Name = "DB_CS_Groupbox";
            this.DB_CS_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DB_CS_Groupbox.Size = new System.Drawing.Size(717, 495);
            this.DB_CS_Groupbox.TabIndex = 10;
            this.DB_CS_Groupbox.TabStop = false;
            this.DB_CS_Groupbox.Text = "اختصارات المهام المطلوبة";
            // 
            // Todos_TablelayoutPanel
            // 
            this.Todos_TablelayoutPanel.ColumnCount = 5;
            this.Todos_TablelayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Todos_TablelayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Todos_TablelayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Todos_TablelayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Todos_TablelayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Todos_TablelayoutPanel.Controls.Add(this.TODOs_AverageDuration_Label, 3, 5);
            this.Todos_TablelayoutPanel.Controls.Add(this.TODOs_MonthDuration_Label, 3, 4);
            this.Todos_TablelayoutPanel.Controls.Add(this.TODOs_TotalDuration_Label, 3, 3);
            this.Todos_TablelayoutPanel.Controls.Add(this.TODOs_AverageCount_Label, 3, 2);
            this.Todos_TablelayoutPanel.Controls.Add(this.TODOs_MonthCount_Label, 3, 1);
            this.Todos_TablelayoutPanel.Controls.Add(this.TODOs_TotalCount_Label, 3, 0);
            this.Todos_TablelayoutPanel.Controls.Add(this.label11, 0, 5);
            this.Todos_TablelayoutPanel.Controls.Add(this.label8, 0, 4);
            this.Todos_TablelayoutPanel.Controls.Add(this.DB_ShwTodo_Button, 2, 7);
            this.Todos_TablelayoutPanel.Controls.Add(this.DB_AddTodo_Button, 0, 7);
            this.Todos_TablelayoutPanel.Controls.Add(this.label1, 0, 3);
            this.Todos_TablelayoutPanel.Controls.Add(this.label2, 0, 2);
            this.Todos_TablelayoutPanel.Controls.Add(this.label3, 0, 1);
            this.Todos_TablelayoutPanel.Controls.Add(this.label4, 0, 0);
            this.Todos_TablelayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Todos_TablelayoutPanel.Location = new System.Drawing.Point(3, 39);
            this.Todos_TablelayoutPanel.Name = "Todos_TablelayoutPanel";
            this.Todos_TablelayoutPanel.RowCount = 8;
            this.Todos_TablelayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Todos_TablelayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Todos_TablelayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Todos_TablelayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Todos_TablelayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Todos_TablelayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Todos_TablelayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Todos_TablelayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.Todos_TablelayoutPanel.Size = new System.Drawing.Size(711, 453);
            this.Todos_TablelayoutPanel.TabIndex = 0;
            // 
            // TODOs_AverageDuration_Label
            // 
            this.Todos_TablelayoutPanel.SetColumnSpan(this.TODOs_AverageDuration_Label, 2);
            this.TODOs_AverageDuration_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODOs_AverageDuration_Label.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODOs_AverageDuration_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.TODOs_AverageDuration_Label.Location = new System.Drawing.Point(3, 280);
            this.TODOs_AverageDuration_Label.Name = "TODOs_AverageDuration_Label";
            this.TODOs_AverageDuration_Label.Size = new System.Drawing.Size(279, 56);
            this.TODOs_AverageDuration_Label.TabIndex = 27;
            this.TODOs_AverageDuration_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TODOs_MonthDuration_Label
            // 
            this.Todos_TablelayoutPanel.SetColumnSpan(this.TODOs_MonthDuration_Label, 2);
            this.TODOs_MonthDuration_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODOs_MonthDuration_Label.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODOs_MonthDuration_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.TODOs_MonthDuration_Label.Location = new System.Drawing.Point(3, 224);
            this.TODOs_MonthDuration_Label.Name = "TODOs_MonthDuration_Label";
            this.TODOs_MonthDuration_Label.Size = new System.Drawing.Size(279, 56);
            this.TODOs_MonthDuration_Label.TabIndex = 26;
            this.TODOs_MonthDuration_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TODOs_TotalDuration_Label
            // 
            this.Todos_TablelayoutPanel.SetColumnSpan(this.TODOs_TotalDuration_Label, 2);
            this.TODOs_TotalDuration_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODOs_TotalDuration_Label.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODOs_TotalDuration_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.TODOs_TotalDuration_Label.Location = new System.Drawing.Point(3, 168);
            this.TODOs_TotalDuration_Label.Name = "TODOs_TotalDuration_Label";
            this.TODOs_TotalDuration_Label.Size = new System.Drawing.Size(279, 56);
            this.TODOs_TotalDuration_Label.TabIndex = 25;
            this.TODOs_TotalDuration_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TODOs_AverageCount_Label
            // 
            this.Todos_TablelayoutPanel.SetColumnSpan(this.TODOs_AverageCount_Label, 2);
            this.TODOs_AverageCount_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODOs_AverageCount_Label.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODOs_AverageCount_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.TODOs_AverageCount_Label.Location = new System.Drawing.Point(3, 112);
            this.TODOs_AverageCount_Label.Name = "TODOs_AverageCount_Label";
            this.TODOs_AverageCount_Label.Size = new System.Drawing.Size(279, 56);
            this.TODOs_AverageCount_Label.TabIndex = 24;
            this.TODOs_AverageCount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TODOs_MonthCount_Label
            // 
            this.Todos_TablelayoutPanel.SetColumnSpan(this.TODOs_MonthCount_Label, 2);
            this.TODOs_MonthCount_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODOs_MonthCount_Label.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODOs_MonthCount_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.TODOs_MonthCount_Label.Location = new System.Drawing.Point(3, 56);
            this.TODOs_MonthCount_Label.Name = "TODOs_MonthCount_Label";
            this.TODOs_MonthCount_Label.Size = new System.Drawing.Size(279, 56);
            this.TODOs_MonthCount_Label.TabIndex = 23;
            this.TODOs_MonthCount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TODOs_TotalCount_Label
            // 
            this.Todos_TablelayoutPanel.SetColumnSpan(this.TODOs_TotalCount_Label, 2);
            this.TODOs_TotalCount_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODOs_TotalCount_Label.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODOs_TotalCount_Label.ForeColor = System.Drawing.Color.Firebrick;
            this.TODOs_TotalCount_Label.Location = new System.Drawing.Point(3, 0);
            this.TODOs_TotalCount_Label.Name = "TODOs_TotalCount_Label";
            this.TODOs_TotalCount_Label.Size = new System.Drawing.Size(279, 56);
            this.TODOs_TotalCount_Label.TabIndex = 22;
            this.TODOs_TotalCount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.Todos_TablelayoutPanel.SetColumnSpan(this.label11, 3);
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("A Nasr", 20.2F);
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(288, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(420, 56);
            this.label11.TabIndex = 21;
            this.label11.Text = "متوسط المدة المستغرقة/الشهر";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.Todos_TablelayoutPanel.SetColumnSpan(this.label8, 3);
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("A Nasr", 20.2F);
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(288, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(420, 56);
            this.label8.TabIndex = 20;
            this.label8.Text = "إجمالي المدة المستغرقة هذا الشهر";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DB_ShwTodo_Button
            // 
            this.DB_ShwTodo_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Todos_TablelayoutPanel.SetColumnSpan(this.DB_ShwTodo_Button, 3);
            this.DB_ShwTodo_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DB_ShwTodo_Button.Font = new System.Drawing.Font("El Messiri SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_ShwTodo_Button.ForeColor = System.Drawing.Color.Red;
            this.DB_ShwTodo_Button.Location = new System.Drawing.Point(41, 395);
            this.DB_ShwTodo_Button.Margin = new System.Windows.Forms.Padding(35, 3, 35, 3);
            this.DB_ShwTodo_Button.Name = "DB_ShwTodo_Button";
            this.DB_ShwTodo_Button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DB_ShwTodo_Button.Size = new System.Drawing.Size(351, 55);
            this.DB_ShwTodo_Button.TabIndex = 15;
            this.DB_ShwTodo_Button.Tag = "";
            this.DB_ShwTodo_Button.Text = "عرض المهام المطلوبة";
            this.DB_ShwTodo_Button.UseVisualStyleBackColor = false;
            this.DB_ShwTodo_Button.Click += new System.EventHandler(this.DB_ShwTodo_Button_Click);
            // 
            // DB_AddTodo_Button
            // 
            this.DB_AddTodo_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Todos_TablelayoutPanel.SetColumnSpan(this.DB_AddTodo_Button, 2);
            this.DB_AddTodo_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DB_AddTodo_Button.Font = new System.Drawing.Font("El Messiri SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_AddTodo_Button.ForeColor = System.Drawing.Color.Red;
            this.DB_AddTodo_Button.Location = new System.Drawing.Point(452, 395);
            this.DB_AddTodo_Button.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.DB_AddTodo_Button.Name = "DB_AddTodo_Button";
            this.DB_AddTodo_Button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DB_AddTodo_Button.Size = new System.Drawing.Size(239, 55);
            this.DB_AddTodo_Button.TabIndex = 14;
            this.DB_AddTodo_Button.Tag = "";
            this.DB_AddTodo_Button.Text = "إضافة مهمة جديدة";
            this.DB_AddTodo_Button.UseVisualStyleBackColor = false;
            this.DB_AddTodo_Button.Click += new System.EventHandler(this.DB_AddTodo_Button_Click);
            // 
            // label1
            // 
            this.Todos_TablelayoutPanel.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("A Nasr", 22.2F);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(288, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 56);
            this.label1.TabIndex = 17;
            this.label1.Text = "إجمالي المدة المستغرقة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.Todos_TablelayoutPanel.SetColumnSpan(this.label2, 3);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("A Nasr", 22.2F);
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(288, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 56);
            this.label2.TabIndex = 18;
            this.label2.Text = "متوسط عدد المهام/الشهر";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.Todos_TablelayoutPanel.SetColumnSpan(this.label3, 3);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("A Nasr", 20.2F);
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(288, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 56);
            this.label3.TabIndex = 19;
            this.label3.Text = "عدد المهام المطلوبة هذا الشهر";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.Todos_TablelayoutPanel.SetColumnSpan(this.label4, 3);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("A Nasr", 22.2F);
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(288, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(420, 56);
            this.label4.TabIndex = 16;
            this.label4.Text = "إجمالي عدد المهام المطلوبة";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Dashboard_Tabcontrol
            // 
            this.Dashboard_Tabcontrol.Controls.Add(this.dashboard_Tabpage);
            this.Dashboard_Tabcontrol.Controls.Add(this.history_Tabpage);
            this.Dashboard_Tabcontrol.ItemSize = new System.Drawing.Size(0, 1);
            this.Dashboard_Tabcontrol.Location = new System.Drawing.Point(201, 4);
            this.Dashboard_Tabcontrol.Name = "Dashboard_Tabcontrol";
            this.Dashboard_Tabcontrol.SelectedIndex = 0;
            this.Dashboard_Tabcontrol.Size = new System.Drawing.Size(1592, 943);
            this.Dashboard_Tabcontrol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Dashboard_Tabcontrol.TabIndex = 14;
            this.Dashboard_Tabcontrol.SelectedIndexChanged += new System.EventHandler(this.Dashboard_Tabcontrol_SelectedIndexChanged);
            // 
            // dashboard_Tabpage
            // 
            this.dashboard_Tabpage.Controls.Add(this.groupBox2);
            this.dashboard_Tabpage.Controls.Add(this.groupBox1);
            this.dashboard_Tabpage.Controls.Add(this.DB_CS_Groupbox);
            this.dashboard_Tabpage.Location = new System.Drawing.Point(4, 5);
            this.dashboard_Tabpage.Name = "dashboard_Tabpage";
            this.dashboard_Tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.dashboard_Tabpage.Size = new System.Drawing.Size(1584, 934);
            this.dashboard_Tabpage.TabIndex = 0;
            this.dashboard_Tabpage.Text = "معلومات وتحكم";
            this.dashboard_Tabpage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox2.Location = new System.Drawing.Point(861, 546);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(717, 348);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اختصارات الملاحظات";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.NOT_AverageLength_Label, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.NOT_TotalLength_Label, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.NOT_TotalCount_Label, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.DB_ShwNot_Button, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.DB_AddNot_Button, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label22, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label25, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label26, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(711, 306);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // NOT_AverageLength_Label
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.NOT_AverageLength_Label, 2);
            this.NOT_AverageLength_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NOT_AverageLength_Label.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOT_AverageLength_Label.ForeColor = System.Drawing.Color.Green;
            this.NOT_AverageLength_Label.Location = new System.Drawing.Point(3, 122);
            this.NOT_AverageLength_Label.Name = "NOT_AverageLength_Label";
            this.NOT_AverageLength_Label.Size = new System.Drawing.Size(279, 61);
            this.NOT_AverageLength_Label.TabIndex = 24;
            this.NOT_AverageLength_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NOT_TotalLength_Label
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.NOT_TotalLength_Label, 2);
            this.NOT_TotalLength_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NOT_TotalLength_Label.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOT_TotalLength_Label.ForeColor = System.Drawing.Color.Green;
            this.NOT_TotalLength_Label.Location = new System.Drawing.Point(3, 61);
            this.NOT_TotalLength_Label.Name = "NOT_TotalLength_Label";
            this.NOT_TotalLength_Label.Size = new System.Drawing.Size(279, 61);
            this.NOT_TotalLength_Label.TabIndex = 23;
            this.NOT_TotalLength_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NOT_TotalCount_Label
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.NOT_TotalCount_Label, 2);
            this.NOT_TotalCount_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NOT_TotalCount_Label.Font = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOT_TotalCount_Label.ForeColor = System.Drawing.Color.Green;
            this.NOT_TotalCount_Label.Location = new System.Drawing.Point(3, 0);
            this.NOT_TotalCount_Label.Name = "NOT_TotalCount_Label";
            this.NOT_TotalCount_Label.Size = new System.Drawing.Size(279, 61);
            this.NOT_TotalCount_Label.TabIndex = 22;
            this.NOT_TotalCount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DB_ShwNot_Button
            // 
            this.DB_ShwNot_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tableLayoutPanel2.SetColumnSpan(this.DB_ShwNot_Button, 3);
            this.DB_ShwNot_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DB_ShwNot_Button.Font = new System.Drawing.Font("El Messiri SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_ShwNot_Button.ForeColor = System.Drawing.Color.Lime;
            this.DB_ShwNot_Button.Location = new System.Drawing.Point(41, 247);
            this.DB_ShwNot_Button.Margin = new System.Windows.Forms.Padding(35, 3, 35, 3);
            this.DB_ShwNot_Button.Name = "DB_ShwNot_Button";
            this.DB_ShwNot_Button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DB_ShwNot_Button.Size = new System.Drawing.Size(351, 55);
            this.DB_ShwNot_Button.TabIndex = 15;
            this.DB_ShwNot_Button.Tag = "";
            this.DB_ShwNot_Button.Text = "عرض الملاحظات";
            this.DB_ShwNot_Button.UseVisualStyleBackColor = false;
            this.DB_ShwNot_Button.Click += new System.EventHandler(this.DB_ShwNot_Button_Click);
            // 
            // DB_AddNot_Button
            // 
            this.DB_AddNot_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tableLayoutPanel2.SetColumnSpan(this.DB_AddNot_Button, 2);
            this.DB_AddNot_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DB_AddNot_Button.Font = new System.Drawing.Font("El Messiri SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_AddNot_Button.ForeColor = System.Drawing.Color.Lime;
            this.DB_AddNot_Button.Location = new System.Drawing.Point(452, 247);
            this.DB_AddNot_Button.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.DB_AddNot_Button.Name = "DB_AddNot_Button";
            this.DB_AddNot_Button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DB_AddNot_Button.Size = new System.Drawing.Size(239, 55);
            this.DB_AddNot_Button.TabIndex = 14;
            this.DB_AddNot_Button.Tag = "";
            this.DB_AddNot_Button.Text = "إضافة ملاحظة جديدة";
            this.DB_AddNot_Button.UseVisualStyleBackColor = false;
            this.DB_AddNot_Button.Click += new System.EventHandler(this.DB_AddNot_Button_Click);
            // 
            // label22
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.label22, 3);
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("A Nasr", 22.2F);
            this.label22.ForeColor = System.Drawing.Color.Green;
            this.label22.Location = new System.Drawing.Point(288, 122);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(420, 61);
            this.label22.TabIndex = 18;
            this.label22.Text = "متوسط طول الملاحظات";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.label25, 3);
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("A Nasr", 20.2F);
            this.label25.ForeColor = System.Drawing.Color.Green;
            this.label25.Location = new System.Drawing.Point(288, 61);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(420, 61);
            this.label25.TabIndex = 19;
            this.label25.Text = "إجمالي طول الملاحظات";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.label26, 3);
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("A Nasr", 22.2F);
            this.label26.ForeColor = System.Drawing.Color.Green;
            this.label26.Location = new System.Drawing.Point(288, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(420, 61);
            this.label26.TabIndex = 16;
            this.label26.Text = "إجمالي عدد الملاحظات";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(774, 495);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اختصارات العمليات المالية";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.FNC_AveragePaid_Label, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.FNC_MonthPaid_Label, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.FNC_TotalPaid_Label, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.FNC_AverageCount_Label, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.FNC_MonthCount_Label, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.FNC_TotalCount_Label, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.DB_ShwFnc_Button, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.DB_AddFnc_Button, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FNC_AveragePaid_Label
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.FNC_AveragePaid_Label, 2);
            this.FNC_AveragePaid_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_AveragePaid_Label.Font = new System.Drawing.Font("Cairo", 9F);
            this.FNC_AveragePaid_Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FNC_AveragePaid_Label.Location = new System.Drawing.Point(3, 280);
            this.FNC_AveragePaid_Label.Name = "FNC_AveragePaid_Label";
            this.FNC_AveragePaid_Label.Size = new System.Drawing.Size(303, 56);
            this.FNC_AveragePaid_Label.TabIndex = 27;
            this.FNC_AveragePaid_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FNC_MonthPaid_Label
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.FNC_MonthPaid_Label, 2);
            this.FNC_MonthPaid_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_MonthPaid_Label.Font = new System.Drawing.Font("Cairo", 9F);
            this.FNC_MonthPaid_Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FNC_MonthPaid_Label.Location = new System.Drawing.Point(3, 224);
            this.FNC_MonthPaid_Label.Name = "FNC_MonthPaid_Label";
            this.FNC_MonthPaid_Label.Size = new System.Drawing.Size(303, 56);
            this.FNC_MonthPaid_Label.TabIndex = 26;
            this.FNC_MonthPaid_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FNC_TotalPaid_Label
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.FNC_TotalPaid_Label, 2);
            this.FNC_TotalPaid_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_TotalPaid_Label.Font = new System.Drawing.Font("Cairo", 9F);
            this.FNC_TotalPaid_Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FNC_TotalPaid_Label.Location = new System.Drawing.Point(3, 168);
            this.FNC_TotalPaid_Label.Name = "FNC_TotalPaid_Label";
            this.FNC_TotalPaid_Label.Size = new System.Drawing.Size(303, 56);
            this.FNC_TotalPaid_Label.TabIndex = 25;
            this.FNC_TotalPaid_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FNC_AverageCount_Label
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.FNC_AverageCount_Label, 2);
            this.FNC_AverageCount_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_AverageCount_Label.Font = new System.Drawing.Font("Cairo", 9F);
            this.FNC_AverageCount_Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FNC_AverageCount_Label.Location = new System.Drawing.Point(3, 112);
            this.FNC_AverageCount_Label.Name = "FNC_AverageCount_Label";
            this.FNC_AverageCount_Label.Size = new System.Drawing.Size(303, 56);
            this.FNC_AverageCount_Label.TabIndex = 24;
            this.FNC_AverageCount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FNC_MonthCount_Label
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.FNC_MonthCount_Label, 2);
            this.FNC_MonthCount_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_MonthCount_Label.Font = new System.Drawing.Font("Cairo", 9F);
            this.FNC_MonthCount_Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FNC_MonthCount_Label.Location = new System.Drawing.Point(3, 56);
            this.FNC_MonthCount_Label.Name = "FNC_MonthCount_Label";
            this.FNC_MonthCount_Label.Size = new System.Drawing.Size(303, 56);
            this.FNC_MonthCount_Label.TabIndex = 23;
            this.FNC_MonthCount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FNC_TotalCount_Label
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.FNC_TotalCount_Label, 2);
            this.FNC_TotalCount_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_TotalCount_Label.Font = new System.Drawing.Font("Cairo", 9F);
            this.FNC_TotalCount_Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FNC_TotalCount_Label.Location = new System.Drawing.Point(3, 0);
            this.FNC_TotalCount_Label.Name = "FNC_TotalCount_Label";
            this.FNC_TotalCount_Label.Size = new System.Drawing.Size(303, 56);
            this.FNC_TotalCount_Label.TabIndex = 22;
            this.FNC_TotalCount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label13, 3);
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("A Nasr", 15.2F);
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(312, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(453, 56);
            this.label13.TabIndex = 21;
            this.label13.Text = "متوسط قيمة العمليات المالية / الشهر (دخل / مصروف)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label14, 3);
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("A Nasr", 17.2F);
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(312, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(453, 56);
            this.label14.TabIndex = 20;
            this.label14.Text = "قيمة العمليات المالية هذا الشهر (دخل / مصروف)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DB_ShwFnc_Button
            // 
            this.DB_ShwFnc_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tableLayoutPanel1.SetColumnSpan(this.DB_ShwFnc_Button, 3);
            this.DB_ShwFnc_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DB_ShwFnc_Button.Font = new System.Drawing.Font("El Messiri SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_ShwFnc_Button.ForeColor = System.Drawing.Color.Navy;
            this.DB_ShwFnc_Button.Location = new System.Drawing.Point(61, 395);
            this.DB_ShwFnc_Button.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.DB_ShwFnc_Button.Name = "DB_ShwFnc_Button";
            this.DB_ShwFnc_Button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DB_ShwFnc_Button.Size = new System.Drawing.Size(351, 55);
            this.DB_ShwFnc_Button.TabIndex = 15;
            this.DB_ShwFnc_Button.Tag = "";
            this.DB_ShwFnc_Button.Text = "عرض العمليات المالية";
            this.DB_ShwFnc_Button.UseVisualStyleBackColor = false;
            this.DB_ShwFnc_Button.Click += new System.EventHandler(this.DB_ShwFnc_Button_Click);
            // 
            // DB_AddFnc_Button
            // 
            this.DB_AddFnc_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.tableLayoutPanel1.SetColumnSpan(this.DB_AddFnc_Button, 2);
            this.DB_AddFnc_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DB_AddFnc_Button.Font = new System.Drawing.Font("El Messiri SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_AddFnc_Button.ForeColor = System.Drawing.Color.Navy;
            this.DB_AddFnc_Button.Location = new System.Drawing.Point(499, 395);
            this.DB_AddFnc_Button.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.DB_AddFnc_Button.Name = "DB_AddFnc_Button";
            this.DB_AddFnc_Button.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DB_AddFnc_Button.Size = new System.Drawing.Size(239, 55);
            this.DB_AddFnc_Button.TabIndex = 14;
            this.DB_AddFnc_Button.Tag = "";
            this.DB_AddFnc_Button.Text = "إضافة عملية مالية";
            this.DB_AddFnc_Button.UseVisualStyleBackColor = false;
            this.DB_AddFnc_Button.Click += new System.EventHandler(this.DB_AddFnc_Button_Click);
            // 
            // label15
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label15, 3);
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("A Nasr", 18.2F);
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(312, 168);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(453, 56);
            this.label15.TabIndex = 17;
            this.label15.Text = "إجمالي قيمة العمليات المالية ( دخل / مصروف)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label18, 3);
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("A Nasr", 15.2F);
            this.label18.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label18.Location = new System.Drawing.Point(312, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(453, 56);
            this.label18.TabIndex = 18;
            this.label18.Text = "متوسط عدد العمليات المالية / الشهر (دخل / مصروف)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label19, 3);
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("A Nasr", 17.2F);
            this.label19.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label19.Location = new System.Drawing.Point(312, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(453, 56);
            this.label19.TabIndex = 19;
            this.label19.Text = "عدد العمليات المالية هذا الشهر (دخل / مصروف)";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label20, 3);
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("A Nasr", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label20.Location = new System.Drawing.Point(312, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(453, 56);
            this.label20.TabIndex = 16;
            this.label20.Text = "إجمالي عدد العمليات المالية (دخل / مصروف)";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // history_Tabpage
            // 
            this.history_Tabpage.Controls.Add(this.History_Groupbox);
            this.history_Tabpage.Location = new System.Drawing.Point(4, 5);
            this.history_Tabpage.Name = "history_Tabpage";
            this.history_Tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.history_Tabpage.Size = new System.Drawing.Size(1584, 934);
            this.history_Tabpage.TabIndex = 1;
            this.history_Tabpage.Text = "تاريخ العمليات";
            this.history_Tabpage.UseVisualStyleBackColor = true;
            // 
            // History_Groupbox
            // 
            this.History_Groupbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.History_Groupbox.Controls.Add(this.History_SearchButton);
            this.History_Groupbox.Controls.Add(this.label24);
            this.History_Groupbox.Controls.Add(this.label23);
            this.History_Groupbox.Controls.Add(this.History_To_Datetimepicker);
            this.History_Groupbox.Controls.Add(this.History_From_Datetimepicker);
            this.History_Groupbox.Controls.Add(this.history_Objectlistview);
            this.History_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.History_Groupbox.Location = new System.Drawing.Point(51, 39);
            this.History_Groupbox.Name = "History_Groupbox";
            this.History_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.History_Groupbox.Size = new System.Drawing.Size(1503, 879);
            this.History_Groupbox.TabIndex = 10;
            this.History_Groupbox.TabStop = false;
            this.History_Groupbox.Text = "تاريخ العمليات";
            // 
            // History_SearchButton
            // 
            this.History_SearchButton.ForeColor = System.Drawing.Color.Black;
            this.History_SearchButton.Location = new System.Drawing.Point(17, 35);
            this.History_SearchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.History_SearchButton.Name = "History_SearchButton";
            this.History_SearchButton.Size = new System.Drawing.Size(146, 46);
            this.History_SearchButton.TabIndex = 18;
            this.History_SearchButton.Text = "بحث";
            this.History_SearchButton.UseVisualStyleBackColor = true;
            this.History_SearchButton.Click += new System.EventHandler(this.History_SearchButton_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("El Messiri", 12F);
            this.label24.Location = new System.Drawing.Point(555, 40);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 31);
            this.label24.TabIndex = 17;
            this.label24.Text = "إلى";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("El Messiri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(990, 40);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 31);
            this.label23.TabIndex = 16;
            this.label23.Text = "من";
            // 
            // History_To_Datetimepicker
            // 
            this.History_To_Datetimepicker.CalendarFont = new System.Drawing.Font("El Messiri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History_To_Datetimepicker.Font = new System.Drawing.Font("El Messiri", 12F);
            this.History_To_Datetimepicker.Location = new System.Drawing.Point(195, 36);
            this.History_To_Datetimepicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.History_To_Datetimepicker.Name = "History_To_Datetimepicker";
            this.History_To_Datetimepicker.Size = new System.Drawing.Size(355, 39);
            this.History_To_Datetimepicker.TabIndex = 15;
            this.History_To_Datetimepicker.Value = new System.DateTime(2025, 7, 2, 0, 0, 0, 0);
            // 
            // History_From_Datetimepicker
            // 
            this.History_From_Datetimepicker.CalendarFont = new System.Drawing.Font("El Messiri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History_From_Datetimepicker.Font = new System.Drawing.Font("El Messiri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History_From_Datetimepicker.Location = new System.Drawing.Point(630, 36);
            this.History_From_Datetimepicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.History_From_Datetimepicker.Name = "History_From_Datetimepicker";
            this.History_From_Datetimepicker.Size = new System.Drawing.Size(355, 39);
            this.History_From_Datetimepicker.TabIndex = 14;
            this.History_From_Datetimepicker.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
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
            this.history_Objectlistview.Cursor = System.Windows.Forms.Cursors.Default;
            this.history_Objectlistview.Font = new System.Drawing.Font("El Messiri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_Objectlistview.FullRowSelect = true;
            this.history_Objectlistview.HideSelection = false;
            this.history_Objectlistview.Location = new System.Drawing.Point(6, 95);
            this.history_Objectlistview.Name = "history_Objectlistview";
            this.history_Objectlistview.RightToLeftLayout = true;
            this.history_Objectlistview.SelectColumnsOnRightClick = false;
            this.history_Objectlistview.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.history_Objectlistview.ShowCommandMenuOnRightClick = true;
            this.history_Objectlistview.ShowItemCountOnGroups = true;
            this.history_Objectlistview.Size = new System.Drawing.Size(1491, 778);
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
            // TileButtons_Panel
            // 
            this.TileButtons_Panel.Controls.Add(this.History_Tilebutton);
            this.TileButtons_Panel.Controls.Add(this.SidePanel1);
            this.TileButtons_Panel.Controls.Add(this.Dashboard_Tilebutton);
            this.TileButtons_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TileButtons_Panel.Location = new System.Drawing.Point(0, 0);
            this.TileButtons_Panel.Name = "TileButtons_Panel";
            this.TileButtons_Panel.Size = new System.Drawing.Size(192, 950);
            this.TileButtons_Panel.TabIndex = 52;
            // 
            // History_Tilebutton
            // 
            this.History_Tilebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.History_Tilebutton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.History_Tilebutton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.History_Tilebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.History_Tilebutton.Font = new System.Drawing.Font("A Nasr", 30F);
            this.History_Tilebutton.ForeColor = System.Drawing.Color.Black;
            this.History_Tilebutton.Image = null;
            this.History_Tilebutton.ImagePosition = 0;
            this.History_Tilebutton.ImageZoom = 0;
            this.History_Tilebutton.LabelPosition = 195;
            this.History_Tilebutton.LabelText = "تاريخ العمليات";
            this.History_Tilebutton.Location = new System.Drawing.Point(2, 318);
            this.History_Tilebutton.Margin = new System.Windows.Forms.Padding(7);
            this.History_Tilebutton.Name = "History_Tilebutton";
            this.History_Tilebutton.Size = new System.Drawing.Size(189, 316);
            this.History_Tilebutton.TabIndex = 48;
            this.History_Tilebutton.Tag = this.history_Tabpage;
            this.History_Tilebutton.Click += new System.EventHandler(this.TileButton_Click);
            // 
            // SidePanel1
            // 
            this.SidePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.SidePanel1.Location = new System.Drawing.Point(0, 0);
            this.SidePanel1.Name = "SidePanel1";
            this.SidePanel1.Size = new System.Drawing.Size(12, 317);
            this.SidePanel1.TabIndex = 46;
            // 
            // Dashboard_Tilebutton
            // 
            this.Dashboard_Tilebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Dashboard_Tilebutton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Dashboard_Tilebutton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.Dashboard_Tilebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboard_Tilebutton.Font = new System.Drawing.Font("A Nasr", 26F);
            this.Dashboard_Tilebutton.ForeColor = System.Drawing.Color.Black;
            this.Dashboard_Tilebutton.Image = null;
            this.Dashboard_Tilebutton.ImagePosition = 0;
            this.Dashboard_Tilebutton.ImageZoom = 0;
            this.Dashboard_Tilebutton.LabelPosition = 240;
            this.Dashboard_Tilebutton.LabelText = "معلومات و اختصارات";
            this.Dashboard_Tilebutton.Location = new System.Drawing.Point(1, 1);
            this.Dashboard_Tilebutton.Margin = new System.Windows.Forms.Padding(6);
            this.Dashboard_Tilebutton.Name = "Dashboard_Tilebutton";
            this.Dashboard_Tilebutton.Size = new System.Drawing.Size(191, 317);
            this.Dashboard_Tilebutton.TabIndex = 45;
            this.Dashboard_Tilebutton.Tag = this.dashboard_Tabpage;
            this.Dashboard_Tilebutton.Click += new System.EventHandler(this.TileButton_Click);
            // 
            // UsrCtrl_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TileButtons_Panel);
            this.Controls.Add(this.Dashboard_Tabcontrol);
            this.Name = "UsrCtrl_Dashboard";
            this.Size = new System.Drawing.Size(1926, 950);
            this.DB_CS_Groupbox.ResumeLayout(false);
            this.Todos_TablelayoutPanel.ResumeLayout(false);
            this.Dashboard_Tabcontrol.ResumeLayout(false);
            this.dashboard_Tabpage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.history_Tabpage.ResumeLayout(false);
            this.History_Groupbox.ResumeLayout(false);
            this.History_Groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.history_Objectlistview)).EndInit();
            this.TileButtons_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox DB_CS_Groupbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private TransparentTabControl Dashboard_Tabcontrol;
        private TabPage dashboard_Tabpage;
        private TabPage history_Tabpage;
        private GroupBox History_Groupbox;
        private Button History_SearchButton;
        private Label label24;
        private Label label23;
        private DateTimePicker History_To_Datetimepicker;
        private DateTimePicker History_From_Datetimepicker;
        private BrightIdeasSoftware.ObjectListView history_Objectlistview;
        private BrightIdeasSoftware.OLVColumn index_Column;
        private BrightIdeasSoftware.OLVColumn table_Affected_column;
        private BrightIdeasSoftware.OLVColumn Date_Column;
        private BrightIdeasSoftware.OLVColumn operation_Column;
        private BrightIdeasSoftware.OLVColumn Extra_Column;
        private Panel TileButtons_Panel;
        private ns1.BunifuTileButton History_Tilebutton;
        private Panel SidePanel1;
        private ns1.BunifuTileButton Dashboard_Tilebutton;
        private TableLayoutPanel Todos_TablelayoutPanel;
        private Button DB_ShwTodo_Button;
        private Button DB_AddTodo_Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label TODOs_AverageDuration_Label;
        private Label TODOs_MonthDuration_Label;
        private Label TODOs_TotalDuration_Label;
        private Label TODOs_AverageCount_Label;
        private Label TODOs_MonthCount_Label;
        private Label TODOs_TotalCount_Label;
        private Label label11;
        private Label label8;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label FNC_AveragePaid_Label;
        private Label FNC_MonthPaid_Label;
        private Label FNC_TotalPaid_Label;
        private Label FNC_AverageCount_Label;
        private Label FNC_MonthCount_Label;
        private Label FNC_TotalCount_Label;
        private Label label13;
        private Label label14;
        private Button DB_ShwFnc_Button;
        private Button DB_AddFnc_Button;
        private Label label15;
        private Label label18;
        private Label label19;
        private Label label20;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label NOT_AverageLength_Label;
        private Label NOT_TotalLength_Label;
        private Label NOT_TotalCount_Label;
        private Button DB_ShwNot_Button;
        private Button DB_AddNot_Button;
        private Label label22;
        private Label label25;
        private Label label26;
    }
}
