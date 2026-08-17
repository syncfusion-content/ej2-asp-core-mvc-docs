---
layout: post
title: How to disable DatePicker in ##Platform_Name## DatePicker | Syncfusion
description: Disable Syncfusion ##Platform_Name## DatePicker by setting the enabled property to false so the popup cannot be opened or used.
platform: ej2-asp-core-mvc
control: Disabled The Datepicker Component
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to disable DatePicker in ##Platform_Name## DatePicker

To disable the DatePicker, use its [enable](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Enabled) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/how-to/disable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disable.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/how-to/disable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disable.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

