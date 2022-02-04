---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Set The Readonly of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Set The Readonly
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set the readonly

The following example demonstrates how to set `readonly` in DatePicker control.
You can achieve this by using [readonly](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DatePicker.html#Syncfusion_EJ2_Calendars_DatePicker_Readonly) property.

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

