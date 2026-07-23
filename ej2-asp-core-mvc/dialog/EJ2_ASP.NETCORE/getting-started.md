---
layout: post
title: Getting Started with ##Platform_Name## Dialog Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Dialog control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET Core Dialog Control

This section briefly explains how to include the [ASP.NET Core Dialog](https://www.syncfusion.com/aspnet-core-ui-controls/modal-dialog) control in an ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create ASP.NET Core web application with Razor pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install ASP.NET Core package in the application

To add [ASP.NET Core Dialog](https://www.syncfusion.com/aspnet-core-ui-controls/modal-dialog) control in the app, open the NuGet package manager in Visual Studio (*Tools → NuGet Package Manager → Manage NuGet Packages for Solution*), search for and install the [Syncfusion.AspNetCore.Popups](https://www.nuget.org/packages/Syncfusion.AspNetCore.Popups/) and [Syncfusion.AspNetCore.Themes](https://www.nuget.org/packages/Syncfusion.AspNetCore.Themes/) packages. All Syncfusion ASP.NET Core packages are available in [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

Alternatively, you can install the same package using the Package Manager Console with the following command.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.Popups -Version {{ site.releaseversion }}
Install-Package Syncfusion.AspNetCore.Themes -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add the ASP.NET Core Tag Helper

After the packages are installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.Popups` Tag Helpers.

{% tabs %}
{% highlight C# tabtitle="~/_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.Popups

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

The theme stylesheet and script are referenced from [CDN](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#cdn-reference). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of the **~/Pages/Shared/_Layout.cshtml**.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the Script Manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager `<ejs-scripts>` at the end of the `<body>` element as follows.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<body>
    ...
    <!-- Syncfusion ASP.NET Core Script Manager -->
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Dialog control

Add the [ASP.NET Core Dialog](https://www.syncfusion.com/aspnet-core-ui-controls/modal-dialog) control in `~/Pages/Index.cshtml` page.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/dialog/getting-started/getting-started/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Dialog](https://www.syncfusion.com/aspnet-core-ui-controls/modal-dialog) will render in your default web browser.

![ASP.NET Core Dialog Control](images/dialog-getting.webp)

## Display content using `ContentTemplate`

You can also pass the Dialog body content as a template by using the `ContentTemplate` property. This is useful when the dialog content includes multiple HTML elements or Razor markup.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/dialog/getting-started/data/tagHelper %}
{% endhighlight %}
{% endtabs %}

N> In the dialog control, max-height is calculated based on the dialog target element height. If the target property is not configured, the document body is considered as a target. Therefore, to show a dialog in proper height, you need to add min-height to the target element.

## Modal Dialog

Setting [`IsModal`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_IsModal) to true shows an overlay behind the Dialog. So, the user must interact with the Dialog before interacting with other content.

When the user clicks the overlay, the action can be handled through the [`overlayClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_OverlayClick) event.

N> When the modal dialog is opened, scrolling within the Dialog's target element is disabled. The scrolling will be enabled again once the Dialog is closed.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/dialog/getting-started/modal/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Modal Dialog](images/modal-dialog-getting.webp)

N>In the dialog control, if the dialog is rendered based on the body, then the dialog gets its height based on its body element height. If the height of the dialog is larger than the body height, then the dialog's height will not be set. For this scenario, the CSS style for the html and body can be set to get the dialog height.

```css

html, body {
   height: 100%;
}

```

## Enable header

The Dialog header can be enabled by adding the header content as text or HTML content through the [`header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Header) property.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/dialog/getting-started/enable-header/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Enable footer

The Dialog provides built-in support to render the `buttons` on the footer (for ex: `OK` or `Cancel` buttons). Each Dialog button can perform an action when clicked.

The primary button is focused automatically when the Dialog is opened. Use the [`click`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.DialogDialogButton.html#Syncfusion_EJ2_Popups_DialogDialogButton_Click) event to handle the button actions.

N> When the Dialog initializes with more than one primary button, the first primary button gets focus when opening the Dialog.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/dialog/getting-started/enable-footer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
public class ButtonModel
{
   public string content { get; set; }
   public bool isPrimary { get; set; }
   public string cssClass { get; set; }
}
{% endhighlight %}
{% endtabs %}

## Draggable

The Dialog supports [dragging](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_AllowDragging) within its target container by holding the Dialog header, which allows the user to reposition the Dialog dynamically.

N> The Dialog can be draggable only when the Dialog header is enabled. From `16.2.x` version, Draggable support for modal dialogs was also enabled.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/dialog/getting-started/draggable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cshtml.cs" %}
public class ButtonModel
{
   public string content { get; set; }
   public string cssClass { get; set; }
}
{% endhighlight %}
{% endtabs %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/Dialog/ASP.NET%20Core%20Tag%20Helper%20Examples).

## Positioning

The Dialog can be positioned using the [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Position) property by providing the X and Y coordinates. It can be positioned inside the target container or **<body>** of the element based on the given X and Y values.

For X: left, center, right (or) any offset value.
For Y: top, center, bottom (or) any offset value.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/dialog/getting-started/positioning/tagHelper %}
{% endhighlight %}
{% endtabs %}

## See also

* [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
* [Load dialog content using AJAX](./how-to/load-dialog-content-using-ajax)
* [How to position the dialog on center of the page on scrolling](./how-to/position-the-dialog-on-center-of-the-page-on-scrolling)
* [Prevent closing of modal dialog](./how-to/prevent-closing-of-modal-dialog)
* [Close dialog while click on outside of dialog](./how-to/close-dialog-while-click-on-outside-of-dialog)
* [How to make a reusable alert and confirm dialog](./how-to/render-a-dialog-using-utility-functions)
