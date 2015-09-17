# .NET Configuration Module for AppDynamics
This project is a generic configuration block to include in .NET config files relating to AppDynamics.

## Adding the Configuration

Step 1: Add the config section

```
<configuration>
  <configSections>
	...
    <section name="appdynamics" type="AppDynamics.Configuration.AppDynamicsConfigurationSection, AppDynamics.Configuration"/>
  </configSections>
  ...
</configuration>
```

Step 2: Add the ```appdynamics``` configuration element

```
<configuration>
  ...
  <appdynamics>
	<app name="test_app">
		<properties>
		  <clear/>
		  <add key="test" value="app property"/>
		</properties>
	</app>
	<tier name="test_tier">
		<properties>
		  <clear/>
		  <add key="test" value="tier property"/>
		</properties>
	</app>
    <properties>
      <clear/>
      <add key="test" value="node property"/>
    </properties>
  </appdynamics>
  ...
</configuration>
```

## Configuration Elements and Attributes

* appdynamics: top-level configuration element
	* app: (required) configuration block relating to the AppDynamics app this application relates to
		* @name: (required) AppDynamics app name to attach this application to
		* properties: (optional) key/value configuration block to app-specific AppDynamics properties 
	* tier: (required) configuration block relating to the AppDynamics tier this application relates to
		* @name: (required) AppDynamics tier name within the app
		* properties: (optional) key/value configuration block to tier-specific AppDynamics properties 
	* properties: (optional) key/value configuration block for node-specific AppDynamics properties
