---
layout: post
title: How to reorder active tab in ##Platform_Name## Tabs | Syncfusion
description: Prevent reordering of the active Syncfusion ##Platform_Name## Tabs item inside the popup overflow mode by setting `reorderActiveTab` to false.
platform: ej2-asp-core-mvc
control: Reorder Active Tab
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to reorder active tab in ##Platform_Name## Tabs

We can able to prevent the changing of the active tab item on resizing the browser when overflow mode is popup by using the `reorderActiveTab` property. By default, the active Tab should be reordered when we click the tab items from the popup. If we set `false` to `reorderActiveTab` property the active tab item from the popup will not be reordered and an active item is highlighted inside the popup. The following code example depicts to prevent the reorder active tab item inside the popup.

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


