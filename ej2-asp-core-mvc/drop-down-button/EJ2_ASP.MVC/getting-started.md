---
layout: post
title: Getting Started with ##Platform_Name## Drop Down Button Component
description: Checkout and learn about getting started with ##Platform_Name## Drop Down Button component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to include a simple DropDownButton in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

## Add DropDownButton to the project

We are going to render `DropDownButton` component in **Index.cshtml** page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Demo.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Demo.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



`ViewBag.items` variable is used for bounding the `items` property in view page.

## Bind dataSource

Populate the action items in `SplitButton` by using the `items` property. Here, the JSON values are passed to the
DropDownButton component are generated in `default.cs` and assigned to `ViewBag` variable.

```cs
public ActionResult Index()
{
    List<object> items = new List<object>();
    items.Add(new
    {
        text = "Cut"
    });
    items.Add(new
    {
        text = "Copy"
    });
    items.Add(new
    {
        text = "Paste"
    });
    ViewBag.items = items;
    return View();
}

```

Output be like the below.

![DropDownButton Sample](./images/drop-down-button.PNG)

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

 The following example shows a basic DropDownButton.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/dropdownbutton/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/dropdownbutton/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [DropDownButton with icons](./icons#dropdownbutton-icons)
* [How to hide dropdown arrow](./how-to/hide-dropdown-arrow)