---
layout: post
title: License Key Registration in ##Platform_Name## Ej2_asp.netcore Component
description: Learn here all about License Key Registration in Syncfusion ##Platform_Name## Ej2_asp.netcore component and more.
platform: ej2-asp-core-mvc
control: License Key Registration
publishingplatform: ##Platform_Name##
documentation: ug
---

# Register Syncfusion License key in ASP.NET Core application

Syncfusion license key should be registered, if your project using Syncfusion ASP.NET Core packages reference from [nuget.org](https://www.nuget.org/packages?q=syncfusion) or from trial installer. The generated license key is a string that needs to be registered before any Syncfusion control is initiated. The following code is used to register the license.

{% tabs %}
{% highlight c# tabtitle="C#" %}

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

{% endhighlight %}
{% endtabs %}

> Place the license key between double quotes. Also, ensure that Syncfusion.Licensing.dll is referenced in your project where the license key is being registered.

## For ASP.NET Core application using .NET 6.0

Register the license key in the `Program.cs` file if you created the ASP.NET Core web application with Visual Studio 2022 and .NET 6.0. 

{% tabs %}
{% highlight c# tabtitle="Program.cs" %}

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
{% endtabs %}

## For ASP.NET Core application using .NET 5.0 or .NET 3.1

Register the license key in Configure method of Startup.cs

{% tabs %}
{% highlight c# tabtitle="Startup.cs" %}

// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(" Your product license key ");
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    else
    {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

...
}

{% endhighlight %}
{% endtabs %}
