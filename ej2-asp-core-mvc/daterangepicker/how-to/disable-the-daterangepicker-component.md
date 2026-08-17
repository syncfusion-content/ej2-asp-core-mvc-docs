---
layout: post
title: How to disable DateRangePicker in ##Platform_Name## | Syncfusion
description: Disable Syncfusion ##Platform_Name## DateRangePicker by setting the enabled property to false so all user interactions and form posts are blocked.
platform: ej2-asp-core-mvc
control: Disable The Daterangepicker Component
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to disable DateRangePicker in ##Platform_Name##

DateRangePicker can be inactivated on a page, by setting [enabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateRangePicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_Enabled) value as false that will disable the control completely from all the user interactions including in the form post.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/how-to/disable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disable.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/how-to/disable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disable.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

