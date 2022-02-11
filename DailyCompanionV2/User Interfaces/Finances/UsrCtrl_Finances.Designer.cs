using ModdedControls;
using System.Drawing;
using System.Windows.Forms;

namespace DailyCompanionV2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsrCtrl_Finances));
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
            this.cityColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FNCReq_Groupbox = new System.Windows.Forms.GroupBox();
            this.reqFNC_Objectlistview = new BrightIdeasSoftware.ObjectListView();
            this.CatFNC_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.TypFNC_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.finalFNC_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DueFNC_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FNC_AuxTo_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.FNC_AuxFrom_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.WalletsSearch_Label = new System.Windows.Forms.Label();
            this.Wlts_Search_Objectlistview = new BrightIdeasSoftware.ObjectListView();
            this.Wlt_Id_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Wlt_Name_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Wlt_credit_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Wlts_Objectlistview = new BrightIdeasSoftware.ObjectListView();
            this.FinanceWallet_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FinanceRelatedentity_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FinanceType_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FinanceCategory_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FinanceDue_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FinancePaid_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FinancialDonedate_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AddFinance_Groupbox = new System.Windows.Forms.GroupBox();
            this.Aux_Panel = new System.Windows.Forms.Panel();
            this.aux_TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.FNC_AuxTo_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_AuxFrom_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_Aux_SearchButton = new System.Windows.Forms.Button();
            this.AuxComment_Label = new System.Windows.Forms.Label();
            this.auxContent_Panel = new System.Windows.Forms.Panel();
            this.FNCWallets_Groupbox = new System.Windows.Forms.GroupBox();
            this.Wallets_TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.all_TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.FNC_notes_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_notes_Textbox = new ModdedControls.ModdedTextBox();
            this.FNC_Label = new System.Windows.Forms.Label();
            this.Add_FNC_Button = new System.Windows.Forms.Button();
            this.FNC_due_date_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.DTPicker_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nowStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FNC_done_date_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.FNC_due_Textbox = new ModdedControls.ModdedTextBox();
            this.FNC_paid_Textbox = new ModdedControls.ModdedTextBox();
            this.FNC_due_date_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_done_date_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_value_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_paid_Adj_Label = new System.Windows.Forms.Label();
            this.Del_FNC_Button = new ns1.BunifuImageButton();
            this.FNC_id_Textbox = new ModdedControls.ModdedTextBox();
            this.FNC_id_Label = new System.Windows.Forms.Label();
            this.FNC_category_Textbox = new ModdedControls.ModdedTextBox();
            this.FNC_category_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_type_Combobox = new System.Windows.Forms.ComboBox();
            this.FNC_Type_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_wltName_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_relatedidentity_Adj_Label = new System.Windows.Forms.Label();
            this.FNC_wallet_Combobox = new System.Windows.Forms.ComboBox();
            this.relatedIdntity_Panel = new System.Windows.Forms.Panel();
            this.FNC_relatedentity_Textbox = new ModdedControls.ModdedTextBox();
            this.FNC_relatedentity_Combobox = new System.Windows.Forms.ComboBox();
            this.UsrCtrl_TgleBtn = new CustomControls.RJControls.RJToggleButton();
            this.Tabcontrol_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Main_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.ReqFNC_Button = new ns1.BunifuImageButton();
            this.FNC_Wallets_Button = new ns1.BunifuImageButton();
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.sidePanel_Treeview = new System.Windows.Forms.TreeView();
            this.FNCReq_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reqFNC_Objectlistview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wlts_Search_Objectlistview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wlts_Objectlistview)).BeginInit();
            this.AddFinance_Groupbox.SuspendLayout();
            this.Aux_Panel.SuspendLayout();
            this.aux_TablePanel.SuspendLayout();
            this.auxContent_Panel.SuspendLayout();
            this.FNCWallets_Groupbox.SuspendLayout();
            this.Wallets_TablePanel.SuspendLayout();
            this.all_TablePanel.SuspendLayout();
            this.DTPicker_contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Del_FNC_Button)).BeginInit();
            this.relatedIdntity_Panel.SuspendLayout();
            this.Tabcontrol_contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_SplitContainer)).BeginInit();
            this.Main_SplitContainer.Panel1.SuspendLayout();
            this.Main_SplitContainer.Panel2.SuspendLayout();
            this.Main_SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReqFNC_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FNC_Wallets_Button)).BeginInit();
            this.Side_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityColumn
            // 
            this.cityColumn.AspectName = "city";
            this.cityColumn.DisplayIndex = 7;
            this.cityColumn.Text = "المدينة";
            // 
            // FNCReq_Groupbox
            // 
            this.FNCReq_Groupbox.Controls.Add(this.reqFNC_Objectlistview);
            this.FNCReq_Groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNCReq_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNCReq_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.FNCReq_Groupbox.Location = new System.Drawing.Point(0, 0);
            this.FNCReq_Groupbox.Name = "FNCReq_Groupbox";
            this.FNCReq_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FNCReq_Groupbox.Size = new System.Drawing.Size(1354, 525);
            this.FNCReq_Groupbox.TabIndex = 12;
            this.FNCReq_Groupbox.TabStop = false;
            this.FNCReq_Groupbox.Text = "العمليات المالية المطلوبة";
            // 
            // reqFNC_Objectlistview
            // 
            this.reqFNC_Objectlistview.AllColumns.Add(this.CatFNC_Column);
            this.reqFNC_Objectlistview.AllColumns.Add(this.TypFNC_Column);
            this.reqFNC_Objectlistview.AllColumns.Add(this.finalFNC_Column);
            this.reqFNC_Objectlistview.AllColumns.Add(this.DueFNC_Column);
            this.reqFNC_Objectlistview.CellEditUseWholeCell = false;
            this.reqFNC_Objectlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CatFNC_Column,
            this.TypFNC_Column,
            this.finalFNC_Column,
            this.DueFNC_Column});
            this.reqFNC_Objectlistview.Cursor = System.Windows.Forms.Cursors.Default;
            this.reqFNC_Objectlistview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reqFNC_Objectlistview.Font = new System.Drawing.Font("El Messiri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqFNC_Objectlistview.FullRowSelect = true;
            this.reqFNC_Objectlistview.HideSelection = false;
            this.reqFNC_Objectlistview.Location = new System.Drawing.Point(3, 39);
            this.reqFNC_Objectlistview.Name = "reqFNC_Objectlistview";
            this.reqFNC_Objectlistview.RightToLeftLayout = true;
            this.reqFNC_Objectlistview.SelectColumnsOnRightClick = false;
            this.reqFNC_Objectlistview.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.reqFNC_Objectlistview.ShowCommandMenuOnRightClick = true;
            this.reqFNC_Objectlistview.ShowItemCountOnGroups = true;
            this.reqFNC_Objectlistview.Size = new System.Drawing.Size(1348, 483);
            this.reqFNC_Objectlistview.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.reqFNC_Objectlistview.SpaceBetweenGroups = 3;
            this.reqFNC_Objectlistview.TabIndex = 19;
            this.reqFNC_Objectlistview.UseCompatibleStateImageBehavior = false;
            this.reqFNC_Objectlistview.UseFiltering = true;
            this.reqFNC_Objectlistview.UseHotControls = false;
            this.reqFNC_Objectlistview.View = System.Windows.Forms.View.Details;
            this.reqFNC_Objectlistview.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.reqFNC_Objectlistview_FormatRow);
            this.reqFNC_Objectlistview.DoubleClick += new System.EventHandler(this.reqFNC_Objectlistview_DoubleClick);
            // 
            // CatFNC_Column
            // 
            this.CatFNC_Column.AspectName = "category";
            this.CatFNC_Column.Hideable = false;
            this.CatFNC_Column.MinimumWidth = 500;
            this.CatFNC_Column.Text = "العملية المالية";
            this.CatFNC_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CatFNC_Column.Width = 500;
            // 
            // TypFNC_Column
            // 
            this.TypFNC_Column.AspectName = "type";
            this.TypFNC_Column.Hideable = false;
            this.TypFNC_Column.MinimumWidth = 200;
            this.TypFNC_Column.Text = "نوع العملية المالية";
            this.TypFNC_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TypFNC_Column.Width = 200;
            // 
            // finalFNC_Column
            // 
            this.finalFNC_Column.AspectName = "due_date";
            this.finalFNC_Column.AspectToStringFormat = "{0: dddd, dd MMMM yyyy}";
            this.finalFNC_Column.Hideable = false;
            this.finalFNC_Column.MinimumWidth = 250;
            this.finalFNC_Column.Text = "تاريخ الاستحقاق";
            this.finalFNC_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.finalFNC_Column.Width = 250;
            // 
            // DueFNC_Column
            // 
            this.DueFNC_Column.AspectName = "due";
            this.DueFNC_Column.Hideable = false;
            this.DueFNC_Column.MinimumWidth = 200;
            this.DueFNC_Column.Text = "القيمة المطلوبة";
            this.DueFNC_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DueFNC_Column.Width = 200;
            // 
            // FNC_AuxTo_Datetimepicker
            // 
            this.FNC_AuxTo_Datetimepicker.CalendarFont = new System.Drawing.Font("El Messiri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aux_TablePanel.SetColumnSpan(this.FNC_AuxTo_Datetimepicker, 9);
            this.FNC_AuxTo_Datetimepicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_AuxTo_Datetimepicker.Font = new System.Drawing.Font("El Messiri", 12F);
            this.FNC_AuxTo_Datetimepicker.Location = new System.Drawing.Point(378, 5);
            this.FNC_AuxTo_Datetimepicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FNC_AuxTo_Datetimepicker.Name = "FNC_AuxTo_Datetimepicker";
            this.aux_TablePanel.SetRowSpan(this.FNC_AuxTo_Datetimepicker, 2);
            this.FNC_AuxTo_Datetimepicker.Size = new System.Drawing.Size(365, 39);
            this.FNC_AuxTo_Datetimepicker.TabIndex = 15;
            this.FNC_AuxTo_Datetimepicker.Value = new System.DateTime(2025, 7, 2, 0, 0, 0, 0);
            // 
            // FNC_AuxFrom_Datetimepicker
            // 
            this.FNC_AuxFrom_Datetimepicker.CalendarFont = new System.Drawing.Font("El Messiri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aux_TablePanel.SetColumnSpan(this.FNC_AuxFrom_Datetimepicker, 9);
            this.FNC_AuxFrom_Datetimepicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_AuxFrom_Datetimepicker.Font = new System.Drawing.Font("El Messiri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNC_AuxFrom_Datetimepicker.Location = new System.Drawing.Point(870, 5);
            this.FNC_AuxFrom_Datetimepicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FNC_AuxFrom_Datetimepicker.Name = "FNC_AuxFrom_Datetimepicker";
            this.aux_TablePanel.SetRowSpan(this.FNC_AuxFrom_Datetimepicker, 2);
            this.FNC_AuxFrom_Datetimepicker.Size = new System.Drawing.Size(365, 39);
            this.FNC_AuxFrom_Datetimepicker.TabIndex = 14;
            this.FNC_AuxFrom_Datetimepicker.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            // 
            // WalletsSearch_Label
            // 
            this.WalletsSearch_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WalletsSearch_Label.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WalletsSearch_Label.ForeColor = System.Drawing.Color.Maroon;
            this.WalletsSearch_Label.Location = new System.Drawing.Point(3, 0);
            this.WalletsSearch_Label.Name = "WalletsSearch_Label";
            this.WalletsSearch_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WalletsSearch_Label.Size = new System.Drawing.Size(331, 169);
            this.WalletsSearch_Label.TabIndex = 44;
            this.WalletsSearch_Label.Text = "label15";
            this.WalletsSearch_Label.Visible = false;
            // 
            // Wlts_Search_Objectlistview
            // 
            this.Wlts_Search_Objectlistview.AllColumns.Add(this.Wlt_Id_Column);
            this.Wlts_Search_Objectlistview.AllColumns.Add(this.Wlt_Name_Column);
            this.Wlts_Search_Objectlistview.AllColumns.Add(this.Wlt_credit_Column);
            this.Wlts_Search_Objectlistview.CellEditUseWholeCell = false;
            this.Wlts_Search_Objectlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Wlt_Id_Column,
            this.Wlt_Name_Column,
            this.Wlt_credit_Column});
            this.Wlts_Search_Objectlistview.Cursor = System.Windows.Forms.Cursors.Default;
            this.Wlts_Search_Objectlistview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wlts_Search_Objectlistview.EmptyListMsg = "لا يوجد عناصر";
            this.Wlts_Search_Objectlistview.EmptyListMsgFont = new System.Drawing.Font("Cairo SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlts_Search_Objectlistview.Font = new System.Drawing.Font("El Messiri", 10F);
            this.Wlts_Search_Objectlistview.FullRowSelect = true;
            this.Wlts_Search_Objectlistview.HideSelection = false;
            this.Wlts_Search_Objectlistview.Location = new System.Drawing.Point(340, 2);
            this.Wlts_Search_Objectlistview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Wlts_Search_Objectlistview.Name = "Wlts_Search_Objectlistview";
            this.Wlts_Search_Objectlistview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Wlts_Search_Objectlistview.RightToLeftLayout = true;
            this.Wlts_Search_Objectlistview.ShowCommandMenuOnRightClick = true;
            this.Wlts_Search_Objectlistview.Size = new System.Drawing.Size(1005, 165);
            this.Wlts_Search_Objectlistview.SortGroupItemsByPrimaryColumn = false;
            this.Wlts_Search_Objectlistview.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.Wlts_Search_Objectlistview.SpaceBetweenGroups = 5;
            this.Wlts_Search_Objectlistview.TabIndex = 43;
            this.Wlts_Search_Objectlistview.TintSortColumn = true;
            this.Wlts_Search_Objectlistview.UseCompatibleStateImageBehavior = false;
            this.Wlts_Search_Objectlistview.UseFilterIndicator = true;
            this.Wlts_Search_Objectlistview.UseFiltering = true;
            this.Wlts_Search_Objectlistview.UseHotControls = false;
            this.Wlts_Search_Objectlistview.View = System.Windows.Forms.View.Details;
            this.Wlts_Search_Objectlistview.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.Wlts_Search_Objectlistview_FormatRow);
            this.Wlts_Search_Objectlistview.DoubleClick += new System.EventHandler(this.Wlts_Search_Objectlistview_DoubleClick);
            // 
            // Wlt_Id_Column
            // 
            this.Wlt_Id_Column.AspectName = "id";
            this.Wlt_Id_Column.MinimumWidth = 50;
            this.Wlt_Id_Column.Tag = "double";
            this.Wlt_Id_Column.Text = "كود";
            this.Wlt_Id_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wlt_Id_Column.Width = 50;
            // 
            // Wlt_Name_Column
            // 
            this.Wlt_Name_Column.AspectName = "name";
            this.Wlt_Name_Column.Hideable = false;
            this.Wlt_Name_Column.MinimumWidth = 255;
            this.Wlt_Name_Column.Tag = "string";
            this.Wlt_Name_Column.Text = "المحفظة";
            this.Wlt_Name_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wlt_Name_Column.Width = 255;
            // 
            // Wlt_credit_Column
            // 
            this.Wlt_credit_Column.AspectName = "credit";
            this.Wlt_credit_Column.Hideable = false;
            this.Wlt_credit_Column.MinimumWidth = 200;
            this.Wlt_credit_Column.Tag = "double";
            this.Wlt_credit_Column.Text = "الرصيد";
            this.Wlt_credit_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wlt_credit_Column.Width = 200;
            // 
            // Wlts_Objectlistview
            // 
            this.Wlts_Objectlistview.AllColumns.Add(this.FinanceWallet_Column);
            this.Wlts_Objectlistview.AllColumns.Add(this.FinanceRelatedentity_Column);
            this.Wlts_Objectlistview.AllColumns.Add(this.FinanceType_Column);
            this.Wlts_Objectlistview.AllColumns.Add(this.FinanceCategory_Column);
            this.Wlts_Objectlistview.AllColumns.Add(this.FinanceDue_Column);
            this.Wlts_Objectlistview.AllColumns.Add(this.FinancePaid_Column);
            this.Wlts_Objectlistview.AllColumns.Add(this.FinancialDonedate_Column);
            this.Wlts_Objectlistview.CellEditUseWholeCell = false;
            this.Wlts_Objectlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FinanceWallet_Column,
            this.FinanceRelatedentity_Column,
            this.FinanceType_Column,
            this.FinanceCategory_Column,
            this.FinanceDue_Column,
            this.FinancePaid_Column,
            this.FinancialDonedate_Column});
            this.Wallets_TablePanel.SetColumnSpan(this.Wlts_Objectlistview, 2);
            this.Wlts_Objectlistview.Cursor = System.Windows.Forms.Cursors.Default;
            this.Wlts_Objectlistview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wlts_Objectlistview.EmptyListMsg = "لا يوجد عناصر";
            this.Wlts_Objectlistview.EmptyListMsgFont = new System.Drawing.Font("Cairo SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlts_Objectlistview.Font = new System.Drawing.Font("El Messiri", 10F);
            this.Wlts_Objectlistview.FullRowSelect = true;
            this.Wlts_Objectlistview.HideSelection = false;
            this.Wlts_Objectlistview.Location = new System.Drawing.Point(3, 171);
            this.Wlts_Objectlistview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Wlts_Objectlistview.Name = "Wlts_Objectlistview";
            this.Wlts_Objectlistview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Wlts_Objectlistview.RightToLeftLayout = true;
            this.Wlts_Objectlistview.ShowCommandMenuOnRightClick = true;
            this.Wlts_Objectlistview.Size = new System.Drawing.Size(1342, 310);
            this.Wlts_Objectlistview.SortGroupItemsByPrimaryColumn = false;
            this.Wlts_Objectlistview.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.Wlts_Objectlistview.SpaceBetweenGroups = 5;
            this.Wlts_Objectlistview.TabIndex = 2;
            this.Wlts_Objectlistview.TintSortColumn = true;
            this.Wlts_Objectlistview.UseCompatibleStateImageBehavior = false;
            this.Wlts_Objectlistview.UseFilterIndicator = true;
            this.Wlts_Objectlistview.UseFiltering = true;
            this.Wlts_Objectlistview.UseHotControls = false;
            this.Wlts_Objectlistview.View = System.Windows.Forms.View.Details;
            this.Wlts_Objectlistview.AboutToCreateGroups += new System.EventHandler<BrightIdeasSoftware.CreateGroupsEventArgs>(this.Wlts_Objectlistview_AboutToCreateGroups);
            this.Wlts_Objectlistview.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.Wlts_Objectlistview_FormatRow);
            this.Wlts_Objectlistview.DoubleClick += new System.EventHandler(this.Wlts_Objectlistview_DoubleClick);
            // 
            // FinanceWallet_Column
            // 
            this.FinanceWallet_Column.AspectName = "wallet";
            this.FinanceWallet_Column.MinimumWidth = 150;
            this.FinanceWallet_Column.Tag = "fnc_wlt_combobox";
            this.FinanceWallet_Column.Text = "المحفظة";
            this.FinanceWallet_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinanceWallet_Column.Width = 150;
            // 
            // FinanceRelatedentity_Column
            // 
            this.FinanceRelatedentity_Column.AspectName = "relatedentity";
            this.FinanceRelatedentity_Column.Hideable = false;
            this.FinanceRelatedentity_Column.MinimumWidth = 255;
            this.FinanceRelatedentity_Column.Tag = "string";
            this.FinanceRelatedentity_Column.Text = "الاسم";
            this.FinanceRelatedentity_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinanceRelatedentity_Column.Width = 255;
            // 
            // FinanceType_Column
            // 
            this.FinanceType_Column.AspectName = "type";
            this.FinanceType_Column.Hideable = false;
            this.FinanceType_Column.MinimumWidth = 200;
            this.FinanceType_Column.Tag = "enum";
            this.FinanceType_Column.Text = "نوع العملية";
            this.FinanceType_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinanceType_Column.Width = 200;
            // 
            // FinanceCategory_Column
            // 
            this.FinanceCategory_Column.AspectName = "category";
            this.FinanceCategory_Column.Hideable = false;
            this.FinanceCategory_Column.MinimumWidth = 250;
            this.FinanceCategory_Column.Tag = "string";
            this.FinanceCategory_Column.Text = "تصنيف العملية";
            this.FinanceCategory_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinanceCategory_Column.Width = 250;
            // 
            // FinanceDue_Column
            // 
            this.FinanceDue_Column.AspectName = "due";
            this.FinanceDue_Column.AspectToStringFormat = "{0:F2}";
            this.FinanceDue_Column.Hideable = false;
            this.FinanceDue_Column.MinimumWidth = 150;
            this.FinanceDue_Column.Tag = "decimal";
            this.FinanceDue_Column.Text = "القيمة المستحقة";
            this.FinanceDue_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinanceDue_Column.Width = 158;
            // 
            // FinancePaid_Column
            // 
            this.FinancePaid_Column.AspectName = "paid";
            this.FinancePaid_Column.AspectToStringFormat = "{0:F2}";
            this.FinancePaid_Column.Hideable = false;
            this.FinancePaid_Column.MinimumWidth = 150;
            this.FinancePaid_Column.Tag = "decimal";
            this.FinancePaid_Column.Text = "المدفوع";
            this.FinancePaid_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinancePaid_Column.Width = 150;
            // 
            // FinancialDonedate_Column
            // 
            this.FinancialDonedate_Column.AspectName = "str_done_date";
            this.FinancialDonedate_Column.Hideable = false;
            this.FinancialDonedate_Column.MinimumWidth = 200;
            this.FinancialDonedate_Column.Tag = "datetime";
            this.FinancialDonedate_Column.Text = "تاريخ الانتهاء";
            this.FinancialDonedate_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinancialDonedate_Column.Width = 200;
            // 
            // AddFinance_Groupbox
            // 
            this.AddFinance_Groupbox.Controls.Add(this.Aux_Panel);
            this.AddFinance_Groupbox.Controls.Add(this.all_TablePanel);
            this.AddFinance_Groupbox.Controls.Add(this.UsrCtrl_TgleBtn);
            this.AddFinance_Groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddFinance_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFinance_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.AddFinance_Groupbox.Location = new System.Drawing.Point(0, 0);
            this.AddFinance_Groupbox.Name = "AddFinance_Groupbox";
            this.AddFinance_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddFinance_Groupbox.Size = new System.Drawing.Size(1375, 851);
            this.AddFinance_Groupbox.TabIndex = 0;
            this.AddFinance_Groupbox.TabStop = false;
            this.AddFinance_Groupbox.Tag = this.Add_FNC_Button;
            this.AddFinance_Groupbox.Text = "إضافة عملية مالية";
            // 
            // Aux_Panel
            // 
            this.Aux_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Aux_Panel.Controls.Add(this.aux_TablePanel);
            this.Aux_Panel.Location = new System.Drawing.Point(9, 228);
            this.Aux_Panel.Name = "Aux_Panel";
            this.Aux_Panel.Size = new System.Drawing.Size(1364, 621);
            this.Aux_Panel.TabIndex = 85;
            this.Aux_Panel.Visible = false;
            this.Aux_Panel.Leave += new System.EventHandler(this.Aux_Panel_Leave);
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
            this.aux_TablePanel.Controls.Add(this.FNC_AuxFrom_Datetimepicker, 3, 1);
            this.aux_TablePanel.Controls.Add(this.FNC_AuxTo_Datetimepicker, 15, 1);
            this.aux_TablePanel.Controls.Add(this.FNC_AuxTo_Adj_Label, 14, 1);
            this.aux_TablePanel.Controls.Add(this.FNC_AuxFrom_Adj_Label, 2, 1);
            this.aux_TablePanel.Controls.Add(this.FNC_Aux_SearchButton, 27, 1);
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
            this.aux_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.aux_TablePanel.Size = new System.Drawing.Size(1360, 617);
            this.aux_TablePanel.TabIndex = 21;
            // 
            // FNC_AuxTo_Adj_Label
            // 
            this.FNC_AuxTo_Adj_Label.AutoSize = true;
            this.FNC_AuxTo_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_AuxTo_Adj_Label.Font = new System.Drawing.Font("El Messiri", 10.5F);
            this.FNC_AuxTo_Adj_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.FNC_AuxTo_Adj_Label.Location = new System.Drawing.Point(747, 2);
            this.FNC_AuxTo_Adj_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FNC_AuxTo_Adj_Label.Name = "FNC_AuxTo_Adj_Label";
            this.aux_TablePanel.SetRowSpan(this.FNC_AuxTo_Adj_Label, 2);
            this.FNC_AuxTo_Adj_Label.Size = new System.Drawing.Size(37, 40);
            this.FNC_AuxTo_Adj_Label.TabIndex = 17;
            this.FNC_AuxTo_Adj_Label.Text = "إلى";
            this.FNC_AuxTo_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FNC_AuxFrom_Adj_Label
            // 
            this.FNC_AuxFrom_Adj_Label.AutoSize = true;
            this.FNC_AuxFrom_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_AuxFrom_Adj_Label.Font = new System.Drawing.Font("El Messiri", 10.5F);
            this.FNC_AuxFrom_Adj_Label.ForeColor = System.Drawing.Color.DarkRed;
            this.FNC_AuxFrom_Adj_Label.Location = new System.Drawing.Point(1239, 2);
            this.FNC_AuxFrom_Adj_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FNC_AuxFrom_Adj_Label.Name = "FNC_AuxFrom_Adj_Label";
            this.aux_TablePanel.SetRowSpan(this.FNC_AuxFrom_Adj_Label, 2);
            this.FNC_AuxFrom_Adj_Label.Size = new System.Drawing.Size(37, 40);
            this.FNC_AuxFrom_Adj_Label.TabIndex = 16;
            this.FNC_AuxFrom_Adj_Label.Text = "من";
            this.FNC_AuxFrom_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FNC_Aux_SearchButton
            // 
            this.aux_TablePanel.SetColumnSpan(this.FNC_Aux_SearchButton, 4);
            this.FNC_Aux_SearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_Aux_SearchButton.Font = new System.Drawing.Font("El Messiri", 12F);
            this.FNC_Aux_SearchButton.ForeColor = System.Drawing.Color.DarkRed;
            this.FNC_Aux_SearchButton.Location = new System.Drawing.Point(91, 5);
            this.FNC_Aux_SearchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.FNC_Aux_SearchButton.Name = "FNC_Aux_SearchButton";
            this.aux_TablePanel.SetRowSpan(this.FNC_Aux_SearchButton, 2);
            this.FNC_Aux_SearchButton.Size = new System.Drawing.Size(160, 34);
            this.FNC_Aux_SearchButton.TabIndex = 18;
            this.FNC_Aux_SearchButton.Text = "بحث";
            this.FNC_Aux_SearchButton.UseVisualStyleBackColor = true;
            this.FNC_Aux_SearchButton.Click += new System.EventHandler(this.FNC_Aux_SearchButton_Click);
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
            this.auxContent_Panel.Controls.Add(this.FNCReq_Groupbox);
            this.auxContent_Panel.Controls.Add(this.FNCWallets_Groupbox);
            this.auxContent_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.auxContent_Panel.Location = new System.Drawing.Point(3, 89);
            this.auxContent_Panel.Name = "auxContent_Panel";
            this.aux_TablePanel.SetRowSpan(this.auxContent_Panel, 25);
            this.auxContent_Panel.Size = new System.Drawing.Size(1354, 525);
            this.auxContent_Panel.TabIndex = 21;
            // 
            // FNCWallets_Groupbox
            // 
            this.FNCWallets_Groupbox.Controls.Add(this.Wallets_TablePanel);
            this.FNCWallets_Groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNCWallets_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNCWallets_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.FNCWallets_Groupbox.Location = new System.Drawing.Point(0, 0);
            this.FNCWallets_Groupbox.Name = "FNCWallets_Groupbox";
            this.FNCWallets_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FNCWallets_Groupbox.Size = new System.Drawing.Size(1354, 525);
            this.FNCWallets_Groupbox.TabIndex = 22;
            this.FNCWallets_Groupbox.TabStop = false;
            this.FNCWallets_Groupbox.Text = "العمليات المالية للمحافظ";
            // 
            // Wallets_TablePanel
            // 
            this.Wallets_TablePanel.ColumnCount = 2;
            this.Wallets_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.Wallets_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Wallets_TablePanel.Controls.Add(this.Wlts_Objectlistview, 0, 1);
            this.Wallets_TablePanel.Controls.Add(this.Wlts_Search_Objectlistview, 0, 0);
            this.Wallets_TablePanel.Controls.Add(this.WalletsSearch_Label, 1, 0);
            this.Wallets_TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wallets_TablePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.Wallets_TablePanel.Location = new System.Drawing.Point(3, 39);
            this.Wallets_TablePanel.Name = "Wallets_TablePanel";
            this.Wallets_TablePanel.RowCount = 2;
            this.Wallets_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.Wallets_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.Wallets_TablePanel.Size = new System.Drawing.Size(1348, 483);
            this.Wallets_TablePanel.TabIndex = 45;
            // 
            // all_TablePanel
            // 
            this.all_TablePanel.ColumnCount = 65;
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.538462F));
            this.all_TablePanel.Controls.Add(this.FNC_notes_Adj_Label, 0, 26);
            this.all_TablePanel.Controls.Add(this.FNC_notes_Textbox, 0, 28);
            this.all_TablePanel.Controls.Add(this.FNC_Label, 2, 40);
            this.all_TablePanel.Controls.Add(this.Add_FNC_Button, 50, 41);
            this.all_TablePanel.Controls.Add(this.FNC_due_date_Datetimepicker, 11, 21);
            this.all_TablePanel.Controls.Add(this.FNC_done_date_Datetimepicker, 11, 23);
            this.all_TablePanel.Controls.Add(this.FNC_due_Textbox, 11, 16);
            this.all_TablePanel.Controls.Add(this.FNC_paid_Textbox, 11, 18);
            this.all_TablePanel.Controls.Add(this.FNC_due_date_Adj_Label, 3, 21);
            this.all_TablePanel.Controls.Add(this.FNC_done_date_Adj_Label, 3, 23);
            this.all_TablePanel.Controls.Add(this.FNC_value_Adj_Label, 3, 16);
            this.all_TablePanel.Controls.Add(this.FNC_paid_Adj_Label, 3, 18);
            this.all_TablePanel.Controls.Add(this.Del_FNC_Button, 62, 0);
            this.all_TablePanel.Controls.Add(this.FNC_id_Textbox, 44, 0);
            this.all_TablePanel.Controls.Add(this.FNC_id_Label, 44, 2);
            this.all_TablePanel.Controls.Add(this.FNC_category_Textbox, 8, 13);
            this.all_TablePanel.Controls.Add(this.FNC_category_Adj_Label, 1, 13);
            this.all_TablePanel.Controls.Add(this.FNC_type_Combobox, 8, 0);
            this.all_TablePanel.Controls.Add(this.FNC_Type_Adj_Label, 0, 0);
            this.all_TablePanel.Controls.Add(this.FNC_wltName_Adj_Label, 0, 4);
            this.all_TablePanel.Controls.Add(this.FNC_relatedidentity_Adj_Label, 0, 8);
            this.all_TablePanel.Controls.Add(this.FNC_wallet_Combobox, 8, 4);
            this.all_TablePanel.Controls.Add(this.relatedIdntity_Panel, 8, 8);
            this.all_TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.all_TablePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.all_TablePanel.Location = new System.Drawing.Point(3, 39);
            this.all_TablePanel.Name = "all_TablePanel";
            this.all_TablePanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_TablePanel.RowCount = 43;
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
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
            this.all_TablePanel.TabIndex = 84;
            // 
            // FNC_notes_Adj_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_notes_Adj_Label, 8);
            this.FNC_notes_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_notes_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.FNC_notes_Adj_Label.Location = new System.Drawing.Point(1204, 460);
            this.FNC_notes_Adj_Label.Name = "FNC_notes_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.FNC_notes_Adj_Label, 2);
            this.FNC_notes_Adj_Label.Size = new System.Drawing.Size(162, 40);
            this.FNC_notes_Adj_Label.TabIndex = 65;
            this.FNC_notes_Adj_Label.Text = "الملاحظات";
            this.FNC_notes_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FNC_notes_Textbox
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_notes_Textbox, 62);
            this.FNC_notes_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_notes_Textbox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNC_notes_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.FNC_notes_Textbox.IsPasswordTextbox = false;
            this.FNC_notes_Textbox.IsPlaceholder = true;
            this.FNC_notes_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNC_notes_Textbox.Location = new System.Drawing.Point(70, 503);
            this.FNC_notes_Textbox.Multiline = true;
            this.FNC_notes_Textbox.Name = "FNC_notes_Textbox";
            this.FNC_notes_Textbox.Placeholder = "الملاحظات";
            this.FNC_notes_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_notes_Textbox.placeholderFont = null;
            this.FNC_notes_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_TablePanel.SetRowSpan(this.FNC_notes_Textbox, 10);
            this.FNC_notes_Textbox.SelectedItem = null;
            this.FNC_notes_Textbox.Size = new System.Drawing.Size(1296, 194);
            this.FNC_notes_Textbox.TabIndex = 7;
            this.FNC_notes_Textbox.Tag = "";
            this.FNC_notes_Textbox.Text = "لا يوجد ملاحظات";
            this.FNC_notes_Textbox.Values = null;
            this.FNC_notes_Textbox.Visible_Password_Button = false;
            this.FNC_notes_Textbox.Enter += new System.EventHandler(this.FNC_Textbox_Enter);
            // 
            // FNC_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_Label, 46);
            this.FNC_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_Label.Font = new System.Drawing.Font("El Messiri", 11.8F);
            this.FNC_Label.Location = new System.Drawing.Point(364, 740);
            this.FNC_Label.Name = "FNC_Label";
            this.all_TablePanel.SetRowSpan(this.FNC_Label, 2);
            this.FNC_Label.Size = new System.Drawing.Size(960, 40);
            this.FNC_Label.TabIndex = 41;
            this.FNC_Label.Text = "message label";
            this.FNC_Label.Visible = false;
            // 
            // Add_FNC_Button
            // 
            this.Add_FNC_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.all_TablePanel.SetColumnSpan(this.Add_FNC_Button, 15);
            this.Add_FNC_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_FNC_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_FNC_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_FNC_Button.ForeColor = System.Drawing.Color.DarkRed;
            this.Add_FNC_Button.Location = new System.Drawing.Point(3, 763);
            this.Add_FNC_Button.Name = "Add_FNC_Button";
            this.all_TablePanel.SetRowSpan(this.Add_FNC_Button, 2);
            this.Add_FNC_Button.Size = new System.Drawing.Size(313, 43);
            this.Add_FNC_Button.TabIndex = 35;
            this.Add_FNC_Button.Text = "إضافة عملية مالية";
            this.Add_FNC_Button.UseVisualStyleBackColor = false;
            this.Add_FNC_Button.Click += new System.EventHandler(this.FNC_Button_Click);
            // 
            // FNC_due_date_Datetimepicker
            // 
            this.FNC_due_date_Datetimepicker.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F);
            this.all_TablePanel.SetColumnSpan(this.FNC_due_date_Datetimepicker, 28);
            this.FNC_due_date_Datetimepicker.ContextMenuStrip = this.DTPicker_contextMenuStrip;
            this.FNC_due_date_Datetimepicker.CustomFormat = "dddd, dd-MMMM-yyyy -- hh:mm tt";
            this.FNC_due_date_Datetimepicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_due_date_Datetimepicker.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.FNC_due_date_Datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FNC_due_date_Datetimepicker.Location = new System.Drawing.Point(553, 363);
            this.FNC_due_date_Datetimepicker.Name = "FNC_due_date_Datetimepicker";
            this.all_TablePanel.SetRowSpan(this.FNC_due_date_Datetimepicker, 2);
            this.FNC_due_date_Datetimepicker.Size = new System.Drawing.Size(582, 34);
            this.FNC_due_date_Datetimepicker.TabIndex = 8;
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
            this.nowStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.nowToolStripMenuItem_MouseDown);
            // 
            // FNC_done_date_Datetimepicker
            // 
            this.FNC_done_date_Datetimepicker.CalendarFont = new System.Drawing.Font("Times New Roman", 13.8F);
            this.FNC_done_date_Datetimepicker.Checked = false;
            this.all_TablePanel.SetColumnSpan(this.FNC_done_date_Datetimepicker, 28);
            this.FNC_done_date_Datetimepicker.ContextMenuStrip = this.DTPicker_contextMenuStrip;
            this.FNC_done_date_Datetimepicker.CustomFormat = "dddd, dd-MMMM-yyyy -- hh:mm tt";
            this.FNC_done_date_Datetimepicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_done_date_Datetimepicker.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.FNC_done_date_Datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FNC_done_date_Datetimepicker.Location = new System.Drawing.Point(553, 403);
            this.FNC_done_date_Datetimepicker.Name = "FNC_done_date_Datetimepicker";
            this.all_TablePanel.SetRowSpan(this.FNC_done_date_Datetimepicker, 2);
            this.FNC_done_date_Datetimepicker.ShowCheckBox = true;
            this.FNC_done_date_Datetimepicker.Size = new System.Drawing.Size(582, 34);
            this.FNC_done_date_Datetimepicker.TabIndex = 9;
            // 
            // FNC_due_Textbox
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_due_Textbox, 28);
            this.FNC_due_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_due_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FNC_due_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.FNC_due_Textbox.IsPasswordTextbox = false;
            this.FNC_due_Textbox.IsPlaceholder = true;
            this.FNC_due_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNC_due_Textbox.Location = new System.Drawing.Point(553, 263);
            this.FNC_due_Textbox.Name = "FNC_due_Textbox";
            this.FNC_due_Textbox.Placeholder = "القيمة المستحقة";
            this.FNC_due_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_due_Textbox.placeholderFont = null;
            this.FNC_due_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_TablePanel.SetRowSpan(this.FNC_due_Textbox, 2);
            this.FNC_due_Textbox.SelectedItem = null;
            this.FNC_due_Textbox.Size = new System.Drawing.Size(582, 38);
            this.FNC_due_Textbox.TabIndex = 7;
            this.FNC_due_Textbox.Tag = "";
            this.FNC_due_Textbox.Text = "القيمة المستحقة";
            this.FNC_due_Textbox.Values = null;
            this.FNC_due_Textbox.Visible_Password_Button = false;
            this.FNC_due_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.FNC_Textbox_cmnFlr_SelectedItemChanged);
            this.FNC_due_Textbox.TextChanged += new System.EventHandler(this.FNC_value_Textbox_TextChanged);
            this.FNC_due_Textbox.Enter += new System.EventHandler(this.FNC_Textbox_Enter);
            // 
            // FNC_paid_Textbox
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_paid_Textbox, 28);
            this.FNC_paid_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_paid_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FNC_paid_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.FNC_paid_Textbox.IsPasswordTextbox = false;
            this.FNC_paid_Textbox.IsPlaceholder = true;
            this.FNC_paid_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNC_paid_Textbox.Location = new System.Drawing.Point(553, 303);
            this.FNC_paid_Textbox.Name = "FNC_paid_Textbox";
            this.FNC_paid_Textbox.Placeholder = "المبلغ المدفوع";
            this.FNC_paid_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_paid_Textbox.placeholderFont = null;
            this.FNC_paid_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_TablePanel.SetRowSpan(this.FNC_paid_Textbox, 2);
            this.FNC_paid_Textbox.SelectedItem = null;
            this.FNC_paid_Textbox.Size = new System.Drawing.Size(582, 38);
            this.FNC_paid_Textbox.TabIndex = 6;
            this.FNC_paid_Textbox.Tag = "";
            this.FNC_paid_Textbox.Text = "المبلغ المدفوع";
            this.FNC_paid_Textbox.Values = null;
            this.FNC_paid_Textbox.Visible_Password_Button = false;
            this.FNC_paid_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.FNC_Textbox_cmnFlr_SelectedItemChanged);
            this.FNC_paid_Textbox.TextChanged += new System.EventHandler(this.FNC_value_Textbox_TextChanged);
            this.FNC_paid_Textbox.Enter += new System.EventHandler(this.FNC_Textbox_Enter);
            // 
            // FNC_due_date_Adj_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_due_date_Adj_Label, 8);
            this.FNC_due_date_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_due_date_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.FNC_due_date_Adj_Label.Location = new System.Drawing.Point(1141, 360);
            this.FNC_due_date_Adj_Label.Name = "FNC_due_date_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.FNC_due_date_Adj_Label, 2);
            this.FNC_due_date_Adj_Label.Size = new System.Drawing.Size(162, 40);
            this.FNC_due_date_Adj_Label.TabIndex = 63;
            this.FNC_due_date_Adj_Label.Text = "تاريخ الاستحقاق";
            this.FNC_due_date_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FNC_done_date_Adj_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_done_date_Adj_Label, 8);
            this.FNC_done_date_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_done_date_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.FNC_done_date_Adj_Label.Location = new System.Drawing.Point(1141, 400);
            this.FNC_done_date_Adj_Label.Name = "FNC_done_date_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.FNC_done_date_Adj_Label, 2);
            this.FNC_done_date_Adj_Label.Size = new System.Drawing.Size(162, 40);
            this.FNC_done_date_Adj_Label.TabIndex = 68;
            this.FNC_done_date_Adj_Label.Text = "تاريخ الدفع الفعلي";
            this.FNC_done_date_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FNC_value_Adj_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_value_Adj_Label, 8);
            this.FNC_value_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_value_Adj_Label.Font = new System.Drawing.Font("A Nasr", 14F);
            this.FNC_value_Adj_Label.Location = new System.Drawing.Point(1141, 260);
            this.FNC_value_Adj_Label.Name = "FNC_value_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.FNC_value_Adj_Label, 2);
            this.FNC_value_Adj_Label.Size = new System.Drawing.Size(162, 40);
            this.FNC_value_Adj_Label.TabIndex = 62;
            this.FNC_value_Adj_Label.Text = "المبلغ المستحق";
            this.FNC_value_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FNC_paid_Adj_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_paid_Adj_Label, 8);
            this.FNC_paid_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_paid_Adj_Label.Font = new System.Drawing.Font("A Nasr", 14F);
            this.FNC_paid_Adj_Label.Location = new System.Drawing.Point(1141, 300);
            this.FNC_paid_Adj_Label.Name = "FNC_paid_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.FNC_paid_Adj_Label, 2);
            this.FNC_paid_Adj_Label.Size = new System.Drawing.Size(162, 40);
            this.FNC_paid_Adj_Label.TabIndex = 71;
            this.FNC_paid_Adj_Label.Text = "المبلغ المدفوع";
            this.FNC_paid_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Del_FNC_Button
            // 
            this.Del_FNC_Button.BackColor = System.Drawing.Color.DarkRed;
            this.all_TablePanel.SetColumnSpan(this.Del_FNC_Button, 2);
            this.Del_FNC_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Del_FNC_Button.Font = new System.Drawing.Font("El Messiri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_FNC_Button.ForeColor = System.Drawing.Color.Black;
            this.Del_FNC_Button.Image = ((System.Drawing.Image)(resources.GetObject("Del_FNC_Button.Image")));
            this.Del_FNC_Button.ImageActive = null;
            this.Del_FNC_Button.Location = new System.Drawing.Point(28, 3);
            this.Del_FNC_Button.Name = "Del_FNC_Button";
            this.all_TablePanel.SetRowSpan(this.Del_FNC_Button, 2);
            this.Del_FNC_Button.Size = new System.Drawing.Size(36, 34);
            this.Del_FNC_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Del_FNC_Button.TabIndex = 54;
            this.Del_FNC_Button.TabStop = false;
            this.Del_FNC_Button.Text = "حذف عملية مالية";
            this.Del_FNC_Button.Visible = false;
            this.Del_FNC_Button.Zoom = 10;
            this.Del_FNC_Button.Click += new System.EventHandler(this.FNC_Button_Click);
            // 
            // FNC_id_Textbox
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_id_Textbox, 18);
            this.FNC_id_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_id_Textbox.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.FNC_id_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.FNC_id_Textbox.IsPasswordTextbox = false;
            this.FNC_id_Textbox.IsPlaceholder = true;
            this.FNC_id_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNC_id_Textbox.Location = new System.Drawing.Point(70, 3);
            this.FNC_id_Textbox.Name = "FNC_id_Textbox";
            this.FNC_id_Textbox.Placeholder = "كود العملية (أدخل أرقام فقط)[في حالة التعديل او الحذف فقط]";
            this.FNC_id_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_id_Textbox.placeholderFont = null;
            this.FNC_id_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_TablePanel.SetRowSpan(this.FNC_id_Textbox, 2);
            this.FNC_id_Textbox.SelectedItem = null;
            this.FNC_id_Textbox.Size = new System.Drawing.Size(372, 27);
            this.FNC_id_Textbox.TabIndex = 53;
            this.FNC_id_Textbox.Tag = "";
            this.FNC_id_Textbox.Text = "كود العملية (أدخل أرقام فقط)[في حالة التعديل او الحذف فقط]";
            this.FNC_id_Textbox.Values = null;
            this.FNC_id_Textbox.Visible = false;
            this.FNC_id_Textbox.Visible_Password_Button = false;
            this.FNC_id_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.FNC_id_Textbox_SelectedItemChanged);
            this.FNC_id_Textbox.TextChanged += new System.EventHandler(this.id_Textbox_TextChanged);
            // 
            // FNC_id_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_id_Label, 18);
            this.FNC_id_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_id_Label.Font = new System.Drawing.Font("El Messiri", 10.8F);
            this.FNC_id_Label.Location = new System.Drawing.Point(70, 40);
            this.FNC_id_Label.Name = "FNC_id_Label";
            this.all_TablePanel.SetRowSpan(this.FNC_id_Label, 3);
            this.FNC_id_Label.Size = new System.Drawing.Size(372, 40);
            this.FNC_id_Label.TabIndex = 52;
            this.FNC_id_Label.Text = "أدخل أرقام فقط";
            this.FNC_id_Label.Visible = false;
            // 
            // FNC_category_Textbox
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_category_Textbox, 35);
            this.FNC_category_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_category_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FNC_category_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.FNC_category_Textbox.IsPasswordTextbox = false;
            this.FNC_category_Textbox.IsPlaceholder = true;
            this.FNC_category_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNC_category_Textbox.Location = new System.Drawing.Point(469, 203);
            this.FNC_category_Textbox.Name = "FNC_category_Textbox";
            this.FNC_category_Textbox.Placeholder = "التصنيف";
            this.FNC_category_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_category_Textbox.placeholderFont = null;
            this.FNC_category_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.all_TablePanel.SetRowSpan(this.FNC_category_Textbox, 2);
            this.FNC_category_Textbox.SelectedItem = null;
            this.FNC_category_Textbox.Size = new System.Drawing.Size(729, 38);
            this.FNC_category_Textbox.TabIndex = 5;
            this.FNC_category_Textbox.Tag = "";
            this.FNC_category_Textbox.Text = "التصنيف";
            this.FNC_category_Textbox.Values = null;
            this.FNC_category_Textbox.Visible_Password_Button = false;
            this.FNC_category_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.FNC_Textbox_cmnFlr_SelectedItemChanged);
            this.FNC_category_Textbox.Enter += new System.EventHandler(this.FNC_Textbox_Enter);
            // 
            // FNC_category_Adj_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_category_Adj_Label, 6);
            this.FNC_category_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_category_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.FNC_category_Adj_Label.Location = new System.Drawing.Point(1225, 200);
            this.FNC_category_Adj_Label.Name = "FNC_category_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.FNC_category_Adj_Label, 2);
            this.FNC_category_Adj_Label.Size = new System.Drawing.Size(120, 40);
            this.FNC_category_Adj_Label.TabIndex = 61;
            this.FNC_category_Adj_Label.Text = "التصنيف";
            this.FNC_category_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FNC_type_Combobox
            // 
            this.FNC_type_Combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.all_TablePanel.SetColumnSpan(this.FNC_type_Combobox, 35);
            this.FNC_type_Combobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_type_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FNC_type_Combobox.Font = new System.Drawing.Font("El Messiri", 15F);
            this.FNC_type_Combobox.FormattingEnabled = true;
            this.FNC_type_Combobox.Location = new System.Drawing.Point(469, 3);
            this.FNC_type_Combobox.Name = "FNC_type_Combobox";
            this.all_TablePanel.SetRowSpan(this.FNC_type_Combobox, 3);
            this.FNC_type_Combobox.Size = new System.Drawing.Size(729, 47);
            this.FNC_type_Combobox.TabIndex = 1;
            this.FNC_type_Combobox.SelectedIndexChanged += new System.EventHandler(this.FNC_type_Combobox_SelectedIndexChanged);
            // 
            // FNC_Type_Adj_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_Type_Adj_Label, 8);
            this.FNC_Type_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_Type_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.FNC_Type_Adj_Label.Location = new System.Drawing.Point(1204, 0);
            this.FNC_Type_Adj_Label.Name = "FNC_Type_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.FNC_Type_Adj_Label, 3);
            this.FNC_Type_Adj_Label.Size = new System.Drawing.Size(162, 60);
            this.FNC_Type_Adj_Label.TabIndex = 37;
            this.FNC_Type_Adj_Label.Text = "نوع العملية المالية";
            this.FNC_Type_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FNC_wltName_Adj_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_wltName_Adj_Label, 8);
            this.FNC_wltName_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_wltName_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.FNC_wltName_Adj_Label.Location = new System.Drawing.Point(1204, 60);
            this.FNC_wltName_Adj_Label.Name = "FNC_wltName_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.FNC_wltName_Adj_Label, 3);
            this.FNC_wltName_Adj_Label.Size = new System.Drawing.Size(162, 60);
            this.FNC_wltName_Adj_Label.TabIndex = 73;
            this.FNC_wltName_Adj_Label.Text = "المحفظة";
            this.FNC_wltName_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FNC_relatedidentity_Adj_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.FNC_relatedidentity_Adj_Label, 8);
            this.FNC_relatedidentity_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_relatedidentity_Adj_Label.Font = new System.Drawing.Font("A Nasr", 12F);
            this.FNC_relatedidentity_Adj_Label.Location = new System.Drawing.Point(1204, 120);
            this.FNC_relatedidentity_Adj_Label.Name = "FNC_relatedidentity_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.FNC_relatedidentity_Adj_Label, 3);
            this.FNC_relatedidentity_Adj_Label.Size = new System.Drawing.Size(162, 60);
            this.FNC_relatedidentity_Adj_Label.TabIndex = 60;
            this.FNC_relatedidentity_Adj_Label.Text = "الجهة ذات الصلة";
            this.FNC_relatedidentity_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FNC_wallet_Combobox
            // 
            this.FNC_wallet_Combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.all_TablePanel.SetColumnSpan(this.FNC_wallet_Combobox, 35);
            this.FNC_wallet_Combobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_wallet_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FNC_wallet_Combobox.Font = new System.Drawing.Font("El Messiri", 15F);
            this.FNC_wallet_Combobox.FormattingEnabled = true;
            this.FNC_wallet_Combobox.Location = new System.Drawing.Point(469, 63);
            this.FNC_wallet_Combobox.Name = "FNC_wallet_Combobox";
            this.all_TablePanel.SetRowSpan(this.FNC_wallet_Combobox, 3);
            this.FNC_wallet_Combobox.Size = new System.Drawing.Size(729, 47);
            this.FNC_wallet_Combobox.TabIndex = 2;
            this.FNC_wallet_Combobox.SelectedIndexChanged += new System.EventHandler(this.FNC_wallet_Combobox_SelectedIndexChanged);
            // 
            // relatedIdntity_Panel
            // 
            this.all_TablePanel.SetColumnSpan(this.relatedIdntity_Panel, 35);
            this.relatedIdntity_Panel.Controls.Add(this.FNC_relatedentity_Textbox);
            this.relatedIdntity_Panel.Controls.Add(this.FNC_relatedentity_Combobox);
            this.relatedIdntity_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relatedIdntity_Panel.Location = new System.Drawing.Point(469, 123);
            this.relatedIdntity_Panel.Name = "relatedIdntity_Panel";
            this.all_TablePanel.SetRowSpan(this.relatedIdntity_Panel, 3);
            this.relatedIdntity_Panel.Size = new System.Drawing.Size(729, 54);
            this.relatedIdntity_Panel.TabIndex = 61;
            // 
            // FNC_relatedentity_Textbox
            // 
            this.FNC_relatedentity_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_relatedentity_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FNC_relatedentity_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.FNC_relatedentity_Textbox.IsPasswordTextbox = false;
            this.FNC_relatedentity_Textbox.IsPlaceholder = true;
            this.FNC_relatedentity_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNC_relatedentity_Textbox.Location = new System.Drawing.Point(0, 0);
            this.FNC_relatedentity_Textbox.Name = "FNC_relatedentity_Textbox";
            this.FNC_relatedentity_Textbox.Placeholder = "الجهة ذات الصلة";
            this.FNC_relatedentity_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_relatedentity_Textbox.placeholderFont = null;
            this.FNC_relatedentity_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FNC_relatedentity_Textbox.SelectedItem = null;
            this.FNC_relatedentity_Textbox.Size = new System.Drawing.Size(729, 38);
            this.FNC_relatedentity_Textbox.TabIndex = 4;
            this.FNC_relatedentity_Textbox.Tag = "";
            this.FNC_relatedentity_Textbox.Text = "الجهة ذات الصلة";
            this.FNC_relatedentity_Textbox.Values = null;
            this.FNC_relatedentity_Textbox.Visible_Password_Button = false;
            this.FNC_relatedentity_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.FNC_Textbox_cmnFlr_SelectedItemChanged);
            this.FNC_relatedentity_Textbox.Enter += new System.EventHandler(this.FNC_Textbox_Enter);
            // 
            // FNC_relatedentity_Combobox
            // 
            this.FNC_relatedentity_Combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.FNC_relatedentity_Combobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FNC_relatedentity_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FNC_relatedentity_Combobox.Font = new System.Drawing.Font("El Messiri", 15F);
            this.FNC_relatedentity_Combobox.FormattingEnabled = true;
            this.FNC_relatedentity_Combobox.Location = new System.Drawing.Point(0, 0);
            this.FNC_relatedentity_Combobox.Name = "FNC_relatedentity_Combobox";
            this.FNC_relatedentity_Combobox.Size = new System.Drawing.Size(729, 47);
            this.FNC_relatedentity_Combobox.TabIndex = 3;
            this.FNC_relatedentity_Combobox.Visible = false;
            this.FNC_relatedentity_Combobox.SelectedIndexChanged += new System.EventHandler(this.FNC_relatedwallet_Combobox_SelectedIndexChanged);
            // 
            // UsrCtrl_TgleBtn
            // 
            this.UsrCtrl_TgleBtn.BackColor = System.Drawing.Color.Transparent;
            this.UsrCtrl_TgleBtn.ForeColor = System.Drawing.Color.Silver;
            this.UsrCtrl_TgleBtn.Location = new System.Drawing.Point(0, -1);
            this.UsrCtrl_TgleBtn.MinimumSize = new System.Drawing.Size(45, 22);
            this.UsrCtrl_TgleBtn.Name = "UsrCtrl_TgleBtn";
            this.UsrCtrl_TgleBtn.OffBackColor = System.Drawing.Color.LightCoral;
            this.UsrCtrl_TgleBtn.OffToggleColor = System.Drawing.Color.DarkRed;
            this.UsrCtrl_TgleBtn.OnBackColor = System.Drawing.Color.RoyalBlue;
            this.UsrCtrl_TgleBtn.OnToggleColor = System.Drawing.Color.Navy;
            this.UsrCtrl_TgleBtn.Size = new System.Drawing.Size(70, 30);
            this.UsrCtrl_TgleBtn.TabIndex = 83;
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
            this.Main_SplitContainer.Panel1.Controls.Add(this.AddFinance_Groupbox);
            this.Main_SplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Main_SplitContainer.Panel1MinSize = 1;
            // 
            // Main_SplitContainer.Panel2
            // 
            this.Main_SplitContainer.Panel2.Controls.Add(this.ReqFNC_Button);
            this.Main_SplitContainer.Panel2.Controls.Add(this.FNC_Wallets_Button);
            this.Main_SplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Main_SplitContainer.Panel2MinSize = 1;
            this.Main_SplitContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Main_SplitContainer.Size = new System.Drawing.Size(1375, 930);
            this.Main_SplitContainer.SplitterDistance = 851;
            this.Main_SplitContainer.TabIndex = 53;
            // 
            // ReqFNC_Button
            // 
            this.ReqFNC_Button.BackColor = System.Drawing.Color.Transparent;
            this.ReqFNC_Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReqFNC_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ReqFNC_Button.Image = global::DailyCompanionV2.Properties.Resources.due_money;
            this.ReqFNC_Button.ImageActive = null;
            this.ReqFNC_Button.Location = new System.Drawing.Point(70, 0);
            this.ReqFNC_Button.Name = "ReqFNC_Button";
            this.ReqFNC_Button.Size = new System.Drawing.Size(70, 75);
            this.ReqFNC_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReqFNC_Button.TabIndex = 76;
            this.ReqFNC_Button.TabStop = false;
            this.ReqFNC_Button.Zoom = 10;
            this.ReqFNC_Button.Click += new System.EventHandler(this.ReqFNC_Button_Click);
            // 
            // FNC_Wallets_Button
            // 
            this.FNC_Wallets_Button.BackColor = System.Drawing.Color.Transparent;
            this.FNC_Wallets_Button.Dock = System.Windows.Forms.DockStyle.Left;
            this.FNC_Wallets_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FNC_Wallets_Button.Image = ((System.Drawing.Image)(resources.GetObject("FNC_Wallets_Button.Image")));
            this.FNC_Wallets_Button.ImageActive = null;
            this.FNC_Wallets_Button.Location = new System.Drawing.Point(0, 0);
            this.FNC_Wallets_Button.Name = "FNC_Wallets_Button";
            this.FNC_Wallets_Button.Size = new System.Drawing.Size(70, 75);
            this.FNC_Wallets_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FNC_Wallets_Button.TabIndex = 75;
            this.FNC_Wallets_Button.TabStop = false;
            this.FNC_Wallets_Button.Zoom = 10;
            this.FNC_Wallets_Button.Click += new System.EventHandler(this.FNC_Wallets_Button_Click);
            // 
            // Side_Panel
            // 
            this.Side_Panel.Controls.Add(this.sidePanel_Treeview);
            this.Side_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Side_Panel.Location = new System.Drawing.Point(0, 0);
            this.Side_Panel.Name = "Side_Panel";
            this.Side_Panel.Size = new System.Drawing.Size(300, 930);
            this.Side_Panel.TabIndex = 94;
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
            // UsrCtrl_Finances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Main_SplitContainer);
            this.Controls.Add(this.Side_Panel);
            this.Name = "UsrCtrl_Finances";
            this.Size = new System.Drawing.Size(1675, 930);
            this.FNCReq_Groupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reqFNC_Objectlistview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wlts_Search_Objectlistview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wlts_Objectlistview)).EndInit();
            this.AddFinance_Groupbox.ResumeLayout(false);
            this.Aux_Panel.ResumeLayout(false);
            this.aux_TablePanel.ResumeLayout(false);
            this.aux_TablePanel.PerformLayout();
            this.auxContent_Panel.ResumeLayout(false);
            this.FNCWallets_Groupbox.ResumeLayout(false);
            this.Wallets_TablePanel.ResumeLayout(false);
            this.all_TablePanel.ResumeLayout(false);
            this.all_TablePanel.PerformLayout();
            this.DTPicker_contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Del_FNC_Button)).EndInit();
            this.relatedIdntity_Panel.ResumeLayout(false);
            this.relatedIdntity_Panel.PerformLayout();
            this.Tabcontrol_contextMenuStrip.ResumeLayout(false);
            this.Main_SplitContainer.Panel1.ResumeLayout(false);
            this.Main_SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_SplitContainer)).EndInit();
            this.Main_SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReqFNC_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FNC_Wallets_Button)).EndInit();
            this.Side_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddFinance_Groupbox;
        private System.Windows.Forms.Button Add_FNC_Button;
        private ModdedControls.ModdedTextBox FNC_notes_Textbox;
        private ModdedTextBox FNC_category_Textbox;
        private ModdedTextBox FNC_relatedentity_Textbox;
        private System.Windows.Forms.Label FNC_Type_Adj_Label;
        private System.Windows.Forms.Label FNC_Label;
        private ModdedTextBox FNC_due_Textbox;
        private System.Windows.Forms.ComboBox FNC_type_Combobox;
        private BrightIdeasSoftware.OLVColumn cityColumn;
        private Label FNC_id_Label;
        private ModdedTextBox FNC_id_Textbox;
        private ns1.BunifuImageButton Del_FNC_Button;
        private Label FNC_due_date_Adj_Label;
        private Label FNC_value_Adj_Label;
        private Label FNC_category_Adj_Label;
        private Label FNC_notes_Adj_Label;
        private DateTimePicker FNC_due_date_Datetimepicker;
        private DateTimePicker FNC_done_date_Datetimepicker;
        private Label FNC_done_date_Adj_Label;
        private Label FNC_paid_Adj_Label;
        private ModdedTextBox FNC_paid_Textbox;
        private Label FNC_relatedidentity_Adj_Label;
        private ComboBox FNC_wallet_Combobox;
        private Label FNC_wltName_Adj_Label;
        private ComboBox FNC_relatedentity_Combobox;
        private BrightIdeasSoftware.ObjectListView Wlts_Objectlistview;
        private BrightIdeasSoftware.OLVColumn FinanceWallet_Column;
        private BrightIdeasSoftware.OLVColumn FinanceRelatedentity_Column;
        private BrightIdeasSoftware.OLVColumn FinanceType_Column;
        private BrightIdeasSoftware.OLVColumn FinanceCategory_Column;
        private BrightIdeasSoftware.OLVColumn FinanceDue_Column;
        private BrightIdeasSoftware.OLVColumn FinancePaid_Column;
        private BrightIdeasSoftware.OLVColumn FinancialDonedate_Column;
        private BrightIdeasSoftware.ObjectListView Wlts_Search_Objectlistview;
        private BrightIdeasSoftware.OLVColumn Wlt_Id_Column;
        private BrightIdeasSoftware.OLVColumn Wlt_Name_Column;
        private BrightIdeasSoftware.OLVColumn Wlt_credit_Column;
        private Label WalletsSearch_Label;
        private GroupBox FNCReq_Groupbox;
        private DateTimePicker FNC_AuxTo_Datetimepicker;
        private DateTimePicker FNC_AuxFrom_Datetimepicker;
        private BrightIdeasSoftware.ObjectListView reqFNC_Objectlistview;
        private BrightIdeasSoftware.OLVColumn CatFNC_Column;
        private BrightIdeasSoftware.OLVColumn TypFNC_Column;
        private BrightIdeasSoftware.OLVColumn finalFNC_Column;
        private BrightIdeasSoftware.OLVColumn DueFNC_Column;
        private ContextMenuStrip Tabcontrol_contextMenuStrip;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private SplitContainer Main_SplitContainer;
        private Panel Side_Panel;
        private TreeView sidePanel_Treeview;
        private CustomControls.RJControls.RJToggleButton UsrCtrl_TgleBtn;
        private TableLayoutPanel all_TablePanel;
        private Panel relatedIdntity_Panel;
        private ns1.BunifuImageButton ReqFNC_Button;
        private ns1.BunifuImageButton FNC_Wallets_Button;
        private TableLayoutPanel aux_TablePanel;
        private Label FNC_AuxTo_Adj_Label;
        private Label FNC_AuxFrom_Adj_Label;
        private Button FNC_Aux_SearchButton;
        private Label AuxComment_Label;
        private Panel auxContent_Panel;
        private Panel Aux_Panel;
        private GroupBox FNCWallets_Groupbox;
        private TableLayoutPanel Wallets_TablePanel;
        private ContextMenuStrip DTPicker_contextMenuStrip;
        private ToolStripMenuItem nowStripMenuItem;
    }
}
