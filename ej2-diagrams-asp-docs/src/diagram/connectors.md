---
title: "Connector"
component: "Diagram"
description: "Diagram connector allows you to draw a line to connect two points, nodes or ports."
---

# Connector

Connectors are objects used to create link between two points, nodes or ports to represent the relationships between them.

## Create connector

Connector can be created by defining the source and target point of the connector. The path to be drawn can be defined with a collection of segments. To explore the properties of a [`connector`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html), refer to [`Connector Properties`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html).

## Add connectors through connectors collection

The [`sourcePoint`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_SourcePoint) and [`targetPoint`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_TargetPoint) properties of connector allow you to define the end points of a connector.

The following code example illustrates how to add a connector through connector collection.

{% aspTab template="diagram/connectors/default", sourceFiles="default.cs" %}

{% endaspTab %}

## Add connector at runtime

Connectors can be added at runtime by using public method, `diagram.add` and can be removed at runtime by using public method, `diagram.remove`.

The following code example illustrates how to add connector at runtime.

{% aspTab template="diagram/connectors/default", sourceFiles="default.cs" %}

{% endaspTab %}

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

{% aspTab template="diagram/connectors/default", sourceFiles="default.cs" %}

{% endaspTab %}

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

{% aspTab template="diagram/connectors/connect", sourceFiles="connect.cs" %}

{% endaspTab %}

* When you remove NodeConstraints InConnect from Default, the node accepts only an outgoing connection to dock in it. Similarly, when you remove NodeConstraints OutConnect from Default, the node accepts only an incoming connection to dock in it.

* When you remove both InConnect and OutConnect NodeConstraints from Default, the node restricts connector to establish connection in it.

* The following code illustrates how to disable InConnect constraints.

```javascript

node.constraints =  NodeConstraints.Default & ~NodeConstraints.InConnect,

```

## Connections with ports

The [`sourcePortID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_SourcePortID) and [`targetPortID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_TargetPortID) properties allow to create connections between some specific points of source/target nodes.
The following code example illustrates how to create port to port connections.

{% aspTab template="diagram/connectors/ports", sourceFiles="ports.cs" %}

{% endaspTab %}

