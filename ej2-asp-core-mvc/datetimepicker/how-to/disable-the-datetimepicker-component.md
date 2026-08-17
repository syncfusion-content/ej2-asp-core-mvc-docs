---
layout: post
title: How to disable DateTimePicker in ##Platform_Name## DateTimePicker | Syncfusion
description: Disable Syncfusion ##Platform_Name## DateTimePicker by setting the enabled property to false so users cannot interact with the input.
platform: ej2-asp-core-mvc
control: Disable The Datetimepicker Component
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to disable DateTimePicker in ##Platform_Name## DateTimePicker

To disable the DateTimePicker, use its [enable](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateTimePicker.html#Syncfusion_EJ2_Calendars_DateTimePicker_Enabled) property to `false`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/disable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disable.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/disable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disable.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

