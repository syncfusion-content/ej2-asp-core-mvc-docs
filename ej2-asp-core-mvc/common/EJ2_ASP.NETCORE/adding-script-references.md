---
layout: post
title: Adding script references in ##Platform_Name## control | Syncfusion
description: Learn here all about adding script references in Syncfusion ##Platform_Name## control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Reference Scripts in ASP.NET Core Application

This section explains the available approaches for referencing client-side scripts and stylesheets for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls. You can reference scripts via **CDN**, **Static Web Assets** (served directly from NuGet packages), **NPM Packages**, or the **Custom Resource Generator (CRG)**. 

## Static Web Assets

Static web assets allow you to reference Syncfusion<sup style="font-size:70%">&reg;</sup> scripts and stylesheets directly from the installed NuGet packages no CDN, no manual file copying. The ASP.NET Core framework serves these files automatically at the path `_content/{PackageName}/`, making them the most reliable and version-consistent way to reference scripts in production.

### Enable Static Web Assets

To serve static web assets, call [UseStaticFiles](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/static-files?view=aspnetcore-8.0) in the app's `~/Program.cs` file.

{% tabs %}
{% highlight c# tabtitle="Program.cs" %}

var app = builder.Build();
app.UseStaticFiles();

{% endhighlight %}
{% endtabs %}

### Reference scripts from Static Web Assets

The combined script for all Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls is available in the `Syncfusion.AspNetCore.Base` package. Add the reference in the `<head>` element of `~/Pages/Shared/_Layout.cshtml`.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>

    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="_content/Syncfusion.AspNetCore.Base/scripts/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Node Package Manager (NPM)

A package in Node.js consists of a set of files needed for a JavaScript module which can be included in any web application. NPM is the popular package manager for both public and private packages.

### Syncfusion<sup style="font-size:70%">&reg;</sup> NPM packages

Scripts and style sheets of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls can be included in an ASP.NET Core web application using NPM packages, since Syncfusion<sup style="font-size:70%">&reg;</sup> publishes its ASP.NET Core controls as the scoped package in NPM.

#### Installing NPM packages in ASP.NET Core Web Application

1.Open the Source Explorer and right click the application name. Then, select “**Add New Item**” menu item to open the “**Add New Item**” window. 

![Add New Item Window](images/add-new-item.png)

2.Select “**Web**” on the left side Tree View and select “**npm configuration File**” in “**Add New Item**” window which will include and configure “**package.json**” file in root folder of the ASP.NET Core web application. 

![Adding package.json](images/add-package-json.png)

3.Open the Source Explorer and right click on the application name. Then, select “**Open Folder in File Explorer**”. 

4.Open the Command Prompt for this location and install the required Syncfusion<sup style="font-size:70%">&reg;</sup> packages using “**npm install @syncfusion/{PACKAGE_NAME} --save**”

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}

npm install @syncfusion/ej2-calendars --save

{% endhighlight %}
{% endtabs %}

5.Installed packages with all its dependencies can be found under the  “**node_modules**” folder as shown in the following image.

![Installed Syncfusion Packages](images/installed-syncfusion-package.png)

#### From Installed Packages

Scripts and style sheets of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls from locally-installed packages can be included in an ASP.NET Core web application using the following two methods.

N>Files in the **wwwroot** folder can be accessed only in client-side, hence Syncfusion<sup style="font-size:70%">&reg;</sup> scripts and style sheets should be copied from **node_modules** to **wwwroot**.

By using either one of the following methods, Client-Side Resource can be loaded in ASP.NET Core web application:

1. Copying scripts and styles using gulp
2. Generating scripts and styles using [CRG (Custom Resource Generator)](./custom-resource-generator)

#### Copying by Gulp

Install required Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core control packages as mentioned in “[**Installing NPM Packages in ASP.NET Core Web Application**](#installing-npm-packages-in-aspnet-core-web-application)”. 

1.In addition to Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core packages, install gulp and glob packages using below commands.

N>Gulp Installation - **npm install gulp --save**

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}

npm install gulp@latest --save

{% endhighlight %}
{% endtabs %}

