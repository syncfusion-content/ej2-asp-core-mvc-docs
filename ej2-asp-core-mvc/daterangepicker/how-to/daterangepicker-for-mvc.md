---
layout: post
title: Render DateRangePickerFor in DateRangePicker | Syncfusion
description: Render Syncfusion ##Platform_Name## DateRangePickerFor from a model and retrieve the selected range during form submission using the HTTP post method.
platform: ej2-asp-core-mvc
control: Daterangepicker For Mvc
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to render DateRangePickerFor in ##Platform_Name## DateRangePicker

The DateRangePickerFor component can be rendered by passing value from the model. The selected date range value can be retrieved during form submission using the post method at the server end.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/how-to/daterangepicker-for/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Daterangepickerfor.cs" %}
{% include code-snippet/daterangepicker/how-to/daterangepicker-for/daterangepickerfor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/daterangepicker/how-to/daterangepicker-for/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Daterangepickerfor.cs" %}
{% include code-snippet/daterangepicker/how-to/daterangepicker-for/daterangepickerfor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![DateRangePickerFor Component in ASP.NET MVC](../images/asp-net-mvc-daterangepickerfor-value-post.png)
