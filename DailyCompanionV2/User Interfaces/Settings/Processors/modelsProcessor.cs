using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DailyCompanionV2.Models;
using DailyCompanionV2.Utilities;
using Shortcut = DailyCompanionV2.Models.Shortcut;

namespace DailyCompanionV2.User_Interfaces.Settings
{
    public static partial class Settings_Processor
    {
        public static bool HandleWallet(Enums.genericHandle_Type handleType, GroupBox grpbox, string name, decimal credit, Label MsgLabel, string Title, Color color, Wallet oldModel, bool byPass = false)
        {
            HM_Manager.Func tobeDone = null;
            int id = oldModel != null ? oldModel.id : 0;
            Wallet _wltNew = new Wallet() { id = id, name = name, credit = credit };
            int _id = id;
            string SpecificMsg = "تمت العملية بنجاح";
            switch (handleType)
            {
                case Enums.genericHandle_Type.إضافة:
                    tobeDone = delegate ()
                    {
                        _id = DBHelper.Insert_Database("wallets", new List<string> { "name", "credit" }, new List<Wallet> { _wltNew }, HM_Manager.HandleHistory, new string[] { "المحافظ", "إضافة مهمة", "" });
                        SpecificMsg = $"تمت الإضافة بنجاح. اسم المحفظة : {_wltNew.name}";
                    };
                    break;
                case Enums.genericHandle_Type.تعديل:
                    tobeDone = delegate ()
                    {
                        DBHelper.Update_Database("wallets", new List<string> { "name", "credit" }, new List<Wallet> { _wltNew }, HM_Manager.HandleHistory, new string[] { "المحافظ", "تعديل البيانات", $"اسم المحفظة: {oldModel.name}  برصيد: {oldModel.credit}" });
                        SpecificMsg = $"تم التعديل بنجاح. اسم المحفظة : {_wltNew.name}";
                    };
                    break;
                case Enums.genericHandle_Type.حذف:
                    byPass = true;
                    tobeDone = delegate ()
                    {
                        if (MessageBox.Show($"سيتم حذف المحفظة باسم : {oldModel.name} التي تحتوي علي رصيد {oldModel.credit}. هل أنت متأكد ؟", "تحذير", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            DBHelper.Delete_Database("wallets", new List<Wallet> { oldModel }, HM_Manager.HandleHistory, new string[] { "المحافظ", "حذف البيانات", $"اسم المحفظة: {oldModel.name}  برصيد: {oldModel.credit}" });
                            SpecificMsg = $"تم التعديل بنجاح. اسم المحفظة : {oldModel.name}";
                        }
                    };
                    break;
                case Enums.genericHandle_Type.تحميل_البيانات:
                    byPass = true;
                    tobeDone = delegate () { HM_Manager.SetControlsFromModel(grpbox, oldModel); SpecificMsg = $"تم تحميل البيانات بنجاح. اسم المحفظة : {oldModel.name}"; };
                    break;
            }
            return HM_Manager.genericHandler(grpbox, Title, color, oldModel, MsgLabel, tobeDone, ref SpecificMsg, byPass);
        }
        public static bool HandleProcess(Enums.genericHandle_Type handleType, GroupBox grpbox, string name, string processname,bool noOutput ,Label MsgLabel, string Title, Color color, Process oldModel, bool byPass = false)
        {
            HM_Manager.Func tobeDone = null;
            int id = oldModel != null ? oldModel.id : 0;
            Process _prcNew = new Process() { id = id, name = name, processname = processname,NoWindow = noOutput };
            int _id = id;
            string SpecificMsg = "تمت العملية بنجاح";
            switch (handleType)
            {
                case Enums.genericHandle_Type.إضافة:
                    tobeDone = delegate ()
                    {
                        _id = DBHelper.Insert_Database("processes", new List<string> { "name", "processname", "nooutput" }, new List<Process> { _prcNew }, HM_Manager.HandleHistory, new string[] { "Processes", "إضافة عملية", "" });
                        SpecificMsg = $"تمت الإضافة بنجاح. اسم Process : {_prcNew.name}";
                    };
                    break;
                case Enums.genericHandle_Type.تعديل:
                    tobeDone = delegate ()
                    {
                        DBHelper.Update_Database("processes", new List<string> { "name", "processname", "nooutput" }, new List<Process> { _prcNew }, HM_Manager.HandleHistory, new string[] { "Processes", "تعديل البيانات", $"الProcess باسم : {oldModel.name} بعنوان {oldModel.processname}." });
                        SpecificMsg = $"تم التعديل بنجاح. اسم Process : {_prcNew.name}";
                    };
                    break;
                case Enums.genericHandle_Type.حذف:
                    byPass = true;
                    tobeDone = delegate ()
                    {
                        if (MessageBox.Show($"سيتم حذف ال Process باسم : {oldModel.name} بعنوان {oldModel.processname}. هل أنت متأكد ؟", "تحذير", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            DBHelper.Delete_Database("processes", new List<Process> { oldModel }, HM_Manager.HandleHistory, new string[] { "Processes", "حذف البيانات", $"الProcess باسم : {oldModel.name} بعنوان {oldModel.processname}." });
                            SpecificMsg = $"تم التعديل بنجاح. اسم Process : {oldModel.name}";
                        }
                    };
                    break;
                case Enums.genericHandle_Type.تحميل_البيانات:
                    byPass = true;
                    tobeDone = delegate () { HM_Manager.SetControlsFromModel(grpbox, oldModel); SpecificMsg = $"تم تحميل البيانات بنجاح. اسم الProcess : {oldModel.name}"; };
                    break;
            }
            return HM_Manager.genericHandler(grpbox, Title, color, oldModel, MsgLabel, tobeDone, ref SpecificMsg, byPass);
        }
        public static bool HandleShortcut(Enums.genericHandle_Type handleType, GroupBox grpbox,int? D_id,int parent_id ,string Nm, string stCut, int Pcs, string chldren, Label MsgLabel, string Title, Color color, Shortcut oldModel, bool byPass = false)
        {
            HM_Manager.Func tobeDone = null;
            int id = D_id == null ? oldModel != null ? oldModel.id : 0 : D_id.Value;
            Shortcut _shtNew = new Shortcut() { id = id, parent_id = parent_id ,name = Nm, shortcut = stCut, process = Pcs };
            int _id = id;
            string SpecificMsg = "تمت العملية بنجاح";
            switch (handleType)
            {
                case Enums.genericHandle_Type.إضافة:
                    tobeDone = delegate ()
                    {
                        if (D_id != null)
                            DBHelper.Insert_Database("shortcuts", new List<string> {"id", "parent_id", "name", "shortcut", "process"}, new List<Shortcut> { _shtNew }, HM_Manager.HandleHistory, new string[] { "الاختصارات", "إضافة عملية", "" });
                        else _id = DBHelper.Insert_Database("shortcuts", new List<string> {"parent_id", "name", "shortcut", "process" }, new List<Shortcut> { _shtNew }, HM_Manager.HandleHistory, new string[] { "الاختصارات", "إضافة عملية", "" });
                        SpecificMsg = $"تمت الإضافة بنجاح. اسم الاختصار : {_shtNew.name}";
                    };
                    break;
                case Enums.genericHandle_Type.تعديل:
                    tobeDone = delegate ()
                    {
                        DBHelper.Update_Database("shortcuts", new List<string> { "parent_id", "name", "shortcut", "process" }, new List<Shortcut> { _shtNew }, HM_Manager.HandleHistory, new string[] { "الاختصارات", "تعديل البيانات", $"الاختصار باسم : {oldModel.name} بعنوان {oldModel.shortcut}." });
                        SpecificMsg = $"تم التعديل بنجاح. اسم الاختصار : {_shtNew.name}";
                    };
                    break;
                case Enums.genericHandle_Type.حذف:
                    byPass = true;
                    tobeDone = delegate ()
                    {
                        if (MessageBox.Show($"سيتم حذف الاختصار باسم : {oldModel.name} بعنوان {oldModel.shortcut}. هل أنت متأكد ؟", "تحذير", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            DBHelper.Delete_Database("shortcuts", new List<Shortcut> { oldModel }, HM_Manager.HandleHistory, new string[] { "الاختصارات", "حذف البيانات", $"الاختصار باسم : {oldModel.name} بعنوان {oldModel.shortcut}." });
                            //DBHelper.Delete_Database("shortcuts", new Shortcut() { parent_id = oldModel.id },HM_Manager.HandleHistory, new string[] { "الاختصارات", "حذف البيانات", $"الاختصار باسم : {oldModel.name} بعنوان {oldModel.shortcut}." }, KEY: "parent_id");
                            SpecificMsg = $"تم التعديل بنجاح. اسم الاختصار : {oldModel.name}";
                        }
                    };
                    break;
                case Enums.genericHandle_Type.تحميل_البيانات:
                    byPass = true;
                    tobeDone = delegate () { HM_Manager.SetControlsFromModel(grpbox, oldModel); SpecificMsg = $"تم تحميل البيانات بنجاح. اسم الاختصار : {oldModel.name}"; };
                    break;
            }
            return HM_Manager.genericHandler(grpbox, Title, color, oldModel, MsgLabel, tobeDone, ref SpecificMsg, byPass);
        }
        public static bool HandleNotification(Enums.genericHandle_Type handleType, GroupBox grpbox, string title, string description, string category, DateTime notif_Date,Enums.notifFrequency notifFrequency, decimal freq_DInt,Enums.notifRepeat notifRepeat ,int repeatInt,DateTime? doneDate ,Label MsgLabel, string Title, Color color, Notification oldModel, bool byPass = false)
        {
            HM_Manager.Func tobeDone = null;
            int id = oldModel != null ? oldModel.id : 0;
            Notification _ntfNew = new Notification() { id = id, title = title, description = description, category = category, notif_Date = notif_Date, freqDInt = freq_DInt, frequency = notifFrequency, repeatInt = repeatInt,  repeat = notifRepeat,done_date = doneDate };
            int _id = id;
            string SpecificMsg = "تمت العملية بنجاح";
            switch (handleType)
            {
                case Enums.genericHandle_Type.إضافة:
                    tobeDone = delegate ()
                    {
                        _id = DBHelper.Insert_Database("notifications", new List<string> { "title", "description", "category", "notifDate", "frequency", "freqDInt", "repeat", "repeatInt", "donedate" }, new List<Notification> { _ntfNew }, HM_Manager.HandleHistory, new string[] { "التنبيهات", "إضافة عملية", "" });
                        SpecificMsg = $"تمت الإضافة بنجاح. اسم التنبيه : {_ntfNew.title}";
                    };
                    break;
                case Enums.genericHandle_Type.تعديل:
                    tobeDone = delegate ()
                    {
                        DBHelper.Update_Database("notifications", new List<string> { "title", "description", "category", "notifDate", "frequency", "freqDInt", "repeat", "repeatInt", "donedate" }, new List<Notification> { _ntfNew }, HM_Manager.HandleHistory, new string[] { "التنبيهات", "تعديل البيانات", $"التنبيه باسم : {oldModel.title} بتاريخ {oldModel.notifDate}." });
                        SpecificMsg = $"تم التعديل بنجاح. اسم التنبيه : {_ntfNew.title}";
                    };
                    break;
                case Enums.genericHandle_Type.حذف:
                    byPass = true;
                    tobeDone = delegate ()
                    {
                        if (MessageBox.Show($"سيتم حذف التنبيه باسم : {oldModel.title} بتاريخ {oldModel.notifDate}. هل أنت متأكد ؟", "تحذير", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            DBHelper.Delete_Database("notifications", new List<Notification> { oldModel }, HM_Manager.HandleHistory, new string[] { "التنبيهات", "حذف البيانات", $"التنبيه باسم : {oldModel.title} بتاريخ {oldModel.notifDate}." });
                            SpecificMsg = $"تم التعديل بنجاح. اسم التنبيه : {_ntfNew.title}";
                        }
                    };
                    break;
                case Enums.genericHandle_Type.تحميل_البيانات:
                    byPass = true;
                    tobeDone = delegate () { HM_Manager.SetControlsFromModel(grpbox, oldModel); SpecificMsg = $"تم تحميل البيانات بنجاح. اسم التنبيه : {oldModel.title}"; };
                    break;
            }
            return HM_Manager.genericHandler(grpbox, Title, color, oldModel, MsgLabel, tobeDone, ref SpecificMsg, byPass);
        }
    }
}
