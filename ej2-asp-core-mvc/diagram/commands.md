---
layout: post
title: Commands in ##Platform_Name## Diagram Component
description: Learn here all about Commands in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Commands
publishingplatform: ##Platform_Name##
documentation: ug
---


# Commands

<!-- markdownlint-disable MD010 -->

There are several commands available in the diagram as follows.

* Alignment commands
* Spacing commands
* Sizing commands
* Clipboard commands
* Grouping commands
* Z-order commands
* Zoom commands
* Nudge commands
* FitToPage commands
* Undo/Redo commands

## Align

Alignment commands enable you to align the selected or defined objects such as nodes and connectors with respect to the selection boundary. Refer to [`align`](https://ej2.syncfusion.com/documentation/api/diagram/#align) commands which shows how to use align methods in the diagram.

<!-- markdownlint-disable MD033 -->

| Parameters | Description |
|:------------| :------: |
|[`Alignment Options`](https://ej2.syncfusion.com/documentation/api/diagram/#align) | <p align="left">Defines the specific direction, with respect to which the objects to be aligned. <br> The accepted values of the argument "alignment options" are as follows.</p> <table><tr><td> Left </td><td align="left"> Aligns all the selected objects at the left of the selection boundary. </td></tr><tr><td> Right </td><td align="left"> Aligns all the selected objects at the right of the selection boundary. </td></tr><tr><td> Center </td><td align="left"> Aligns all the selected objects at the center of the selection boundary. </td></tr><tr><td>Top </td><td align="left"> Aligns all the selected objects at the top of the selection boundary. </td></tr><tr><td> Bottom </td><td align="left"> Aligns all the selected objects at the bottom of the selection boundary. </td></tr><tr><td> Middle </td><td align="left"> Aligns all the selected objects at the middle of the selection boundary. </td></tr></table>|
| Objects | <p align="left">Defines the objects to be aligned. This is an optional parameter. By default, all the nodes and connectors in the selected region of the diagram gets aligned.</p> |
[`Alignment Mode`](https://ej2.syncfusion.com/documentation/api/diagram/alignmentMode/)  | <p align="left">Defines the specific mode, with respect to which the objects to be aligned. This is an optional parameter. The default alignment mode is `Object`.<br> The accepted values of the argument "alignment mode" are as follows.</p> <table><tr><td> Object </td><td align="left"> Aligns the objects based on the first object in the selected list. </td></tr><tr><td> Selector </td><td align="left"> Aligns the objects based on the selection boundary. </td></tr></table>|

The following code example illustrates how to align all the selected objects at the left side of the selection boundary.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/align/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Align.cs" %}
{% include code-snippet/diagram/commands/align/align.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Align.cs" %}
{% include code-snippet/diagram/commands/align/align.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
var diagram = document.getElementById("container").ej2_instances[0];
var selArray = [];
selArray.push(diagram.nodes[0], diagram.nodes[1], diagram.nodes[2]);
//Selects the nodes
diagram.select(selArray);
//Sets direction as left
diagram.align('Left', diagram.selectedItems.nodes, 'Selector');
diagram.dataBind();
```

![Align Sample](images/Commands_img1.png)

## Distribute

The [`Distribute`](https://ej2.syncfusion.com/documentation/api/diagram#distribute) commands enable to place the selected objects on the page at equal intervals from each other. The selected objects are equally spaced within the selection boundary.

The factor to distribute the shapes [`DistributeOptions`](https://ej2.syncfusion.com/documentation/api/diagram/distributeOptions/) are listed as follows:

* RightToLeft: Distributes the objects based on the distance between the right and left sides of the adjacent objects.
* Left: Distributes the objects based on the distance between the left sides of the adjacent objects.
* Right: Distributes the objects based on the distance between the right sides of the adjacent objects.
* Center: Distributes the objects based on the distance between the center of the adjacent objects.
* BottomToTop: Distributes the objects based on the distance between the bottom and top sides of the adjacent objects.
* Top: Distributes the objects based on the distance between the top sides of the adjacent objects.
* Bottom: Distributes the objects based on the distance between the bottom sides of the adjacent objects.
* Middle: Distributes the objects based on the distance between the vertical center of the adjacent objects.

The following code example illustrates how to execute the space commands.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/distribute/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Distribute.cs" %}
{% include code-snippet/diagram/commands/distribute/distribute.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Distribute.cs" %}
{% include code-snippet/diagram/commands/distribute/distribute.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
var diagram = document.getElementById("container").ej2_instances[0];
var selArray = [];
selArray.push(diagram.nodes[0], diagram.nodes[1], diagram.nodes[2]);
//Selects the nodes
diagram.select(selArray);
//Distributes space between the nodes
diagram.distribute('RightToLeft', diagram.selectedItems.nodes);
```

![Distribute Sample](images/Commands_img2.png)

## Sizing

Sizing [`sameSize`](https://ej2.syncfusion.com/documentation/api/diagram/#samesize) commands enable to equally size the selected nodes with respect to the first selected object.

[`SizingOptions`](https://ej2.syncfusion.com/documentation/api/diagram/#samesize) are as follows:

* Width: Scales the width of the selected objects.
* Height: Scales the height of the selected objects.
* Size: Scales the selected objects both vertically and horizontally.

The following code example illustrates how to execute the size commands.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/diagram/commands/size/size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/diagram/commands/size/size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
var diagram = document.getElementById("container").ej2_instances[0];
var selArray = [];
selArray.push(diagram.nodes[0], diagram.nodes[1], diagram.nodes[2]);
//Selects the nodes
diagram.select(selArray);
//Resizes the selected nodes with the same width
diagram.sameSize('Width', diagram.selectedItems.nodes);
```

![Sizing Sample](images/Commands_img3.png)

## Clipboard

Clipboard commands are used to cut, copy, or paste the selected elements. Refer to the following link which shows how to use clipboard methods in the diagram.

* Cuts the selected elements from the diagram to the diagram’s clipboard, [`cut`](https://ej2.syncfusion.com/documentation/api/diagram/#cut).

* Copies the selected elements from the diagram to the diagram’s clipboard, [`copy`](https://ej2.syncfusion.com/documentation/api/diagram/#copy).

* Pastes the diagram’s clipboard data (nodes/connectors) into the diagram, [`paste`](https://ej2.syncfusion.com/documentation/api/diagram/#paste).

The following code illustrates how to execute the clipboard commands.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/paste/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paste.cs" %}
{% include code-snippet/diagram/commands/paste/paste.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Paste.cs" %}
{% include code-snippet/diagram/commands/paste/paste.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagram = document.getElementById("container").ej2_instances[0];
diagram.select([diagram.nodes[0], diagram.nodes[1], diagram.connectors[0]]);
//copies the selected nodes
diagram.copy();
//pastes the copied objects
diagram.paste(diagram.copy() as(NodeModel | ConnectorModel)[]);
```

## Grouping

**Grouping commands** are used to group/ungroup the selected elements on the diagram. Refer to the following link which shows how to use grouping commands in the diagram.

[`Group`](https://ej2.syncfusion.com/documentation/api/diagram/#group) the selected nodes and connectors in the diagram.

[`Ungroup`](https://ej2.syncfusion.com/documentation/api/diagram/#ungroup) the selected nodes and connectors in the diagram.

The following code illustrates how to execute the grouping commands.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/diagram/commands/group/group.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Group.cs" %}
{% include code-snippet/diagram/commands/group/group.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagram = document.getElementById("container").ej2_instances[0];
diagram.appendTo('#element');
//Selects the diagram
diagram.selectAll();
//Groups the selected elements.
diagram.group();
```

## Z-Order command

**Z-Order commands** enable you to visually arrange the selected objects such as nodes and connectors on the page.

### bringToFront command

The [`bringToFront`](https://ej2.syncfusion.com/documentation/api/diagram/#bringtofront) command visually brings the selected element to front over all the other overlapped elements. The following code illustrates how to execute the `bringToFront` command.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/order/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagram = document.getElementById("container").ej2_instances[0];
let selArray: (NodeModel)[] = [];
diagram.appendTo('#element');
selArray.push(diagram.nodes[2]);
//Selects the nodes
diagram.select(selArray);
//Brings to front
diagram.bringToFront();

```

### sendToBack command

The [`sendToBack`](https://ej2.syncfusion.com/documentation/api/diagram/#sendtoback) command visually moves the selected element behind all the other overlapped elements. The following code illustrates how to execute the `sendToBack` command.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/order/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagram = document.getElementById("container").ej2_instances[0];
let selArray: (NodeModel)[] = [];
diagram.appendTo('#element');
selArray.push(diagram.nodes[2]);
//Selects the nodes
diagram.select(selArray);
//Sends to back
diagram.sendToBack();
```

### moveForward command

The [`moveForward`](https://ej2.syncfusion.com/documentation/api/diagram/#moveforward) command visually moves the selected element over the nearest overlapping element. The following code illustrates how to execute the `moveForward` command.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/order/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagram = document.getElementById("container").ej2_instances[0];
let selArray: (NodeModel)[] = [];
diagram.appendTo('#element');
selArray.push(diagram.nodes[1]);
//Selects the nodes
diagram.select(selArray);
//Moves forward
diagram.moveForward();
```

### sendBackward command

The [`sendBackward`](https://ej2.syncfusion.com/documentation/api/diagram/#sendbackward) command visually moves the selected element behind the underlying element. The following code illustrates how to execute the `sendBackward` command.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/order/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagram = document.getElementById("container").ej2_instances[0];
let selArray: (NodeModel)[] = [];
diagram.appendTo('#element');
selArray.push(diagram.nodes[1]);
diagram.select(selArray);
//Sends backward
diagram.sendBackward();
```

## Zoom

The [`zoom`](https://ej2.syncfusion.com/documentation/api/diagram/#zoom) command is used to zoom-in and zoom-out the diagram view.

The following code illustrates how to zoom-in/zoom out the diagram.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/order/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagram = document.getElementById("container").ej2_instances[0];
// Sets the zoomFactor
//Defines the focusPoint to zoom the Diagram with respect to any point
//When you do not set focus point, zooming is performed with reference to the center of current Diagram view.
diagram.zoom(1.2, {
    x: 100,
    y: 100
});

```

## Nudge command

The [`nudge`](https://ej2.syncfusion.com/documentation/api/diagram/#nudge) commands move the selected elements towards up, down, left, or right by 1 pixel.

[`NudgeDirection`](https://ej2.syncfusion.com/documentation/api/diagram/nudgeDirection) nudge command moves the selected elements towards the specified direction by 1 pixel, by default.

The accepted values of the argument "direction" are as follows:

* Up: Moves the selected elements towards up by the specified delta value.
* Down: Moves the selected elements towards down by the specified delta value.
* Left: Moves the selected elements towards left by the specified delta value.
* Right: Moves the selected elements towards right by the specified delta value.

The following code illustrates how to execute nudge command.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/order/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagram = document.getElementById("container").ej2_instances[0];
//Nudges to right
diagram.nudge('Right');

```

## Nudge by using arrow keys

The corresponding arrow keys are used to move the selected elements towards up, down, left, or right direction by 1 pixel.

![Nudge Command](images/Commands_img4.png)

Nudge commands are particularly useful for accurate placement of elements.

## BringIntoView

The [`bringIntoView`](https://ej2.syncfusion.com/documentation/api/diagram/#bringintoview) command brings the specified rectangular region into the viewport of the diagram.

The following code illustrates how to execute the `bringIntoView` command.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/order/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagram = document.getElementById("container").ej2_instances[0];
//Brings the specified rectangular region of the Diagram content to the viewport of the page.
var bound = new Rect(200, 400, 500, 400);
diagram.bringIntoView(bound);
```

## BringToCenter

The [`bringToCenter`](https://ej2.syncfusion.com/documentation/api/diagram/#bringtocenter) command brings the specified rectangular region of the diagram content to the center of the viewport.

The following code illustrates how to execute the `bringToCenter` command.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/order/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagram = document.getElementById("container").ej2_instances[0];
//Brings the specified rectangular region of the Diagram content to the center of the viewport.
let bound: Rect = new Rect(200, 400, 500, 400);
diagram.bringToCenter(bound);

```

## FitToPage command

The [`fitToPage`](https://ej2.syncfusion.com/documentation/api/diagram/#fittopage) command helps to fit the diagram content into the view with respect to either width, height, or at the whole.

The [`mode`](https://ej2.syncfusion.com/documentation/api/diagram/fitModes/) parameter defines whether the diagram has to be horizontally/vertically fit into the viewport with respect to width, height, or entire bounds of the diagram.

The [`region`](https://ej2.syncfusion.com/documentation/api/diagram/diagramRegions/) parameter defines the region that has to be drawn as an image.

The [`margin`](https://ej2.syncfusion.com/documentation/api/diagram/iFitOptions/) parameter defines the region/bounds of the diagram content that is to be fit into the view.

The [`canZoomIn`](https://ej2.syncfusion.com/documentation/api/diagram/iFitOptions#canZoomIn/) parameter enables/disables zooming to fit the smaller content into a larger viewport.

The [`customBounds`](../api/diagram/iFitOpthttps://ej2.syncfusion.com/documentation/api/diagram/iFitOptions#customBounds) parameter the custom region that has to be fit into the viewport.

The following code illustrates how to execute `FitToPage` command.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/order/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Order.cs" %}
{% include code-snippet/diagram/commands/order/order.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var diagram = document.getElementById("container").ej2_instances[0];
//fit the diagram to the page with respect to mode and region
diagram.fitToPage({
    mode: 'Page',
    region: 'Content',
    margin: {
        bottom: 50
    },
    canZoomIn: false
});

```

## Command manager

Diagram provides support to map/bind command execution with desired combination of key gestures. Diagram provides some built-in commands.
[`CommandManager`](https://ej2.syncfusion.com/documentation/api/diagram/commandManager/) provides support to define custom commands. The custom commands are executed, when the specified key gesture is recognized.

## Custom command

To define a custom command, specify the following properties:
* [`execute`](https://ej2.syncfusion.com/documentation/api/diagram/commandModel/#execute): A method to be executed.
* [`canExecute`](https://ej2.syncfusion.com/documentation/api/diagram/commandModel/#canexecute): A method to define whether the command can be executed at the moment.
* [`gesture`](https://ej2.syncfusion.com/documentation/api/diagram/commandModel/#gesture): A combination of [`keys`](https://ej2.syncfusion.com/documentation/api/diagram/keys/) and [`KeyModifiers`](https://ej2.syncfusion.com/documentation/api/diagram/keyModifiers/).
* [`parameter`](https://ej2.syncfusion.com/documentation/api/diagram/commandModel/#parameter): Defines any additional parameters that are required at runtime.
* [`name`](https://ej2.syncfusion.com/documentation/api/diagram/commandModel/#name): Defines the name of the command.

To explore the properties of custom commands, refer to [`Commands`](https://ej2.syncfusion.com/documentation/api/diagram/command#commands).

The following code example illustrates how to define a custom command.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/existingCommand/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ExistingCommand.cs" %}
{% include code-snippet/diagram/commands/existingCommand/existingCommand.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="ExistingCommand.cs" %}
{% include code-snippet/diagram/commands/existingCommand/existingCommand.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

    function canExecute() {
            var diagram = document.getElementById("diagram").ej2_instances[0];
        //Defines that the clone command can be executed, if and only if the selection list is not empty.
        if (diagram.selectedItems.nodes.length > 0 || diagram.selectedItems.connectors.length > 0) {
            return true;
        }
        return false;
    }
    //Command handler
    function execute() {
        //Logic to clone the selected element
        var diagram = document.getElementById("diagram").ej2_instances[0];
        diagram.copy();
        diagram.paste();
        diagram.dataBind();
    }

```

## Modify the existing command

When any one of the default commands is not desired, they can be disabled. To change the functionality of a specific command, the command can be completely modified.

The following code example illustrates how to disable a command and how to modify the built-in commands.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/nudge/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nudge.cs" %}
{% include code-snippet/diagram/commands/nudge/nudge.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/diagram/commands/nudge/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nudge.cs" %}
{% include code-snippet/diagram/commands/nudge/nudge.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

    function canExecute() {
        return false;
    }

```

## See Also

* [How to create the custom context menu items](./context-menu)