---
layout: post
title: Header Bar in ##Platform_Name## Schedule Component | Syncfusion
description: Learn here all about Header Bar in Syncfusion ##Platform_Name## Schedule component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Header Bar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Header customization

The header part of Scheduler can be customized easily with the built-in options available.

## Show or Hide header bar

By default, the header bar holds the date and view navigation options, through which the user can switch between the dates and various views. This header bar can be hidden from the UI by setting `false` to the [`showHeaderBar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_ShowHeaderBar) property. It's default value is `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-bar/show-hide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-bar/show-hide/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-bar/show-hide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-bar/show-hide/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Display Show or Hide Header Bar in ASP.NET Core Scheduler](images/scheduler-hide-header.png)

## Customizing header bar

Apart from the default date navigation and view options available on the header bar, you can add custom items into the Scheduler header bar by making use of the `actionBegin` event. Here, an employee image is added to the header bar, clicking on which will open the popup showing that person's short profile information.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-bar/custom-header-bar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-bar/custom-header-bar/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-bar/custom-header-bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-bar/custom-header-bar/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Display Customizing Header Bar in ASP.NET Core Scheduler](images/scheduler-custom-header.png)

## How to display the view options within the header bar popup

By default, the header bar holds the view navigation options, through which the user can switch between various views. You can move this view options to the header bar popup by setting `true` to the [`enableAdaptiveUI`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_EnableAdaptiveUI) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-bar/adaptive-ui/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-bar/adaptive-ui/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-bar/adaptive-ui/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-bar/adaptive-ui/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Display Header Bar Popup in ASP.NET Core Scheduler](images/scheduler-header-popup.png)

N> Refer [here](./resources/#adaptive-ui-in-desktop) to know more about adaptive UI in resources scheduler.

## Date header customization

The Scheduler UI that displays the date text on all views are considered as the date header cells. You can customize the date header cells of Scheduler either using [`dateHeaderTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_DateHeaderTemplate) or [`renderCell`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_RenderCell) event.

### Using date header template

The [`dateHeaderTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_DateHeaderTemplate) option is used to customize the date header cells of day, week and work-week views.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-bar/custom-date-header/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-bar/custom-date-header/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-bar/custom-date-header/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-bar/custom-date-header/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Display Date Header Customization with Template in ASP.NET Core Scheduler](images/scheduler-custom-header-with-template.png)

### Using renderCell event

In month view, the date header template is not applicable and therefore the same customization can be added beside the date text in month cells by making use of the [`renderCell`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_RenderCell) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-bar/render-cell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-bar/render-cell/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-bar/render-cell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-bar/render-cell/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Display Date Header Customization with Render Cell in ASP.NET Core Scheduler](images/scheduler-custom-header-with-rendercell.png)

## Customizing the date range text

The [`DateRangeTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_DateRangeTemplate) option allows you to customize the text content of the date range displayed in the scheduler. By default, the date range text is determined by the scheduler view being used. However, you can use the [`DateRangeTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_DateRangeTemplate) option to override the default text and specify your own custom text to be displayed.

The [`DateRangeTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_DateRangeTemplate) property includes `startDate`, `endDate` and `currentView` options, you can customize the date range text using these available options.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-bar/custom-date-range/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-bar/custom-date-range/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-bar/custom-date-range/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-bar/custom-date-range/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Display Customizing the Date Range Text in ASP.NET Core Scheduler](images/scheduler-custom-date-range-text.png)

## Customizing header indent cells

It is possible to customize the header indent cells using the [`headerIndentTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Schedule.Schedule.html#Syncfusion_EJ2_Schedule_Schedule_HeaderIndentTemplate) option and change the look and appearance in both the vertical and timeline views. In vertical views, You can customize the header indent cells at the hierarchy level and you can customize the resource header left indent cell in timeline views using the template option.

**Example:** To customize the header left indent cell to display resources text, refer to the below code example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-bar/header-indent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-bar/header-indent/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/schedule/header-bar/header-indent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/schedule/header-bar/header-indent/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Display Customizing Header Indent Cells in ASP.NET Core Scheduler](images/scheduler-header-indent-cell.png)

N> You can refer to our [ASP.NET Core Scheduler](https://www.syncfusion.com/aspnet-core-ui-controls/scheduler) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET Core Scheduler example](https://ej2.syncfusion.com/aspnetcore/Schedule/Overview#/material) to knows how to present and manipulate data.
