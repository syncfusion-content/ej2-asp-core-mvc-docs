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

 This section briefly explains about how to include a simple Toolbar in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part part of the system requirements and configure the common specifications.

## Adding component to the Application

* Now open your view and controller page to render Toolbar component.

{% aspTab  template="toolbar/getting-started/data", sourceFiles="data.cs"%}

{% endaspTab %}

Output be like the below.

![getting started](../../toolbar/images/gettingstarted.PNG)

## Render the Toolbar items using content template

You can bind any HTML elements or other components in Toolbar items, by simply using the content template property in ASP.NET Toolbar.

In the below demo, the Toolbar items are given as [Button](../button), [MaskedTextBox](../maskedtextbox), [RadioButton](../radio-button), [DropDownList](../drop-down-list) using the content template. In the content template property of Toolbar, you can directly render these controls like below in the code.

{% aspTab template="toolbar/how-to/contenttemplate", sourceFiles="contenttemplate.cs" %}

{% endaspTab %}

Output be like the below.

![content template](../../toolbar/images/contenttemplate.PNG)

## See Also

* [How to add Toggle Button](./how-to/add-toggle-button)