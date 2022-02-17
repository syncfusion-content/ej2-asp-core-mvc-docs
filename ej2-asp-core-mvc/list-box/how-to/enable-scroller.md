---
layout: post
title: Enable Scroller in ##Platform_Name## List Box Component
description: Learn here all about Enable Scroller in Syncfusion ##Platform_Name## List Box component and more.
platform: ej2-asp-core-mvc
control: Enable Scroller
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enable Scroller

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

