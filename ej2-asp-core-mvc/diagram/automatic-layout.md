---
layout: post
title: Automatic Layout in ##Platform_Name## Diagram Component
description: Learn here all about Automatic Layout in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Automatic Layout
publishingplatform: ##Platform_Name##
documentation: ug
---


# Automatic Layout

Diagram provides support to auto-arrange the nodes in the diagram area that is referred as [`Layout`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html). It includes the following layout modes:

## Layout modes

* Hierarchical layout
* Organization chart
* Radial tree
* Symmetric layout
* Mind Map layout
* Complex hierarchical tree layout

## Hierarchical layout

The hierarchical tree layout arranges nodes in a tree-like structure, where the nodes in the hierarchical layout may have multiple parents. There is no need to specify the layout root. To arrange the nodes in a hierarchical structure, specify the layout [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_Type) as `HierarchicalTree`. The following example shows how to arrange the nodes in a hierarchical structure.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/Hierarchical/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hierarchical.cs" %}
{% include code-snippet/diagram/layout/Hierarchical/Hierarchical.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Hierarchical.cs" %}
{% include code-snippet/diagram/layout/Hierarchical/Hierarchical.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

        function getNodeDefaults(obj, diagram) {
            var collapseicon = obj.collapseIcon;
            obj.shape = { type: 'Text', content: obj.data.Name };
            obj.style = { fill: '#659be5', strokeColor: 'none', color: 'white', strokeWidth: 2 };
            obj.borderColor = '#3a6eb5';
            obj.backgroundColor = '#659be5';
            obj.shape.margin = { left: 5, right: 5, bottom: 5, top: 5 };
            obj.expandIcon = { height: 10, width: 10, shape: 'None', fill: 'lightgray', offset: { x: .5, y: 1 } };
            obj.expandIcon.verticalAlignment = 'Auto';
            obj.expandIcon.margin = { left: 0, right: 0, top: 0, bottom: 0 };
            collapseicon.offset = { x: .5, y: 1 };
            collapseicon.verticalAlignment = 'Auto';
            collapseicon.margin = { left: 0, right: 0, top: 0, bottom: 0 };
            collapseicon.height = 10;
            collapseicon.width = 10;
            collapseicon.padding.top = 5;
            collapseicon.shape = 'None';
            collapseicon.fill = 'lightgray';
            return obj;
        }

        function connectorDefaults(connector, diagram) {
            connector.targetDecorator.shape = 'None';
            connector.type = 'Orthogonal';
            connector.constraints = 0;
            connector.cornerRadius = 5;
            return connector;
        }
```

## Radial tree layout

The radial tree layout arranges nodes on a virtual concentric circle around a root node. Sub-trees formed by the branching of child nodes are located radially around the child nodes. This arrangement result in an ever-expanding concentric arrangement with radial proximity to the root node indicating the node level in the hierarchy. The layout [`root`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_Root) property can be used to define the root node of the layout. When no root node is set, the algorithm automatically considers one of the diagram nodes as the root node.

To arrange nodes in a radial tree structure, set the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_Type) of the layout as `RadialTree`. The following code illustrates how to arrange the nodes in a radial tree structure.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/radial/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Radial.cs" %}
{% include code-snippet/diagram/layout/radial/radial.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Radial.cs" %}
{% include code-snippet/diagram/layout/radial/radial.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Organizational Chart

An organizational chart is a diagram that displays the structure of an organization and relationships. To create an organizational chart, the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_Type) of layout should be set as an `OrganizationalChart`.
The following code example illustrates how to create an organizational chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/Organizational/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Organizational.cs" %}
{% include code-snippet/diagram/layout/Organizational/Organizational.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Organizational.cs" %}
{% include code-snippet/diagram/layout/Organizational/Organizational.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

        function getLayoutInfo(node, options, orientation, type) {
            if (node.data.Role === 'General Manager') {
                options.assistants.push(options.children[0]);
                options.children.splice(0, 1);
            }
            if (!options.hasSubTree) {
                options.type = 'Right';
            }
        }
```

Organizational chart layout starts parsing from root and iterate through all its child elements. The `getLayoutInfo` method provides necessary information of a node’s children and the way to arrange (direction, orientation, offsets, etc.) them. The arrangements can be customized by overriding this function as explained.

### GetLayoutInfo

Set chart orientations, chart types, and offset to be left between parent and child nodes by overriding the method, `diagram.layout.getLayoutInfo`. The [`getLayoutInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_GetLayoutInfo) method is called to configure every subtree of the organizational chart. It takes the following arguments.

    * node: Parent node to that options are to be customized.
    * options: Object to set the customizable properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/Organizational/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Organizational.cs" %}
{% include code-snippet/diagram/layout/Organizational/Organizational.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Organizational.cs" %}
{% include code-snippet/diagram/layout/Organizational/Organizational.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

        function getLayoutInfo(node, options, orientation, type) {
        if (!options.hasSubTree) {
                options.type = 'Center';
                options.orientation = 'Horizontal';
            }
        }

```

The following table illustrates the properties that “options” argument takes.

| Property | Description | Default Value |
| -------- | ----------- | ------------- |
|options.assistants|By default, the collection is empty. When any of the child nodes have to be set as **Assistant**, you can remove from children collection and have to insert into assistants collection.|Empty array|
|options.orientation|Gets or sets the organizational chart orientation.|SubTreeOrientation.Vertical|
|options.type|Gets or sets the chart organizational chart type.|For horizontal chart orientation:SubTreeAlignments.Center and for vertical chart orientation:SubTreeAlignments.Alternate|
|options.offset|Offset is the horizontal space to be left between parent and child nodes.|20 pixels applicable only for vertical chart orientations.|
|options.hasSubTree|Gets whether the node contains subtrees.|Boolean|
|options.level|Gets the depth of the node from layout root.|Number|
|options.enableRouting|By default, connections are routed based on the chart type and orientations. This property gets or sets whether default routing is to be enabled or disabled.|true|
|options.rows|Sets the number of rows on which the child nodes will be arranged. Applicable only for balanced type horizontal tree.|Number|

The following table illustrates the different chart orientations and chart types.

|Orientation|Type|Description|Example|
| -------- | ----------- | ------------- |------|
|Horizontal|Left|Arranges the child nodes horizontally at the left side of the parent.|![Horizontal Left](images/hleft.jpg)|
||Right|Arranges the child nodes horizontally at the right side of the parent.|![Horizontal Right](images/hright.jpg)|
||Center|Arranges the children like standard tree layout orientation.|![Horizontal Center](images/hcenter.jpg)|
||Balanced|Arranges the leaf level child nodes in multiple rows.|![Horizontal Balanced](images/hbalanced.jpg)|
|Vertical|Left|Arranges the children vertically at the left side of the parent.|![Vertical Left](images/vleft.jpg)|
||Right|Arranges the children vertically at the right side of the parent.|![Vertical Right](images/vright.jpg)|
||Alternate|Arranges the children vertically at both left and right sides of the parent.|![Vertical Alternate](images/vAlternate.jpg)|

The following code example illustrates how to set the vertical right arrangement to the leaf level trees.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/Organizational/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Organizational.cs" %}
{% include code-snippet/diagram/layout/Organizational/Organizational.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Organizational.cs" %}
{% include code-snippet/diagram/layout/Organizational/Organizational.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
        function getLayoutInfo(node, options, orientation, type) {
            if (!options.hasSubTree) {
                options.type = 'Right';
                options.orientation = 'Vertical';
            }
        }

```

### Assistant

Assistants are child item that have a different relationship with the parent node. They are laid out in a dedicated part of the tree. A node can be specified as an assistant of its parent by adding it to the `assistants` property of the argument “options”.

The following code example illustrates how to add assistants to layout.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/Organizational/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Organizational.cs" %}
{% include code-snippet/diagram/layout/Organizational/Organizational.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Organizational.cs" %}
{% include code-snippet/diagram/layout/Organizational/Organizational.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
        function getLayoutInfo(node, options, orientation, type) {
         if (node.data['Role'] === 'General Manager') {
                options.assistants.push(options.children[0]);
                options.children.splice(0, 1);
            }
            if (!options.hasSubTree) {
                options.type = 'Right';
                options.orientation = 'Vertical';
            }
        }

```

## Symmetric layout

The symmetric layout has been formed using nodes position by closer together or pushing them further apart. This is repeated iteratively until the system comes to an equilibrium state.

The layout’s [`springLength`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_SpringLength) defined as how long edges should be, ideally. This will be the resting length for the springs. Edge attraction and vertex repulsion forces to be defined by using layout’s [`springFactor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_SpringFactor), the more sibling nodes repel each other. The relative positions do not change any more from one iteration to the next. The number of iterations can be specified by using layout’s [`maxIteration`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_MaxIteration).

The following code illustrates how to arrange the nodes in a radial tree structure.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/symmetric/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Symmetric.cs" %}
{% include code-snippet/diagram/layout/symmetric/symmetric.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Symmetric.cs" %}
{% include code-snippet/diagram/layout/symmetric/symmetric.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Mind Map layout

A mind map is a diagram that displays the nodes as a spider diagram organizes information around a central concept. To create mind map, the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_Type) of layout should be set as `MindMap`.
The following code example illustrates how to create an organizational chart.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/mindMap/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MindMap.cs" %}
{% include code-snippet/diagram/layout/mindMap/mindMap.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="MindMap.cs" %}
{% include code-snippet/diagram/layout/mindMap/mindMap.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Complex hierarchical tree

Complex hierarchical tree layout is the extended version of the hierarchical tree layout. The child had been two or more parents. To create a complex hierarchical tree, the [`type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_Type) of layout should be set as `ComplexHierarchicalTree`.
The following code example illustrates how to create a complex hierarchical tree.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/ComplexHierarchicalTree/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ComplexHierarchicalTree.cs" %}
{% include code-snippet/diagram/layout/ComplexHierarchicalTree/ComplexHierarchicalTree.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="ComplexHierarchicalTree.cs" %}
{% include code-snippet/diagram/layout/ComplexHierarchicalTree/ComplexHierarchicalTree.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Line Distribution

Line distribution is used to arrange the connectors without overlapping in automatic layout. In some cases, the automatic layout connectors connecting to the nodes will be overlapped with one another. So user can decide whether the segment of each connector from a single parent node should be same point or different point. The [`ConnectionPointOrigin`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Diagrams.DiagramLayout.html#Syncfusion_Blazor_Diagrams_DiagramLayout_ConnectionPointOrigin) property of layout is used to enable or disable the line distribution in layout. By default ConnectionPointOrigin will be `SamePoint`.

The following code example illustrates how to allow a line distribution in diagram layout.

```cs

    public ActionResult LineDistribution()
        {
            DiagramLayout connectionPointOriginValue = new DiagramLayout() { ConnectionPointOrigin = ConnectionPointOrigin.DifferentPoint };
            ViewBag.connectionPointOrigin = connectionPointOriginValue;
            return View();
        }

```

### Linear Arrangement

Linear arrangement is used to linearly arrange the child nodes in layout, which means the parent node is placed in the center corresponding to its children. When line distribution is enabled, linear arrangement is also activated by default. The [`Arrangement`](https://help.syncfusion.com/cr/blazor/Syncfusion.Blazor.Diagrams.DiagramLayout.html#Syncfusion_Blazor_Diagrams_DiagramLayout_Arrangement) property of layout is used to enable or disable the linear arrangement in layout. By default Arrangement will be `Nonlinear`.

> Linear arrangement is applicable only for complex hierarchical tree layout.

The following code illustrates how to allow a linear arrangement in diagram layout.

```cs

    public ActionResult LinearArrangement()
        {
            DiagramLayout arrangementValue = new DiagramLayout() { Arrangement = ChildArrangement.Linear};
            ViewBag.arrangement = arrangementValue;
            return View();
        }

```

### Prevent connectors overlay

The below constraints prevents the connector segments overlapping nodes with a complex hierarchical layout.

```cs

    DiagramLayout arrangementValue = new DiagramLayout() { Arrangement = ChildArrangement.Linear};

```

## Customize layout

Orientation, spacings, and position of the layout can be customized with a set of properties.

To explore layout properties, refer to [`Layout Properties`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html).

### Layout bounds

Diagram provides support to align the layout within any custom rectangular area. For more information about bounds, refer to [`bounds`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_Bounds).

### Layout alignment

The layout can be aligned anywhere over the layout bounds/viewport using the [`horizontalAlignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_HorizontalAlignment) and [`verticalAlignment`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_VerticalAlignment) properties of the layout.

The following code illustrates how to align the layout at the top-left of the layout bounds.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/layoutAlign/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LayoutAlign.cs" %}
{% include code-snippet/diagram/layout/layoutAlign/layoutAlign.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="LayoutAlign.cs" %}
{% include code-snippet/diagram/layout/layoutAlign/layoutAlign.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Layout spacing

Layout provides support to add space horizontally and vertically between the nodes. The [`horizontalSpacing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_HorizontalSpacing) and [`verticalSpacing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_VerticalSpacing) properties of the layout allows you to set the space between the nodes in horizontally and vertically.

### Layout margin

Layout provides support to add some blank space between the layout bounds/viewport and the layout. The [`margin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.LayoutMarginLayout.html) property of the layout allows you to set the blank space.

The following code illustrates how to set the layout margin.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/layoutMargin/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LayoutMargin.cs" %}
{% include code-snippet/diagram/layout/layoutMargin/layoutMargin.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="LayoutMargin.cs" %}
{% include code-snippet/diagram/layout/layoutMargin/layoutMargin.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Layout orientation

The layout orientation can used to arrange the layout based on the direction. there are different orientation types that are defined in the following table.

|Orientation|Description|
| -------- | ----------- |
|TopToBottom|Aligns the layout from top to bottom. All the roots are placed at top of diagram.|
|LeftToRight|Aligns the layout from left to right. All the roots are placed at left of diagram.|
|BottomToTop|Aligns the layout from bottom to top. All the roots are placed at bottom of the diagram.|
|RightToLeft|Aligns the layout from right to left. All the roots are placed at right of the diagram.|

Diagram provides support to customize the  [`orientation`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_Orientation) of layout. You can set the desired orientation using layout.orientation.

> In the diagram the default orientation is TopToBottom.

The following code illustrates how to arrange the nodes in a BottomToTop orientation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/orientation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Orientation.cs" %}
{% include code-snippet/diagram/layout/orientation/orientation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Orientation.cs" %}
{% include code-snippet/diagram/layout/orientation/orientation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Fixed node

Layout provides support to arrange the nodes with reference to the position of a fixed node and set it to the [`fixedNode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramLayout.html#Syncfusion_EJ2_Diagrams_DiagramLayout_FixedNode) of the layout property. This is helpful when you try to expand/collapse a node. It might be expected that the position of the double-clicked node should not be changed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/fixedNode/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="FixedNode.cs" %}
{% include code-snippet/diagram/layout/fixedNode/fixedNode.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="FixedNode.cs" %}
{% include code-snippet/diagram/layout/fixedNode/fixedNode.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Expand and collapse

Diagram allows to expand/collapse the subtrees of a layout. The node’s isExpanded property allows you to expand/collapse its children. The following code example shows how to expand/collapse the children of a node.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/expandCollapse/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExpandCollapse.cs" %}
{% include code-snippet/diagram/layout/expandCollapse/expandCollapse.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="ExpandCollapse.cs" %}
{% include code-snippet/diagram/layout/expandCollapse/expandCollapse.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
  function getNodeDefaults(obj, diagram) {
            obj.expandIcon = {
                height: 15,
                width: 15,
                shape: "Plus",
                fill: 'lightgray',
                offset: {
                    x: .5,
                    y: .85
                }
            }
            obj.collapseIcon.offset = {
                x: .5,
                y: .85
            }
            obj.collapseIcon.height = 15;
            obj.collapseIcon.width = 15;
            obj.collapseIcon.shape = "Minus";
            obj.height = 50;
            obj.borderColor = 'white';
            obj.backgroundColor = '#6BA5D7';
            obj.borderWidth = 1;
            obj.style = {
                fill: 'transparent',
                strokeWidth: 2
            };
        }
```

In the previous example, while expanding/collapsing a node, it is set as fixed node in order to prevent it from repositioning.

### Refresh layout

Diagram allows to refresh the layout at runtime. To refresh the layout, refer to Refresh layout.

### setNodeTemplate

 The setNodeTemplate function is provided for the purpose of customizing nodes. It will be called for each node on node initialization. In this function, the node style and its properties can be customized and can bind the custom JSON with node.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/layout/setNodeTemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SetNodeTemplate.cs" %}
{% include code-snippet/diagram/layout/setNodeTemplate/setNodeTemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="SetNodeTemplate.cs" %}
{% include code-snippet/diagram/layout/setNodeTemplate/setNodeTemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

    function setNodeTemplate(obj, diagram) {
        obj.style.borderColor = obj.data.color;
    }

```
