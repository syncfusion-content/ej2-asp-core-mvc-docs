---
layout: post
title: Getting Started with ##Platform_Name## Datepicker Component
description: Checkout and learn about getting started with ##Platform_Name## Datepicker component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started Mvc
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains how to include simple DatePicker control in your ASP.NET MVC application. You can refer to [ASP.NET MVC Getting Started documentation](../../getting-started/) page for system requirements, and configure common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#aspnet-mvc) to know about registering Syncfusion license key in your ASP.NET MVC application to use our controls.

## Initialize DatePicker control to the Application

DatePicker control can be rendered by using the `EJS().DatePicker()` tag helper in ASP.NET MVC application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the DatePicker.

The following example shows a basic DatePicker control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/getting-started/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Getting-started.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/getting-started/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Getting-started.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



> Running the above code will display the basic DatePicker on the browser.

## Setting the value within min and max dates

To restrict the selection of date within a specified range, use the min and max properties.

The below example demonstrates the DatePicker to select a date within a range from 5 to 27 in a current month.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/getting-started/daterange/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Daterange.cs" %}
{% include code-snippet/datepicker/getting-started/daterange/daterange.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/getting-started/daterange/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Daterange.cs" %}
{% include code-snippet/datepicker/getting-started/daterange/daterange.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Change the format of selected date](./date-format)
* [Render DatePicker with specific culture](./globalization)
* [How to change the initial view of the DatePicker](./view)
* [How to achieve validation with DatePicker](./how-to/client-side-validation)
