---
layout: post
title: Tab key navigation using tabIndex property in ##Platform_Name## Tab Component
description: Learn here all about Tab key navigation in Syncfusion ##Platform_Name## Tab component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tab key navigation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enabling tab key navigation in Tabs

The `tabIndex` property of a Tab item is used to enable tab key navigation for that particular item. When a positive value is assigned to the `tabIndex` property, it allows the user to switch focus to the next or previous tab item using the Tab or Shift+Tab keys. By default, the user can only switch between tab items using the arrow keys.

If the `tabIndex` value is set to 0 for all tab items, the tab will switch based on the order of the elements on the page. This means that if the tab items are listed in a specific order on the page, the user will be able to navigate through them using the Tab key in that same order.

To use the `tabIndex` property, you can assign a positive value to the property of each tab item that you want to enable tab key navigation. For example:

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

With this code, the user will be able to switch between the tab items using the Tab and Shift+Tab keys, in the order specified by the `tabIndex` values.
It's important to note that the `tabIndex` property only affects the ability to navigate between tab items using the Tab key. The user will still be able to use the arrow keys to switch between tab items, regardless of the value of the `tabIndex` property.
