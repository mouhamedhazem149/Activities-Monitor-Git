using ModdedControls;

namespace DailyCompanionV2.User_Interfaces
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsrCtrl_Todo));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("مهام مقترحة", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("مهام مطلوبة", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("خيارات سابقة", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("مهام شبيهة");
            this.Aux_Panel = new System.Windows.Forms.Panel();
            this.aux_TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.TODO_AuxTo_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.DTPicker_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nowStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TODO_AuxFrom_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.TODO_AuxTo_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_AuxFrom_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_Aux_SearchButton = new System.Windows.Forms.Button();
            this.AuxComment_Label = new System.Windows.Forms.Label();
            this.auxContent_Panel = new System.Windows.Forms.Panel();
            this.TodoReq_Groupbox = new System.Windows.Forms.GroupBox();
            this.reqTODO_Objectlistview = new BrightIdeasSoftware.ObjectListView();
            this.ReqTODO_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.categoryTODO_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.finalTODO_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Timeline_Groupbox = new System.Windows.Forms.GroupBox();
            this.Timeline_Panel = new System.Windows.Forms.Panel();
            this.Todo_Timeline_Control = new MaterialWinforms.Controls.MaterialTimeline();
            this.AddTodo_Groupbox = new System.Windows.Forms.GroupBox();
            this.all_TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.TODO_notes_Textbox = new ModdedControls.ModdedTextBox();
            this.TODO_notes_Adj_Label = new System.Windows.Forms.Label();
            this.AddTODO_Label = new System.Windows.Forms.Label();
            this.Add_TODO_Button = new System.Windows.Forms.Button();
            this.TODO_duration_value_Label = new System.Windows.Forms.Label();
            this.TODO_start_date_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.TODO_due_date_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.TODO_duration_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_duration_Textbox = new ModdedControls.ModdedTextBox();
            this.TODO_done_date_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.TODO_done_date_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_due_date_Adj_Label = new System.Windows.Forms.Label();
            this.TODOs_chkpoint_list_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_start_date_Adj_Label = new System.Windows.Forms.Label();
            this.Todos_chkpoint_list_Objectlistview = new BrightIdeasSoftware.ObjectListView();
            this.ChkPnt_index_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ChkPnt_name_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ChkPnt_date_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TODOs_DelChkPnt_Button = new System.Windows.Forms.Button();
            this.TODOs_AddChkPnt_Button = new System.Windows.Forms.Button();
            this.TODO_category_Textbox = new ModdedControls.ModdedTextBox();
            this.TODO_todo_Textbox = new ModdedControls.ModdedTextBox();
            this.TODO_dueto_Textbox = new ModdedControls.ModdedTextBox();
            this.TODO_category_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_todo_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_dueto_Adj_Label = new System.Windows.Forms.Label();
            this.id_Label = new System.Windows.Forms.Label();
            this.TODO_id_Textbox = new ModdedControls.ModdedTextBox();
            this.TODO_name_Adj_Label = new System.Windows.Forms.Label();
            this.TODO_duefrom_Textbox = new ModdedControls.ModdedTextBox();
            this.Del_TODO_Button = new ns1.BunifuImageButton();
            this.UsrCtrl_TgleBtn = new CustomControls.RJControls.RJToggleButton();
            this.Tabcontrol_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.ReqTODOs_Button = new ns1.BunifuImageButton();
            this.Timeline_Button = new ns1.BunifuImageButton();
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.sidePanel_Treeview = new System.Windows.Forms.TreeView();
            this.Aux_Panel.SuspendLayout();
            this.aux_TablePanel.SuspendLayout();
            this.DTPicker_contextMenuStrip.SuspendLayout();
            this.auxContent_Panel.SuspendLayout();
            this.TodoReq_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reqTODO_Objectlistview)).BeginInit();
            this.Timeline_Groupbox.SuspendLayout();
            this.Timeline_Panel.SuspendLayout();
            this.AddTodo_Groupbox.SuspendLayout();
            this.all_TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Todos_chkpoint_list_Objectlistview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Del_TODO_Button)).BeginInit();
            this.Tabcontrol_contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_SplitContainer)).BeginInit();
            this.Main_SplitContainer.Panel1.SuspendLayout();
            this.Main_SplitContainer.Panel2.SuspendLayout();
            this.Main_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReqTODOs_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timeline_Button)).BeginInit();
            this.Side_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aux_Panel
            // 
            this.Aux_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Aux_Panel.Controls.Add(this.aux_TablePanel);
            this.Aux_Panel.Location = new System.Drawing.Point(111, 230);
            this.Aux_Panel.Name = "Aux_Panel";
            this.Aux_Panel.Size = new System.Drawing.Size(1364, 621);
            this.Aux_Panel.TabIndex = 75;
            this.Aux_Panel.Visible = false;
            this.Aux_Panel.Leave += new System.EventHandler(this.aux_Panel_Leave);
            // 
            // aux_TablePanel
            // 
            this.aux_TablePanel.ColumnCount = 33;
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.030302F));
            this.aux_TablePanel.Controls.Add(this.TODO_AuxTo_Datetimepicker, 15, 1);
            this.aux_TablePanel.Controls.Add(this.TODO_AuxFrom_Datetimepicker, 3, 1);
            this.aux_TablePanel.Controls.Add(this.TODO_AuxTo_Adj_Label, 14, 1);
            this.aux_TablePanel.Controls.Add(this.TODO_AuxFrom_Adj_Label, 2, 1);
            this.aux_TablePanel.Controls.Add(this.TODO_Aux_SearchButton, 27, 1);
            this.aux_TablePanel.Controls.Add(this.AuxComment_Label, 3, 4);
            this.aux_TablePanel.Controls.Add(this.auxContent_Panel, 0, 7);
            this.aux_TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aux_TablePanel.Location = new System.Drawing.Point(0, 0);
            this.aux_TablePanel.Name = "aux_TablePanel";
            this.aux_TablePanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aux_TablePanel.RowCount = 32;
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.4600919F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.4600919F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.400679F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.4600919F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.40068F));
            this.aux_TablePanel.Size = new System.Drawing.Size(1360, 617);
            this.aux_TablePanel.TabIndex = 21;
            // 
            // TODO_AuxTo_Datetimepicker
            // 
            this.TODO_AuxTo_Datetimepicker.CalendarFont = new System.Drawing.Font("El Messiri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aux_TablePanel.SetColumnSpan(this.TODO_AuxTo_Datetimepicker, 9);
            this.TODO_AuxTo_Datetimepicker.ContextMenuStrip = this.DTPicker_contextMenuStrip;
            this.TODO_AuxTo_Datetimepicker.Font = new System.Drawing.Font("El Messiri", 12F);
            this.TODO_AuxTo_Datetimepicker.Location = new System.Drawing.Point(388, 5);
            this.TODO_AuxTo_Datetimepicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TODO_AuxTo_Datetimepicker.Name = "TODO_AuxTo_Datetimepicker";
            this.aux_TablePanel.SetRowSpan(this.TODO_AuxTo_Datetimepicker, 2);
            this.TODO_AuxTo_Datetimepicker.Size = new System.Drawing.Size(355, 39);
            this.TODO_AuxTo_Datetimepicker.TabIndex = 15;
            this.TODO_AuxTo_Datetimepicker.Value = new System.DateTime(2025, 7, 2, 0, 0, 0, 0);
            // 
            // DTPicker_contextMenuStrip
            // 
            this.DTPicker_contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DTPicker_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowStripMenuItem});
            this.DTPicker_contextMenuStrip.Name = "DTPicker_contextMenuStrip";
            this.DTPicker_contextMenuStrip.Size = new System.Drawing.Size(110, 28);
            // 
            // nowStripMenuItem
            // 
            this.nowStripMenuItem.Name = "nowStripMenuItem";
            this.nowStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.nowStripMenuItem.Text = "Now";
            this.nowStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nowStripMenuItem_MouseDown);
            // 
            // TODO_AuxFrom_Datetimepicker
            // 
            this.TODO_AuxFrom_Datetimepicker.CalendarFont = new System.Drawing.Font("El Messiri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aux_TablePanel.SetColumnSpan(this.TODO_AuxFrom_Datetimepicker, 9);
            this.TODO_AuxFrom_Datetimepicker.ContextMenuStrip = this.DTPicker_contextMenuStrip;
            this.TODO_AuxFrom_Datetimepicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_AuxFrom_Datetimepicker.Font = new System.Drawing.Font("El Messiri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODO_AuxFrom_Datetimepicker.Location = new System.Drawing.Point(870, 5);
            this.TODO_AuxFrom_Datetimepicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TODO_AuxFrom_Datetimepicker.Name = "TODO_AuxFrom_Datetimepicker";
            this.aux_TablePanel.SetRowSpan(this.TODO_AuxFrom_Datetimepicker, 2);
            this.TODO_AuxFrom_Datetimepicker.Size = new System.Drawing.Size(365, 39);
            this.TODO_AuxFrom_Datetimepicker.TabIndex = 14;
            this.TODO_AuxFrom_Datetimepicker.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            // 
            // TODO_AuxTo_Adj_Label
            // 
            this.TODO_AuxTo_Adj_Label.AutoSize = true;
            this.TODO_AuxTo_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_AuxTo_Adj_Label.Font = new System.Drawing.Font("El Messiri", 11F);
            this.TODO_AuxTo_Adj_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.TODO_AuxTo_Adj_Label.Location = new System.Drawing.Point(747, 2);
            this.TODO_AuxTo_Adj_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TODO_AuxTo_Adj_Label.Name = "TODO_AuxTo_Adj_Label";
            this.aux_TablePanel.SetRowSpan(this.TODO_AuxTo_Adj_Label, 2);
            this.TODO_AuxTo_Adj_Label.Size = new System.Drawing.Size(37, 40);
            this.TODO_AuxTo_Adj_Label.TabIndex = 17;
            this.TODO_AuxTo_Adj_Label.Text = "إلى";
            this.TODO_AuxTo_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TODO_AuxFrom_Adj_Label
            // 
            this.TODO_AuxFrom_Adj_Label.AutoSize = true;
            this.TODO_AuxFrom_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_AuxFrom_Adj_Label.Font = new System.Drawing.Font("El Messiri", 11F);
            this.TODO_AuxFrom_Adj_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.TODO_AuxFrom_Adj_Label.Location = new System.Drawing.Point(1239, 2);
            this.TODO_AuxFrom_Adj_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TODO_AuxFrom_Adj_Label.Name = "TODO_AuxFrom_Adj_Label";
            this.aux_TablePanel.SetRowSpan(this.TODO_AuxFrom_Adj_Label, 2);
            this.TODO_AuxFrom_Adj_Label.Size = new System.Drawing.Size(37, 40);
            this.TODO_AuxFrom_Adj_Label.TabIndex = 16;
            this.TODO_AuxFrom_Adj_Label.Text = "من";
            this.TODO_AuxFrom_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TODO_Aux_SearchButton
            // 
            this.aux_TablePanel.SetColumnSpan(this.TODO_Aux_SearchButton, 4);
            this.TODO_Aux_SearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_Aux_SearchButton.Font = new System.Drawing.Font("El Messiri", 12F);
            this.TODO_Aux_SearchButton.ForeColor = System.Drawing.Color.DarkRed;
            this.TODO_Aux_SearchButton.Location = new System.Drawing.Point(91, 5);
            this.TODO_Aux_SearchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TODO_Aux_SearchButton.Name = "TODO_Aux_SearchButton";
            this.aux_TablePanel.SetRowSpan(this.TODO_Aux_SearchButton, 2);
            this.TODO_Aux_SearchButton.Size = new System.Drawing.Size(160, 34);
            this.TODO_Aux_SearchButton.TabIndex = 18;
            this.TODO_Aux_SearchButton.Text = "بحث";
            this.TODO_Aux_SearchButton.UseVisualStyleBackColor = true;
            this.TODO_Aux_SearchButton.Click += new System.EventHandler(this.TODO_SearchButton_Click);
            // 
            // AuxComment_Label
            // 
            this.aux_TablePanel.SetColumnSpan(this.AuxComment_Label, 28);
            this.AuxComment_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuxComment_Label.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuxComment_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.AuxComment_Label.Location = new System.Drawing.Point(92, 44);
            this.AuxComment_Label.Name = "AuxComment_Label";
            this.AuxComment_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aux_TablePanel.SetRowSpan(this.AuxComment_Label, 2);
            this.AuxComment_Label.Size = new System.Drawing.Size(1142, 40);
            this.AuxComment_Label.TabIndex = 20;
            this.AuxComment_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // auxContent_Panel
            // 
            this.aux_TablePanel.SetColumnSpan(this.auxContent_Panel, 33);
            this.auxContent_Panel.Controls.Add(this.TodoReq_Groupbox);
            this.auxContent_Panel.Controls.Add(this.Timeline_Groupbox);
            this.auxContent_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auxContent_Panel.Location = new System.Drawing.Point(3, 89);
            this.auxContent_Panel.Name = "auxContent_Panel";
            this.aux_TablePanel.SetRowSpan(this.auxContent_Panel, 25);
            this.auxContent_Panel.Size = new System.Drawing.Size(1354, 525);
            this.auxContent_Panel.TabIndex = 21;
            // 
            // TodoReq_Groupbox
            // 
            this.TodoReq_Groupbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TodoReq_Groupbox.Controls.Add(this.reqTODO_Objectlistview);
            this.TodoReq_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodoReq_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.TodoReq_Groupbox.Location = new System.Drawing.Point(-132, 14);
            this.TodoReq_Groupbox.Name = "TodoReq_Groupbox";
            this.TodoReq_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TodoReq_Groupbox.Size = new System.Drawing.Size(1478, 500);
            this.TodoReq_Groupbox.TabIndex = 11;
            this.TodoReq_Groupbox.TabStop = false;
            this.TodoReq_Groupbox.Text = "تاريخ العمليات";
            this.TodoReq_Groupbox.Visible = false;
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
            this.reqTODO_Objectlistview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reqTODO_Objectlistview.Font = new System.Drawing.Font("El Messiri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqTODO_Objectlistview.FullRowSelect = true;
            this.reqTODO_Objectlistview.HideSelection = false;
            this.reqTODO_Objectlistview.Location = new System.Drawing.Point(3, 39);
            this.reqTODO_Objectlistview.Name = "reqTODO_Objectlistview";
            this.reqTODO_Objectlistview.RightToLeftLayout = true;
            this.reqTODO_Objectlistview.SelectColumnsOnRightClick = false;
            this.reqTODO_Objectlistview.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.reqTODO_Objectlistview.ShowCommandMenuOnRightClick = true;
            this.reqTODO_Objectlistview.ShowItemCountOnGroups = true;
            this.reqTODO_Objectlistview.Size = new System.Drawing.Size(1472, 458);
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
            // Timeline_Groupbox
            // 
            this.Timeline_Groupbox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Timeline_Groupbox.Controls.Add(this.Timeline_Panel);
            this.Timeline_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timeline_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.Timeline_Groupbox.Location = new System.Drawing.Point(-129, 14);
            this.Timeline_Groupbox.Name = "Timeline_Groupbox";
            this.Timeline_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Timeline_Groupbox.Size = new System.Drawing.Size(1475, 500);
            this.Timeline_Groupbox.TabIndex = 12;
            this.Timeline_Groupbox.TabStop = false;
            this.Timeline_Groupbox.Text = "خط زمني";
            this.Timeline_Groupbox.Visible = false;
            // 
            // Timeline_Panel
            // 
            this.Timeline_Panel.AutoScroll = true;
            this.Timeline_Panel.Controls.Add(this.Todo_Timeline_Control);
            this.Timeline_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Timeline_Panel.Location = new System.Drawing.Point(3, 39);
            this.Timeline_Panel.Name = "Timeline_Panel";
            this.Timeline_Panel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Timeline_Panel.Size = new System.Drawing.Size(1469, 458);
            this.Timeline_Panel.TabIndex = 21;
            // 
            // Todo_Timeline_Control
            // 
            this.Todo_Timeline_Control.AufsteigendSortieren = false;
            this.Todo_Timeline_Control.Depth = 0;
            this.Todo_Timeline_Control.Location = new System.Drawing.Point(13, 7);
            this.Todo_Timeline_Control.MouseState = MaterialWinforms.MouseState.HOVER;
            this.Todo_Timeline_Control.Name = "Todo_Timeline_Control";
            this.Todo_Timeline_Control.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Todo_Timeline_Control.Size = new System.Drawing.Size(1450, 716);
            this.Todo_Timeline_Control.TabIndex = 19;
            this.Todo_Timeline_Control.Text = "materialTimeline1";
            // 
            // AddTodo_Groupbox
            // 
            this.AddTodo_Groupbox.Controls.Add(this.all_TablePanel);
            this.AddTodo_Groupbox.Controls.Add(this.UsrCtrl_TgleBtn);
            this.AddTodo_Groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddTodo_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTodo_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.AddTodo_Groupbox.Location = new System.Drawing.Point(0, 0);
            this.AddTodo_Groupbox.Name = "AddTodo_Groupbox";
            this.AddTodo_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddTodo_Groupbox.Size = new System.Drawing.Size(1375, 851);
            this.AddTodo_Groupbox.TabIndex = 1;
            this.AddTodo_Groupbox.TabStop = false;
            this.AddTodo_Groupbox.Tag = this.Add_TODO_Button;
            this.AddTodo_Groupbox.Text = "إضافة مهام";
            // 
            // all_TablePanel
            // 
            this.all_TablePanel.AutoSize = true;
            this.all_TablePanel.ColumnCount = 65;
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538461F));
            this.all_TablePanel.Controls.Add(this.TODO_notes_Textbox, 34, 22);
            this.all_TablePanel.Controls.Add(this.TODO_notes_Adj_Label, 34, 20);
            this.all_TablePanel.Controls.Add(this.AddTODO_Label, 2, 40);
            this.all_TablePanel.Controls.Add(this.Add_TODO_Button, 55, 41);
            this.all_TablePanel.Controls.Add(this.TODO_duration_value_Label, 8, 18);
            this.all_TablePanel.Controls.Add(this.TODO_start_date_Datetimepicker, 8, 12);
            this.all_TablePanel.Controls.Add(this.TODO_due_date_Datetimepicker, 36, 12);
            this.all_TablePanel.Controls.Add(this.TODO_duration_Adj_Label, 1, 16);
            this.all_TablePanel.Controls.Add(this.TODO_duration_Textbox, 8, 16);
            this.all_TablePanel.Controls.Add(this.TODO_done_date_Datetimepicker, 8, 14);
            this.all_TablePanel.Controls.Add(this.TODO_done_date_Adj_Label, 1, 14);
            this.all_TablePanel.Controls.Add(this.TODO_due_date_Adj_Label, 33, 12);
            this.all_TablePanel.Controls.Add(this.TODOs_chkpoint_list_Adj_Label, 0, 20);
            this.all_TablePanel.Controls.Add(this.TODO_start_date_Adj_Label, 1, 12);
            this.all_TablePanel.Controls.Add(this.Todos_chkpoint_list_Objectlistview, 0, 22);
            this.all_TablePanel.Controls.Add(this.TODOs_DelChkPnt_Button, 11, 37);
            this.all_TablePanel.Controls.Add(this.TODOs_AddChkPnt_Button, 22, 37);
            this.all_TablePanel.Controls.Add(this.TODO_category_Textbox, 6, 6);
            this.all_TablePanel.Controls.Add(this.TODO_todo_Textbox, 6, 9);
            this.all_TablePanel.Controls.Add(this.TODO_dueto_Textbox, 6, 3);
            this.all_TablePanel.Controls.Add(this.TODO_category_Adj_Label, 0, 6);
            this.all_TablePanel.Controls.Add(this.TODO_todo_Adj_Label, 0, 9);
            this.all_TablePanel.Controls.Add(this.TODO_dueto_Adj_Label, 0, 3);
            this.all_TablePanel.Controls.Add(this.id_Label, 45, 2);
            this.all_TablePanel.Controls.Add(this.TODO_id_Textbox, 45, 0);
            this.all_TablePanel.Controls.Add(this.TODO_name_Adj_Label, 0, 0);
            this.all_TablePanel.Controls.Add(this.TODO_duefrom_Textbox, 6, 0);
            this.all_TablePanel.Controls.Add(this.Del_TODO_Button, 62, 0);
            this.all_TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.all_TablePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.all_TablePanel.Location = new System.Drawing.Point(3, 39);
            this.all_TablePanel.Name = "all_TablePanel";
            this.all_TablePanel.RowCount = 43;
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.Size = new System.Drawing.Size(1369, 809);
            this.all_TablePanel.TabIndex = 92;
            // 
            // TODO_notes_Textbox
            // 
            this.all_TablePanel.SetColumnSpan(this.TODO_notes_Textbox, 31);
            this.TODO_notes_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_notes_Textbox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODO_notes_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.TODO_notes_Textbox.IsPasswordTextbox = false;
            this.TODO_notes_Textbox.IsPlaceholder = true;
            this.TODO_notes_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODO_notes_Textbox.Location = new System.Drawing.Point(3, 379);
            this.TODO_notes_Textbox.Multiline = true;
            this.TODO_notes_Textbox.Name = "TODO_notes_Textbox";
            this.TODO_notes_Textbox.Placeholder = "ملاحظات";
            this.TODO_notes_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.TODO_notes_Textbox.placeholderFont = null;
            this.TODO_notes_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_TablePanel.SetRowSpan(this.TODO_notes_Textbox, 17);
            this.TODO_notes_Textbox.SelectedItem = null;
            this.TODO_notes_Textbox.Size = new System.Drawing.Size(649, 317);
            this.TODO_notes_Textbox.TabIndex = 9;
            this.TODO_notes_Textbox.Tag = "";
            this.TODO_notes_Textbox.Text = "لا يوجد ملاحظات";
            this.TODO_notes_Textbox.Values = null;
            this.TODO_notes_Textbox.Visible_Password_Button = false;
            this.TODO_notes_Textbox.Enter += new System.EventHandler(this.TODO_Textbox_Enter);
            // 
            // TODO_notes_Adj_Label
            // 
            this.TODO_notes_Adj_Label.AutoSize = true;
            this.all_TablePanel.SetColumnSpan(this.TODO_notes_Adj_Label, 6);
            this.TODO_notes_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_notes_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.TODO_notes_Adj_Label.Location = new System.Drawing.Point(532, 338);
            this.TODO_notes_Adj_Label.Name = "TODO_notes_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.TODO_notes_Adj_Label, 2);
            this.TODO_notes_Adj_Label.Size = new System.Drawing.Size(120, 38);
            this.TODO_notes_Adj_Label.TabIndex = 64;
            this.TODO_notes_Adj_Label.Text = "ملاحظات";
            this.TODO_notes_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddTODO_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.AddTODO_Label, 48);
            this.AddTODO_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddTODO_Label.Font = new System.Drawing.Font("El Messiri", 11.8F);
            this.AddTODO_Label.Location = new System.Drawing.Point(322, 718);
            this.AddTODO_Label.Name = "AddTODO_Label";
            this.all_TablePanel.SetRowSpan(this.AddTODO_Label, 2);
            this.AddTODO_Label.Size = new System.Drawing.Size(1002, 38);
            this.AddTODO_Label.TabIndex = 41;
            this.AddTODO_Label.Text = "message label";
            this.AddTODO_Label.Visible = false;
            // 
            // Add_TODO_Button
            // 
            this.Add_TODO_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.all_TablePanel.SetColumnSpan(this.Add_TODO_Button, 10);
            this.Add_TODO_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_TODO_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_TODO_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_TODO_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Add_TODO_Button.Location = new System.Drawing.Point(3, 740);
            this.Add_TODO_Button.Name = "Add_TODO_Button";
            this.all_TablePanel.SetRowSpan(this.Add_TODO_Button, 2);
            this.Add_TODO_Button.Size = new System.Drawing.Size(208, 66);
            this.Add_TODO_Button.TabIndex = 34;
            this.Add_TODO_Button.Text = "إضافة مهام";
            this.Add_TODO_Button.UseVisualStyleBackColor = false;
            this.Add_TODO_Button.Click += new System.EventHandler(this.TODO_Button_Click);
            // 
            // TODO_duration_value_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.TODO_duration_value_Label, 24);
            this.TODO_duration_value_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_duration_value_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_duration_value_Label.Location = new System.Drawing.Point(700, 300);
            this.TODO_duration_value_Label.Name = "TODO_duration_value_Label";
            this.TODO_duration_value_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_TablePanel.SetRowSpan(this.TODO_duration_value_Label, 2);
            this.TODO_duration_value_Label.Size = new System.Drawing.Size(498, 38);
            this.TODO_duration_value_Label.TabIndex = 71;
            // 
            // TODO_start_date_Datetimepicker
            // 
            this.TODO_start_date_Datetimepicker.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F);
            this.all_TablePanel.SetColumnSpan(this.TODO_start_date_Datetimepicker, 24);
            this.TODO_start_date_Datetimepicker.ContextMenuStrip = this.DTPicker_contextMenuStrip;
            this.TODO_start_date_Datetimepicker.CustomFormat = "dddd, dd-MMMM-yyyy -- hh:mm tt";
            this.TODO_start_date_Datetimepicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_start_date_Datetimepicker.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.TODO_start_date_Datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TODO_start_date_Datetimepicker.Location = new System.Drawing.Point(700, 189);
            this.TODO_start_date_Datetimepicker.Name = "TODO_start_date_Datetimepicker";
            this.all_TablePanel.SetRowSpan(this.TODO_start_date_Datetimepicker, 2);
            this.TODO_start_date_Datetimepicker.Size = new System.Drawing.Size(498, 34);
            this.TODO_start_date_Datetimepicker.TabIndex = 5;
            this.TODO_start_date_Datetimepicker.ValueChanged += new System.EventHandler(this.TODO_Datetimepicker_ValueChanged);
            // 
            // TODO_due_date_Datetimepicker
            // 
            this.TODO_due_date_Datetimepicker.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F);
            this.all_TablePanel.SetColumnSpan(this.TODO_due_date_Datetimepicker, 24);
            this.TODO_due_date_Datetimepicker.ContextMenuStrip = this.DTPicker_contextMenuStrip;
            this.TODO_due_date_Datetimepicker.CustomFormat = "dddd, dd-MMMM-yyyy -- hh:mm tt";
            this.TODO_due_date_Datetimepicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_due_date_Datetimepicker.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.TODO_due_date_Datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TODO_due_date_Datetimepicker.Location = new System.Drawing.Point(28, 189);
            this.TODO_due_date_Datetimepicker.Name = "TODO_due_date_Datetimepicker";
            this.all_TablePanel.SetRowSpan(this.TODO_due_date_Datetimepicker, 2);
            this.TODO_due_date_Datetimepicker.Size = new System.Drawing.Size(498, 34);
            this.TODO_due_date_Datetimepicker.TabIndex = 6;
            // 
            // TODO_duration_Adj_Label
            // 
            this.TODO_duration_Adj_Label.AutoSize = true;
            this.all_TablePanel.SetColumnSpan(this.TODO_duration_Adj_Label, 7);
            this.TODO_duration_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_duration_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_duration_Adj_Label.Location = new System.Drawing.Point(1204, 262);
            this.TODO_duration_Adj_Label.Name = "TODO_duration_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.TODO_duration_Adj_Label, 2);
            this.TODO_duration_Adj_Label.Size = new System.Drawing.Size(141, 38);
            this.TODO_duration_Adj_Label.TabIndex = 70;
            this.TODO_duration_Adj_Label.Text = "الوقت المستغرق (بالدقائق)";
            this.TODO_duration_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TODO_duration_Textbox
            // 
            this.all_TablePanel.SetColumnSpan(this.TODO_duration_Textbox, 24);
            this.TODO_duration_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_duration_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TODO_duration_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.TODO_duration_Textbox.IsPasswordTextbox = false;
            this.TODO_duration_Textbox.IsPlaceholder = true;
            this.TODO_duration_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODO_duration_Textbox.Location = new System.Drawing.Point(700, 265);
            this.TODO_duration_Textbox.Name = "TODO_duration_Textbox";
            this.TODO_duration_Textbox.Placeholder = "الوقت المستغرق";
            this.TODO_duration_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.TODO_duration_Textbox.placeholderFont = null;
            this.TODO_duration_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.all_TablePanel.SetRowSpan(this.TODO_duration_Textbox, 2);
            this.TODO_duration_Textbox.SelectedItem = null;
            this.TODO_duration_Textbox.Size = new System.Drawing.Size(498, 38);
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
            this.all_TablePanel.SetColumnSpan(this.TODO_done_date_Datetimepicker, 26);
            this.TODO_done_date_Datetimepicker.ContextMenuStrip = this.DTPicker_contextMenuStrip;
            this.TODO_done_date_Datetimepicker.CustomFormat = "dddd, dd-MMMM-yyyy -- hh:mm tt";
            this.TODO_done_date_Datetimepicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_done_date_Datetimepicker.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.TODO_done_date_Datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TODO_done_date_Datetimepicker.Location = new System.Drawing.Point(658, 227);
            this.TODO_done_date_Datetimepicker.Name = "TODO_done_date_Datetimepicker";
            this.all_TablePanel.SetRowSpan(this.TODO_done_date_Datetimepicker, 2);
            this.TODO_done_date_Datetimepicker.ShowCheckBox = true;
            this.TODO_done_date_Datetimepicker.Size = new System.Drawing.Size(540, 34);
            this.TODO_done_date_Datetimepicker.TabIndex = 7;
            this.TODO_done_date_Datetimepicker.ValueChanged += new System.EventHandler(this.TODO_Datetimepicker_ValueChanged);
            // 
            // TODO_done_date_Adj_Label
            // 
            this.TODO_done_date_Adj_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TODO_done_date_Adj_Label.AutoSize = true;
            this.all_TablePanel.SetColumnSpan(this.TODO_done_date_Adj_Label, 7);
            this.TODO_done_date_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_done_date_Adj_Label.Location = new System.Drawing.Point(1204, 229);
            this.TODO_done_date_Adj_Label.Name = "TODO_done_date_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.TODO_done_date_Adj_Label, 2);
            this.TODO_done_date_Adj_Label.Size = new System.Drawing.Size(141, 27);
            this.TODO_done_date_Adj_Label.TabIndex = 67;
            this.TODO_done_date_Adj_Label.Text = "موعد الإنهاء";
            this.TODO_done_date_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TODO_due_date_Adj_Label
            // 
            this.TODO_due_date_Adj_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TODO_due_date_Adj_Label.AutoSize = true;
            this.all_TablePanel.SetColumnSpan(this.TODO_due_date_Adj_Label, 7);
            this.TODO_due_date_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_due_date_Adj_Label.Location = new System.Drawing.Point(532, 191);
            this.TODO_due_date_Adj_Label.Name = "TODO_due_date_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.TODO_due_date_Adj_Label, 2);
            this.TODO_due_date_Adj_Label.Size = new System.Drawing.Size(141, 27);
            this.TODO_due_date_Adj_Label.TabIndex = 63;
            this.TODO_due_date_Adj_Label.Text = "الموعد النهائي";
            this.TODO_due_date_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TODOs_chkpoint_list_Adj_Label
            // 
            this.TODOs_chkpoint_list_Adj_Label.AutoSize = true;
            this.all_TablePanel.SetColumnSpan(this.TODOs_chkpoint_list_Adj_Label, 6);
            this.TODOs_chkpoint_list_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODOs_chkpoint_list_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.TODOs_chkpoint_list_Adj_Label.Location = new System.Drawing.Point(1246, 338);
            this.TODOs_chkpoint_list_Adj_Label.Name = "TODOs_chkpoint_list_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.TODOs_chkpoint_list_Adj_Label, 2);
            this.TODOs_chkpoint_list_Adj_Label.Size = new System.Drawing.Size(120, 38);
            this.TODOs_chkpoint_list_Adj_Label.TabIndex = 78;
            this.TODOs_chkpoint_list_Adj_Label.Text = "نقاط فاصلة";
            this.TODOs_chkpoint_list_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TODO_start_date_Adj_Label
            // 
            this.TODO_start_date_Adj_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TODO_start_date_Adj_Label.AutoSize = true;
            this.all_TablePanel.SetColumnSpan(this.TODO_start_date_Adj_Label, 7);
            this.TODO_start_date_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_start_date_Adj_Label.Location = new System.Drawing.Point(1204, 191);
            this.TODO_start_date_Adj_Label.Name = "TODO_start_date_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.TODO_start_date_Adj_Label, 2);
            this.TODO_start_date_Adj_Label.Size = new System.Drawing.Size(141, 27);
            this.TODO_start_date_Adj_Label.TabIndex = 76;
            this.TODO_start_date_Adj_Label.Text = "موعد البداية";
            this.TODO_start_date_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.all_TablePanel.SetColumnSpan(this.Todos_chkpoint_list_Objectlistview, 33);
            this.Todos_chkpoint_list_Objectlistview.Cursor = System.Windows.Forms.Cursors.Default;
            this.Todos_chkpoint_list_Objectlistview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Todos_chkpoint_list_Objectlistview.EmptyListMsg = "لا يوجد عناصر";
            this.Todos_chkpoint_list_Objectlistview.EmptyListMsgFont = new System.Drawing.Font("Cairo SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.Todos_chkpoint_list_Objectlistview.Font = new System.Drawing.Font("El Messiri", 7.8F);
            this.Todos_chkpoint_list_Objectlistview.FullRowSelect = true;
            this.Todos_chkpoint_list_Objectlistview.HideSelection = false;
            this.Todos_chkpoint_list_Objectlistview.Location = new System.Drawing.Point(679, 378);
            this.Todos_chkpoint_list_Objectlistview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Todos_chkpoint_list_Objectlistview.Name = "Todos_chkpoint_list_Objectlistview";
            this.Todos_chkpoint_list_Objectlistview.RightToLeftLayout = true;
            this.all_TablePanel.SetRowSpan(this.Todos_chkpoint_list_Objectlistview, 15);
            this.Todos_chkpoint_list_Objectlistview.ShowCommandMenuOnRightClick = true;
            this.Todos_chkpoint_list_Objectlistview.ShowFilterMenuOnRightClick = false;
            this.Todos_chkpoint_list_Objectlistview.Size = new System.Drawing.Size(687, 281);
            this.Todos_chkpoint_list_Objectlistview.SortGroupItemsByPrimaryColumn = false;
            this.Todos_chkpoint_list_Objectlistview.SpaceBetweenGroups = 5;
            this.Todos_chkpoint_list_Objectlistview.TabIndex = 10;
            this.Todos_chkpoint_list_Objectlistview.TintSortColumn = true;
            this.Todos_chkpoint_list_Objectlistview.UseCompatibleStateImageBehavior = false;
            this.Todos_chkpoint_list_Objectlistview.UseFilterIndicator = true;
            this.Todos_chkpoint_list_Objectlistview.UseFiltering = true;
            this.Todos_chkpoint_list_Objectlistview.UseHotControls = false;
            this.Todos_chkpoint_list_Objectlistview.View = System.Windows.Forms.View.Details;
            this.Todos_chkpoint_list_Objectlistview.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.Todos_chkpoint_list_Objectlistview_CellEditFinishing);
            this.Todos_chkpoint_list_Objectlistview.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.Todos_chkpoint_list_Objectlistview_CellEditStarting);
            this.Todos_chkpoint_list_Objectlistview.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.Todos_chkpoint_list_Objectlistview_ItemsChanged);
            this.Todos_chkpoint_list_Objectlistview.SelectionChanged += new System.EventHandler(this.Todos_chkpoint_list_Objectlistview_SelectionChanged);
            // 
            // ChkPnt_index_Column
            // 
            this.ChkPnt_index_Column.AspectName = "index";
            this.ChkPnt_index_Column.Hideable = false;
            this.ChkPnt_index_Column.IsEditable = false;
            this.ChkPnt_index_Column.MinimumWidth = 30;
            this.ChkPnt_index_Column.Tag = "string";
            this.ChkPnt_index_Column.Text = "م";
            this.ChkPnt_index_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChkPnt_index_Column.Width = 30;
            // 
            // ChkPnt_name_Column
            // 
            this.ChkPnt_name_Column.AspectName = "ChkName";
            this.ChkPnt_name_Column.Hideable = false;
            this.ChkPnt_name_Column.MinimumWidth = 285;
            this.ChkPnt_name_Column.Tag = "string";
            this.ChkPnt_name_Column.Text = "نقطة فاصلة";
            this.ChkPnt_name_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChkPnt_name_Column.Width = 285;
            // 
            // ChkPnt_date_Column
            // 
            this.ChkPnt_date_Column.AspectName = "Chk_Date";
            this.ChkPnt_date_Column.AspectToStringFormat = "{0: dddd, dd-MMMM-yyyy -- hh:mm tt}";
            this.ChkPnt_date_Column.Hideable = false;
            this.ChkPnt_date_Column.MinimumWidth = 230;
            this.ChkPnt_date_Column.Tag = "date";
            this.ChkPnt_date_Column.Text = "التاريخ";
            this.ChkPnt_date_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChkPnt_date_Column.Width = 230;
            // 
            // TODOs_DelChkPnt_Button
            // 
            this.TODOs_DelChkPnt_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.all_TablePanel.SetColumnSpan(this.TODOs_DelChkPnt_Button, 11);
            this.TODOs_DelChkPnt_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODOs_DelChkPnt_Button.Enabled = false;
            this.TODOs_DelChkPnt_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TODOs_DelChkPnt_Button.Font = new System.Drawing.Font("El Messiri", 10.8F);
            this.TODOs_DelChkPnt_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TODOs_DelChkPnt_Button.Location = new System.Drawing.Point(910, 664);
            this.TODOs_DelChkPnt_Button.Name = "TODOs_DelChkPnt_Button";
            this.all_TablePanel.SetRowSpan(this.TODOs_DelChkPnt_Button, 2);
            this.TODOs_DelChkPnt_Button.Size = new System.Drawing.Size(225, 32);
            this.TODOs_DelChkPnt_Button.TabIndex = 80;
            this.TODOs_DelChkPnt_Button.Text = "حذف المحدد";
            this.TODOs_DelChkPnt_Button.UseVisualStyleBackColor = false;
            this.TODOs_DelChkPnt_Button.Click += new System.EventHandler(this.TODOs_DelChkPnt_Button_Click);
            // 
            // TODOs_AddChkPnt_Button
            // 
            this.TODOs_AddChkPnt_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.all_TablePanel.SetColumnSpan(this.TODOs_AddChkPnt_Button, 11);
            this.TODOs_AddChkPnt_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODOs_AddChkPnt_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TODOs_AddChkPnt_Button.Font = new System.Drawing.Font("El Messiri", 10.8F);
            this.TODOs_AddChkPnt_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TODOs_AddChkPnt_Button.Location = new System.Drawing.Point(679, 664);
            this.TODOs_AddChkPnt_Button.Name = "TODOs_AddChkPnt_Button";
            this.all_TablePanel.SetRowSpan(this.TODOs_AddChkPnt_Button, 2);
            this.TODOs_AddChkPnt_Button.Size = new System.Drawing.Size(225, 32);
            this.TODOs_AddChkPnt_Button.TabIndex = 79;
            this.TODOs_AddChkPnt_Button.Text = "إضافة نقطة فاصلة";
            this.TODOs_AddChkPnt_Button.UseVisualStyleBackColor = false;
            this.TODOs_AddChkPnt_Button.Click += new System.EventHandler(this.TODOs_AddChkPnt_Button_Click);
            // 
            // TODO_category_Textbox
            // 
            this.all_TablePanel.SetColumnSpan(this.TODO_category_Textbox, 38);
            this.TODO_category_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_category_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TODO_category_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.TODO_category_Textbox.IsPasswordTextbox = false;
            this.TODO_category_Textbox.IsPlaceholder = true;
            this.TODO_category_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODO_category_Textbox.Location = new System.Drawing.Point(448, 89);
            this.TODO_category_Textbox.Name = "TODO_category_Textbox";
            this.TODO_category_Textbox.Placeholder = "التصنيف";
            this.TODO_category_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.TODO_category_Textbox.placeholderFont = null;
            this.TODO_category_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_TablePanel.SetRowSpan(this.TODO_category_Textbox, 2);
            this.TODO_category_Textbox.SelectedItem = null;
            this.TODO_category_Textbox.Size = new System.Drawing.Size(792, 38);
            this.TODO_category_Textbox.TabIndex = 3;
            this.TODO_category_Textbox.Tag = "";
            this.TODO_category_Textbox.Text = "التصنيف";
            this.TODO_category_Textbox.Values = null;
            this.TODO_category_Textbox.Visible_Password_Button = false;
            this.TODO_category_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.TODO_Textbox_cmnFlr_SelectedItemChanged);
            this.TODO_category_Textbox.Enter += new System.EventHandler(this.TODO_Textbox_Enter);
            // 
            // TODO_todo_Textbox
            // 
            this.all_TablePanel.SetColumnSpan(this.TODO_todo_Textbox, 38);
            this.TODO_todo_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_todo_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TODO_todo_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.TODO_todo_Textbox.IsPasswordTextbox = false;
            this.TODO_todo_Textbox.IsPlaceholder = true;
            this.TODO_todo_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODO_todo_Textbox.Location = new System.Drawing.Point(448, 132);
            this.TODO_todo_Textbox.Name = "TODO_todo_Textbox";
            this.TODO_todo_Textbox.Placeholder = "المهمة";
            this.TODO_todo_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.TODO_todo_Textbox.placeholderFont = null;
            this.TODO_todo_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_TablePanel.SetRowSpan(this.TODO_todo_Textbox, 2);
            this.TODO_todo_Textbox.SelectedItem = null;
            this.TODO_todo_Textbox.Size = new System.Drawing.Size(792, 38);
            this.TODO_todo_Textbox.TabIndex = 4;
            this.TODO_todo_Textbox.Tag = "";
            this.TODO_todo_Textbox.Text = "المهمة";
            this.TODO_todo_Textbox.Values = null;
            this.TODO_todo_Textbox.Visible_Password_Button = false;
            this.TODO_todo_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.TODO_Textbox_cmnFlr_SelectedItemChanged);
            this.TODO_todo_Textbox.Enter += new System.EventHandler(this.TODO_Textbox_Enter);
            // 
            // TODO_dueto_Textbox
            // 
            this.all_TablePanel.SetColumnSpan(this.TODO_dueto_Textbox, 38);
            this.TODO_dueto_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_dueto_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TODO_dueto_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.TODO_dueto_Textbox.IsPasswordTextbox = false;
            this.TODO_dueto_Textbox.IsPlaceholder = true;
            this.TODO_dueto_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODO_dueto_Textbox.Location = new System.Drawing.Point(448, 46);
            this.TODO_dueto_Textbox.Name = "TODO_dueto_Textbox";
            this.TODO_dueto_Textbox.Placeholder = "الجهة المطلوب لها";
            this.TODO_dueto_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.TODO_dueto_Textbox.placeholderFont = null;
            this.TODO_dueto_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_TablePanel.SetRowSpan(this.TODO_dueto_Textbox, 2);
            this.TODO_dueto_Textbox.SelectedItem = null;
            this.TODO_dueto_Textbox.Size = new System.Drawing.Size(792, 38);
            this.TODO_dueto_Textbox.TabIndex = 2;
            this.TODO_dueto_Textbox.Tag = "";
            this.TODO_dueto_Textbox.Text = "الجهة المطلوب لها";
            this.TODO_dueto_Textbox.Values = null;
            this.TODO_dueto_Textbox.Visible_Password_Button = false;
            this.TODO_dueto_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.TODO_Textbox_cmnFlr_SelectedItemChanged);
            this.TODO_dueto_Textbox.Enter += new System.EventHandler(this.TODO_Textbox_Enter);
            // 
            // TODO_category_Adj_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.TODO_category_Adj_Label, 6);
            this.TODO_category_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_category_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_category_Adj_Label.Location = new System.Drawing.Point(1246, 86);
            this.TODO_category_Adj_Label.Name = "TODO_category_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.TODO_category_Adj_Label, 2);
            this.TODO_category_Adj_Label.Size = new System.Drawing.Size(120, 38);
            this.TODO_category_Adj_Label.TabIndex = 62;
            this.TODO_category_Adj_Label.Text = "التصنيف";
            this.TODO_category_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TODO_todo_Adj_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.TODO_todo_Adj_Label, 6);
            this.TODO_todo_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_todo_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_todo_Adj_Label.Location = new System.Drawing.Point(1246, 129);
            this.TODO_todo_Adj_Label.Name = "TODO_todo_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.TODO_todo_Adj_Label, 2);
            this.TODO_todo_Adj_Label.Size = new System.Drawing.Size(120, 38);
            this.TODO_todo_Adj_Label.TabIndex = 73;
            this.TODO_todo_Adj_Label.Text = "المهمة المطلوبة";
            this.TODO_todo_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TODO_dueto_Adj_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.TODO_dueto_Adj_Label, 6);
            this.TODO_dueto_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_dueto_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_dueto_Adj_Label.Location = new System.Drawing.Point(1246, 43);
            this.TODO_dueto_Adj_Label.Name = "TODO_dueto_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.TODO_dueto_Adj_Label, 2);
            this.TODO_dueto_Adj_Label.Size = new System.Drawing.Size(120, 38);
            this.TODO_dueto_Adj_Label.TabIndex = 61;
            this.TODO_dueto_Adj_Label.Text = "الجهة المستحِقة";
            this.TODO_dueto_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.id_Label, 17);
            this.id_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.id_Label.Font = new System.Drawing.Font("El Messiri", 10.8F);
            this.id_Label.Location = new System.Drawing.Point(70, 38);
            this.id_Label.Name = "id_Label";
            this.all_TablePanel.SetRowSpan(this.id_Label, 2);
            this.id_Label.Size = new System.Drawing.Size(351, 24);
            this.id_Label.TabIndex = 52;
            this.id_Label.Text = "أدخل أرقام فقط";
            this.id_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.id_Label.Visible = false;
            // 
            // TODO_id_Textbox
            // 
            this.all_TablePanel.SetColumnSpan(this.TODO_id_Textbox, 17);
            this.TODO_id_Textbox.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.TODO_id_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.TODO_id_Textbox.IsPasswordTextbox = false;
            this.TODO_id_Textbox.IsPlaceholder = true;
            this.TODO_id_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODO_id_Textbox.Location = new System.Drawing.Point(70, 3);
            this.TODO_id_Textbox.Name = "TODO_id_Textbox";
            this.TODO_id_Textbox.Placeholder = "كود العملية (أدخل أرقام فقط)[في حالة التعديل او الحذف فقط]";
            this.TODO_id_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.TODO_id_Textbox.placeholderFont = null;
            this.TODO_id_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_TablePanel.SetRowSpan(this.TODO_id_Textbox, 2);
            this.TODO_id_Textbox.SelectedItem = null;
            this.TODO_id_Textbox.Size = new System.Drawing.Size(351, 29);
            this.TODO_id_Textbox.TabIndex = 74;
            this.TODO_id_Textbox.Tag = "";
            this.TODO_id_Textbox.Text = "كود العملية (أدخل أرقام فقط)[في حالة التعديل او الحذف فقط]";
            this.TODO_id_Textbox.Values = null;
            this.TODO_id_Textbox.Visible = false;
            this.TODO_id_Textbox.Visible_Password_Button = false;
            this.TODO_id_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.TODO_id_Textbox_SelectedItemChanged);
            this.TODO_id_Textbox.TextChanged += new System.EventHandler(this.TODO_id_Textbox_TextChanged);
            this.TODO_id_Textbox.Enter += new System.EventHandler(this.TODO_Textbox_Enter);
            // 
            // TODO_name_Adj_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.TODO_name_Adj_Label, 6);
            this.TODO_name_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_name_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.TODO_name_Adj_Label.Location = new System.Drawing.Point(1246, 0);
            this.TODO_name_Adj_Label.Name = "TODO_name_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.TODO_name_Adj_Label, 2);
            this.TODO_name_Adj_Label.Size = new System.Drawing.Size(120, 38);
            this.TODO_name_Adj_Label.TabIndex = 60;
            this.TODO_name_Adj_Label.Text = "مطلوب من";
            this.TODO_name_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TODO_duefrom_Textbox
            // 
            this.all_TablePanel.SetColumnSpan(this.TODO_duefrom_Textbox, 38);
            this.TODO_duefrom_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TODO_duefrom_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TODO_duefrom_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.TODO_duefrom_Textbox.IsPasswordTextbox = false;
            this.TODO_duefrom_Textbox.IsPlaceholder = true;
            this.TODO_duefrom_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TODO_duefrom_Textbox.Location = new System.Drawing.Point(448, 3);
            this.TODO_duefrom_Textbox.Name = "TODO_duefrom_Textbox";
            this.TODO_duefrom_Textbox.Placeholder = "مطلوب من";
            this.TODO_duefrom_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.TODO_duefrom_Textbox.placeholderFont = null;
            this.TODO_duefrom_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_TablePanel.SetRowSpan(this.TODO_duefrom_Textbox, 2);
            this.TODO_duefrom_Textbox.SelectedItem = null;
            this.TODO_duefrom_Textbox.Size = new System.Drawing.Size(792, 38);
            this.TODO_duefrom_Textbox.TabIndex = 1;
            this.TODO_duefrom_Textbox.Tag = "";
            this.TODO_duefrom_Textbox.Text = "مطلوب من";
            this.TODO_duefrom_Textbox.Values = null;
            this.TODO_duefrom_Textbox.Visible_Password_Button = false;
            this.TODO_duefrom_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.TODO_Textbox_cmnFlr_SelectedItemChanged);
            this.TODO_duefrom_Textbox.Enter += new System.EventHandler(this.TODO_Textbox_Enter);
            // 
            // Del_TODO_Button
            // 
            this.Del_TODO_Button.BackColor = System.Drawing.Color.DarkRed;
            this.all_TablePanel.SetColumnSpan(this.Del_TODO_Button, 2);
            this.Del_TODO_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Del_TODO_Button.Font = new System.Drawing.Font("El Messiri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_TODO_Button.ForeColor = System.Drawing.Color.Black;
            this.Del_TODO_Button.Image = ((System.Drawing.Image)(resources.GetObject("Del_TODO_Button.Image")));
            this.Del_TODO_Button.ImageActive = null;
            this.Del_TODO_Button.Location = new System.Drawing.Point(28, 3);
            this.Del_TODO_Button.Name = "Del_TODO_Button";
            this.all_TablePanel.SetRowSpan(this.Del_TODO_Button, 3);
            this.Del_TODO_Button.Size = new System.Drawing.Size(36, 37);
            this.Del_TODO_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Del_TODO_Button.TabIndex = 54;
            this.Del_TODO_Button.TabStop = false;
            this.Del_TODO_Button.Visible = false;
            this.Del_TODO_Button.Zoom = 10;
            this.Del_TODO_Button.Click += new System.EventHandler(this.TODO_Button_Click);
            // 
            // UsrCtrl_TgleBtn
            // 
            this.UsrCtrl_TgleBtn.BackColor = System.Drawing.Color.Transparent;
            this.UsrCtrl_TgleBtn.ForeColor = System.Drawing.Color.Silver;
            this.UsrCtrl_TgleBtn.Location = new System.Drawing.Point(0, -2);
            this.UsrCtrl_TgleBtn.MinimumSize = new System.Drawing.Size(45, 22);
            this.UsrCtrl_TgleBtn.Name = "UsrCtrl_TgleBtn";
            this.UsrCtrl_TgleBtn.OffBackColor = System.Drawing.Color.LightCoral;
            this.UsrCtrl_TgleBtn.OffToggleColor = System.Drawing.Color.DarkRed;
            this.UsrCtrl_TgleBtn.OnBackColor = System.Drawing.Color.RoyalBlue;
            this.UsrCtrl_TgleBtn.OnToggleColor = System.Drawing.Color.Navy;
            this.UsrCtrl_TgleBtn.Size = new System.Drawing.Size(70, 30);
            this.UsrCtrl_TgleBtn.TabIndex = 82;
            this.UsrCtrl_TgleBtn.UseVisualStyleBackColor = false;
            this.UsrCtrl_TgleBtn.CheckedChanged += new System.EventHandler(this.UsrCtrl_TgleBtn_CheckedChanged);
            // 
            // Tabcontrol_contextMenuStrip
            // 
            this.Tabcontrol_contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Tabcontrol_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.Tabcontrol_contextMenuStrip.Name = "Tabcontrol_contextMenuStrip";
            this.Tabcontrol_contextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Tabcontrol_contextMenuStrip.Size = new System.Drawing.Size(113, 52);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.copyToolStripMenuItem_MouseDown);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pasteToolStripMenuItem_MouseDown);
            // 
            // Main_SplitContainer
            // 
            this.Main_SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_SplitContainer.Location = new System.Drawing.Point(300, 0);
            this.Main_SplitContainer.Name = "Main_SplitContainer";
            this.Main_SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Main_SplitContainer.Panel1
            // 
            this.Main_SplitContainer.Panel1.Controls.Add(this.Aux_Panel);
            this.Main_SplitContainer.Panel1.Controls.Add(this.AddTodo_Groupbox);
            this.Main_SplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Main_SplitContainer.Panel1MinSize = 1;
            // 
            // Main_SplitContainer.Panel2
            // 
            this.Main_SplitContainer.Panel2.Controls.Add(this.ReqTODOs_Button);
            this.Main_SplitContainer.Panel2.Controls.Add(this.Timeline_Button);
            this.Main_SplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Main_SplitContainer.Panel2MinSize = 1;
            this.Main_SplitContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Main_SplitContainer.Size = new System.Drawing.Size(1375, 930);
            this.Main_SplitContainer.SplitterDistance = 851;
            this.Main_SplitContainer.TabIndex = 76;
            // 
            // ReqTODOs_Button
            // 
            this.ReqTODOs_Button.BackColor = System.Drawing.Color.Transparent;
            this.ReqTODOs_Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReqTODOs_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ReqTODOs_Button.Image = global::DailyCompanionV2.Properties.Resources.requirements;
            this.ReqTODOs_Button.ImageActive = null;
            this.ReqTODOs_Button.Location = new System.Drawing.Point(70, 0);
            this.ReqTODOs_Button.Name = "ReqTODOs_Button";
            this.ReqTODOs_Button.Size = new System.Drawing.Size(70, 75);
            this.ReqTODOs_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReqTODOs_Button.TabIndex = 74;
            this.ReqTODOs_Button.TabStop = false;
            this.ReqTODOs_Button.Zoom = 10;
            this.ReqTODOs_Button.Click += new System.EventHandler(this.ReqTODOs_Button_Click);
            // 
            // Timeline_Button
            // 
            this.Timeline_Button.BackColor = System.Drawing.Color.Transparent;
            this.Timeline_Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.Timeline_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Timeline_Button.Image = global::DailyCompanionV2.Properties.Resources.timeline;
            this.Timeline_Button.ImageActive = null;
            this.Timeline_Button.Location = new System.Drawing.Point(0, 0);
            this.Timeline_Button.Name = "Timeline_Button";
            this.Timeline_Button.Size = new System.Drawing.Size(70, 75);
            this.Timeline_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Timeline_Button.TabIndex = 73;
            this.Timeline_Button.TabStop = false;
            this.Timeline_Button.Zoom = 10;
            this.Timeline_Button.Click += new System.EventHandler(this.Timeline_Button_Click);
            // 
            // Side_Panel
            // 
            this.Side_Panel.Controls.Add(this.sidePanel_Treeview);
            this.Side_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_Panel.Location = new System.Drawing.Point(0, 0);
            this.Side_Panel.Name = "Side_Panel";
            this.Side_Panel.Size = new System.Drawing.Size(300, 930);
            this.Side_Panel.TabIndex = 93;
            // 
            // sidePanel_Treeview
            // 
            this.sidePanel_Treeview.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sidePanel_Treeview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel_Treeview.Font = new System.Drawing.Font("Cairo SemiBold", 9.8F, System.Drawing.FontStyle.Bold);
            this.sidePanel_Treeview.Location = new System.Drawing.Point(0, 0);
            this.sidePanel_Treeview.Name = "sidePanel_Treeview";
            treeNode1.Name = "Node3";
            treeNode1.Text = "Node3";
            treeNode2.Name = "Node0";
            treeNode2.Text = "مهام مقترحة";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Node4";
            treeNode4.Name = "Node1";
            treeNode4.Text = "مهام مطلوبة";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Node6";
            treeNode7.Name = "Node2";
            treeNode7.Text = "خيارات سابقة";
            treeNode8.Name = "Node7";
            treeNode8.Text = "مهام شبيهة";
            this.sidePanel_Treeview.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode7,
            treeNode8});
            this.sidePanel_Treeview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sidePanel_Treeview.RightToLeftLayout = true;
            this.sidePanel_Treeview.Size = new System.Drawing.Size(300, 930);
            this.sidePanel_Treeview.TabIndex = 1;
            this.sidePanel_Treeview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.sidePanel_Treeview_MouseDoubleClick);
            // 
            // UsrCtrl_Todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Main_SplitContainer);
            this.Controls.Add(this.Side_Panel);
            this.Name = "UsrCtrl_Todo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1675, 930);
            this.Aux_Panel.ResumeLayout(false);
            this.aux_TablePanel.ResumeLayout(false);
            this.aux_TablePanel.PerformLayout();
            this.DTPicker_contextMenuStrip.ResumeLayout(false);
            this.auxContent_Panel.ResumeLayout(false);
            this.TodoReq_Groupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reqTODO_Objectlistview)).EndInit();
            this.Timeline_Groupbox.ResumeLayout(false);
            this.Timeline_Panel.ResumeLayout(false);
            this.AddTodo_Groupbox.ResumeLayout(false);
            this.AddTodo_Groupbox.PerformLayout();
            this.all_TablePanel.ResumeLayout(false);
            this.all_TablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Todos_chkpoint_list_Objectlistview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Del_TODO_Button)).EndInit();
            this.Tabcontrol_contextMenuStrip.ResumeLayout(false);
            this.Main_SplitContainer.Panel1.ResumeLayout(false);
            this.Main_SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_SplitContainer)).EndInit();
            this.Main_SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReqTODOs_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timeline_Button)).EndInit();
            this.Side_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox TodoReq_Groupbox;
        private System.Windows.Forms.Button TODO_Aux_SearchButton;
        private System.Windows.Forms.Label TODO_AuxTo_Adj_Label;
        private System.Windows.Forms.Label TODO_AuxFrom_Adj_Label;
        private System.Windows.Forms.DateTimePicker TODO_AuxTo_Datetimepicker;
        private System.Windows.Forms.DateTimePicker TODO_AuxFrom_Datetimepicker;
        private BrightIdeasSoftware.ObjectListView reqTODO_Objectlistview;
        private BrightIdeasSoftware.OLVColumn ReqTODO_Column;
        private BrightIdeasSoftware.OLVColumn finalTODO_Column;
        private BrightIdeasSoftware.OLVColumn categoryTODO_Column;
        private System.Windows.Forms.GroupBox Timeline_Groupbox;
        private MaterialWinforms.Controls.MaterialTimeline Todo_Timeline_Control;
        private System.Windows.Forms.Label AuxComment_Label;
        private System.Windows.Forms.Panel Timeline_Panel;
        private System.Windows.Forms.GroupBox AddTodo_Groupbox;
        private System.Windows.Forms.Button TODOs_DelChkPnt_Button;
        private System.Windows.Forms.Button TODOs_AddChkPnt_Button;
        private System.Windows.Forms.Label TODOs_chkpoint_list_Adj_Label;
        private BrightIdeasSoftware.ObjectListView Todos_chkpoint_list_Objectlistview;
        private BrightIdeasSoftware.OLVColumn ChkPnt_index_Column;
        private BrightIdeasSoftware.OLVColumn ChkPnt_name_Column;
        private BrightIdeasSoftware.OLVColumn ChkPnt_date_Column;
        private ModdedTextBox TODO_id_Textbox;
        private System.Windows.Forms.Label TODO_todo_Adj_Label;
        private ModdedTextBox TODO_todo_Textbox;
        private System.Windows.Forms.Label TODO_notes_Adj_Label;
        private System.Windows.Forms.Label TODO_category_Adj_Label;
        private System.Windows.Forms.Label TODO_dueto_Adj_Label;
        private System.Windows.Forms.Label TODO_name_Adj_Label;
        private ns1.BunifuImageButton Del_TODO_Button;
        private System.Windows.Forms.Label id_Label;
        private ModdedTextBox TODO_category_Textbox;
        private System.Windows.Forms.Label AddTODO_Label;
        private System.Windows.Forms.Button Add_TODO_Button;
        private ModdedTextBox TODO_notes_Textbox;
        private ModdedTextBox TODO_dueto_Textbox;
        private ModdedTextBox TODO_duefrom_Textbox;
        private System.Windows.Forms.ContextMenuStrip Tabcontrol_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private CustomControls.RJControls.RJToggleButton UsrCtrl_TgleBtn;
        private System.Windows.Forms.TableLayoutPanel all_TablePanel;
        private System.Windows.Forms.Label TODO_duration_value_Label;
        private System.Windows.Forms.DateTimePicker TODO_start_date_Datetimepicker;
        private System.Windows.Forms.DateTimePicker TODO_due_date_Datetimepicker;
        private System.Windows.Forms.Label TODO_duration_Adj_Label;
        private ModdedTextBox TODO_duration_Textbox;
        private System.Windows.Forms.DateTimePicker TODO_done_date_Datetimepicker;
        private System.Windows.Forms.Label TODO_done_date_Adj_Label;
        private System.Windows.Forms.Label TODO_due_date_Adj_Label;
        private System.Windows.Forms.Label TODO_start_date_Adj_Label;
        private ns1.BunifuImageButton ReqTODOs_Button;
        private ns1.BunifuImageButton Timeline_Button;
        private System.Windows.Forms.Panel Aux_Panel;
        private System.Windows.Forms.TableLayoutPanel aux_TablePanel;
        private System.Windows.Forms.Panel auxContent_Panel;
        private System.Windows.Forms.SplitContainer Main_SplitContainer;
        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.TreeView sidePanel_Treeview;
        private System.Windows.Forms.ContextMenuStrip DTPicker_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem nowStripMenuItem;
    }
}
