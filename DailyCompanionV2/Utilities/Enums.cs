using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace DailyCompanionV2.Utilities
{
    public struct EnumStruct
    {
        public string displayName { get; set; }
        public string realName { get; set; }
    }
    public static class Enums
    {
        public static System.Drawing.Color addColor = System.Drawing.Color.DarkRed;
        public static System.Drawing.Color modColor = System.Drawing.Color.Blue;
        public enum mainformState
        {
            dashboard,
            settings,
            addtab
        }
        public enum usrctrlState
        {
            add,
            mod
        }
        public enum addedCtrls
        {
            active,
            inactive,
        }
        public enum financeType
        {
            دخل,
            مدفوعات,
            [Display(Name = "( شحن شخصي) تحويل أرصدة بدون مدفوعات فعلية")]
            تحويل_أرصدة
        }
        #region Notification
        public enum notifFrequency
        {
            سنوي,
            شهري,
            أسبوعي,
            يومي,
            آخر
        }
        public enum notifRepeat
        {
            دائم,
            محدد
        }
        #endregion
        #region Dashboard
        public enum DashboardField
        {
            الإجمالي_مهام,
            إجمالي_الشهر_مهام,
            متوسط_مهام,
            مطلوب_مهام,
            الإجمالي_مالية,
            إجمالي_الشهر_مالية,
            متوسط_مالية,
            مطلوب_مالية,
            الإجمالي_ملاحظات,
            متوسط_ملاحظات,
        }
        public enum dashboardAuxState
        {
            history,
            none
        }
        #endregion

        #region General
        public enum Resolution
        {
            [Display(Name = "1920 x 1080")]
            A_1920x1080,
            [Display(Name = "1366 x 768")]
            B_1366x768,
            [Display(Name = "1280 x 1040")]
            C_1280x1040
        }
        #endregion
       
        #region UserControls
        public enum todoArgument
        {
            none,
            showTodoManager,
            loadTodoItem,
        }
        public enum todoAuxState
        {
            none,
            required,
            timeline
        }
        public enum noteArgument
        {
            none,
            showNoteManager,
            loadNoteItem
        }
        public enum financeArgument
        {
            none,
            showFinanceManager,
            loadFinanceItem
        }
        public enum financeAuxState
        {
            none,
            required,
            wallets
        }
        public enum reportAuxState
        {
            Line,
            Pie,
            spLine,
            none
        }
        public enum settingsState
        {
            general,
            finance,
            login,
            shortcut,
            notification,
            none
        }
        #endregion

        #region Settings
        public enum User_Category
        {
            مدير_البرنامج,
            مسؤول,
            موظف
        }
        public enum genericHandle_Type
        {
            إضافة,
            تعديل,
            حذف,
            تحميل_البيانات
        }
        #endregion
        
        #region Reports
        public enum Span
        {
            سنوي,
            شهري,
            يومي,
            أخرى
        }
        public enum report_tabState
        {
            مهام,
            مالية,
            ملاحظات,
        }
        #endregion

        public static string GetDisplayName(this Enum enumValue)
        {
            string displayName;
            displayName = enumValue.GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault()
                .GetCustomAttribute<DisplayAttribute>()?
                .GetName();
            if (string.IsNullOrEmpty(displayName)) displayName = enumValue.ToString();
            return displayName;
        }
        public static T GetValueFromName<T>(string name)
        {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();

            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field, typeof(DisplayAttribute)) as DisplayAttribute;
                if (attribute != null) { if (attribute.Name == name) return (T)field.GetValue(null); }
                else { if (field.Name == name) return (T)field.GetValue(null); }
            }
            throw new ArgumentOutOfRangeException("name");
        }
        public static Enum GetValueFromName(Enum type, string name) => 
            type.GetType().GetEnumValues().OfType<Enum>().Where(eNum => eNum.GetDisplayName() == name).FirstOrDefault();
    }
}
