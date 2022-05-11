using DailyCompanionV2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DailyCompanionV2.User_Interfaces
{
    partial class UsrCtrl_Shortcut : UserControl
    {
        public UsrCtrl_Shortcut(System.Drawing.Color color)
        {
            InitializeComponent();
            this.BackColor = shrtcuts_Treeview.BackColor = ControlPaint.Light(color, .2f);
            Sync();
        }
        public void Sync()
        {
            LoadTreeView();
        }
        private void LoadTreeView()
        {
            shrtcuts_Treeview.Nodes.Clear();
            foreach (Models.Shortcut shrtCut in Program.Shortcuts_List)
            {
                shrtcuts_Treeview.Nodes.Add(shrtCut.id.ToString(),shrtCut.name);
                shrtcuts_Treeview.Nodes[shrtCut.id.ToString()].Tag = shrtCut;
                shrtcuts_Treeview.Nodes[shrtCut.id.ToString()].ToolTipText = shrtCut.shortcut;
                shrtcuts_Treeview.Nodes[shrtCut.id.ToString()].ContextMenuStrip = node_MenuStrip;
                var tempChildren = GetChildrenTreeNode(shrtCut.childrenShrtcuts);
                if (tempChildren != null)
                    shrtcuts_Treeview.Nodes[shrtCut.id.ToString()].Nodes.AddRange(tempChildren);
            }
        }
        TreeNode[] GetChildrenTreeNode(List<Models.Shortcut> children) => (children != null && children.Count > 0) ?
            children.Where(chld => (chld.childrenShrtcuts != null && chld.childrenShrtcuts.Count > 0)).Select(p => new TreeNode(p.name, GetChildrenTreeNode(p.childrenShrtcuts)) {ContextMenuStrip = node_MenuStrip, ToolTipText = p.shortcut, Tag = p })
            .Concat(children.Where(chld => (chld.childrenShrtcuts == null || chld.childrenShrtcuts.Count == 0)).Select(p => new TreeNode(p.name) { ContextMenuStrip = node_MenuStrip, ToolTipText = p.shortcut, Tag = p })).ToArray() 
            : null;
         private void editToolStripMenuItem_Click(object sender, EventArgs e) =>
            Program.WorkingForm.Click_Settings(Enums.settingsState.shortcut);

        void OpenShortcut(Models.Shortcut shrtCut)
        {
            var process = System.Diagnostics.Process.Start(HM_Manager.ExecuteProcess(shrtCut.proModel.processname, shrtCut.shortcut));
            process.WaitForExit(); process.Close();
        }
        private void expandToolStripMenuItem_Click(object sender, EventArgs e) => 
            (((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as TreeView).SelectedNode.Expand();
        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e) =>
            (((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as TreeView).SelectedNode.ExpandAll();
        private void openToolStripMenuItem_Click(object sender, EventArgs e) => 
            OpenShortcut((Models.Shortcut)(((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as TreeView).SelectedNode.Tag);

        private void shrtcuts_Treeview_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!(sender is TreeView)) return;
            if (e.Button == MouseButtons.Right) shrtcuts_Treeview.SelectedNode = e.Node;
            var selNode = (sender as TreeView).SelectedNode;
            if (e.Button == MouseButtons.Right && selNode != null && (sender as TreeView).GetNodeAt(e.Location) == selNode)
            {
                try
                {
                    Models.Shortcut shrtCut = (Models.Shortcut)selNode.Tag;
                    string Path = shrtCut.shortcut;
                    Clipboard.SetText(Path);
                    HM_Manager.Success_addition(Shortcut_Label, $"تم النسخ للحافظة [{Path}]");
                }
                catch (Exception ex) { HM_Manager.Fail_addition(Shortcut_Label, "برجاء التاكد من بيانات الاختصار أو العملية"); }
            }
        }

        private void shrtcuts_Treeview_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!(sender is TreeView)) return;
            var selNode = e.Node;
            if (e.Button == MouseButtons.Left && selNode != null && (sender as TreeView).GetNodeAt(e.Location) == selNode)
            {
                try
                {
                    OpenShortcut((Models.Shortcut)selNode.Tag);
                    HM_Manager.Success_addition(Shortcut_Label, "تم تحميل الاختصار بنجاح");
                }
                catch (Exception ex) { HM_Manager.Fail_addition(Shortcut_Label, "برجاء التاكد من بيانات الاختصار أو العملية"); }
            }
        }
    }
}
