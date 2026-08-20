---
layout: post
title: Disable fixed group headers in DropDownList | Syncfusion
description: Disable Syncfusion ##Platform_Name## DropDownList fixed group headers by setting CSS visibility hidden on the e-fixed-group class element.
platform: ej2-asp-core-mvc
control: Group Header
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to disable fixed group headers in ##Platform_Name## DropDownList

The following example demonstrate about how to disable the Fixed group header in DropDownList through CSS by using `visibility` attribute.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/disbalefixedheader/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Vegetables.cs" %}
{% include code-snippet/dropdownlist/how-to/disbalefixedheader/Vegetables.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/disbalefixedheader/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Vegetables.cs" %}
{% include code-snippet/dropdownlist/how-to/disbalefixedheader/Vegetables.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

