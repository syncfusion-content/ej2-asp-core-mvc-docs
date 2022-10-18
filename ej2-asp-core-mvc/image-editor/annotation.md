---
layout: post
title: Annotation in ##Platform_Name## ImageEditor Control | Syncfusion
description: Learn here all about Customiation in Syncfusion ##Platform_Name## ImageEditor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Annotation

The Image Editor has multiple annotations support including text, freehand drawings, and shapes such as rectangles, ellipses, and lines.

## Text

The Text annotation can be inserted and customized by changing its color, font family, font size, and font styles such as bold and italic. The text annotation can be made by either using a toolbar or `drawText` method.

In `drawText` method, the text annotation can be inserted by specifying the text, font family, font size, and font styles. The `drawText` method has the following parameters.

* x - Specifies x-coordinate of the text

* y - Specifies y-coordinate of the text

* text - Specifies the text to add to an image

* fontFamily - Specifies the font family of the text.

* fontSize - Specifies the font size of the text.

* bold - Specifies whether the text is bold or not.

* italic - Specifies whether the text is italic or not.

* color - Specifies font color of the text.

In the toolbar, the text annotation can be inserted by clicking the Annotation dropdown button and picking the Add Text option from that popup. Once the text is inserted, the contextual toolbar will be enabled for customizing its color, font family, font size, and font styles such as bold and italic.

In the following example, you can using the drawText method in the button click event..

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/annotation/text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/annotation/text/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/annotation/text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/annotation/text/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](/images/image-editor-text.png)

## Freehand Draw

This annotation can be customized by changing the pen color and stroke width and it can be made by either using a toolbar or the `freeHandDraw` method.

The `freeHandDraw` method is used to enable or disable a freehand drawing option in an Image Editor.

In the toolbar, the freehand draw annotation can be inserted by clicking the Annotation dropdown button and picking the Pen option from that popup. Once the freehand draw is enabled, the contextual toolbar will be enabled.

In the following example, the `freeHandDraw` method is used to toggle the freehand drawings.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/annotation/freehand-draw/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/annotation/freehand-draw/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/annotation/freehand-draw/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/annotation/freehand-draw/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](/images/image-editor-freehand-draw.png)

## Shapes

The shape annotations include rectangles, ellipses, and lines. The border color, fill color, and border width of the shapes can be customized.

### Rectangle

The Rectangle shape can be inserted and customized by changing its border color, fill color, and border width. The Rectangle shape can be made by either using a toolbar or the `drawRectangle` method.

In the `drawRectangle` method, the rectangle shape can be inserted by specifying fillcolor, stroke color and stroke width. The `drawRectangle` method has the following parameters.

     *  x - Specifies the x-coordinate of the rectangle.

     *  y - Specifies the y-coordinate of the rectangle.

     *  width - Specifies the width of the rectangle.

     *  height - Specifies the height of the rectangle.

     *  strokeWidth - Specifies the stroke width of the rectangle.

     *  strokeColor - Specifies the stroke color of the rectangle.

     *  fillColor - the fill color of the rectangle.

In the toolbar, the Rectangle shape can be inserted by clicking the Annotation dropdown button and picking the Rectangle option from that popup. Once the shape is inserted, the contextual toolbar will be enabled for customizing its fill color, stroke color, and stroke width.

In the following example, the `drawRectangle` method is used to draw the rectangle.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/annotation/rectangle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/annotation/rectangle/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/annotation/rectangle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/annotation/rectangle/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](/images/image-editor-rectangle.png)

### Ellipse

The Ellipse shape can be inserted and customized by changing its border color, fill color, and border width. The Ellipse shape can be made by either using a toolbar or the `drawEllipse` method.

In the `drawEllipse` method, the ellipse shape can be inserted by specifying fillcolor, stroke color and stroke width. The `drawEllipse` method has the following parameters.

     * x - Specifies the x-coordinate of the ellipse.

     * y - Specifies the y-coordinate of the ellipse.

     * radiusX - the radius x point for the ellipse.

     * radiusY - the radius y point for the ellipse.

     * strokeWidth - the stroke width of the ellipse.

     * strokeColor - the stroke color of the ellipse.

     * fillColor - the fill color of the ellipse.

In the toolbar, the Ellipse shape can be inserted by clicking the Annotation dropdown button and picking the Ellipse option from that popup. Once the shape is inserted, the contextual toolbar will be enabled for customizing its fill color, stroke color, and stroke width.

In the following example, the `drawEllipse` method is used to draw the ellipse.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/annotation/ellipse/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/annotation/ellipse/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/annotation/ellipse/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/annotation/ellipse/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](/images/image-editor-ellipse.png)

### Line

The line shape can be inserted and customized by changing its border color, and border width. The Line shape can be made by either using a toolbar or the `drawLine` method.

In the `drawLine` method, the line shape can be inserted by specifying, stroke color and stroke width. The `drawLine` method has the following parameters:

     *  startX – Specifies start point x-coordinate of line.

     *  startY – Specifies start point y-coordinate of line.

     *  endX - Specifies endpoint x-coordinates of line.

     *  endY - Specifies end point y-coordinates of the line.

     *  strokeWidth - Specifies the stroke width of the line.

     *  strokeColor - Specifies the stroke color of the line.

In the toolbar, the Line shape can be inserted by clicking the Annotation dropdown button and picking the Line option from that popup. Once the line shape is inserted, the contextual toolbar will be enabled for customizing its stroke color, and stroke width.

In the following example, the `drawLine` method is used to draw the line.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/annotation/line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/annotation/line/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/annotation/line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/annotation/line/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](/images/image-editor-line.png)