N>Glob Installation - **npm install glob --save**

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}

npm install glob@latest --save

{% endhighlight %}
{% endtabs %}

2.To set up the server, open Dependencies -> Manage NuGet Packages -> Browse. Then, search and install "**Microsoft.AspNetCore.StaticFiles -V2.2.0**" and "**Microsoft.TypeScript.MSBuild -V3.8.3**" packages.

![Install NuGet Packages](images/install-nuGet-package.png)
     
Open up your "**Startup.cs**" file and edit your Configure function to looks like the below code snippet.

{% tabs %}
{% highlight c# tabtitle="Startup.cs" %}

public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    if (env.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    app.UseDefaultFiles();
    app.UseStaticFiles();
}

{% endhighlight %}
{% endtabs %}

Restart Visual Studio for the red squiggly lines below "**UseDefaultFiles**" and "**UseStaticFiles**" to disappear.

3.Open the Source Explorer and right click on the application name. Then, select “**Add New Item**” menu item to open the “**Add New Item**” window. 

4.Select “**ASP.NET Core**” on the left side Tree View and select “**JavaScript File**” in the “**Add New Item**” window. It will include a js file in the root folder of the ASP.NET Core web application. Rename the js file as “**gulpfile.js**”.

![Add gulpjs file](images/add-gulpjs.png)

5.Copy the following code snippet and paste it in **gulpfile.js** for automatically copying the script and styles from “**node_modules**” to “**wwwroot**” while building the web application.

{% tabs %}
{% highlight c# tabtitle="gulpfile.js" %}

/// <binding BeforeBuild='copy-client-resource'/>
// nodejs requiring statement for importing and using the package in this js file
var gulp = require('gulp');
var glob = require('glob');
// gulp task for copying file form “node_modules” to “wwwroot” directory
gulp.task("copy-client-resource", function (done) {
    let packagePath = './node_modules/@syncfusion/';
    let destCommonPath = 'wwwroot/syncfusion'
    let installedPackages = glob.sync(`${packagePath}*`);
    for (let insPackage of installedPackages) {
        let packagename = insPackage.replace(packagePath, '');
        gulp.src(`${insPackage}/dist/global/**/*`)
            .pipe(gulp.dest(`${destCommonPath}/${packagename}/`));
        gulp.src(`${insPackage}/styles/**/*.css`)
            .pipe(gulp.dest(`${destCommonPath}/${packagename}/styles/`));
    }
    done();
});

{% endhighlight %}
{% endtabs %}

6.Build the ASP.NET Core web application and notice that a new folder named “**Syncfusion**” is created in “**wwwroot**” folder.

![Copied to wwwroot](images/copied-to-wwwroot.png)

7.Add the client-side resource in the `<head>` element of the `~/Views/Shared/_Layout.cshtml`. Here, scripts and styles of Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Calendar has been loaded for example.  

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="~/syncfusion/ej2-calendars/styles/calendar/material.css" />
    <link rel="stylesheet" href="~/syncfusion/ej2-base/styles/material.css" />
    <link rel="stylesheet" href="~/syncfusion/ej2-buttons/styles/button/material.css" />
    <!-- Syncfusion ASP.NET Core controls scripts -->
    <script src="~/syncfusion/ej2-base/ej2-base.min.js"></script>
    <script src="~/syncfusion/ej2-calendars/ej2-calendars.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## CDN Reference

Syncfusion<sup style="font-size:70%">&reg;</sup> hosts every ASP.NET Core control package on CDN, from which scripts and stylesheets can be loaded. For detailed CDN URLs, individual control CDN references, and CDN fallback configuration, refer to the [CDN Reference](./script-reference-cdn) page.

## Custom Resource Generator

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core provides an option to generate a control's scripts using the [Custom Resource Generator](https://crg.syncfusion.com/) (CRG) tool. Refer [here](./custom-resource-generator) for details.

## See also

* [CDN Reference](./script-reference-cdn)
* [CDN Fallback](./cdn-fallback)
* [Adding Nonce to Script tag in ASP.NET Core](./security-aspects#adding-nonce-to-script-tag-in-aspnetcore)