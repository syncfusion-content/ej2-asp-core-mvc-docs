---
title: "Drop-down list Getting started"
component: "DropDownList"
description: "This section explains how to create a simple Syncfusion ASP.NET MVC drop-down list control and configure it's functionalities in ASP.NET MVC application."
---

# Getting Started

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET MVC application to use our controls.

This section briefly explains how to include simple DropDownList control in your ASP.NET MVC application. You can refer to [ASP.NET MVC Getting Started documentation](../getting-started/) page for system requirements, and configure common specifications.

## Initialize DropDownList control to the Application

DropDownList control can be rendered by using the `EJS().DropDownList()` tag helper in ASP.NET MVC application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the DropDownList.

{% aspTab template="dropdownlist/getting-started/default", sourceFiles="data.cs" %}

{% endaspTab %}

> Running the above code will display the basic DropDownList on the browser.

## Binding data source

After initialization, populate the DropDownList with data using the [dataSource](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~DataSource.html) property.
Here, an array of string values is passed to the DropDownList control.

The following example illustrates the output in your browser.

{% aspTab template="dropdownlist/getting-started/data", sourceFiles="data.cs" %}

{% endaspTab %}

## Configure the popup list

By default, the width of the popup list automatically adjusts according to the DropDownList input element's width, and the height of the popup list has '300px'.

The height and width of the popup list can also be customized using the
[popupHeight](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~PopupHeight.html) and [popupWidth](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~PopupWidth.html) properties
respectively.

In the following sample, popup list's width and height are configured.

{% aspTab template="dropdownlist/getting-started/suggestionlist", sourceFiles="suggestionlist.cs" %}

{% endaspTab %}

## See Also

* [How to bind the data](./data-binding/)