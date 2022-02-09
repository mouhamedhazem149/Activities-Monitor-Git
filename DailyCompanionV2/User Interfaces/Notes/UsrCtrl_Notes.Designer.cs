using ModdedControls;

namespace DailyCompanionV2.User_Interfaces
{
    partial class UsrCtrl_Notes
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
            this.Note_Groupbox = new System.Windows.Forms.GroupBox();
            this.UsrCtrl_TgleBtn = new CustomControls.RJControls.RJToggleButton();
            this.all_TablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.Add_NOT_Button = new System.Windows.Forms.Button();
            this.Encrypt_Button = new System.Windows.Forms.Button();
            this.Decrypt_Button = new System.Windows.Forms.Button();
            this.Del_NOT_Button = new ns1.BunifuImageButton();
            this.NOT_strNote_Textbox = new ModdedControls.ModdedTextBox();
            this.NOT_title_Adj_Label = new System.Windows.Forms.Label();
            this.NOT_title_Textbox = new ModdedControls.ModdedTextBox();
            this.Not_Label = new System.Windows.Forms.Label();
            this.Tabcontrol_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.sidePanel_Treeview = new System.Windows.Forms.TreeView();
            this.Main_SplitContainer = new System.Windows.Forms.SplitContainer();
            this.Note_Groupbox.SuspendLayout();
            this.all_TablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Del_NOT_Button)).BeginInit();
            this.Tabcontrol_contextMenuStrip.SuspendLayout();
            this.Side_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Main_SplitContainer)).BeginInit();
            this.Main_SplitContainer.Panel1.SuspendLayout();
            this.Main_SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Note_Groupbox
            // 
            this.Note_Groupbox.Controls.Add(this.UsrCtrl_TgleBtn);
            this.Note_Groupbox.Controls.Add(this.all_TablePanel);
            this.Note_Groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Note_Groupbox.Font = new System.Drawing.Font("El Messiri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note_Groupbox.ForeColor = System.Drawing.Color.DarkRed;
            this.Note_Groupbox.Location = new System.Drawing.Point(0, 0);
            this.Note_Groupbox.Name = "Note_Groupbox";
            this.Note_Groupbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Note_Groupbox.Size = new System.Drawing.Size(1375, 851);
            this.Note_Groupbox.TabIndex = 2;
            this.Note_Groupbox.TabStop = false;
            this.Note_Groupbox.Text = "إضافة ملاحظات";
            // 
            // UsrCtrl_TgleBtn
            // 
            this.UsrCtrl_TgleBtn.BackColor = System.Drawing.Color.Transparent;
            this.UsrCtrl_TgleBtn.ForeColor = System.Drawing.Color.Silver;
            this.UsrCtrl_TgleBtn.Location = new System.Drawing.Point(0, 0);
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
            this.all_TablePanel.Controls.Add(this.Add_NOT_Button, 52, 39);
            this.all_TablePanel.Controls.Add(this.Encrypt_Button, 2, 33);
            this.all_TablePanel.Controls.Add(this.Decrypt_Button, 18, 33);
            this.all_TablePanel.Controls.Add(this.Del_NOT_Button, 62, 0);
            this.all_TablePanel.Controls.Add(this.NOT_strNote_Textbox, 2, 3);
            this.all_TablePanel.Controls.Add(this.NOT_title_Adj_Label, 0, 0);
            this.all_TablePanel.Controls.Add(this.NOT_title_Textbox, 7, 0);
            this.all_TablePanel.Controls.Add(this.Not_Label, 2, 36);
            this.all_TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.all_TablePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.all_TablePanel.Location = new System.Drawing.Point(3, 39);
            this.all_TablePanel.Name = "all_TablePanel";
            this.all_TablePanel.RowCount = 41;
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
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
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            this.all_TablePanel.Size = new System.Drawing.Size(1369, 809);
            this.all_TablePanel.TabIndex = 65;
            // 
            // Add_NOT_Button
            // 
            this.Add_NOT_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.all_TablePanel.SetColumnSpan(this.Add_NOT_Button, 13);
            this.Add_NOT_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_NOT_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_NOT_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_NOT_Button.ForeColor = System.Drawing.Color.DarkRed;
            this.Add_NOT_Button.Location = new System.Drawing.Point(3, 766);
            this.Add_NOT_Button.Name = "Add_NOT_Button";
            this.all_TablePanel.SetRowSpan(this.Add_NOT_Button, 2);
            this.Add_NOT_Button.Size = new System.Drawing.Size(271, 40);
            this.Add_NOT_Button.TabIndex = 56;
            this.Add_NOT_Button.Text = "إضافة الملاحظات";
            this.Add_NOT_Button.UseVisualStyleBackColor = false;
            this.Add_NOT_Button.Click += new System.EventHandler(this.NOTE_Button_Click);
            // 
            // Encrypt_Button
            // 
            this.Encrypt_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.all_TablePanel.SetColumnSpan(this.Encrypt_Button, 15);
            this.Encrypt_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Encrypt_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encrypt_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt_Button.ForeColor = System.Drawing.Color.Black;
            this.Encrypt_Button.Location = new System.Drawing.Point(1015, 646);
            this.Encrypt_Button.Name = "Encrypt_Button";
            this.all_TablePanel.SetRowSpan(this.Encrypt_Button, 3);
            this.Encrypt_Button.Size = new System.Drawing.Size(309, 54);
            this.Encrypt_Button.TabIndex = 63;
            this.Encrypt_Button.Text = "تشفير";
            this.Encrypt_Button.UseVisualStyleBackColor = false;
            this.Encrypt_Button.Click += new System.EventHandler(this.Encrypt_Button_Click);
            // 
            // Decrypt_Button
            // 
            this.Decrypt_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.all_TablePanel.SetColumnSpan(this.Decrypt_Button, 15);
            this.Decrypt_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Decrypt_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrypt_Button.Font = new System.Drawing.Font("El Messiri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt_Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Decrypt_Button.Location = new System.Drawing.Point(679, 646);
            this.Decrypt_Button.Name = "Decrypt_Button";
            this.all_TablePanel.SetRowSpan(this.Decrypt_Button, 3);
            this.Decrypt_Button.Size = new System.Drawing.Size(309, 54);
            this.Decrypt_Button.TabIndex = 64;
            this.Decrypt_Button.Text = "فك تشفير";
            this.Decrypt_Button.UseVisualStyleBackColor = false;
            this.Decrypt_Button.Click += new System.EventHandler(this.Decrypt_Button_Click);
            // 
            // Del_NOT_Button
            // 
            this.Del_NOT_Button.BackColor = System.Drawing.Color.DarkRed;
            this.all_TablePanel.SetColumnSpan(this.Del_NOT_Button, 2);
            this.Del_NOT_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Del_NOT_Button.Font = new System.Drawing.Font("El Messiri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Del_NOT_Button.ForeColor = System.Drawing.Color.Black;
            this.Del_NOT_Button.Image = global::DailyCompanionV2.Properties.Resources.bin;
            this.Del_NOT_Button.ImageActive = null;
            this.Del_NOT_Button.Location = new System.Drawing.Point(28, 3);
            this.Del_NOT_Button.Name = "Del_NOT_Button";
            this.all_TablePanel.SetRowSpan(this.Del_NOT_Button, 3);
            this.Del_NOT_Button.Size = new System.Drawing.Size(36, 37);
            this.Del_NOT_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Del_NOT_Button.TabIndex = 57;
            this.Del_NOT_Button.TabStop = false;
            this.Del_NOT_Button.Text = "حذف الملاحظة";
            this.Del_NOT_Button.Visible = false;
            this.Del_NOT_Button.Zoom = 10;
            this.Del_NOT_Button.Click += new System.EventHandler(this.NOTE_Button_Click);
            // 
            // NOT_strNote_Textbox
            // 
            this.all_TablePanel.SetColumnSpan(this.NOT_strNote_Textbox, 63);
            this.NOT_strNote_Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NOT_strNote_Textbox.Font = new System.Drawing.Font("El Messiri", 12.8F);
            this.NOT_strNote_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.NOT_strNote_Textbox.IsPasswordTextbox = false;
            this.NOT_strNote_Textbox.IsPlaceholder = true;
            this.NOT_strNote_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOT_strNote_Textbox.Location = new System.Drawing.Point(3, 46);
            this.NOT_strNote_Textbox.Multiline = true;
            this.NOT_strNote_Textbox.Name = "NOT_strNote_Textbox";
            this.NOT_strNote_Textbox.Placeholder = "الملاحظات";
            this.NOT_strNote_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.NOT_strNote_Textbox.placeholderFont = null;
            this.all_TablePanel.SetRowSpan(this.NOT_strNote_Textbox, 30);
            this.NOT_strNote_Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NOT_strNote_Textbox.SelectedItem = null;
            this.NOT_strNote_Textbox.Size = new System.Drawing.Size(1321, 594);
            this.NOT_strNote_Textbox.TabIndex = 5;
            this.NOT_strNote_Textbox.Tag = "";
            this.NOT_strNote_Textbox.Text = "الملاحظات";
            this.NOT_strNote_Textbox.Values = null;
            this.NOT_strNote_Textbox.Visible_Password_Button = false;
            // 
            // NOT_title_Adj_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.NOT_title_Adj_Label, 7);
            this.NOT_title_Adj_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NOT_title_Adj_Label.Font = new System.Drawing.Font("El Messiri", 10.8F);
            this.NOT_title_Adj_Label.Location = new System.Drawing.Point(1225, 0);
            this.NOT_title_Adj_Label.Name = "NOT_title_Adj_Label";
            this.all_TablePanel.SetRowSpan(this.NOT_title_Adj_Label, 2);
            this.NOT_title_Adj_Label.Size = new System.Drawing.Size(141, 40);
            this.NOT_title_Adj_Label.TabIndex = 60;
            this.NOT_title_Adj_Label.Text = "العنوان";
            this.NOT_title_Adj_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NOT_title_Textbox
            // 
            this.NOT_title_Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.all_TablePanel.SetColumnSpan(this.NOT_title_Textbox, 54);
            this.NOT_title_Textbox.ForeColor = System.Drawing.Color.Silver;
            this.NOT_title_Textbox.IsPasswordTextbox = false;
            this.NOT_title_Textbox.IsPlaceholder = true;
            this.NOT_title_Textbox.listboxFont = new System.Drawing.Font("El Messiri SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOT_title_Textbox.Location = new System.Drawing.Point(91, 3);
            this.NOT_title_Textbox.Name = "NOT_title_Textbox";
            this.NOT_title_Textbox.Placeholder = "العنوان";
            this.NOT_title_Textbox.placeholderColor = System.Drawing.Color.Silver;
            this.NOT_title_Textbox.placeholderFont = null;
            this.NOT_title_Textbox.SelectedItem = null;
            this.NOT_title_Textbox.Size = new System.Drawing.Size(1128, 43);
            this.NOT_title_Textbox.TabIndex = 3;
            this.NOT_title_Textbox.Text = "العنوان";
            this.NOT_title_Textbox.Values = null;
            this.NOT_title_Textbox.Visible_Password_Button = false;
            this.NOT_title_Textbox.SelectedItemChanged += new System.EventHandler<System.EventArgs>(this.NOT_title_Textbox_SelectedItemChanged);
            // 
            // Not_Label
            // 
            this.all_TablePanel.SetColumnSpan(this.Not_Label, 35);
            this.Not_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Not_Label.Font = new System.Drawing.Font("El Messiri", 10.8F);
            this.Not_Label.Location = new System.Drawing.Point(595, 703);
            this.Not_Label.Name = "Not_Label";
            this.all_TablePanel.SetRowSpan(this.Not_Label, 2);
            this.Not_Label.Size = new System.Drawing.Size(729, 40);
            this.Not_Label.TabIndex = 62;
            this.Not_Label.Text = "العدد يجب ان يكون رقم صحيح";
            this.Not_Label.Visible = false;
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
            this.Main_SplitContainer.Panel1.Controls.Add(this.Note_Groupbox);
            this.Main_SplitContainer.Size = new System.Drawing.Size(1375, 930);
            this.Main_SplitContainer.SplitterDistance = 851;
            this.Main_SplitContainer.TabIndex = 95;
            // 
            // UsrCtrl_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Main_SplitContainer);
            this.Controls.Add(this.Side_Panel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "UsrCtrl_Notes";
            this.Size = new System.Drawing.Size(1675, 930);
            this.Note_Groupbox.ResumeLayout(false);
            this.all_TablePanel.ResumeLayout(false);
            this.all_TablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Del_NOT_Button)).EndInit();
            this.Tabcontrol_contextMenuStrip.ResumeLayout(false);
            this.Side_Panel.ResumeLayout(false);
            this.Main_SplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_SplitContainer)).EndInit();
            this.Main_SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Note_Groupbox;
        private ModdedControls.ModdedTextBox NOT_title_Textbox;
        private ModdedControls.ModdedTextBox NOT_strNote_Textbox;
        private System.Windows.Forms.Label NOT_title_Adj_Label;
        private ns1.BunifuImageButton Del_NOT_Button;
        private System.Windows.Forms.Button Add_NOT_Button;
        private System.Windows.Forms.Label Not_Label;
        private System.Windows.Forms.Button Decrypt_Button;
        private System.Windows.Forms.Button Encrypt_Button;
        private System.Windows.Forms.ContextMenuStrip Tabcontrol_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.Panel Side_Panel;
        private System.Windows.Forms.TreeView sidePanel_Treeview;
        private System.Windows.Forms.SplitContainer Main_SplitContainer;
        private System.Windows.Forms.TableLayoutPanel all_TablePanel;
        private CustomControls.RJControls.RJToggleButton UsrCtrl_TgleBtn;
    }
}
