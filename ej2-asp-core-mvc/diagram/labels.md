---
layout: post
title: Labels in ##Platform_Name## Diagram Component
description: Learn here all about Labels in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Labels
publishingplatform: ##Platform_Name##
documentation: ug
---


# Annotation

[`Annotation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNodeAnnotation.html) is a block of text that can be displayed over a node or connector. Annotation is used to textually represent an object with a string that can be edited at runtime. Multiple annotations can be added to a node/connector.

<!-- markdownlint-disable MD033 -->

## Create annotation

An annotation can be added to a node/connector by defining the annotation object and adding that to the annotation collection of the node/connector. The [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNodeAnnotation.html#Syncfusion_EJ2_Diagrams_DiagramNodeAnnotation_Content) property of annotation defines the text to be displayed. The following code illustrates how to create a annotation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/annotationRender/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/annotationRender/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/annotationRender/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/annotationRender/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Add annotations at runtime

* Annotations can be added at runtime by using the client-side method [`addLabels`](../api/diagram/#addLabels). The following code illustrates how to add a annotation to a node.

* The annotation's [`ID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNodeAnnotation.html#Syncfusion_EJ2_Diagrams_DiagramNodeAnnotation_Id) property is used to define the name of the annotation and its further used to find the annotation at runtime and do any customization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/updateAnnotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/updateAnnotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/updateAnnotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/updateAnnotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
var diagramElement = document.getElementById('element');
var diagram = diagramElement.ej2_instances[0];
var annotation = [{
    id: 'label1',
    //set the contect
    content: 'Annotation'
}]
//Method to add labels at run time
diagram.addLabels(diagram.nodes[0], annotation);
diagram.dataBind();

```

## Remove annotation

A collection of annotations can be removed from the node by using client-side method [`removeLabels`](../api/diagram/#removeLabels). The following code illustrates how to remove a annotation to a node.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/updateAnnotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/updateAnnotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/updateAnnotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/updateAnnotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagramElement = document.getElementById('element');
var diagram = diagramElement.ej2_instances[0];
var annotation = [{
    id: 'label1',
    content: 'Annotation'
}]
//Method to remove labels at runtime
diagram.removeLabels(diagram.nodes[0], annotation);

```

## Update annotation at runtime

You can change any annotation properties at runtime and update it through the client-side method [`dataBind`](../api/diagram/#dataBind).

The following code example illustrates how to change the annotation properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/updateAnnotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/updateAnnotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/updateAnnotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/updateAnnotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
var diagramElement = document.getElementById('element');
var diagram = diagramElement.ej2_instances[0];

diagram.nodes[0].annotations[0].content = 'Updated Annotation';
//Method to update the annotation at run time
diagram.dataBind();

```

## Alignment

Annotation can be aligned relative to the node boundaries. It has [`margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNodeAnnotation.html#Syncfusion_EJ2_Diagrams_DiagramNodeAnnotation_Margin), [`offset`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNodeAnnotation.html#Syncfusion_EJ2_Diagrams_DiagramNodeAnnotation_Offset), horizontal, and vertical alignment settings. It is quite tricky when all four alignments are used together but gives more control over alignment.

## Offset

The offset property of annotation is used to align the annotations based on fractions. 0 represents top/left corner, 1 represents bottom/right corner, and 0.5 represents half of width/height.

Set the size for a nodes annotation by using [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNodeAnnotation.html#Syncfusion_EJ2_Diagrams_DiagramNodeAnnotation_Width) and
[`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNodeAnnotation.html#Syncfusion_EJ2_Diagrams_DiagramNodeAnnotation_Height) properties.

The following code shows the relationship between the annotation position (black color circle) and offset (fraction values).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/annotationOffset/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/annotationOffset/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/annotationOffset/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/annotationOffset/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Horizontal and vertical alignment

The [`horizontalAlignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNodeAnnotation.html#Syncfusion_EJ2_Diagrams_DiagramNodeAnnotation_HorizontalAlignment) property of annotation is used to set how the annotation is horizontally aligned at the annotation position determined from the fraction values. The [`verticalAlignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNodeAnnotation.html#Syncfusion_EJ2_Diagrams_DiagramNodeAnnotation_VerticalAlignment) property is used to set how annotation is vertically aligned at the annotation position.

The following tables illustrates all the possible alignments visually with 'offset (0, 0)'.

| Horizontal Alignment | Vertical Alignment | Output with Offset(0,0) |
| -------- | -------- | -------- |
| Left | Top | ![Left Top Label Alignment](images/Label1.png) |
| Center | Top | ![Center Top Label Alignment](images/Label2.png) |
| Right | Top |  ![Right Top Label Alignment](images/Label3.png) |
| Left | Center | ![Left Center Label Alignment](images/Label4.png) |
| Center | Center| ![Center Center Label Alignment](images/Label5.png) |
| Right | Center | ![Right Center Label Alignment](images/Label6.png) |
| Left | Bottom | ![Left Bottom Label Alignment](images/Label7.png) |
| Center | Bottom | ![Center Bottom Label Alignment](images/Label8.png) |
| Right |Bottom |![Right Bottom Label Alignment](images/Label9.png) |

The following codes illustrates how to align annotations.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/HVAlignAnnotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/HVAlignAnnotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/HVAlignAnnotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/HVAlignAnnotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Annotation alignment with respect to segments

The offset and alignment properties of annotation allows you to align the connector annotations with respect to the segments.

The following code example illustrates how to align connector annotations.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/annotationSegment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/annotationSegment/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/annotationSegment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/annotationSegment/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Margin

[`Margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNodeAnnotation.html#Syncfusion_EJ2_Diagrams_DiagramNodeAnnotation_Margin) is an absolute value used to add some blank space in any one of its four sides. The annotations can be displaced with the margin property.
The following code example illustrates how to align a annotation based on its `offset`, `horizontalAlignment`, `verticalAlignment`, and `margin` values.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/annotationMargin/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/annotationMargin/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/annotationMargin/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/annotationMargin/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Text align

The [`textAlign`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramTextStyle.html#Syncfusion_EJ2_Diagrams_DiagramTextStyle_TextAlign) property of annotation allows you to set how the text should be aligned (left, right, center, or justify) inside the text block. The following codes illustrate how to set textAlign for an annotation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/annotationTextAlign/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/annotationTextAlign/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/annotationTextAlign/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/annotationTextAlign/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Hyperlink

Diagram provides a support to add a [`hyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNodeAnnotation.html#Syncfusion_EJ2_Diagrams_DiagramNodeAnnotation_Hyperlink) for the nodes/connectors annotation. It can also be customized.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/hyperLink/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HyperLink.cs" %}
{% include code-snippet/diagram/annotation/hyperLink/hyperLink.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/hyperLink/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HyperLink.cs" %}
{% include code-snippet/diagram/annotation/hyperLink/hyperLink.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Template Support for Annotation

Diagram provides template support for annotation. you should define a SVG/HTML content as string in the annotation's [`template`](https://ej2.syncfusion.com/documentation/api/diagram/annotationModel#template) property.

The following code illustrates how to define a template in node's annotation. similarly, you can define it in connectors.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/labelTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LabelTemplate.cs" %}
{% include code-snippet/diagram/annotation/labelTemplate/labelTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/labelTemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LabelTemplate.cs" %}
{% include code-snippet/diagram/annotation/labelTemplate/labelTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Wrapping

When text overflows node boundaries, you can control it by using [`text wrapping`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramTextStyle.html#Syncfusion_EJ2_Diagrams_DiagramTextStyle_TextWrapping). So, it is wrapped into multiple lines. The wrapping property of annotation defines how the text should be wrapped. The following code illustrates how to wrap a text in a node.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/textWrapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/textWrapping/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/textWrapping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/textWrapping/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



| No Wrap | Text will not be wrapped. | ![Label No Wrap](images/Wrap1.png) |
| Wrap | Text-wrapping occurs, when the text overflows beyond the available node width. | ![Label Wrap](images/Wrap2.png) |
| WrapWithOverflow (Default) | Text-wrapping occurs, when the text overflows beyond the available node width. However, the text may overflow beyond the node width in the case of a very long word. | ![Label WrapWith Overflow](images/Wrap3.png) |

## Text overflow

The label’s [`TextOverflow`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramTextStyle.html#Syncfusion_EJ2_Diagrams_DiagramTextStyle_TextOverflow) property is used control whether to display the overflowed content in node or not.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/textOverFlow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/textOverFlow/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/textOverFlow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/textOverFlow/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Appearance

* You can change the font style of the annotations with the font specific properties (fontSize, fontFamily, color). The following code illustrates how to customize the appearance of the annotation.

* The label’s [`bold`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramTextStyle.html#Syncfusion_EJ2_Diagrams_DiagramTextStyle_Bold), [`italic`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramTextStyle.html#Syncfusion_EJ2_Diagrams_DiagramTextStyle_Italic), and [`textDecoration`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramTextStyle.html#Syncfusion_EJ2_Diagrams_DiagramTextStyle_TextDecoration) properties are used to style the label’s text.

* The label’s [`fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramTextStyle.html#Syncfusion_EJ2_Diagrams_DiagramTextStyle_Fill), [`strokeColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramTextStyle.html#Syncfusion_EJ2_Diagrams_DiagramTextStyle_StrokeColor), and [`strokeWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramTextStyle.html#Syncfusion_EJ2_Diagrams_DiagramTextStyle_StrokeWidth) properties are used to define the background color and border color of the annotation and the [`opacity`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramTextStyle.html#Syncfusion_EJ2_Diagrams_DiagramTextStyle_Opacity) property is used to define the transparency of the annotations.

* The [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNodeAnnotation.html#Syncfusion_EJ2_Diagrams_DiagramNodeAnnotation_Visibility) property of the annotation enables or disables the visibility of annotation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/appearance/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/appearance/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/appearance/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/appearance/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The fill, border, and opacity appearances of the text can also be customized with appearance specific properties of annotation. The following code illustrates how to customize background, opacity, and border of the annotation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/appearanceStyle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/appearanceStyle/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/appearanceStyle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/appearanceStyle/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Interaction

Diagram allows annotation to be interacted by selecting, dragging, rotating, and resizing. Annotation interaction is disabled, by default. You can enable annotation interaction with the [`constraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.AnnotationConstraints.html)  property of annotation. You can also curtail the services of interaction by enabling either selecting, dragging, rotating, or resizing individually with the respective constraints property of annotation. The following code illustrates how to enable annotation interaction.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/appearanceStyle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/appearanceStyle/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/appearanceStyle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/appearanceStyle/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Edit

Diagram provides support to edit an annotation at runtime, either programmatically or interactively. By default, annotation is in view mode. But it can be brought to edit mode in two ways;

* Programmatically
By using [`startTextEdit`](../api/diagram/#startTextEdit) method, edit the text through programmatically.

* Interactively
    1. By double-clicking the annotation.
    2. By selecting the item and pressing the F2 key.

Double-clicking any annotation will enables editing and the node enables first annotation editing. When the focus of editor is lost, the annotation for the node is updated.
When you double-click on the node/connector/diagram model, the [`doubleClick`](../api/diagram/#doubleClick--emittypeidoubleClickeventargs) event gets triggered.

## Read-only annotations

Diagram allows to create read-only annotations. You have to set the read-only property of annotation to enable/disable the read-only [`constraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.AnnotationConstraints.html). The following code illustrates how to enable read-only mode.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/readOnly/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/readOnly/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/readOnly/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/readOnly/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Drag Limit

* The diagram control now supports defining the [`dragLimit`](https://ej2.syncfusion.com/documentation/api/diagram/annotationModel#draglimit) to the label while dragging from the connector and also update the position to the nearest segment offset.

* You can set the value to dragLimit [`left`](https://ej2.syncfusion.com/documentation/api/diagram/marginModel#left), [`right`](https://ej2.syncfusion.com/documentation/api/diagram/marginModel#right), [`top`](https://ej2.syncfusion.com/documentation/api/diagram/marginModel#top), and [`bottom`](https://ej2.syncfusion.com/documentation/api/diagram/marginModel#bottom) properties which allow the dragging of connector labels to a certain limit based on the user defined values.

* By default, drag limit will be disabled for the connector. It can be enabled by setting connector constraints as drag.

* The following code illustrates how to set a dragLimit for connector annotations.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/dragLimit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DragLimit.cs" %}
{% include code-snippet/diagram/annotation/dragLimit/dragLimit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/dragLimit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DragLimit.cs" %}
{% include code-snippet/diagram/annotation/dragLimit/dragLimit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple annotations

You can add any number of annotations to a node or connector. The following code illustrates how to add multiple annotations to a node.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/multiAnnotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/multiAnnotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/annotation/multiAnnotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/diagram/annotation/multiAnnotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Constraints

The constraints property of annotation allows you to enable/disable certain annotation behaviours. For instance, you can disable annotation editing.