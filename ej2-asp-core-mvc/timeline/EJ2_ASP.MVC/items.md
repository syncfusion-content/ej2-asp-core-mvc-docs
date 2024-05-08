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

The Timeline items can be added by using the `<e-timeline-item>` tag helper. Each item can be configured with options such as `content`, `oppositeContent`, `dotCss`, `disabled` and `cssClass`.

## Adding content

You can define the item content using the [content](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Layouts.TimelineItem.html#Syncfusion_EJ2_Layouts_TimelineItem_Content) property.

### String content

You can define string content for the Timeline items.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/items/content/string-based/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/items/content/string-based/stringbased.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/items/content/string-based/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/items/content/string-based/stringbased.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![String-based content](images/content.png)

### Templated content

You can specify the [Template Content](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Layouts.TimelineItem.html#Syncfusion_EJ2_Layouts_TimelineItem_ContentTemplate) for the items, by using the selector for an element in HTML.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/items/content/template-based/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/items/content/template-based/templatebased.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/items/content/template-based/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/items/content/template-based/templatebased.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Templated content](images/content-template.png)

## Adding opposite content

You can add additional information to each Timeline item, by using the [oppositeContent](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Layouts.TimelineItem.html#Syncfusion_EJ2_Layouts_TimelineItem_OppositeContent) property which is positioned opposite to the item content. Similar to the `content` property you can define `string` or `function` as contents to the oppositeContent.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/items/opposite-content/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/items/opposite-content/oppositecontent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/items/opposite-content/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/items/opposite-content/oppositecontent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![opposite content](images/opposite-content.png)

## Dot item

You can define CSS class to set icons, background colors, or images to personalize the appearance of dots associated with each Timeline item by using the [dotCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Layouts.TimelineItem.html#Syncfusion_EJ2_Layouts_TimelineItem_DotCss) property.

### Adding icons

You can define the CSS class to show the icon for each item using the `dotCss` property.

### Adding images

You can include images for the Timeline items using the `dotCss` property, by setting the CSS `background-image` property.

### Adding text

You can display text for the Timeline items using the `dotCss` property, by adding text to the CSS `content` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/items/dot-item/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/items/dot-item/dotitem.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/items/dot-item/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/items/dot-item/dotitem.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Dot items](images/dot-item.png)

## Disabling items

You can use the [disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Layouts.TimelineItem.html#Syncfusion_EJ2_Layouts_TimelineItem_Disabled) property to disable an item when set to `true`. By default, the value is `false`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/items/disabled/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/items/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/items/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/items/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Disabling items](images/disabled.png)

## CSS class

The [cssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Layouts.TimelineItem.html#Syncfusion_EJ2_Layouts_TimelineItem_CssClass) property allows you to define a custom class to modify the appearance of the Timeline item.