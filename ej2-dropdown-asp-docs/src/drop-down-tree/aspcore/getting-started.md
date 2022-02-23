---
title: "Drop-down tree Getting started"
component: "Dropdown Tree"
description: "This section explains how to create a simple Syncfusion ASP.NET Core drop-down tree control and configure it's functionalities in ASP.NET Core."
---

# Getting Started

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET CORE application to use our components.

This section briefly explains you about how to include simple **DropDown Tree** control in your ASP.NET Core application. You can refer to [ASP.NET Core Getting Started documentation](../getting-started/) page for system requirements, and configure common specifications.

## Initialize DropDown Tree control to the Application

DropDown Tree control can be rendered by using the `ejs-dropdowntree` tag helper in ASP.NET Core application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the DropDown Tree.

{% aspTab template="dropdowntree/getting-started/default", sourceFiles="data.cs" %}

{% endaspTab %}

> Running the above code will display the basic DropDown Tree on the browser.

## Binding data source

The Dropdown Tree control can load the data either from local data sources or remote data services. This can be done using the `dataSource` property that is a member of the `fields` property. The dataSource property supports nested list of data and DataManager. Here, nested list of data is passed to the Dropdown Tree control.

{% aspTab template="dropdowntree/getting-started/data", sourceFiles="data.cs" %}

{% endaspTab %}

Output be like the below.

![DropDownTree Sample](./images/getting-started.PNG)
