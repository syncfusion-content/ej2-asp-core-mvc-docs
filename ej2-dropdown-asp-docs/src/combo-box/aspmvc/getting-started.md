---
title: "Combo box Getting started"
component: "ComboBox"
description: "This section explains how to create a simple Syncfusion ASP.NET MVC combo box control and configure its functionalities in ASP.NET MVC application."
---

# Getting Started

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET MVC application to use our controls.

This section briefly explains how to include simple ComboBox control in your ASP.NET MVC application. You can refer to [ASP.NET MVC Getting Started documentation](../getting-started/) page for system requirements, and configure common specifications.

## Initialize ComboBox control to the Application

ComboBox control can be rendered by using the `EJS().ComboBox()` tag helper in ASP.NET MVC application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the ComboBox.

{% aspTab template="combobox/getting-started/default", sourceFiles="data.cs" %}

{% endaspTab %}

## Binding data source

After initializing, populate the ComboBox with data using the [dataSource](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~DataSource.html) property.
Here, an array of string values is passed to the ComboBox component.

The following example illustrates the output in your browser.

{% aspTab template="combobox/getting-started/data", sourceFiles="data.cs" %}

{% endaspTab %}

## Custom values

The ComboBox allows the user to give input as custom value which is not required to present in predefined
set of values. By default, this support is enabled by [allowCustom](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~AllowCustom.html)
 property. In this case, both text field and value field considered as same.
The custom value will be sent to post back handler when a form is about to be submitted.

{% aspTab template="combobox/getting-started/customvalue", sourceFiles="customvalue.cs" %}

{% endaspTab %}

## Configure the popup list

By default, the width of the popup list automatically adjusts according to the ComboBox input element's width, and the height of the popup list has '300px'.

The height and width of the popup list can also be customized using the
[popupHeight](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~PopupHeight.html) and [popupWidth](https://help.syncfusion.com/cr/cref_files/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~PopupWidth.html) properties
respectively.

In the following sample, popup list's width and height are configured.

{% aspTab template="combobox/getting-started/suggestionlist", sourceFiles="suggestionlist.cs" %}

{% endaspTab %}

## See Also

* [How to bind the data](./data-binding/)
