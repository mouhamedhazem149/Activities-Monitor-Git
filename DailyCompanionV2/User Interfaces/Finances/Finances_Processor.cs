using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DailyCompanionV2.Models;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2.User_Interfaces.Finance
{
    public static partial class Finances_Processor
    {
        public static bool HandleFNC(Enums.genericHandle_Type handleType, GroupBox grpbox, string relatedentity, Enums.financeType type, int wallet, string category, double due, double paid, DateTime due_date, bool done_dateDone, DateTime doneDate, string notes, Label MsgLabel, string Title, Color color, Models.Finances oldModel, bool byPass = false)
        {
            HM_Manager.Func tobeDone = null;
            DateTime? done_date;
            if (done_dateDone) done_date = doneDate;
            else done_date = null;
            int id = oldModel != null ? oldModel.id : 0;
            
            Wallet Wlt = Program.Wallets_List.Where(p => p.id == wallet).FirstOrDefault();
            double change = type == Enums.financeType.دخل ? paid : -1 * paid;
            double Old_change = 0;
            if (oldModel != null) Old_change = oldModel.type == Enums.financeType.دخل ? oldModel.paid : -1 * oldModel.paid;

            Finances _fncNew = new Finances() { id = id, relatedentity = relatedentity,type = type,category= category,wallet = wallet,due = due,paid = paid,due_date = due_date,done_date = done_date, notes = notes, lst_updt = DateTime.Now };
            int _id = id;
            string SpecificMsg = "تمت العملية بنجاح";
            switch (handleType)
            {
                case Enums.genericHandle_Type.إضافة:
                    tobeDone = delegate ()
                    {
                        _id = DBHelper.Insert_Database("finances", new List<string> { "relatedentity", "type", "wallet", "category", "due", "paid", "duedate", "notes", "donedate", "lstupdt" }, new List<Finances> { _fncNew }, HM_Manager.HandleHistory, new string[] { "العمليات المالية", "إضافة مهمة", "" });
                        SpecificMsg = $"تمت الإضافة بنجاح. كود العملية المالية : {_id}";
                        Settings.Settings_Processor.HandleWallet(Enums.genericHandle_Type.تعديل, null, Wlt.name, Wlt.credit + (decimal)change,null, Title, color, Wlt,true);
                    if (type == Enums.financeType.تحويل_أرصدة)
                        Settings.Settings_Processor.HandleWallet(Enums.genericHandle_Type.تعديل, null, relatedentity, Program.Wallets_List.Where(p => p.name == relatedentity).First().credit - (decimal)change, null, Title, color, Program.Wallets_List.Where(p => p.name == relatedentity).First(),true);
                    };
                    break;
                case Enums.genericHandle_Type.تعديل:
                    tobeDone = delegate ()
                    {
                        DBHelper.Update_Database("finances", new List<string> { "relatedentity", "type", "wallet", "category", "due", "paid", "duedate", "notes", "donedate", "lstupdt" }, new List<Finances> { _fncNew }, HM_Manager.HandleHistory, new string[] { "العمليات المالية", "تعديل البيانات", $"الكود الخاص بالعملية: {_id}  المتعلقة ب: {relatedentity}" });
                        SpecificMsg = $"تم التعديل بنجاح. كود العملية المالية : {_id}";
                        Settings.Settings_Processor.HandleWallet(Enums.genericHandle_Type.تعديل, null, Wlt.name, Wlt.credit + (decimal)change, null, Title, color, Wlt,true);
                        Wallet oldWlt = Program.Wallets_List.Where(p => p.id == oldModel.wallet).First();
                        Settings.Settings_Processor.HandleWallet(Enums.genericHandle_Type.تعديل, null, oldWlt.name, oldWlt.credit - (decimal)Old_change, null, Title, color, oldWlt, true);
                        if (oldModel.type == Enums.financeType.تحويل_أرصدة)
                            Settings.Settings_Processor.HandleWallet(Enums.genericHandle_Type.تعديل, null, oldModel.relatedentity, Program.Wallets_List.Where(p => p.name == oldModel.relatedentity).First().credit + (decimal)Old_change, null, Title, color, Program.Wallets_List.Where(p => p.name == oldModel.relatedentity).First(),true);
                        if (type == Enums.financeType.تحويل_أرصدة)
                            Settings.Settings_Processor.HandleWallet(Enums.genericHandle_Type.تعديل, null, relatedentity, Program.Wallets_List.Where(p => p.name == relatedentity).First().credit - (decimal)change, null, Title, color, Program.Wallets_List.Where(p => p.name == relatedentity).First(),true);
                    };
                    break;
                case Enums.genericHandle_Type.حذف:
                    byPass = true;
                    tobeDone = delegate ()
                    {
                        if (MessageBox.Show($"سيتم حذف العملية المالية الخاصة ب : {oldModel.relatedentity}  تحت تصنيف : {oldModel.category}. هل أنت متأكد ؟", "تحذير", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            DBHelper.Delete_Database("finances", new List<Finances> { oldModel }, HM_Manager.HandleHistory, new string[] { "العمليات المالية", "حذف البيانات", $"الكود الخاص بالعملية: {_id}  المتعلقة ب: {relatedentity}" });
                            SpecificMsg = $"تم التعديل بنجاح. كود العملية المالية : {_id}";
                            Wallet oldWlt = Program.Wallets_List.Where(p => p.id == oldModel.wallet).First();
                            Settings.Settings_Processor.HandleWallet(Enums.genericHandle_Type.تعديل, null, oldWlt.name, oldWlt.credit - (decimal)change, null, Title, color, oldWlt, true);
                            if (oldModel.type == Enums.financeType.تحويل_أرصدة)
                                Settings.Settings_Processor.HandleWallet(Enums.genericHandle_Type.تعديل, null, oldModel.relatedentity, Program.Wallets_List.Where(p => p.name == oldModel.relatedentity).First().credit + (decimal)change, null, Title, color, Program.Wallets_List.Where(p => p.name == oldModel.relatedentity).First(), true);
                        }
                    };
                    break;
                case Enums.genericHandle_Type.تحميل_البيانات:
                    byPass = true;
                    tobeDone = delegate () { HM_Manager.SetControlsFromModel(grpbox, oldModel); SpecificMsg = $"تم تحميل البيانات بنجاح. كود العملية : {_id}"; };
                    break;
            }
            return HM_Manager.genericHandler(grpbox, Title, color, oldModel, MsgLabel, tobeDone, ref SpecificMsg, byPass);
        }
    }
}
