---
layout: post
title: Resize the Syncfusion Grid in Various Dimensions in ##Platform_Name## Grid Component
description: Learn here all about Resize the Grid in various dimension in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Resize the Grid in various dimension
publishingplatform: ##Platform_Name##
documentation: ug
---

# Resize the Grid in various dimension in ASP.NET MVC Grid

The Syncfusion ASP.NET MVC Grid offers a friendly way to resize the Grid, allowing you to adjust its width and height for improved data visualization.

To resize the Grid externally, you can use an external button to modify the width of the parent element that contains the Grid. This will effectively resize the Grid along with its parent container.

The following example demonstrates how to resize the Grid on external button click based on input:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/keyboard-dimension/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dimension.cs" %}
{% include code-snippet/grid/how-to/keyboard-dimension/dimension.cs %}
{% endhighlight %}
{% endtabs %}

![various dimension](../images/how-to-dimension.png)