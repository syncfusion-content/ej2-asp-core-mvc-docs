---
layout: post
title: Size Modes in the ##Platform_Name## | Syncfusion
description: Learn here all about size modes in Syncfusion ##Platform_Name## and how to apply it to application or specific control.
platform: ej2-asp-core-mvc
control: common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Size Mode for ASP.NET Core Controls

Syncfusion ASP.NET Core controls support touch (bigger theme) and normal size modes. The following topics explains how to enable the same in your application.

## Size mode for application

You can enable touch mode (bigger theme) for an application by adding `.e-bigger` class in the `~/wwwroot/css/site.css` file and assign to the `body` element in the `~/Pages/Shared/_Layout.cshtml` page.

{% tabs %}
{% highlight c# tabtitle="~/site.css" %}

.e-bigger {
    font-size: x-large;
}

{% endhighlight %}
{% endtabs %}

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body class="e-bigger">...</body>

{% endhighlight %}
{% endtabs %}

## Size mode for a Control

You can enable touch mode (bigger theme) for ASP.NET Core controls by adding `.e-bigger` class and assign to the `div` which contains the control.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<div class="e-bigger">
    <ejs-calendar id="calendar"></ejs-calendar>
</div>

<div class="e-bigger">
    <ejs-button id="element" content="Button"></ejs-button>
</div>

<div class="e-bigger">
    <ejs-checkbox id="default" label="Checked" checked="true"></ejs-checkbox>
</div>

<style>
    .e-bigger {
     font-size: x-large;
    }
</style>

{% endhighlight %}
{% endtabs %}

## Change size mode for application at runtime

You can change the size mode of an application between touch and normal (mouse) mode at runtime by adding and removing the `.e-bigger` class.

Follow the below steps to change the size mode for an application at runtime.

1. Add the `e-bigger` CSS class in the `~/wwwroot/css/site.css` file.

{% tabs %}
{% highlight c# tabtitle="~/site.css" %}

.e-bigger {
    font-size: x-large;
}

{% endhighlight %}
{% endtabs %}

2. Refer to the following code for adding control and the JavaScript click action inside the script tag of `~/Pages/Index.cshtml` file to switch between touch and mouse mode using `e-bigger` class.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<p> Size-modes for application </p>
<p> This demo shows the Size-Modes applied for an entire application </p>

<button id="touch">Touch Mode</button>
<button id="mouse">Mouse Mode</button>

<div>
<ejs-calendar id="calendar"></ejs-calendar>
</div>

<div>
<ejs-button id="element" content="Button"></ejs-button>
</div>

<div>
    <ejs-checkbox id="default" label="Checked" checked="true"></ejs-checkbox>
</div>

<script>
    document.getElementById("touch").addEventListener("click", function () {
        document.body.classList.add('e-bigger');
    });

    document.getElementById("mouse").addEventListener("click", function () {
        document.body.classList.remove('e-bigger');
    });
</script>

{% endhighlight %}
{% endtabs %}

![change-size-mode-for-application-at-runtime](images/change-size-mode-for-application-at-runtime.gif)

> [View sample in GitHub](https://github.com/SyncfusionExamples/asp-net-core-size-modes/tree/main/SizeModeApp)

## Change size mode for a control at runtime

You can change the size mode of a control between touch and normal (mouse) mode at runtime by setting `.e-bigger` CSS class.  

Refer to the following code, in which the `e-bigger` class is added for enabling touch mode using the for loop in ASP.NET core application.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<p> Size-modes for application </p>
<p> This demo shows the Size-Modes applied for Syncfusion Control </p>

<button id="touch">Touch Mode</button>
<button id="mouse">Mouse Mode</button>

<div class="control">
    <ejs-calendar id="calendar"></ejs-calendar>
</div>

<div class="control">
    <ejs-button id="element" content="Button"></ejs-button>
</div>

<div class="control">
    <ejs-checkbox id="default" label="Checked" checked="true"></ejs-checkbox>
</div>

<style>
    .e-bigger {
        font-size: x-large;
    }
</style>

<script>
    document.getElementById("touch").addEventListener("click", function () {
        var controls = document.querySelectorAll('.control');
        for (var index = 0; index < controls.length; index++) {
            controls[index].classList.add('e-bigger');
        }
    });

    document.getElementById("mouse").addEventListener("click", function () {
        var controls = document.querySelectorAll('.control');
        for (var index = 0; index < controls.length; index++) {
            controls[index].classList.remove('e-bigger');
        }
    });
</script>

{% endhighlight %}
{% endtabs %}

![change-size-mode-for-a-control-at-runtime](images/change-size-mode-for-a-component-at-runtime.gif)

> [View sample in GitHub](https://github.com/SyncfusionExamples/asp-net-core-size-modes/tree/main/SizeModeControl)

## Change font size for all controls

You can change the font-size for all the controls by overriding the CSS for `e-control` class as follows. 

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<style>
    .e-control, .e-control [class^='e-'], .e-control [class*=' e-'] {

    font-size:1rem;

    }
</style>
{% endhighlight %}
{% endtabs %}

## See Also

Refer below topics to learn about responsiveness controls based on the available size in Syncfusion ASP.NET Core Controls.

* [Sidebar Responsiveness](https://ej2.syncfusion.com/aspnetcore/documentation/sidebar/auto-close/)
* [DataGrid Responsiveness](https://ej2.syncfusion.com/aspnetcore/documentation/grid/Columns/responsive-columns/)
* [TreeGrid Responsiveness](https://ej2.syncfusion.com/aspnetcore/documentation/tree-grid/scrolling/#responsive-with-parent-container)
* [Dashboard Layout Responsiveness](https://ej2.syncfusion.com/aspnetcore/documentation/dashboard-layout/adaptive-layout/)
* [Kanban Responsiveness](https://ej2.syncfusion.com/aspnetcore/documentation/kanban/responsive-mode/)
* [Toolbar Responsiveness](https://ej2.syncfusion.com/aspnetcore/documentation/toolbar/responsive-mode/)
* [Tab Responsiveness](https://ej2.syncfusion.com/aspnetcore/documentation/tab/responsive-modes/)
