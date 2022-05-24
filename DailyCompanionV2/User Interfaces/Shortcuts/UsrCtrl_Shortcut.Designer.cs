
namespace DailyCompanionV2.User_Interfaces
{
    partial class UsrCtrl_Shortcut
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
            this.Shortcut_Label = new System.Windows.Forms.Label();
            this.node_MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shrtcuts_OTreeview = new BrightIdeasSoftware.TreeListView();
            this.shtcutName_Column = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.node_MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shrtcuts_OTreeview)).BeginInit();
            this.SuspendLayout();
            // 
            // Shortcut_Label
            // 
            this.Shortcut_Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Shortcut_Label.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shortcut_Label.Location = new System.Drawing.Point(0, 354);
            this.Shortcut_Label.Name = "Shortcut_Label";
            this.Shortcut_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Shortcut_Label.Size = new System.Drawing.Size(550, 26);
            this.Shortcut_Label.TabIndex = 2;
            this.Shortcut_Label.Text = "label1";
            this.Shortcut_Label.Visible = false;
            // 
            // node_MenuStrip
            // 
            this.node_MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.node_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1,
            this.toolStripSeparator2,
            this.openToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.toolStripSeparator1,
            this.expandAllToolStripMenuItem,
            this.collapseAllToolStripMenuItem});
            this.node_MenuStrip.Name = "node_MenuStrip";
            this.node_MenuStrip.Size = new System.Drawing.Size(209, 136);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.editToolStripMenuItem1.RightToLeftAutoMirrorImage = true;
            this.editToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(208, 24);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.openToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.expandAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.collapseAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // shrtcuts_OTreeview
            // 
            this.shrtcuts_OTreeview.AllColumns.Add(this.shtcutName_Column);
            this.shrtcuts_OTreeview.CellEditUseWholeCell = false;
            this.shrtcuts_OTreeview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.shtcutName_Column});
            this.shrtcuts_OTreeview.ContextMenuStrip = this.node_MenuStrip;
            this.shrtcuts_OTreeview.Cursor = System.Windows.Forms.Cursors.Default;
            this.shrtcuts_OTreeview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shrtcuts_OTreeview.EmptyListMsg = "لا توجد اختصارات";
            this.shrtcuts_OTreeview.EmptyListMsgFont = new System.Drawing.Font("Cairo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shrtcuts_OTreeview.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shrtcuts_OTreeview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.shrtcuts_OTreeview.HideSelection = false;
            this.shrtcuts_OTreeview.Location = new System.Drawing.Point(0, 0);
            this.shrtcuts_OTreeview.Name = "shrtcuts_OTreeview";
            this.shrtcuts_OTreeview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.shrtcuts_OTreeview.RightToLeftLayout = true;
            this.shrtcuts_OTreeview.ShowGroups = false;
            this.shrtcuts_OTreeview.Size = new System.Drawing.Size(550, 354);
            this.shrtcuts_OTreeview.TabIndex = 3;
            this.shrtcuts_OTreeview.UseCompatibleStateImageBehavior = false;
            this.shrtcuts_OTreeview.View = System.Windows.Forms.View.Details;
            this.shrtcuts_OTreeview.VirtualMode = true;
            this.shrtcuts_OTreeview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.shrtcuts_OTreeview_MouseDoubleClick);
            // 
            // shtcutName_Column
            // 
            this.shtcutName_Column.AspectName = "name";
            this.shtcutName_Column.Hideable = false;
            this.shtcutName_Column.IsEditable = false;
            this.shtcutName_Column.MinimumWidth = 400;
            this.shtcutName_Column.Searchable = false;
            this.shtcutName_Column.ShowTextInHeader = false;
            this.shtcutName_Column.Text = "";
            this.shtcutName_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.shtcutName_Column.Width = 400;
            // 
            // UsrCtrl_Shortcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.shrtcuts_OTreeview);
            this.Controls.Add(this.Shortcut_Label);
            this.Name = "UsrCtrl_Shortcut";
            this.Size = new System.Drawing.Size(550, 380);
            this.node_MenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shrtcuts_OTreeview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Shortcut_Label;
        private System.Windows.Forms.ContextMenuStrip node_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private BrightIdeasSoftware.TreeListView shrtcuts_OTreeview;
        private BrightIdeasSoftware.OLVColumn shtcutName_Column;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    }
}
