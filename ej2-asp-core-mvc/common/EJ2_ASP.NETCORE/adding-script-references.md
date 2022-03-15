---
layout: post
title: Adding script references in ##Platform_Name## control
description: Learn here all about adding script references in Syncfusion ##Platform_Name## control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Reference Scripts in ASP.NET Core Application

This section provides information about reference scripts from CDN and Custom resource generator (CRG) for Syncfusion ASP.NET Core controls.

## CDN Reference

Syncfusion hosts every ASP.NET Core control as a separate node package in CDN, from which scripts and style sheets of the individual package can be loaded. It also hosts a single node package with all ASP.NET Core controls on it, from which scripts and style sheets of all controls can be loaded as single script and style file.

Here, the generic syntax of the Syncfusion ASP.NET Core CDN URL for the both Individual ASP.NET Core control package and Complete ASP.NET Core controls package has been explained.

### CDN Reference for all controls

The primary goal of all the ASP.NET Core controls package is to help the novice to get started with Syncfusion ASP.NET Core control by referring the single line for script and styles without bothering about the dependency graph of the ASP.NET Core controls.

**Syntax:**

| controls | CDN Reference |
| --- | --- |
| Scripts reference for all controls| https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js |
| Styles reference for all controls | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/{THEME-NAME}.css |

> Syncfusion will never recommend all controls CDN for real-time projects. Because, the size of this CDN impacts website/app loading time since this package includes all the Syncfusion ASP.NET Core controls.

Add the EJ2 CDN client-side resources to the `<head>` element of the `~/Views/Shared/_Layout.cshtml` layout page.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion Essential JS 2 Styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/material.css" />

    <!-- Syncfusion Essential JS 2 Scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

### Individual control CDN Reference

The primary goal of individual control CDN is to optimize the loading time and memory of the website/app in the production stage. The order of individual control package loading should be in line with its dependency graph. The CDN of the Dependency Packages should be included manually before the intended individual control package CDN.

**Syntax:**

| controls | CDN Reference |
| --- | --- |
| Scripts reference for individual control| https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/{PACKAGE-NAME}/dist/global/{PACKAGE-NAME}.min.js |
| Styles reference for individual control | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/{PACKAGE-NAME}/styles/{THEME-NAME}.css |

Add the CDN client-side resources in the `<head>` element of the `~/Views/Shared/_Layout.cshtml` layout page.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion Essential JS 2 Styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/styles/material.css" />
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/styles/material.css" />
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/styles/material.css" />
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/styles/material.css" />
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2{{ site.ej2version }}//ej2-lists/styles/material.css" />

    <!-- Syncfusion Essential JS 2 Scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-base/dist/global/ej2-base.min.js"></script>
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-buttons/dist/global/ej2-buttons.min.js"></script>
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-popups/dist/global/ej2-popups.min.js"></script>
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-lists/dist/global/ej2-lists.min.js"></script>
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/ej2-calendars/dist/global/ej2-calendars.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

In addition to above, Syncfusion ASP.NET Core controls provides latest scripts and styles in CDN without versioning. You can use this in development environment if you want to always use the latest version of scripts and styles. It is not recommended to use this in production environment.

| controls | CDN Reference |
| --- | --- |
| Scripts reference for all controls| https://cdn.syncfusion.com/ej2/dist/ej2.min.js |
| Styles reference for all controls | https://cdn.syncfusion.com/ej2/{THEME-NAME}.css |

## Node Package Manager (NPM)

A package in Node.js consists of a set of files needed for a JavaScript module which can be included in any web application. NPM is the popular package manager for both public and private packages.

### Syncfusion NPM packages

Scripts and style sheets of Syncfusion ASP.NET Core controls can be included in an ASP.NET Core web application using NPM packages, since Syncfusion publishes its ASP.NET Core controls as the scoped package in NPM.

#### Installing NPM packages in ASP.NET Core Web Application

