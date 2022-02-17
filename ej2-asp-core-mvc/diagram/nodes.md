---
layout: post
title: Nodes in ##Platform_Name## Diagram Component
description: Learn here all about Nodes in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Nodes
publishingplatform: ##Platform_Name##
documentation: ug
---


# Node

Nodes are graphical objects used to visually represent the geometrical information, process flow, internal business procedure, entity, or any other kind of data.

![Node](images/node.png)

<!-- markdownlint-disable MD033 -->

## Create node

A node can be created and added to the diagram, either programmatically or interactively. Nodes are stacked on the diagram area from bottom to top in the order they are added.

## Add node through nodes collection

To create a node, define the [`node`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html) object and add that to nodes collection of the diagram model. The following code example illustrates how to add a node to the diagram.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/node/node/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Node.cs" %}
{% include code-snippet/diagram/node/node/node.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Node.cs" %}
{% include code-snippet/diagram/node/node/node.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Add/Remove node at runtime

* Nodes can be added at runtime by using public method, add and can be removed at runtime by using public method,
remove. On adding node at runtime, the nodes collection is changed and the [`collectionChange`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Diagram.html#Syncfusion_EJ2_Diagrams_Diagram_CollectionChange) event will trigger.

* The node’s ID property is used to define the name of the node and its further used to find the node at runtime and do any customization.

The following code illustrates how to add a node.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/node/run/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Run.cs" %}
{% include code-snippet/diagram/node/run/run.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Run.cs" %}
{% include code-snippet/diagram/node/run/run.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
var node = {
    id: 'node1', offsetX = 100, offsetY = 100, height = 50, width = 100
};
diagram.add(node);
```

## Add node from palette

Nodes can be predefined and added to the palette, and can be dropped into the diagram when needed. For more information
about adding nodes from symbol palette, refer to [`Symbol Palette`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SymbolPalette.html).

* Once you drag a node/connector from the palette to the diagram, the following events can be used to do your customization.
* When a symbol is dragged into diagram from symbol palette, the [`dragEnter`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Diagram.html#Syncfusion_EJ2_Diagrams_Diagram_DragEnter) event gets triggered.
* When a symbol is dragged over diagram, the [`dragOver`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Diagram.html#Syncfusion_EJ2_Diagrams_Diagram_DragOver) event gets triggered.
* When a symbol is dragged and dropped from symbol palette to diagram area, the [`drop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Diagram.html#Syncfusion_EJ2_Diagrams_Diagram_Drop) event gets triggered.
* When a symbol is dragged outside of the diagram, the [`dragLeave`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Diagram.html#Syncfusion_EJ2_Diagrams_Diagram_DragLeave) event gets triggered.

## Create node through data source

Nodes can be generated automatically with the information provided through data source. The default properties for
these nodes are fetched from default settings. For more information about data source, refer to Data Binding.

## Draw nodes

Nodes can be interactively drawn by clicking and dragging the diagram surface by using `NodeDrawingTool`. For more
information about drawing nodes, refer to Draw Nodes.

## Position

* Position of a node is controlled by using its [`offsetX`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html#Syncfusion_EJ2_Diagrams_DiagramNode_OffsetX) and [`offsetY`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html#Syncfusion_EJ2_Diagrams_DiagramNode_OffsetY) properties. By default, these offset properties represent the distance between the origin of the diagram’s page and node’s center point.

* You may expect this offset values to represent the distance between page origin and node’s top-left corner instead of center. The Pivot property helps to solve this problem. Default value of node’s [`pivot`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html#Syncfusion_EJ2_Diagrams_DiagramNode_Pivot) point is (0.5, 0.5), that means center of the node.

* The size of the node can be controlled by using its [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html#Syncfusion_EJ2_Diagrams_DiagramNode_Width) and
[`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html#Syncfusion_EJ2_Diagrams_DiagramNode_Height) properties.

* Rotation of a node is controlled by using its [`rotateAngle`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html#Syncfusion_EJ2_Diagrams_DiagramNode_RotateAngle) property.

The following table illustrates how pivot relates offset values with node boundaries.

| Pivot | Offset |
|-------- | -------- |
| (0.5,0.5)| offsetX and offsetY values are considered as the node’s center point. |
| (0,0) | offsetX and offsetY values are considered as the top-left corner of the node. |
| (1,1) | offsetX and offsetY values are considered as the bottom-right corner of the node. |

The following code illustrates how to change the `pivot` value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/node/position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/diagram/node/position/position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Position.cs" %}
{% include code-snippet/diagram/node/position/position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Flip

The diagram Provides support to flip the node. [`flip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html#Syncfusion_EJ2_Diagrams_DiagramNode_Flip) is performed to
give the mirrored image of the original element.

The flip types are as follows:

* HorizontalFlip
 `Horizontal` is used to change the element in horizontal direction.

* VerticalFlip
`Vertical` is used to change the element in vertical direction

* Both
`Both` which involves both vertical and horizontal changes of the element.

The following code illustrates how to provide the mirror image of the original element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/node/flip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Flip.cs" %}
{% include code-snippet/diagram/node/flip/flip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Flip.cs" %}
{% include code-snippet/diagram/node/flip/flip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The flip is also applicable for group and BPMN shapes.

## Appearance

* The appearance of a node can be customized by changing its [`fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_Fill) color, [`borderColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeColor), [`borderWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeWidth), [`strokeDashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeDashArray),
[`opacity`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_Opacity), and [`shadow`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html).

* The [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html#Syncfusion_EJ2_Diagrams_DiagramNode_Visible) property of the node enables or disables the visibility of the node.

The following code illustrates how to customize the appearance of the shape.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/node/appear/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Appear.cs" %}
{% include code-snippet/diagram/node/appear/appear.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Appear.cs" %}
{% include code-snippet/diagram/node/appear/appear.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Gradient

The [`gradient`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_Gradient) property of the node allows you to define and apply the gradient effect to that node.

The gradient stop property defines the color and a position, where the previous color transition ends and a new color transition starts.

The gradient stop’s opacity property defines the transparency level of the region.

There are two types of gradients as follows:

* Linear gradient

* Radial gradient

## Linear gradient

* [`LinearGradient`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.GradientType.html) defines a smooth transition between a set of colors (so-called stops) on a line.

* A linear gradient’s x1, y1, x2, y2 properties are used to define the position (relative to the node) of the rectangular region that needs to be painted.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/node/linearGrad/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LinearGrad.cs" %}
{% include code-snippet/diagram/node/linearGrad/linearGrad.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="LinearGrad.cs" %}
{% include code-snippet/diagram/node/linearGrad/linearGrad.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Radial gradient

* [`RadialGradient`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.GradientType.html) defines a smooth transition between stops on a circle.

* A radial gradient’s cx, cy, fx, fy properties are used to define the position (relative to the node) of the outermost or the innermost circle of the radial gradient.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/node/radialGrad/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RadialGrad.cs" %}
{% include code-snippet/diagram/node/radialGrad/radialGrad.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="RadialGrad.cs" %}
{% include code-snippet/diagram/node/radialGrad/radialGrad.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Shadow

Diagram provides support to add [`shadow`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html#Syncfusion_EJ2_Diagrams_DiagramNode_Shadow) effect to a node that is disabled, by default. It can be enabled with the
constraints property of the node. The following code illustrates how to drop shadow.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/node/shadow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Shadow.cs" %}
{% include code-snippet/diagram/node/shadow/shadow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Shadow.cs" %}
{% include code-snippet/diagram/node/shadow/shadow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing shadow

The angle, distance, and opacity of the shadow can be customized with the shadow property of the node. The following code
example illustrates how to customize shadow.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/node/shadow2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Shadow2.cs" %}
{% include code-snippet/diagram/node/shadow2/shadow2.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Shadow2.cs" %}
{% include code-snippet/diagram/node/shadow2/shadow2.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Icon

Diagram provides support to describe the state of the node. i.e., the node is expanded or collapsed state.

> Icon can be created only when the node has outEdges.

* To explore the properties of expand and collapse icon, refer to [`expandIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html#Syncfusion_EJ2_Diagrams_DiagramNode_ExpandIcon) and [`collapseIcon`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html#Syncfusion_EJ2_Diagrams_DiagramNode_CollapseIcon).

* The expandIcon’s and collapseIcon’s shape properties allow to define the shape of the icon.

The following code example illustrates how to create an icon of various shapes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/node/icon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Icon.cs" %}
{% include code-snippet/diagram/node/icon/icon.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Icon.cs" %}
{% include code-snippet/diagram/node/icon/icon.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customizing expand icon

* Set the borderColor, borderWidth, and background color for an expandIcon using borderColor, borderWidth, and fill properties.

* Set a size for an expandIcon by using width and height properties.

* The expand icon can be aligned relative to the node boundaries. It has margin, offset, horizontalAlignment, and verticalAlignment settings. It is quite tricky, when all four alignments are used together but gives you more control over alignment.

## Customizing collapse icon

* Set the [`borderColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramIconShape.html#Syncfusion_EJ2_Diagrams_DiagramIconShape_BorderColor),
[`borderWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramIconShape.html#Syncfusion_EJ2_Diagrams_DiagramIconShape_BorderWidth), background color for an collapseIcon using borderColor, borderWidth, and [`fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramIconShape.html#Syncfusion_EJ2_Diagrams_DiagramIconShape_Fill) properties.

* Set a size for collapseIcon by using [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramIconShape.html#Syncfusion_EJ2_Diagrams_DiagramIconShape_Width) and
[`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramIconShape.html#Syncfusion_EJ2_Diagrams_DiagramIconShape_Height) properties.

* Like expand icon, collapse icon also can be aligned relative to the node boundaries. It has margin, offset, horizontalAlignment, and verticalAlignment settings. It is quite tricky, when all four alignments are used together but gives you more control over alignment.

## Interaction

Diagram provides support to drag, resize, or rotate the node interactively. For more information about editing a node at runtime, refer to Edit Nodes.

## Constraints

The constraints property of the node allows you to enable/disable certain features. For more information about node constraints, refer to [`Node Constraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html#Syncfusion_EJ2_Diagrams_DiagramNode_Constraints).

## Custom properties

The [`addInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramNode.html#Syncfusion_EJ2_Diagrams_DiagramNode_AddInfo) property of the node allows to maintain additional information to the node.

## Stack order

The nodes z-order property specifies the stack order of the node. A node with greater stack order is always in front of a node with a lower stack order.

## Data flow

Node has the InEdges and OutEdges read-only property. In this property, you can find what are all the connectors that are connected to the node, and then you can find these connectors by using the [`getObject`](../api/diagram#getObject) method in the diagram.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/node/dataflow/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dataflow.cs" %}
{% include code-snippet/diagram/node/dataflow/dataflow.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Dataflow.cs" %}
{% include code-snippet/diagram/node/dataflow/dataflow.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to add annotations to the node](./labels)
* [How to add ports to the node](./ports)
* [How to enable/disable the behavior of the node](./constraints)
* [How to add nodes to the symbol palette](./symbol-palette)
* [How to edit the node visual interface](./interaction#selection)
* [How to create diagram nodes using drawing tools](./tools)