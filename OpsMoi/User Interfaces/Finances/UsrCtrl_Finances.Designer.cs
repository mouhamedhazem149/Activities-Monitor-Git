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
            this.SearchOps_Wlt_TileButton = new ns1.BunifuTileButton();
            this.SearchOps_Wlt_Tabpage = new System.Windows.Forms.TabPage();
            this.WalletsSearch_Label = new System.Windows.Forms.Label();
            this.Wlts_Search_Objectlistview = new BrightIdeasSoftware.ObjectListView();
            this.Wlt_Id_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Wlt_Name_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Wlt_credit_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.WltsOps_From_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.WltsOps_To_Datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.WltsOps_From_Adj_Label = new System.Windows.Forms.Label();
            this.WltsOps_To_Adj_Label = new System.Windows.Forms.Label();
            this.WltsOps_Label = new System.Windows.Forms.Label();
            this.WltsOps_Search_Button = new System.Windows.Forms.Button();
            this.Wlts_Objectlistview = new BrightIdeasSoftware.ObjectListView();
            this.FinanceWallet_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FinanceRelatedentity_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FinanceType_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FinanceCategory_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FinanceDue_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FinancePaid_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FinancialDonedate_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.FNCManager_TileButton = new ns1.BunifuTileButton();
            this.FNCmanage_Tabpage = new System.Windows.Forms.TabPage();
            this.AddFinance_Groupbox = new System.Windows.Forms.GroupBox();
            this.FNC_relatedentity_Combobox = new System.Windows.Forms.ComboBox();
            this.FNC_wallet_Combobox = new System.Windows.Forms.ComboBox();
            this.Name_Label = new System.Windows.Forms.Label();
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
            this.SearchOps_Wlt_Tabpage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wlts_Search_Objectlistview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wlts_Objectlistview)).BeginInit();
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
            // SearchOps_Wlt_TileButton
            // 
            this.SearchOps_Wlt_TileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchOps_Wlt_TileButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchOps_Wlt_TileButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.SearchOps_Wlt_TileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchOps_Wlt_TileButton.Font = new System.Drawing.Font("A Nasr", 20F);
            this.SearchOps_Wlt_TileButton.ForeColor = System.Drawing.Color.Black;
            this.SearchOps_Wlt_TileButton.Image = null;
            this.SearchOps_Wlt_TileButton.ImagePosition = 0;
            this.SearchOps_Wlt_TileButton.ImageZoom = 0;
            this.SearchOps_Wlt_TileButton.LabelPosition = 180;
            this.SearchOps_Wlt_TileButton.LabelText = "العمليات المالية للمحافظ";
            this.SearchOps_Wlt_TileButton.Location = new System.Drawing.Point(2, 318);
            this.SearchOps_Wlt_TileButton.Margin = new System.Windows.Forms.Padding(7);
            this.SearchOps_Wlt_TileButton.Name = "SearchOps_Wlt_TileButton";
            this.SearchOps_Wlt_TileButton.Size = new System.Drawing.Size(189, 316);
            this.SearchOps_Wlt_TileButton.TabIndex = 48;
            this.SearchOps_Wlt_TileButton.Tag = this.SearchOps_Wlt_Tabpage;
            this.SearchOps_Wlt_TileButton.Click += new System.EventHandler(this.TileButton_Click);
            // 
            // SearchOps_Wlt_Tabpage
            // 
            this.SearchOps_Wlt_Tabpage.Controls.Add(this.WalletsSearch_Label);
            this.SearchOps_Wlt_Tabpage.Controls.Add(this.Wlts_Search_Objectlistview);
            this.SearchOps_Wlt_Tabpage.Controls.Add(this.WltsOps_From_Datetimepicker);
            this.SearchOps_Wlt_Tabpage.Controls.Add(this.WltsOps_To_Datetimepicker);
            this.SearchOps_Wlt_Tabpage.Controls.Add(this.WltsOps_From_Adj_Label);
            this.SearchOps_Wlt_Tabpage.Controls.Add(this.WltsOps_To_Adj_Label);
            this.SearchOps_Wlt_Tabpage.Controls.Add(this.WltsOps_Label);
            this.SearchOps_Wlt_Tabpage.Controls.Add(this.WltsOps_Search_Button);
            this.SearchOps_Wlt_Tabpage.Controls.Add(this.Wlts_Objectlistview);
            this.SearchOps_Wlt_Tabpage.Location = new System.Drawing.Point(5, 4);
            this.SearchOps_Wlt_Tabpage.Name = "SearchOps_Wlt_Tabpage";
            this.SearchOps_Wlt_Tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchOps_Wlt_Tabpage.Size = new System.Drawing.Size(1601, 899);
            this.SearchOps_Wlt_Tabpage.TabIndex = 1;
            this.SearchOps_Wlt_Tabpage.Text = "بحث / تعديل";
            this.SearchOps_Wlt_Tabpage.UseVisualStyleBackColor = true;
            // 
            // WalletsSearch_Label
            // 
            this.WalletsSearch_Label.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WalletsSearch_Label.ForeColor = System.Drawing.Color.Maroon;
            this.WalletsSearch_Label.Location = new System.Drawing.Point(162, 7);
            this.WalletsSearch_Label.Name = "WalletsSearch_Label";
            this.WalletsSearch_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WalletsSearch_Label.Size = new System.Drawing.Size(886, 27);
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
            this.Wlts_Search_Objectlistview.EmptyListMsg = "لا يوجد عناصر";
            this.Wlts_Search_Objectlistview.EmptyListMsgFont = new System.Drawing.Font("Cairo SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlts_Search_Objectlistview.Font = new System.Drawing.Font("El Messiri", 10F);
            this.Wlts_Search_Objectlistview.FullRowSelect = true;
            this.Wlts_Search_Objectlistview.HideSelection = false;
            this.Wlts_Search_Objectlistview.Location = new System.Drawing.Point(6, 39);
            this.Wlts_Search_Objectlistview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Wlts_Search_Objectlistview.Name = "Wlts_Search_Objectlistview";
            this.Wlts_Search_Objectlistview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Wlts_Search_Objectlistview.RightToLeftLayout = true;
            this.Wlts_Search_Objectlistview.ShowCommandMenuOnRightClick = true;
            this.Wlts_Search_Objectlistview.Size = new System.Drawing.Size(1041, 270);
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
            // WltsOps_From_Datetimepicker
            // 
            this.WltsOps_From_Datetimepicker.CalendarFont = new System.Drawing.Font("El Messiri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WltsOps_From_Datetimepicker.Font = new System.Drawing.Font("El Messiri", 9F);
            this.WltsOps_From_Datetimepicker.Location = new System.Drawing.Point(1232, 14);
            this.WltsOps_From_Datetimepicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WltsOps_From_Datetimepicker.Name = "WltsOps_From_Datetimepicker";
            this.WltsOps_From_Datetimepicker.Size = new System.Drawing.Size(331, 31);
            this.WltsOps_From_Datetimepicker.TabIndex = 37;
            this.WltsOps_From_Datetimepicker.Tag = "From";
            this.WltsOps_From_Datetimepicker.Value = new System.DateTime(2021, 10, 19, 0, 0, 0, 0);
            // 
            // WltsOps_To_Datetimepicker
            // 
            this.WltsOps_To_Datetimepicker.CalendarFont = new System.Drawing.Font("El Messiri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WltsOps_To_Datetimepicker.Font = new System.Drawing.Font("El Messiri", 9F);
            this.WltsOps_To_Datetimepicker.Location = new System.Drawing.Point(1232, 62);
            this.WltsOps_To_Datetimepicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WltsOps_To_Datetimepicker.Name = "WltsOps_To_Datetimepicker";
            this.WltsOps_To_Datetimepicker.Size = new System.Drawing.Size(331, 31);
            this.WltsOps_To_Datetimepicker.TabIndex = 38;
            this.WltsOps_To_Datetimepicker.Tag = "To";
            this.WltsOps_To_Datetimepicker.Value = new System.DateTime(2021, 10, 19, 0, 0, 0, 0);
            // 
            // WltsOps_From_Adj_Label
            // 
            this.WltsOps_From_Adj_Label.AutoSize = true;
            this.WltsOps_From_Adj_Label.Font = new System.Drawing.Font("El Messiri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WltsOps_From_Adj_Label.ForeColor = System.Drawing.Color.Brown;
            this.WltsOps_From_Adj_Label.Location = new System.Drawing.Point(1567, 17);
            this.WltsOps_From_Adj_Label.Name = "WltsOps_From_Adj_Label";
            this.WltsOps_From_Adj_Label.Size = new System.Drawing.Size(28, 23);
            this.WltsOps_From_Adj_Label.TabIndex = 40;
            this.WltsOps_From_Adj_Label.Text = "من";
            // 
            // WltsOps_To_Adj_Label
            // 
            this.WltsOps_To_Adj_Label.AutoSize = true;
            this.WltsOps_To_Adj_Label.Font = new System.Drawing.Font("El Messiri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WltsOps_To_Adj_Label.ForeColor = System.Drawing.Color.Brown;
            this.WltsOps_To_Adj_Label.Location = new System.Drawing.Point(1569, 67);
            this.WltsOps_To_Adj_Label.Name = "WltsOps_To_Adj_Label";
            this.WltsOps_To_Adj_Label.Size = new System.Drawing.Size(32, 23);
            this.WltsOps_To_Adj_Label.TabIndex = 41;
            this.WltsOps_To_Adj_Label.Text = "إلى";
            // 
            // WltsOps_Label
            // 
            this.WltsOps_Label.ForeColor = System.Drawing.Color.Maroon;
            this.WltsOps_Label.Location = new System.Drawing.Point(1232, 111);
            this.WltsOps_Label.Name = "WltsOps_Label";
            this.WltsOps_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WltsOps_Label.Size = new System.Drawing.Size(363, 99);
            this.WltsOps_Label.TabIndex = 42;
            this.WltsOps_Label.Text = "label15";
            this.WltsOps_Label.Visible = false;
            // 
            // WltsOps_Search_Button
            // 
            this.WltsOps_Search_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.WltsOps_Search_Button.FlatAppearance.BorderSize = 0;
            this.WltsOps_Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WltsOps_Search_Button.Font = new System.Drawing.Font("El Messiri", 10F);
            this.WltsOps_Search_Button.ForeColor = System.Drawing.Color.Black;
            this.WltsOps_Search_Button.Location = new System.Drawing.Point(1095, 30);
            this.WltsOps_Search_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WltsOps_Search_Button.Name = "WltsOps_Search_Button";
            this.WltsOps_Search_Button.Size = new System.Drawing.Size(112, 44);
            this.WltsOps_Search_Button.TabIndex = 39;
            this.WltsOps_Search_Button.Text = "بحث";
            this.WltsOps_Search_Button.UseVisualStyleBackColor = false;
            this.WltsOps_Search_Button.Click += new System.EventHandler(this.WltsOps_Search_Button_Click);
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
            this.Wlts_Objectlistview.Cursor = System.Windows.Forms.Cursors.Default;
            this.Wlts_Objectlistview.EmptyListMsg = "لا يوجد عناصر";
            this.Wlts_Objectlistview.EmptyListMsgFont = new System.Drawing.Font("Cairo SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wlts_Objectlistview.Font = new System.Drawing.Font("El Messiri", 10F);
            this.Wlts_Objectlistview.FullRowSelect = true;
            this.Wlts_Objectlistview.HideSelection = false;
            this.Wlts_Objectlistview.Location = new System.Drawing.Point(6, 313);
            this.Wlts_Objectlistview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Wlts_Objectlistview.Name = "Wlts_Objectlistview";
            this.Wlts_Objectlistview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Wlts_Objectlistview.RightToLeftLayout = true;
            this.Wlts_Objectlistview.ShowCommandMenuOnRightClick = true;
            this.Wlts_Objectlistview.Size = new System.Drawing.Size(1589, 580);
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
            this.AddFinance_Groupbox.Controls.Add(this.FNC_relatedentity_Combobox);
            this.AddFinance_Groupbox.Controls.Add(this.FNC_wallet_Combobox);
            this.AddFinance_Groupbox.Controls.Add(this.Name_Label);
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
            // FNC_relatedentity_Combobox
            // 
            this.FNC_relatedentity_Combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.FNC_relatedentity_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FNC_relatedentity_Combobox.Font = new System.Drawing.Font("El Messiri", 15F);
            this.FNC_relatedentity_Combobox.FormattingEnabled = true;
            this.FNC_relatedentity_Combobox.Location = new System.Drawing.Point(734, 36);
            this.FNC_relatedentity_Combobox.Name = "FNC_relatedentity_Combobox";
            this.FNC_relatedentity_Combobox.Size = new System.Drawing.Size(685, 47);
            this.FNC_relatedentity_Combobox.TabIndex = 3;
            this.FNC_relatedentity_Combobox.Visible = false;
            this.FNC_relatedentity_Combobox.SelectedIndexChanged += new System.EventHandler(this.FNC_relatedwallet_Combobox_SelectedIndexChanged);
            // 
            // FNC_wallet_Combobox
            // 
            this.FNC_wallet_Combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.FNC_wallet_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FNC_wallet_Combobox.Font = new System.Drawing.Font("El Messiri", 15F);
            this.FNC_wallet_Combobox.FormattingEnabled = true;
            this.FNC_wallet_Combobox.Location = new System.Drawing.Point(734, 89);
            this.FNC_wallet_Combobox.Name = "FNC_wallet_Combobox";
            this.FNC_wallet_Combobox.Size = new System.Drawing.Size(685, 47);
            this.FNC_wallet_Combobox.TabIndex = 2;
            this.FNC_wallet_Combobox.SelectedIndexChanged += new System.EventHandler(this.FNC_wallet_Combobox_SelectedIndexChanged);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.Name_Label.Location = new System.Drawing.Point(1449, 94);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(80, 33);
            this.Name_Label.TabIndex = 73;
            this.Name_Label.Text = "المحفظة";
            // 
            // FNC_paid_Adj_Label
            // 
            this.FNC_paid_Adj_Label.AutoSize = true;
            this.FNC_paid_Adj_Label.Font = new System.Drawing.Font("A Nasr", 14F);
            this.FNC_paid_Adj_Label.Location = new System.Drawing.Point(1445, 251);
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
            this.FNC_paid_Textbox.Location = new System.Drawing.Point(541, 246);
            this.FNC_paid_Textbox.Name = "FNC_paid_Textbox";
            this.FNC_paid_Textbox.Placeholder = "المبلغ المدفوع";
            this.FNC_paid_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_paid_Textbox.placeholderFont = null;
            this.FNC_paid_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FNC_paid_Textbox.SelectedItem = null;
            this.FNC_paid_Textbox.Size = new System.Drawing.Size(891, 38);
            this.FNC_paid_Textbox.TabIndex = 6;
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
            this.FNC_done_date_Datetimepicker.Location = new System.Drawing.Point(821, 401);
            this.FNC_done_date_Datetimepicker.Name = "FNC_done_date_Datetimepicker";
            this.FNC_done_date_Datetimepicker.ShowCheckBox = true;
            this.FNC_done_date_Datetimepicker.Size = new System.Drawing.Size(548, 34);
            this.FNC_done_date_Datetimepicker.TabIndex = 9;
            // 
            // FNC_done_date_Adj_Label
            // 
            this.FNC_done_date_Adj_Label.AutoSize = true;
            this.FNC_done_date_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.FNC_done_date_Adj_Label.Location = new System.Drawing.Point(1428, 403);
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
            this.FNC_due_date_Datetimepicker.Location = new System.Drawing.Point(871, 345);
            this.FNC_due_date_Datetimepicker.Name = "FNC_due_date_Datetimepicker";
            this.FNC_due_date_Datetimepicker.Size = new System.Drawing.Size(498, 34);
            this.FNC_due_date_Datetimepicker.TabIndex = 8;
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
            this.FNC_due_date_Adj_Label.Location = new System.Drawing.Point(1445, 347);
            this.FNC_due_date_Adj_Label.Name = "FNC_due_date_Adj_Label";
            this.FNC_due_date_Adj_Label.Size = new System.Drawing.Size(121, 33);
            this.FNC_due_date_Adj_Label.TabIndex = 63;
            this.FNC_due_date_Adj_Label.Text = "تاريخ الاستحقاق";
            // 
            // FNC_value_Adj_Label
            // 
            this.FNC_value_Adj_Label.AutoSize = true;
            this.FNC_value_Adj_Label.Font = new System.Drawing.Font("A Nasr", 14F);
            this.FNC_value_Adj_Label.Location = new System.Drawing.Point(1441, 302);
            this.FNC_value_Adj_Label.Name = "FNC_value_Adj_Label";
            this.FNC_value_Adj_Label.Size = new System.Drawing.Size(118, 31);
            this.FNC_value_Adj_Label.TabIndex = 62;
            this.FNC_value_Adj_Label.Text = "المبلغ المستحق";
            // 
            // FNC_category_Adj_Label
            // 
            this.FNC_category_Adj_Label.AutoSize = true;
            this.FNC_category_Adj_Label.Font = new System.Drawing.Font("A Nasr", 15F);
            this.FNC_category_Adj_Label.Location = new System.Drawing.Point(1471, 198);
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
            this.FNC_id_Textbox.Location = new System.Drawing.Point(31, 51);
            this.FNC_id_Textbox.Name = "FNC_id_Textbox";
            this.FNC_id_Textbox.Placeholder = "كود العملية (أدخل أرقام فقط)[في حالة التعديل او الحذف فقط]";
            this.FNC_id_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_id_Textbox.placeholderFont = null;
            this.FNC_id_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FNC_id_Textbox.SelectedItem = null;
            this.FNC_id_Textbox.Size = new System.Drawing.Size(468, 27);
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
            this.id_Label.Location = new System.Drawing.Point(31, 81);
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
            this.FNC_type_Combobox.Location = new System.Drawing.Point(734, 142);
            this.FNC_type_Combobox.Name = "FNC_type_Combobox";
            this.FNC_type_Combobox.Size = new System.Drawing.Size(685, 47);
            this.FNC_type_Combobox.TabIndex = 1;
            this.FNC_type_Combobox.SelectedIndexChanged += new System.EventHandler(this.FNC_type_Combobox_SelectedIndexChanged);
            // 
            // FNC_due_Textbox
            // 
            this.FNC_due_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FNC_due_Textbox.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.FNC_due_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.FNC_due_Textbox.IsPasswordTextbox = false;
            this.FNC_due_Textbox.IsPlaceholder = true;
            this.FNC_due_Textbox.Location = new System.Drawing.Point(541, 297);
            this.FNC_due_Textbox.Name = "FNC_due_Textbox";
            this.FNC_due_Textbox.Placeholder = "القيمة المستحقة";
            this.FNC_due_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_due_Textbox.placeholderFont = null;
            this.FNC_due_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FNC_due_Textbox.SelectedItem = null;
            this.FNC_due_Textbox.Size = new System.Drawing.Size(891, 38);
            this.FNC_due_Textbox.TabIndex = 7;
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
            this.Type_Label.Location = new System.Drawing.Point(1425, 151);
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
            this.FNC_category_Textbox.Location = new System.Drawing.Point(541, 195);
            this.FNC_category_Textbox.Name = "FNC_category_Textbox";
            this.FNC_category_Textbox.Placeholder = "التصنيف";
            this.FNC_category_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.FNC_category_Textbox.placeholderFont = null;
            this.FNC_category_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FNC_category_Textbox.SelectedItem = null;
            this.FNC_category_Textbox.Size = new System.Drawing.Size(891, 38);
            this.FNC_category_Textbox.TabIndex = 5;
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
            this.FNC_relatedentity_Textbox.TabIndex = 4;
            this.FNC_relatedentity_Textbox.Tag = "";
            this.FNC_relatedentity_Textbox.Text = "الجهة ذات الصلة";
            this.FNC_relatedentity_Textbox.Values = null;
            this.FNC_relatedentity_Textbox.Visible_Password_Button = false;
            // 
            // TileButtons_Panel
            // 
            this.TileButtons_Panel.Controls.Add(this.SearchOps_Wlt_TileButton);
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
            this.FNC_TabControl.Controls.Add(this.SearchOps_Wlt_Tabpage);
            this.FNC_TabControl.Controls.Add(this.Req_Tabpage);
            this.FNC_TabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.FNC_TabControl.Location = new System.Drawing.Point(193, 0);
            this.FNC_TabControl.Multiline = true;
            this.FNC_TabControl.Name = "FNC_TabControl";
            this.FNC_TabControl.SelectedIndex = 0;
            this.FNC_TabControl.Size = new System.Drawing.Size(1610, 907);
            this.FNC_TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.FNC_TabControl.TabIndex = 44;
            this.FNC_TabControl.SelectedIndexChanged += new System.EventHandler(this.FNC_TabControl_SelectedIndexChanged);
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
            this.SearchOps_Wlt_Tabpage.ResumeLayout(false);
            this.SearchOps_Wlt_Tabpage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wlts_Search_Objectlistview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wlts_Objectlistview)).EndInit();
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
        private TabPage SearchOps_Wlt_Tabpage;
        private TabPage Req_Tabpage;
        private Panel SidePanel1;
        private ns1.BunifuTileButton Req_MTN_TileButton;
        private ns1.BunifuTileButton SearchOps_Wlt_TileButton;
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
        private ComboBox FNC_wallet_Combobox;
        private Label Name_Label;
        private ComboBox FNC_relatedentity_Combobox;
        private BrightIdeasSoftware.ObjectListView Wlts_Objectlistview;
        private BrightIdeasSoftware.OLVColumn FinanceWallet_Column;
        private BrightIdeasSoftware.OLVColumn FinanceRelatedentity_Column;
        private BrightIdeasSoftware.OLVColumn FinanceType_Column;
        private BrightIdeasSoftware.OLVColumn FinanceCategory_Column;
        private BrightIdeasSoftware.OLVColumn FinanceDue_Column;
        private BrightIdeasSoftware.OLVColumn FinancePaid_Column;
        private BrightIdeasSoftware.OLVColumn FinancialDonedate_Column;
        private DateTimePicker WltsOps_From_Datetimepicker;
        private DateTimePicker WltsOps_To_Datetimepicker;
        private Label WltsOps_From_Adj_Label;
        private Label WltsOps_To_Adj_Label;
        private Label WltsOps_Label;
        private Button WltsOps_Search_Button;
        private BrightIdeasSoftware.ObjectListView Wlts_Search_Objectlistview;
        private BrightIdeasSoftware.OLVColumn Wlt_Id_Column;
        private BrightIdeasSoftware.OLVColumn Wlt_Name_Column;
        private BrightIdeasSoftware.OLVColumn Wlt_credit_Column;
        private Label WalletsSearch_Label;
    }
}
