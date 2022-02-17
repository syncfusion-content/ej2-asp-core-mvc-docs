---
layout: post
title: Timepicker For Mvc in ##Platform_Name## Timepicker Component
description: Learn here all about Timepicker For Mvc in Syncfusion ##Platform_Name## Timepicker component and more.
platform: ej2-asp-core-mvc
control: Timepicker For Mvc
publishingplatform: ##Platform_Name##
documentation: ug
---


# Render TimePickerFor

The TimePickerFor component can be rendered by passing a value from the model. The selected date value can be retrieved during form submission using the post method at the server end.

The following sample demonstrates how to retrieve the value in the controller by rendering the  TimePickerFor component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timepicker/how-to/timepicker-for/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Timepickerfor.cs" %}
{% include code-snippet/timepicker/how-to/timepicker-for/timepickerfor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timepicker/how-to/timepicker-for/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Timepickerfor.cs" %}
{% include code-snippet/timepicker/how-to/timepicker-for/timepickerfor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Selected value will be retrieved as below.

![TimePickerFor Component in ASP.NET MVC](../images/asp-net-mvc-timepickerfor-value-post.png)
