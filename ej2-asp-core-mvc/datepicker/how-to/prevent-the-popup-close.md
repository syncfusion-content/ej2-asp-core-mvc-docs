---
layout: post
title: How to prevent popup close in ##Platform_Name## DatePicker | Syncfusion
description: Keep the Syncfusion ##Platform_Name## DatePicker popup open by calling preventDefault on the PreventableEventArgs in the close event.
platform: ej2-asp-core-mvc
control: Prevent The Popup Close
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to prevent popup close in ##Platform_Name## DatePicker

To prevent the DatePicker popup from closing, use the preventDefault method from the `PreventableEventArgs`.

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

