---
layout: post
title: Overview of Syncfusion license registration - Syncfusion
description: Learn here about how to register Syncfusion ##Platform_Name## license key for ##Platform_Name## application for license validation.
platform: ej2-asp-core-mvc
control: License Key Registration
publishingplatform: ##Platform_Name##
documentation: ug
---

## Review notes

### MISSING STEPS
- [MISSING STEPS] Intro paragraph — No explicit step tells users where to place the registration call in an existing ASP.NET Core app using older startup patterns — Add a note for Startup.cs-based apps or link to the matching setup topic.
- [MISSING STEPS] .NET 8.0/.NET 9.0 section — No prerequisite states that the app must already reference the Syncfusion.Licensing package/assembly before calling `RegisterLicense()` — Add a prerequisite note for the licensing dependency.

### MISSING INFORMATION
- [MISSING INFORMATION] Intro paragraph — The page does not mention where to obtain the license key, only that it must be registered — Link to the license generation topic.
- [MISSING INFORMATION] .NET 8.0/.NET 9.0 section — No compatibility note explains whether the sample applies to minimal hosting only, or also to older ASP.NET Core templates — Clarify supported hosting model and template versions.
- [MISSING INFORMATION] Code sample — The snippet omits the full `Program.cs` context, so it is unclear where `builder.Build()` comes from — Add a small surrounding context or clarify that this is an excerpt.

### TECHNICAL ACCURACY
- [TECHNICAL ACCURACY] Intro paragraph — “if your project using” is grammatically incorrect and reduces clarity — Change to “if your project uses”.
- [TECHNICAL ACCURACY] Intro paragraph — “refer from nuget.org or from syncfusion installer” is awkward and imprecise — Change to “referenced from NuGet.org or the Syncfusion installer”.
- [TECHNICAL ACCURACY] Note block — “Syncfusion.Licensing.dll is referenced” is outdated for NuGet-based projects, where a package reference is usually used instead of a direct DLL reference — Clarify package versus assembly reference.
- [TECHNICAL ACCURACY] .NET 8.0/.NET 9.0 section — The snippet uses `var app = builder.Build();` without showing `builder` initialization, so it will not run as-is — Include the missing preceding lines or mark it as a partial snippet.
- [TECHNICAL ACCURACY] .NET 8.0/.NET 9.0 section — The sample is labeled for .NET 8.0/.NET 9.0 only, but the registration pattern also applies to other minimal-hosting versions — Broaden or qualify the version note.

### GRAMMATICAL / LANGUAGE ISSUES
- [GRAMMATICAL / LANGUAGE ISSUES] Heading and intro — “License key” is inconsistently capitalized across the page — Use consistent capitalization for the term throughout.
- [GRAMMATICAL / LANGUAGE ISSUES] Intro paragraph — “if your project using” is ungrammatical — Change to “if your project uses”.
- [GRAMMATICAL / LANGUAGE ISSUES] Intro paragraph — “The following code is used to register the license.” is vague — Specify that the code must be placed before any Syncfusion control is initialized.
- [GRAMMATICAL / LANGUAGE ISSUES] .NET 8.0/.NET 9.0 section — “.NET 8.0 /.NET 9.0” contains inconsistent spacing around the slash — Use a consistent format such as “.NET 8.0/.NET 9.0”.

### STRUCTURE / CLARITY
- [STRUCTURE / CLARITY] Page flow — The document jumps from a generic registration note to a version-specific sample without a transition or explanation — Add a short bridge sentence explaining why the second example exists.
- [STRUCTURE / CLARITY] Note block — The two bullet points are mixed into a single note and one line is visually detached from the other — Reformat the note for consistent bullet structure.
- [STRUCTURE / CLARITY] .NET 8.0/.NET 9.0 section — The section title is more specific than the content, which only shows one minimal-hosting snippet — Clarify that the snippet is an example for the newer template.

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
