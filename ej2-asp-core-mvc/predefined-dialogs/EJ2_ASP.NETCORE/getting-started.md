---
layout: post
title: Getting Started with ASP.NET CORE Predefined Dialogs | Syncfusion
description: Checkout and learn about getting started with ASP.NET CORE Predefined Dialogs of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ASP.NET CORE
documentation: ug
---


# Getting Started with ASP.NET Core Predefined Dialogs 

This section briefly explains about how to include ASP.NET Core Predefined Dialogs in your ASP.NET Core application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET Core controls](https://ej2.syncfusion.com/aspnetcore/documentation/system-requirements/)

## Create ASP.NET Core web application with Razor pages

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-6.0&tabs=visual-studio#create-a-razor-pages-web-app)

* [Create a Project using Syncfusion ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/project-template/)

## Install ASP.NET Core package in the application

Syncfusion ASP.NET Core controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages/) to learn more about installing NuGet packages in various OS environments. To add ASP.NET Core controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.AspNet.Core](https://www.nuget.org/packages/Syncfusion.EJ2.AspNet.Core/) and then install it.

> The Syncfusion.EJ2.AspNet.Core NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

## Add Syncfusion ASP.NET Core Tag Helper

Open `~/Views/_ViewImports.cshtml` file and import the `Syncfusion.EJ2` TagHelper.

{% tabs %}
{% highlight c# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.EJ2

{% endhighlight %}
{% endtabs %}

## Add style sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme/) to learn different ways ([CDN](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#cdn-reference), [NPM package](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references#node-package-manager-npm), and [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator/)) to refer styles in ASP.NET Core application, and to have the expected appearance for Syncfusion ASP.NET Core controls. Here, the theme is referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Pages/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager

Open `~/Pages/Shared/_Layout.cshtml` page and register the script manager <ejs-script> at the end of `<body>` in the ASP.NET Core application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Render a Dialog using utility functions

The Dialog control provides built-in utility functions to render the alert and confirm dialogs with the minimal code. The following options are used as an argument on calling the utility functions:

| Options   | Description |
|-----------|-------------|
| title | Specifies the title of dialog like the [`header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Header) property.|
| content | Specifies the value that can be displayed in dialog's content area like the [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Content) property. |
| isModal | Specifies the Boolean value whether the dialog can be displayed as modal or non-modal. For more details, refer to the [`isModal`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_IsModal) property.|
| position | Specifies the value where the alert or confirm dialog is positioned within the document. For more details, refer to the [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Position) property { X: ‘center’, Y: ‘center’}|
| okButton | Configures the `OK button` that contains button properties with the click events. `okButton:{ icon:'prefix icon to the button', cssClass:'custom class to the button', click: 'action for OK button click', text: 'Yes' // <-- Default value is 'OK' }`|
| cancelButton | Configures the `Cancel button` that contains button properties with the click events. `cancelButton:{ icon:'prefix icon to the button', cssClass:'custom class to the button', click: 'action for ‘Cancel’ button click', text: 'No' // <-- Default value is 'Cancel'}`|
|isDraggable|Specifies the value whether the alert or confirm dialog can be dragged by the user.|
| showCloseIcon | When set to true, the close icon is shown in the Dialog control. |
| closeOnEscape|When set to true, you can close the dialog by pressing ESC key.|
| cssClass | Specifies the CSS class name that can be appended to the dialog.|
| zIndex | Specifies the order of the dialog, that is displayed in front or behind of another component.|
| open | Event which is triggered after the dialog is opened.|
| Close | Event which is triggered after the dialog is closed.|
| animationSettings | Specifies the animation settings of the dialog component. |
## Add ASP.NET Core Predefined Dialogs

Now, add the Syncfusion ASP.NET Core Pregefined Dialogs tag helper in `~/Pages/Index.cshtml` page.

Once you completed the setup, you can open predefined dialogs from any where in application using `Alert`,`Confirm` or `Prompt` methods in `DialogUtility`.
The dialog component provides built-in utility functions to render the alert and confirm dialogs with the minimal code.
The following options are used as an argument on calling the utility functions:

### Show alert dialog

An alert dialog box used to display an errors, warnings, and information alerts that needs user awareness. This can be achieved by using the `DialogUtility.alert` method. The alert dialog is displayed along with the `OK` button. When user clicks on `OK` button, alert dialog will get closed.

In the below code example, alert dialog displayed on button click action.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/predefined-dialogs/getting-started/alert-dialog/tagHelper %}
{% endhighlight %}
{% endtabs %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET Core Predefined Dialog will be rendered in the default web browser.

![ASP.NET Core Predfined Dialogs alert Dialog](./images/alert-default.png)
### Show confirm dialog

A confirm dialog box used to displays a specified message along with the `OK` and `Cancel` buttons.This can be achieved by using the `DialogUtility.confirm` method. It is used to get approval from the user, and it appears before any critical action. After get approval from the user the dialog will disappear automatically.

In the below code example, the confirm dialog displayed on `OK` and `Cancel` button click action.
 
{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/predefined-dialogs/getting-started/confirm-dialog/tagHelper %}
{% endhighlight %}
{% endtabs %}


![ASP.NET CORE Predefined Dialogs confirm Dialog](./images/confirm-default.png)

### Show Prompt dialog

A prompt dialog is used to get the input from the user. When the user clicks the `OK` button the input value from the dialog is returned. If the user clicks the `Cancel` button the null value is returned. After getting the input from the user the dialog will disappear automatically.

In the below code example, the confirm dialog displayed on `OK` and `Cancel` button click action.
 
{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/predefined-dialogs/getting-started/prompt-dialog/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET CORE Predefined Dialogs prompt Dialog](./images/prompt-default.png)
## See also

* [Getting Started with Syncfusion ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
* [Getting Started with Syncfusion ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
* [Load dialog content using AJAX](./how-to/load-dialog-content-using-ajax)
* [How to position the dialog on center of the page on scrolling](./how-to/position-the-dialog-on-center-of-the-page-on-scrolling)
* [Prevent closing of modal dialog](./how-to/prevent-closing-of-modal-dialog)
* [Close dialog while click on outside of dialog](./how-to/close-dialog-while-click-on-outside-of-dialog)
* [How to make a reusable alert and confirm dialog](./how-to/render-a-dialog-using-utility-functions)
