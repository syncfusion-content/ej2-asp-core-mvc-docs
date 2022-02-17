---
layout: post
title: Bubble in ##Platform_Name## Maps Component
description: Learn here all about Bubble in Syncfusion ##Platform_Name## Maps component and more.
platform: ej2-asp-core-mvc
control: Bubble
publishingplatform: ##Platform_Name##
documentation: ug
---

# Bubbles

Bubbles in the Maps control represent the underlying data values of the Maps. It can be scattered throughout the Maps shapes that contain values in the data source. Bubbles are enabled by setting the `Visible` property of `MapsBubble` to **true**. To add bubbles to the Maps, bind the data source to the `DataSource` property of `MapsBubble` and set the field name, that contains the numerical data, in the data source to the `ValuePath` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/bubble/bubble/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble.cs" %}
{% include code-snippet/maps/bubble/bubble/bubble.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/bubble/bubble/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble.cs" %}
{% include code-snippet/maps/bubble/bubble/bubble.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bubbles](./images/Bubble/bubble.PNG)

## Bubble shapes

The following types of shapes are available to render the bubbles in Maps.

* Circle
* Square

By default, bubbles are rendered in the **Circle** type. To change the type of the bubble, set the `BubbleType` property of `MapsBubble` as **Square** to render the square shape bubbles.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/bubble/bubble-shape/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-shape.cs" %}
{% include code-snippet/maps/bubble/bubble-shape/bubble-shape.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/bubble/bubble-shape/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-shape.cs" %}
{% include code-snippet/maps/bubble/bubble-shape/bubble-shape.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bubble shape](./images/Bubble/bubble-shape.PNG)

## Customization

The following properties are available in `MapsBubble` to customize the bubbles of the Maps component.

* `Border` – To customize the color, width and opacity of the border of the bubbles in Maps.
* `Fill` – To apply the color for bubbles in Maps.
* `Opacity` – To apply opacity to the bubbles in Maps.
* `AnimationDelay` - To change the time delay in the transition for bubbles.
* `AnimationDuration` - To change the time duration of animation for bubbles.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/bubble/bubble-customization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-customization.cs" %}
{% include code-snippet/maps/bubble/bubble-customization/bubble-customization.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/bubble/bubble-customization/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-customization.cs" %}
{% include code-snippet/maps/bubble/bubble-customization/bubble-customization.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bubble customization](./images/Bubble/bubble-customization.PNG)

## Setting colors to the bubbles from the data source

The color for each bubble in the Maps can be set using the `ColorValuePath` property of `MapsBubble`. The value for the `ColorValuePath` property is the field name from the data source of the `MapsBubble` which contains the color values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/bubble/bubble-valuepath/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-valuepath.cs" %}
{% include code-snippet/maps/bubble/bubble-valuepath/bubble-valuepath.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/bubble/bubble-valuepath/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-valuepath.cs" %}
{% include code-snippet/maps/bubble/bubble-valuepath/bubble-valuepath.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bubble valuepath](./images/Bubble/bubble-valuepath.PNG)

## Setting the range of the bubble size

The size of the bubbles is calculated from the values got from the `ValuePath` property. The range for the radius of the bubbles can be modified using `MinRadius` and `MaxRadius` properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/bubble/bubblesize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bubblesize.cs" %}
{% include code-snippet/maps/bubble/bubblesize/bubblesize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/bubble/bubblesize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bubblesize.cs" %}
{% include code-snippet/maps/bubble/bubblesize/bubblesize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bubble shape](./images/Bubble/bubble-sizing.png)

## Multiple bubble groups

Multiple groups of bubbles can be added in the Maps by adding multiple `MapsBubble` in the `MapsBubbles` and customization for the bubbles can be done with the `MapsBubble` class. In the following example, the gender-wise population ratio is demonstrated with two different bubble groups.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/bubble/multiple-bubble/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-bubble.cs" %}
{% include code-snippet/maps/bubble/multiple-bubble/multiple-bubble.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/bubble/multiple-bubble/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-bubble.cs" %}
{% include code-snippet/maps/bubble/multiple-bubble/multiple-bubble.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Bubble shape](./images/Bubble/multiple-bubble.PNG)

## Enable tooltip for bubble

The tooltip for the bubbles can be enabled by setting the `Visible` property of the `MapsTooltipSettings` as **true**. The content for the tooltip can be set using the `ValuePath` property in the `MapsTooltipSettings` of the `MapsBubble` where the value for the `ValuePath` property is the field name from the data source of the `MapsBubble`. Any HTML element can be added as the template in tooltip using the `Template` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/bubble/bubble-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-tooltip.cs" %}
{% include code-snippet/maps/bubble/bubble-tooltip/bubble-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/bubble/bubble-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bubble-tooltip.cs" %}
{% include code-snippet/maps/bubble/bubble-tooltip/bubble-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Enable tooltip for bubble](./images/Bubble/bubble-tooltip.PNG)