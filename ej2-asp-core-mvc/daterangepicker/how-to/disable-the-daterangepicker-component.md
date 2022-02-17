---
layout: post
title: Disable The Daterangepicker Component in ##Platform_Name## Daterangepicker Component
description: Learn here all about Disable The Daterangepicker Component in Syncfusion ##Platform_Name## Daterangepicker component and more.
platform: ej2-asp-core-mvc
control: Disable The Daterangepicker Component
publishingplatform: ##Platform_Name##
documentation: ug
---


# Disable the control

DateRangePicker can be inactivated on a page, by setting [enabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateRangePicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_Enabled) value as false that will disable the control completely from all the user interactions including in the form post. The following example demonstrates the disabled control.

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

