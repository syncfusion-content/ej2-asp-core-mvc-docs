---
layout: post
title: Daterangepicker For Mvc in ##Platform_Name## Daterangepicker Component
description: Learn here all about Daterangepicker For Mvc in Syncfusion ##Platform_Name## Daterangepicker component and more.
platform: ej2-asp-core-mvc
control: Daterangepicker For Mvc
publishingplatform: ##Platform_Name##
documentation: ug
---


# Render DateRangePickerFor

The DateRangePickerFor component can be rendered by passing value from the model. The selected date range value can be retrieved during form submission using the post method at the server end.

The following sample demonstrates how to retrieve the value in the controller by rendering the  DateRangePickerFor component.

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



Selected value will be retrieved as below.

![DateRangePickerFor Component in ASP.NET MVC](../images/asp-net-mvc-daterangepickerfor-value-post.png)
