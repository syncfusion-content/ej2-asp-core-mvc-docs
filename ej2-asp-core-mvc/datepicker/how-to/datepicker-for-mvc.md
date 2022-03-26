---
layout: post
title: Datepicker For Mvc in ##Platform_Name## Datepicker Component
description: Learn here all about Datepicker for Mvc in Syncfusion ##Platform_Name## Datepicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Datepicker For Mvc
publishingplatform: ##Platform_Name##
documentation: ug
---


# Render DatePickerFor

The DatePickerFor component can be rendered by passing a value from the model. The selected date value can be retrieved during form submission using the post method at the server end.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/how-to/datepicker-for/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datepickerfor.cs" %}
{% include code-snippet/datepicker/how-to/datepicker-for/datepickerfor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/how-to/datepicker-for/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datepickerfor.cs" %}
{% include code-snippet/datepicker/how-to/datepicker-for/datepickerfor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![DatePickerFor Component in ASP.NET MVC](../images/asp-net-mvc-datepickerfor-value-post.png)
