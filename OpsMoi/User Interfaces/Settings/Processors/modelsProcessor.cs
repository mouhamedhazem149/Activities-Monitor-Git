using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OpsMoi.Models;
using OpsMoi.Utilities;

namespace OpsMoi.User_Interfaces.Settings
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
    }
}
