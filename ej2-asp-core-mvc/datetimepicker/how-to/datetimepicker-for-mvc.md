---
layout: post
title: Datetimepicker For Mvc in ##Platform_Name## Datetimepicker Component
description: Learn here all about Datetimepicker for Mvc in Syncfusion ##Platform_Name## Datetimepicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Datetimepicker For Mvc
publishingplatform: ##Platform_Name##
documentation: ug
---


# Render DateTimePickerFor

The DateTimePickerFor component can be rendered by passing a value from the model. The selected date value can be retrieved during form submission using the post method at the server end.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/datetimepicker-for/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datetimepickerfor.cs" %}
{% include code-snippet/datetimepicker/datetimepicker-for/datetimepickerfor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datetimepicker/datetimepicker-for/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datetimepickerfor.cs" %}
{% include code-snippet/datetimepicker/datetimepicker-for/datetimepickerfor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![DateTimePickerFor Component in ASP.NET MVC](../images/asp-net-mvc-datetimepickerfor-value-post.png)
