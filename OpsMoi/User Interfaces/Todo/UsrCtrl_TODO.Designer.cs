using ModdedControls;

namespace OpsMoi.User_Interfaces
{
    partial class UsrCtrl_Todo
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
            this.todos_Tabcontrol = new TransparentTabControl();
            this.TODO_manageTab = new System.Windows.Forms.TabPage();
            this.AddTodo_Groupbox = new System.Windows.Forms.GroupBox();
            this.TODOs_DelChkPnt_Button = new System.Windows.Forms.Button();
            this.TODOs_AddChkPnt_Button = new System.Windows.Forms.Button();
            this.TODOs_chkpoint_list_Adj_Label = new System.Windows.Forms.Label();
            this.Todos_chkpoint_list_Objectlistview = new BrightIdeasSoftware.ObjectListView();
            this.ChkPnt_index_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ChkPnt_name_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ChkPnt_date_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TODO_start_date_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.TODO_start_date_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_id_Textbox = new ModdedControls.ModdedTextBox();
            this.TODO_todo_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_todo_Textbox = new ModdedControls.ModdedTextBox();
            this.TODO_duration_value_Label = new System.Windows.Forms.Label();
            this.TODO_duration_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_duration_Textbox = new ModdedControls.ModdedTextBox();
            this.TODO_done_date_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.TODO_done_date_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_due_date_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.TODO_notes_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_due_date_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_category_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_dueto_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_name_Adj_Label = new System.Windows.Forms.Label();
            this.Modify_TODO_Button = new System.Windows.Forms.Button();
            this.Del_TODO_Button = new System.Windows.Forms.Button();
            this.id_Label = new System.Windows.Forms.Label();
            this.TODO_category_Textbox = new ModdedControls.ModdedTextBox();
            this.AddTODO_Label = new System.Windows.Forms.Label();
            this.Add_TODO_Button = new System.Windows.Forms.Button();
            this.TODO_notes_Textbox = new ModdedControls.ModdedTextBox();
            this.TODO_dueto_Textbox = new ModdedControls.ModdedTextBox();
            this.TODO_duefrom_Textbox = new ModdedControls.ModdedTextBox();
            this.TODO_reqTab = new System.Windows.Forms.TabPage();
            this.History_Groupbox = new System.Windows.Forms.GroupBox();
            this.TODO_SearchButton = new System.Windows.Forms.Button();
            this.TODO_To_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_From_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_To_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.TODO_From_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.reqTODO_Objectlistview = new BrightIdeasSoftware.ObjectListView();
            this.ReqTODO_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.categoryTODO_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.finalTODO_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Bills_Tab = new System.Windows.Forms.TabPage();
            this.TileButtons_Panel = new System.Windows.Forms.Panel();
            this.TODOreq_TileButton = new ns1.BunifuTileButton();
            this.Bills_TileButton = new ns1.BunifuTileButton();
            this.SidePanel1 = new System.Windows.Forms.Panel();
            this.TODOmanage_TileButton = new ns1.BunifuTileButton();
            this.todos_Tabcontrol.SuspendLayout();
            this.TODO_manageTab.SuspendLayout();
            this.AddTodo_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Todos_chkpoint_list_Objectlistview)).BeginInit();
            this.TODO_reqTab.SuspendLayout();
            this.History_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reqTODO_Objectlistview)).BeginInit();
            this.TileButtons_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // todos_Tabcontrol
            // 
            this.todos_Tabcontrol.Controls.Add(this.TODO_manageTab);
            this.todos_Tabcontrol.Controls.Add(this.TODO_reqTab);
            this.todos_Tabcontrol.Controls.Add(this.Bills_Tab);
            this.todos_Tabcontrol.ItemSize = new System.Drawing.Size(0, 1);
            this.todos_Tabcontrol.Location = new System.Drawing.Point(152, 1);
            this.todos_Tabcontrol.Multiline = true;
            this.todos_Tabcontrol.Name = "todos_Tabcontrol";
            this.todos_Tabcontrol.SelectedIndex = 0;
            this.todos_Tabcontrol.Size = new System.Drawing.Size(1762, 950);
            this.todos_Tabcontrol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.todos_Tabcontrol.TabIndex = 0;
            this.todos_Tabcontrol.SelectedIndexChanged += new System.EventHandler(this.todos_Tabcontrol_SelectedIndexChanged);
            // 
            // TODO_manageTab
            // 
            this.TODO_manageTab.Controls.Add(this.AddTodo_Groupbox);
            this.TODO_manageTab.Location = new System.Drawing.Point(4, 5);
            this.TODO_manageTab.Name = "TODO_manageTab";
            this.TODO_manageTab.Padding = new System.Windows.Forms.Padding(3);
            this.TODO_manageTab.Size = new System.Drawing.Size(1754, 941);
            this.TODO_manageTab.TabIndex = 0;
            this.TODO_manageTab.Text = "إدارة المهام";
            this.TODO_manageTab.UseVisualStyleBackColor = true;
            // 
            // AddTodo_Groupbox
            // 
            this.AddTodo_Groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTodo_Groupbox.Controls.Add(this.TODOs_DelChkPnt_Button);
            this.AddTodo_Groupbox.Controls.Add(this.TODOs_AddChkPnt_Button);
            this.AddTodo_Groupbox.Controls.Add(this.TODOs_chkpoint_list_Adj_Label);
            this.AddTodo_Groupbox.Controls.Add(this.Todos_chkpoint_list_Objectlistview);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_start_date_Datetimepicker);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_start_date_Adj_Label);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_id_Textbox);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_todo_Adj_Label);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_todo_Textbox);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_duration_value_Label);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_duration_Adj_Label);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_duration_Textbox);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_done_date_Datetimepicker);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_done_date_Adj_Label);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_due_date_Datetimepicker);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_notes_Adj_Label);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_due_date_Adj_Label);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_category_Adj_Label);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_dueto_Adj_Label);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_name_Adj_Label);
            this.AddTodo_Groupbox.Controls.Add(this.Modify_TODO_Button);
            this.AddTodo_Groupbox.Controls.Add(this.Del_TODO_Button);
            this.AddTodo_Groupbox.Controls.Add(this.id_Label);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_category_Textbox);
            this.AddTodo_Groupbox.Controls.Add(this.AddTODO_Label);
            this.AddTodo_Groupbox.Controls.Add(this.Add_TODO_Button);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_notes_Textbox);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_dueto_Textbox);
            this.AddTodo_Groupbox.Controls.Add(this.TODO_duefrom_Textbox);
            this.AddTodo_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTodo_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.AddTodo_Groupbox.Location = new System.Drawing.Point(6, 6);
            this.AddTodo_Groupbox.Name = "AddTodo_Groupbox";
            this.AddTodo_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddTodo_Groupbox.Size = new System.Drawing.Size(1566, 893);
            this.AddTodo_Groupbox.TabIndex = 1;
            this.AddTodo_Groupbox.TabStop = false;
            this.AddTodo_Groupbox.Tag = this.Add_TODO_Button;
            this.AddTodo_Groupbox.Text = "إضافة مهام";
            this.AddTodo_Groupbox.ForeColorChanged += new System.EventHandler(this.AddMaintenance_Groupbox_ForeColorChanged);
            // 
            // TODOs_DelChkPnt_Button
            // 
            this.TODOs_DelChkPnt_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TODOs_DelChkPnt_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TODOs_DelChkPnt_Button.Enabled = false;
            this.TODOs_DelChkPnt_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TODOs_DelChkPnt_Button.Font = new System.Drawing.Font("El Messiri", 10.8F);
            this.TODOs_DelChkPnt_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TODOs_DelChkPnt_Button.Location = new System.Drawing.Point(1065, 749);
            this.TODOs_DelChkPnt_Button.Name = "TODOs_DelChkPnt_Button";
            this.TODOs_DelChkPnt_Button.Size = new System.Drawing.Size(220, 35);
            this.TODOs_DelChkPnt_Button.TabIndex = 80;
            this.TODOs_DelChkPnt_Button.Text = "حذف المحدد";
            this.TODOs_DelChkPnt_Button.UseVisualStyleBackColor = false;
            this.TODOs_DelChkPnt_Button.Click += new System.EventHandler(this.TODOs_DelChkPnt_Button_Click);
            // 
            // TODOs_AddChkPnt_Button
            // 
            this.TODOs_AddChkPnt_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TODOs_AddChkPnt_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TODOs_AddChkPnt_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TODOs_AddChkPnt_Button.Font = new System.Drawing.Font("El Messiri", 10.8F);
            this.TODOs_AddChkPnt_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TODOs_AddChkPnt_Button.Location = new System.Drawing.Point(839, 750);
            this.TODOs_AddChkPnt_Button.Name = "TODOs_AddChkPnt_Button";
            this.TODOs_AddChkPnt_Button.Size = new System.Drawing.Size(220, 35);
            this.TODOs_AddChkPnt_Button.TabIndex = 79;
            this.TODOs_AddChkPnt_Button.Text = "إضافة نقطة فاصلة";
            this.TODOs_AddChkPnt_Button.UseVisualStyleBackColor = false;
            this.TODOs_AddChkPnt_Button.Click += new System.EventHandler(this.TODOs_AddChkPnt_Button_Click);
            // 
            // TODOs_chkpoint_list_Adj_Label
            // 
            this.TODOs_chkpoint_list_Adj_Label.AutoSize = true;
            this.TODOs_chkpoint_list_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.TODOs_chkpoint_list_Adj_Label.Location = new System.Drawing.Point(1455, 389);
            this.TODOs_chkpoint_list_Adj_Label.Name = "TODOs_chkpoint_list_Adj_Label";
            this.TODOs_chkpoint_list_Adj_Label.Size = new System.Drawing.Size(102, 33);
            this.TODOs_chkpoint_list_Adj_Label.TabIndex = 78;
            this.TODOs_chkpoint_list_Adj_Label.Text = "نقاط فاصلة";
            // 
            // Todos_chkpoint_list_Objectlistview
            // 
            this.Todos_chkpoint_list_Objectlistview.AllColumns.Add(this.ChkPnt_index_Column);
            this.Todos_chkpoint_list_Objectlistview.AllColumns.Add(this.ChkPnt_name_Column);
            this.Todos_chkpoint_list_Objectlistview.AllColumns.Add(this.ChkPnt_date_Column);
            this.Todos_chkpoint_list_Objectlistview.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.Todos_chkpoint_list_Objectlistview.CellEditUseWholeCell = false;
            this.Todos_chkpoint_list_Objectlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChkPnt_index_Column,
            this.ChkPnt_name_Column,
            this.ChkPnt_date_Column});
            this.Todos_chkpoint_list_Objectlistview.Cursor = System.Windows.Forms.Cursors.Default;
            this.Todos_chkpoint_list_Objectlistview.EmptyListMsg = "لا يوجد عناصر";
            this.Todos_chkpoint_list_Objectlistview.EmptyListMsgFont = new System.Drawing.Font("Cairo SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.Todos_chkpoint_list_Objectlistview.Font = new System.Drawing.Font("El Messiri", 8.2F);
            this.Todos_chkpoint_list_Objectlistview.FullRowSelect = true;
            this.Todos_chkpoint_list_Objectlistview.HideSelection = false;
            this.Todos_chkpoint_list_Objectlistview.Location = new System.Drawing.Point(839, 425);
            this.Todos_chkpoint_list_Objectlistview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Todos_chkpoint_list_Objectlistview.Name = "Todos_chkpoint_list_Objectlistview";
            this.Todos_chkpoint_list_Objectlistview.RightToLeftLayout = true;
            this.Todos_chkpoint_list_Objectlistview.ShowCommandMenuOnRightClick = true;
            this.Todos_chkpoint_list_Objectlistview.ShowFilterMenuOnRightClick = false;
            this.Todos_chkpoint_list_Objectlistview.Size = new System.Drawing.Size(721, 320);
            this.Todos_chkpoint_list_Objectlistview.SortGroupItemsByPrimaryColumn = false;
            this.Todos_chkpoint_list_Objectlistview.SpaceBetweenGroups = 5;
            this.Todos_chkpoint_list_Objectlistview.TabIndex = 77;
            this.Todos_chkpoint_list_Objectlistview.TintSortColumn = true;
            this.Todos_chkpoint_list_Objectlistview.UseCompatibleStateImageBehavior = false;
            this.Todos_chkpoint_list_Objectlistview.UseFilterIndicator = true;
            this.Todos_chkpoint_list_Objectlistview.UseFiltering = true;
            this.Todos_chkpoint_list_Objectlistview.UseHotControls = false;
            this.Todos_chkpoint_list_Objectlistview.View = System.Windows.Forms.View.Details;
            this.Todos_chkpoint_list_Objectlistview.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.Todos_chkpoint_list_Objectlistview_CellEditStarting);
            this.Todos_chkpoint_list_Objectlistview.SelectionChanged += new System.EventHandler(this.Todos_chkpoint_list_Objectlistview_SelectionChanged);
            // 
            // ChkPnt_index_Column
            // 
            this.ChkPnt_index_Column.AspectName = "index";
            this.ChkPnt_index_Column.Hideable = false;
            this.ChkPnt_index_Column.IsEditable = false;
            this.ChkPnt_index_Column.MinimumWidth = 45;
            this.ChkPnt_index_Column.Tag = "string";
            this.ChkPnt_index_Column.Text = "م";
            this.ChkPnt_index_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChkPnt_index_Column.Width = 45;
            // 
            // ChkPnt_name_Column
            // 
            this.ChkPnt_name_Column.AspectName = "ChkName";
            this.ChkPnt_name_Column.Hideable = false;
            this.ChkPnt_name_Column.MinimumWidth = 320;
            this.ChkPnt_name_Column.Tag = "string";
            this.ChkPnt_name_Column.Text = "نقطة فاصلة";
            this.ChkPnt_name_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChkPnt_name_Column.Width = 320;
            // 
            // ChkPnt_date_Column
            // 
            this.ChkPnt_date_Column.AspectName = "Chk_Date";
            this.ChkPnt_date_Column.AspectToStringFormat = "{0: dddd, dd-MMMM-yyyy -- hh:mm tt}";
            this.ChkPnt_date_Column.Hideable = false;
            this.ChkPnt_date_Column.MinimumWidth = 200;
            this.ChkPnt_date_Column.Tag = "date";
            this.ChkPnt_date_Column.Text = "التاريخ";
            this.ChkPnt_date_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChkPnt_date_Column.Width = 200;
            // 
            // TODO_start_date_Datetimepicker
            // 
            this.TODO_start_date_Datetimepicker.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F);
            this.TODO_start_date_Datetimepicker.CustomFormat = "dddd, dd-MMMM-yyyy -- hh:mm tt";
            this.TODO_start_date_Datetimepicker.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.TODO_start_date_Datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TODO_start_date_Datetimepicker.Location = new System.Drawing.Point(887, 249);
            this.TODO_start_date_Datetimepicker.Name = "TODO_start_date_Datetimepicker";
            this.TODO_start_date_Datetimepicker.Size = new System.Drawing.Size(513, 34);
            this.TODO_start_date_Datetimepicker.TabIndex = 75;
            this.TODO_start_date_Datetimepicker.ValueChanged += new System.EventHandler(this.TODO_Datetimepicker_ValueChanged);
            // 
            // TODO_start_date_Adj_Label
            // 
            this.TODO_start_date_Adj_Label.AutoSize = true;
            this.TODO_start_date_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_start_date_Adj_Label.Location = new System.Drawing.Point(1448, 255);
            this.TODO_start_date_Adj_Label.Name = "TODO_start_date_Adj_Label";
            this.TODO_start_date_Adj_Label.Size = new System.Drawing.Size(81, 27);
            this.TODO_start_date_Adj_Label.TabIndex = 76;
            this.TODO_start_date_Adj_Label.Text = "موعد البداية";
            // 
            // TODO_id_Textbox
            // 
            this.TODO_id_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TODO_id_Textbox.Enabled = false;
            this.TODO_id_Textbox.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TODO_id_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.TODO_id_Textbox.IsPasswordTextbox = false;
            this.TODO_id_Textbox.IsPlaceholder = true;
            this.TODO_id_Textbox.Location = new System.Drawing.Point(32, 48);
            this.TODO_id_Textbox.Name = "TODO_id_Textbox";
            this.TODO_id_Textbox.Placeholder = "كود العملية (أدخل أرقام فقط)[في حالة التعديل او الحذف فقط]";
            this.TODO_id_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.TODO_id_Textbox.placeholderFont = null;
            this.TODO_id_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TODO_id_Textbox.SelectedItem = null;
            this.TODO_id_Textbox.Size = new System.Drawing.Size(488, 29);
            this.TODO_id_Textbox.TabIndex = 74;
            this.TODO_id_Textbox.Tag = "";
            this.TODO_id_Textbox.Text = "كود العملية (أدخل أرقام فقط)[في حالة التعديل او الحذف فقط]";
            this.TODO_id_Textbox.Values = null;
            this.TODO_id_Textbox.Visible_Password_Button = false;
            this.TODO_id_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.TODO_id_Textbox_SelectedItemChanged);
            this.TODO_id_Textbox.TextChanged += new System.EventHandler(this.TODO_id_Textbox_TextChanged);
            // 
            // TODO_todo_Adj_Label
            // 
            this.TODO_todo_Adj_Label.AutoSize = true;
            this.TODO_todo_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_todo_Adj_Label.Location = new System.Drawing.Point(1441, 204);
            this.TODO_todo_Adj_Label.Name = "TODO_todo_Adj_Label";
            this.TODO_todo_Adj_Label.Size = new System.Drawing.Size(107, 27);
            this.TODO_todo_Adj_Label.TabIndex = 73;
            this.TODO_todo_Adj_Label.Text = "المهمة المطلوبة";
            // 
            // TODO_todo_Textbox
            // 
            this.TODO_todo_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TODO_todo_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TODO_todo_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.TODO_todo_Textbox.IsPasswordTextbox = false;
            this.TODO_todo_Textbox.IsPlaceholder = true;
            this.TODO_todo_Textbox.Location = new System.Drawing.Point(532, 198);
            this.TODO_todo_Textbox.Name = "TODO_todo_Textbox";
            this.TODO_todo_Textbox.Placeholder = "المهمة";
            this.TODO_todo_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.TODO_todo_Textbox.placeholderFont = null;
            this.TODO_todo_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TODO_todo_Textbox.SelectedItem = null;
            this.TODO_todo_Textbox.Size = new System.Drawing.Size(901, 38);
            this.TODO_todo_Textbox.TabIndex = 4;
            this.TODO_todo_Textbox.Tag = "";
            this.TODO_todo_Textbox.Text = "المهمة";
            this.TODO_todo_Textbox.Values = null;
            this.TODO_todo_Textbox.Visible_Password_Button = false;
            // 
            // TODO_duration_value_Label
            // 
            this.TODO_duration_value_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_duration_value_Label.Location = new System.Drawing.Point(32, 366);
            this.TODO_duration_value_Label.Name = "TODO_duration_value_Label";
            this.TODO_duration_value_Label.Size = new System.Drawing.Size(632, 27);
            this.TODO_duration_value_Label.TabIndex = 71;
            // 
            // TODO_duration_Adj_Label
            // 
            this.TODO_duration_Adj_Label.AutoSize = true;
            this.TODO_duration_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_duration_Adj_Label.Location = new System.Drawing.Point(670, 330);
            this.TODO_duration_Adj_Label.Name = "TODO_duration_Adj_Label";
            this.TODO_duration_Adj_Label.Size = new System.Drawing.Size(168, 27);
            this.TODO_duration_Adj_Label.TabIndex = 70;
            this.TODO_duration_Adj_Label.Text = "الوقت المستغرق (بالدقائق)";
            // 
            // TODO_duration_Textbox
            // 
            this.TODO_duration_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TODO_duration_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TODO_duration_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.TODO_duration_Textbox.IsPasswordTextbox = false;
            this.TODO_duration_Textbox.IsPlaceholder = true;
            this.TODO_duration_Textbox.Location = new System.Drawing.Point(32, 324);
            this.TODO_duration_Textbox.Name = "TODO_duration_Textbox";
            this.TODO_duration_Textbox.Placeholder = "الوقت المستغرق";
            this.TODO_duration_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.TODO_duration_Textbox.placeholderFont = null;
            this.TODO_duration_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TODO_duration_Textbox.SelectedItem = null;
            this.TODO_duration_Textbox.Size = new System.Drawing.Size(635, 38);
            this.TODO_duration_Textbox.TabIndex = 8;
            this.TODO_duration_Textbox.Tag = "";
            this.TODO_duration_Textbox.Text = "0";
            this.TODO_duration_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TODO_duration_Textbox.Values = null;
            this.TODO_duration_Textbox.Visible_Password_Button = false;
            this.TODO_duration_Textbox.TextChanged += new System.EventHandler(this.TODO_duration_Textbox_TextChanged);
            // 
            // TODO_done_date_Datetimepicker
            // 
            this.TODO_done_date_Datetimepicker.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F);
            this.TODO_done_date_Datetimepicker.Checked = false;
            this.TODO_done_date_Datetimepicker.CustomFormat = "dddd, dd-MMMM-yyyy -- hh:mm tt";
            this.TODO_done_date_Datetimepicker.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.TODO_done_date_Datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TODO_done_date_Datetimepicker.Location = new System.Drawing.Point(854, 340);
            this.TODO_done_date_Datetimepicker.Name = "TODO_done_date_Datetimepicker";
            this.TODO_done_date_Datetimepicker.ShowCheckBox = true;
            this.TODO_done_date_Datetimepicker.Size = new System.Drawing.Size(546, 34);
            this.TODO_done_date_Datetimepicker.TabIndex = 7;
            this.TODO_done_date_Datetimepicker.ValueChanged += new System.EventHandler(this.TODO_Datetimepicker_ValueChanged);
            // 
            // TODO_done_date_Adj_Label
            // 
            this.TODO_done_date_Adj_Label.AutoSize = true;
            this.TODO_done_date_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_done_date_Adj_Label.Location = new System.Drawing.Point(1448, 346);
            this.TODO_done_date_Adj_Label.Name = "TODO_done_date_Adj_Label";
            this.TODO_done_date_Adj_Label.Size = new System.Drawing.Size(81, 27);
            this.TODO_done_date_Adj_Label.TabIndex = 67;
            this.TODO_done_date_Adj_Label.Text = "موعد الإنهاء";
            // 
            // TODO_due_date_Datetimepicker
            // 
            this.TODO_due_date_Datetimepicker.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F);
            this.TODO_due_date_Datetimepicker.CustomFormat = "dddd, dd-MMMM-yyyy -- hh:mm tt";
            this.TODO_due_date_Datetimepicker.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.TODO_due_date_Datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TODO_due_date_Datetimepicker.Location = new System.Drawing.Point(887, 291);
            this.TODO_due_date_Datetimepicker.Name = "TODO_due_date_Datetimepicker";
            this.TODO_due_date_Datetimepicker.Size = new System.Drawing.Size(513, 34);
            this.TODO_due_date_Datetimepicker.TabIndex = 5;
            // 
            // TODO_notes_Adj_Label
            // 
            this.TODO_notes_Adj_Label.AutoSize = true;
            this.TODO_notes_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.TODO_notes_Adj_Label.Location = new System.Drawing.Point(750, 389);
            this.TODO_notes_Adj_Label.Name = "TODO_notes_Adj_Label";
            this.TODO_notes_Adj_Label.Size = new System.Drawing.Size(80, 33);
            this.TODO_notes_Adj_Label.TabIndex = 64;
            this.TODO_notes_Adj_Label.Text = "ملاحظات";
            // 
            // TODO_due_date_Adj_Label
            // 
            this.TODO_due_date_Adj_Label.AutoSize = true;
            this.TODO_due_date_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_due_date_Adj_Label.Location = new System.Drawing.Point(1448, 297);
            this.TODO_due_date_Adj_Label.Name = "TODO_due_date_Adj_Label";
            this.TODO_due_date_Adj_Label.Size = new System.Drawing.Size(94, 27);
            this.TODO_due_date_Adj_Label.TabIndex = 63;
            this.TODO_due_date_Adj_Label.Text = "الموعد النهائي";
            // 
            // TODO_category_Adj_Label
            // 
            this.TODO_category_Adj_Label.AutoSize = true;
            this.TODO_category_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_category_Adj_Label.Location = new System.Drawing.Point(1459, 154);
            this.TODO_category_Adj_Label.Name = "TODO_category_Adj_Label";
            this.TODO_category_Adj_Label.Size = new System.Drawing.Size(63, 27);
            this.TODO_category_Adj_Label.TabIndex = 62;
            this.TODO_category_Adj_Label.Text = "التصنيف";
            // 
            // TODO_dueto_Adj_Label
            // 
            this.TODO_dueto_Adj_Label.AutoSize = true;
            this.TODO_dueto_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_dueto_Adj_Label.Location = new System.Drawing.Point(1439, 103);
            this.TODO_dueto_Adj_Label.Name = "TODO_dueto_Adj_Label";
            this.TODO_dueto_Adj_Label.Size = new System.Drawing.Size(103, 27);
            this.TODO_dueto_Adj_Label.TabIndex = 61;
            this.TODO_dueto_Adj_Label.Text = "الجهة المستحِقة";
            // 
            // TODO_name_Adj_Label
            // 
            this.TODO_name_Adj_Label.AutoSize = true;
            this.TODO_name_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_name_Adj_Label.Location = new System.Drawing.Point(1447, 51);
            this.TODO_name_Adj_Label.Name = "TODO_name_Adj_Label";
            this.TODO_name_Adj_Label.Size = new System.Drawing.Size(75, 27);
            this.TODO_name_Adj_Label.TabIndex = 60;
            this.TODO_name_Adj_Label.Text = "مطلوب من";
            // 
            // Modify_TODO_Button
            // 
            this.Modify_TODO_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Modify_TODO_Button.FlatAppearance.BorderSize = 0;
            this.Modify_TODO_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modify_TODO_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify_TODO_Button.ForeColor = System.Drawing.Color.Black;
            this.Modify_TODO_Button.Location = new System.Drawing.Point(771, 833);
            this.Modify_TODO_Button.Name = "Modify_TODO_Button";
            this.Modify_TODO_Button.Size = new System.Drawing.Size(259, 53);
            this.Modify_TODO_Button.TabIndex = 55;
            this.Modify_TODO_Button.Text = "تعديل مهام";
            this.Modify_TODO_Button.UseVisualStyleBackColor = false;
            this.Modify_TODO_Button.Click += new System.EventHandler(this.TODO_Button_Click);
            // 
            // Del_TODO_Button
            // 
            this.Del_TODO_Button.BackColor = System.Drawing.Color.DarkRed;
            this.Del_TODO_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_TODO_Button.Font = new System.Drawing.Font("El Messiri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_TODO_Button.ForeColor = System.Drawing.Color.Black;
            this.Del_TODO_Button.Location = new System.Drawing.Point(401, 840);
            this.Del_TODO_Button.Name = "Del_TODO_Button";
            this.Del_TODO_Button.Size = new System.Drawing.Size(221, 38);
            this.Del_TODO_Button.TabIndex = 54;
            this.Del_TODO_Button.Text = "حذف مهام";
            this.Del_TODO_Button.UseVisualStyleBackColor = false;
            this.Del_TODO_Button.Click += new System.EventHandler(this.TODO_Button_Click);
            // 
            // id_Label
            // 
            this.id_Label.AutoSize = true;
            this.id_Label.Font = new System.Drawing.Font("El Messiri", 10.8F);
            this.id_Label.Location = new System.Drawing.Point(32, 80);
            this.id_Label.Name = "id_Label";
            this.id_Label.Size = new System.Drawing.Size(137, 29);
            this.id_Label.TabIndex = 52;
            this.id_Label.Text = "أدخل أرقام فقط";
            this.id_Label.Visible = false;
            // 
            // TODO_category_Textbox
            // 
            this.TODO_category_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TODO_category_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TODO_category_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.TODO_category_Textbox.IsPasswordTextbox = false;
            this.TODO_category_Textbox.IsPlaceholder = true;
            this.TODO_category_Textbox.Location = new System.Drawing.Point(532, 147);
            this.TODO_category_Textbox.Name = "TODO_category_Textbox";
            this.TODO_category_Textbox.Placeholder = "التصنيف";
            this.TODO_category_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.TODO_category_Textbox.placeholderFont = null;
            this.TODO_category_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TODO_category_Textbox.SelectedItem = null;
            this.TODO_category_Textbox.Size = new System.Drawing.Size(901, 38);
            this.TODO_category_Textbox.TabIndex = 3;
            this.TODO_category_Textbox.Tag = "";
            this.TODO_category_Textbox.Text = "التصنيف";
            this.TODO_category_Textbox.Values = null;
            this.TODO_category_Textbox.Visible_Password_Button = false;
            // 
            // AddTODO_Label
            // 
            this.AddTODO_Label.Font = new System.Drawing.Font("El Messiri", 11.8F);
            this.AddTODO_Label.Location = new System.Drawing.Point(15, 787);
            this.AddTODO_Label.Name = "AddTODO_Label";
            this.AddTODO_Label.Size = new System.Drawing.Size(1515, 41);
            this.AddTODO_Label.TabIndex = 41;
            this.AddTODO_Label.Text = "اختر نوع الصيانة";
            this.AddTODO_Label.Visible = false;
            // 
            // Add_TODO_Button
            // 
            this.Add_TODO_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Add_TODO_Button.FlatAppearance.BorderSize = 0;
            this.Add_TODO_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_TODO_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_TODO_Button.ForeColor = System.Drawing.Color.Black;
            this.Add_TODO_Button.Location = new System.Drawing.Point(15, 833);
            this.Add_TODO_Button.Name = "Add_TODO_Button";
            this.Add_TODO_Button.Size = new System.Drawing.Size(259, 53);
            this.Add_TODO_Button.TabIndex = 35;
            this.Add_TODO_Button.Text = "إضافة مهام";
            this.Add_TODO_Button.UseVisualStyleBackColor = false;
            this.Add_TODO_Button.Click += new System.EventHandler(this.TODO_Button_Click);
            // 
            // TODO_notes_Textbox
            // 
            this.TODO_notes_Textbox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODO_notes_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.TODO_notes_Textbox.IsPasswordTextbox = false;
            this.TODO_notes_Textbox.IsPlaceholder = true;
            this.TODO_notes_Textbox.Location = new System.Drawing.Point(6, 425);
            this.TODO_notes_Textbox.Multiline = true;
            this.TODO_notes_Textbox.Name = "TODO_notes_Textbox";
            this.TODO_notes_Textbox.Placeholder = "ملاحظات";
            this.TODO_notes_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.TODO_notes_Textbox.placeholderFont = null;
            this.TODO_notes_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TODO_notes_Textbox.SelectedItem = null;
            this.TODO_notes_Textbox.Size = new System.Drawing.Size(827, 355);
            this.TODO_notes_Textbox.TabIndex = 6;
            this.TODO_notes_Textbox.Tag = "";
            this.TODO_notes_Textbox.Text = "لا يوجد ملاحظات";
            this.TODO_notes_Textbox.Values = null;
            this.TODO_notes_Textbox.Visible_Password_Button = false;
            // 
            // TODO_dueto_Textbox
            // 
            this.TODO_dueto_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TODO_dueto_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TODO_dueto_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.TODO_dueto_Textbox.IsPasswordTextbox = false;
            this.TODO_dueto_Textbox.IsPlaceholder = true;
            this.TODO_dueto_Textbox.Location = new System.Drawing.Point(532, 96);
            this.TODO_dueto_Textbox.Name = "TODO_dueto_Textbox";
            this.TODO_dueto_Textbox.Placeholder = "الجهة المطلوب لها";
            this.TODO_dueto_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.TODO_dueto_Textbox.placeholderFont = null;
            this.TODO_dueto_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TODO_dueto_Textbox.SelectedItem = null;
            this.TODO_dueto_Textbox.Size = new System.Drawing.Size(901, 38);
            this.TODO_dueto_Textbox.TabIndex = 2;
            this.TODO_dueto_Textbox.Tag = "";
            this.TODO_dueto_Textbox.Text = "الجهة المطلوب لها";
            this.TODO_dueto_Textbox.Values = null;
            this.TODO_dueto_Textbox.Visible_Password_Button = false;
            // 
            // TODO_duefrom_Textbox
            // 
            this.TODO_duefrom_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TODO_duefrom_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TODO_duefrom_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.TODO_duefrom_Textbox.IsPasswordTextbox = false;
            this.TODO_duefrom_Textbox.IsPlaceholder = true;
            this.TODO_duefrom_Textbox.Location = new System.Drawing.Point(532, 44);
            this.TODO_duefrom_Textbox.Name = "TODO_duefrom_Textbox";
            this.TODO_duefrom_Textbox.Placeholder = "مطلوب من";
            this.TODO_duefrom_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.TODO_duefrom_Textbox.placeholderFont = null;
            this.TODO_duefrom_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TODO_duefrom_Textbox.SelectedItem = null;
            this.TODO_duefrom_Textbox.Size = new System.Drawing.Size(901, 38);
            this.TODO_duefrom_Textbox.TabIndex = 1;
            this.TODO_duefrom_Textbox.Tag = "";
            this.TODO_duefrom_Textbox.Text = "مطلوب من";
            this.TODO_duefrom_Textbox.Values = null;
            this.TODO_duefrom_Textbox.Visible_Password_Button = false;
            // 
            // TODO_reqTab
            // 
            this.TODO_reqTab.Controls.Add(this.History_Groupbox);
            this.TODO_reqTab.Location = new System.Drawing.Point(4, 5);
            this.TODO_reqTab.Name = "TODO_reqTab";
            this.TODO_reqTab.Padding = new System.Windows.Forms.Padding(3);
            this.TODO_reqTab.Size = new System.Drawing.Size(1754, 941);
            this.TODO_reqTab.TabIndex = 1;
            this.TODO_reqTab.Text = "المهام المطلوبة";
            this.TODO_reqTab.UseVisualStyleBackColor = true;
            // 
            // History_Groupbox
            // 
            this.History_Groupbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.History_Groupbox.Controls.Add(this.TODO_SearchButton);
            this.History_Groupbox.Controls.Add(this.TODO_To_Adj_Label);
            this.History_Groupbox.Controls.Add(this.TODO_From_Adj_Label);
            this.History_Groupbox.Controls.Add(this.TODO_To_Datetimepicker);
            this.History_Groupbox.Controls.Add(this.TODO_From_Datetimepicker);
            this.History_Groupbox.Controls.Add(this.reqTODO_Objectlistview);
            this.History_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.History_Groupbox.Location = new System.Drawing.Point(6, 6);
            this.History_Groupbox.Name = "History_Groupbox";
            this.History_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.History_Groupbox.Size = new System.Drawing.Size(1503, 879);
            this.History_Groupbox.TabIndex = 11;
            this.History_Groupbox.TabStop = false;
            this.History_Groupbox.Text = "تاريخ العمليات";
            // 
            // TODO_SearchButton
            // 
            this.TODO_SearchButton.ForeColor = System.Drawing.Color.Black;
            this.TODO_SearchButton.Location = new System.Drawing.Point(17, 35);
            this.TODO_SearchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TODO_SearchButton.Name = "TODO_SearchButton";
            this.TODO_SearchButton.Size = new System.Drawing.Size(146, 46);
            this.TODO_SearchButton.TabIndex = 18;
            this.TODO_SearchButton.Text = "بحث";
            this.TODO_SearchButton.UseVisualStyleBackColor = true;
            this.TODO_SearchButton.Click += new System.EventHandler(this.TODO_SearchButton_Click);
            // 
            // TODO_To_Adj_Label
            // 
            this.TODO_To_Adj_Label.AutoSize = true;
            this.TODO_To_Adj_Label.Font = new System.Drawing.Font("El Messiri", 12F);
            this.TODO_To_Adj_Label.Location = new System.Drawing.Point(555, 40);
            this.TODO_To_Adj_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TODO_To_Adj_Label.Name = "TODO_To_Adj_Label";
            this.TODO_To_Adj_Label.Size = new System.Drawing.Size(43, 31);
            this.TODO_To_Adj_Label.TabIndex = 17;
            this.TODO_To_Adj_Label.Text = "إلى";
            // 
            // TODO_From_Adj_Label
            // 
            this.TODO_From_Adj_Label.AutoSize = true;
            this.TODO_From_Adj_Label.Font = new System.Drawing.Font("El Messiri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODO_From_Adj_Label.Location = new System.Drawing.Point(990, 40);
            this.TODO_From_Adj_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TODO_From_Adj_Label.Name = "TODO_From_Adj_Label";
            this.TODO_From_Adj_Label.Size = new System.Drawing.Size(38, 31);
            this.TODO_From_Adj_Label.TabIndex = 16;
            this.TODO_From_Adj_Label.Text = "من";
            // 
            // TODO_To_Datetimepicker
            // 
            this.TODO_To_Datetimepicker.CalendarFont = new System.Drawing.Font("El Messiri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODO_To_Datetimepicker.Font = new System.Drawing.Font("El Messiri", 12F);
            this.TODO_To_Datetimepicker.Location = new System.Drawing.Point(195, 36);
            this.TODO_To_Datetimepicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TODO_To_Datetimepicker.Name = "TODO_To_Datetimepicker";
            this.TODO_To_Datetimepicker.Size = new System.Drawing.Size(355, 39);
            this.TODO_To_Datetimepicker.TabIndex = 15;
            this.TODO_To_Datetimepicker.Value = new System.DateTime(2025, 7, 2, 0, 0, 0, 0);
            // 
            // TODO_From_Datetimepicker
            // 
            this.TODO_From_Datetimepicker.CalendarFont = new System.Drawing.Font("El Messiri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODO_From_Datetimepicker.Font = new System.Drawing.Font("El Messiri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODO_From_Datetimepicker.Location = new System.Drawing.Point(630, 36);
            this.TODO_From_Datetimepicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TODO_From_Datetimepicker.Name = "TODO_From_Datetimepicker";
            this.TODO_From_Datetimepicker.Size = new System.Drawing.Size(355, 39);
            this.TODO_From_Datetimepicker.TabIndex = 14;
            this.TODO_From_Datetimepicker.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            // 
            // reqTODO_Objectlistview
            // 
            this.reqTODO_Objectlistview.AllColumns.Add(this.ReqTODO_Column);
            this.reqTODO_Objectlistview.AllColumns.Add(this.categoryTODO_Column);
            this.reqTODO_Objectlistview.AllColumns.Add(this.finalTODO_Column);
            this.reqTODO_Objectlistview.CellEditUseWholeCell = false;
            this.reqTODO_Objectlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ReqTODO_Column,
            this.categoryTODO_Column,
            this.finalTODO_Column});
            this.reqTODO_Objectlistview.Cursor = System.Windows.Forms.Cursors.Default;
            this.reqTODO_Objectlistview.Font = new System.Drawing.Font("El Messiri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqTODO_Objectlistview.FullRowSelect = true;
            this.reqTODO_Objectlistview.HideSelection = false;
            this.reqTODO_Objectlistview.Location = new System.Drawing.Point(6, 95);
            this.reqTODO_Objectlistview.Name = "reqTODO_Objectlistview";
            this.reqTODO_Objectlistview.RightToLeftLayout = true;
            this.reqTODO_Objectlistview.SelectColumnsOnRightClick = false;
            this.reqTODO_Objectlistview.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.reqTODO_Objectlistview.ShowCommandMenuOnRightClick = true;
            this.reqTODO_Objectlistview.ShowItemCountOnGroups = true;
            this.reqTODO_Objectlistview.Size = new System.Drawing.Size(1491, 778);
            this.reqTODO_Objectlistview.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.reqTODO_Objectlistview.SpaceBetweenGroups = 3;
            this.reqTODO_Objectlistview.TabIndex = 13;
            this.reqTODO_Objectlistview.UseCompatibleStateImageBehavior = false;
            this.reqTODO_Objectlistview.UseFiltering = true;
            this.reqTODO_Objectlistview.UseHotControls = false;
            this.reqTODO_Objectlistview.View = System.Windows.Forms.View.Details;
            this.reqTODO_Objectlistview.AboutToCreateGroups += new System.EventHandler<BrightIdeasSoftware.CreateGroupsEventArgs>(this.reqTODO_Objectlistview_AboutToCreateGroups);
            this.reqTODO_Objectlistview.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.reqTODO_Objectlistview_FormatRow);
            this.reqTODO_Objectlistview.DoubleClick += new System.EventHandler(this.reqTODO_Objectlistview_DoubleClick);
            // 
            // ReqTODO_Column
            // 
            this.ReqTODO_Column.AspectName = "todo";
            this.ReqTODO_Column.Hideable = false;
            this.ReqTODO_Column.MinimumWidth = 500;
            this.ReqTODO_Column.Text = "المهمة المطلوبة";
            this.ReqTODO_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReqTODO_Column.Width = 500;
            // 
            // categoryTODO_Column
            // 
            this.categoryTODO_Column.AspectName = "category";
            this.categoryTODO_Column.Hideable = false;
            this.categoryTODO_Column.MinimumWidth = 200;
            this.categoryTODO_Column.Text = "التصنيف";
            this.categoryTODO_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.categoryTODO_Column.Width = 200;
            // 
            // finalTODO_Column
            // 
            this.finalTODO_Column.AspectName = "due_date";
            this.finalTODO_Column.AspectToStringFormat = "{0: dddd, dd MMMM yyyy}";
            this.finalTODO_Column.Hideable = false;
            this.finalTODO_Column.MinimumWidth = 250;
            this.finalTODO_Column.Text = "الموعد النهائي";
            this.finalTODO_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.finalTODO_Column.Width = 250;
            // 
            // Bills_Tab
            // 
            this.Bills_Tab.Location = new System.Drawing.Point(4, 5);
            this.Bills_Tab.Name = "Bills_Tab";
            this.Bills_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Bills_Tab.Size = new System.Drawing.Size(1754, 941);
            this.Bills_Tab.TabIndex = 2;
            this.Bills_Tab.Text = "الطلبات (تجهيزات - نقل أجهزة)";
            this.Bills_Tab.UseVisualStyleBackColor = true;
            // 
            // TileButtons_Panel
            // 
            this.TileButtons_Panel.Controls.Add(this.TODOreq_TileButton);
            this.TileButtons_Panel.Controls.Add(this.Bills_TileButton);
            this.TileButtons_Panel.Controls.Add(this.SidePanel1);
            this.TileButtons_Panel.Controls.Add(this.TODOmanage_TileButton);
            this.TileButtons_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TileButtons_Panel.Location = new System.Drawing.Point(0, 0);
            this.TileButtons_Panel.Name = "TileButtons_Panel";
            this.TileButtons_Panel.Size = new System.Drawing.Size(150, 950);
            this.TileButtons_Panel.TabIndex = 53;
            // 
            // TODOreq_TileButton
            // 
            this.TODOreq_TileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TODOreq_TileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TODOreq_TileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.TODOreq_TileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TODOreq_TileButton.Font = new System.Drawing.Font("A Nasr", 17F);
            this.TODOreq_TileButton.ForeColor = System.Drawing.Color.Black;
            this.TODOreq_TileButton.Image = null;
            this.TODOreq_TileButton.ImagePosition = 0;
            this.TODOreq_TileButton.ImageZoom = 0;
            this.TODOreq_TileButton.LabelPosition = 150;
            this.TODOreq_TileButton.LabelText = "المهام المطلوبة";
            this.TODOreq_TileButton.Location = new System.Drawing.Point(0, 317);
            this.TODOreq_TileButton.Margin = new System.Windows.Forms.Padding(6);
            this.TODOreq_TileButton.Name = "TODOreq_TileButton";
            this.TODOreq_TileButton.Size = new System.Drawing.Size(150, 317);
            this.TODOreq_TileButton.TabIndex = 48;
            this.TODOreq_TileButton.Tag = this.TODO_reqTab;
            this.TODOreq_TileButton.Click += new System.EventHandler(this.TileButton_Click);
            // 
            // Bills_TileButton
            // 
            this.Bills_TileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Bills_TileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Bills_TileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.Bills_TileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bills_TileButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bills_TileButton.Font = new System.Drawing.Font("A Nasr", 13F);
            this.Bills_TileButton.ForeColor = System.Drawing.Color.Black;
            this.Bills_TileButton.Image = null;
            this.Bills_TileButton.ImagePosition = 0;
            this.Bills_TileButton.ImageZoom = 0;
            this.Bills_TileButton.LabelPosition = 160;
            this.Bills_TileButton.LabelText = "مدفوعات";
            this.Bills_TileButton.Location = new System.Drawing.Point(0, 634);
            this.Bills_TileButton.Margin = new System.Windows.Forms.Padding(49, 57, 49, 57);
            this.Bills_TileButton.Name = "Bills_TileButton";
            this.Bills_TileButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Bills_TileButton.Size = new System.Drawing.Size(150, 316);
            this.Bills_TileButton.TabIndex = 47;
            this.Bills_TileButton.Tag = this.Bills_Tab;
            this.Bills_TileButton.Visible = false;
            this.Bills_TileButton.Click += new System.EventHandler(this.TileButton_Click);
            // 
            // SidePanel1
            // 
            this.SidePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.SidePanel1.Location = new System.Drawing.Point(0, 0);
            this.SidePanel1.Name = "SidePanel1";
            this.SidePanel1.Size = new System.Drawing.Size(12, 317);
            this.SidePanel1.TabIndex = 46;
            // 
            // TODOmanage_TileButton
            // 
            this.TODOmanage_TileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TODOmanage_TileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TODOmanage_TileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.TODOmanage_TileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TODOmanage_TileButton.Font = new System.Drawing.Font("A Nasr", 16.5F);
            this.TODOmanage_TileButton.ForeColor = System.Drawing.Color.Black;
            this.TODOmanage_TileButton.Image = null;
            this.TODOmanage_TileButton.ImagePosition = 0;
            this.TODOmanage_TileButton.ImageZoom = 0;
            this.TODOmanage_TileButton.LabelPosition = 180;
            this.TODOmanage_TileButton.LabelText = "إدارة المهام";
            this.TODOmanage_TileButton.Location = new System.Drawing.Point(0, 0);
            this.TODOmanage_TileButton.Margin = new System.Windows.Forms.Padding(5);
            this.TODOmanage_TileButton.Name = "TODOmanage_TileButton";
            this.TODOmanage_TileButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TODOmanage_TileButton.Size = new System.Drawing.Size(150, 317);
            this.TODOmanage_TileButton.TabIndex = 45;
            this.TODOmanage_TileButton.Tag = this.TODO_manageTab;
            this.TODOmanage_TileButton.Click += new System.EventHandler(this.TileButton_Click);
            // 
            // UsrCtrl_Todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TileButtons_Panel);
            this.Controls.Add(this.todos_Tabcontrol);
            this.Name = "UsrCtrl_Todo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1926, 950);
            this.Enter += new System.EventHandler(this.UsrCtrl_customerservice_Enter);
            this.todos_Tabcontrol.ResumeLayout(false);
            this.TODO_manageTab.ResumeLayout(false);
            this.AddTodo_Groupbox.ResumeLayout(false);
            this.AddTodo_Groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Todos_chkpoint_list_Objectlistview)).EndInit();
            this.TODO_reqTab.ResumeLayout(false);
            this.History_Groupbox.ResumeLayout(false);
            this.History_Groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reqTODO_Objectlistview)).EndInit();
            this.TileButtons_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TransparentTabControl todos_Tabcontrol;
        private System.Windows.Forms.TabPage TODO_manageTab;
        private System.Windows.Forms.TabPage TODO_reqTab;
        private System.Windows.Forms.TabPage Bills_Tab;
        private System.Windows.Forms.Panel TileButtons_Panel;
        private ns1.BunifuTileButton TODOreq_TileButton;
        private ns1.BunifuTileButton Bills_TileButton;
        private System.Windows.Forms.Panel SidePanel1;
        private ns1.BunifuTileButton TODOmanage_TileButton;
        private System.Windows.Forms.GroupBox AddTodo_Groupbox;
        private System.Windows.Forms.Label TODO_due_date_Adj_Label;
        private System.Windows.Forms.Label TODO_category_Adj_Label;
        private System.Windows.Forms.Label TODO_dueto_Adj_Label;
        private System.Windows.Forms.Label TODO_name_Adj_Label;
        private System.Windows.Forms.Button Modify_TODO_Button;
        private System.Windows.Forms.Button Del_TODO_Button;
        private System.Windows.Forms.Label id_Label;
        private ModdedTextBox TODO_category_Textbox;
        private System.Windows.Forms.Label AddTODO_Label;
        private System.Windows.Forms.Button Add_TODO_Button;
        private ModdedTextBox TODO_notes_Textbox;
        private ModdedTextBox TODO_dueto_Textbox;
        private ModdedTextBox TODO_duefrom_Textbox;
        private System.Windows.Forms.DateTimePicker TODO_due_date_Datetimepicker;
        private System.Windows.Forms.Label TODO_notes_Adj_Label;
        private System.Windows.Forms.DateTimePicker TODO_done_date_Datetimepicker;
        private System.Windows.Forms.Label TODO_done_date_Adj_Label;
        private System.Windows.Forms.Label TODO_duration_value_Label;
        private System.Windows.Forms.Label TODO_duration_Adj_Label;
        private ModdedTextBox TODO_duration_Textbox;
        private System.Windows.Forms.Label TODO_todo_Adj_Label;
        private ModdedTextBox TODO_todo_Textbox;
        private ModdedTextBox TODO_id_Textbox;
        private System.Windows.Forms.DateTimePicker TODO_start_date_Datetimepicker;
        private System.Windows.Forms.Label TODO_start_date_Adj_Label;
        private System.Windows.Forms.GroupBox History_Groupbox;
        private System.Windows.Forms.Button TODO_SearchButton;
        private System.Windows.Forms.Label TODO_To_Adj_Label;
        private System.Windows.Forms.Label TODO_From_Adj_Label;
        private System.Windows.Forms.DateTimePicker TODO_To_Datetimepicker;
        private System.Windows.Forms.DateTimePicker TODO_From_Datetimepicker;
        private BrightIdeasSoftware.ObjectListView reqTODO_Objectlistview;
        private BrightIdeasSoftware.OLVColumn ReqTODO_Column;
        private BrightIdeasSoftware.OLVColumn finalTODO_Column;
        private BrightIdeasSoftware.OLVColumn categoryTODO_Column;
        private System.Windows.Forms.Label TODOs_chkpoint_list_Adj_Label;
        private BrightIdeasSoftware.ObjectListView Todos_chkpoint_list_Objectlistview;
        private BrightIdeasSoftware.OLVColumn ChkPnt_index_Column;
        private BrightIdeasSoftware.OLVColumn ChkPnt_name_Column;
        private BrightIdeasSoftware.OLVColumn ChkPnt_date_Column;
        private System.Windows.Forms.Button TODOs_AddChkPnt_Button;
        private System.Windows.Forms.Button TODOs_DelChkPnt_Button;
    }
}
