---
layout: post
title: Getting Started with ##Platform_Name## Datetimepicker Component
description: Checkout and learn about getting started with ##Platform_Name## Datetimepicker component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains about how to include a simple DateTimePicker in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../../getting-started/) page for introduction part of the system requirements and configure the common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#aspnet-mvc) to know about registering Syncfusion license key in your ASP.NET MVC application to use our controls.

## Initialize DateTimePicker control to the Application

DateTimePicker control can be rendered by using the `EJS().DateTimePicker()` tag helper in ASP.NET MVC application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the DateTimePicker.

The following example shows a basic DateTimePicker control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/getting-started/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Getting-started.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/getting-started/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Getting-started.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



> Running the above code will display the basic DateTimePicker on the browser.

## Setting the min and max

The minimum and maximum date time can be defined with the help of `min` and `max` property.
The following example demonstrates to set the `min` and `max` on initializing the
DateTimePicker.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/getting-started/daterange/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Daterange.cs" %}
{% include code-snippet/datetimepicker/getting-started/daterange/daterange.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/getting-started/daterange/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Daterange.cs" %}
{% include code-snippet/datetimepicker/getting-started/daterange/daterange.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Render DateTimePicker with specific culture](./globalization)
* [How to get and set value in DateTimePickerFor](./how-to/datetimepicker-for-mvc)