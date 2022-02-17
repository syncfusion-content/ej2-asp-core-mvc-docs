---
layout: post
title: Tools in ##Platform_Name## Diagram Component
description: Learn here all about Tools in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Tools
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tools

## Drawing tools

Drawing tool allows you to draw any kind of node/connector during runtime by clicking and dragging on the diagram page.

## Shapes

To draw a shape, set the JSON of that shape to the drawType property of the diagram and activate the drawing tool by using the [`tool`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramTools.html) property. The following code example illustrates how to draw a rectangle at runtime.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/Tools/shapes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Shapes.cs" %}
{% include code-snippet/diagram/Tools/shapes/shapes.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Shapes.cs" %}
{% include code-snippet/diagram/Tools/shapes/shapes.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

function Created() {
    var diagram = document.getElementById("container").ej2_instances[0];
    var drawingshape = { type: 'Basic', shape: 'Rectangle' };
        var node = {
            shape: drawingshape
        };
        diagram.drawingObject = node;
        //To draw an object once, activate draw once
        diagram.tool = DiagramTools.DrawOnce;
        diagram.dataBind();
    }
```

The following code example illustrates how to draw a path.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/Tools/shapes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Shapes.cs" %}
{% include code-snippet/diagram/Tools/shapes/shapes.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Shapes.cs" %}
{% include code-snippet/diagram/Tools/shapes/shapes.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

function Created() {
    var diagram = document.getElementById("container").ej2_instances[0];
    var node = {
            id: "Path",
            style: { fill: "#fbe172" },
            annotations: [{
                content: "Path"
            }],
            shape: {
                type:'Path',
                data: 'M13.560 67.524 L 21.941 41.731 L 0.000 25.790 L 27.120 25.790 L 35.501 0.000 L 43.882 25.790 L 71.000 25.790 L 49.061 41.731 L 57.441 67.524 L 35.501 51.583 z'
            }
        };
        diagram.drawingObject = node;
        //To draw an object once, activate draw once
        diagram.tool = DiagramTools.DrawOnce;
        diagram.dataBind();
    }

```

## Connectors

To draw connectors, set the JSON of the connector to the drawType property. The drawing [`tool`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramTools.html) can be activated by using the tool property. The following code example illustrates how to draw a straight line connector.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/Tools/shapes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Shapes.cs" %}
{% include code-snippet/diagram/Tools/shapes/shapes.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Shapes.cs" %}
{% include code-snippet/diagram/Tools/shapes/shapes.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript
function Created() {
    var diagram = document.getElementById("container").ej2_instances[0];
    var connectors = {
            id: 'connector1',
            type: 'Straight',
           segments: [{ type: "polyline" }]
        }
        diagram.drawingObject = connectors;
        //To draw an object once, activate draw once
        diagram.tool = DiagramTools.DrawOnce;
        diagram.dataBind();
}

```

## Text

Diagram allows you to create a textNode, when you click on the diagram page. The following code illustrates how to draw a text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/Tools/node/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Node.cs" %}
{% include code-snippet/diagram/Tools/node/node.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Node.cs" %}
{% include code-snippet/diagram/Tools/node/node.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

function Created() {
    var diagram = document.getElementById("container").ej2_instances[0];
    var node = {
        shape: {
            type: 'Text',
        }
    };
    diagram.drawingObject = node;
    //To draw an object once, activate draw once
    diagram.tool = DiagramTools.DrawOnce;
    diagram.dataBind();
}

```

Once you activate the TextTool, perform label editing of a node/connector.

## Polygon shape

Diagram allows to create the polygon shape by clicking and moving the mouse at runtime on the diagram page.

The following code illustrates how to draw a polygon shape.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/Tools/node/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Node.cs" %}
{% include code-snippet/diagram/Tools/node/node.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Node.cs" %}
{% include code-snippet/diagram/Tools/node/node.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

function Created() {
        var drawingshape = { type: 'Basic', shape: 'Polygon' };
        //JSON to create a polygon
        var node = {
            shape: drawingshape
        };
        diagram.drawingObject = node;
        //To draw an object once, activate draw once
        diagram.tool = DiagramTools.DrawOnce;
        diagram.dataBind();
}

```

## Polyline Connector

Diagram allows to create the polyline segments with straight lines and angled vertices at the control points by clicking and moving the mouse at runtime on the diagram page.

The following code illustrates how to draw a polyline connector.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/Tools/node/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Node.cs" %}
{% include code-snippet/diagram/Tools/node/node.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Node.cs" %}
{% include code-snippet/diagram/Tools/node/node.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

function Created() {
    var connector =  { id: 'connector1', type: 'Polyline'};
    diagram.drawingObject = connector;
    //To draw an object once, activate draw once
    diagram.tool = DiagramTools.DrawOnce;
    diagram.dataBind();
}

```

## Tool selection

There are some functionalities that can be achieved by clicking and dragging on the diagram surface. They are as follows.

* Draw selection rectangle: MultipleSelect tool
* Pan the diagram: Zoom pan
* Draw nodes/connectors: DrawOnce/DrawOnce

As all the three behaviors are completely different, you can achieve only one behavior at a time based on the tool that you choose.
When more than one of those tools are applied, a tool is activated based on the precedence given in the following table.

|Precedence|Tools|Description|
|----------|-----|-----------|
|1st|ContinuesDraw|Allows you to draw the nodes or connectors continuously. Once it is activated, you cannot perform any other interaction in the diagram.|
|2nd|DrawOnce|Allows you to draw a single node or connector. Once you complete the DrawOnce action, SingleSelect, and MultipleSelect tools are automatically enabled.|
|3rd|ZoomPan|Allows you to pan the diagram. When you enable both the SingleSelect and ZoomPan tools, you can perform the basic interaction as the cursor hovers node/connector. Panning is enabled when cursor hovers the diagram.|
|4th|MultipleSelect|Allows you to select multiple nodes and connectors. When you enable both the MultipleSelect and ZoomPan tools, cursor hovers the diagram. When panning is enabled, you cannot select multiple nodes.|
|5th|SingleSelect|Allows you to select individual nodes or connectors.|
|6th|None|Disables all tools.|

Set the desired [`tool`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramTools.html) to the tool property of the diagram model. The following code illustrates how to enable single/multiple tools.

```javascript
// To Enable Single Tool
diagram.tool = DiagramTools.DrawOnce;
diagram.dataBind();

// Enables multiple tools
diagram.tool = DiagramTools.DrawOnce || DiagramTools.ZoomPan;
diagram.dataBind();

```