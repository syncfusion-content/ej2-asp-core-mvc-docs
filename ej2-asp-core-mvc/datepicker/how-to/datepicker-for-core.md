---
layout: post
title: Datepicker For Core in ##Platform_Name## Datepicker Component
description: Learn here all about Datepicker For Core in Syncfusion ##Platform_Name## Datepicker component and more.
platform: ej2-asp-core-mvc
control: Datepicker For Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Render DatePickerFor

The DatePickerFor component can be rendered by passing a value from the model. The selected date value can be retrieved during form submission using the post method at the server end.

The following sample demonstrates how to retrieve the value in the controller by rendering the DatePickerFor component.

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



Selected value will be retrieved as below.

![DatePickerFor Component in ASP.NET Core](../images/asp-net-core-datepickerfor-value-post.png)
