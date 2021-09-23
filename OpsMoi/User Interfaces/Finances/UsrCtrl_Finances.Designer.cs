using ModdedControls;
using System.Drawing;
using System.Windows.Forms;

namespace OpsMoi
{
    partial class UsrCtrl_Finances
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
            this.cityColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.SidePanel1 = new System.Windows.Forms.Panel();
            this.Req_MTN_TileButton = new ns1.BunifuTileButton();
            this.Req_Tabpage = new System.Windows.Forms.TabPage();
            this.SearchMod_MTN_TileButton = new ns1.BunifuTileButton();
            this.Search_Modify_Tabpage = new System.Windows.Forms.TabPage();
            this.FNCManager_TileButton = new ns1.BunifuTileButton();
            this.FNCmanage_Tabpage = new System.Windows.Forms.TabPage();
            this.AddFinance_Groupbox = new System.Windows.Forms.GroupBox();
            this.FNC_paid_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_paid_Textbox = new ModdedControls.ModdedTextBox();
            this.FNC_done_date_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.FNC_done_date_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_due_date_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.FNC_notes_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_due_date_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_value_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_category_Adj_Label = new System.Windows.Forms.Label();
            this.MTN_name_Adj_Label = new System.Windows.Forms.Label();
            this.Modify_FNC_Button = new System.Windows.Forms.Button();
            this.Del_FNC_Button = new System.Windows.Forms.Button();
            this.FNC_id_Textbox = new ModdedControls.ModdedTextBox();
            this.id_Label = new System.Windows.Forms.Label();
            this.FNC_type_Combobox = new System.Windows.Forms.ComboBox();
            this.FNC_due_Textbox = new ModdedControls.ModdedTextBox();
            this.FNC_Label = new System.Windows.Forms.Label();
            this.Type_Label = new System.Windows.Forms.Label();
            this.Add_FNC_Button = new System.Windows.Forms.Button();
            this.FNC_notes_Textbox = new ModdedControls.ModdedTextBox();
            this.FNC_category_Textbox = new ModdedControls.ModdedTextBox();
            this.FNC_relatedentity_Textbox = new ModdedControls.ModdedTextBox();
            this.TileButtons_Panel = new System.Windows.Forms.Panel();
            this.FNC_TabControl = new TransparentTabControl();
            this.FNCmanage_Tabpage.SuspendLayout();
            this.AddFinance_Groupbox.SuspendLayout();
            this.TileButtons_Panel.SuspendLayout();
            this.FNC_TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityColumn
            // 
            this.cityColumn.AspectName = "city";
            this.cityColumn.DisplayIndex = 7;
            this.cityColumn.Text = "المدينة";
            // 
            // SidePanel1
            // 
            this.SidePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.SidePanel1.Location = new System.Drawing.Point(0, 0);
            this.SidePanel1.Name = "SidePanel1";
            this.SidePanel1.Size = new System.Drawing.Size(12, 317);
            this.SidePanel1.TabIndex = 46;
            // 
            // Req_MTN_TileButton
            // 
            this.Req_MTN_TileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Req_MTN_TileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Req_MTN_TileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.Req_MTN_TileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Req_MTN_TileButton.Font = new System.Drawing.Font("A Nasr", 26.8F);
            this.Req_MTN_TileButton.ForeColor = System.Drawing.Color.Black;
            this.Req_MTN_TileButton.Image = null;
            this.Req_MTN_TileButton.ImagePosition = 0;
            this.Req_MTN_TileButton.ImageZoom = 0;
            this.Req_MTN_TileButton.LabelPosition = 216;
            this.Req_MTN_TileButton.LabelText = "أوامر مطلوبة";
            this.Req_MTN_TileButton.Location = new System.Drawing.Point(1, 634);
            this.Req_MTN_TileButton.Margin = new System.Windows.Forms.Padding(56, 65, 56, 65);
            this.Req_MTN_TileButton.Name = "Req_MTN_TileButton";
            this.Req_MTN_TileButton.Size = new System.Drawing.Size(191, 316);
            this.Req_MTN_TileButton.TabIndex = 47;
            this.Req_MTN_TileButton.Tag = this.Req_Tabpage;
            this.Req_MTN_TileButton.Visible = false;
            this.Req_MTN_TileButton.Click += new System.EventHandler(this.TileButton_Click);
            // 
            // Req_Tabpage
            // 
            this.Req_Tabpage.BackColor = System.Drawing.Color.Transparent;
            this.Req_Tabpage.Location = new System.Drawing.Point(5, 4);
            this.Req_Tabpage.Name = "Req_Tabpage";
            this.Req_Tabpage.Size = new System.Drawing.Size(1601, 899);
            this.Req_Tabpage.TabIndex = 0;
            this.Req_Tabpage.Text = "صيانات مطلوبة";
            // 
            // SearchMod_MTN_TileButton
            // 
            this.SearchMod_MTN_TileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchMod_MTN_TileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchMod_MTN_TileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.SearchMod_MTN_TileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchMod_MTN_TileButton.Font = new System.Drawing.Font("A Nasr", 30F);
            this.SearchMod_MTN_TileButton.ForeColor = System.Drawing.Color.Black;
            this.SearchMod_MTN_TileButton.Image = null;
            this.SearchMod_MTN_TileButton.ImagePosition = 0;
            this.SearchMod_MTN_TileButton.ImageZoom = 0;
            this.SearchMod_MTN_TileButton.LabelPosition = 195;
            this.SearchMod_MTN_TileButton.LabelText = "بحث";
            this.SearchMod_MTN_TileButton.Location = new System.Drawing.Point(2, 318);
            this.SearchMod_MTN_TileButton.Margin = new System.Windows.Forms.Padding(7);
            this.SearchMod_MTN_TileButton.Name = "SearchMod_MTN_TileButton";
            this.SearchMod_MTN_TileButton.Size = new System.Drawing.Size(189, 316);
            this.SearchMod_MTN_TileButton.TabIndex = 48;
            this.SearchMod_MTN_TileButton.Tag = this.Search_Modify_Tabpage;
            this.SearchMod_MTN_TileButton.Visible = false;
            this.SearchMod_MTN_TileButton.Click += new System.EventHandler(this.TileButton_Click);
            // 
            // Search_Modify_Tabpage
            // 
            this.Search_Modify_Tabpage.Location = new System.Drawing.Point(5, 4);
            this.Search_Modify_Tabpage.Name = "Search_Modify_Tabpage";
            this.Search_Modify_Tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.Search_Modify_Tabpage.Size = new System.Drawing.Size(1601, 899);
            this.Search_Modify_Tabpage.TabIndex = 1;
            this.Search_Modify_Tabpage.Text = "بحث / تعديل";
            this.Search_Modify_Tabpage.UseVisualStyleBackColor = true;
            // 
            // FNCManager_TileButton
            // 
            this.FNCManager_TileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.FNCManager_TileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.FNCManager_TileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.FNCManager_TileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FNCManager_TileButton.Font = new System.Drawing.Font("A Nasr", 20F);
            this.FNCManager_TileButton.ForeColor = System.Drawing.Color.Black;
            this.FNCManager_TileButton.Image = null;
            this.FNCManager_TileButton.ImagePosition = 0;
            this.FNCManager_TileButton.ImageZoom = 0;
            this.FNCManager_TileButton.LabelPosition = 185;
            this.FNCManager_TileButton.LabelText = "إدارة العمليات المالية";
            this.FNCManager_TileButton.Location = new System.Drawing.Point(1, 1);
            this.FNCManager_TileButton.Margin = new System.Windows.Forms.Padding(6);
            this.FNCManager_TileButton.Name = "FNCManager_TileButton";
            this.FNCManager_TileButton.Size = new System.Drawing.Size(191, 317);
            this.FNCManager_TileButton.TabIndex = 45;
            this.FNCManager_TileButton.Tag = this.FNCmanage_Tabpage;
            this.FNCManager_TileButton.Click += new System.EventHandler(this.TileButton_Click);
            // 
            // FNCmanage_Tabpage
            // 
            this.FNCmanage_Tabpage.Controls.Add(this.AddFinance_Groupbox);
            this.FNCmanage_Tabpage.Location = new System.Drawing.Point(5, 4);
            this.FNCmanage_Tabpage.Name = "FNCmanage_Tabpage";
            this.FNCmanage_Tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.FNCmanage_Tabpage.Size = new System.Drawing.Size(1601, 899);
            this.FNCmanage_Tabpage.TabIndex = 0;
            this.FNCmanage_Tabpage.Text = "إضافة";
            this.FNCmanage_Tabpage.UseVisualStyleBackColor = true;
            // 
            // AddFinance_Groupbox
            // 
            this.AddFinance_Groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFinance_Groupbox.Controls.Add(this.FNC_paid_Adj_Label);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_paid_Textbox);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_done_date_Datetimepicker);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_done_date_Adj_Label);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_due_date_Datetimepicker);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_notes_Adj_Label);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_due_date_Adj_Label);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_value_Adj_Label);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_category_Adj_Label);
            this.AddFinance_Groupbox.Controls.Add(this.MTN_name_Adj_Label);
            this.AddFinance_Groupbox.Controls.Add(this.Modify_FNC_Button);
            this.AddFinance_Groupbox.Controls.Add(this.Del_FNC_Button);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_id_Textbox);
            this.AddFinance_Groupbox.Controls.Add(this.id_Label);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_type_Combobox);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_due_Textbox);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_Label);
            this.AddFinance_Groupbox.Controls.Add(this.Type_Label);
            this.AddFinance_Groupbox.Controls.Add(this.Add_FNC_Button);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_notes_Textbox);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_category_Textbox);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_relatedentity_Textbox);
            this.AddFinance_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFinance_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.AddFinance_Groupbox.Location = new System.Drawing.Point(6, 0);
            this.AddFinance_Groupbox.Name = "AddFinance_Groupbox";
            this.AddFinance_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddFinance_Groupbox.Size = new System.Drawing.Size(1577, 893);
            this.AddFinance_Groupbox.TabIndex = 0;
            this.AddFinance_Groupbox.TabStop = false;
            this.AddFinance_Groupbox.Tag = this.Add_FNC_Button;
            this.AddFinance_Groupbox.Text = "إضافة عملية مالية";
            this.AddFinance_Groupbox.ForeColorChanged += new System.EventHandler(this.AddFNC_Groupbox_ForeColorChanged);
            // 
            // FNC_paid_Adj_Label
            // 
            this.FNC_paid_Adj_Label.AutoSize = true;
            this.FNC_paid_Adj_Label.Font = new System.Drawing.Font("A Nasr", 14F);
            this.FNC_paid_Adj_Label.Location = new System.Drawing.Point(1445, 215);
            this.FNC_paid_Adj_Label.Name = "FNC_paid_Adj_Label";
            this.FNC_paid_Adj_Label.Size = new System.Drawing.Size(110, 31);
            this.FNC_paid_Adj_Label.TabIndex = 71;
            this.FNC_paid_Adj_Label.Text = "المبلغ المدفوع";
            // 
            // FNC_paid_Textbox
            // 
            this.FNC_paid_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FNC_paid_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FNC_paid_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.FNC_paid_Textbox.IsPasswordTextbox = false;
            this.FNC_paid_Textbox.IsPlaceholder = true;
            this.FNC_paid_Textbox.Location = new System.Drawing.Point(541, 210);
            this.FNC_paid_Textbox.Name = "FNC_paid_Textbox";
            this.FNC_paid_Textbox.Placeholder = "المبلغ المدفوع";
            this.FNC_paid_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_paid_Textbox.placeholderFont = null;
            this.FNC_paid_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FNC_paid_Textbox.SelectedItem = null;
            this.FNC_paid_Textbox.Size = new System.Drawing.Size(891, 38);
            this.FNC_paid_Textbox.TabIndex = 4;
            this.FNC_paid_Textbox.Tag = "";
            this.FNC_paid_Textbox.Text = "المبلغ المدفوع";
            this.FNC_paid_Textbox.Values = null;
            this.FNC_paid_Textbox.Visible_Password_Button = false;
            this.FNC_paid_Textbox.TextChanged += new System.EventHandler(this.FNC_value_Textbox_TextChanged);
            // 
            // FNC_done_date_Datetimepicker
            // 
            this.FNC_done_date_Datetimepicker.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F);
            this.FNC_done_date_Datetimepicker.Checked = false;
            this.FNC_done_date_Datetimepicker.CustomFormat = "dddd, dd-MMMM-yyyy -- hh:mm tt";
            this.FNC_done_date_Datetimepicker.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.FNC_done_date_Datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FNC_done_date_Datetimepicker.Location = new System.Drawing.Point(821, 365);
            this.FNC_done_date_Datetimepicker.Name = "FNC_done_date_Datetimepicker";
            this.FNC_done_date_Datetimepicker.ShowCheckBox = true;
            this.FNC_done_date_Datetimepicker.Size = new System.Drawing.Size(548, 34);
            this.FNC_done_date_Datetimepicker.TabIndex = 8;
            // 
            // FNC_done_date_Adj_Label
            // 
            this.FNC_done_date_Adj_Label.AutoSize = true;
            this.FNC_done_date_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.FNC_done_date_Adj_Label.Location = new System.Drawing.Point(1428, 367);
            this.FNC_done_date_Adj_Label.Name = "FNC_done_date_Adj_Label";
            this.FNC_done_date_Adj_Label.Size = new System.Drawing.Size(139, 33);
            this.FNC_done_date_Adj_Label.TabIndex = 68;
            this.FNC_done_date_Adj_Label.Text = "تاريخ الدفع الفعلي";
            // 
            // FNC_due_date_Datetimepicker
            // 
            this.FNC_due_date_Datetimepicker.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F);
            this.FNC_due_date_Datetimepicker.CustomFormat = "dddd, dd-MMMM-yyyy -- hh:mm tt";
            this.FNC_due_date_Datetimepicker.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.FNC_due_date_Datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FNC_due_date_Datetimepicker.Location = new System.Drawing.Point(871, 309);
            this.FNC_due_date_Datetimepicker.Name = "FNC_due_date_Datetimepicker";
            this.FNC_due_date_Datetimepicker.Size = new System.Drawing.Size(498, 34);
            this.FNC_due_date_Datetimepicker.TabIndex = 6;
            // 
            // FNC_notes_Adj_Label
            // 
            this.FNC_notes_Adj_Label.AutoSize = true;
            this.FNC_notes_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.FNC_notes_Adj_Label.Location = new System.Drawing.Point(1426, 439);
            this.FNC_notes_Adj_Label.Name = "FNC_notes_Adj_Label";
            this.FNC_notes_Adj_Label.Size = new System.Drawing.Size(88, 33);
            this.FNC_notes_Adj_Label.TabIndex = 65;
            this.FNC_notes_Adj_Label.Text = "الملاحظات";
            // 
            // FNC_due_date_Adj_Label
            // 
            this.FNC_due_date_Adj_Label.AutoSize = true;
            this.FNC_due_date_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.FNC_due_date_Adj_Label.Location = new System.Drawing.Point(1445, 311);
            this.FNC_due_date_Adj_Label.Name = "FNC_due_date_Adj_Label";
            this.FNC_due_date_Adj_Label.Size = new System.Drawing.Size(121, 33);
            this.FNC_due_date_Adj_Label.TabIndex = 63;
            this.FNC_due_date_Adj_Label.Text = "تاريخ الاستحقاق";
            // 
            // FNC_value_Adj_Label
            // 
            this.FNC_value_Adj_Label.AutoSize = true;
            this.FNC_value_Adj_Label.Font = new System.Drawing.Font("A Nasr", 14F);
            this.FNC_value_Adj_Label.Location = new System.Drawing.Point(1441, 266);
            this.FNC_value_Adj_Label.Name = "FNC_value_Adj_Label";
            this.FNC_value_Adj_Label.Size = new System.Drawing.Size(118, 31);
            this.FNC_value_Adj_Label.TabIndex = 62;
            this.FNC_value_Adj_Label.Text = "المبلغ المستحق";
            // 
            // FNC_category_Adj_Label
            // 
            this.FNC_category_Adj_Label.AutoSize = true;
            this.FNC_category_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.FNC_category_Adj_Label.Location = new System.Drawing.Point(1471, 162);
            this.FNC_category_Adj_Label.Name = "FNC_category_Adj_Label";
            this.FNC_category_Adj_Label.Size = new System.Drawing.Size(77, 33);
            this.FNC_category_Adj_Label.TabIndex = 61;
            this.FNC_category_Adj_Label.Text = "التصنيف";
            // 
            // MTN_name_Adj_Label
            // 
            this.MTN_name_Adj_Label.AutoSize = true;
            this.MTN_name_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.MTN_name_Adj_Label.Location = new System.Drawing.Point(1460, 51);
            this.MTN_name_Adj_Label.Name = "MTN_name_Adj_Label";
            this.MTN_name_Adj_Label.Size = new System.Drawing.Size(105, 27);
            this.MTN_name_Adj_Label.TabIndex = 60;
            this.MTN_name_Adj_Label.Text = "الجهة ذات الصلة";
            // 
            // Modify_FNC_Button
            // 
            this.Modify_FNC_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Modify_FNC_Button.FlatAppearance.BorderSize = 0;
            this.Modify_FNC_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modify_FNC_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify_FNC_Button.ForeColor = System.Drawing.Color.Black;
            this.Modify_FNC_Button.Location = new System.Drawing.Point(781, 817);
            this.Modify_FNC_Button.Name = "Modify_FNC_Button";
            this.Modify_FNC_Button.Size = new System.Drawing.Size(259, 53);
            this.Modify_FNC_Button.TabIndex = 55;
            this.Modify_FNC_Button.Text = "تعديل عملية مالية";
            this.Modify_FNC_Button.UseVisualStyleBackColor = false;
            this.Modify_FNC_Button.Click += new System.EventHandler(this.FNC_Button_Click);
            // 
            // Del_FNC_Button
            // 
            this.Del_FNC_Button.BackColor = System.Drawing.Color.DarkRed;
            this.Del_FNC_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_FNC_Button.Font = new System.Drawing.Font("El Messiri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_FNC_Button.ForeColor = System.Drawing.Color.Black;
            this.Del_FNC_Button.Location = new System.Drawing.Point(411, 824);
            this.Del_FNC_Button.Name = "Del_FNC_Button";
            this.Del_FNC_Button.Size = new System.Drawing.Size(221, 38);
            this.Del_FNC_Button.TabIndex = 54;
            this.Del_FNC_Button.Text = "حذف عملية مالية";
            this.Del_FNC_Button.UseVisualStyleBackColor = false;
            this.Del_FNC_Button.Click += new System.EventHandler(this.FNC_Button_Click);
            // 
            // FNC_id_Textbox
            // 
            this.FNC_id_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FNC_id_Textbox.Enabled = false;
            this.FNC_id_Textbox.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.FNC_id_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.FNC_id_Textbox.IsPasswordTextbox = false;
            this.FNC_id_Textbox.IsPlaceholder = true;
            this.FNC_id_Textbox.Location = new System.Drawing.Point(160, 51);
            this.FNC_id_Textbox.Name = "FNC_id_Textbox";
            this.FNC_id_Textbox.Placeholder = "كود العملية (أدخل أرقام فقط)[في حالة التعديل او الحذف فقط]";
            this.FNC_id_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_id_Textbox.placeholderFont = null;
            this.FNC_id_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FNC_id_Textbox.SelectedItem = null;
            this.FNC_id_Textbox.Size = new System.Drawing.Size(339, 27);
            this.FNC_id_Textbox.TabIndex = 53;
            this.FNC_id_Textbox.Tag = "";
            this.FNC_id_Textbox.Text = "كود العملية (أدخل أرقام فقط)[في حالة التعديل او الحذف فقط]";
            this.FNC_id_Textbox.Values = null;
            this.FNC_id_Textbox.Visible_Password_Button = false;
            this.FNC_id_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.FNC_id_Textbox_SelectedItemChanged);
            this.FNC_id_Textbox.TextChanged += new System.EventHandler(this.id_Textbox_TextChanged);
            // 
            // id_Label
            // 
            this.id_Label.AutoSize = true;
            this.id_Label.Font = new System.Drawing.Font("El Messiri", 10.8F);
            this.id_Label.Location = new System.Drawing.Point(6, 53);
            this.id_Label.Name = "id_Label";
            this.id_Label.Size = new System.Drawing.Size(137, 29);
            this.id_Label.TabIndex = 52;
            this.id_Label.Text = "أدخل أرقام فقط";
            this.id_Label.Visible = false;
            // 
            // FNC_type_Combobox
            // 
            this.FNC_type_Combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.FNC_type_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FNC_type_Combobox.Font = new System.Drawing.Font("El Messiri", 15F);
            this.FNC_type_Combobox.FormattingEnabled = true;
            this.FNC_type_Combobox.Location = new System.Drawing.Point(871, 97);
            this.FNC_type_Combobox.Name = "FNC_type_Combobox";
            this.FNC_type_Combobox.Size = new System.Drawing.Size(549, 47);
            this.FNC_type_Combobox.TabIndex = 2;
            // 
            // FNC_due_Textbox
            // 
            this.FNC_due_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FNC_due_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FNC_due_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.FNC_due_Textbox.IsPasswordTextbox = false;
            this.FNC_due_Textbox.IsPlaceholder = true;
            this.FNC_due_Textbox.Location = new System.Drawing.Point(541, 261);
            this.FNC_due_Textbox.Name = "FNC_due_Textbox";
            this.FNC_due_Textbox.Placeholder = "القيمة المستحقة";
            this.FNC_due_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_due_Textbox.placeholderFont = null;
            this.FNC_due_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FNC_due_Textbox.SelectedItem = null;
            this.FNC_due_Textbox.Size = new System.Drawing.Size(891, 38);
            this.FNC_due_Textbox.TabIndex = 5;
            this.FNC_due_Textbox.Tag = "";
            this.FNC_due_Textbox.Text = "القيمة المستحقة";
            this.FNC_due_Textbox.Values = null;
            this.FNC_due_Textbox.Visible_Password_Button = false;
            this.FNC_due_Textbox.TextChanged += new System.EventHandler(this.FNC_value_Textbox_TextChanged);
            // 
            // FNC_Label
            // 
            this.FNC_Label.Font = new System.Drawing.Font("El Messiri", 11.8F);
            this.FNC_Label.Location = new System.Drawing.Point(31, 718);
            this.FNC_Label.Name = "FNC_Label";
            this.FNC_Label.Size = new System.Drawing.Size(1473, 78);
            this.FNC_Label.TabIndex = 41;
            this.FNC_Label.Text = "اختر نوع الصيانة";
            this.FNC_Label.Visible = false;
            // 
            // Type_Label
            // 
            this.Type_Label.AutoSize = true;
            this.Type_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.Type_Label.Location = new System.Drawing.Point(1426, 106);
            this.Type_Label.Name = "Type_Label";
            this.Type_Label.Size = new System.Drawing.Size(140, 33);
            this.Type_Label.TabIndex = 37;
            this.Type_Label.Text = "نوع العملية المالية";
            // 
            // Add_FNC_Button
            // 
            this.Add_FNC_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Add_FNC_Button.FlatAppearance.BorderSize = 0;
            this.Add_FNC_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_FNC_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_FNC_Button.ForeColor = System.Drawing.Color.Black;
            this.Add_FNC_Button.Location = new System.Drawing.Point(25, 817);
            this.Add_FNC_Button.Name = "Add_FNC_Button";
            this.Add_FNC_Button.Size = new System.Drawing.Size(259, 53);
            this.Add_FNC_Button.TabIndex = 35;
            this.Add_FNC_Button.Text = "إضافة عملية مالية";
            this.Add_FNC_Button.UseVisualStyleBackColor = false;
            this.Add_FNC_Button.Click += new System.EventHandler(this.FNC_Button_Click);
            // 
            // FNC_notes_Textbox
            // 
            this.FNC_notes_Textbox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNC_notes_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.FNC_notes_Textbox.IsPasswordTextbox = false;
            this.FNC_notes_Textbox.IsPlaceholder = true;
            this.FNC_notes_Textbox.Location = new System.Drawing.Point(25, 475);
            this.FNC_notes_Textbox.Multiline = true;
            this.FNC_notes_Textbox.Name = "FNC_notes_Textbox";
            this.FNC_notes_Textbox.Placeholder = "الملاحظات";
            this.FNC_notes_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_notes_Textbox.placeholderFont = null;
            this.FNC_notes_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FNC_notes_Textbox.SelectedItem = null;
            this.FNC_notes_Textbox.Size = new System.Drawing.Size(1488, 237);
            this.FNC_notes_Textbox.TabIndex = 7;
            this.FNC_notes_Textbox.Tag = "";
            this.FNC_notes_Textbox.Text = "لا يوجد ملاحظات";
            this.FNC_notes_Textbox.Values = null;
            this.FNC_notes_Textbox.Visible_Password_Button = false;
            // 
            // FNC_category_Textbox
            // 
            this.FNC_category_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FNC_category_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FNC_category_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.FNC_category_Textbox.IsPasswordTextbox = false;
            this.FNC_category_Textbox.IsPlaceholder = true;
            this.FNC_category_Textbox.Location = new System.Drawing.Point(541, 159);
            this.FNC_category_Textbox.Name = "FNC_category_Textbox";
            this.FNC_category_Textbox.Placeholder = "التصنيف";
            this.FNC_category_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_category_Textbox.placeholderFont = null;
            this.FNC_category_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FNC_category_Textbox.SelectedItem = null;
            this.FNC_category_Textbox.Size = new System.Drawing.Size(891, 38);
            this.FNC_category_Textbox.TabIndex = 3;
            this.FNC_category_Textbox.Tag = "";
            this.FNC_category_Textbox.Text = "التصنيف";
            this.FNC_category_Textbox.Values = null;
            this.FNC_category_Textbox.Visible_Password_Button = false;
            // 
            // FNC_relatedentity_Textbox
            // 
            this.FNC_relatedentity_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FNC_relatedentity_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FNC_relatedentity_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.FNC_relatedentity_Textbox.IsPasswordTextbox = false;
            this.FNC_relatedentity_Textbox.IsPlaceholder = true;
            this.FNC_relatedentity_Textbox.Location = new System.Drawing.Point(541, 45);
            this.FNC_relatedentity_Textbox.Name = "FNC_relatedentity_Textbox";
            this.FNC_relatedentity_Textbox.Placeholder = "الجهة ذات الصلة";
            this.FNC_relatedentity_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_relatedentity_Textbox.placeholderFont = null;
            this.FNC_relatedentity_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FNC_relatedentity_Textbox.SelectedItem = null;
            this.FNC_relatedentity_Textbox.Size = new System.Drawing.Size(891, 38);
            this.FNC_relatedentity_Textbox.TabIndex = 1;
            this.FNC_relatedentity_Textbox.Tag = "";
            this.FNC_relatedentity_Textbox.Text = "الجهة ذات الصلة";
            this.FNC_relatedentity_Textbox.Values = null;
            this.FNC_relatedentity_Textbox.Visible_Password_Button = false;
            // 
            // TileButtons_Panel
            // 
            this.TileButtons_Panel.Controls.Add(this.SearchMod_MTN_TileButton);
            this.TileButtons_Panel.Controls.Add(this.Req_MTN_TileButton);
            this.TileButtons_Panel.Controls.Add(this.SidePanel1);
            this.TileButtons_Panel.Controls.Add(this.FNCManager_TileButton);
            this.TileButtons_Panel.Location = new System.Drawing.Point(0, 0);
            this.TileButtons_Panel.Name = "TileButtons_Panel";
            this.TileButtons_Panel.Size = new System.Drawing.Size(192, 950);
            this.TileButtons_Panel.TabIndex = 51;
            // 
            // FNC_TabControl
            // 
            this.FNC_TabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.FNC_TabControl.Controls.Add(this.FNCmanage_Tabpage);
            this.FNC_TabControl.Controls.Add(this.Search_Modify_Tabpage);
            this.FNC_TabControl.Controls.Add(this.Req_Tabpage);
            this.FNC_TabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.FNC_TabControl.Location = new System.Drawing.Point(193, 0);
            this.FNC_TabControl.Multiline = true;
            this.FNC_TabControl.Name = "FNC_TabControl";
            this.FNC_TabControl.SelectedIndex = 0;
            this.FNC_TabControl.Size = new System.Drawing.Size(1610, 907);
            this.FNC_TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.FNC_TabControl.TabIndex = 44;
            // 
            // UsrCtrl_Finances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TileButtons_Panel);
            this.Controls.Add(this.FNC_TabControl);
            this.Name = "UsrCtrl_Finances";
            this.Size = new System.Drawing.Size(1926, 950);
            this.FNCmanage_Tabpage.ResumeLayout(false);
            this.AddFinance_Groupbox.ResumeLayout(false);
            this.AddFinance_Groupbox.PerformLayout();
            this.TileButtons_Panel.ResumeLayout(false);
            this.FNC_TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddFinance_Groupbox;
        private System.Windows.Forms.Button Add_FNC_Button;
        private ModdedControls.ModdedTextBox FNC_notes_Textbox;
        private ModdedTextBox FNC_category_Textbox;
        private ModdedTextBox FNC_relatedentity_Textbox;
        private System.Windows.Forms.Label Type_Label;
        private System.Windows.Forms.Label FNC_Label;
        private ModdedTextBox FNC_due_Textbox;
        private System.Windows.Forms.ComboBox FNC_type_Combobox;
        private BrightIdeasSoftware.OLVColumn cityColumn;
        private TransparentTabControl FNC_TabControl;
        private TabPage FNCmanage_Tabpage;
        private TabPage Search_Modify_Tabpage;
        private TabPage Req_Tabpage;
        private Panel SidePanel1;
        private ns1.BunifuTileButton Req_MTN_TileButton;
        private ns1.BunifuTileButton SearchMod_MTN_TileButton;
        private ns1.BunifuTileButton FNCManager_TileButton;
        private Panel TileButtons_Panel;
        private Label id_Label;
        private ModdedTextBox FNC_id_Textbox;
        private Button Modify_FNC_Button;
        private Button Del_FNC_Button;
        private Label FNC_due_date_Adj_Label;
        private Label FNC_value_Adj_Label;
        private Label FNC_category_Adj_Label;
        private Label FNC_notes_Adj_Label;
        private DateTimePicker FNC_due_date_Datetimepicker;
        private DateTimePicker FNC_done_date_Datetimepicker;
        private Label FNC_done_date_Adj_Label;
        private Label FNC_paid_Adj_Label;
        private ModdedTextBox FNC_paid_Textbox;
        private Label MTN_name_Adj_Label;
    }
}
