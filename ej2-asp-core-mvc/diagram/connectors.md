---
layout: post
title: Connectors in ##Platform_Name## Diagram Component
description: Learn here all about Connectors in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Connectors
publishingplatform: ##Platform_Name##
documentation: ug
---


# Connector

Connectors are objects used to create link between two points, nodes or ports to represent the relationships between them.

## Create connector

Connector can be created by defining the source and target point of the connector. The path to be drawn can be defined with a collection of segments. To explore the properties of a [`connector`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html), refer to [`Connector Properties`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html).

## Add connectors through connectors collection

The [`sourcePoint`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_SourcePoint) and [`targetPoint`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_TargetPoint) properties of connector allow you to define the end points of a connector.

The following code example illustrates how to add a connector through connector collection.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/diagram/connectors/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/diagram/connectors/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Add connector at runtime

Connectors can be added at runtime by using public method, `diagram.add` and can be removed at runtime by using public method, `diagram.remove`.

The following code example illustrates how to add connector at runtime.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/diagram/connectors/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/diagram/connectors/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var connectors = {
    id: "connector2",
    style: {
        strokeColor: '#6BA5D7',
        fill: '#6BA5D7',
        strokeWidth: 2
    },
    targetDecorator: {
        style: {
            fill: '#6BA5D7',
            strokeColor: '#6BA5D7'
        }
    },
    sourcePoint: {
        x: 300,
        y: 100
    },
    targetPoint: {
        x: 400,
        y: 200
    }
}

var diagram = document.getElementById("container").ej2_instances[0];
// Adds to the Diagram
diagram.add(connectors)
// Remove from the diagram
diagram.remove(connectors)

```

## Connectors from palette

Connectors can be predefined and added to the symbol palette. You can drop those connectors into the diagram, when required.

For more information about adding connectors from symbol palette, refer to `Symbol Palette`.

## Draw connectors

Connectors can be interactively drawn by clicking and dragging on the diagram surface by using `drawingObject`.

For more information about drawing connectors, refer to [`Draw Connectors`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.Diagram.html#Syncfusion_EJ2_Diagrams_Diagram_DrawingObject).

## Update connector at runtime

Various connector properties such as `sourcePoint`, `targetPoint`, `style`, `sourcePortID`, `targetPortID`, etc., can be updated at the runtime.

The following code example illustrates how to update a connector's source point, target point, styles properties at runtime.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/diagram/connectors/default/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/diagram/connectors/default/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagram = document.getElementById("container").ej2_instances[0];
// Update the connector properties at the run time
diagram.connectors[0].style.strokeColor = '#6BA5D7';
diagram.connectors[0].style.fill = '#6BA5D7';
diagram.connectors[0].style.strokeWidth = 2;
diagram.connectors[0].targetDecorator.style.fill = '#6BA5D7';
diagram.connectors[0].targetDecorator.style.strokeColor = '#6BA5D7';
diagram.connectors[0].sourcePoint.x = 150;
diagram.connectors[0].targetPoint.x = 150;
diagram.dataBind();

```

## Connect nodes

* The [`sourceID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_SourceID) and [`targetID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_TargetID) properties allow to define the nodes to be connected.

