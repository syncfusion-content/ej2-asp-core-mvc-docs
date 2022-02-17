---
layout: post
title: Datetimepicker For Core in ##Platform_Name## Datetimepicker Component
description: Learn here all about Datetimepicker For Core in Syncfusion ##Platform_Name## Datetimepicker component and more.
platform: ej2-asp-core-mvc
control: Datetimepicker For Core
publishingplatform: ##Platform_Name##
documentation: ug
---


# Render DateTimePickerFor

The DateTimePickerFor component can be rendered by passing a value from the model. The selected date value can be retrieved during form submission using the post method at the server end.

The following sample demonstrates how to retrieve the value in the controller by rendering the DateTimePickerFor component.

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



Selected value will be retrieved as below.

![DateTimePickerFor Component in ASP.NET Core](../images/asp-net-core-datetimepickerfor-value-post.png)
