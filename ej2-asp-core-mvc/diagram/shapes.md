---
layout: post
title: Shapes in ##Platform_Name## Diagram Component
description: Learn here all about Shapes in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Shapes
publishingplatform: ##Platform_Name##
documentation: ug
---


# Shapes

Diagram provides support to add different kind of nodes. They are as follows:

* Text node
* Image node
* HTML node
* Native node
* Basic shapes
* Flow shapes

<!-- markdownlint-disable MD033 -->
<!-- markdownlint-disable MD010 -->

## Text

Texts can be added to the diagram as [`text`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) nodes. The shape property of the node allows you to set the type of node and for text nodes, it should be set as **text**. In addition, define the content object that is used to define the text to be added and style is used to customize the appearance of that text. The following code illustrates how to create a text node.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text.cs" %}
{% include code-snippet/diagram/shapes/text/text.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Text.cs" %}
{% include code-snippet/diagram/shapes/text/text.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Image

Diagram allows to add images as [`image`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) nodes. The shape property of node allows you to set the type of node and for image nodes, it should be set as **image**. In addition, the source property of shape enables you to set the image source.

The following code illustrates how an image node is created.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Image.cs" %}
{% include code-snippet/diagram/shapes/image/image.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Image.cs" %}
{% include code-snippet/diagram/shapes/image/image.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Base64 Encoded Image Into The Image Node:**

The following code illustrates how add Base64 image into image node.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/imagebase64/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Imagebase64.cs" %}
{% include code-snippet/diagram/shapes/imagebase64/imagebase64.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Imagebase64.cs" %}
{% include code-snippet/diagram/shapes/imagebase64/imagebase64.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Deploy your HTML file in the web application and export the diagram (image node) or else the image node will not be exported in the Chrome and Firefox due to security issues. Refer to the following link.

Link 1: `http://asked.online/draw-images-on-canvas-locally-using-chrome/2546077/`

Link 2: `http://stackoverflow.com/questions/4761711/local-image-in-canvas-in-chrome`

## Image alignment

Stretch and align the image content anywhere but within the node boundary.

The scale property of the node allows to stretch the image as you desired (either to maintain proportion or to stretch). By default, the [`scale`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Scale.html) property of the node is set as **meet**.
The following code illustrates how to scale or stretch the content of the image node.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/scale/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Scale.cs" %}
{% include code-snippet/diagram/shapes/scale/scale.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Scale.cs" %}
{% include code-snippet/diagram/shapes/scale/scale.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The following table illustrates all the possible scale options for the image node.

| Values | Images |
|-------- | -------- |
| None | ![None Alignment](images/Image1.png) |
| Meet |![Meet Alignment](images/Image2.png) |
| Slice |![Slice Alignment](images/Image3.png) |
| Stretch |![Stretch Alignment](images/Image4.png) |

## HTML

Html elements can be embedded in the diagram through [`Html`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) type node. The shape property of node allows you to set the type of node and to create a HTML node it should be set as `HTML`. The following code illustrates how an Html node is created.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/HTML/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HTML.cs" %}
{% include code-snippet/diagram/shapes/HTML/HTML.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="HTML.cs" %}
{% include code-snippet/diagram/shapes/HTML/HTML.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> HTML node cannot be exported to image format, like JPEG, PNG, and BMP. It is by design, while exporting the diagram is drawn in a canvas. Further, this canvas is exported into image formats. Currently, drawing in a canvas equivalent from all possible HTML is not feasible. Hence, this limitation.

## HTML Node With Template

Html elements can be embedded in the diagram using [`Html`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) type node. The shape property of the node allows you to set the type of node. The following code shows how an Html node is created with a template.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/html-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HTML_Node_With_Template.cshtml" %}
{% include code-snippet/diagram/shapes/html-template/HTML-Node-With-Template.cshtml %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="HTML_Node_With_Template.cshtml" %}
{% include code-snippet/diagram/shapes/html-template/HTML-Node-With-Template.cshtml %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Native

Diagram provides support to embed SVG element into a node. The shape property of node allows you to set the type of node. To create a [`native`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) node, it should be set as **native**. The following code illustrates how a native node is created.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/native/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Native.cs" %}
{% include code-snippet/diagram/shapes/native/native.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Native.cs" %}
{% include code-snippet/diagram/shapes/native/native.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> Like HTML node, the native node also cannot be exported to image format. Fill color of native node can be overridden by the inline style or fill of the SVG element specified in the template.

## SVG content alignment

Stretch and align the svg content anywhere but within the node boundary.

The scale property of the node allows to stretch the svg content as you desired (either to maintain proportion or to stretch). By default, the `scale` property of node is set as **meet**.
The following code illustrates how to scale or stretch the content of the node.

The following tables illustrates all the possible scale options for the node.

| Values | Images |
|-------- | -------- |
| None | ![None SVG Content Alignment](images/Native1.png) |
| Meet | ![Meet SVG Content Alignment](images/Native2.png) |
| Slice | ![Slice SVG Content Alignment](images/Native3.png) |
| Stretch |![Stretch SVG Content Alignment](images/Native4.png) |

## Basic shapes

* The [`Basic`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) shapes are common shapes that are used to represent the geometrical information visually. To create basic shapes, the type of the shape should be set as **basic**. Its shape property can be set with any one of the built-in shape.

* To render a rounded rectangle, you need to set the type as basic and shape as rectangle. Set the [`cornerRadius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramBasicShape.html#Syncfusion_EJ2_Diagrams_DiagramBasicShape_CornerRadius) property to specify the radius of rounded rectangle.

The following code example illustrates how to create a basic shape.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/basic/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Basic.cs" %}
{% include code-snippet/diagram/shapes/basic/basic.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Basic.cs" %}
{% include code-snippet/diagram/shapes/basic/basic.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> By default, the `shape` property of the node is set as **basic**.

Default property for shape is Rectangle.

> When the `shape` is not set for a basic shape, it is considered as a **rectangle**.

The list of basic shapes are as follows.

![BasicShapes](images/Basic.png)

## Path

The [`Path`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) node is a commonly used basic shape that allows visually to represent the geometrical information. To create a path node, specify the shape as **path**. The path property of node allows you to define the path to be drawn. The following code illustrates how a path node is created.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/path/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Path.cs" %}
{% include code-snippet/diagram/shapes/path/path.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Path.cs" %}
{% include code-snippet/diagram/shapes/path/path.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Flow Shapes

The [`flow`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) shapes are used to represent the process flow. It is used for analyzing, designing, and managing for documentation process. To create a flow shape, specify the shape type as **flow**. Flow shapes and by default, it is considered as **process**. The following code example illustrates how to create a flow shape.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/flow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Flow.cs" %}
{% include code-snippet/diagram/shapes/flow/flow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Flow.cs" %}
{% include code-snippet/diagram/shapes/flow/flow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The list of flow shapes are as follows.

![FlowShapes](images/FlowShapes.png)