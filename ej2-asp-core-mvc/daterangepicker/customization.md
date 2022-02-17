---
layout: post
title: Customization in ##Platform_Name## Daterangepicker Component
description: Learn here all about Customization in Syncfusion ##Platform_Name## Daterangepicker component and more.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customization

The DateRangePicker is available for UI customization that can be achieved by using available properties and events in the control.

## Day cell format

The DateRangePicker is available for UI customization based on your application requirements. It can be achieved by using [renderDayCell](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateRangePicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_RenderDayCell)
 event that provides an option to customize each day cell on rendering.

The following example disables the weekends of every month by using `renderDayCell` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/customization/daycell/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Daycell.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/customization/daycell/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Daycell.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## First day of week

Start day in a week will differ based on the culture, but you can also customize this based on the application needs.
For this, you have to make use of [firstDayOfWeek](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateRangePicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_FirstDayOfWeek) property.
By default, first day of a week in en-US is Sunday. In the following example it is customized to Monday with the help of this property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/customization/firstday/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Firstday.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/customization/firstday/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Firstday.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## See Also

* [How to customize DateRangePicker using cssClass](./how-to/customization-using-cssclass)
* [How to disable DateRangePicker control](./how-to/disable-the-daterangepicker-component)
* [How to customize the DateRangePicker day header](./how-to/customize-the-daterangepicker-day-header)