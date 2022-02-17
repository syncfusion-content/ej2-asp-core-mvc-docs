---
layout: post
title: Customize Tab Content Height in ##Platform_Name## Tab Component
description: Learn here all about Customize Tab Content Height in Syncfusion ##Platform_Name## Tab component and more.
platform: ej2-asp-core-mvc
control: Customize Tab Content Height
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize Tab content height

You can change the Tab content height by using the `heightAdjustMode` property. By default, the Tab content `heightAdjustMode` property is set to `Content` value.

* **None**: Each tab content height is set based on the Tab height. This value is used only the tab component having the `height` property.
* **Auto**: Each tab content height will take the maximum height of all other tabs content.
* **Content**: Each tab content height is set based on their own content.
* **Fill**: Each tab content height is set based on the full height of Tabs parent element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Height.cs" %}
{% include code-snippet/tab/height/height.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Height.cs" %}
{% include code-snippet/tab/height/height.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Custom Tab content height](../images/height.PNG)