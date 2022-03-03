
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
            this.shrtcuts_Treeview = new System.Windows.Forms.TreeView();
            this.shortcut_MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Shortcut_Label = new System.Windows.Forms.Label();
            this.node_MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.expandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.shortcut_MenuStrip.SuspendLayout();
            this.node_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // shrtcuts_Treeview
            // 
            this.shrtcuts_Treeview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shrtcuts_Treeview.Font = new System.Drawing.Font("Cairo SemiBold", 9.8F, System.Drawing.FontStyle.Bold);
            this.shrtcuts_Treeview.ForeColor = System.Drawing.Color.Black;
            this.shrtcuts_Treeview.Location = new System.Drawing.Point(0, 0);
            this.shrtcuts_Treeview.Name = "shrtcuts_Treeview";
            this.shrtcuts_Treeview.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.shrtcuts_Treeview.RightToLeftLayout = true;
            this.shrtcuts_Treeview.ShowNodeToolTips = true;
            this.shrtcuts_Treeview.Size = new System.Drawing.Size(550, 380);
            this.shrtcuts_Treeview.TabIndex = 0;
            this.shrtcuts_Treeview.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.shrtcuts_Treeview_NodeMouseClick);
            this.shrtcuts_Treeview.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.shrtcuts_Treeview_NodeMouseDoubleClick);
            // 
            // shortcut_MenuStrip
            // 
            this.shortcut_MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.shortcut_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.shortcut_MenuStrip.Name = "shortcut_MenuStrip";
            this.shortcut_MenuStrip.Size = new System.Drawing.Size(105, 28);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
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
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.expandToolStripMenuItem,
            this.expandAllToolStripMenuItem});
            this.node_MenuStrip.Name = "node_MenuStrip";
            this.node_MenuStrip.Size = new System.Drawing.Size(150, 82);
            // 
            // expandToolStripMenuItem
            // 
            this.expandToolStripMenuItem.Name = "expandToolStripMenuItem";
            this.expandToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.expandToolStripMenuItem.Text = "Expand";
            this.expandToolStripMenuItem.Click += new System.EventHandler(this.expandToolStripMenuItem_Click);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // UsrCtrl_Shortcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ContextMenuStrip = this.shortcut_MenuStrip;
            this.Controls.Add(this.Shortcut_Label);
            this.Controls.Add(this.shrtcuts_Treeview);
            this.Name = "UsrCtrl_Shortcut";
            this.Size = new System.Drawing.Size(550, 380);
            this.shortcut_MenuStrip.ResumeLayout(false);
            this.node_MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView shrtcuts_Treeview;
        private System.Windows.Forms.ContextMenuStrip shortcut_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label Shortcut_Label;
        private System.Windows.Forms.ContextMenuStrip node_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem expandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
