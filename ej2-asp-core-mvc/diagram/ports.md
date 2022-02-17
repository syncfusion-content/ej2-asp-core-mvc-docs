---
layout: post
title: Ports in ##Platform_Name## Diagram Component
description: Learn here all about Ports in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Ports
publishingplatform: ##Platform_Name##
documentation: ug
---


# Ports

Diagram provides support to define custom ports for making connections.

![Port](images/Port1.png)

<!-- markdownlint-disable MD033 -->

When a connector is connected between two nodes, its end points are automatically docked to the node’s nearest boundary as shown in the following image.

![Port to Port](images/port2.png)

Ports act as the connection points of the node and allows to create connections with only those specific points as shown in the following image.

![Port Image](images/Port3.png)

## Create port

## Add ports when initializing nodes

To add a connection port, define the port object and add it to node’s ports collection. The `offset` property of port accepts an object of fractions and used to determine the position of ports. The following code illustrates how to add ports when initializing the node.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/ports/port/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Port.cs" %}
{% include code-snippet/diagram/ports/port/port.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Port.cs" %}
{% include code-snippet/diagram/ports/port/port.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Add ports at runtime

Add ports at runtime by using the client-side method [`addPorts`](../api/diagram#addPorts). The following code illustrates how to add ports to node at runtime.

The port’s ID property is used to define the unique ID for the port and its further used to find the port at runtime.
If ID is not set, then default ID is automatically set.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/ports/run/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Run.cs" %}
{% include code-snippet/diagram/ports/run/run.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Run.cs" %}
{% include code-snippet/diagram/ports/run/run.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

// Initialize port collection
var port= [{
        id: 'port1',
        offset: {
            x: 0,
            y: 0.5
        },
        visibility: PortVisibility.Visible
    } {
        id: 'port2',
        offset: {
            x: 1,
            y: 0.5
        },
        visibility: PortVisibility.Visible
    },
    {
        id: 'port3',
        offset: {
            x: 0.5,
            y: 0
        },
        visibility: PortVisibility.Visible
    },
    {
        id: 'port4',
        offset: {
            x: 0.5,
            y: 1
        },
        visibility: PortVisibility.Visible
    }
];

// Method to add ports through run time
diagram.addPorts(diagram.nodes[0], port);

```

## Remove ports at runtime

Remove ports at runtime by using client-side method [`removePorts`](../api/diagram#removePorts). Refer to the following example which shows how to remove ports at runtime.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/ports/remove/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Remove.cs" %}
{% include code-snippet/diagram/ports/remove/remove.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Remove.cs" %}
{% include code-snippet/diagram/ports/remove/remove.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

var ports = [{
    id: 'port1',
}, {
    id: 'port2',
}, {
    id: 'port3',
}, {
    id: 'port4',
}]
diagram.removePorts(diagram.nodes[0], ports);

```

## Update port at runtime

You can change any port properties at runtime and update it through the client-side method [`dataBind`](../api/diagram#dataBind).

The following code example illustrates how to change the port properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/ports/port/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Port.cs" %}
{% include code-snippet/diagram/ports/port/port.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Port.cs" %}
{% include code-snippet/diagram/ports/port/port.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



```javascript

diagram.nodes[0].ports[0].offset = {
    x: 1,
    y: 1
};
diagram.dataBind();

```

## Appearance

* The shape of port can be changed by using its shape property. To explore the different types of port shapes, refer to Port Shapes. If you need to render a custom shape, then you can set shape as path and define path using path data property of port.

* The appearance of ports can be customized by using [`strokeColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeColor),
[`strokeWidth`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_StrokeWidth), and [`fill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramShapeStyle.html#Syncfusion_EJ2_Diagrams_DiagramShapeStyle_Fill) properties of the port.

* Customize the port size by using the [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPort.html#Syncfusion_EJ2_Diagrams_DiagramPort_Width) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPort.html#Syncfusion_EJ2_Diagrams_DiagramPort_Height) properties of port.

* The ports [`visibility`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramPort.html#Syncfusion_EJ2_Diagrams_DiagramPort_Visibility) property allows you to define, when the port should be visible.

The following code illustrates how to change the appearance of port.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/diagram/ports/appear/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Appear.cs" %}
{% include code-snippet/diagram/ports/appear/appear.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Appear.cs" %}
{% include code-snippet/diagram/ports/appear/appear.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Offset

The offset property of port is used to align the port based on fractions. 0 represents top/left corner, 1 represents bottom/right corner, and 0.5 represents half of width/height.

## Constraints

The constraints property allows to enable/disable certain behaviors of ports. For more information about port
constraints, refer to [`Port Constraints`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.PortConstraints.html).
