---
layout: post
title: Shapes in ##Platform_Name## Diagram Control | Syncfusion®
description: Learn here all about shapes in Syncfusion® ##Platform_Name## Diagram component of Syncfusion Essential® JS 2 and more.
platform: ej2-asp-core-mvc
control: Shapes
publishingplatform: ##Platform_Name##
documentation: ug
---


# Shapes in Diagram Control

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

Texts can be added to the diagram as [`text`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) nodes. The shape property of the node allows to set the type of node and for text nodes, it should be set as **text**. In addition, define the content object that is used to define the text to be added and style is used to customize the appearance of that text.

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



N> Deploy your HTML file in the web application and export the diagram (image node) or else the image node will not be exported in the Chrome and Firefox due to security issues.

**Link 1**: [Draw images on canvas locally using chrome](http://asked.online/draw-images-on-canvas-locally-using-chrome/2546077/)

**Link 2**: [Local image in canvas in chrome](http://stackoverflow.com/questions/4761711/local-image-in-canvas-in-chrome)

## Image alignment

Stretch and align the image content anywhere but within the node boundary.

The scale property of the node allows to stretch the image as you desired (either to maintain proportion or to stretch). By default, the [`scale`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Scale.html) property of the node is set as **meet**.

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


| Values | Images |
|-------- | -------- |
| None | ![None Alignment](images/Image1.png) |
| Meet |![Meet Alignment](images/Image2.png) |
| Slice |![Slice Alignment](images/Image3.png) |
| Stretch |![Stretch Alignment](images/Image4.png) |

## HTML

Html elements can be embedded in the diagram through [`Html`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html) type node. The shape property of node allows to set the type of node and to create a HTML node it should be set as `HTML`.

N> HTML node cannot be exported to image format, like JPEG, PNG, and BMP. It is by design, while exporting the diagram is drawn in a canvas. Further, this canvas is exported into image formats. Currently, drawing in a canvas equivalent from all possible HTML is not feasible. Hence, this limitation.

### HTML node with content template

To render an HTML node with a content template, we need to define the desired template string within the [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramHtml.html#Syncfusion_EJ2_Diagrams_DiagramHtml_Content) property. The following code illustrates how to create an HTML node with a content template:

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

#### Functional content template

To render an HTML node using a functional template, we define a function that returns the template string. Within this function, modifications can be made based on the node's ID.

The following code illustrates how to render an HTML node using the function and manipulate its content dynamically.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/HTML-FnContent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HTML.cs" %}
{% include code-snippet/diagram/shapes/HTML-FnContent/HTML.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="HTML.cs" %}
{% include code-snippet/diagram/shapes/HTML-FnContent/HTML.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### HTML Node With node template

To render html node with nodeTemplate we need to define the nodeTemplate in the html file and assign it to the [`nodeTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Diagram.html#Syncfusion_EJ2_Diagrams_Diagram_NodeTemplate) property of the diagram. The following code illustrates how to render html node with nodeTemplate.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/HTML-Template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HTML.cs" %}
{% include code-snippet/diagram/shapes/HTML-Template/HTML.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="HTML_Node_With_Template.cshtml" %}
{% include code-snippet/diagram/shapes/HTML-Template/HTML.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

#### Functional node template

We can define a function which returns a template string and assign it directly to the `nodeTemplate` property of diagram.

Refer the code example below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/HTML-TemplateFnNode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HTML_Node_With_Template.cshtml" %}
{% include code-snippet/diagram/shapes/HTML-TemplateFnNode/HTML-Node-With-Template.cshtml %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="HTML_Node_With_Template.cshtml" %}
{% include code-snippet/diagram/shapes/HTML-TemplateFnNode/HTML-Node-With-Template.cshtml %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Native

Diagram provides support to embed SVG element into a node. The shape property of node allows to set the type of node. To create a [`native`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html#Syncfusion_EJ2_Diagrams_Shapes_Native) node, it should be set as **native**.

N> Like HTML node, the native node also cannot be exported to image format. Fill color of native node can be overridden by the inline style or fill of the SVG element specified in the template.

### Native node with content template

To render an SVG node using a content template, define the desired template string in the node's [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNative.html#Syncfusion_EJ2_Diagrams_DiagramNative_Content) property. The following example demonstrates how to create an SVG node using a content template.

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

#### Functional content template

Dynamic SVG content generation is supported through function-based templates that return SVG markup based on runtime conditions. This approach enables responsive graphics that adapt to node properties or the application's state.

The following example demonstrates how to render an SVG node using a function and dynamically manipulate its content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/native-FnContent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Native.cs" %}
{% include code-snippet/diagram/shapes/native-FnContent/native.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Native.cs" %}
{% include code-snippet/diagram/shapes/native-FnContent/native.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Native node with node template

The [`nodeTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Diagram.html#Syncfusion_EJ2_Diagrams_Diagram_NodeTemplate) property allows defining reusable SVG templates at the diagram level. This approach is efficient when multiple nodes share similar vector graphics or when centralized template management is required.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/native-Template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Native.cs" %}
{% include code-snippet/diagram/shapes/native-Template/SVG.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Native.cs" %}
{% include code-snippet/diagram/shapes/native-Template/SVG.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

#### Functional node template

A functional `nodeTemplate` implementation provides maximum flexibility for generating SVG templates programmatically and creating dynamic content.

The following example demonstrates this approach.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/shapes/Native-TemplateFnNode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Native.cs" %}
{% include code-snippet/diagram/shapes/Native-TemplateFnNode/HTML.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Native.cs" %}
{% include code-snippet/diagram/shapes/Native-TemplateFnNode/HTML.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## SVG content alignment

Stretch and align the svg content anywhere but within the node boundary.

The scale property of the node allows to stretch the svg content as you desired (either to maintain proportion or to stretch). By default, the `scale` property of node is set as **meet**.

The following tables illustrates all the possible scale options for the node.

| Values | Images |
|-------- | -------- |
| None | ![None SVG Content Alignment](images/Native1.png) |
| Meet | ![Meet SVG Content Alignment](images/Native2.png) |
| Slice | ![Slice SVG Content Alignment](images/Native3.png) |
| Stretch |![Stretch SVG Content Alignment](images/Native4.png) |

## Basic shapes

* The [`Basic`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html#Syncfusion_EJ2_Diagrams_Shapes_Basic) shapes are common shapes that are used to represent the geometrical information visually. To create basic shapes, the type of the shape should be set as **basic**. Its shape property can be set with any one of the built-in shape.

* To render a rounded rectangle, you need to set the type as basic and shape as rectangle. Set the [`cornerRadius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramBasicShape.html#Syncfusion_EJ2_Diagrams_DiagramBasicShape_CornerRadius) property to specify the radius of rounded rectangle.

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



N> By default, the `shape` property of the node is set as **basic**.

Default property for shape is Rectangle.

N> When the `shape` is not set for a basic shape, it is considered as a **rectangle**.

The list of basic shapes are as follows.

![BasicShapes](images/Basic.png)

## Path

The [`Path`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html#Syncfusion_EJ2_Diagrams_Shapes_Path) node is a commonly used basic shape that allows visually to represent the geometrical information. To create a path node, specify the shape as **path**. The path property of node allows you to define the path to be drawn.

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

The [`flow`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Shapes.html#Syncfusion_EJ2_Diagrams_Shapes_Flow) shapes are used to represent the process flow. It is used for analyzing, designing, and managing for documentation process. To create a flow shape, specify the shape type as **flow**. Flow shapes and by default, it is considered as **process**.

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

![FlowShapes](images/FlowShapes.png)
