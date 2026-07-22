---
layout: post
title: Getting Started with ASP.NET Core ComboBox Control | Syncfusion
description: Check out and learn about getting started with ASP.NET Core ComboBox control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: ComboBox
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core ComboBox Control

This section briefly explains how to include the [ASP.NET Core ComboBox](https://www.syncfusion.com/aspnet-core-ui-controls/combobox) control in your ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create an ASP.NET Core Web App with Razor pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install the required ASP.NET Core packages

To add **ASP.NET Core ComboBox** control in the app, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for and install the [Syncfusion.AspNetCore.DropDowns](https://www.nuget.org/packages/Syncfusion.AspNetCore.DropDowns) and [Syncfusion.AspNetCore.Themes](https://www.nuget.org/packages/Syncfusion.AspNetCore.Themes) packages. All Syncfusion ASP.NET Core packages are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

Alternatively, you can install the same packages using the Package Manager Console with the following command.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.DropDowns -Version {{ site.releaseversion }}
Install-Package Syncfusion.AspNetCore.Themes -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Tag Helpers

After the packages are installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.DropDowns` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.DropDowns

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

The theme stylesheet and script can be referenced from [CDN](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#cdn-reference). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml**.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    @* ASP.NET Core controls styles *@
    <link rel="stylesheet" href="_content/Syncfusion.AspNetCore.Themes/styles/fluent2.css" />
    @* ASP.NET Core controls scripts *@
    <script src="_content/Syncfusion.AspNetCore.DropDowns/scripts/sf-combo-box.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the Script Manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager `<ejs-scripts>` at the end of the `<body>` element as follows.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    @*  ASP.NET Core Script Manager *@
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core ComboBox control

Add the [ASP.NET Core ComboBox](https://www.syncfusion.com/aspnet-core-ui-controls/combobox) control in the **~/Pages/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/combobox/getting-started/default/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core ComboBox](https://www.syncfusion.com/aspnet-core-ui-controls/combobox) control will render in your default web browser.

![ASP.NET Core ComboBox Control](images/combobox-control.webp)

## Binding data source

After initializing, populate the [ASP.NET Core ComboBox](https://www.syncfusion.com/aspnet-core-ui-controls/combobox) with data using the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.ComboBox.html#Syncfusion_EJ2_DropDowns_ComboBox_DataSource) property with an array of string values.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/combobox/getting-started/data/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Custom values

The [ASP.NET Core ComboBox](https://www.syncfusion.com/aspnet-core-ui-controls/combobox) allows users to enter custom values that are not present in the predefined set of values. By default, this support is enabled by the [allowCustom](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.ComboBox.html#Syncfusion_EJ2_DropDowns_ComboBox_AllowCustom) property. In this case, both the text field and value field are considered the same. The custom value will be sent to the post back handler when a form is submitted.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/combobox/getting-started/customvalue/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Configure the popup list

By default, the width of the popup list automatically adjusts according to the [ASP.NET Core ComboBox](https://www.syncfusion.com/aspnet-core-ui-controls/combobox) input element's width, and the height of the popup list is **300px**.

The height and width of the popup list can also be customized using the [popupHeight](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.ComboBox.html#Syncfusion_EJ2_DropDowns_ComboBox_PopupHeight) and [popupWidth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.ComboBox.html#Syncfusion_EJ2_DropDowns_ComboBox_PopupWidth) properties respectively.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/combobox/getting-started/suggestionlist/tagHelper %}
{% endhighlight %}
{% endtabs %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/ComboBox/ASP.NET%20Core%20Tag%20Helper%20Examples).

## See also

* [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages)
* [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
* [How to bind the data in ASP.NET Core ComboBox](./data-binding)
