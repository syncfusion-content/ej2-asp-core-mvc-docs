---
layout: post
title: Disabled The Datepicker Component in ASP.NET MVC Datepicker Component
description: Learn here all about how to disable the Datepicker component in Syncfusion ASP.NET MVC Datepicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Disabled The Datepicker Component
publishingplatform: ASP.NET MVC
documentation: ug
---


# Disabled State

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

