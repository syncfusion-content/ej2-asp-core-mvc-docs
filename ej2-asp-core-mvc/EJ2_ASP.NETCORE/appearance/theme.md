---
layout: post
title: Themes in Syncfusion ##Platform_Name## Controls
description: Learn here all about built-in themes and how to change it dynamically in Syncfusion ##Platform_Name## controls.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Syncfusion ASP.NET Core Themes

The following list of themes are included in the Syncfusion ASP.NET Core controls library.

|Theme |Style Sheet Name|
|--------|--------|
|Bootstrap 5 | bootstrap5.css |
|Bootstrap 5 Dark | bootstrap5-dark.css |
|Bootstrap 4 | bootstrap4.css |
|Bootstrap 3 | bootstrap.css |
|Bootstrap 3 Dark | bootstrap-dark.css |
|Google’s Material | material.css |
|Google’s Material-Dark | material-dark.css |
|Tailwind CSS | tailwind.css |
|Tailwind CSS Dark | tailwind-dark.css |
|Fluent | fluent.css |
|Fluent Dark | fluent-dark.css |
|Microsoft Office Fabric | fabric.css |
|Microsoft Office Fabric Dark | fabric-dark.css |
|High Contrast | highcontrast.css |

The Syncfusion ASP.NET Core Bootstrap Theme is designed based on Bootstrap v3, whereas the Bootstrap4 theme is designed based on Bootstrap v4. Syncfusion ASP.NET Core themes provide support for the Fusion Theme that can only be downloaded from [ThemeStudio](https://ej2.syncfusion.com/themestudio/?theme=fusion).

## Reference themes in ASP.NET Core application

Syncfusion ASP.NET Core themes can be used in your ASP.NET Core application by referencing the style sheet. Refer the ASP.NET Core Styles Sheet inside the `<head>` element of `~/Pages/Shared/_Layout.cshtml` layout page.

Using the below approaches the themes can be referenced in the ASP.NET Core application,

1. [CDN](#cdn-reference) - Used to reference complete css via static web assets.
2. [CRG](https://ej2.syncfusion.com/aspnetcore/documentation/common/custom-resource-generator/) - Used to generate resources only for the selected (used) components.
3. [Theme Studio](https://ej2.syncfusion.com/aspnetcore/documentation/appearance/theme-studio/) - Used to customize and generate themes only for the selected (used) components.
4. [NPM Packages](#npm-packages) - Used to customize the existing themes and bundle stylesheet's in an application.
5. [LibMan](#libman) - Used to downloads popular libraries and frameworks from a file system or a content delivery network (CDN) in an application.

## CDN Reference

Instead of using a local resource on your server, you can use a cloud CDN to refer the theme style sheets. CDN Stands for "Content Delivery Network". A CDN is a group of servers distributed in different locations. While CDN are often used to host websites, they are commonly used to provide other types of downloadable data as well. Examples include software programs, images, videos, and streaming media.

Syncfusion ASP.NET Core Themes are available in the CDN. Make sure that the version in the URLs matches the version of the Syncfusion Essential JS 2 ASP.NET Core Package you are using.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    <link href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/bootstrap5.css" rel="stylesheet"/>
</head>

{% endhighlight %}
{% endtabs %}

| Theme Name | CDN Reference |
|--- | --- |
| Bootstrap 5 | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/bootstrap5.css |
| Bootstrap 5 Dark| https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/bootstrap5-dark.css |
| Bootstrap 4 | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/bootstrap4.css |
| Bootstrap 3 | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/bootstrap.css |
| Bootstrap 3 Dark| https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/bootstrap-dark.css |
| Google’s Material | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/material.css |
| Google’s Material Dark | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/material-dark.css |
| Tailwind CSS | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/tailwind.css |
| Tailwind Dark CSS | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/tailwind-dark.css |
| Fluent | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css |
| Fluent Dark | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent-dark.css |
| Microsoft Office Fabric  | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fabric.css |
| Microsoft Office Fabric Dark | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fabric-dark.css |
| High Contrast  | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/highcontrast.css |

## NPM Packages

NPM is a node package manager. It is basically used for managing dependencies of various server-side dependencies. You can manage server-side dependencies manually. It is a command-line program for dealing with said repository that aids in package installation, version management, and dependency management. It is an online repository for the publishing of open-source `Node.js` projects.

You can add the theme for the ASP.NET Core applications through **npm packages** using the **SCSS** files by following the below process.

* Install Web Compiler to use `SCSS` files in ASP.NET Core applications.

* To install Web Compiler, open Visual Studio and click the **Manage Extensions** in the toolbar.

![Themes-npm-package-extension](images/themes-npm-package-extension.png)
 
![Themes-npm-package-web-compiler](images/themes-npm-package-web-compiler.png)

* Open Command Prompt from the application root directory and run the following command to install the Syncfusion `node_modules` in this application.

{% tabs %}
{% highlight c# tabtitle="CMD" %}

npm install @syncfusion/ej2

{% endhighlight %}
{% endtabs %}

* Create a `custom.scss` file inside `~/wwwroot/css` location and provide the variables to override as shown below.

{% tabs %}
{% highlight c# tabtitle="~/custom.scss" %}

  $primary: blue !default;
@import 'ej2/fabric.scss';

{% endhighlight %}
{% endtabs %}

* Right-click the `SCSS` file and click the Web Compiler to compile the file.

![Themes-npm-packages-compile](images/themes-npm-packages-compile.png) 

* The `compilerconfig.json` file is created. Then, provide the location of the compiled CSS file and include a path as shown in the following code snippet.

{% tabs %}
{% highlight c# tabtitle="compilerconfig.json" %}

[
  {
    "outputFile": "wwwroot/css/custom.css",
    "inputFile": "wwwroot/css/custom.scss",
    "useNodeSass": true,
    "options": {
      "includePath": "node_modules/@syncfusion"
    }
  }
]

{% endhighlight %}
{% endtabs %}

* The SCSS file has been compiled to the CSS file. Then, add this CSS file to the `<head>` element of the **~/Pages/Shared/_Layout.cshtml** page.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link rel="stylesheet" href="~/css/custom.css" />
</head>

{% endhighlight %}
{% endtabs %}

* Run the application and see the fabric themes from installed npm packages were applied.

> [View sample in GitHub](https://github.com/SyncfusionExamples/asp-net-core-css-customization-using-webcompiler-)

## LibMan

Library Manager ([LibMan](https://docs.microsoft.com/en-us/aspnet/core/client-side/libman/libman-vs?view=aspnetcore-6.0)) is a client-side library acquisition tool that is simple to use. LibMan is a program that downloads popular libraries and frameworks from a file system or a content delivery network (CDN).

LibMan offers the following advantages,

1. Only the library files you need are downloaded.
2. Additional tooling, such as Node.js, npm, and WebPack, isn't necessary to acquire a subset of files in a library.
3. Files can be placed in a specific location without resorting to build tasks or manual file copying.

### Client-Side Library dialog

1.Right-click the project folder where the files should be added. Select **Add** -> **Client-Side Library**. Then Add Client-Side Library dialog appears like below.

![Client side library dialog](images/theme-client-side.png)

2.Select the **unpkg** in the provider dropdown to get the Syncfusion control themes.

![Select unpkg provider](images/client-library-unpkg.png)

3.you can refer the combined control styles by using `@syncfusion/ej2@{{ site.ej2version }}` in the library textbox.

![Specify Syncfusion library](images/library-unpkg.png)

4.you can able to choose specific files or include all library files like below.

For example, Choose specific files and the bootstrap5 theme is selected in the dialog.

![Choose themes](images/library-unpkg-theme.png)

5.By using the target location textbox, you can specify the location of where files will be stored in the application.

For example, Modified the default location `wwwroot/lib/syncfusion/ej2/` to  `wwwroot/themes/syncfusion/ej2/`.

![Modified the target location](images/client-side-target-unpkg.png)

6.Click the install button then `libman.json` file is added to the root application with the following content.

{% tabs %}
{% highlight cshtml tabtitle="libman.json" %}

{
  "version": "1.0",
  "defaultProvider": "unpkg",
  "libraries": [
    {
      "library": "@syncfusion/ej2@{{ site.ej2version }}",
      "destination": "wwwroot/themes/syncfusion/ej2/",
      "files": [
        "bootstrap5.css"
      ]
    }
  ]
}

{% endhighlight %}
{% endtabs %}

> If you use individual control styles, you should install their dependent controls styles.

7.you can refer to the theme sheet which was downloaded from the client-side library in the `<head>` element of the **~/Pages/Shared/_Layout.cshtml** file.

{% tabs %}
{% highlight cshtml tabtitle="~/_Layout.cshtml" %}

<head>
  ...
  <link href="~/themes/syncfusion/ej2/bootstrap5.css" rel="stylesheet" />
</head>

{% endhighlight %}
{% endtabs %}

8.Run the application and see the bootstrap5 themes downloaded from LibMan were applied.

> [View sample in GitHub](https://github.com/SyncfusionExamples/asp-net-core-libman)

## Change theme dynamically

In the ASP.NET Core application, the application theme can be changed dynamically by changing its style sheet reference in code.

1. Modify the **~/Pages/Shared/_Layout.cshtml** page with the below code to implement a theme change dynamically using the dropdown by its id value in javascript function in the application.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

@model IndexModel
<!DOCTYPE html>
<html lang="en">
<head>
    ...
    <!-- Syncfusion ASP.NET Core controls styles -->
    <link id="cssfile" rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/bootstrap5.css" />
</head>
<body>
<header>
    ...
    <div>
        <ejs-dropdownlist id="theme" dataSource="@Model.Themes" index="1" change="onThemeChange" placeholder="Themes" floatLabelType="Always">
        <e-dropdownlist-fields text="Text" value="ID"></e-dropdownlist-fields>
        </ejs-dropdownlist>
    </div>
</header>

<script type="text/javascript">
    function onThemeChange(e) {
        document.getElementsByTagName('body')[0].style.display = 'none';
        var themeName = e.value;
        let synclink = document.getElementById('cssfile');
        synclink.href = 'https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/' + themeName + '.css';
        setTimeout(function () { document.getElementsByTagName('body')[0].style.display = 'block'; }, 200);
    }
</script>
{% endhighlight %}
{% endtabs %}

2. Add the following code for dropdown data on the **~/Pages/Index.cshtml.cs** model page.

{% tabs %}
{% highlight c# tabtitle="~/Index.cshtml.cs" %}

public List<ThemeDetails> Themes = new List<ThemeDetails>() {
    new ThemeDetails(){ ID = "material", Text = "Material" },
    new ThemeDetails(){ ID = "bootstrap", Text = "Bootstrap" },
    new ThemeDetails(){ ID = "fabric", Text = "Fabric" },
    new ThemeDetails(){ ID = "bootstrap4", Text = "Bootstrap 4" },
    new ThemeDetails(){ ID = "tailwind", Text = "TailWind"},
    new ThemeDetails(){ ID = "tailwind-dark", Text = "TailWind Dark" },
    new ThemeDetails(){ ID = "material-dark", Text = "Material Dark" },
    new ThemeDetails(){ ID = "bootstrap-dark", Text = "Bootstrap Dark" },
    new ThemeDetails(){ ID = "fabric-dark", Text = "Fabric Dark" },
    new ThemeDetails(){ ID = "highcontrast", Text = "High Contrast" }
};

public class ThemeDetails
{
    public string ID { get; set; }
    public string Text { get; set; }
}

{% endhighlight %}
{% endtabs %}

![Change theme dynamically](images/dynamic-theme-switching.gif)

> [View sample in GitHub](https://github.com/SyncfusionExamples/asp-net-core-theme-switcher)
