---
layout: post
title: How to set placeholder in ##Platform_Name## DatePicker | Syncfusion
description: Display a short hint inside the Syncfusion ##Platform_Name## DatePicker input element by setting the placeholder property.
platform: ej2-asp-core-mvc
control: Set The Placeholder
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to set placeholder in ##Platform_Name## DatePicker

The following example demonstrates how to set `placholder` in the DatePicker control.

Using [placeholder](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Placeholder) you can display a short hint in the input element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/how-to/placeholder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Placeholder.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/how-to/placeholder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Placeholder.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