* The following code example illustrates how to connect two nodes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/connect/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Connect.cs" %}
{% include code-snippet/diagram/connectors/connect/connect.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Connect.cs" %}
{% include code-snippet/diagram/connectors/connect/connect.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



* When you remove NodeConstraints InConnect from Default, the node accepts only an outgoing connection to dock in it. Similarly, when you remove NodeConstraints OutConnect from Default, the node accepts only an incoming connection to dock in it.

* When you remove both InConnect and OutConnect NodeConstraints from Default, the node restricts connector to establish connection in it.

* The following code illustrates how to disable InConnect constraints.

```javascript

node.constraints =  NodeConstraints.Default & ~NodeConstraints.InConnect,

```

## Connections with ports

The [`sourcePortID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_SourcePortID) and [`targetPortID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_TargetPortID) properties allow to create connections between some specific points of source/target nodes.
The following code example illustrates how to create port to port connections.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/ports/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ports.cs" %}
{% include code-snippet/diagram/connectors/ports/ports.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Ports.cs" %}
{% include code-snippet/diagram/connectors/ports/ports.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Similarly, the `sourcePortID` or `targetPortID` can be changed at the runtime by changing the port [`sourcePortID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_SourcePortID) or [`targetPortID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_TargetPortID).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/ports/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Ports.cs" %}
{% include code-snippet/diagram/connectors/ports/ports.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Ports.cs" %}
{% include code-snippet/diagram/connectors/ports/ports.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
var diagram = document.getElementById("container").ej2_instances[0];
diagram.appendTo('#element');
// Update the target portID at the run time
diagram.connectors[0].targetPortID = 'newnodeport1'

```

* When you set PortConstraints to InConnect, the port accepts only an incoming connection to dock in it. Similarly, when you set PortConstraints to OutConnect, the port accepts only an outgoing connection to dock in it.
* When you set PortConstraints to None, the port restricts connector to establish connection in it.

```javascript

port.constraints =  PortConstraints.InConnect,

```

## Segments

The path of the connector is defined with a collection of segments. There are three types of segments.

## Straight

To create a straight line, specify the [`type`](https://ej2.syncfusion.com/documentation/api/diagram/segments/) of the segment as **straight** and add a straight segment to [`segments`](https://ej2.syncfusion.com/documentation/api/diagram/connector/#segments) collection and need to specify [`type`](https://ej2.syncfusion.com/documentation/api/diagram/connector/#type-Segments) for the connector. The following code example illustrates how to create a default straight segment.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/segment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Segment.cs" %}
{% include code-snippet/diagram/connectors/segment/segment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/segment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Segment.cs" %}
{% include code-snippet/diagram/connectors/segment/segment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The [`point`](https://ej2.syncfusion.com/documentation/api/diagram/straightSegment/#point-PointModel) property of straight segment allows you to define the end point of it. The following code example illustrates how to define the end point of a straight segment.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/segment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Segment.cs" %}
{% include code-snippet/diagram/connectors/segment/segment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/segment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Segment.cs" %}
{% include code-snippet/diagram/connectors/segment/segment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Orthogonal

Orthogonal segments is used to create segments that are perpendicular to each other.

Set the segment [`type`](https://ej2.syncfusion.com/documentation/api/diagram/segments/) as orthogonal to create a default orthogonal segment and need to specify [`type`](https://ej2.syncfusion.com/documentation/api/diagram/connector/#segments). The following code example illustrates how to create a default orthogonal segment.

Multiple segments can be defined one after another. To create a connector with multiple segments, define and add the segments to [`connector.segments`](https://ej2.syncfusion.com/documentation/api/diagram/connector/#segments) collection. The following code example illustrates how to create a connector with multiple segments.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/orthogonal/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Orthogonal.cs" %}
{% include code-snippet/diagram/connectors/orthogonal/orthogonal.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Orthogonal.cs" %}
{% include code-snippet/diagram/connectors/orthogonal/orthogonal.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The [`length`](https://ej2.syncfusion.com/documentation/api/diagram/orthogonalSegment/#length) and [`direction`](https://ej2.syncfusion.com/documentation/api/diagram/orthogonalSegment/) properties allow to define the flow and length of segment. The following code example illustrates how to create customized orthogonal segments.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/direction/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Direction.cs" %}
{% include code-snippet/diagram/connectors/direction/direction.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Direction.cs" %}
{% include code-snippet/diagram/connectors/direction/direction.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You need to mention the segment type as same as what you mentioned in connector type. There should be no contradiction between connector type and segment type.

## Avoid overlapping

Orthogonal segments are automatically re-routed, in order to avoid overlapping with the source and target nodes. The following preview illustrates how orthogonal segments are re-routed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/overlapping/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Overlapping.cs" %}
{% include code-snippet/diagram/connectors/overlapping/overlapping.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Overlapping.cs" %}
{% include code-snippet/diagram/connectors/overlapping/overlapping.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Bezier

Bezier segments are used to create curve segments and the curves are configurable either with the control points or with vectors.

To create a bezier segment, the [`segment.type`](https://ej2.syncfusion.com/documentation/api/diagram/segments/) is set as `bezier` and need to specify [`type`](https://ej2.syncfusion.com/documentation/api/diagram/connector/#type-Segments) for the connector. The following code example illustrates how to create a default bezier segment.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/vector/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Vector.cs" %}
{% include code-snippet/diagram/connectors/vector/vector.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Vector.cs" %}
{% include code-snippet/diagram/connectors/vector/vector.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The [`point1`](https://ej2.syncfusion.com/documentation/api/diagram/bezierSegment/#point1) and [`point2`](https://ej2.syncfusion.com/documentation/api/diagram/bezierSegment/#point2) properties of bezier segment enable you to set the control points. The following code example illustrates how to configure the bezier segments with control points.

The [`vector1`](https://ej2.syncfusion.com/documentation/api/diagram/bezierSegment/#vector1) and [`vector2`](https://ej2.syncfusion.com/documentation/api/diagram/bezierSegment/#vector2) properties of bezier segment enable you to define the vectors. The following code illustrates how to configure a bezier curve with vectors.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/points/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Points.cs" %}
{% include code-snippet/diagram/connectors/points/points.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Points.cs" %}
{% include code-snippet/diagram/connectors/points/points.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Decorator

* Starting and ending points of a connector can be decorated with some customizable shapes like arrows, circles, diamond, or path. The connection end points can be decorated with the [`sourceDecorator`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_SourceDecorator) and [`targetDecorator`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_TargetDecorator) properties of the connector.

* The [`shape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDecorator.html#Syncfusion_EJ2_Diagrams_DiagramDecorator_Shape) property of `sourceDecorator` allows to define the shape of the decorators. Similarly, the [shape](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDecorator.html#Syncfusion_EJ2_Diagrams_DiagramDecorator_Shape) property of `targetDecorator` allows to define the shape of the decorators.

* To create custom shape for source decorator, use [`pathData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDecorator.html#Syncfusion_EJ2_Diagrams_DiagramDecorator_PathData) property. Similarly, to create custom shape for target decorator, use [`pathData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDecorator.html#Syncfusion_EJ2_Diagrams_DiagramDecorator_PathData) property.

* The following code example illustrates how to create decorators of various shapes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/srcdecorator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Srcdecorator.cs" %}
{% include code-snippet/diagram/connectors/srcdecorator/srcdecorator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Srcdecorator.cs" %}
{% include code-snippet/diagram/connectors/srcdecorator/srcdecorator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Padding

Padding is used to leave the space between the Connector's end point and the object to where it is connected.

* The [`sourcePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_SourcePadding) property of connector defines space between the source point and the source node of the connector.

* The [`targetPadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_TargetPadding) property of connector defines space between the end point and the target node of the connector.

* The following code example illustrates how to leave space between the connection end points and source and target nodes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/padding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Padding.cs" %}
{% include code-snippet/diagram/connectors/padding/padding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Padding.cs" %}
{% include code-snippet/diagram/connectors/padding/padding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Flip

The diagram Provides support to flip the connector. The [`flip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_Flip) is performed to give the mirrored image of the original element.

The flip types are as follows:

* HorizontalFlip
 `Horizontal` is used to interchange the connector source and target x points.

* VerticalFlip
`Vertical` is used to interchange the connector source and target y points.

* Both
`Both` is used to interchange the source point as target point and target point as source point

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/flip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Flip.cs" %}
{% include code-snippet/diagram/connectors/flip/flip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Flip.cs" %}
{% include code-snippet/diagram/connectors/flip/flip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



 > The flip is not applicable when the connectors connect in nodes.

## Bridging

Line bridging creates a bridge for lines to smartly cross over the other lines, at points of intersection. By default, [`bridgeDirection`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.BridgeDirection.html) is set to top. Depending upon the direction given bridging direction appears.
Bridging can be enabled/disabled either with the `connector.constraints` or `diagram.constraints`. The following code example illustrates how to enable line bridging.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/bridging/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bridging.cs" %}
{% include code-snippet/diagram/connectors/bridging/bridging.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Bridging.cs" %}
{% include code-snippet/diagram/connectors/bridging/bridging.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You need to inject connector bridging module into the diagram.

The [`bridgeSpace`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_BridgeSpace) property of connectors can be used to define the width for line bridging.

Limitation: Bezier segments do not support bridging.

## Corner radius

Corner radius allows to create connectors with rounded corners. The radius of the rounded corner is set with the [`cornerRadius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_CornerRadius) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/cornerradius/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Cornerradius.cs" %}
{% include code-snippet/diagram/connectors/cornerradius/cornerradius.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Cornerradius.cs" %}
{% include code-snippet/diagram/connectors/cornerradius/cornerradius.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Appearance

* The connector’s [`strokeWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramStrokeStyle.html#Syncfusion_EJ2_Diagrams_DiagramStrokeStyle_StrokeWidth), [`strokeColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramStrokeStyle.html#Syncfusion_EJ2_Diagrams_DiagramStrokeStyle_StrokeColor), [`strokeDashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramStrokeStyle.html#Syncfusion_EJ2_Diagrams_DiagramStrokeStyle_StrokeDashArray), and [`opacity`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramStrokeStyle.html#Syncfusion_EJ2_Diagrams_DiagramStrokeStyle_Opacity) properties are used to customize the appearance of the connector segments.

* The [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_Visible) property of the connector enables or disables the visibility of connector.

* Default values for all the `connectors` can be set using the `getConnectorDefaults` properties. For example, if all connectors have the same type or having the same property then such properties can be moved into `getConnectorDefaults`.

## Segment appearance

The following code example illustrates how to customize the segment appearance.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/style/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Style.cs" %}
{% include code-snippet/diagram/connectors/style/style.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Style.cs" %}
{% include code-snippet/diagram/connectors/style/style.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Decorator appearance

* The source decorator’s [`strokeColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeColor), [`strokeWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeWidth), and [`strokeDashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeDashArray) properties are used to customize the color, width, and appearance of the decorator.

* To set the border stroke color, stroke width, and stroke dash array for the target decorator, use [`strokeColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeColor), [`strokeWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeWidth), and [`strokeDashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeDashArray).

* To set the size for source and target decorator, use width and height property.

The following code example illustrates how to customize the appearance of the decorator.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/decorator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Decorator.cs" %}
{% include code-snippet/diagram/connectors/decorator/decorator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Decorator.cs" %}
{% include code-snippet/diagram/connectors/decorator/decorator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Interaction

* Diagram allows to edit the connectors at runtime. To edit the connector segments at runtime, refer to [`Connection Editing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.html).

## Automatic line routing

Diagram provides additional flexibility to re-route the diagram connectors. A connector will frequently re-route itself when a shape moves next to it. The following screenshot illustrates how the connector automatically re-routes the segments.

* The line routing constraints must be included to the default diagram constraints to enable automatic line routing support like below.

* The following code block shows how to create the diagram with specifying nodes, connectors, constraints, and necessary modules for line routing.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/linerouting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Linerouting.cs" %}
{% include code-snippet/diagram/connectors/linerouting/linerouting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/linerouting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Linerouting.cs" %}
{% include code-snippet/diagram/connectors/linerouting/linerouting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



* In some situations, automatic line routing enabled diagram needs to ignore a specific connector from automatic line routing. So, in this case, auto routing feature can be disabled to the specific connector using the [`constraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.ConnectorConstraints.html) property of the connector like the following code snippet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/linerouting1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Linerouting1.cs" %}
{% include code-snippet/diagram/connectors/linerouting1/linerouting1.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/linerouting1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Linerouting1.cs" %}
{% include code-snippet/diagram/connectors/linerouting1/linerouting1.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Constraints

* The [`constraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.ConnectorConstraints.html) property of connector allows to enable/disable certain features of connectors.

* To enable or disable the constraints, refer [`constraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.ConnectorConstraints.html).

The following code illustrates how to disable selection.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/constraints/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Constraints.cs" %}
{% include code-snippet/diagram/connectors/constraints/constraints.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Constraints.cs" %}
{% include code-snippet/diagram/connectors/constraints/constraints.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom properties

* The [`addInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_AddInfo) property of connectors allow you to maintain additional information to the connectors.

```javascript

var connectors = {
    id: 'connector1',
    // Defines the information about the connector
    addInfo:'centralconnector',
    type: 'Straight',
    sourceID: 'Transaction',
    targetID: 'Verification'
};

```

## Stack order

The connectors [`zIndex`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_ZIndex) property specifies the stack order of the connector. A connector with greater stack order is always in front of a connector with a lower stack order.

The following code illustrates how to render connector based on the stack order.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/connectors/zindex/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Zindex.cs" %}
{% include code-snippet/diagram/connectors/zindex/zindex.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Zindex.cs" %}
{% include code-snippet/diagram/connectors/zindex/zindex.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to add annotations to the connector](./labels)
* [How to enable/disable the behavior of the node](./constraints)
* [How to add connectors to the symbol palette](./symbol-palette)
* [How to perform the interaction on the connector](./interaction)
* [How to create diagram connectors using drawing tools](./tools#tools)
