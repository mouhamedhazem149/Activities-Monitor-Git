using DailyCompanionV2.Models;
using DailyCompanionV2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Shortcut = DailyCompanionV2.Models.Shortcut;

namespace DailyCompanionV2.User_Interfaces
{
    partial class UsrCtrl_Shortcut : UserControl, ICustomControl
    {
        public UsrCtrl_Shortcut(System.Drawing.Color color)
        {
            InitializeByResolution();
            Set_Tags();
            this.BackColor = shrtcuts_OTreeview.BackColor = ControlPaint.Light(color, .2f);
        }
        public void InitializeByResolution() => InitializeComponent();
        public void Sync() => LoadTreeView();
        public void Set_Tags()
        {
            shrtcuts_OTreeview.CanExpandGetter = delegate (object rowObject) { return ((rowObject as Models.Shortcut).childrenShrtcuts(tempList) != null && (rowObject as Models.Shortcut).childrenShrtcuts(tempList).Count > 0); };
            shrtcuts_OTreeview.ChildrenGetter = delegate (object rowObject) { return ((Models.Shortcut)rowObject).childrenShrtcuts(tempList); };

        }
        private List<Models.Shortcut> tempList;
        private void LoadTreeView()
        {
            if (tempList != null) tempList.Clear();
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            tempList = Program.Shortcuts_List;
            HM_Manager.Update_OLV(tempList.Where(p => p.parent_id == 0).ToList(), shrtcuts_OTreeview);
            Console.WriteLine($"Elapsed time :: {timer.ElapsedMilliseconds} mSec");
        }
        
        void OpenShortcut(Shortcut shrtCut)
        {
            var process = System.Diagnostics.Process.Start(HM_Manager.ExecuteProcess(shrtCut.proModel.processname, shrtCut.shortcut, shrtCut.proModel.NoWindow));
            process.WaitForExit(); process.Close();
        }
        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e) => 
            shrtcuts_OTreeview.SelectedObjects.Cast<Shortcut>().ToList().ForEach(shtct => collapseAllNode(shrtcuts_OTreeview,shtct, tempList));
        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e) =>
            shrtcuts_OTreeview.SelectedObjects.Cast<Shortcut>().ToList().ForEach(prnt => expandAllNode(shrtcuts_OTreeview,prnt, tempList));
        private void collapseAllNode(BrightIdeasSoftware.TreeListView treeList, Shortcut parent, List<Shortcut> refList)
        {
            treeList.Collapse(parent);
            List<Shortcut> temp = parent.childrenShrtcuts(refList);
            if (temp.SafeCount() > 0)
                temp.ForEach(chld => collapseAllNode(treeList, chld, refList));
        }
        private void expandAllNode(BrightIdeasSoftware.TreeListView treeList, Shortcut parent, List<Shortcut> refList)
        {
            treeList.Expand(parent);
            List<Shortcut> temp = parent.childrenShrtcuts(refList);
            if (temp.SafeCount() > 0)
                temp.ForEach(chld => expandAllNode(treeList, chld, refList));
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (shrtcuts_OTreeview.SelectedObjects.Cast<Shortcut>().ToList().SafeCount() > 0)
                {
                    shrtcuts_OTreeview.SelectedObjects.Cast<Shortcut>().ToList().ForEach(sht => OpenShortcut(sht));
                    HM_Manager.Success_addition(Shortcut_Label, "تم تحميل الاختصار بنجاح");
                }
                else throw new Exception("");
            }
            catch (Exception ex) { HM_Manager.Fail_addition(Shortcut_Label, "برجاء اختيار عنصر أو التأكد من صحة البيانات"); }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shrtcuts_OTreeview.SelectedObjects.Cast<Shortcut>().ToList().SafeCount() > 0)
            {
                shrtcuts_OTreeview.SelectedObjects.Cast<Shortcut>().ToList().ForEach(sht => Clipboard.SetText(sht.shortcut));
                HM_Manager.Success_addition(Shortcut_Label, $"تم النسخ للحافظة");
            }
            else HM_Manager.Fail_addition(Shortcut_Label, "برجاء اختيار عنصر واحد علي الأقل");
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e) =>
            Program.WorkingForm.Click_Settings(Enums.settingsState.shortcut);

        private void shrtcuts_OTreeview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (shrtcuts_OTreeview.SelectedObjects.Cast<Shortcut>().ToList().SafeCount() > 0)
                {
                    shrtcuts_OTreeview.SelectedObjects.Cast<Shortcut>().ToList().ForEach(sht => OpenShortcut(sht));
                    HM_Manager.Success_addition(Shortcut_Label, "تم تحميل الاختصار بنجاح");
                }
                else throw new Exception("");
            }
            catch (Exception ex) { HM_Manager.Fail_addition(Shortcut_Label, "برجاء اختيار عنصر أو التأكد من صحة البيانات"); }
        }
    }
}
