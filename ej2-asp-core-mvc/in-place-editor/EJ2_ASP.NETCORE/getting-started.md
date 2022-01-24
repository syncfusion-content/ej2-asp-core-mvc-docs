---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Getting Started of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

 This section briefly explains about how to include a simple In-place Editor in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add the In-place Editor with Textbox

By default, Syncfusion ASP.NET Core TextBox control is rendered in In-place Editor with the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Type) property sets as Text.

{% aspTab template="in-place-editor/getting-started-text", sourceFiles="controller.cs" %}

{% endaspTab %}

## Configuring DropDownList

You can render the Syncfusion ASP.NET Core DropDownList by changing the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Type) property as `DropDownList` and configure its properties and methods using the [`model`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Model) property.

In the following sample, `type` and model values are configured to render the `DropDownList` control.

{% aspTab template="in-place-editor/getting-started-drop", sourceFiles="controller.cs" %}

{% endaspTab %}

## Integrate DatePicker

You can render the Essential JS2 DatePicker by changing the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Type) property as `Date` and also configure its properties and methods using the [`model`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Model) property.

In the following sample, `type` and `model` values are configured to render the `DatePicker` control.

{% aspTab template="in-place-editor/getting-started-date", sourceFiles="controller.cs" %}

{% endaspTab %}

## Run the application

* Now, open your view page to render the In-place Editor component.

{% aspTab template="in-place-editor/getting-started-form", sourceFiles="controller.cs" %}

{% endaspTab %}

The output will be as follows.

![Getting started form](./images/getting-started-form.PNG)

## Submitting data to the server (save)

You can submit editor value to the server by configuring the [`url`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Url), [`adaptor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Adaptor) and [`primaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_PrimaryKey) property.

| Property   | Usage                                           |
|------------|---------------------------------------------------------|
| **`url`**        | Gets the URL for server submit action.        |
| **`adaptor`**    | Specifies the adaptor type that is used by DataManager to communicate with DataSource.  |
| **`primaryKey`** | Defines the unique primary key of editable field which can be used for saving data in the data-base. |

> The `primaryKey` property is mandatory. If it's not set, edited data are not sent to the server.

## Refresh with modified value

The edited data is submitted to the server and you can see the new values getting reflected in the In-place Editor.

{% aspTab template="in-place-editor/getting-started", sourceFiles="controller.cs" %}

{% endaspTab %}

The output will be as follows.

![Getting started](./images/getting-started.PNG)

## See Also

* [Types of rendering the editor](./integration)