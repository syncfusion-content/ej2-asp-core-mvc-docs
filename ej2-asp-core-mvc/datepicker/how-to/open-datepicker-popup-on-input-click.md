---
layout: post
title: Open Datepicker Popup On Input Click in ##Platform_Name## Datepicker Component
description: Learn here all about open Datepicker popup on input click in Syncfusion ##Platform_Name## Datepicker component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Open Datepicker Popup On Input Click
publishingplatform: ##Platform_Name##
documentation: ug
---


# Open the DatePicker popup upon focusing input of DatePicker

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