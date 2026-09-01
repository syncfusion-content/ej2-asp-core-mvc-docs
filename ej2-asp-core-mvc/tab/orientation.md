---
layout: post
title: Orientation in ##Platform_Name## Tabs | Syncfusion
description: Place the Syncfusion ##Platform_Name## Tabs header at top, bottom, left, or right positions using the `headerPlacement` property.
platform: ej2-asp-core-mvc
control: Tabs
publishingplatform: ##Platform_Name##
documentation: ug
---

# Orientation in ##Platform_Name## Tabs control

This section explains how to modify the position and overflow mode of the Tab header.

It allows placing the header section inside the Tabs control at different positions by using the `headerPlacement` property. The available positions are as follows:

* **Top**: Tab header items can be arranged horizontally, and their content can be placed after the header.
* **Bottom**: Tab header items can be arranged horizontally, and their content can be placed before the header.
* **Left**: Tab header items can be arranged vertically, and their content can be placed after the header.
* **Right**: Tab header items can be arranged vertically, and their content can be placed before the header.

It is also adaptable to the available space when the Tab items exceed the view space. You can customize the modes by using `overflowMode` property. The available modes are as follows:

* Scrollable
* Popup

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/orientation-tab/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Orientation.cs" %}
{% include code-snippet/tab/orientation-tab/orientation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/orientation-tab/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Orientation.cs" %}
{% include code-snippet/tab/orientation-tab/orientation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![Tab vertical support](./images/vertical.PNG)

## See also

* [How to load Tab with DataSource](./how-to/load-tab-with-data-source)
* [How to load Tab items dynamically](./how-to/load-tab-items-dynamically)
* [How to render the Tab items using content template](./how-to/render-the-tab-items-using-content-template)
