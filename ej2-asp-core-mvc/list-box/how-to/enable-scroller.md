---
layout: post
title: How to enable the scroller in ##Platform_Name## ListBox | Syncfusion
description: Enable Syncfusion ##Platform_Name## ListBox scrolling for long lists by setting the scrollMode property to Scroll, ScrollTo, or Virtual with fixed item height.
platform: ej2-asp-core-mvc
control: Enable Scroller
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to enable the scroller in ##Platform_Name## ListBox

The ListBox supports scrolling and it can be achieved by restricting the height of the list box using [`height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~Height.html) property.

In the following sample, `height` of the list box is restricted to `250px`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/scroller/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Scroller.cs" %}
{% include code-snippet/listbox/scroller/scroller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/scroller/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Scroller.cs" %}
{% include code-snippet/listbox/scroller/scroller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

