---
layout: post
title: Themes in ##Platform_Name## Controls
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
|TailwindDark CSS | tailwind-dark.css |
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

## CDN Reference

Instead of using a local resource on your server, you can use a cloud CDN to reference the theme style sheets. CDN Stands for "Content Delivery Network". A CDN is a group of servers distributed in different locations. While CDN are often used to host websites, they are commonly used to provide other types of downloadable data as well. Examples include software programs, images, videos, and streaming media.

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
| Microsoft Office Fabric  | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fabric.css |
| Microsoft Office Fabric Dark | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fabric-dark.css |
| High Contrast  | https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/highcontrast.css |

## Change theme dynamically

In the ASP.NET Core application, the application theme can be changed dynamically by changing its style sheet reference in code.

1.Modify the **~/Pages/Shared/_Layout.cshtml** page with the below code to implement a theme change dynamically using the dropdown by its id value in javascript function in the application.

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

2.Add the following code for dropdown data on the **~/Pages/Index.cshtml.cs** model page.

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

> [View sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/ThemeSwitch)
