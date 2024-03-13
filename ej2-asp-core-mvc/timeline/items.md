---
layout: post
title: Items in ##Platform_Name## Timeline Control | Syncfusion
description: Checkout and learn about Items in Syncfusion ##Platform_Name## Timeline control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Items in ##Platform_Name## Timeline control

The `items` property in Timeline is responsible for providing the data that will be displayed as individual timeline entries where each item can be customized using various properties.

## Defining Content

The `content` property specifies the main text or information displayed within the timeline item.

### String-based Content

You can directly provide a simple, static content that describes the timeline item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Template-based Content

This allows you to have greater control over the content displayed in each item which enables you to define item content using HTML elements.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Adding Opposite Content

The oppositeContent property defines additional content that appears opposite to the main content within the timeline item. Similar to the `content`, you can also define opposite content as either a `string` or a `template`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Defining Dot item

The `dotCss` property allows you to specify a class to personalize the appearance of the dot associated with each timeline item.

### Displaying Icons

By using the `dotCss` property, you can define an Icon CSS class to render an icon in the timeline item.

### Adding Images

You can use the `dotCss` property to specify a class and set background image for it which embeds an image in the timeline item.

### Including Text

You can also define a class using the `dotCss` property and utilize the pseudo-selector to define the content property within the CSS to showcase text directly in timeline item.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Disabled Item

The `disabled` property determines whether the timeline item is active or inactive. When set to `true`, the item is disabled and may appear grayed out, indicating that it is not currently accessible.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/Timeline/item-configuration/separator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/Timeline/item-configuration/separator/separator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## CSS class

The `cssClass` property allows you to define a custom class to modify the appearance of the timeline item.