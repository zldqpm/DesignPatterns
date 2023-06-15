using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private static readonly object lockObject = new object();

        private string configurationData;

        private ConfigurationManager()
        {
            // 加载配置数据
            configurationData = LoadConfigurationData();
        }

        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new ConfigurationManager();
                        }
                    }
                }
                return instance;
            }
        }

        public string GetConfigurationData()
        {
            return configurationData;
        }

        private string LoadConfigurationData()
        {
            // 从配置文件或其他数据源加载配置数据的逻辑
            return "配置文件内容...";
        }
    }

}