Similarly, the `sourcePortID` or `targetPortID` can be changed at the runtime by changing the port [`sourcePortID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_SourcePortID) or [`targetPortID`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_TargetPortID).

{% aspTab template="diagram/connectors/ports", sourceFiles="ports.cs" %}

{% endaspTab %}

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

{% aspTab template="diagram/connectors/segments", sourceFiles="segments.cs" %}

{% endaspTab %}

The [`point`](https://ej2.syncfusion.com/documentation/api/diagram/straightSegment/#point-PointModel) property of straight segment allows you to define the end point of it. The following code example illustrates how to define the end point of a straight segment.

{% aspTab template="diagram/connectors/segments", sourceFiles="segments.cs" %}

{% endaspTab %}

## Orthogonal

Orthogonal segments is used to create segments that are perpendicular to each other.

Set the segment [`type`](https://ej2.syncfusion.com/documentation/api/diagram/segments/) as orthogonal to create a default orthogonal segment and need to specify [`type`](https://ej2.syncfusion.com/documentation/api/diagram/connector/#segments). The following code example illustrates how to create a default orthogonal segment.

Multiple segments can be defined one after another. To create a connector with multiple segments, define and add the segments to [`connector.segments`](https://ej2.syncfusion.com/documentation/api/diagram/connector/#segments) collection. The following code example illustrates how to create a connector with multiple segments.

{% aspTab template="diagram/connectors/orthogonal", sourceFiles="orthogonal.cs" %}

{% endaspTab %}

The [`length`](https://ej2.syncfusion.com/documentation/api/diagram/orthogonalSegment/#length) and [`direction`](https://ej2.syncfusion.com/documentation/api/diagram/orthogonalSegment/) properties allow to define the flow and length of segment. The following code example illustrates how to create customized orthogonal segments.

{% aspTab template="diagram/connectors/direction", sourceFiles="direction.cs" %}

{% endaspTab %}

>Note: You need to mention the segment type as same as what you mentioned in connector type. There should be no contradiction between connector type and segment type.

## Avoid overlapping

Orthogonal segments are automatically re-routed, in order to avoid overlapping with the source and target nodes. The following preview illustrates how orthogonal segments are re-routed.

{% aspTab template="diagram/connectors/overlapping", sourceFiles="overlapping.cs" %}

{% endaspTab %}

## Bezier

Bezier segments are used to create curve segments and the curves are configurable either with the control points or with vectors.

To create a bezier segment, the [`segment.type`](https://ej2.syncfusion.com/documentation/api/diagram/segments/) is set as `bezier` and need to specify [`type`](https://ej2.syncfusion.com/documentation/api/diagram/connector/#type-Segments) for the connector. The following code example illustrates how to create a default bezier segment.

{% aspTab template="diagram/connectors/vector", sourceFiles="vector.cs" %}

{% endaspTab %}

The [`point1`](https://ej2.syncfusion.com/documentation/api/diagram/bezierSegment/#point1) and [`point2`](https://ej2.syncfusion.com/documentation/api/diagram/bezierSegment/#point2) properties of bezier segment enable you to set the control points. The following code example illustrates how to configure the bezier segments with control points.

The [`vector1`](https://ej2.syncfusion.com/documentation/api/diagram/bezierSegment/#vector1) and [`vector2`](https://ej2.syncfusion.com/documentation/api/diagram/bezierSegment/#vector2) properties of bezier segment enable you to define the vectors. The following code illustrates how to configure a bezier curve with vectors.

{% aspTab template="diagram/connectors/points", sourceFiles="points.cs" %}

{% endaspTab %}

## Decorator

* Starting and ending points of a connector can be decorated with some customizable shapes like arrows, circles, diamond, or path. The connection end points can be decorated with the [`sourceDecorator`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_SourceDecorator) and [`targetDecorator`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_TargetDecorator) properties of the connector.

* The [`shape`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDecorator.html#Syncfusion_EJ2_Diagrams_DiagramDecorator_Shape) property of `sourceDecorator` allows to define the shape of the decorators. Similarly, the [shape](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDecorator.html#Syncfusion_EJ2_Diagrams_DiagramDecorator_Shape) property of `targetDecorator` allows to define the shape of the decorators.

* To create custom shape for source decorator, use [`pathData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDecorator.html#Syncfusion_EJ2_Diagrams_DiagramDecorator_PathData) property. Similarly, to create custom shape for target decorator, use [`pathData`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramDecorator.html#Syncfusion_EJ2_Diagrams_DiagramDecorator_PathData) property.

* The following code example illustrates how to create decorators of various shapes.

{% aspTab template="diagram/connectors/srcdecorator", sourceFiles="srcdecorator.cs" %}

{% endaspTab %}

## Padding

Padding is used to leave the space between the Connector's end point and the object to where it is connected.

* The [`sourcePadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_SourcePadding) property of connector defines space between the source point and the source node of the connector.

* The [`targetPadding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_TargetPadding) property of connector defines space between the end point and the target node of the connector.

* The following code example illustrates how to leave space between the connection end points and source and target nodes.

{% aspTab template="diagram/connectors/padding", sourceFiles="padding.cs" %}

{% endaspTab %}

## Flip

The diagram Provides support to flip the connector. The [`flip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_Flip) is performed to give the mirrored image of the original element.

The flip types are as follows:

* HorizontalFlip
 `Horizontal` is used to interchange the connector source and target x points.

* VerticalFlip
`Vertical` is used to interchange the connector source and target y points.

* Both
`Both` is used to interchange the source point as target point and target point as source point

{% aspTab template="diagram/connectors/flip", sourceFiles="flipt.cs" %}

{% endaspTab %}

 >Note: The flip is not applicable when the connectors connect in nodes.

## Bridging

Line bridging creates a bridge for lines to smartly cross over the other lines, at points of intersection. By default, [`bridgeDirection`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.BridgeDirection.html) is set to top. Depending upon the direction given bridging direction appears.
Bridging can be enabled/disabled either with the `connector.constraints` or `diagram.constraints`. The following code example illustrates how to enable line bridging.

{% aspTab template="diagram/connectors/bridging", sourceFiles="bridging.cs" %}

{% endaspTab %}

>Note: You need to inject connector bridging module into the diagram.

The [`bridgeSpace`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_BridgeSpace) property of connectors can be used to define the width for line bridging.

Limitation: Bezier segments do not support bridging.

## Corner radius

Corner radius allows to create connectors with rounded corners. The radius of the rounded corner is set with the [`cornerRadius`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_CornerRadius) property.

{% aspTab template="diagram/connectors/cornerradius", sourceFiles="cornerradius.cs" %}

{% endaspTab %}

## Appearance

* The connector’s [`strokeWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramStrokeStyle.html#Syncfusion_EJ2_Diagrams_DiagramStrokeStyle_StrokeWidth), [`strokeColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramStrokeStyle.html#Syncfusion_EJ2_Diagrams_DiagramStrokeStyle_StrokeColor), [`strokeDashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramStrokeStyle.html#Syncfusion_EJ2_Diagrams_DiagramStrokeStyle_StrokeDashArray), and [`opacity`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramStrokeStyle.html#Syncfusion_EJ2_Diagrams_DiagramStrokeStyle_Opacity) properties are used to customize the appearance of the connector segments.

* The [`visible`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConnector.html#Syncfusion_EJ2_Diagrams_DiagramConnector_Visible) property of the connector enables or disables the visibility of connector.

* Default values for all the `connectors` can be set using the `getConnectorDefaults` properties. For example, if all connectors have the same type or having the same property then such properties can be moved into `getConnectorDefaults`.

## Segment appearance

The following code example illustrates how to customize the segment appearance.

{% aspTab template="diagram/connectors/style", sourceFiles="style.cs" %}

{% endaspTab %}

## Decorator appearance

* The source decorator’s [`strokeColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeColor), [`strokeWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeWidth), and [`strokeDashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeDashArray) properties are used to customize the color, width, and appearance of the decorator.

* To set the border stroke color, stroke width, and stroke dash array for the target decorator, use [`strokeColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeColor), [`strokeWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeWidth), and [`strokeDashArray`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeDashArray).

* To set the size for source and target decorator, use width and height property.

The following code example illustrates how to customize the appearance of the decorator.

{% aspTab template="diagram/connectors/decorator", sourceFiles="decorator.cs" %}

{% endaspTab %}

## Interaction

* Diagram allows to edit the connectors at runtime. To edit the connector segments at runtime, refer to [`Connection Editing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.html).

## Automatic line routing

Diagram provides additional flexibility to re-route the diagram connectors. A connector will frequently re-route itself when a shape moves next to it. The following screenshot illustrates how the connector automatically re-routes the segments.

* The line routing constraints must be included to the default diagram constraints to enable automatic line routing support like below.

* The following code block shows how to create the diagram with specifying nodes, connectors, constraints, and necessary modules for line routing.

{% aspTab template="diagram/connectors/linerouting", sourceFiles="linerouting.cs" %}

{% endaspTab %}

* In some situations, automatic line routing enabled diagram needs to ignore a specific connector from automatic line routing. So, in this case, auto routing feature can be disabled to the specific connector using the [`constraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.ConnectorConstraints.html) property of the connector like the following code snippet.

{% aspTab template="diagram/connectors/linerouting1", sourceFiles="linerouting1.cs" %}

{% endaspTab %}

## Constraints

* The [`constraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.ConnectorConstraints.html) property of connector allows to enable/disable certain features of connectors.

* To enable or disable the constraints, refer [`constraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.ConnectorConstraints.html).

The following code illustrates how to disable selection.

{% aspTab template="diagram/connectors/constraints", sourceFiles="constraints.cs" %}

{% endaspTab %}

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

{% aspTab template="diagram/connectors/zindex", sourceFiles="zindex.cs" %}

{% endaspTab %}

## See Also

* [How to add annotations to the connector](./labels)
* [How to enable/disable the behavior of the node](./constraints)
* [How to add connectors to the symbol palette](./symbol-palette)
* [How to perform the interaction on the connector](./interaction)
* [How to create diagram connectors using drawing tools](./tools#tools)
