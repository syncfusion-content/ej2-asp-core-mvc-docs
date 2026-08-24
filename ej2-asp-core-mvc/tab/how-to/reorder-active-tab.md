---
layout: post
title: How to reorder active Tab in ##Platform_Name## Tabs | Syncfusion
description: Prevent reordering of the active Syncfusion ##Platform_Name## Tabs item inside the popup overflow mode by setting `reorderActiveTab` to false.
platform: ej2-asp-core-mvc
control: Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to reorder active Tab in ##Platform_Name## Tabs

You can able to prevent the changing of the active Tab item on resizing the browser when overflow mode is popup by using the [reorderActiveTab](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.Tab.html#Syncfusion_EJ2_Navigations_Tab_ReorderActiveTab) property. By default, the active Tab is reordered when you select a Tab item from the popup. If You set `reorderActiveTab` to **false**, the active Tab item from the popup will not be reordered and the active item is highlighted inside the popup. The following code example demonstrates how to prevent the active Tab from being reordered within the popup.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/reorderactivetab/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Reorderactivetab.cs" %}
{% include code-snippet/tab/reorderactivetab/reorderactivetab.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/reorderactivetab/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Reorderactivetab.cs" %}
{% include code-snippet/tab/reorderactivetab/reorderactivetab.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


