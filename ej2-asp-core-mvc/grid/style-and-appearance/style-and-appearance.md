---
layout: post
title: Style And Appearance in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about Style And Appearance in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Style And Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Style and Appearance

To modify the Grid appearance, you need to override the default CSS of grid. Please find the CSS structure that can be used to modify the Grid appearance. Also, you have an option to create your own custom theme for all the JavaScript controls using our [`Theme Studio`](https://ej2.syncfusion.com/themestudio/?theme=material).

## Customizing the Grid root element

Use the below CSS to customize the Grid root element.

```css

.e-grid {
      font-family: cursive;
}

```

You can modify the grid styling appearance by overriding the default CSS style of the Grid.

In the following sample, the font family of grid content is changed to **cursive**, and the background color of rows, selected rows, alternate rows, and row hovering color is modified using the below CSS styles.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/style-and-appearance/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Style-and-appearance.cs" %}
{% include code-snippet/grid/style-and-appearance/style-and-appearance.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/style-and-appearance/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Style-and-appearance.cs" %}
{% include code-snippet/grid/style-and-appearance/style-and-appearance.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
