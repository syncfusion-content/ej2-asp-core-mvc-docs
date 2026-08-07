---
layout: post
title: ##Platform_Name## Grid Dynamic Resizing | Syncfusion
description: Learn how to resize ##Platform_Name## Data Grid dynamically by adjusting parent container dimensions and managing grid width and height responsively.
platform: ej2-asp-core-mvc
control: Resize the Grid in various dimension
publishingplatform: ##Platform_Name##
documentation: ug
---

# Grid Resizing in ASP.NET Core Data Grid

The Syncfusion ASP.NET Core Grid offers a friendly way to resize the Grid, allowing you to adjust its width and height for improved data visualization.

To resize the Grid externally, you can use an external button to modify the width of the parent element that contains the Grid. This will effectively resize the Grid along with its parent container.

The following example demonstrates how to resize the Grid on external button click based on input:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/keyboard-dimension/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dimension.cs" %}
{% include code-snippet/grid/how-to/keyboard-dimension/dimension.cs %}
{% endhighlight %}
{% endtabs %}

![various dimension](../images/how-to-dimension.png)