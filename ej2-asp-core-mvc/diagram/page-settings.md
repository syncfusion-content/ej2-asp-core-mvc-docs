---
layout: post
title: Page Settings in ##Platform_Name## Diagram Component
description: Learn here all about Page Settings in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Page Settings
publishingplatform: ##Platform_Name##
documentation: ug
---


# Page Settings

Page settings enable to customize the appearance, width, and height of the diagram page.

## Page size and appearance

* The size and appearance of the diagram pages can be customized with the page settings property.

* The [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPageSettings.html#Syncfusion_EJ2_Diagrams_DiagramPageSettings_Width) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPageSettings.html#Syncfusion_EJ2_Diagrams_DiagramPageSettings_Height) properties of page settings define the size of the page and based on the size, the [`orientation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPageSettings.html#Syncfusion_EJ2_Diagrams_DiagramPageSettings_Orientation) will be set for the page. In addition to that, the appearance of the page can be customized with [`source`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramBackground.html#Syncfusion_EJ2_Diagrams_DiagramBackground_Source) and set of appearance specific properties.

* The [`color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramBackground.html#Syncfusion_EJ2_Diagrams_DiagramBackground_Color) property is used to customize the background color and border color of the page.

* The [`margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPageSettings.html#Syncfusion_EJ2_Diagrams_DiagramPageSettings_Margin) property is used to define the page margin.

* To explore those properties, refer to [`Page Settings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPageSettings.htmll).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/pageSettings/page/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Page.cs" %}
{% include code-snippet/diagram/pageSettings/page/page.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Page.cs" %}
{% include code-snippet/diagram/pageSettings/page/page.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Set background image

Stretch and align the background image anywhere over the diagram area.
The [`source`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramBackground.html#Syncfusion_EJ2_Diagrams_DiagramBackground_Source) property of [`background`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramBackground.html) allows you to set the path of the image.
The [`scale`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramBackground.html#Syncfusion_EJ2_Diagrams_DiagramBackground_Scale) and the [`align`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramBackground.html#Syncfusion_EJ2_Diagrams_DiagramBackground_Align) properties help to stretch/align the background images.

The following code illustrates how to stretch and align the background image.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/pagesettings/image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Image.cs" %}
{% include code-snippet/diagram/pagesettings/image/image.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/pagesettings/image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Image.cs" %}
{% include code-snippet/diagram/pagesettings/image/image.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple page and page breaks

When multiple page is enabled, the size of the page dynamically increases or decreases in multiples of page width and height and completely fits diagram within the page boundaries. Page breaks is used as a visual guide to see how pages are split into multiple pages.

The [`multiplePage`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPageSettings.html#Syncfusion_EJ2_Diagrams_DiagramPageSettings_MultiplePage) and [`showPageBreak`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPageSettings.html#Syncfusion_EJ2_Diagrams_DiagramPageSettings_ShowPageBreaks) properties of page settings allow you to enable/disable multiple pages and page breaks respectively.
The following code illustrates how to enable multiple page and page break lines.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/pagesettings/image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Image.cs" %}
{% include code-snippet/diagram/pagesettings/image/image.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/pagesettings/image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Image.cs" %}
{% include code-snippet/diagram/pagesettings/image/image.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Boundary constraints

The diagram provides support to restrict/customize the interactive region, out of which the elements cannot be dragged, resized, or rotated. The [`boundaryConstraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.BoundaryConstraints.html) property of page settings allows you to customize the interactive region.
To explore the boundary constraints, refer to [`Boundary Constraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.BoundaryConstraints.html).

The following code example illustrates how to define boundary constraints with respect to the page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/pagesettings/boundary/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Boundary.cs" %}
{% include code-snippet/diagram/pagesettings/boundary/boundary.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/pagesettings/boundary/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Boundary.cs" %}
{% include code-snippet/diagram/pagesettings/boundary/boundary.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

