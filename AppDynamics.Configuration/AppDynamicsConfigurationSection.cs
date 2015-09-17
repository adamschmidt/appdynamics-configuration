using System.Configuration;

namespace AppDynamics.Configuration
{
    public class AppDynamicsConfigurationSection : ConfigurationSection
    {
        private const string PropertiesSetting = "properties";

        [ConfigurationProperty(PropertiesSetting, IsDefaultCollection = true)]
        public KeyValueConfigurationCollection NodeProperties
        {
            get { return (KeyValueConfigurationCollection)base[PropertiesSetting]; }
        }

        private const string AppSetting = "app";

        [ConfigurationProperty(AppSetting, IsRequired = true)]
        public AppConfigurationElement App
        {
            get { return (AppConfigurationElement)base[AppSetting]; }
        }

        private const string TierSetting = "tier";

        [ConfigurationProperty(TierSetting, IsRequired = true)]
        public TierConfigurationElement Tier
        {
            get { return (TierConfigurationElement)base[TierSetting]; }
        }

    }
}
