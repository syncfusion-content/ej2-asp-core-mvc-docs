---
layout: post
title: Licensing Troubleshoot in Syncfusion ##Platform_Name## Component
description: Learn here all about licensing troubleshoot in Syncfusion ##Platform_Name## component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Licensing Troubleshoot
publishingplatform: ##Platform_Name##
documentation: ug
---

# Syncfusion<sup style="font-size:70%">&reg;</sup> Licensing FAQ

## Is an internet connection required for Syncfusion<sup style="font-size:70%">&reg;</sup> Essential Studio<sup style="font-size:70%">&reg;</sup> license validation?

* Syncfusion<sup style="font-size:70%">&reg;</sup> license validation is done offline during application execution and does not require internet access. 

* Apps registered with a Syncfusion<sup style="font-size:70%">&reg;</sup> license key can be deployed on any system that does not have an internet connection.

## How to upgrade from trial version after purchasing a license

To upgrade from trial version, there are two possible solutions.

* Uninstall the trial version and install the fully licensed build from the [License & Downloads](https://www.syncfusion.com/account/downloads) section of our website.

* If you are using Syncfusion<sup style="font-size:70%">&reg;</sup> controls from [nuget.org](https:/www.nuget.org/packages?q=syncfusion), replace the currently used trial license key with a paid license key that can be generated from the [License & Downloads](https://www.syncfusion.com/account/downloads) section of our website. Refer to [this](https://ej2.syncfusion.com/aspnetcore/documentation/licensing/how-to-register-in-an-application) topic for more information regarding registering the license in the application.

N> License registration is not required if you reference Syncfusion<sup style="font-size:70%">&reg;</sup> assemblies from Licensed installer. These licensing changes applicable to all evaluators who refers the Syncfusion<sup style="font-size:70%">&reg;</sup> assemblies from evaluation installer and those who use Syncfusion<sup style="font-size:70%">&reg;</sup> NuGet packages from [nuget.org](https://www.nuget.org/).

## Where can I get a license key

License keys can be generated from the [License & Downloads](https://syncfusion.com/account/downloads) or [Trial & Downloads](https://www.syncfusion.com/account/manage-trials/downloads) section of the Syncfusion<sup style="font-size:70%">&reg;</sup> website.

![Get Community License Key](images/get-community-license-key.png)

N> Syncfusion<sup style="font-size:70%">&reg;</sup> license keys are **version and platform specific**. Refer to the [KB](https://www.syncfusion.com/kb/8976/how-to-generate-license-key-for-licensed-products) to generate the license key for the required version and platform.
<br/> Refer to this [KB](https://www.syncfusion.com/kb/8951/which-version-syncfusion-license-key-should-i-use-in-my-application) to know which version of the Syncfusion<sup style="font-size:70%">&reg;</sup> license key should be used in the application.

## Registering Syncfusion<sup style="font-size:70%">&reg;</sup> account for direct NuGet.org user

If you have directly obtained Syncfusion<sup style="font-size:70%">&reg;</sup> assemblies from [NuGet.org](http://nuget.org/) and do not have a Syncfusion<sup style="font-size:70%">&reg;</sup> account, follow the steps to obtain a free 30-day trial license key:

* Register for a free Syncfusion<sup style="font-size:70%">&reg;</sup> account [here](https://www.syncfusion.com/account/register).
* Go to the start trials [page](https://syncfusion.com/account/manage-trials/start-trials) and start a trial.
* Finally proceed to the [Trial & Downloads section](https://www.syncfusion.com/account/manage-trials/downloads) to obtain the [license key](https://ej2.syncfusion.com/aspnetcore/documentation/licensing/how-to-generate).

## Registering license key for Syncfusion<sup style="font-size:70%">&reg;</sup> JavaScript Components used in ASP.NET Core App

If you are using [Syncfusion<sup style="font-size:70%">&reg;</sup> JavaScript Components](https://ej2.syncfusion.com/home/) in application, then you have to register license for ASP.NET Core in `Program.cs` and for JavaScript components register license in `_Layout.cshtml` after referring to the Syncfusion<sup style="font-size:70%">&reg;</sup> styles and scripts as follows,

N>  From 2022 Vol 1 (v20.1) only the license key registration required for Syncfusion<sup style="font-size:70%">&reg;</sup> Javascript Components.

{% tabs %}
{% highlight c# tabtitle="Program.cs" hl_lines="3" %}

var app = builder.Build();
//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

{% endhighlight %}

{% highlight c# tabtitle="~/_Layout.cshtml" hl_lines="9" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
    <script>
        // Registering Syncfusion license key
        ej.base.registerLicense('License Key');
    </script>
</head>

{% endhighlight %}
{% endtabs %}
