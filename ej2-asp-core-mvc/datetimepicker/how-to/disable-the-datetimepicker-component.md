---
layout: post
title: Disable The Datetimepicker Component in ##Platform_Name## Datetimepicker Component
description: Learn here all about disable the Datetimepicker component in Syncfusion ##Platform_Name## Datetimepicker component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Disable The Datetimepicker Component
publishingplatform: ##Platform_Name##
documentation: ug
---


# Disable the component

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

