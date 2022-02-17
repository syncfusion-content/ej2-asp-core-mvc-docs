---
layout: post
title: Grid Tick in ##Platform_Name## Range Navigator Component
description: Learn here all about Grid Tick in Syncfusion ##Platform_Name## Range Navigator component and more.
platform: ej2-asp-core-mvc
control: Grid Tick
publishingplatform: ##Platform_Name##
documentation: ug
---


# Grid and Tick Lines

## Grid line customization

The gridlines indicate axis divisions by drawing the chart plot. Gridlines include helpful cues to the user, particularly for large or complicated charts. The `width`, `color`, and `dashArray` of the major gridlines can be customized by using the `majorGridLines` setting.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/grid/grid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grid.cs" %}
{% include code-snippet/range-navigator/grid/grid/grid.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/grid/grid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grid.cs" %}
{% include code-snippet/range-navigator/grid/grid/grid.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Gridline customization](images/grid-tick/grid.png)

## Tick line customization

Ticklines are the small lines which is drawn on the axis line representing the axis labels. Ticklines will be drawn outside the axis by default. The `width`, `color`, and `dashArray` of the major ticklines can be customized by using the `majorTickLines` setting.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/grid/tick/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tick.cs" %}
{% include code-snippet/range-navigator/grid/tick/tick.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/range-navigator/grid/tick/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tick.cs" %}
{% include code-snippet/range-navigator/grid/tick/tick.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Tickline customization](images/grid-tick/tick.png)