---
layout: post
title: How to open DatePicker on focus in ##Platform_Name## DatePicker | Syncfusion
description: Open the Syncfusion ##Platform_Name## DatePicker popup on input focus by calling the show method inside the input focus event handler.
platform: ej2-asp-core-mvc
control: Open Datepicker Popup On Input Click
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to open DatePicker on focus in ##Platform_Name## DatePicker

You can open the DatePicker popup on input focus by calling the `show` method in the input `focus` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/datepicker/how-to/openpopup/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Openpopup.cs" %}
{% include code-snippet/datepicker/how-to/openpopup/openpopup.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/datepicker/how-to/openpopup/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Openpopup.cs" %}
{% include code-snippet/datepicker/how-to/openpopup/openpopup.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![datepicker](../images/openpopup.png)