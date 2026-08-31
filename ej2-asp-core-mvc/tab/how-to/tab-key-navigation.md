---
layout: post
title: How to enable Tab key navigation in ##Platform_Name## Tabs | Syncfusion
description: Enable Tab key navigation between Syncfusion ##Platform_Name## Tabs items by setting a positive value to the `TabIndex` property on each item.
platform: ej2-asp-core-mvc
control: Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to enable Tab key navigation in ##Platform_Name## Tabs

The `TabIndex` property of a Tab item is used to enable Tab key navigation for that particular item. When a positive value is assigned to the `TabIndex` property, it allows the user to switch focus to the next or previous Tab item using the Tab or Shift+Tab keys. By default, the user can only switch between Tab items using the arrow keys.

If the `TabIndex` value is set to **0** for all Tab items, the Tab will switch based on the order of the elements on the page. This means that if the Tab items are listed in a specific order on the page, the user will be able to navigate through them using the Tab key in that same order.

To use the `TabIndex` property, you can assign a positive value to the property of each Tab item that you want to enable Tab key navigation. For example:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/tabkeynavigation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tabkeynavigation.cs" %}
{% include code-snippet/tab/tabkeynavigation/tabkeynavigation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/tabkeynavigation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tabkeynavigation.cs" %}
{% include code-snippet/tab/tabkeynavigation/tabkeynavigation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

With this code, the user will be able to switch between the Tab items using the Tab and Shift+Tab keys, in the order specified by the `TabIndex` values.
It's important to note that the `TabIndex` property only affects the ability to navigate between Tab items using the Tab key. The user will still be able to use the arrow keys to switch between Tab items, regardless of the value of the `TabIndex` property.
