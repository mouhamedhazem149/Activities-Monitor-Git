using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DailyCompanionV2.Utilities;

namespace DailyCompanionV2.User_Interfaces.Settings
{
    public static partial class Settings_Processor
    {
        public static void ChangePassword(string OldPassword, string NewPassword, string RNewPassword, Label MsgLabel)
        {
            Models.Settings temp = Program.mainSettings;
            try
            {
                if (OldPassword == HM_Manager.Decrypt(temp.mainpassword))
                    if (NewPassword == RNewPassword)
                    {
                        DBHelper.Update_Database("settings", new List<string> { "mainpassword" }, new Models.Settings() { serialnumber = temp.serialnumber, mainpassword = HM_Manager.topEncrypt(NewPassword) }, HM_Manager.HandleHistory, new string[] { "المستخدمين", "إعادة تعيين كلمة المرور", $"اسم المستخدم: {temp.name} وكلمة المرور القديمة: {HM_Manager.Decrypt(temp.mainpassword)} والجديدة: {NewPassword}" }, KEY: "serialnumber", OLDVALUE: "serialnumber");
                        HM_Manager.Success_addition(MsgLabel, "تم تعديل كلمة المرور بنجاح!");
                    }
                    else { HM_Manager.Fail_addition(MsgLabel, "تأكد من تطابق كلمتي المرور!"); }
                else { HM_Manager.Fail_addition(MsgLabel, "تأكد من صحة كلمة المرور القديمة!"); }
            }
            catch (Exception) { HM_Manager.Fail_addition(MsgLabel, "فشل التعديل!"); }
        }
    }
}
