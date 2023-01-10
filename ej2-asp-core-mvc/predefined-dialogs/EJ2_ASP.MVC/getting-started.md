---
layout: post
title: Getting Started with ASP.NET MVC Predefined Dialogs | Syncfusion
description: Checkout and learn about getting started with ASP.NET MVC Predefined Dialogs of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ejmvc
documentation: ug
---


# Getting Started with ASP.NET Core Predefined Dialogs 
This section briefly explains about how to include ASP.NET MVC Predefined Dialogs in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio)

* [Create a Project using Syncfusion ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

Syncfusion ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. To add ASP.NET MVC controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

N> The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

N> If you create ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it. 

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add style sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion ASP.NET MVC controls. Here, the theme is referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager

Open `~/Views/Shared/_Layout.cshtml` page and register the script manager `EJS().ScriptManager()` at the end of `<body>` in the ASP.NET MVC application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Open ASP.NET MVC Predefined Dialogs 

Now, add the Syncfusion ASP.NET MVC Pregefined Dialogs in `~/Views/Home/Index.cshtml` page.

Once you completed the setup, you can open predefined dialogs from any where in application using `Alert`,`Confirm` or `Prompt` methods in `DialogUtility`.

### Show alert dialog

An alert dialog box used to display an errors, warnings, and information alerts that needs user awareness. This can be achieved by using the `DialogUtility.alert` method. The alert dialog is displayed along with the `OK` button. When user clicks on `OK` button, alert dialog will get closed.

In the below code example, alert dialog displayed on button click action.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/predefined-dialogs/getting-started/alert-dialog/razor %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC predefined dialogs will be rendered in the default web browser.

![ASP.NET MVC Predefinded Dialogs alert](./images/alert-default.png)

### Show confirm dialog

A confirm dialog box used to displays a specified message along with the `OK` and `Cancel` buttons.This can be achieved by using the `DialogUtility.confirm` method. It is used to get approval from the user, and it appears before any critical action. After get approval from the user the dialog will disappear automatically.

In the below code example, the confirm dialog displayed on `OK` and `Cancel` button click action.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/predefined-dialogs/getting-started/confirm-dialog/razor %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Predefinded Dialogs confirm](./images/confirm-default.png)

### Show Prompt dialog

A prompt dialog is used to get the input from the user. When the user clicks the `OK` button the input value from the dialog is returned. If the user clicks the `Cancel` button the null value is returned. After getting the input from the user the dialog will disappear automatically.

In the below code example, the confirm dialog displayed on `OK` and `Cancel` button click action.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/predefined-dialogs/getting-started/prompt-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/getting-started/prompt-dialog/controller.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Predefinded Dialogs prompt](./images/prompt-default.png)

## See also

* [Real time example using Dialog](https://ej2.syncfusion.com/aspnetmvc/Grid/DialogEditing#/bootstrap5)
* [Load dialog content using AJAX](./how-to/load-dialog-content-using-ajax)
* [How to position the dialog on center of the page on scrolling](./how-to/position-the-dialog-on-center-of-the-page-on-scrolling)
* [Prevent closing of modal dialog](./how-to/prevent-closing-of-modal-dialog)
* [Close dialog while click on outside of dialog](./how-to/close-dialog-while-click-on-outside-of-dialog)
* [How to make a reusable alert and confirm dialog](./how-to/render-a-dialog-using-utility-functions)