1.Open the Source Explorer and right click the application name. Then, select “**Add New Item**” menu item to open the “**Add New Item**” window. 

![Add New Item Window](images/add-new-item.png)

2.Select “**Web**” on the left side Tree View and select “**npm configuration File**” in “**Add New Item**” window which will include and configure “**package.json**” file in root folder of the ASP.NET Core web application. 

![Adding package.json](images/add-package-json.png)

3.Open the Source Explorer and right click on the application name. Then, select “**Open Folder in File Explorer**”. 

4.Open the Command Prompt for this location and install the required Syncfusion packages using “**npm install @syncfusion/{PACKAGE_NAME} --save**”

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}

npm install @syncfusion/ej2-calendars --save

{% endhighlight %}
{% endtabs %}

5.Installed packages with all its dependencies can be found under the  “**node_modules**” folder as shown in the following image.

![Installed Syncfusion Packages](images/installed-syncfusion-package.png)

#### From Installed Packages

Scripts and style sheets of Syncfusion ASP.NET Core controls from locally-installed packages can be included in an ASP.NET Core web application using the following two methods.

>Files in the **wwwroot** folder can be accessed only in client-side, hence Syncfusion scripts and style sheets should be copied from **node_modules** to **wwwroot**.

By using either one of the following methods, Client-Side Resource can be loaded in ASP.NET Core web application:

1. Copying scripts and styles using gulp
2. Generating scripts and styles using CRG (Custom Resource Generator)

#### Copying by Gulp

Install required Syncfusion ASP.NET Core control packages as mentioned in “[**Installing NPM Packages in ASP.NET Core Web Application**](#installing-npm-packages-in-aspnet-core-web-application)”. 

1.In addition to Syncfusion ASP.NET Core packages, install gulp and glob packages using below commands.

>Gulp Installation - **npm install gulp --save**

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}

npm install gulp@latest --save

{% endhighlight %}
{% endtabs %}

>Glob Installation - **npm install glob --save**

{% tabs %}
{% highlight c# tabtitle=".NET CLI" %}

npm install glob@latest --save

{% endhighlight %}
{% endtabs %}

2.To set up the server, open Dependencies -> Manage NuGet Packages -> Browse. Then, search and install "**Microsoft.AspNetCore.StaticFiles**" and "**Microsoft.TypeScript.MSBuild**" packages.

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

7.Add the client-side resource in the `<head>` element of the `~/Views/Shared/_Layout.cshtml`. Here, scripts and styles of Syncfusion ASP.NET Core Calendar has been loaded for example.  

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    <!-- Syncfusion Essential JS 2 Styles -->
    <link rel="stylesheet" href="~/syncfusion/ej2-calendars/styles/calendar/material.css" />
    <link rel="stylesheet" href="~/syncfusion/ej2-base/styles/material.css" />
    <link rel="stylesheet" href="~/syncfusion/ej2-buttons/styles/button/material.css" />
    <link rel="stylesheet" href="~/syncfusion/ej2-popups/styles/popup/material.css" />
    <link rel="stylesheet" href="~/syncfusion/ej2-lists/styles/list-view/material.css" />
    <!-- Syncfusion Essential JS 2 Scripts -->
    <script src="~/syncfusion/ej2-base/ej2-base.min.js"></script>
    <script src="~/syncfusion/ej2-buttons/ej2-buttons.min.js"></script>
    <script src="~/syncfusion/ej2-popups/ej2-popups.min.js"></script>
    <script src="~/syncfusion/ej2-lists/ej2-lists.min.js"></script>
    <script src="~/syncfusion/ej2-calendars/ej2-calendars.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Custom Resource Generator

The Syncfusion ASP.NET Core provides an option to generate a control's scripts using the [Custom Resource Generator](https://crg.syncfusion.com/) (CRG) tool for the ASP.NET Core Controls. To generate the control-wise scripts externally using CRG, refer [here](./custom-resource-generator).
