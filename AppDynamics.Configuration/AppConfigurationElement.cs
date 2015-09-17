using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDynamics.Configuration
{
    public class AppConfigurationElement : ConfigurationElement
    {
        private const string NameSetting = "name";
        [ConfigurationProperty(NameSetting, IsRequired = true, IsKey = true)]
        public string Name
        {
            get { return (string)base[NameSetting]; }
        }

        private const string PropertiesSetting = "properties";

        [ConfigurationProperty(PropertiesSetting, IsDefaultCollection = true, IsRequired = false)]
        public KeyValueConfigurationCollection AppProperties
        {
            get { return (KeyValueConfigurationCollection)base[PropertiesSetting]; }
        }

    }
}
