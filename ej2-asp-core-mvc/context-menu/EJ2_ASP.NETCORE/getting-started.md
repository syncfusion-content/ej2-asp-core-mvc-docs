---
layout: post
title: Getting Started with ##Platform_Name## Context Menu Component
description: Checkout and learn about getting started with ##Platform_Name## Context Menu component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---

# Getting Started

This section briefly explains about how to create a simple ContextMenu in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add ContextMenu to the project

Add the HTML `ejs-contextmenu` tag with `id` attribute as `contextmenu` to your **Index.cshtml** file and also add target element on which the ContextMenu has to be opened.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Demo.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Demo.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



`ViewBag.menuItems` variable is used for bounding the `items` property in view page.

## Bind dataSource

Populate the menu items in `ContextMenu` by using the `items` property. Here, the JSON values are passed to the
ContextMenu component are generated in `default.cs` and assigned to `ViewBag` variable.

```cs
public IActionResult Index()
        {
            //define the array of JSON
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "Cut"
            });
            menuItems.Add(new
            {
                text = "Copy"
            });
            menuItems.Add(new
            {
                text = "Paste"
            });
            ViewBag.menuItems = menuItems;
            return View();
        }

```

Output be like the below.

![ContextMenu Sample](./images/context-menu.PNG)

## Run the application

After successful compilation of your application, simply press `F5` to run the application.

The following example shows a basic ContextMenu.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/context-menu/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/context-menu/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Rendering items with Separator

The Separators are the horizontal lines that are used to separate the menu items. You cannot select the separators. You
can enable separators to group the menu items using the [`separator`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem~Separator.html)
property. Cut, Copy, and Paste menu items are grouped using the `separator` property in the following sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/separator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/context-menu/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/separator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/context-menu/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The [`separator`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem~Separator.html) property should not be given along with the other fields in the [`MenuItem`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem.html).
