---
title: "Constraints"
component: "Diagram"
description: "Diagram constraints allow you to enable/disable certain behaviors of the diagram, nodes and connectors."
---

# Constraints

Constraints are used to enable/disable certain behaviors of the diagram, nodes and connectors. Constraints are provided as flagged enumerations, so that multiple behaviors can be enabled/disabled using Bitwise operators (&, |, ~, <<, etc.).

To know more about Bitwise operators, refer to [`Bitwise Operations`](#bitwise-operations).

## Diagram constraints

Diagram constraints allow to enable or disable the following behaviors:

* Page editing
* Bridging
* Zoom and pan
* Undo/redo
* Tooltip

The following example illustrates how to give page editing using the diagram constraints.

{% aspTab template="diagram/constraints/default", sourceFiles="default.cs" %}

{% endaspTab %}

For more information about diagram constraints, refer to [`DiagramConstraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramConstraints.htmll).

## Node constraints

Node constraints allows to enable or disable the following behaviors of node. They are as follows:

* Selection
* Deletion
* Drag
* Resize
* Rotate
* Connect
* Shadow
* Tooltip

The following example illustrates how to disable rotation using the node constraints.

{% aspTab template="diagram/constraints/node", sourceFiles="node.cs" %}

{% endaspTab %}

For more information about node constraints, refer to [`NodeConstraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.NodeConstraints.html).

## Connector constraints

Connector constraints allow to enable or disable certain behaviors of connectors.

* Selection
* Deletion
* Drag
* Segment editing
* Tooltip
* Bridging

The following code illustrates how to disable selection by using connector constraints.

{% aspTab template="diagram/constraints/connector", sourceFiles="connector.cs" %}

{% endaspTab %}

For more information about connector constraints, refer to [`ConnectorConstraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.ConnectorConstraints.html).

## Port constraints

You can enable or disable certain behaviors of port. They are as follows:

* Connect
* ConnectOnDrag

The following code illustrates how to disable creating connections with a port.

{% aspTab template="diagram/constraints/port", sourceFiles="port.cs" %}

{% endaspTab %}

For more information about port constraints, refer to [`PortConstraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.PortConstraints.html).

## Annotation constraints

You can enable or disable read-only mode for the annotations by using the annotation constraints.

The following code illustrates how to enable read-only mode for the annotations.

{% aspTab template="diagram/constraints/annotation", sourceFiles="annotation.cs" %}

{% endaspTab %}

For more details about annotation constraints, refer to [`AnnotationConstraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.AnnotationConstraints.html).

## Selector constraints

Selector visually represents the selected elements with certain editable thumbs. The visibility of the thumbs can be controlled with selector constraints. The part of selector is categorized as follows:

* Resizer
* Rotator
* User handles

The following code illustrates how to hide rotator.

{% aspTab template="diagram/constraints/selector", sourceFiles="selector.cs" %}

{% endaspTab %}

For more information about selector constraints, refer to [`SelectorConstraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SelectorConstraints.html).

## Snap constraints

Snap constraints control the visibility of gridlines and enable/disable snapping. Snap constraints allow to set the following behaviors.

* Show only horizontal or vertical gridlines.
* Show both horizontal and vertical gridlines.
* Snap to either horizontal or vertical gridlines.
* Snap to both horizontal and vertical gridlines.

The following code illustrates how to show only horizontal gridlines.

{% aspTab template="diagram/constraints/snap", sourceFiles="snap.cs" %}

{% endaspTab %}

For more information about snap constraints, refer to [`SnapConstraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.SnapConstraints.html).

## Boundary constraints

Boundary constraints defines a boundary for the diagram inside which the interaction should be done. Boundary constraints allow to set the following behaviors.

* Infinite boundary
* Diagram sized boundary
* Page sized boundary

The following code illustrates how to limit the interaction done inside a diagram within a page.

{% aspTab template="diagram/constraints/page", sourceFiles="page.cs" %}

{% endaspTab %}

For more information about selector constraints, refer to [`BoundaryConstraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.BoundaryConstraints.html).

## Inherit behaviors

Some of the behaviors can be defined through both the specific object (node/connector) and diagram. When the behaviors are contradictorily defined through both, the actual behavior is set through inherit options.

The following code example illustrates how to inherit the line bridging behavior from the diagram model.

{% aspTab template="diagram/constraints/bridging", sourceFiles="bridging.cs" %}

{% endaspTab %}

## Bitwise operations

Bitwise operations are used to manipulate the flagged enumerations [enum]. In this section, Bitwise operations are illustrated by using node constraints. The same is applicable while working with node constraints, connector constraints, or port constraints.

## Add operation

You can add or enable multiple values at a time by using Bitwise ‘|’ (OR) operator.

```typescript
node.constraints = NodeConstraints.Select | NodeConstraints.Rotate;
```

In the previous example, you can do both the selection and rotation operation.

## Remove Operation

You can remove or disable values by using Bitwise ‘&~’ (XOR) operator.

```typescript
node.constraints = node.constraints & ~(NodeConstraints.Rotate);
```

In the previous example, rotation is disabled but other constraints are enabled.

## Check operation

You can check any value by using Bitwise ‘&’ (AND) operator.

```typescript
if ((node.constraints & (NodeConstraints.Rotate)) == (NodeConstraints.Rotate));
```

In the previous example, check whether the rotate constraints are enabled in a node. When node constraints have rotate constraints, the expression returns a rotate constraint.