---
layout: post
title: How to add tooltips to ##Platform_Name## DropDownList items | Syncfusion
description: Add a Syncfusion Tooltip to ##Platform_Name## DropDownList items via beforeRender, displaying each item's Name and Code in the tooltip.
platform: ej2-asp-core-mvc
control: Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to add tooltips to ##Platform_Name## DropDownList items

You can add tooltips to DropDownList items by using the `ej.popups.Tooltip` component. When the mouse hovers over a DropDownList item, the tooltip displays the item's Name and Code. The Tooltip is instantiated client-side, appended to the `body`, and its `beforeRender` event is used to set the content based on the hovered list item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/dropdown-with-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Countries.cs" %}
{% include code-snippet/dropdownlist/how-to/dropdown-with-tooltip/Countries.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/dropdown-with-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Countries.cs" %}
{% include code-snippet/dropdownlist/how-to/dropdown-with-tooltip/Countries.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

