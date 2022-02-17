---
layout: post
title: Prevent The Popup Close in ##Platform_Name## Datepicker Component
description: Learn here all about Prevent The Popup Close in Syncfusion ##Platform_Name## Datepicker component and more.
platform: ej2-asp-core-mvc
control: Prevent The Popup Close
publishingplatform: ##Platform_Name##
documentation: ug
---


# Prevent the popup close

To prevent the DatePicker popup from closing, use the
preventDefault method from the
`PreventableEventArgs`.

The following example demonstrates how to prevent the popup from closing.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/how-to/popupclose/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Popupclose.cs" %}
{% include code-snippet/datepicker/how-to/popupclose/popupclose.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/how-to/popupclose/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Popupclose.cs" %}
{% include code-snippet/datepicker/how-to/popupclose/popupclose.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

