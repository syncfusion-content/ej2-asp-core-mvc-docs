---
layout: post
title: Getting Started with ASP.NET Core Numeric Textbox Control | Syncfusion
description: Check out and learn about getting started with ASP.NET Core Numeric Textbox control of Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Numeric Textbox
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started with ASP.NET Core Numeric Textbox Control

This section briefly explains how to include the [ASP.NET Core Numeric Textbox](https://www.syncfusion.com/aspnet-core-ui-controls/numeric-textbox) control in your ASP.NET Core application using [Visual Studio](https://visualstudio.microsoft.com/vs/).

## Create an ASP.NET Core Web App with Razor pages

Create an **ASP.NET Core Web App** using Visual Studio via [Microsoft Templates](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-10.0&tabs=visual-studio#create-a-razor-pages-web-app) or the [Syncfusion® ASP.NET Core Extension](https://ej2.syncfusion.com/aspnetcore/documentation/visual-studio-integration/create-project). For detailed instructions, refer to the [ASP.NET Core Web App Getting Started](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages) documentation.

## Install the required ASP.NET Core packages

To add [ASP.NET Core Numeric Textbox](https://www.syncfusion.com/aspnet-core-ui-controls/numeric-textbox) control in the app, open the NuGet package manager in Visual Studio *(Tools → NuGet Package Manager → Manage NuGet Packages for Solution)*, search for and install the [Syncfusion.AspNetCore.Inputs](https://www.nuget.org/packages/Syncfusion.AspNetCore.Inputs/) and [Syncfusion.AspNetCore.Themes](https://www.nuget.org/packages/Syncfusion.AspNetCore.Themes/) packages. All Syncfusion ASP.NET Core packages are available on [nuget.org](https://www.nuget.org/packages?q=syncfusion.EJ2). See the [NuGet packages](https://ej2.syncfusion.com/aspnetcore/documentation/nuget-packages) topic for details.

Alternatively, you can install the same packages using the Package Manager Console with the following command.

{% tabs %}
{% highlight C# tabtitle="Package Manager Console" %}

Install-Package Syncfusion.AspNetCore.Inputs -Version {{ site.releaseversion }}
Install-Package Syncfusion.AspNetCore.Themes -Version {{ site.releaseversion }}

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Tag Helpers

After the packages are installed, open the **~/Pages/_ViewImports.cshtml** file and import the `Syncfusion.AspNetCore.Base` and `Syncfusion.AspNetCore.Inputs` Tag Helpers.

{% tabs %}
{% highlight cshtml tabtitle="_ViewImports.cshtml" %}

@addTagHelper *, Syncfusion.AspNetCore.Base
@addTagHelper *, Syncfusion.AspNetCore.Inputs

{% endhighlight %}
{% endtabs %}

## Add stylesheet and script resources

The theme stylesheet and script can be referenced from [CDN](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme#cdn-reference). Include the [stylesheet](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme) and [script references](https://ej2.syncfusion.com/aspnetcore/documentation/common/adding-script-references) inside the `<head>` of **~/Pages/Shared/_Layout.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<head>
    ...
    @* ASP.NET Core controls styles *@
    <link rel="stylesheet" href="_content/Syncfusion.AspNetCore.Themes/styles/fluent2.css" />
    @* ASP.NET Core controls scripts *@
    <script src="_content/Syncfusion.AspNetCore.Inputs/scripts/sf-numerictextbox.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register the Script Manager

Open the **~/Pages/Shared/_Layout.cshtml** file and register the script manager `<ejs-scripts>` at the end of the `<body>` element as follows.

{% tabs %}
{% highlight cshtml tabtitle="_Layout.cshtml" %}

<body>
    ...
    @* ASP.NET Core Script Manager *@
    <ejs-scripts></ejs-scripts>
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET Core Numeric Textbox control

Add the [ASP.NET Core Numeric Textbox](https://www.syncfusion.com/aspnet-core-ui-controls/numeric-textbox) control in the **~/Pages/Index.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/numeric-textbox/getting-started/getting-started/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Run the application

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to launch the application. The [ASP.NET Core Numeric Textbox](https://www.syncfusion.com/aspnet-core-ui-controls/numeric-textbox) control will render in your default web browser.

![ASP.NET Core Numeric Textbox Control](images/gettingStarted.webp)

## Range validation

You can set the minimum and maximum range of values in the Numeric Textbox using the [min](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Min) and [max](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Max) properties, so the numeric value should be in the min and max range.

The validation behavior depends on the [StrictMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_StrictMode) property.

The below example demonstrates range validation.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/numeric-textbox/getting-started/range/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Formatting the value

Users can set the format of the Numeric Textbox control using the [Format](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Format) property. The value will be displayed in the specified format when the control is in the focused-out state. For more information about formatting the value, refer to this [link](./formats).

The below example demonstrates how to format the value by using currency format value `c2`.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/numeric-textbox/getting-started/format/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Numeric Textbox with Formatting](images/format.webp)

## Precision of numbers

You can restrict the number of decimals to be entered in the Numeric Textbox by using the [decimals](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Decimals) and [validateDecimalOnType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_ValidateDecimalOnType) properties.
So, you cannot enter a value with more decimal places than decimals allows.

* If `validateDecimalOnType` is false, number of decimals will not be restricted.
Otherwise, number of decimals will be restricted while typing in the Numeric Textbox.

{% tabs %}
{% highlight cshtml tabtitle="Index.cshtml" %}
{% include code-snippet/numeric-textbox/getting-started/precision/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Restricting Decimal Values in ASP.NET Core Numeric Textbox](./images/precision.webp)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/NumericTextBox/ASP.NET%20Core%20Tag%20Helper%20Examples)

## See also

1. [Getting Started with ASP.NET Core using Razor Pages](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/razor-pages/)
2. [Getting Started with ASP.NET Core MVC using Tag Helper](https://ej2.syncfusion.com/aspnetcore/documentation/getting-started/aspnet-core-mvc-taghelper)
3. [How to perform custom validation using FormValidator](./how-to/perform-custom-validation-using-form-validator)
4. [How to customize the UI appearance of the control](./how-to/customize-the-ui-appearance-of-the-control)
5. [How to customize the spin button’s up and down arrow](./how-to/customize-the-spin-buttons-up-and-down-arrow)
6. [How to customize the step value and hide spin buttons](./how-to/customize-the-step-value-and-hide-spin-buttons)
7. [How to prevent nullable input in Numeric Textbox](./how-to/prevent-nullable-input-in-numerictextbox)
8. [How to maintain trailing zeros in Numeric Textbox](./how-to/maintain-trailing-zeros-in-numerictextbox)
