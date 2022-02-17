---
layout: post
title: Set The Placeholder in ##Platform_Name## Datepicker Component
description: Learn here all about Set The Placeholder in Syncfusion ##Platform_Name## Datepicker component and more.
platform: ej2-asp-core-mvc
control: Set The Placeholder
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set the placeholder

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

