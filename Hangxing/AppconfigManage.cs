using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Hangxing
{
    class AppconfigManage
    {
        public static void addItem(string keyName, string keyValue)
        {
            //添加配置文件的项，键为keyName，值为keyValue
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add(keyName, keyValue);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        public static bool existItem(string keyName)
        {
            //判断配置文件中是否存在键为keyName的项
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == keyName)
                {
                    //存在
                    return true;
                }
            }
            return false;
        }

        public static string valueItem(string keyName)
        {
            //返回配置文件中键为keyName的项的值
            return ConfigurationManager.AppSettings[keyName];
        }
        public static void modifyItem(string keyName, string newKeyValue)
        {
            //修改配置文件中键为keyName的项的值
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[keyName].Value = newKeyValue;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        public static void removeItem(string keyName)
        {
            //删除配置文件键为keyName的项
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(keyName);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

    }
}
