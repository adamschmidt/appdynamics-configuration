# .NET Configuration Module for AppDynamics

This project is a generic configuration block to include in .NET config files relating to AppDynamics. NOTE: This does not
tie in with the .NET agent, it's merely a construct to assist with configuration and automation.

## Installation

This package is available as a Nuget package:

```
Install-Package AppDynamics.Configuration
```

Installing the package includes a transform of your Web.config or App.config to include the config section declaration
and the configuration block. After installation, your config file will look as follows:

```
<configuration>
  <configSections>
	...
    <section name="appdynamics" type="AppDynamics.Configuration.AppDynamicsConfigurationSection, AppDynamics.Configuration"/>
  </configSections>
  <appdynamics>
	<app name="test_app">
		<properties/>
	</app>
	<tier name="...your assembly name...">
		<properties/>
	</app>
    <properties/>
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
