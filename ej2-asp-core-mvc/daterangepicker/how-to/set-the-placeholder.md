---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Set The Placeholder of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Set The Placeholder
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set the placeholder

The following example demonstrates how to set [placeholder](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Calendars.DateRangePicker.html#Syncfusion_EJ2_Calendars_DateRangePicker_Placeholder) in the DateRangePicker control.

Using `placeholder` you can display a short hint in the input element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/how-to/placeholder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Placeholder.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/how-to/placeholder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Placeholder.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

