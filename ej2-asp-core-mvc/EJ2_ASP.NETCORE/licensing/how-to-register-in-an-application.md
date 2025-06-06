---
layout: post
title: Overview of Syncfusion license registration - Syncfusion
description: Learn here about how to register Syncfusion ##Platform_Name## license key for ##Platform_Name## application for license validation.
platform: ej2-asp-core-mvc
control: License Key Registration
publishingplatform: ##Platform_Name##
documentation: ug
---

# Register Syncfusion<sup style="font-size:70%">&reg;</sup> License key in ASP .NET Core EJ2 application

Syncfusion<sup style="font-size:70%">&reg;</sup> license key should be registered, if your project using Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core packages refer from [nuget.org](https://www.nuget.org/packages?q=syncfusion) or from syncfusion<sup style="font-size:70%">&reg;</sup> installer. The generated license key is a string that needs to be registered before any Syncfusion<sup style="font-size:70%">&reg;</sup> control is initiated. The following code is used to register the license.

{% tabs %}
{% highlight c# tabtitle="C#" %}

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

{% endhighlight %}
{% endtabs %}

N> * Place the license key between double quotes. Also, ensure that Syncfusion.Licensing.dll is referenced in your project where the license key is being registered.
* Syncfusion<sup style="font-size:70%">&reg;</sup> license validation is done offline during application execution and does not require internet access. Apps registered with a Syncfusion<sup style="font-size:70%">&reg;</sup> license key can be deployed on any system that does not have an internet connection.

## For ASP.NET Core application using .NET 8.0/.NET 9.0

Register the license key in the `Program.cs` file if you created the ASP.NET Core web application with Visual Studio 2022 and .NET 8.0 /.NET 9.0. 

{% tabs %}
{% highlight c# tabtitle="Program.cs" %}

var app = builder.Build();
//Register Syncfusion license
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

{% endhighlight %}
{% endtabs %}
