---
layout: post
title: Bing Map in ##Platform_Name## Maps Component
description: Learn here all about Bing Map in Syncfusion ##Platform_Name## Maps component and more.
platform: ej2-asp-core-mvc
control: Bing Map
publishingplatform: ##Platform_Name##
documentation: ug
---

# Display geometry shape in bing maps

Usually bing map displays the Maps in satellite view in which you can't make changes as per your requirement. To over come this, you can add maps shape as sublayer over the bing map and you can customize it as per your requirement. Kindly follow the below steps to add geometry shapes as sublayer in bing maps.

**Step 1**:

To render the Maps control as bing map, set the `ShapeLayerType` as **Bing** and also provide the key for the bing map.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/bing/bingmap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bingmap.cs" %}
{% include code-snippet/maps/bing/bingmap/bingmap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/bing/bingmap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bingmap.cs" %}
{% include code-snippet/maps/bing/bingmap/bingmap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![bing map](../images/How-to/bing.PNG)

**Step 2**:

The geometry shape can be added in the bing map using sublayer concept. In the below example, Africa continent can be set as the sublayer in bing map using the `Type` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/bing/bingsublayer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bingsublayer.cs" %}
{% include code-snippet/maps/bing/bingsublayer/bingsublayer.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/bing/bingsublayer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bingsublayer.cs" %}
{% include code-snippet/maps/bing/bingsublayer/bingsublayer.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![bing map with sublayer](../images/How-to/bingwithsublayer.PNG)