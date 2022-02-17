---
layout: post
title: Zooming in ##Platform_Name## Maps Component
description: Learn here all about Zooming in Syncfusion ##Platform_Name## Maps component and more.
platform: ej2-asp-core-mvc
control: Zooming
publishingplatform: ##Platform_Name##
documentation: ug
---

# Center position zooming

The center position zooming can be achieved by using the `MapsCenterPosition` class and `ZoomFactor` property as mentioned in the following example. The center position is used to configure the zoom level of Maps, and the zoom factor is used to specify the center position where the Maps should be displayed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/centerposition/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Centerposition.cs" %}
{% include code-snippet/maps/centerposition/centerposition.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/centerposition/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Centerposition.cs" %}
{% include code-snippet/maps/centerposition/centerposition.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Annotation zindex](../images/How-to/centerposition.PNG)