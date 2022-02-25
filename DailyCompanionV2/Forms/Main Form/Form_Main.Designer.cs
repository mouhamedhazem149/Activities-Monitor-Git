namespace DailyCompanionV2
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Buttons_Panel = new System.Windows.Forms.Panel();
            this.Settings_Button = new System.Windows.Forms.Button();
            this.TabButtons_Panel = new System.Windows.Forms.Panel();
            this.RPRT_Button = new System.Windows.Forms.Button();
            this.NOTE_Button = new System.Windows.Forms.Button();
            this.FNC_Button = new System.Windows.Forms.Button();
            this.TODO_Button = new System.Windows.Forms.Button();
            this.Tabs_Button = new System.Windows.Forms.Button();
            this.Dashboard_Button = new System.Windows.Forms.Button();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.Header_Panel = new System.Windows.Forms.Panel();
            this.header_TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.CompanyName_Label = new System.Windows.Forms.Label();
            this.Shutdown_ImageButton = new ns1.BunifuImageButton();
            this.Minimize_ImageButton = new ns1.BunifuImageButton();
            this.Shortcut_ImageButton = new ns1.BunifuImageButton();
            this.Refresh_Button = new ns1.BunifuImageButton();
            this.ScreenShot_Button = new ns1.BunifuImageButton();
            this.Screenshot_Label = new System.Windows.Forms.Label();
            this.User_welcome_Label = new System.Windows.Forms.Label();
            this.User_Name_Label = new System.Windows.Forms.Label();
            this.notification_Panel = new System.Windows.Forms.Panel();
            this.Notification_Label = new System.Windows.Forms.Label();
            this.Notification_ImageButton = new ns1.BunifuImageButton();
            this.WebPage_ImageButton = new ns1.BunifuImageButton();
            this.UserInterfaces_Panel = new System.Windows.Forms.Panel();
            this.ActiveTabs_Tabcontrol = new XanderUI.XUIFlatTab();
            this.Main_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.Buttons_Panel.SuspendLayout();
            this.TabButtons_Panel.SuspendLayout();
            this.Header_Panel.SuspendLayout();
            this.header_TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shutdown_ImageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_ImageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shortcut_ImageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenShot_Button)).BeginInit();
            this.notification_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notification_ImageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebPage_ImageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Main_SplitContainer)).BeginInit();
            this.Main_SplitContainer.Panel1.SuspendLayout();
            this.Main_SplitContainer.Panel2.SuspendLayout();
            this.Main_SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Buttons_Panel
            // 
            this.Buttons_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Buttons_Panel.Controls.Add(this.Settings_Button);
            this.Buttons_Panel.Controls.Add(this.TabButtons_Panel);
            this.Buttons_Panel.Controls.Add(this.Tabs_Button);
            this.Buttons_Panel.Controls.Add(this.Dashboard_Button);
            this.Buttons_Panel.Controls.Add(this.xuiClock1);
            this.Buttons_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Buttons_Panel.Location = new System.Drawing.Point(0, 0);
            this.Buttons_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Buttons_Panel.Name = "Buttons_Panel";
            this.Buttons_Panel.Size = new System.Drawing.Size(235, 1080);
            this.Buttons_Panel.TabIndex = 0;
            // 
            // Settings_Button
            // 
            this.Settings_Button.BackColor = System.Drawing.Color.Transparent;
            this.Settings_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Settings_Button.FlatAppearance.BorderSize = 0;
            this.Settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Button.Font = new System.Drawing.Font("A Nasr", 18.2F);
            this.Settings_Button.ForeColor = System.Drawing.Color.Black;
            this.Settings_Button.Image = global::DailyCompanionV2.Properties.Resources.settings;
            this.Settings_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_Button.Location = new System.Drawing.Point(0, 970);
            this.Settings_Button.Name = "Settings_Button";
            this.Settings_Button.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.Settings_Button.Size = new System.Drawing.Size(235, 110);
            this.Settings_Button.TabIndex = 33;
            this.Settings_Button.Text = "الإعدادات";
            this.Settings_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings_Button.UseVisualStyleBackColor = false;
            this.Settings_Button.Click += new System.EventHandler(this.Settings_Button_Click);
            // 
            // TabButtons_Panel
            // 
            this.TabButtons_Panel.Controls.Add(this.RPRT_Button);
            this.TabButtons_Panel.Controls.Add(this.NOTE_Button);
            this.TabButtons_Panel.Controls.Add(this.FNC_Button);
            this.TabButtons_Panel.Controls.Add(this.TODO_Button);
            this.TabButtons_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabButtons_Panel.Location = new System.Drawing.Point(0, 376);
            this.TabButtons_Panel.Name = "TabButtons_Panel";
            this.TabButtons_Panel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.TabButtons_Panel.Size = new System.Drawing.Size(235, 361);
            this.TabButtons_Panel.TabIndex = 31;
            this.TabButtons_Panel.Visible = false;
            // 
            // RPRT_Button
            // 
            this.RPRT_Button.BackColor = System.Drawing.Color.Transparent;
            this.RPRT_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.RPRT_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RPRT_Button.Font = new System.Drawing.Font("A Nasr", 18.2F);
            this.RPRT_Button.Image = global::DailyCompanionV2.Properties.Resources.reports;
            this.RPRT_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RPRT_Button.Location = new System.Drawing.Point(0, 270);
            this.RPRT_Button.Name = "RPRT_Button";
            this.RPRT_Button.Padding = new System.Windows.Forms.Padding(4);
            this.RPRT_Button.Size = new System.Drawing.Size(225, 90);
            this.RPRT_Button.TabIndex = 30;
            this.RPRT_Button.Text = "تقارير";
            this.RPRT_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RPRT_Button.UseVisualStyleBackColor = false;
            this.RPRT_Button.Click += new System.EventHandler(this.Reports_Button_Click);
            // 
            // NOTE_Button
            // 
            this.NOTE_Button.BackColor = System.Drawing.Color.Transparent;
            this.NOTE_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.NOTE_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NOTE_Button.Font = new System.Drawing.Font("A Nasr", 18.2F);
            this.NOTE_Button.Image = global::DailyCompanionV2.Properties.Resources.notes;
            this.NOTE_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NOTE_Button.Location = new System.Drawing.Point(0, 180);
            this.NOTE_Button.Name = "NOTE_Button";
            this.NOTE_Button.Padding = new System.Windows.Forms.Padding(4);
            this.NOTE_Button.Size = new System.Drawing.Size(225, 90);
            this.NOTE_Button.TabIndex = 29;
            this.NOTE_Button.Text = "ملاحظات";
            this.NOTE_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NOTE_Button.UseVisualStyleBackColor = false;
            this.NOTE_Button.Click += new System.EventHandler(this.Notes_Button_Click);
            // 
            // FNC_Button
            // 
            this.FNC_Button.BackColor = System.Drawing.Color.Transparent;
            this.FNC_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.FNC_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FNC_Button.Font = new System.Drawing.Font("A Nasr", 18.2F);
            this.FNC_Button.Image = global::DailyCompanionV2.Properties.Resources.finances;
            this.FNC_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FNC_Button.Location = new System.Drawing.Point(0, 90);
            this.FNC_Button.Name = "FNC_Button";
            this.FNC_Button.Padding = new System.Windows.Forms.Padding(4);
            this.FNC_Button.Size = new System.Drawing.Size(225, 90);
            this.FNC_Button.TabIndex = 28;
            this.FNC_Button.Text = "عمليات مالية";
            this.FNC_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FNC_Button.UseVisualStyleBackColor = false;
            this.FNC_Button.Click += new System.EventHandler(this.Finances_Button_Click);
            // 
            // TODO_Button
            // 
            this.TODO_Button.BackColor = System.Drawing.Color.Transparent;
            this.TODO_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.TODO_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TODO_Button.Font = new System.Drawing.Font("A Nasr", 18.2F);
            this.TODO_Button.Image = global::DailyCompanionV2.Properties.Resources.todos;
            this.TODO_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TODO_Button.Location = new System.Drawing.Point(0, 0);
            this.TODO_Button.Name = "TODO_Button";
            this.TODO_Button.Padding = new System.Windows.Forms.Padding(4);
            this.TODO_Button.Size = new System.Drawing.Size(225, 90);
            this.TODO_Button.TabIndex = 27;
            this.TODO_Button.Text = "مهام";
            this.TODO_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TODO_Button.UseVisualStyleBackColor = false;
            this.TODO_Button.Click += new System.EventHandler(this.Todo_Button_Click);
            // 
            // Tabs_Button
            // 
            this.Tabs_Button.BackColor = System.Drawing.Color.Transparent;
            this.Tabs_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tabs_Button.FlatAppearance.BorderSize = 0;
            this.Tabs_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tabs_Button.Font = new System.Drawing.Font("A Nasr", 18.2F);
            this.Tabs_Button.ForeColor = System.Drawing.Color.Black;
            this.Tabs_Button.Image = global::DailyCompanionV2.Properties.Resources.addtab;
            this.Tabs_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tabs_Button.Location = new System.Drawing.Point(0, 266);
            this.Tabs_Button.Name = "Tabs_Button";
            this.Tabs_Button.Size = new System.Drawing.Size(235, 110);
            this.Tabs_Button.TabIndex = 30;
            this.Tabs_Button.Text = "إضافة تبويب";
            this.Tabs_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Tabs_Button.UseVisualStyleBackColor = false;
            this.Tabs_Button.Click += new System.EventHandler(this.Tabs_Button_Click);
            // 
            // Dashboard_Button
            // 
            this.Dashboard_Button.BackColor = System.Drawing.Color.Transparent;
            this.Dashboard_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard_Button.FlatAppearance.BorderSize = 0;
            this.Dashboard_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard_Button.Font = new System.Drawing.Font("A Nasr", 18.2F);
            this.Dashboard_Button.ForeColor = System.Drawing.Color.Black;
            this.Dashboard_Button.Image = global::DailyCompanionV2.Properties.Resources.dashboard;
            this.Dashboard_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard_Button.Location = new System.Drawing.Point(0, 156);
            this.Dashboard_Button.Name = "Dashboard_Button";
            this.Dashboard_Button.Size = new System.Drawing.Size(235, 110);
            this.Dashboard_Button.TabIndex = 32;
            this.Dashboard_Button.Text = "لوحة المعلومات";
            this.Dashboard_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Dashboard_Button.UseVisualStyleBackColor = false;
            this.Dashboard_Button.Click += new System.EventHandler(this.Dashboard_Button_Click);
            // 
            // xuiClock1
            // 
            this.xuiClock1.CircleThickness = 6;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.xuiClock1.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiClock1.HexagonColor = System.Drawing.Color.Transparent;
            this.xuiClock1.Location = new System.Drawing.Point(0, 0);
            this.xuiClock1.Margin = new System.Windows.Forms.Padding(2);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.ShowAmPm = true;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(235, 156);
            this.xuiClock1.TabIndex = 24;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // Header_Panel
            // 
            this.Header_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.Header_Panel.Controls.Add(this.header_TablePanel);
            this.Header_Panel.Controls.Add(this.WebPage_ImageButton);
            this.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Panel.Location = new System.Drawing.Point(0, 0);
            this.Header_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Header_Panel.Name = "Header_Panel";
            this.Header_Panel.Size = new System.Drawing.Size(1684, 139);
            this.Header_Panel.TabIndex = 1;
            // 
            // header_TablePanel
            // 
            this.header_TablePanel.ColumnCount = 50;
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.header_TablePanel.Controls.Add(this.CompanyName_Label, 0, 0);
            this.header_TablePanel.Controls.Add(this.Shutdown_ImageButton, 49, 0);
            this.header_TablePanel.Controls.Add(this.Minimize_ImageButton, 47, 0);
            this.header_TablePanel.Controls.Add(this.Shortcut_ImageButton, 44, 5);
            this.header_TablePanel.Controls.Add(this.Refresh_Button, 16, 0);
            this.header_TablePanel.Controls.Add(this.ScreenShot_Button, 18, 0);
            this.header_TablePanel.Controls.Add(this.Screenshot_Label, 16, 6);
            this.header_TablePanel.Controls.Add(this.User_welcome_Label, 26, 4);
            this.header_TablePanel.Controls.Add(this.User_Name_Label, 26, 6);
            this.header_TablePanel.Controls.Add(this.notification_Panel, 42, 5);
            this.header_TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.header_TablePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.header_TablePanel.Location = new System.Drawing.Point(0, 0);
            this.header_TablePanel.Name = "header_TablePanel";
            this.header_TablePanel.RowCount = 8;
            this.header_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.header_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.header_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.header_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.header_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.header_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.header_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.header_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.header_TablePanel.Size = new System.Drawing.Size(1684, 139);
            this.header_TablePanel.TabIndex = 32;
            // 
            // CompanyName_Label
            // 
            this.CompanyName_Label.BackColor = System.Drawing.Color.Transparent;
            this.header_TablePanel.SetColumnSpan(this.CompanyName_Label, 15);
            this.CompanyName_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyName_Label.Font = new System.Drawing.Font("Cairo", 40F, System.Drawing.FontStyle.Bold);
            this.CompanyName_Label.ForeColor = System.Drawing.Color.Navy;
            this.CompanyName_Label.Location = new System.Drawing.Point(1191, 0);
            this.CompanyName_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompanyName_Label.Name = "CompanyName_Label";
            this.header_TablePanel.SetRowSpan(this.CompanyName_Label, 8);
            this.CompanyName_Label.Size = new System.Drawing.Size(491, 139);
            this.CompanyName_Label.TabIndex = 29;
            this.CompanyName_Label.Text = "اسم الشركة";
            this.CompanyName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Shutdown_ImageButton
            // 
            this.Shutdown_ImageButton.BackColor = System.Drawing.Color.Transparent;
            this.Shutdown_ImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Shutdown_ImageButton.Image = ((System.Drawing.Image)(resources.GetObject("Shutdown_ImageButton.Image")));
            this.Shutdown_ImageButton.ImageActive = null;
            this.Shutdown_ImageButton.Location = new System.Drawing.Point(2, 2);
            this.Shutdown_ImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.Shutdown_ImageButton.Name = "Shutdown_ImageButton";
            this.header_TablePanel.SetRowSpan(this.Shutdown_ImageButton, 3);
            this.Shutdown_ImageButton.Size = new System.Drawing.Size(63, 47);
            this.Shutdown_ImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Shutdown_ImageButton.TabIndex = 0;
            this.Shutdown_ImageButton.TabStop = false;
            this.Shutdown_ImageButton.Zoom = 10;
            this.Shutdown_ImageButton.Click += new System.EventHandler(this.Shutdown_ImageButton_Click);
            // 
            // Minimize_ImageButton
            // 
            this.Minimize_ImageButton.BackColor = System.Drawing.Color.Transparent;
            this.header_TablePanel.SetColumnSpan(this.Minimize_ImageButton, 2);
            this.Minimize_ImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Minimize_ImageButton.Image = ((System.Drawing.Image)(resources.GetObject("Minimize_ImageButton.Image")));
            this.Minimize_ImageButton.ImageActive = null;
            this.Minimize_ImageButton.Location = new System.Drawing.Point(69, 2);
            this.Minimize_ImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.Minimize_ImageButton.Name = "Minimize_ImageButton";
            this.header_TablePanel.SetRowSpan(this.Minimize_ImageButton, 3);
            this.Minimize_ImageButton.Size = new System.Drawing.Size(62, 47);
            this.Minimize_ImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize_ImageButton.TabIndex = 30;
            this.Minimize_ImageButton.TabStop = false;
            this.Minimize_ImageButton.Zoom = 10;
            this.Minimize_ImageButton.Click += new System.EventHandler(this.Minimize_ImageButton_Click);
            // 
            // Shortcut_ImageButton
            // 
            this.Shortcut_ImageButton.BackColor = System.Drawing.Color.Transparent;
            this.header_TablePanel.SetColumnSpan(this.Shortcut_ImageButton, 2);
            this.Shortcut_ImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Shortcut_ImageButton.Image = global::DailyCompanionV2.Properties.Resources.shortcut;
            this.Shortcut_ImageButton.ImageActive = null;
            this.Shortcut_ImageButton.Location = new System.Drawing.Point(168, 87);
            this.Shortcut_ImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.Shortcut_ImageButton.Name = "Shortcut_ImageButton";
            this.header_TablePanel.SetRowSpan(this.Shortcut_ImageButton, 3);
            this.Shortcut_ImageButton.Size = new System.Drawing.Size(62, 50);
            this.Shortcut_ImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Shortcut_ImageButton.TabIndex = 31;
            this.Shortcut_ImageButton.TabStop = false;
            this.Shortcut_ImageButton.Zoom = 10;
            this.Shortcut_ImageButton.Click += new System.EventHandler(this.Shortcut_ImageButton_Click);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.BackColor = System.Drawing.Color.Transparent;
            this.header_TablePanel.SetColumnSpan(this.Refresh_Button, 2);
            this.Refresh_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Refresh_Button.Image = global::DailyCompanionV2.Properties.Resources.sync_icon;
            this.Refresh_Button.ImageActive = null;
            this.Refresh_Button.Location = new System.Drawing.Point(1092, 2);
            this.Refresh_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh_Button.Name = "Refresh_Button";
            this.header_TablePanel.SetRowSpan(this.Refresh_Button, 3);
            this.Refresh_Button.Size = new System.Drawing.Size(62, 47);
            this.Refresh_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Refresh_Button.TabIndex = 26;
            this.Refresh_Button.TabStop = false;
            this.Refresh_Button.Zoom = 10;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // ScreenShot_Button
            // 
            this.ScreenShot_Button.BackColor = System.Drawing.Color.Transparent;
            this.header_TablePanel.SetColumnSpan(this.ScreenShot_Button, 2);
            this.ScreenShot_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenShot_Button.Image = global::DailyCompanionV2.Properties.Resources.screenshot;
            this.ScreenShot_Button.ImageActive = null;
            this.ScreenShot_Button.Location = new System.Drawing.Point(1026, 2);
            this.ScreenShot_Button.Margin = new System.Windows.Forms.Padding(2);
            this.ScreenShot_Button.Name = "ScreenShot_Button";
            this.header_TablePanel.SetRowSpan(this.ScreenShot_Button, 3);
            this.ScreenShot_Button.Size = new System.Drawing.Size(62, 47);
            this.ScreenShot_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScreenShot_Button.TabIndex = 24;
            this.ScreenShot_Button.TabStop = false;
            this.ScreenShot_Button.Zoom = 10;
            this.ScreenShot_Button.Click += new System.EventHandler(this.ScreenShot_Button_Click);
            // 
            // Screenshot_Label
            // 
            this.Screenshot_Label.BackColor = System.Drawing.Color.Transparent;
            this.header_TablePanel.SetColumnSpan(this.Screenshot_Label, 10);
            this.Screenshot_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screenshot_Label.Font = new System.Drawing.Font("Alameen", 12.8F, System.Drawing.FontStyle.Bold);
            this.Screenshot_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Screenshot_Label.Location = new System.Drawing.Point(828, 102);
            this.Screenshot_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Screenshot_Label.Name = "Screenshot_Label";
            this.header_TablePanel.SetRowSpan(this.Screenshot_Label, 2);
            this.Screenshot_Label.Size = new System.Drawing.Size(326, 37);
            this.Screenshot_Label.TabIndex = 25;
            this.Screenshot_Label.Text = "تم حفظ لقطة الشاشة بنجاح";
            this.Screenshot_Label.Visible = false;
            // 
            // User_welcome_Label
            // 
            this.User_welcome_Label.BackColor = System.Drawing.Color.Transparent;
            this.header_TablePanel.SetColumnSpan(this.User_welcome_Label, 8);
            this.User_welcome_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_welcome_Label.Font = new System.Drawing.Font("Alameen", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.User_welcome_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.User_welcome_Label.Location = new System.Drawing.Point(564, 68);
            this.User_welcome_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.User_welcome_Label.Name = "User_welcome_Label";
            this.header_TablePanel.SetRowSpan(this.User_welcome_Label, 2);
            this.User_welcome_Label.Size = new System.Drawing.Size(260, 34);
            this.User_welcome_Label.TabIndex = 16;
            this.User_welcome_Label.Text = "مرحبا بك :)";
            // 
            // User_Name_Label
            // 
            this.User_Name_Label.BackColor = System.Drawing.Color.Transparent;
            this.header_TablePanel.SetColumnSpan(this.User_Name_Label, 15);
            this.User_Name_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_Name_Label.Font = new System.Drawing.Font("El Messiri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name_Label.Location = new System.Drawing.Point(333, 102);
            this.User_Name_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.User_Name_Label.Name = "User_Name_Label";
            this.header_TablePanel.SetRowSpan(this.User_Name_Label, 2);
            this.User_Name_Label.Size = new System.Drawing.Size(491, 37);
            this.User_Name_Label.TabIndex = 15;
            this.User_Name_Label.Text = "اسم المستخدم";
            // 
            // notification_Panel
            // 
            this.header_TablePanel.SetColumnSpan(this.notification_Panel, 2);
            this.notification_Panel.Controls.Add(this.Notification_Label);
            this.notification_Panel.Controls.Add(this.Notification_ImageButton);
            this.notification_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notification_Panel.Location = new System.Drawing.Point(235, 88);
            this.notification_Panel.Name = "notification_Panel";
            this.header_TablePanel.SetRowSpan(this.notification_Panel, 3);
            this.notification_Panel.Size = new System.Drawing.Size(60, 48);
            this.notification_Panel.TabIndex = 33;
            // 
            // Notification_Label
            // 
            this.Notification_Label.AutoSize = true;
            this.Notification_Label.BackColor = System.Drawing.Color.Transparent;
            this.Notification_Label.Font = new System.Drawing.Font("Alef", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification_Label.ForeColor = System.Drawing.Color.White;
            this.Notification_Label.Location = new System.Drawing.Point(0, -1);
            this.Notification_Label.Name = "Notification_Label";
            this.Notification_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Notification_Label.Size = new System.Drawing.Size(14, 18);
            this.Notification_Label.TabIndex = 33;
            this.Notification_Label.Text = "5";
            this.Notification_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Notification_ImageButton
            // 
            this.Notification_ImageButton.BackColor = System.Drawing.Color.Transparent;
            this.Notification_ImageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Notification_ImageButton.Image = global::DailyCompanionV2.Properties.Resources.notification;
            this.Notification_ImageButton.ImageActive = null;
            this.Notification_ImageButton.Location = new System.Drawing.Point(0, 0);
            this.Notification_ImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.Notification_ImageButton.Name = "Notification_ImageButton";
            this.Notification_ImageButton.Size = new System.Drawing.Size(60, 48);
            this.Notification_ImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Notification_ImageButton.TabIndex = 32;
            this.Notification_ImageButton.TabStop = false;
            this.Notification_ImageButton.Zoom = 10;
            this.Notification_ImageButton.Click += new System.EventHandler(this.Notification_ImageButton_Click);
            // 
            // WebPage_ImageButton
            // 
            this.WebPage_ImageButton.BackColor = System.Drawing.Color.Transparent;
            this.WebPage_ImageButton.Image = global::DailyCompanionV2.Properties.Resources.global;
            this.WebPage_ImageButton.ImageActive = null;
            this.WebPage_ImageButton.Location = new System.Drawing.Point(267, 33);
            this.WebPage_ImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.WebPage_ImageButton.Name = "WebPage_ImageButton";
            this.WebPage_ImageButton.Size = new System.Drawing.Size(71, 71);
            this.WebPage_ImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WebPage_ImageButton.TabIndex = 1;
            this.WebPage_ImageButton.TabStop = false;
            this.WebPage_ImageButton.Visible = false;
            this.WebPage_ImageButton.Zoom = 10;
            this.WebPage_ImageButton.Click += new System.EventHandler(this.FacebookLink_ImageButton_Click);
            // 
            // UserInterfaces_Panel
            // 
            this.UserInterfaces_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            this.UserInterfaces_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserInterfaces_Panel.ForeColor = System.Drawing.Color.Black;
            this.UserInterfaces_Panel.Location = new System.Drawing.Point(0, 139);
            this.UserInterfaces_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.UserInterfaces_Panel.Name = "UserInterfaces_Panel";
            this.UserInterfaces_Panel.Size = new System.Drawing.Size(1684, 941);
            this.UserInterfaces_Panel.TabIndex = 7;
            this.UserInterfaces_Panel.TabStop = true;
            // 
            // ActiveTabs_Tabcontrol
            // 
            this.ActiveTabs_Tabcontrol.ActiveHeaderColor = System.Drawing.Color.White;
            this.ActiveTabs_Tabcontrol.ActiveTextColor = System.Drawing.Color.Black;
            this.ActiveTabs_Tabcontrol.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ActiveTabs_Tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActiveTabs_Tabcontrol.Font = new System.Drawing.Font("Cairo Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ActiveTabs_Tabcontrol.HeaderBackgroundColor = System.Drawing.Color.White;
            this.ActiveTabs_Tabcontrol.InActiveHeaderColor = System.Drawing.Color.Silver;
            this.ActiveTabs_Tabcontrol.InActiveTextColor = System.Drawing.Color.DimGray;
            this.ActiveTabs_Tabcontrol.ItemSize = new System.Drawing.Size(240, 16);
            this.ActiveTabs_Tabcontrol.Location = new System.Drawing.Point(0, 139);
            this.ActiveTabs_Tabcontrol.Name = "ActiveTabs_Tabcontrol";
            this.ActiveTabs_Tabcontrol.OnlyTopLine = true;
            this.ActiveTabs_Tabcontrol.PageColor = System.Drawing.Color.LightGray;
            this.ActiveTabs_Tabcontrol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ActiveTabs_Tabcontrol.SelectedIndex = 0;
            this.ActiveTabs_Tabcontrol.Size = new System.Drawing.Size(1684, 941);
            this.ActiveTabs_Tabcontrol.TabIndex = 82;
            this.ActiveTabs_Tabcontrol.Visible = false;
            this.ActiveTabs_Tabcontrol.SelectedIndexChanged += new System.EventHandler(this.ActiveTabs_Tabcontrol_SelectedIndexChanged);
            this.ActiveTabs_Tabcontrol.DoubleClick += new System.EventHandler(this.ActiveTabs_Tabcontrol_DoubleClick);
            this.ActiveTabs_Tabcontrol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActiveTabs_Tabcontrol_KeyDown);
            // 
            // Main_SplitContainer
            // 
            this.Main_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.Main_SplitContainer.Name = "Main_SplitContainer";
            // 
            // Main_SplitContainer.Panel1
            // 
            this.Main_SplitContainer.Panel1.Controls.Add(this.Buttons_Panel);
            this.Main_SplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // Main_SplitContainer.Panel2
            // 
            this.Main_SplitContainer.Panel2.Controls.Add(this.ActiveTabs_Tabcontrol);
            this.Main_SplitContainer.Panel2.Controls.Add(this.UserInterfaces_Panel);
            this.Main_SplitContainer.Panel2.Controls.Add(this.Header_Panel);
            this.Main_SplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Main_SplitContainer.Size = new System.Drawing.Size(1920, 1080);
            this.Main_SplitContainer.SplitterDistance = 235;
            this.Main_SplitContainer.SplitterWidth = 1;
            this.Main_SplitContainer.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.Main_SplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Buttons_Panel.ResumeLayout(false);
            this.TabButtons_Panel.ResumeLayout(false);
            this.Header_Panel.ResumeLayout(false);
            this.header_TablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Shutdown_ImageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_ImageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shortcut_ImageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenShot_Button)).EndInit();
            this.notification_Panel.ResumeLayout(false);
            this.notification_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Notification_ImageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebPage_ImageButton)).EndInit();
            this.Main_SplitContainer.Panel1.ResumeLayout(false);
            this.Main_SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_SplitContainer)).EndInit();
            this.Main_SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel Buttons_Panel;
        private System.Windows.Forms.Panel Header_Panel;
        private ns1.BunifuImageButton WebPage_ImageButton;
        private ns1.BunifuImageButton Shutdown_ImageButton;
        private System.Windows.Forms.Label User_welcome_Label;
        private System.Windows.Forms.Label User_Name_Label;
        private System.Windows.Forms.Panel UserInterfaces_Panel;
        private XanderUI.XUIClock xuiClock1;
        private ns1.BunifuImageButton ScreenShot_Button;
        private System.Windows.Forms.Label Screenshot_Label;
        private ns1.BunifuImageButton Refresh_Button;
        private System.Windows.Forms.Label CompanyName_Label;
        private ns1.BunifuImageButton Minimize_ImageButton;
        private XanderUI.XUIFlatTab ActiveTabs_Tabcontrol;
        private ns1.BunifuImageButton Shortcut_ImageButton;
        private System.Windows.Forms.SplitContainer Main_SplitContainer;
        private System.Windows.Forms.TableLayoutPanel header_TablePanel;
        private ns1.BunifuImageButton Notification_ImageButton;
        private System.Windows.Forms.Panel notification_Panel;
        private System.Windows.Forms.Label Notification_Label;
        private System.Windows.Forms.Panel TabButtons_Panel;
        private System.Windows.Forms.Button RPRT_Button;
        private System.Windows.Forms.Button NOTE_Button;
        private System.Windows.Forms.Button FNC_Button;
        private System.Windows.Forms.Button TODO_Button;
        private System.Windows.Forms.Button Tabs_Button;
        private System.Windows.Forms.Button Settings_Button;
        private System.Windows.Forms.Button Dashboard_Button;
    }
}
