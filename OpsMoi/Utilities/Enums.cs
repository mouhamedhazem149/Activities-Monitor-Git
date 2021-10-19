using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace OpsMoi.Utilities
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
        
        public enum financeType
        {
            دخل,
            مدفوعات,
            [Display(Name = "( شحن شخصي) تحويل أرصدة بدون مدفوعات فعلية")]
            تحويل_أرصدة
        }

        #region Dashboard
        public enum DashboardField
        {
            إجمالي_عدد_المهام_المطلوبة,
            عدد_المهام_المطلوبة_هذا_الشهر,
            متوسط_عدد_المهام_الشهر,
            إجمالي_المدة_المستغرقة,
            إجمالي_المدة_المستغرقة_هذا_الشهر,
            متوسط_المدة_المستغرقة_الشهر,
            إجمالي_عدد_العمليات_المالية_,
            عدد_العمليات_المالية_هذا_الشهر,
            متوسط_عدد_العمليات_المالية__الشهر,
            إجمالي_قيمة_العمليات_المالية,
            قيمة_العمليات_المالية_هذا_الشهر,
            متوسط_قيمة_العمليات_المالية_الشهر,
            إجمالي_عدد_الملاحظات,
            إجمالي_طول_الملاحظات,
            متوسط_طول_الملاحظات
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
        public enum settingsArgument
        {
            none,
            openWalletManager
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
            يومي
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
