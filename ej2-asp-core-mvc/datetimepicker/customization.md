---
layout: post
title: Customization in ##Platform_Name## Datetimepicker Component
description: Learn here all about Customization in Syncfusion ##Platform_Name## Datetimepicker component and more.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customization

The DateTimePicker is available for UI customization that can be achieved by using available properties and events in the component.

## Day and Time Cell format

The DateTimePicker is available for UI customization based on your application requirements.
It can be achieved by using [renderDayCell](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_RenderDayCell)
event that provides an option to customize each day cell on rendering.

The following example disables the weekends of every month by using `renderDayCell` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/daytimecellformat/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Daytimecellformat.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/daytimecellformat/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Daytimecellformat.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## See Also

* [How to disable the DateTimePicker control](./how-to/disable-the-datetimepicker-component)
* [How to customize the DateTimePicker day header](./how-to/customize-the-datetimepicker-day-header)