using System.Configuration;
using NUnit.Framework;

namespace AppDynamics.Configuration.Tests
{
    public class AppDynamicsConfigurationTests
    {
        [Test]
        public void configuration_should_contain_settings_from_appconfig()
        {
            var config = ConfigurationManager.GetSection("appdynamics") as AppDynamicsConfigurationSection;

            Assert.NotNull(config, "Configuration element 'appdynamics' should exist in configuration");
            Assert.NotNull(config.Tier, "appdynamics/tier element must exist");
            Assert.NotNull(config.App, "appdynamics/app element must exist");
            Assert.IsTrue(
                config.NodeProperties != null && config.NodeProperties.Count == 1,
                "appdynamics/properties element for this test to pass");
            Assert.IsTrue(
                config.NodeProperties["test"] != null && config.NodeProperties["test"].Value == "node property",
                "appdynamics/properties must contain a 'test' key set to 'property' for this test to pass");

            Assert.AreEqual("test_app", config.App.Name);
            Assert.IsTrue(
                config.App.AppProperties != null,
                "appdynamics/app must contain a 'properties' element for this test to pass");
            Assert.IsTrue(
                config.App.AppProperties["test"] != null && config.App.AppProperties["test"].Value == "app property",
                "appdynamics/app/properties must contain a 'test' key set to 'app property' for this test to pass");

            Assert.AreEqual("test_tier", config.Tier.Name);
            Assert.IsTrue(
                config.Tier.TierProperties != null,
                "appdynamics/app must contain a 'properties' element for this test to pass");
            Assert.IsTrue(
                config.Tier.TierProperties["test"] != null && config.Tier.TierProperties["test"].Value == "tier property",
                "appdynamics/tier/properties must contain a 'test' key set to 'tier property' for this test to pass");
        }
    }
}
