---
layout: post
title: Getting Started with ##Platform_Name## Calendar Component
description: Checkout and learn about getting started with ##Platform_Name## Calendar component of Syncfusion, and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains how to include a simple Calendar control in your ASP.NET MVC application. You can refer to [ASP.NET MVC Getting Started documentation](../../getting-started/) page for system requirements, and configure common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed, you also have to include a license key in your projects. Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#aspnet-mvc) to know about registering Syncfusion license key in your ASP.NET MVC application to use our controls.

## Initialize Calendar control to the Application

Calendar control can be rendered by using the `EJS().Calendar()` tag helper in ASP.NET MVC application. Add the below simple code to your `index.cshtml` page which is available within the `Views/Home` folder, to initialize the Calendar.

The following example shows a basic Calendar control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/getting-started/getting-started/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Getting-started.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/getting-started/getting-started/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Getting-started.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



> Running the above code will display the basic Calendar on the browser.

## Setting the value within min and max dates

After rendering a simple Calendar control by following the above steps, configure the Calendar to set a value within a specific range using its value, min, and max properties.

Here the Calendar allows you to select a date within the range from 5th to 27th of this month.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/calendar/getting-started/daterange/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Daterange.cs" %}
{% include code-snippet/calendar/getting-started/daterange/daterange.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/calendar/getting-started/daterange/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Daterange.cs" %}
{% include code-snippet/calendar/getting-started/daterange/daterange.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Select multiple dates in the Calendar](./multi-select)
* [Render Calendar with specific culture](./globalization)
* [How to change the initial view of the Calendar](./calendar-views)
* [Render Calendar with week numbers](./how-to/render-the-calendar-with-week-numbers)
* [Show other month dates](./how-to/show-dates-of-other-months)