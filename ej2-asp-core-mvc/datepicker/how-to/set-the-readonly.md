---
layout: post
title: How to set readonly in ##Platform_Name## DatePicker | Syncfusion
description: Make Syncfusion ##Platform_Name## DatePicker non-editable but still allow opening the popup by setting the readonly property to true.
platform: ej2-asp-core-mvc
control: Set The Readonly
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to set readonly in ##Platform_Name## DatePicker

The following example demonstrates how to set `readonly` in DatePicker control. You can achieve this by using [readonly](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Readonly) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/how-to/read/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Read.cs" %}
{% include code-snippet/datepicker/how-to/read/read.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/how-to/read/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Read.cs" %}
{% include code-snippet/datepicker/how-to/read/read.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

