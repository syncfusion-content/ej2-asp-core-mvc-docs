---
layout: post
title: Export with Templates in ##Platform_Name## Maps Component
description: Learn how to export Maps with Templates in Syncfusion ##Platform_Name## Maps component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Maps
publishingplatform: ##Platform_Name##
documentation: ug
---

# Export with Templates in Angular Maps component

Maps has template support for marker, data label and tooltip, as well as annotation that is similar to template. We will demonstrate how to export a marker template in the following example. In a similar way, you can export the data label template, tooltip template and annotation.

First, Maps does not support exporting with a marker template. This is because the marker template functionality is intended to render any HTML elements, such as text, tables, images, or custom HTML design, on top of the Maps. Because Maps is an SVG component, the marker templates are positioned above the SVG element in the top, left, bottom, and right positions. As a result, when exporting, the marker templates must be placed in the **foreignObject** element of the SVG and positioned using CSS styles. However, it is not supported by all web browsers. As a workaround, we can achieve the desired result in the sample application itself.

> The Maps with marker template, data label template, tooltip template and annotation can be exported in **PNG**, **JPEG**, and **PDF** formats.

## Export Shape Maps with Template

The following code example will show you how to export a shape Maps with marker template. You can also use this format to frame and make other templates and annotation work.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/export-template/shape-map-with-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShapeMapTemplate.cs" %}
{% include code-snippet/maps/export-template/shape-map-with-template/shape-map-with-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/export-template/shape-map-with-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShapeMapTemplate.cs" %}
{% include code-snippet/maps/export-template/shape-map-with-template/shape-map-with-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Shape Maps with template](../images/how-to/shape-maps-with-template.png)

## Export OSM Maps with Template

The following code example will show you how to export an OSM Maps with marker template. You can also use this format to frame and make other templates and annotation work.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/export-template/osm-map-with-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="OSMMapTemplate.cs" %}
{% include code-snippet/maps/export-template/osm-map-with-template/osm-map-with-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/export-template/osm-map-with-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="OSMMapTemplate.cs" %}
{% include code-snippet/maps/export-template/osm-map-with-template/osm-map-with-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Screenshot**

![OSM Maps with template](../images/how-to/osm-maps-with-template.png)