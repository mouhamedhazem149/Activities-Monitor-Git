using System;
using System.Collections.Generic;
using System.Configuration;

namespace DailyCompanionV2.Utilities
{
    public static partial class HM_Manager
    {
        public static void UpdateConfiguration(List<Tuple<string, string>> settingValuePair)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection apSection = config.AppSettings;
            settingValuePair.ForEach(svPair => apSection.Settings[svPair.Item1].Value = svPair.Item2);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
