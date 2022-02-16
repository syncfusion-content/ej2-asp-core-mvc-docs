---
layout: post
title: Ej1 Api Migration in ##Platform_Name## Diagram Component
description: Learn here all about Ej1 Api Migration in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Ej1 Api Migration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Migration from Essential JS 1

This article describes the API migration process of Diagram component from Essential JS 1 to Essential JS 2.

## Background

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>Defines the background color of diagram elements</b></td>
<td><b>Property</b>:<i>`BackgroundColor`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").BackgroundColor("yellow").Render();
    }

</code>
</td>
<td><b>Property</b>:<i>`BackgroundColor`</i>
<code>

    @Html.EJS().Diagram("container").BackgroundColor("red")).Render()

</code>
</td>
</tr>
<tr>
<td><b>Defines how to align the background image over the diagram area</b></td>
<td><b>Property</b>:<i>`BackgroundImage.Alignment`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").BackgroundImage(new BackgroundImage() { Alignment= ImageAlignment.XMidYMid}).Render();
    }

</code>
</td>
<td><b>Property</b>:<i>`Background.Align`</i>
<code>

    @Html.EJS().Diagram("container").PageSettings(new DiagramPageSettings() { Background= new DiagramBackground() { Align=ImageAlignment.XMidYMid} }).Render()

</code>
</td>
</tr>
<tr>
<td><b>Defines how the background image should be scaled/stretched</b></td>
<td><b>Property</b>:<i>`BackgroundImage.Scale`</i>
<code>

    @{
        Html.EJ().Diagram("diagram").BackgroundImage(new BackgroundImage() { Scale=ScaleConstraints.Meet }).Render();
    }

</code>
</td>
<td><b>Property</b>:<i>`Background.Scale`</i>
<code>

    Html.EJS().Diagram("container").PageSettings(new DiagramPageSettings() { Background= new DiagramBackground() { Scale=Scale.Meet} }).Render()

</code>
</td>
</tr>
<tr>
<td><b>Sets the source path of the background image</b></td>
<td><b>Property</b>:<i>`BackgroundImage.Source`</i>
<code>

    @{
        Html.EJ().Diagram("diagram").BackgroundImage(new BackgroundImage() { Source= "../images/Employee/artBoard 13.Png" }).Render();
    }

</code>
</td>
<td><b>Property</b>:<i>`Background.Source`</i>
<code>

    @Html.EJS().Diagram("container").PageSettings(new DiagramPageSettings() { Background= new DiagramBackground() { Source= "Syncfusion.Png" } }).Render()

</code>
</td>
</tr>
</table>

## Bridging

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>Sets the direction of line bridges</b></td>
<td><b>Property</b>:<i>`BridgeDirection`</i>
<code>

    @{
        Html.EJ().Diagram("diagram").BridgeDirection(BridgeDirection.Bottom).Render();
    }

</code>
</td>

<td><b>Property</b>:<i>`BridgeDirection`</i>
<code>

    @Html.EJS().Diagram("container").BridgeDirection(BridgeDirection.Left)).Render()

</code>
</td>
</tr>
</table>

## CommandManager

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>Stores the multiple command names with the corresponding command objects</b></td>
<td>
<b>Property</b>:<i>`CommandManager.Commands`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<code>

    function canExecute(args) {
        var diagram = $("#DiagramContent").EjDiagram("instance");
        return diagram.Model.SelectedItems.Children.Length;
    }
    function execute(args) {
        var diagram = $("#DiagramContent").EjDiagram("instance");
        diagram.Copy();
        diagram.Paste();
    }

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Command clone = new Command() {
        Execute = "executeClone", CanExecute = "canExecuteClone",
        Gesture = new Gesture() { Key = Keys.C, KeyModifiers = KeyModifiers.Shift }
    };
    Model.CommandManager.Commands.Add("clone", clone);
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`CommandManager.Commands`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").CommandManager(ViewBag.commandManager).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramCommand> commands = new List<DiagramCommand>();
    commands.Add(new DiagramCommand() { Name = "customCopy" });
    DiagramCommandManager commandManager = new DiagramCommandManager()
    {
        Commands = commands
    };
    ViewBag.commandManager = commandManager;

</code></td>
</tr>
<tr>
<td><b>Defines any additional parameters that are required at runtime</b></td>
<td>
<b>Property</b>:<i>`CommandManager.Commands.Parameter`</i>

<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as Syncfusion.JavaScript.DataVisualization.Models.DiagramProperties);

</code>
<code>

    function canExecute(args) {
        var diagram = $("#DiagramContent").EjDiagram("instance");
        return diagram.Model.SelectedItems.Children.Length;
    }
    function execute(args) {
        var diagram = $("#DiagramContent").EjDiagram("instance");
        diagram.Copy();
        diagram.Paste();
    }

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Command clone = new Command() {
        parameter : "node", Execute = "executeClone", CanExecute = "canExecuteClone",
        Gesture = new Gesture() { Key = Keys.C, KeyModifiers = KeyModifiers.Shift }
    };
    Model.CommandManager.Commands.Add("clone", clone);
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`CommandManager.Commands.Parameter`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").CommandManager(ViewBag.commandManager).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramCommand> commands = new List<DiagramCommand>();
    commands.Add(new DiagramCommand() { Parameter = "node" });
    DiagramCommandManager commandManager = new DiagramCommandManager()
    {
        Commands = commands
    };
    ViewBag.commandManager = commandManager;

</code></td>
</tr>
</table>

## Connectors

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>Allows the user to save custom information/data about a connector</b></td>
<td>
<b>Property</b>:<i>`Connector.AddInfo`</i>

<code>

    @{
        Dictionary<string, object> AddInfo = new Dictionary<string, object>();
        AddInfo.Add("Description", "Bidirectional Flow");

        Html.EJ().Diagram("diagram")Connectors(c => c.Add(new Connector() { AddInfo = AddInfo })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connectors.AddInfo`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    Dictionary<string, object> AddInfo = new Dictionary<string, object>();
    AddInfo.Add("Description", "Bidirectional Flow");
    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { AddInfo = AddInfo });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Defines the bridgeSpace of connector</b></td>
<td>
<b>Property</b>:<i>`Connector.BridgeSpace`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram")Connectors(c => c.Add(new Connector() { BridgeSpace = 15 })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connectors.BridgeSpace`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { BridgeSpace = 15 });
    ViewBag.Connectors = connectors;

</code>
</code></td>
</tr>

<tr>
<td><b>Enables or disables the behaviors of connectors</b></td>
<td>
<b>Property</b>:<i>`Connector.Constraints`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() {  Constraints = Syncfusion.JavaScript.DataVisualization.DiagramEnums.ConnectorConstraints.Bridging })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connector.Constraints`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { Constraints = ConnectorConstraints.Bridging });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Defines the radius of the rounded corner</b></td>
<td>
<b>Property</b>:<i>`Connector.CornerRadius`</i>
<br>
<br>
<code>

    @{
        Collection Segment = new Collection();
        Segment.Add(new Segment() { Type = Segments.Orthogonal });
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() { CornerRadius = 15 })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connector.CornerRadius`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { CornerRadius = 5});
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Customize connectors appearance using user-defined CSS</b></td>
<td>
<b>Property</b>:<i>`Connector.CssClass`</i>
<br>
<br>
<code>

    //CSS style
    .HoverConnector:hover {
        stroke:blue
    }
</code><br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() { CssClass = "hoverConnector" })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the horizontal alignment of the connector</b></td>
<td>
<b>Property</b>:<i>`Connector.HorizontalAlign`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() {  HorizontalAlign = HorizontalAlignment.Right })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>A collection of JSON objects where each object represents a label</b></td>
<td>
<b>Property</b>:<i>`Connector.Labels`</i>

<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { Text = "Connector" });

        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connector.Annotations`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>

<b>[Model]</b>
<code>

    List<DiagramConnectorAnnotation> annotation = new List<DiagramConnectorAnnotation>();
    annotation.Add(new DiagramConnectorAnnotation() { Content = "connector" });
    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { Annotations =  annotation});
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Stroke color of the connector</b></td>
<td>
<b>Property</b>:<i>`Connector.LineColor`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() { Name = "connector1", LineColor = "blue" })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connector.Style.StrokeColor`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { Style = { StrokeColor = "blue" }});
    ViewBag.Connectors = connectors;

</code></td>
</tr>
</tr>
<tr>
<td><b>Sets the pattern of dashes and gaps used to stroke the path of the connector</b></td>
<td>
<b>Property</b>:<i>`Connector.LineDashArray`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() { LineDashArray = "2,2" })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connector.Style.StrokeDashArray`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() {  Style = { StrokeDashArray= "2, 2" }});
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Sets the width of the line</b></td>
<td>
<b>Property</b>:<i>`Connector.LineWidth`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() { LineWidth = 10 })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connector.Style.StrokeWidth`</i>
<br>
<br>
<b>[View]</b>
<code>
    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() {  Style = { StrokeWidth = 2 }});
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Defines the padding value to ease the interaction with connectors
</b></td>
<td>
<b>Property</b>:<i>`Connector.LineHitPadding`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() { LineHitPadding = 15 })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connectors.HitPadding`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { HitPadding = 20 });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Sets a unique name for the connector</b></td>
<td>
<b>Property</b>:<i>`Connector.Name`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() { Name = "connector1" })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.Id`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { Id = "connector1" });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Defines the transparency of the connector</b></td>
<td>
<b>Property</b>:<i>`Connector.Opacity`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() { Opacity = 1 })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.Style.Opacity`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { Style = { Opacity = 0.5} });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Sets the parent name of the connector.</b></td>
<td>
<b>Property</b>:<i>`Connector.Parent`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() { Parent = "parent" })).Render();
    }

</code>
</td><td>
<b>Not applicable</b>
</td>
</tr>
<tr>
<td><b>An array of JSON objects where each object represents a segment
</b></td>
<td>
<b>Property</b>:<i>`Connector.Segments`</i>
<br>
<br>
<code>

    @{
        Collection Segment = new Collection();
        Segment.Add(new Segment() { Type = Segments.Orthogonal });
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ Segments=Segment } )) .Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connector.Segments`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<Segment> segments = new List<Segment>();
    segments.Add(new Segment() { Type = Segments.Orthogonal });
    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { Segments = segments });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Sets the direction of orthogonal segment
</b></td>
<td>
<b>Property</b>:<i>`Connector.Segments.Direction`</i>
<br>
<br>
<code>

    @{
        Collection Segment = new Collection();
        Segment.Add(new Segment() { Direction = "bottom" });
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ Segments=Segment } )) .Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.Segments.Direction`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<Segment> segments = new List<Segment>();
    segments.Add(new Segment() { Direction = "Bottom" });
    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { Segments = segments });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Describes the length of orthogonal segment
</b></td>
<td>
<b>Property</b>:<i>`Connector.Segments.Length`</i>
<br>
<br>
<code>

    @{
        Collection Segment = new Collection();
        Segment.Add(new Segment() { Length = 50 });
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ Segments=Segment } )) .Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.Segments.Length`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<Segment> segments = new List<Segment>();
    segments.Add(new Segment() { Length=30 });
    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { Segments = segments });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Describes the end point of bezier/straight segment</b></td>
<td>
<b>Property</b>:<i>`Connector.Segments.Point`</i>
<br>
<br>
<code>

    @{
        Collection Segment = new Collection();
        Segment.Add(new Segment() { Point = new DiagramPoint(75, 150) });
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ Segments=Segment } )) .Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connectors.Segments.Point`</i>
<br>
<br>

</td>
</tr>
<tr>
<td><b>Defines the first control point of the bezier segment</b></td>
<td>
<b>Property</b>:<i>`Connector.Segments.Point1`</i>
<br>
<br>
<code>

    @{
        Collection Segment = new Collection();
        Segment.Add(new Segment() { Point1 = new DiagramPoint(75, 150) });
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ Segments=Segment } )) .Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connectors.Segments.Point1`</i>
<br>
<br>

</td>
</tr>

<tr>
<td><b>Defines the second control point of bezier segment</b></td>
<td>
<b>Property</b>:<i>`Connector.Segments.Point2`</i>
<br>
<br>
<code>

    @{
        Collection Segment = new Collection();
        Segment.Add(new Segment() { Point2 = new DiagramPoint(75, 150) });
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ Segments=Segment } )) .Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connectors.Segments.Point2`</i>
<br>
<br>

</td>
</tr>

<tr>
<td><b>Sets the type of the segment
</b></td>
<td>
<code>

    @{
        Collection Segment = new Collection();<br>
        Segment.Add(new Segment() { Type = Segments.Straight });<br>
        Html.EJ().Diagram("diagram")Connectors(c => c.Add(new Connector(){ Segments=Segment } )) .Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connectors.Segments.Type`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<Segment> segments = new List<Segment>();
    segments.Add(new Segment() { Type = Segments.Bezier });
    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { Segments = segments });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Describes the length and angle between the first control point and the start point of bezier segment</b></td>
<td>
<b>Property</b>:<i>`Connector.Segments.Vector1`</i>
<br>
<br>
<code>

    @{
        Collection Segment = new Collection();<br>
        Segment.Add(new Segment() { Vector1 = new Vector(75, 0) });<br>
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ Segments=Segment } )).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connectors.Segments.Vector1`</i>
<br>
<br>

</td>
</tr>

<tr>
<td><b>Describes the length and angle between the second control point and end point of bezier segment
</b></td>
<td>
<b>Property</b>:<i>`Connector.Segments.Vector2`</i>
<br>
<br>
<code>

    @{
        Collection Segment = new Collection();<br>
        Segment.Add(new Segment() { Vector2 = new Vector(75, 180) });<br>
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ Segments=Segment } )) .Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connectors.Segments.Vector2`</i>
<br>
<br>

</td>
</tr>

<tr>
<td><b>Sets the type of the connector
</b></td>
<td>
<b>Property</b>:<i>`Connector.Shape.Type`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ Shape = new Shape() { Type = Shapes.BPMN } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Connectors.Shape.Type`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { Shape= new BpmnConnectors() { Type = "Bpmn" } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Defines the source decorator of the connector
</b></td>
<td>
<b>Property</b>:<i>`Connector.SourceDecorator`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ SourceDecorator = new Decorator() { Shape=DecoratorShapes.OpenArrow } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { SourceDecorator = new DiagramDecorator () { Shape = DecoratorShapes.OpenArrow } } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Sets the border color of the source decorator</b></td>
<td>
<b>Property</b>:<i>`Connector.SourceDecorator.BorderColor`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ SourceDecorator = new Decorator() { BorderColor = "red" } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator.Style.StrokeColor`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { SourceDecorator = new DiagramDecorator () {  Style = { StrokeColor="green" } } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Sets the border width of the decorator</b></td>
<td>
<b>Property</b>:<i>`Connector.SourceDecorator.BorderWidth`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ SourceDecorator = new Decorator() { BorderWidth = 5 } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator.Style.StrokeWidth`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { SourceDecorator = new DiagramDecorator () { Style = { StrokeWidth=2 } } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Defines to customize sourceDecorator appearance using user-defined CSS
</b></td>
<td>
<b>Property</b>:<i>`Connector.SourceDecorator.CssClass`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ SourceDecorator = new Decorator() { CssClass = "className"  } })).Render();
    }

</code>
</td><td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the fill color of the source decorator
</b></td>
<td>
<b>Property</b>:<i>`Connector.SourceDecorator.FillColor`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Height("500px").Width("500px").Connectors(c => c.Add(new Connector(){SourceDecorator = new Decorator() { FillColor = "red"  } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator.Style.Fill`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Width("1000").Height("645px").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { SourceDecorator = new DiagramDecorator () {  Style = { Fill= "red" } } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Sets the height of the source decorator</b></td>
<td>
<b>Property</b>:<i>`Connector.SourceDecorator.Height`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ SourceDecorator = new Decorator() { Height = 10  } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator.Height`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { SourceDecorator = new DiagramDecorator () {  Height=10 } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Defines the custom shape of the source decorator
</b></td>
<td>
<b>Property</b>:<i>`Connector.SourceDecorator.PathData`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ SourceDecorator = new Decorator() { Shape = DecoratorShapes.Path, PathData = "M 376.892,225.284L 371.279,211.95L 376.892,198.617L 350.225,211.95L 376.892,225.284 Z"  } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator.PathData`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() {  SourceDecorator = new DiagramDecorator () { Shape = DecoratorShapes.Custom, PathData= "M 376.892,225.284 L 371.279,211.95 L 376.892,198.617 L 350.225,211.95 L 376.892,225.284 Z" } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Defines the shape of the source decorator.
</b></td>
<td>
<b>Property</b>:<i>`Connector.SourceDecorator.Shape`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ SourceDecorator = new Decorator() { Shape = OpenArrow  } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator.Shape`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { SourceDecorator = new DiagramDecorator () { Shape = DecoratorShapes.OpenArrow } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Defines the width of the source decorator
</b></td>
<td>
<b>Property</b>:<i>`Connector.SourceDecorator.Width`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram".Connectors(c => c.Add(new Connector(){ SourceDecorator = new Decorator() { Width = 10 } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator.Width`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() {  SourceDecorator = new DiagramDecorator () { Width=10 } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Sets the source node of the connector
</b></td>
<td>
<b>Property</b>:<i>`Connector.SourceNode`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ SourceNode = "source" })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceID`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { SourceID="source" } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Defines the space to be left between the source node and the source point of a connector</b></td>
<td>
<b>Property</b>:<i>`Connector.SourcePadding`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ SourcePadding = 2 })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.HitPadding`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() {HitPadding=2 });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Describes the start point of the connector
</b></td>
<td>
<b>Property</b>:<i>`Connector.SourcePoint`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){SourcePoint = new DiagramPoint(100, 100) })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourcePoint`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { SourcePoint = { X= 100, Y=100} } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Sets the source port of the connector
</b></td>
<td>
<b>Property</b>:<i>`Connector.SourcePort`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ SourcePort = "sourcePort" })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourcePortID`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() {  SourceID="source", SourcePortID="sourcePortId" });
    ViewBag.Connectors = connectors;

</code></td>

</tr>

<tr>
<td><b>Defines the target decorator of the connector
</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetDecorator`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ TargetDecorator = new Decorator() { Shape=DecoratorShapes.OpenArrow } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { TargetDecorator = new DiagramDecorator () { Shape = DecoratorShapes.OpenArrow } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Sets the border color of the target decorator</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetDecorator.BorderColor`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ TargetDecorator = new Decorator() { BorderColor = "red" } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator.Style.StrokeColor`</i>
<br>
<br>
<code>
<b>[View]</b>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { TargetDecorator = new DiagramDecorator () { Style = { StrokeColor="green" } } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Sets the border width of the decorator</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetDecorator.BorderWidth`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ TargetDecorator = new Decorator() { Shape=DecoratorShapes.OpenArrow, BorderWidth = 5 } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator.Style.StrokeWidth`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { TargetDecorator = new DiagramDecorator () { Style = { StrokeWidth=2 } }});
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Defines to customize target Decorator appearance using user-defined CSS
</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetDecorator.CssClass`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ TargetDecorator = new Decorator() { CssClass = "className" } })).Render();
    }

</code>
</td><td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Sets the fill color of the target decorator
</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetDecorator.FillColor`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ TargetDecorator = new Decorator() { FillColor = "red" } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator.Style.Fill`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { TargetDecorator = new DiagramDecorator () { Style = {Fill= "red" }} });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Sets the height of the target decorator</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetDecorator.Height`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ TargetDecorator = new Decorator() { Height = 10 } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator.Height`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Width("1000").Height("645px").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { TargetDecorator = new DiagramDecorator () { Height=10 } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Defines the custom shape of the target decorator
</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetDecorator.PathData`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ TargetDecorator = new Decorator() { shape: DecoratorShapes.Path,
        pathData: "M 376.892,225.284 L 371.279,211.95 L 376.892,198.617 L 350.225,211.95 L 376.892,225.284 Z" } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator.PathData`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { TargetDecorator = new DiagramDecorator () { Shape = DecoratorShapes.Custom, PathData= "M 376.892,225.284 L 371.279,211.95 L 376.892,198.617 L 350.225,211.95 L 376.892,225.284 Z" } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Defines the shape of the target decorator.
</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetDecorator.Shape`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ TargetDecorator = new Decorator() { Shape = DecoratorShapes.OpenArrow } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator.Shape`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Width("1000").Height("645px").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { TargetDecorator = new DiagramDecorator () { Shape = DecoratorShapes.OpenArrow } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Defines the width of the target decorator
</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetDecorator.Width`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ TargetDecorator = new Decorator() { Width = 10 } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator.Width`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { TargetDecorator = new DiagramDecorator () { Width=10 } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Sets the target node of the connector
</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetNode`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ TargetNode = "target" })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetID`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() {  TargetID="target" });
    ViewBag.Connectors = connectors;

</code></td>
</tr>
<tr>
<td><b>Defines the space to be left between the target node and the target point of a connector</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetPadding`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ TargetPadding = 2 })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.HitPadding`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { TargetDecorator = new DiagramDecorator () { HitPadding = 2 });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Describes the start point of the connector
</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetPoint`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){Name = "connector1", TargetPoint = new DiagramPoint(200, 200)})).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetPoint`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { TargetPoint = { X = 200, Y = 200 } } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Sets the target port of the connector
</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetPort`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector(){ TargetPort = "targetPort" })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetPortID`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { TargetID="target", TargetPortID="targetPortId" });
    ViewBag.Connectors = connectors;

</code>
</td>
</tr>

<tr>
<td><b>Defines the tooltip that should be shown when the mouse hovers over connector
</b></td>
<td>
<b>Property</b>:<i>`Connector.Tooltip`</i>
<br>
<br>
<code>
    <script type="text/x-jsrender" id="mouseovertooltip"><br>
        <div style="background-color: #F08080; color: white; white-space: nowrap; height: 20px"><br>
            <span style="padding: 5px;">  </span><br>
        </div><br>
    </script>
<br>

    @{
        Html.EJ().Diagram("diagram").Height("500px").Width("500px").Connectors(c => c.Add(new Connector() { Name = "connector1", SourcePoint = new DiagramPoint(100, 100), TargetPoint = new DiagramPoint(200, 200), Segments = Segment, Tooltip = new Tooltip() { TemplateId = "mouseOverTooltip"} } })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.Tooltip`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { Constraints=ConnectorConstraints.Default | ConnectorConstraints.Tooltip, Tooltip = { Content = "Connector" } });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Sets the vertical alignment of connector
</b></td>
<td>
<b>Property</b>:<i>`Connector.VerticalAlign`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() { VerticalAlign= VerticalAlignment.Bottom})).Render();
    }

</code>
</td><td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Enables or disables the visibility of connector
</b></td>
<td>
<b>Property</b>:<i>`Connector.Visible`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() { Visible= false })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.Visible`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { Visible = true });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Sets the z-index of the connector
</b></td>
<td>
<b>Property</b>:<i>`Connector.ZOrder`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() { ZOrder = 3 })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Connectors.ZIndex`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Connectors(ViewBag.Connectors).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramConnector> connectors = new List<DiagramConnector>();
    connectors.Add(new DiagramConnector() { ZIndex = -1 });
    ViewBag.Connectors = connectors;

</code></td>
</tr>

<tr>
<td><b>Enables/Disables the default behaviors of the diagram
</b></td>
<td>
<b>Property</b>:<i>`Constraints`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Connectors(c => c.Add(new Connector() { Constraints=ConnectorConstraints.Default | ConnectorConstraints.Bridging })).Render();
    }

</code>
</td><td>
<b>Property</b>:<i>`Constraints`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Constraints(DiagramConstraints.Default | DiagramConstraints.Bridging).Render()

<code>
</code></td>
</tr>
</table>

## ContextMenu

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Defines the collection of context menu items</b></td>
<td>
<b>Property</b>:<i>`ContextMenu.Items`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Name = "HyperLink" });
    Model.ContextMenu = new DiagramContextMenu()
    {
        Items = menuItems
    };
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Items`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").ContextMenuSettings(ViewBag.contextMenuSettings).Render()

</code>
<b>[Model]</b>
<code>

    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Text = "delete" });
    DiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        Items = menuItems
    };
    ViewBag.contextMenuSettings = contextMenuSettings;

</code></td>
</tr>

<tr>
<td><b>Defines the text for the collection of context menu item</b></td>
<td>
<b>Property</b>:<i>`ContextMenu.Items.Text`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Text = "Text" });
    Model.ContextMenu = new DiagramContextMenu()
    {
        Items = menuItems
    };
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Items.Text`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").ContextMenuSettings(ViewBag.contextMenuSettings).Render()

</code>
<b>[Model]</b>
<code>

    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Text = "delete" });
    DiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        Items = menuItems
    };
    ViewBag.contextMenuSettings = contextMenuSettings;

</code></td>
</tr>

<tr>
<td><b>Defines the name for the collection of context menu items</b></td>
<td>
<b>Property</b>:<i>`ContextMenu.Items.Name`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Name = "HyperLink" });
    Model.ContextMenu = new DiagramContextMenu()
    {
        Items = menuItems
    };
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Items.Id`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").ContextMenuSettings(ViewBag.contextMenuSettings).Render()

</code>
<b>[Model]</b>
<code>

    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Id = "id" });
    DiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        Items = menuItems
    };
    ViewBag.contextMenuSettings = contextMenuSettings;

</code></td>
</tr>

<tr>
<td><b>Defines the image url for the collection of context menu items</b></td>
<td>
<b>Property</b>:<i>`ContextMenu.Items.ImageUrl`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { ImageUrl = "Images/zoomIn.Png" });
    Model.ContextMenu = new DiagramContextMenu()
    {
        Items = menuItems
    };
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Items.Url`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").ContextMenuSettings(ViewBag.contextMenuSettings).Render()

</code>
<b>[Model]</b>
<code>

    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Url = "Images/zoomIn.Png" });
    DiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        Items = menuItems
    };
    ViewBag.contextMenuSettings = contextMenuSettings;

</code></td>
</tr>
<tr>
<td><b>Defines the cssClass for the collection of context menu items</b></td>
<td>
<b>Property</b>:<i>`ContextMenu.Items.CssClass`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { CssClass = "menu" });
    Model.ContextMenu = new DiagramContextMenu()
    {
        Items = menuItems
    };
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Items.IconCss`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").ContextMenuSettings(ViewBag.contextMenuSettings).Render()

</code>
<b>[Model]</b>
<code>

    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { IconCss = "e-copy" });
    DiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        Items = menuItems
    };
    ViewBag.contextMenuSettings = contextMenuSettings;

</code></td>
</tr>
<tr>
<td><b>Defines the collection of sub items for the context menu items</b></td>
<td>
<b>Property</b>:<i>`ContextMenu.Items.SubItems`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    List<ContextMenuItem> SubItems = new List<ContextMenuItem>();
    SubItems.Add(new ContextMenuItem() { Name = "HyperLink" });
    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { SubItems = SubItems });
    Model.ContextMenu = new DiagramContextMenu()
    {
        Items = menuItems
    };
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Items.Items`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").ContextMenuSettings(ViewBag.contextMenuSettings).Render()

</code>
<b>[Model]</b>
<code>

    List<ContextMenuItem> SubItems = new List<ContextMenuItem>();
    SubItems.Add(new ContextMenuItem() { Id = "id" });
    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Items = SubItems });
    DiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        Items = menuItems
    };
    ViewBag.contextMenuSettings = contextMenuSettings;

</code></td>
</tr>
<tr>
<td><b>Set whether to display the default context menu items or not</b></td>
<td>
<b>Property</b>:<i>`ContextMenu.ShowCustomMenuItemsOnly`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.ContextMenu = new DiagramContextMenu()
    {
        ShowCustomMenuItemsOnly = true
    };
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.ShowCustomMenuOnly`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").ContextMenuSettings(ViewBag.contextMenuSettings).Render()

</code>
<b>[Model]</b>
<code>

    LDiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        ShowCustomMenuOnly = false
    };
    ViewBag.contextMenuSettings = contextMenuSettings;

</code></td>
</tr>

<tr>
<td><b>Specifies separator between the menu items</b></td>
<td>
<b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Items.Separator`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").ContextMenuSettings(ViewBag.contextMenuSettings).Render()

</code>
<b>[Model]</b>
<code>

    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Separator = true });
    DiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        Items = menuItems
    };
    ViewBag.contextMenuSettings = contextMenuSettings;

</code></td>
</tr>

<tr>
<td><b>Define the target to show the menu item.</b></td>
<td>
<b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Items.Target`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").ContextMenuSettings(ViewBag.contextMenuSettings).Render()

</code>
<b>[Model]</b>
<code>

    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Target = ".E-diagramcontent" });
    DiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        Items = menuItems
    };
    ViewBag.contextMenuSettings = contextMenuSettings;

</code></td>
</tr>

<tr>
<td><b>Enables/Disables the context menu items</b></td>
<td>
<b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Show`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").ContextMenuSettings(ViewBag.contextMenuSettings).Render()

</code>
<b>[Model]</b>
<code>

    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Id = "id" });
    DiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        Show = true
    };
    ViewBag.contextMenuSettings = contextMenuSettings;

</code></td>
</tr>
</table>

## DataSourceSettings

<!-- markdownlint-disable MD033 -->

<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>Defines the data source either as a collection of objects or as an instance of ej.DataManager</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.DataSource`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.DataSource = getDatasource();
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`DataSourceSettings.DataManager`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").DataSourceSettings(ViewBag.dataSource).Render()

</code>
<b>[Model]</b>
<code>

    DiagramDataSource dataSource = new DiagramDataSource()
    {
        DataManager = items
    };
    ViewBag.dataSource = dataSource;

</code></td>
</tr>
<tr>
<td><b>Sets the unique id of the data source items</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.Id`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.Id = "ID";
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`DataSourceSettings.Id`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").DataSourceSettings(ViewBag.dataSource).Render()

</code>
<b>[Model]</b>
<code>

    DiagramDataSource dataSource = new DiagramDataSource()
    {
        Id = "Id"
    };
    ViewBag.dataSource = dataSource;

</code></td>
</tr>
<tr>
<td><b>Defines the parent id of the data source item</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.Parent`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.Parent = "ReportingPerson";
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ParentId`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").DataSourceSettings(ViewBag.dataSource).Render()

</code>
<b>[Model]</b>
<code>

    DiagramDataSource dataSource = new DiagramDataSource()
    {
        ParentId = "ReportingPerson"
    };
    ViewBag.dataSource = dataSource;

</code></td>
</tr>
<tr>
<td><b>Describes query to retrieve a set of data from the specified datasource</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.Query`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.Query = "datasource query";
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the unique id of the root data source item</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.Root`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.Root = "E1";
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`DataSourceSettings.Root`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").DataSourceSettings(ViewBag.dataSource).Render()

</code>
<b>[Model]</b>
<code>

    DiagramDataSource dataSource = new DiagramDataSource()
    {
        Root = "E1"
    };
    ViewBag.dataSource = dataSource;

</code></td>
</tr>
<tr>
<td><b>Describes the name of the table on which the specified query has to be executed</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.TableName`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.TableName = "datasource table name";
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Specifies the method name which is used to get the updated data from client side to the server side
</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.CrudAction`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.CrudAction = { Read = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/GetNodes" }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Specifies the create method which is used to get the nodes to be added from client side to the server side
</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.CrudAction.Create`</i>
<br>
<br>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.CrudAction = { Create = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/AddNodes" }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Specifies the update method which is used to get the updated data from client side to the server side
</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.CrudAction.Update`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.CrudAction = { Update = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/UpdateNodes" }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Specifies the destroy method which is used to get the deleted items data from client side to the server side
</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.CrudAction.Destroy`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.CrudAction = { Destroy = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/DeleteNodes" }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Specifies the read method to get the created nodes from client side to the server side
</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.CrudAction.Read`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.CrudAction = { Read = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/GetNodes" }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Defines the data source either as a collection of objects or as an instance of ej.DataManager</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.CustomFields`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.CustomFields = new List<string>()
    {
        "Description",
        "Color"
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`DataSourceSettings.Data`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").DataSourceSettings(ViewBag.dataSource).Render()

</code>
<b>[Model]</b>
<code>

    DiagramDataSource dataSource = new DiagramDataSource()
    {
        Data = new List<string>()
        {
            "Description",
            "Color"
        }
    };
    ViewBag.dataSource = dataSource;

</code></td>
</tr>
<tr>
<td><b>Defines the data source either as a collection of objects or as an instance of ej.DataManager</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
        DataSource = DiagramContext.HierarchicalDetails.ToList(),
        SourceNode = "SourceNode",
        TargetNode = "TargetNode",
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Sets the datasource for the connection datasource settings items</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource.DataSource`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
        DataSource = DiagramContext.HierarchicalDetails.ToList()
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Sets the unique id of the connection data source item</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource.Id`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
        Id = "id"
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the source node of the connection data source item</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource.SourceNode`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
        SourceNode = "SourceNode"
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the target node of the connection data source item</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource.TargetNode`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
        TargetNode = "TargetNode"
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the sourcePointX value of the connection data source item</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource.SourcePointX`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
        SourcePointX = "200"
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the sourcePointY value of the connection data source item</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource.SourcePointY`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
        SourcePointY = "300"
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the targetPoint-x value of the connection data source item</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource.TargetPointX`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
        TargetPointX = "100"
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the targetPoint-y value of the connection data source item</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource.TargetPointY`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
        TargetPointY = "100"
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Specifies the method name which is used to get updated connectors from client side to the server side</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource.CrudAction`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
         CrudAction = { Create = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/AddConnectors" }
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Specifies the create method which is used to get the connectors to be added from client side to the server side</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource.CrudAction.Create`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
         CrudAction = { Create = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/AddConnectors" }
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Specifies the update method which is used to get the updated connectors from client side to the server side</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource.CrudAction.Update`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
         CrudAction = {
            Update = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/UpdateConnectors" }
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Specifies the destroy method which is used to get the deleted items data from client side to the server side</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource.CrudAction.Destroy`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
         CrudAction = { Destroy = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/DeleteConnectors" }
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Specifies the read method which is used to get the data from client side to the server side</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource.CrudAction.Read`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
         CrudAction = { Read = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/GetConnectors" }
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Specifies the custom fields to get the updated data from client side to the server side</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ConnectionDataSource.CustomFields`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties).Render();

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DataSourceSettings.ConnectionDataSource = new ConnectionDataSourceSettings()
    {
        CustomFields = new List<string>()
        {
            "Description",
            "Color",
        }
    }
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
</table>

## DefaultSettings

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>Initializes the default values for nodes and connectors</b></td>
<td>
<b>Property</b>:<i>`DefaultSettings.Node`</i>
<br>
<br>
<code>

    @{
        Node defaultNode = new Node() { FillColor = "red" };
        Html.EJ().Diagram("diagram").DefaultSettings(d=>d.Node(defaultNode)).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`GetNodeDefaults`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").GetNodeDefaults("getNodeDefaults")

</code>
<code>

    function getNodeDefaults(obj, diagram) {
        obj.Shape = { type: 'Basic', shape: 'Rectangle', cornerRadius: 10 };
        obj.Width = 80;
        obj.Style.StrokeWidth = 2;
        obj.Style.StrokeColor = '#6F409F';
        obj.Height = 35;
    }

</code></td>
</tr>

<tr>
<td><b>Initializes the default connector properties</b></td>
<td>
<b>Property</b>:<i>`DefaultSettings.Connector`</i>
<br>
<br>
<code>

    @{
        Connector defaultConnector = new Connector() { LineColor = "red", LineWidth = 4, LineDashArray = "2,2" };
        Html.EJ().Diagram("diagram").DefaultSettings(d=>d.Connector(defaultConnector)).Render();
    }

</code>
</code>
</td>
<td>
<b>Property</b>:<i>`GetConnectorDefaults`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").GetConnectorDefaults("getConnectorDefaults").Render()

</code>
<code>

    function getConnectorDefaults(obj, diagram) {
        obj.Type = 'Bezier';
        obj.Style.StrokeColor = '#6f409f';
        obj.Style.StrokeWidth = 2;
        obj.TargetDecorator = {
            style: {
                strokeColor: '#6f409f',
                fill: '#6f409f',
            }
        }
    }

</code></td>
</tr>

<tr>
<td><b>Initializes the default properties of groups</b></td>
<td>
<b>Property</b>:<i>`DefaultSettings.Group`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    Group defaultNode = new Group() { Constraints = NodeConstraints.Default | ~NodeConstraints.Drag };
    Model.DefaultSettings.Group = defaultNode;
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>
</table>

## DrawType

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>Sets the type of JSON object to be drawn through drawing tool</b></td>
<td>
<b>Property</b>:<i>`DrawType`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    Model.DrawType = { Type: "node" };
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`DrawingObject`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Created("diagramCreated").Render()

</code>
<code>

    function diagramCreated() {
        diagram = document.GetElementById("diagram").Ej2_instances[0];
        diagram.DrawingObject = { shape: { type: 'Basic', shape: 'Rectangle' } };
        diagram.Tool = ej.Diagrams.DiagramTools.ContinuousDraw;
        diagram.DataBind();
    }

</code></td>
</tr>
</table>

## EnableAutoScroll

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>Enables or disables auto scroll in diagram</b></td>
<td>
<b>Property</b>:<i>`EnableAutoScroll`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").EnableAutoScroll(false).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`CanAutoScroll`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").ScrollSettings(new DiagramScrollSettings() { CanAutoScroll = true}).Render()

</code>
<b>[Model]</b>
<code>
</code></td>
</tr>
</table>

## EnableContextMenu

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>Enables or disables diagram context menu</b></td>
<td>
<b>Property</b>:<i>`EnableContextMenu`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").EnableContextMenu(true).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Show`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").ContextMenuSettings(new DiagramContextMenuSettings() { Show = true}).Render()

</code></td>
</tr>
</table>

## GetCustomCursor

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Enable or disable rendering component with custom cursor</b></td>
<td><b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`GetCustomCursor`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").GetCustomCursor("getCustomCursor").Render()

</code>
<code>

    function getCustomCursor(action, active) {
        var cursor;
        if (active && action === 'Drag') {
            cursor = '-webkit-grabbing';
        } else if (action === 'Drag') {
            cursor = '-webkit-grabbing'
        }
        return cursor;
    }

</code></td>
</tr>
</table>

## GetCustomProperty

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Allows to get the custom properties that have to be serialized<b></td>
<td><b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`GetCustomProperty`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").GetCustomProperty("getCustomProperty").Render()

</code>
<code>

    function getCustomProperty(key: string) {
        if (key === 'nodes') {
            return ['description'];
            }
        return null;
    }

</code></td>
</tr>
</table>

## GetDescription

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Allows to get the custom description<b></td>
<td><b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`GetDescription`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").GetDescription("getAccessibility").Render()

</code>
<code>

    function getAccessibility(object, diagram) {
        var value;
        if (object.propName == "connectors") {
            value = 'clicked on Connector';
        } else {
            value = undefined;
        }
        return value;
    }

</code></td>
</tr>
</table>

## GetCustomTool

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Allows to get the custom tool<b></td>
<td><b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`GetCustomTool`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Width("1000").Height("645px").GetCustomTool("getTool")

<code>
</code>

    function getTool(action) {
        var tool;
        if (action === 'userHandle') {
            tool = new CloneTool(diagram.CommandHandler, true);
        }
        return tool;
    }
    class CloneTool extends ToolBase {
        public mouseDown(args) {
            super.MouseDown(args);
            diagram.Copy();
            diagram.Paste();
        }
    }

</code></td>
</tr>
</table>

## Height

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>Specifies the height of the diagram</b></td>
<td>
<b>Property</b>:<i>`Height`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Height("500px").Render();
    }

</code>
<code>
</td>
<td>
<b>Property</b>:<i>`Height`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Height("645px").Render()

</code></td>
</tr>
</table>

## HistoryManager

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>
<tr>
<td><b>A method that takes a history entry as argument and returns whether the specific entry can be popped or not</b></td>
<td>
<b>Property</b>:<i>`HistoryManager.CanPop`</i>
<br>
<br>
<code>

    <script>
        var diagram = $("#diagramcontent").EjDiagram("instance");
        var entry = { object: node, prevState: node.employeeData };
        diagram.Model.HistoryManager.Push(entry);
        var value = { role: "New role" };
        node.employeeData = value;
        if(diagram.Model.HistoryManager.CanPop(entry)){
            diagram.Model.HistoryManager.Pop();
        }
    </script>

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>A method that ends grouping the changes</b></td>
<td>
<b>Property</b>:<i>`HistoryManager.CloseGroupAction`</i>
<br>
<br>
<code>

    <script>
        var group = diagram.Model.SelectedItems;
        diagram.Model.HistoryManager.StartGroupAction();
        for (var i = 0; i < group.Children.Length; i++) {
            var option = {};
            var item = group.Children[i];
            // Updates the fillColor for all the child elements.
            option.FillColor = args.Style.BackgroundColor;
            diagram.UpdateNode(item.Name, option);
        }
        diagram.Model.HistoryManager.CloseGroupAction();
    </sccript>

</code>
</td>
<td>
<b>Property</b>:<i>`HistoryList.EndGroupAction`</i>
<br>
<br>
<code>

    <script>
        var diagram = document.getElementById("container").ej2_instances[0];
        var objects = [];
        objects.Push(diagram.Nodes[0], diagram.Nodes[1], diagram.Connectors[0]);
        diagram.HistoryList.StartGroupAction();
        diagram.Distribute('Top', objects);
        diagram.Distribute('Bottom', objects);
        diagram.Distribute('BottomToTop', objects);
        diagram.HistoryList.EndGroupAction();
    </script>

</code></td>
</tr>
<tr>
<td><b>A method that removes the history of a recent change made in diagram</b></td>
<td>
<b>Property</b>:<i>`HistoryManager.Pop`</i>
<br>
<br>
<code>

    <script>
        var diagram = $("#diagramcontent").EjDiagram("instance");
        diagram.Model.HistoryManager.Pop();
    </script>

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>A method that allows to track the custom changes made in diagram</b></td>
<td>
<b>Property</b>:<i>`HistoryManager.Push`</i>
<br>
<br>
<code>

    <script>
        var diagram = $("#diagramcontent").EjDiagram("instance");
        var entry = { object: node, prevState: node.employeeData };
        diagram.Model.HistoryManager.Push(entry);
        var value = { role: "New role" };
        node.employeeData = value;
    </script>

</code>
</td>
<td>
<b>Property</b>:<i>`HistoryList.Push`</i>
<br>
<br>
<code>

    <script>
        var diagram = document.getElementById("container").ej2_instances[0];
        var object = diagram.Nodes[0];
        object['description'] = (document.GetElementById('custom') as HTMLSelectElement).Value;
        var entry = { undoObject: object };
        diagram.HistoryList.Push(entry);
        diagram.DataBind();
    </script>

</code></td>
</tr>
<tr>
<td><b>Defines what should be happened while trying to restore a custom change</b></td>
<td>
<b>Property</b>:<i>`HistoryManager.Redo`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    Model.HistoryManager = new HistoryManager()
    {
        Redo = "customUndoRedo"
    }
    ViewData["diagramModel"] = Model;

</code>
<code>

    function customUndoRedo(args) {
        var diagram = $("#diagramcontent").EjDiagram("instance");
        var node = args.Object;
        var currentState = node.employeeData;
        node.employeeData = args.PrevState;
        args.PrevState = currentState;
    }

</code>
</td>
<td>
<b>Property</b>:<i>`HistoryList.Redo`</i>
<br>
<br>
<code>

    <script>
        var diagram = document.getElementById("container").ej2_instances[0];
        var node1 = diagram.Nodes[0];
        node1['customName'] = 'customNode';
        entry = {
            undoObject: node1
        };
        diagram.HistoryList.Push(entry);
        diagram.HistoryList.Undo = function(args: HistoryEntry) {
            args.RedoObject = cloneObject(args.UndoObject) as NodeModel;
            args.UndoObject['customName'] = 'customNodeChange';
        }
        diagram.HistoryList.Redo = function(args: HistoryEntry) {
            var current = cloneObject(args.UndoObject) as NodeModel;
            args.UndoObject['customName'] = args.RedoObject['customName'];
            args.RedoObject = current;
        }
    </script>

</code>
</td>
</tr>
<tr>
<td><b>Gets the number of redo actions to be stored on the history manager. Its an read-only property and the collection should not be modified</b></td>
<td>
<b>Property</b>:<i>`HistoryManager.RedoStack`</i>
<br>
<br>
<code>

    <script>
        var diagram = $("#diagramcontent").EjDiagram("instance");
        diagram.Model.HistoryManager.RedoStack();
    </script>

</code>
</td>
<td>
<b>Property</b>:<i>`HistoryList.RedoStack`</i>
<br>
<br>
<code>

    <script>
        var diagram = document.getElementById("container").ej2_instances[0];
        diagram.AppendTo('#diagram');
        diagram.HistoryList.RedoStack();
    </script>

</code></td>
</tr>
<tr>
<td><b>Restricts the undo and redo actions to a certain limit</b></td>
<td>
<b>Property</b>:<i>`HistoryManager.StackLimit`</i>
<br>
<br>
<code>

    <script>
        var diagram = $("#diagramcontent").EjDiagram("instance");
        diagram.Model.HistoryManager.StackLimit();
    </script>

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>A method that starts to group the changes to revert/restore them in a single undo or redo</b></td>
<td>
<b>Property</b>:<i>`HistoryManager.StartGroupAction`</i>
<br>
<br>
<code>

    <script>
        var group = diagram.Model.SelectedItems
        diagram.Model.HistoryManager.StartGroupAction();
        for (var i = 0; i < group.Children.Length; i++) {
            var option = {};
            var item = group.Children[i];
            option.FillColor = args.Style.BackgroundColor;
            diagram.UpdateNode(item.Name, option);
        }
        diagram.Model.HistoryManager.CloseGroupAction();
    </script>

</code>
</td>
<td>
<b>Property</b>:<i>`HistoryList.StartGroupAction`</i>
<br>
<br>
<code>

    <script>
        var diagram = document.getElementById("container").ej2_instances[0];
        var objects = [];
        objects.Push(diagram.Nodes[0], diagram.Nodes[1], diagram.Connectors[0]);
        diagram.HistoryList.StartGroupAction();
        diagram.Distribute('Top', objects);
        diagram.Distribute('Bottom', objects);
        diagram.Distribute('BottomToTop', objects);
        diagram.HistoryList.EndGroupAction();
    </script>

</code>
</td>
</tr>
<tr>
<td><b>Defines what should be happened while trying to revert a custom change</b></td>
<td>
<b>Property</b>:<i>`HistoryManager.Undo`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").HistoryManager(h=>h.Undo("customUndoRedo").Redo("customUndoRedo")).Render();
    }

</code>
<code>

    <script>
        function customUndoRedo(args) {
            var diagram = $("#diagramcontent").EjDiagram("instance");
            var node = args.Object;
            var currentState = node.employeeData;
            node.employeeData = args.PrevState;
            args.PrevState = currentState;
        }
    </script>

</code>
</td>
<td>
<b>Property</b>:<i>`HistoryList.Undo`</i>
<br>
<br>
<code>

    <script>
        var diagram = document.getElementById("container").ej2_instances[0];
        diagram.HistoryList.Push(entry);
        diagram.HistoryList.Undo = function(args: HistoryEntry) {
            args.RedoObject = cloneObject(args.UndoObject) as NodeModel;
            args.UndoObject['customName'] = 'customNodeChange';
        }
        diagram.HistoryList.Redo = function(args: HistoryEntry) {
            var current = cloneObject(args.UndoObject) as NodeModel;
            args.UndoObject['customName'] = args.RedoObject['customName'];
            args.RedoObject = current;
        }
    </script>

</code>
</tr>
<tr>
<td><b>Gets the number of undo actions to be stored on the history manager. Its an read-only property and the collection should not be modified</b></td>
<td>
<b>Property</b>:<i>`HistoryManager.UndoStack`</i>
<br>
<br>
<code>

    <script>
        var diagram = $("#diagramcontent").EjDiagram("instance");
        diagram.Model.HistoryManager.UndoStack();
    </script>

</code>
</td>
<td>
<b>Property</b>:<i>`HistoryList.UndoStack`</i>
<br>
<br>
<code>

    <script>
        var diagram = document.getElementById("container").ej2_instances[0];
        diagram.HistoryList.UndoStack();
    </script>

</code></td>
</tr>
<tr>
<td><b>Set the current entry object</b></td>
<td>
<b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`HistoryList.CurrentEntry`</i>
<br>
<br>
<code>

    <script>
        var diagram = document.getElementById("container").ej2_instances[0];
        diagram.HistoryList.CurrentEntry();
    </script>

</code></td>
</tr>
<tr>
<td><b>Set the history entry can be undo</b></td>
<td>
<b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`HistoryList.CanUndo`</i>
<br>
<br>
<code>

    <script>
        var diagram = document.getElementById("container").ej2_instances[0];
        diagram.HistoryList.CanUndo = true;
    </script>

</code></td>
</tr>
<tr>
<td><b>Set the history entry can be redo</b></td>
<td>
<b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`HistoryList.CanRedo`</i>
<br>
<br>
<code>

    <script>
        var diagram = document.getElementById("container").ej2_instances[0];
        diagram.HistoryList.CanRedo = true;
    </script>

</code></td>
</tr>
<tr>
<td><b>Used to decide to stored the changes to history</b></td>
<td>
<b>Property</b>:<i>`HistoryManager.CanLog`</i>
<br>
<br>
<code>

    var diagram = $("#diagramcontent").EjDiagram("instance");
    diagram.Model.HistoryManager.CanLog();

</code>
</td></td>
<td>
<b>Property</b>:<i>`HistoryList.CanLog`</i>
<br>
<br>
<code>

    <script>
        var diagram = document.getElementById("container").ej2_instances[0];
        diagram.HistoryList.CanLog = function (entry: HistoryEntry) {
                entry.Cancel = true;
                return entry;
        }
    </script>

</code></td>
</tr>
</table>

## Layout

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Specifies the custom bounds to arrange/align the layout</b></td>
<td>
<b>Property</b>:<i>`Layout.Bounds`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Layout(l=>l.Bounds(new Rectangle() { X = 10, Y = 10, Width = 100, Height = 100 })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.Bounds`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.Bounds("getBounds")).Render();

</code>
<br>
<br>
<code>
    <script>
        function getBounds() {
            var bounds = { X = 10, Y = 10, Width = 100, Height = 100 };
            return bounds;
        }
    </script>

</code>
</td>
</tr>

<tr>
<td><b>Defines the fixed node with reference to which, the layout will be arranged and fixed node will not be repositioned</b></td>
<td>
<b>Property</b>:<i>`Layout.FixedNode`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Layout(l=>l.FixedNode("nodeName")).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.FixedNode`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.FixedNode("node")).Render();

</code></td>
</tr>

<tr>
<td><b>Customizes the orientation of trees/sub trees</b></td>
<td>
<b>Property</b>:<i>`Layout.GetLayoutInfo`</i>
<br>
<br>
<code>

    <script>
        function getLayoutInfo(diagram, node, options) {
            options.Orientation = "vertical";
            options.Type = "left"; offset = 10;
        };
    </script>

</code>
<code>

    @{
        Html.EJ().Diagram("diagram").Layout(l=>l.GetLayoutInfo("getLayoutInfo")).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.GetLayoutInfo`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.GetLayoutInfo("getLayoutInfo")).Render();

</code>
<code>

    <script>
        function getLayoutInfo(node, options) {
            if (node.Data.Role === 'General Manager') {
                options.Assistants.Push(options.Children[0]);
                options.Children.Splice(0, 1);
            }
            if (!options.HasSubTree) {
                options.Type = 'Right';
            }
        }
    </script>

</code>
</td>
</tr>

<tr>
<td><b>Defines a method to customize the segments based on source and target nodes</b></td>
<td>
<b>Property</b>:<i>`Layout.GetConnectorSegments`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Layout(l=>l.GetConnectorSegments("getConnectorSegments")).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.ConnectorSegments`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.ConnectorSegments(ConnectorSegments.Default)).Render();

</code></td>
</tr>

<tr>
<td><b>Sets the space to be horizontally left between nodes</b></td>
<td>
<b>Property</b>:<i>`Layout.HorizontalSpacing`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Layout(l=>l.HorizontalSpacing(50)).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.HorizontalSpacing`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.HorizontalSpacing(50)).Render();

</code></td>
</tr>

<tr>
<td><b>Defines the space to be left between layout bounds and layout</b></td>
<td>
<b>Property</b>:<i>`Layout.Margin`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Layout(l=>l.Margin(new Margin() { Left = 20, Right = 20, Top = 20, Bottom = 20 })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.Margin`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.Margin(m=> m.Top(50).Bottom(0).Left(50).Right(0))).Render();

</code></td>
</tr>

<tr>
<td><b>Defines how to horizontally align the layout within the layout bounds</b></td>
<td>
<b>Property</b>:<i>`Layout.HorizontalAlignment`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Layout(l=>l.HorizontalAlignment(HorizontalAlignment.Center)).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.HorizontalAlignment`</i>
<br>
<br>
<code>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.HorizontalAlignment(HorizontalAlignment.Center)).Render();

</code>
</code></td>
</tr>

<tr>
<td><b>Defines how to vertically align the layout within the layout bounds</b></td>
<td>
<b>Property</b>:<i>`Layout.VerticalAlignment`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Layout(l=>l.VerticalAlignment(VerticalAlignment.Center)).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.VerticalAlignment`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.VerticalAlignment(VerticalAlignment.Top)).Render();

</code></td>
</tr>

<tr>
<td><b>Sets the orientation/direction to arrange the diagram elements</b></td>
<td>
<b>Property</b>:<i>`Layout.Orientation`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Layout(l=>l.Orientation(LeftToRight)).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.Orientation`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.Orientation(LayoutOrientation.TopToBottom)).Render();

</code></td>
</tr>

<tr>
<td><b>Sets the type of the layout based on which the elements will be arranged</b></td>
<td>
<b>Property</b>:<i>`Layout.Type`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Layout(l=>l.Type(LayoutTypes.HierarchicalTree)).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.Type`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.Type(LayoutType.OrganizationalChart)).Render();

</code></td>
</tr>

<tr>
<td><b>Sets the space to be vertically left between nodes</b></td>
<td>
<b>Property</b>:<i>`Layout.VerticalSpacing`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Layout(l=>l.VerticalSpacing(50)).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.VerticalSpacing`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.VerticalSpacing(50)).Render();

</code></td>
</tr>

<tr>
<td><b>Sets the value is used to define the root node of the layout</b></td>
<td>
<b>Property</b>:<i>`Layout.Root`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    Model.Layout.Root = "nodeName";
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.Root`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.Root("nodeName")).Render();

</code></td>
</tr>

<tr>
<td><b>Defines how long edges should be, ideally. This will be the resting length for the springs</b></td>
<td>
<b>Property</b>:<i>`Layout.SpringFactor`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    Model.Layout.SpringFactor = .4F;
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.SpringFactor`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.SpringFactor(0.8)).Render();

</code></td>
</tr>

<tr>
<td><b>Defines how long edges should be, ideally. This will be the resting length for the springs</b></td>
<td>
<b>Property</b>:<i>`Layout.MaxIteration`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    Model.Layout.MaxIteration = 50;
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.MaxIteration`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.MaxIteration(500)).Render();

</code></td>
</tr>

<tr>
<td><b>Defines how long edges should be, ideally. This will be the resting length for the springs</b></td>
<td>
<b>Property</b>:<i>`Layout.SpringLength`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties)

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    Model.Layout.SpringLength = 50;
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.SpringLength`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.SpringLength(80)).Render();

</code></td>
</tr>

<tr>
<td><b>Sets how to define the connection direction (first segment direction & last segment direction)</b></td>
<td><b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`Layout.ConnectionDirection`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.ConnectionDirection(ConnectionDirection.Auto)).Render();

</code></td>
</tr>

<tr>
<td><b>Enables/Disables animation option when a node is expanded/collapsed</b></td>
<td><b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`Layout.EnableAnimation`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.EnableAnimation(true)).Render();

</code></td>
</tr>

<tr>
<td><b>Defines whether an object should be at the left/right of the mind map. Applicable only for the direct children of the root node</b></td>
<td><b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`Layout.GetBranch`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Layout(l => l.GetBranch("getBranch")).Render();

</code>
<code>

    function getBranch(node, nodes) {
        return node.Data.Branch;
    }

</code></td>
</tr>
</table>

## Nodes

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Array of JSON objects where each object represents a node</b></td>
<td>
<b>Property</b>:<i>`Nodes`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Name = "node1" })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Id = "nodeName" });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the type of BPMN Activity. Applicable, if the node is a BPMN activity</b></td>
<td>
<b>Property</b>:<i>`Nodes.Activity`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() { Activity = BPMNActivity.SubProcess })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Activity`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Id = "nodeName", shape: { type =  'Bpmn', shape =  'Activity', activity = { activity = "Task" } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>To maintain additional information about nodes</b></td>
<td>
<b>Property</b>:<i>`Nodes.AddInfo`</i>
<br>
<br>
<code>

    @{
        Dictionary<string, object> AddInfo = new Dictionary<string, object>();
        AddInfo.Add("Description", "Bidirectional Flow");
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { AddInfo = AddInfo })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.AddInfo`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    Dictionary<string, object> AddInfo = new Dictionary<string, object>();
    AddInfo.Add("Description", "Bidirectional Flow");
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { AddInfo = AddInfo });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the additional information of a process. It is not directly related to the message flows or sequence flows of the process</b></td>
<td>
<b>Property</b>:<i>`Nodes.Annotation`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram")Nodes(n => n.Add(new BPMNNode() { Annotation = new BPMNAnnotation(){ Text= "Text" } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Annotations`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> Node = new List<DiagramNodeAnnotation>();
    Node.Add(new DiagramNodeAnnotation() { Content = "Place Order" } });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = Node});
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the angle between the BPMN shape and the annotation</b></td>
<td>
<b>Property</b>:<i>`Nodes.Annotation.Angle`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() { Annotation = new BPMNAnnotation(){ Angle=-45 } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Annotations.Angle`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramBpmnAnnotation> Node = new List<DiagramBpmnAnnotation>();
    Node.Add(new DiagramBpmnAnnotation() { Angle = -45 });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = Node});
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the direction of the text annotation</b></td>
<td>
<b>Property</b>:<i>`Nodes.Annotation.Direction`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() { Annotation = new BPMNAnnotation(){Direction=BPMNAnnotationDirections.Left } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Sets the height of the text annotation</b></td>
<td>
<b>Property</b>:<i>`Nodes.Annotation.Height`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() { Annotation = new BPMNAnnotation(){ Height=50 } })).Render();
    }

</code>
</td>
<td>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramBpmnAnnotation> Node = new List<DiagramBpmnAnnotation>();
    Node.Add(new DiagramBpmnAnnotation() { Height = 50 });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = Node});
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the distance between the BPMN shape and the annotation</b></td>
<td>
<b>Property</b>:<i>`Nodes.Annotation.Length`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() { Annotation = new BPMNAnnotation(){ Length=150 } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Annotations.Length`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramBpmnAnnotation> Node = new List<DiagramBpmnAnnotation>();
    Node.Add(new DiagramBpmnAnnotation() { Length = 150 });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = Node});
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the additional information about the flow object in a BPMN Process</b></td>
<td>
<b>Property</b>:<i>`Nodes.Annotation.Text`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() { Annotation = new BPMNAnnotation(){ Text= "Text" } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Annotations.Text`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramBpmnAnnotation> Node = new List<DiagramBpmnAnnotation>();
    Node.Add(new DiagramBpmnAnnotation() { Text= "Text" });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = Node});
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the width of the text annotation</b></td>
<td>
<b>Property</b>:<i>`Nodes.Annotation.Width`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() { Annotation = new BPMNAnnotation(){ Width=100 } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Annotations.Width`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramBpmnAnnotation> Node = new List<DiagramBpmnAnnotation>();
    Node.Add(new DiagramBpmnAnnotation() { Width = 100 });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = Node});
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the id for the annotation</b></td>
<td>
<b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Annotations.Id`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramBpmnAnnotation> Node = new List<DiagramBpmnAnnotation>();
    Node.Add(new DiagramBpmnAnnotation() { Id = "id" });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = Node});
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines whether the group can be ungrouped or not</b></td>
<td>
<b>Property</b>:<i>`Nodes.CanUngroup`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    Node node1 = new Node() { Name = "node1"};
    Node node2 = new Node() { Name = "node2"};
    Group group = new Group();
    group.Children.Add(node1);
    group.Children.Add(node2);
    group.CanUngroup = false;
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>Array of JSON objects where each object represents a child node/connector</b></td>
<td>
<b>Property</b>:<i>`Nodes.Children`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    Node node1 = new Node() { Name = "node1"};
    Node node2 = new Node() { Name = "node2"};
    Group group = new Group();
    group.Children.Add(node1);
    group.Children.Add(node2);
    ViewData["diagramModel"] = Model;

</code></td>
</tr>

<tr>
<td><b>Sets the type of UML classifier</b></td>
<td>
<b>Property</b>:<i>`Nodes.Classifier`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new UMLClassifier() { Classifier=ClassifierShapes.Class } )).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines the name, attributes and methods of a Class. Applicable, if the node is a Class</b></td>
<td>
<b>Property</b>:<i>`Nodes.Class`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n=>n.Add(new UMLClassifier() { Classifier = ClassifierShapes.Class, Class = { Name = "name" } } )).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Sets the name of class</b></td>
<td>
<b>Property</b>:<i>`Nodes.Class.Name`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram.Nodes(n => n.Add(new UMLClassifier() {Classifier=ClassifierShapes.Class, Class= { Name = "name"} } )).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Defines the collection of attributes</b></td>
<td>
<b>Property</b>:<i>`Nodes.Class.Attributes`</i>
<br>
<br>
<code>

    @{
        Collection attribute = new Collection();
        attribute.Add(new UMLAttribute() { Name = "name" });
        Html.EJ().Diagram("diagram.Nodes(n => n.Add(new UMLClassifier() {Classifier=ClassifierShapes.Class, Class= { Attributes= attribute} } )).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the name of the attribute</b></td>
<td>
<b>Property</b>:<i>`Nodes.Class.Attributes.Name`</i>
<br>
<br>
<code>

    @{
        Collection attribute = new Collection();
        attribute.Add(new UMLAttribute() { Name = "name" });
        Html.EJ().Diagram("diagram.Nodes(n => n.Add(new UMLClassifier() {Classifier=ClassifierShapes.Class, Class= { Attributes= attribute} } )).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the data type of attribute</b></td>
<td>
<b>Property</b>:<i>`Nodes.Class.Attributes.Type`</i>
<br>
<br>
<code>

    @{
        Collection attribute = new Collection();
        attribute.Add(new UMLAttribute() { Type = "Date" });
        Html.EJ().Diagram("diagram.Nodes(n => n.Add(new UMLClassifier() {Classifier=ClassifierShapes.Class, Class= { Attributes= attribute} } )).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Defines the visibility of the attribute</b></td>
<td>
<b>Property</b>:<i>`Nodes.Class.Attributes.Scope`</i>
<br>
<br>
<code>

    @{
        Collection attribute = new Collection();
        attribute.Add(new UMLAttribute() { Scope = Scopes.Protected });
        Html.EJ().Diagram("diagram.Nodes(n => n.Add(new UMLClassifier() {Classifier=ClassifierShapes.Class, Class= { Attributes= attribute} } )).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Defines the collection of methods of a Class</b></td>
<td>
<b>Property</b>:<i>`Nodes.Class.Methods`</i>
<br>
<br>
<code>

    @{
        Collection methods = new Collection();
        methods.Add(new UMLMethod() { Name = { "getHistory"} });
        Html.EJ().Diagram("diagram.Nodes(n => n.Add(new UMLClassifier() {Classifier=ClassifierShapes.Class, Class= { Methods = methods} } )).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the name of the method</b></td>
<td>
<b>Property</b>:<i>`Nodes.Class.Methods.Name`</i>
<br>
<br>
<code>

    @{
        Collection methods = new Collection();
        methods.Add(new UMLMethod() { Name = "getHistory" });
        Html.EJ().Diagram("diagram.Nodes(n => n.Add(new UMLClassifier() {Classifier=ClassifierShapes.Class, Class= { Methods = methods} } )).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Defines the arguments of the method</b></td>
<td>
<b>Property</b>:<i>`Nodes.Class.Methods.Arguments`</i>
<br>
<br>
<code>

    @{
        Collection parameter = new Collection();
        parameter.Add(new UMLParameter() { Name = "Date", Type = "String" });
        Collection methods = new Collection();
        methods.Add(new UMLMethod() { Parameters = parameter });
        Html.EJ().Diagram("diagram.Nodes(n => n.Add(new UMLClassifier() {Classifier=ClassifierShapes.Class, Class= { Methods = methods} } )).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Defines the name, attributes and methods of a Class. Applicable, if the node is a Class</b></td>
<td>
<b>Property</b>:<i>`Nodes.Class.Methods.Arguments.Name`</i>
<br>
<br>
<code>

    @{
        Collection parameter = new Collection();
        parameter.Add(new UMLParameter() { Name = "Date" });
        Collection methods = new Collection();
        methods.Add(new UMLMethod() { Parameters = parameter });
        Html.EJ().Diagram("diagram.Nodes(n => n.Add(new UMLClassifier() {Classifier=ClassifierShapes.Class, Class= { Methods = methods} } )).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the type of the argument</b></td>
<td>
<b>Property</b>:<i>`Nodes.Class.Methods.Arguments.Type`</i>
<br>
<br>
<code>

    @{
        Collection parameter = new Collection();
        parameter.Add(new UMLParameter() { Type = "String" });
        Collection methods = new Collection();
        methods.Add(new UMLMethod() { Parameters = parameter });
        Html.EJ().Diagram("diagram.Nodes(n => n.Add(new UMLClassifier() {Classifier=ClassifierShapes.Class, Class= { Methods = methods} } )).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the return type of the method</b></td>
<td>
<b>Property</b>:<i>`Nodes.Class.Methods.Type`</i>
<br>
<br>
<code>

    @{
        Collection methods = new Collection();
        methods.Add(new UMLMethod() { Type = "History" });
        Html.EJ().Diagram("diagram.Nodes(n => n.Add(new UMLClassifier() {Classifier=ClassifierShapes.Class, Class= { Methods = methods} } )).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the visibility of the method</b></td>
<td>
<b>Property</b>:<i>`Nodes.Class.Methods.Scope`</i>
<br>
<br>
<code>

    @{
        Collection methods = new Collection();
        methods.Add(new UMLMethod() { Scope = Protected });
        Html.EJ().Diagram("diagram.Nodes(n => n.Add(new UMLClassifier() {Classifier=ClassifierShapes.Class, Class= { Methods = methods} } )).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines the state of the node is collapsed/expanded</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { CollapseIcon = { Shape=IconShapes.ArrowUp, } } )).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { CollapseIcon = { Shape = IconShapes.ArrowUp} });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the border color for collapse icon of node</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.BorderColor`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { CollapseIcon = { BorderColor= "red"} } )).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.BorderColor`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { CollapseIcon = { BorderColor = "red" } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the border width for collapse icon of node</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.BorderWidth`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { CollapseIcon = { BorderWidth=2 } } )).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.BorderWidth`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { CollapseIcon = { BorderWidth = 2 } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the fill color for collapse icon of node</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.FillColor`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { CollapseIcon = { FillColor="green" } } )).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Fill`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { CollapseIcon = { Fill = "red" } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the height for collapse icon of node</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Height`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { CollapseIcon = { Height = 10 } } )).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Height`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { CollapseIcon = { Height = 10 } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the horizontal alignment of the icon</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.HorizontalAlignment`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { CollapseIcon = { HorizontalAlignment = HorizontalAlignment.Left} } )).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.HorizontalAlignment`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { CollapseIcon = { HorizontalAlignment = HorizontalAlignment.Left } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>To set the margin for the collapse icon of node</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Margin`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() {  CollapseIcon = {  Margin = new Margin() { Left = 5 } } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Margin`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { CollapseIcon = { Margin = new DiagramMargin() { Left = 5} } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the fraction/ratio(relative to node) that defines the position of the icon</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Offset`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { CollapseIcon = {Offset=new DiagramPoint() { X= 0, Y= 0.5F } } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Offset`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { CollapseIcon = { Offset = { X = 0, Y = 0.5 } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the shape of the collapsed state of the node</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Shape`</i>
<br>
<br>
<code>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { CollapseIcon = { Shape = IconShapes.ArrowUp } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Shape`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { CollapseIcon = { Shape = IconShapes.ArrowUp } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the vertical alignment of the icon</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.VerticalAlignment `</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { CollapseIcon = { VerticalAlignment= VerticalAlignment.Top } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.VerticalAlignment `</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { CollapseIcon = { VerticalAlignment= VerticalAlignment.Top } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b> Defines the custom content of the icon</b></td>
<td>
<b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Content`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() {
        CollapseIcon = {
            Shape = IconShapes.Template,
            Content = '<g><path d="M90,43.841c0,24.213-19.779,43.841-44.182,43.841c-7.747,0-15.025-1.98-21.357-5.455L0,90l7.975-23.522' +
            'c-4.023-6.606-6.34-14.354-6.34-22.637C1.635,19.628,21.416,0,45.818,0C70.223,0,90,19.628,90,43.841z M45.818,6.982' +
            'c-20.484,0-37.146,16.535-37.146,36.859c0,8.065,2.629,15.534,7.076,21.61L11.107,79.14l14.275-4.537' +
            'c5.865,3.851,12.891,6.097,20.437,6.097c20.481,0,37.146-16.533,37.146-36.857S66.301,6.982,45.818,6.982z M68.129,53.938' +
            'c-0.273-0.447-0.994-0.717-2.076-1.254c-1.084-0.537-6.41-3.138-7.4-3.495c-0.993-0.358-1.717-0.538-2.438,0.537' +
            'c-0.721,1.076-2.797,3.495-3.43,4.212c-0.632,0.719-1.263,0.809-2.347,0.271c-1.082-0.537-4.571-1.673-8.708-5.333' +
            'c-3.219-2.848-5.393-6.364-6.025-7.441c-0.631-1.075-0.066-1.656,0.475-2.191c0.488-0.482,1.084-1.255,1.625-1.882' +
            'c0.543-0.628,0.723-1.075,1.082-1.793c0.363-0.717,0.182-1.344-0.09-1.883c-0.27-0.537-2.438-5.825-3.34-7.977' +
            'c-0.902-2.15-1.803-1.792-2.436-1.792c-0.631,0-1.354-0.09-2.076-0.09c-0.722,0-1.896,0.269-2.889,1.344' +
            'c-0.992,1.076-3.789,3.676-3.789,8.963c0,5.288,3.879,10.397,4.422,11.113c0.541,0.716,7.49,11.92,18.5,16.223' +
            'C58.2,65.771,58.2,64.336,60.186,64.156c1.984-0.179,6.406-2.599,7.312-5.107C68.398,56.537,68.398,54.386,68.129,53.938z">' +
            '</path></g>'
        }
    });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the geometry of a path</b></td>
<td>
<b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.PathData`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() {
        CollapseIcon = { Shape = IconShapes.Path, PathData = "M0,0 L0,100" }
    });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the corner radius of the icon border</b></td>
<td>
<b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.CornerRadius`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() {
        CollapseIcon = { CornerRadius = 5 }
    });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the space that the icon has to be moved from the icon border</b></td>
<td>
<b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Padding`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() {
        CollapseIcon = { Padding = { Left = 15} }
    });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the distance to be left between a node and its connections(In coming and out going connections)</b></td>
<td>
<b>Property</b>:<i>`Nodes.ConnectorPadding`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { ConnectorPadding = 5 })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Enables or disables the default behaviors of the node</b></td>
<td>
<b>Property</b>:<i>`Nodes.Constraints`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Constraints = NodeConstraints.Default })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Constraints`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() {
        Constraints = NodeConstraints.Default
    });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the orientation of the container. Applicable, if the group is a container</b></td>
<td>
<b>Property</b>:<i>`Nodes.Container.Orientation`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    Node node1 = new Node() { Name = "node1"};
    Node node2 = new Node() { Name = "node2"};
    Group group = new Group();
    group.Children.Add(node1);
    group.Children.Add(node2);
    group.Container = new Container() { Orientation = "Horizontal" };
    ViewData["diagramModel"] = Model;

</code></td>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Sets the type of the container. Applicable if the group is a container.</b></td>
<td>
<b>Property</b>:<i>`Nodes.Container.Type`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    Node node1 = new Node() { Name = "node1"};
    Node node2 = new Node() { Name = "node2"};
    Group group = new Group();
    group.Children.Add(node1);
    group.Children.Add(node2);
    group.Container = new Container() { Orientation = "Horizontal" };
    ViewData["diagramModel"] = Model;

</code></td>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines the corner radius of rectangular shapes</b></td>
<td>
<b>Property</b>:<i>`Nodes.CornerRadius`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram")Nodes(n => n.Add(new BasicShape() { CornerRadius=5 })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>This property allows you to customize nodes appearance using user-defined CSS</b></td>
<td>
<b>Property</b>:<i>`Nodes.CssClass`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { CssClass= "hoverNode" })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines the BPMN data object</b></td>
<td>
<b>Property</b>:<i>`Nodes.Data.Type`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() { Shape = BPMNShapes.DataObject, Data = new BPMNDataObject(){ Type = BPMNDataObjects.Input } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.DataObject.Type`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Shape = new BpmnShapes() { Type = "BPMN", Shape = "DataObject", dataObject = new DiagramBpmnDataObject() { Type = BpmnDataObjects.Input} } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines whether the BPMN data object is a collection or not</b></td>
<td>
<b>Property</b>:<i>`Nodes.Data.Collection`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() { Shape = BPMNShapes.DataObject, Data = new BPMNDataObject(){ Collection = false } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.DataObject.Collection`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Shape = new BpmnShapes() { Type = "BPMN", Shape = "DataObject", dataObject = new DiagramBpmnDataObject() { Collection = false } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines an Enumeration in a UML Class Diagram</b></td>
<td>
<b>Property</b>:<i>`Nodes.Enumeration`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new UMLClassifier() { Classifier = ClassifierShapes.Enumeration, Enumeration = { Name = "AccountType" } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Sets the name of the Enumeration</b></td>
<td>
<b>Property</b>:<i>`Nodes.Enumeration.Name`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new UMLClassifier() { Classifier = ClassifierShapes.Enumeration, Enumeration={ Name = "AccountType" } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines the collection of enumeration members</b></td>
<td>
<b>Property</b>:<i>`Nodes.Enumeration.Members`</i>
<br>
<br>
<code>

    @{
        Collection member = new Collection();
        member.Add(new UMLEnumeration() { Name = "CheckingAccount" });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new UMLClassifier() { Classifier = ClassifierShapes.Enumeration, Enumeration = new UMLEnumeration() { Members = member } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Sets the name of the enumeration member</b></td>
<td>
<b>Property</b>:<i>`Nodes.Enumeration.Members.Name`</i>
<br>
<br>
<code>

    @{
        Collection member = new Collection();
        member.Add(new UMLEnumeration() { Name = "CheckingAccount" });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new UMLClassifier() { Classifier = ClassifierShapes.Enumeration, Enumeration = new UMLEnumeration() { Members = member } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Sets the type of the BPMN Events. Applicable, if the node is a BPMN event</b></td>
<td>
<b>Property</b>:<i>`Nodes.Event`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() { Shape=BPMNShapes.Event, Event=BPMNEvents.Intermediate })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Event`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Event", Event = { Event = BpmnEvents.Start } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the type of the trigger</b></td>
<td>
<b>Property</b>:<i>`Nodes.Event.Trigger`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() { Shape = BPMNShapes.Event, Trigger = BPMNTriggers.None })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Event.Trigger`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Event", Event = { Trigger = BpmnTriggers.None } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines whether the node can be automatically arranged using layout or not</b></td>
<td>
<b>Property</b>:<i>`Nodes.ExcludeFromLayout`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Layout( l=>l.Type(LayoutTypes.HierarchicalTree)).Nodes(n => n.Add(new Node() { Name = "Patient"ExcludeFromLayout=true }).Add(new Node() { Name = "Patient1" }).Add(new Node() { Name = "Patient2" })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.ExcludeFromLayout`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Layout(new DiagramLayout() { Type = LayoutType.HierarchicalTree}).Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Id = "Patient", ExcludeFromLayout= true } } });
    nodes.Add(new DiagramNode() { Id = "Patient1" } } });
    nodes.Add(new DiagramNode() { Id = "Patient2" } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the fill color of the node</b></td>
<td>
<b>Property</b>:<i>`Nodes.FillColor`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Height("500px").Width("500px").Nodes(n => n.Add(new Node() { FillColor="red" })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Fill`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Style = new DiagramShapeStyle { Fill = "red" } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the type of the BPMN Gateway. Applicable, if the node is a BPMN gateway</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gateway`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() { Shape=BPMNShapes.Gateway, Gateway=BPMNGateways.Exclusive })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Gateway`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Gateways", gateWay = { Type = BpmnGateways.Exclusive } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Paints the node with linear color transitions</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.Type`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Gradient= new LinearGradient() { Type = "linear" } })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Gradient.Type`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Style = new DiagramShapeStyle { Gradient = new DiagramGradient() { Type = GradientType.Linear } } });
    ViewBag.Nodes = nodes;

</code></td>

</tr>

<tr>
<td><b>Defines the x1 value of linear gradient</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.LinearGradient.X1`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() {  Gradient= new LinearGradient() { Type = "linear", X1 = 0 } })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Gradient.LinearGradient.X1`</i>
<br>
<br>
</td>

</tr>

<tr>
<td><b>Defines the x2 value of linear gradient</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.LinearGradient.X2`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() {  Gradient= new LinearGradient() { Type = "linear", X2 = 50 } })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Gradient.LinearGradient.X2`</i>
<br>
<br>
</td>

</tr>

<tr>
<td><b>Defines the y1 value of linear gradient</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.LinearGradient.Y1`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() {  Gradient= new LinearGradient() { Type = "linear", Y1 = 0 } })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Gradient.LinearGradient.Y1`</i>
<br>
<br>
</td>

</tr>

<tr>
<td><b>Defines the y2 value of linear gradient</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.LinearGradient.Y2`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Gradient= new LinearGradient() { Type = "linear",  Y2 = 50 } })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Gradient.LinearGradient.Y2`</i>
<br>
<br>
</td>
</tr>

<tr>
<td><b>Defines the type of gradient</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.RadialGradient.Type`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() {  Gradient= new RadialGradient() { Type = "radial" } })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Gradient.Type`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Style = new DiagramShapeStyle { Gradient = new DiagramGradient() { Type = GradientType.Radial } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the position of the outermost circle
</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.RadialGradient.Cx`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() {  Gradient= new RadialGradient() { Type = "radial", CX=50 } })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.RadialGradient.Cx`</i>
<br>
<br>
</td>
</tr>

<tr>
<td><b>Defines the outer most circle of the radial gradient</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.RadialGradient.Cy`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() {  Gradient= new RadialGradient() { Type = "radial", CY=50 } })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.RadialGradient.Cy`</i>
<br>
<br>
</td>
</tr>

<tr>
<td><b>Defines the innermost circle of the radial gradient</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.RadialGradient.Fx`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Gradient= new RadialGradient() { Type = "radial", FX=50 } })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.RadialGradient.Fx`</i>
<br>
<br>
</td>
</tr>

<tr>
<td><b>Defines the innermost circle of the radial gradient</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.RadialGradient.Fy`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Gradient= new RadialGradient() { Type = "radial", FY=50 } })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.RadialGradient.Fy`</i>
<br>
<br>
</td>
</tr>

<tr>
<td><b>Defines the different colors and the region of color transitions</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.RadialGradient.Stops`</i>
<br>
<br>
<code>

    @{
        Collection stops = new Collection();
        stops.Add(new Stop() { Color = "white", Offset = 0 });
        stops.Add(new Stop() { Color = "red", Offset = 50 });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Gradient= new RadialGradient() { Stops = stops } })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.RadialGradient.Stops`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramStop> stops = new List<DiagramStop>();
    stops.Add(new DiagramStop() { Color = "white", Offset = 0 });
    stops.Add(new DiagramStop() { Color = "red", Offset = 50 });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Style = new DiagramShapeStyle { Gradient = new DiagramGradient() { Stops = stops } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the color to be filled over the specified region</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.Stops.Color`</i>
<br>
<br>
<code>

    @{
        Collection stops = new Collection();
        stops.Add(new Stop() { Color = "white" });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Gradient= new RadialGradient() { Stops = stops } })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Gradient.Stops.Color`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramStop> stops = new List<DiagramStop>();
    stops.Add(new DiagramStop() { Color = "white" });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Style = new DiagramShapeStyle { Gradient = new DiagramGradient() { Stops = stops } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the position where the previous color transition ends and a new color transition starts</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.Stops.Offset`</i>
<br>
<br>
<code>

    @{
        Collection stops = new Collection();
        stops.Add(new Stop() { Offset = 0 });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Gradient= new RadialGradient() { Stops = stops } })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Gradient.Stops.Offset`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramStop> stops = new List<DiagramStop>();
    stops.Add(new DiagramStop() { Offset = 0 });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Style = new DiagramShapeStyle { Gradient = new DiagramGradient() { Stops = stops } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Describes the transparency level of the region</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.Stops.Opacity`</i>
<br>
<br>
<code>

    @{
        Collection stops = new Collection();
        stops.Add(new Stop() { Opacity = 0.5F });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Gradient= new RadialGradient() { Stops = stops } })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Gradient.Stops.Opacity`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramStop> stops = new List<DiagramStop>();
    stops.Add(new DiagramStop() { Opacity = 0.5 });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Style = new DiagramShapeStyle { Gradient = new DiagramGradient() { Stops = stops } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the header of a swimlane/lane</b></td>
<td>
<b>Property</b>:<i>`Nodes.Header`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    SwimLane swimLane = new SwimLane();
    Header header = new Header();
    header.Text = "Text";
    swimLane.Header = header;       ~
    Model.Nodes.Add(swimLane);
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines the height of the node</b></td>
<td>
<b>Property</b>:<i>`Nodes.Height`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Height=100 })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Height`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Height = 100 });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the horizontal alignment of the node. Applicable, if the parent of the node is a container</b></td>
<td>
<b>Property</b>:<i>`Nodes.HorizontalAlign`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { HorizontalAlign=HorizontalAlignment.Left })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines an interface in a UML interface Diagram</b></td>
<td>
<b>Property</b>:<i>`Nodes.Interface`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new UMLClassifier() { Classifier = ClassifierShapes.Interface,  } } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines the name, attributes and methods of a Interface. Applicable, if the node is a Interface</b></td>
<td>
<b>Property</b>:<i>`Nodes.Interface.Name`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram")Nodes(n => n.Add(new UMLClassifier() { Classifier = Interface, Interface = { Name = "Patient" } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines the collection of attributes</b></td>
<td>
<b>Property</b>:<i>`Nodes.Interface.Attributes`</i>
<br>
<br>
<code>

    @{
        Collection attribute = new Collection();
        attribute.Add(new UMLAttribute() { Name = "accepted"  });
        Html.EJ().Diagram("diagram")Nodes(n => n.Add(new UMLClassifier() { Classifier = Interface, Interface = { Attributes = attribute } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the name of the attribute</b></td>
<td>
<b>Property</b>:<i>`Nodes.Interface.Attributes.Name`</i>
<br>
<br>
<code>

    @{
        Collection attribute = new Collection();
        attribute.Add(new UMLAttribute() { Name = "accepted"  });
        Html.EJ().Diagram("diagram")Nodes(n => n.Add(new UMLClassifier() { Classifier = Interface, Interface = { Attributes = attribute } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the data type of attribute</b></td>
<td>
<b>Property</b>:<i>`Nodes.Interface.Attributes.Type`</i>
<br>
<br>
<code>

    @{
        Collection attribute = new Collection();
        attribute.Add(new UMLAttribute() { Type = "Date"  });
        Html.EJ().Diagram("diagram")Nodes(n => n.Add(new UMLClassifier() { Classifier = Interface, Interface = { Attributes = attribute } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Defines the visibility of the attribute</b></td>
<td>
<b>Property</b>:<i>`Nodes.Interface.Attributes.Scope`</i>
<br>
<br>
<code>

    @{
        Collection attribute = new Collection();
        attribute.Add(new UMLAttribute() { Scope = Scopes.Protected  });
        Html.EJ().Diagram("diagram")Nodes(n => n.Add(new UMLClassifier() { Classifier = Interface, Interface = { Attributes = attribute } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Defines the collection of methods of a interface</b></td>
<td>
<b>Property</b>:<i>`Nodes.Interface.Methods`</i>
<br>
<br>
<code>

    @{
        Collection methods = new Collection();
        methods.Add(new UMLMethod() { Scope = Scopes.Protected });
        Html.EJ().Diagram("diagram")Nodes(n => n.Add(new UMLClassifier() { Classifier = Interface, Interface = { Attributes = attribute } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the name of the method</b></td>
<td>
<b>Property</b>:<i>`Nodes.Interface.Methods.Name`</i>
<br>
<br>
<code>

    @{
        Collection methods = new Collection();
        methods.Add(new UMLMethod() { Name = "Date" });
        Html.EJ().Diagram("diagram")Nodes(n => n.Add(new UMLClassifier() { Classifier = Interface, Interface = { Attributes = attribute } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Defines the arguments of the method</b></td>
<td>
<b>Property</b>:<i>`Nodes.Interface.Methods.Arguments`</i>
<br>
<br>
<code>

    @{
        Collection parameter = new Collection();
        parameter.Add(new UMLParameter() { Name = "Date", Type = "String" });
        Collection methods = new Collection();
        methods.Add(new UMLMethod() { Parameters = parameter });
        Html.EJ().Diagram("diagram")Nodes(n => n.Add(new UMLClassifier() { Classifier = Interface, Interface = { Attributes = attribute } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Defines the name, attributes and methods of a interface. Applicable, if the node is a interface</b></td>
<td>
<b>Property</b>:<i>`Nodes.Interface.Methods.Arguments.Name`</i>
<br>
<br>
<code>

    @{
        Collection parameter = new Collection();
        parameter.Add(new UMLParameter() { Name = "Date" });
        Collection methods = new Collection();
        methods.Add(new UMLMethod() { Parameters = parameter });
        Html.EJ().Diagram("diagram")Nodes(n => n.Add(new UMLClassifier() { Classifier = Interface, Interface = { Attributes = attribute } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the type of the argument</b></td>
<td>
<b>Property</b>:<i>`Nodes.Interface.Methods.Arguments.Type`</i>
<br>
<br>
<code>

    @{
        Collection parameter = new Collection();
        parameter.Add(new UMLParameter() { Type = "String" });
        Collection methods = new Collection();
        methods.Add(new UMLMethod() { Parameters = parameter });
        Html.EJ().Diagram("diagram")Nodes(n => n.Add(new UMLClassifier() { Classifier = Interface, Interface = { Attributes = attribute } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the return type of the method</b></td>
<td>
<b>Property</b>:<i>`Nodes.Interface.Methods.Type`</i>
<br>
<br>
<code>

    @{
        Collection methods = new Collection();
        methods.Add(new UMLMethod() { Type = "History" });
        Html.EJ().Diagram("diagram")Nodes(n => n.Add(new UMLClassifier() { Classifier = Interface, Interface = { Attributes = attribute } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the visibility of the method</b></td>
<td>
<b>Property</b>:<i>`Nodes.Interface.Methods.Scope`</i>
<br>
<br>
<code>

    @{
        Collection methods = new Collection();
        methods.Add(new UMLMethod() { Scope = Scopes.Protected });
        Html.EJ().Diagram("diagram")Nodes(n => n.Add(new UMLClassifier() { Classifier = Interface, Interface = { Attributes = attribute } })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Defines whether the sub tree of the node is expanded or collapsed</b></td>
<td>
<b>Property</b>:<i>`Nodes.IsExpanded`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { IsExpanded=false })).Render();
    }

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.IsExpanded`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { IsExpanded = false });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the node as a swimlane</b></td>
<td>
<b>Property</b>:<i>`Nodes.IsSwimlane`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    SwimLane swimLane = new SwimLane();
    swimLane.IsSwimlane = true;
    Model.Nodes.Add(swimLane);
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>A collection of objects where each object represents a label</b></td>
<td>
<b>Property</b>:<i>`Nodes.Labels`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { Text = "Connector" });
        Html.EJ().Diagram("diagram").Height("500px").Width("500px").Nodes(n => n.Add(new Node() { Name = "Patient", OffsetX = 100, OffsetY = 100, Labels=Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Annotations`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Content = "Annotation" });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>An array of objects where each object represents a lane. Applicable, if the node is a swimlane</b></td>
<td>
<b>Property</b>:<i>`Nodes.Lanes`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    Collection lanes = new Collection();
    lanes.Add(new Lane() { Name = "lane1" });
    lanes.Add(new Lane() { Name = "lane2" });
    SwimLane swimLane = new SwimLane();
    swimLane.Lanes = lanes;
    Model.Nodes.Add(swimLane);
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>This property allows you to customize lanes appearance using user-defined CSS</b></td>
<td>
<b>Property</b>:<i>`Nodes.Lanes.CssClass`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    DiagramProperties Model = new DiagramProperties();
    Collection lanes = new Collection();
    lanes.Add(new Lane() { CssClass = "hoverLane" });
    SwimLane swimLane = new SwimLane();
    swimLane.Lanes = lanes;
    Model.Nodes.Add(swimLane);
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines the header of the lane</b></td>
<td>
<b>Property</b>:<i>`Nodes.Lanes.Header`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    Collection lanes = new Collection();
    Header header = new Header();
    header.Text = "Text";
    lanes.Add(new Lane() { Header = header });
    SwimLane swimLane = new SwimLane();
    swimLane.Lanes = lanes;
    swimLane.IsSwimlane = true;
    Model.Nodes.Add(swimLane);

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines the width of lane</b></td>
<td>
<b>Property</b>:<i>`Nodes.Lanes.Width`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    Collection lanes = new Collection();
    lanes.Add(new Lane() { Width = 200 });
    SwimLane swimLane = new SwimLane();
    swimLane.Lanes = lanes;
    swimLane.IsSwimlane = true;
    Model.Nodes.Add(swimLane);

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>An array of objects where each object represents a child node of the lane</b></td>
<td>
<b>Property</b>:<i>`Nodes.Lanes.Children`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    Collection lanes = new Collection();
    Collection children = new Collection();
    children.Add(new Node() { Name = "process" });
    lanes.Add(new Lane() {  Children = children });
    SwimLane swimLane = new SwimLane();
    swimLane.Lanes = lanes;
    swimLane.IsSwimlane = true;
    Model.Nodes.Add(swimLane);

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines the object as a lane</b></td>
<td>
<b>Property</b>:<i>`Nodes.Lanes.IsLane`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    Collection lanes = new Collection();
    lanes.Add(new Lane() {  IsLane = true });
    SwimLane swimLane = new SwimLane();
    swimLane.Lanes = lanes;
    Model.Nodes.Add(swimLane);

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines the minimum space to be left between the bottom of parent bounds and the node</b></td>
<td>
<b>Property</b>:<i>`Nodes.Margin`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() {  MarginBottom=50, MarginLeft=10, MarginRight=10, MarginTop=10 })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Margin`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Margin = new DiagramMargin() { Bottom = 15, Left = 15, Right = 15, Up = 15 }  });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the maximum height limit of the node</b></td>
<td>
<b>Property</b>:<i>`Nodes.MaxHeight`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() {MaxHeight=100})).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.MaxHeight`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { MaxHeight = 50  });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the unique identifier of the node</b></td>
<td>
<b>Property</b>:<i>`Nodes.Name`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Name = "Patient" })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Id`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { ID = "Name"  });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the path geometry that defines the shape of a path node</b></td>
<td>
<b>Property</b>:<i>`Nodes.PathData`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Height("500px").Width("500px").Nodes(n => n.Add(new BasicShape() { Shape = BasicShapes.Path, PathData= "M 370.9702,194.9961 L 359.5112,159.7291 L 389.5112,137.9341 L 419.5112,159.7291 L 408.0522,194.9961 L 370.9702,194.9961 z" })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Data`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Shape = new DiagramBasicShape() { Type = Shapes.Path  } });
    ViewBag.Nodes = nodes;

</code></td>

</tr>

<tr>
<td><b>An array of objects, where each object represents a smaller region(phase) of a swimlane</b></td>
<td>
<b>Property</b>:<i>`Nodes.Phases`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    Collection phase = new Collection();
    phase.Add(new Phase() { Name = "Phase1" });
    SwimLane swimLane = new SwimLane();
    swimLane.Phases = phase;
    Model.Nodes.Add(swimLane);

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

 <tr>
<td><b>Defines the header of the smaller regions</b></td>
<td>
<b>Property</b>:<i>`Nodes.Phases.Label`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    Collection label = new Collection();
    label.Add(new Label() { Text = "Phase1" });
    Collection phase = new Collection();
    phase.Add(new Phase() { Labels =  label });
    SwimLane swimLane = new SwimLane();
    swimLane.Phases = phase;
    Model.Nodes.Add(swimLane);

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines the line color of the splitter that splits adjacent phases</b></td>
<td>
<b>Property</b>:<i>`Nodes.Phases.LineColor`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    Collection phase = new Collection();
    phase.Add(new Phase() { LineColor = "green" });
    SwimLane swimLane = new SwimLane();
    swimLane.Phases = phase;
    Model.Nodes.Add(swimLane);

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Sets the length of the smaller region(phase) of a swimlane</b></td>
<td>
<b>Property</b>:<i>`Nodes.Phases.Offset`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    Collection phase = new Collection();
    phase.Add(new Phase() { Offset = "150" });
    SwimLane swimLane = new SwimLane();
    swimLane.Phases = phase;
    Model.Nodes.Add(swimLane);

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Sets the orientation of the phase</b></td>
<td>
<b>Property</b>:<i>`Nodes.Phases.Orientation`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    Collection phase = new Collection();
    phase.Add(new Phase() { Orientation = "Horizontal" });
    SwimLane swimLane = new SwimLane();
    swimLane.Phases = phase;
    Model.Nodes.Add(swimLane);

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the height of the phase headers</b></td>
<td>
<b>Property</b>:<i>`Nodes.PhaseSize`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    Collection phase = new Collection();
    phase.Add(new Phase() { Orientation = "Horizontal" });
    SwimLane swimLane = new SwimLane();
    swimLane.PhaseSize = "50";
    Model.Nodes.Add(swimLane);

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
<tr>
<td><b>Sets the ratio/ fractional value relative to node, based on which the node will be transformed(positioning, scaling and rotation)</b></td>
<td>
<b>Property</b>:<i>`Nodes.Pivot`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Pivot = new DiagramPoint() { X=0, Y=0 } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Pivot`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Pivot = new DiagramPoint() { X = 0, Y = 0} });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines a collection of points to draw a polygon. Applicable, if the shape is a polygon</b></td>
<td>
<b>Property</b>:<i>`Nodes.Points`</i>
<br>
<br>
<code>

    @{
        Collection point = new Collection();
        point.Add(new DiagramPoint() { X = 0, Y = 12.5F });
        point.Add(new DiagramPoint() { X = 0, Y = 50 });
        point.Add(new DiagramPoint() { X = 50, Y = 50 });
        point.Add(new DiagramPoint() { X = 50, Y = 0 });
        point.Add(new DiagramPoint() { X = 12.5F, Y = 0 });
        point.Add(new DiagramPoint() { X = 0, Y = 12.5F });
        Html.EJ().Diagram("diagram").Height("500px").Width("500px").Nodes(n => n.Add(new BasicShape() { Name = "Patient", OffsetX = 100, OffsetY = 100, Shape=Syncfusion.JavaScript.DataVisualization.DiagramEnums.BasicShapes.Polygon, Points= point })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Points`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramPoint> points = new List<DiagramPoint>();
    points.Add(new DiagramPoint() { X = 35, Y = 0 });
    points.Add(new DiagramPoint() { X = 65, Y = 0 });
    points.Add(new DiagramPoint() { X = 100, Y = 35 });
    points.Add(new DiagramPoint() { X = 100, Y = 65 });
    points.Add(new DiagramPoint() { X = 65, Y = 100 });
    points.Add(new DiagramPoint() { X = 35, Y = 100 });
    points.Add(new DiagramPoint() { X = 0, Y = 65 });
    points.Add(new DiagramPoint() { X = 0, Y = 35 });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Shape = new DiagramBasicShape() { Type = Basic, Shape = BasicShapes.Polygon, Points = points  } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>An array of objects where each object represents a port</b></td>
<td>
<b>Property</b>:<i>`Nodes.Ports`</i>
<br>
<br>
<code>

    @{
        Collection ports = new Collection();
        ports.Add(new Port() { Name="port1", Offset=new DiagramPoint() {X=0.5F, Y=0 }, Shape=PortShapes.Square, Size=10 });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Ports=ports })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Ports`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramPort> ports = new List<DiagramPort>();
    ports.Add(new DiagramPort() { Id = "port" });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Ports = ports });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the border color of the port</b></td>
<td>
<b>Property</b>:<i>`Nodes.Ports.BorderColor`</i>
<br>
<br>
<code>

    @{
        Collection ports = new Collection();
        ports.Add(new Port() { BorderColor= "Yellow" });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Ports=ports })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Ports.Style.StrokeColor`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramPort> ports = new List<DiagramPort>();
    ports.Add(new DiagramPort() {  });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Ports = ports });
    ViewBag.Nodes = nodes;

</code></td>
<code>
</code></td>
</tr>

<tr>
<td><b>Defines whether connections can be created with the port</b></td>
<td>
<b>Property</b>:<i>`Nodes.Ports.Constraints`</i>
<br>
<br>
<code>

    @{
        Collection ports = new Collection();
        ports.Add(new Port() { Constraints=PortConstraints.Connect });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Ports=ports })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Ports.Constraints`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramPort> ports = new List<DiagramPort>();
    ports.Add(new DiagramPort() { Constraints = PortConstraints.Drag });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Ports = ports });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>An array of objects where each object represents a port</b></td>
<td>
<b>Property</b>:<i>`Nodes.Ports.Shape`</i>
<br>
<br>
<code>

    @{
        Collection ports = new Collection();
        ports.Add(new Port() { Shape=PortShapes.Square });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Ports=ports })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Ports.Shape`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramPort> ports = new List<DiagramPort>();
    ports.Add(new DiagramPort() { Shape = PortShapes.Circle });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Ports = ports });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the vertical alignment of the port with respect to its immediate parent</b></td>
<td>
<b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`Nodes.Ports.VerticalAlignment`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramPort> ports = new List<DiagramPort>();
    ports.Add(new DiagramPort() { VerticalAlignment = VerticalAlignment.Top });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Ports = ports });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the opacity and the position of shadow</b></td>
<td>
<b>Property</b>:<i>`Nodes.Shadow`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() {  Shadow=new Shadow() { Opacity=0.5F } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shadow`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Shadow = new DiagramShadow() { Opacity = 0.5 } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the sub process of a BPMN Activity. Applicable, if the type of the BPMN activity is sub process</b></td>
<td>
<b>Property</b>:<i>`Nodes.SubProcess`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() {  Shape=BPMNShapes.Activity, Activity=BPMNActivity.SubProcess, SubProcess = { Loop=BPMNLoops.Standard, Adhoc=true } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Activity.SubProcess`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Activity", Activity = { Activity = BpmnActivities.SubProcess} } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the collection of events that need to be appended with BPMN Sub-Process</b></td>
<td>
<b>Property</b>:<i>`Nodes.SubProcess.Events`</i>
<br>
<br>
<code>

    @{
        Collection events = new Collection();
        events.Add(new BPMNEvent() { Name = "intermediate1" } });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() {  Shape = BPMNShapes.Activity, Activity = BPMNActivity.SubProcess, SubProcess = { Type = BPMNSubProcessTypes.Event, Events=events } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Activity.SubProcess.Events`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramBpmnSubEvent> events = new List<DiagramBpmnSubEvent>();
    events.Add(new DiagramBpmnSubEvent() { Event = BpmnEvents.Intermediate });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Activity", Activity = { Activity = BpmnActivities.SubProcess, SubProcess = { Type = BpmnSubProcessTypes.Event, Events = events }  } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>An array of objects where each object represents a port</b></td>
<td>
<b>Property</b>:<i>`Nodes.SubProcess.Events.Ports`</i>
<br>
<br>
<code>

    @{
        Collection ports = new Collection();
        ports.Add(new Port() { Name = "port1" });
        Collection events = new Collection();
        events.Add(new BPMNEvent() { Ports = ports } });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() {  Shape = BPMNShapes.Activity, Activity = BPMNActivity.SubProcess, SubProcess = { Type = BPMNSubProcessTypes.Event, Events=events } })).Render();
    }

<code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Activity.SubProcess.Events.Ports`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramPort> ports = new List<DiagramPort>();
    ports.Add(new DiagramPort() { Id = "port"};
    List<DiagramBpmnSubEvent> events = new List<DiagramBpmnSubEvent>();
    events.Add(new DiagramBpmnSubEvent() { Event = BpmnEvents.Intermediate, Ports = ports });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Activity", Activity = { Activity = BpmnActivities.SubProcess, SubProcess = { Type = BpmnSubProcessTypes.Event, Events = events }  } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>A collection of objects where each object represents a label</b></td>
<td>
<b>Property</b>:<i>`Nodes.SubProcess.Events.Labels`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { Text = "Label" });
        Collection events = new Collection();
        events.Add(new BPMNEvent() { Labels = Labels } });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() {  Shape = BPMNShapes.Activity, Activity = BPMNActivity.SubProcess, SubProcess = { Type = BPMNSubProcessTypes.Event, Events=events } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Activity.SubProcess.Events.Annotations`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Content = "Annotation" });
    List<DiagramBpmnSubEvent> events = new List<DiagramBpmnSubEvent>();
    events.Add(new DiagramBpmnSubEvent() { Event = BpmnEvents.Intermediate, Annotation = annotation });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Activity", Activity = { Activity = BpmnActivities.SubProcess, SubProcess = { Type = BpmnSubProcessTypes.Event, Events = events }  } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines the task of the BPMN activity. Applicable, if the type of activity is set as task</b></td>
<td>
<b>Property</b>:<i>`Nodes.Task`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new BPMNNode() { Shape = BPMNShapes.Activity, Activity = BPMNActivity.Task, Task = { Type=BPMNTasks.Service } })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Activity.Task`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Shape = new BpmnShapes() { Type = "Bpmn", Shape = "Activity", Activity = BpmnActivities.Task, Task = { Type = BpmnTasks.Service } }  } } });
    ViewBag.Nodes = nodes;

</code></td>
</tr>
</table>

## NodeTemplate

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Binds the custom JSON data with node properties</b></td>
<td>
<b>Property</b>:<i>`NodeTemplate`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { Text = "Label" });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }
</code>
<code>

    <script>

        function nodeTemplate(diagram, node) {
            node.labels[0].text = node.Description;
            node.fillColor = node.Color;
            node.width = node.Width;
            node.height = node.Height;
            node.offsetX = node.offsetX;
            node.offsetY = node.offsetY;
        }
    </script>

</code>

</td>
<td>
<b>Property</b>:<i>`SetNodeTemplate`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").SetNodeTemplate("setNodeTemplate").Render()

</code>
<code>

    <script>
        var getTextElement = (text: string) => {
            var textElement = new TextElement();
            textElement.Width = 50;
            textElement.Height = 20;
            textElement.Content = text;
            return textElement;
        };
        function setNodeTemplate() {
            setNodeTemplate: (object: NodeModel, diagram: Diagram): StackPanel => {
                if (object.Id === 'node2') {
                    var table = new StackPanel();
                    table.Orientation = 'Horizontal';
                    var column1 = new StackPanel();
                    column1.Children = [];
                    column1.Children.Push(getTextElement('Column1'));
                    addRows(column1);
                    var column2 = new StackPanel();
                    column2.Children = [];
                    column2.Children.Push(getTextElement('Column2'));
                    addRows(column2);
                    table.Children = [column1, column2];
                    return table;
                }
                return null;
            }
        }
    </script>

</code></td>
</tr>
</table>

## Layers

<!-- markdownlint-disable MD033 -->
 <table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>A collection of JSON objects where each object represents a layer. Layer is a named category of diagram shapes</b></td>
<td>
<b>Property</b>:<i>`Layers`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    Model.Layers = new Collection();
    Model.Layers.Add(new Layer() { Name = "Layer1" });

</code>
</td>
<td>
<b>Property</b>:<i>`Layers`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Layers(ViewBag.Layers).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramLayer> layers = new List<DiagramLayer>();
    layers.Add(new DiagramLayer() { Id = "layer" });
    ViewBag.Layers = layers;

</code></td>

</tr>

<tr>
<td><b>A collection of JSON objects where each object represents a layer. Layer is a named category of diagram shapes</b></td>
<td>
<b>Property</b>:<i>`Layers.Print`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJ().Diagram("Diagram1", ViewData["diagramModel "] as DiagramProperties).Render()

</code>
<b>[Model]</b>
<code>

    Model.Layers = new Collection();
    Model.Layers.Add(new Layer() { Print = true });

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
</table>

## Annotations

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>A collection of objects where each object represents a label</b></td>
<td>
<b>Property</b>:<i>`Labels.Text`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { Text = "Label" });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Content`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Content = "Annotation" });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Offset for annotation content</b></td>
<td>
<b>Property</b>:<i>`Labels.Offset`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { Offset=new DiagramPoint() { X = 0, Y = 1 } });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Offset`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Offset=new DiagramPoint() { X = 0, Y = 1 } });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the hyperlink for the labels</b></td>
<td>
<b>Property</b>:<i>`Labels.HyperLink`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { Text = "HRPortal", Hyperlink= "https://www.Syncfusion.Com" });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Hyperlink`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() {Content = "HRPortal", Hyperlink = "https://www.Syncfusion.Com" });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Enables/disables the bold style</b></td>
<td>
<b>Property</b>:<i>`Labels.Bold`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { Bold=true });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Style.Bold`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Style = new DiagramTextStyle() { Bold = true } });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the border color of the label</b></td>
<td>
<b>Property</b>:<i>`Labels.BorderColor`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { BorderColor="red" });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Style.StrokeColor`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Style = new DiagramTextStyle() { StrokeColor = "red" } });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the border width of the label</b></td>
<td>
<b>Property</b>:<i>`Labels.BorderWidth`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { BorderWidth=2 });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Style.StrokeWidth`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Style = new DiagramTextStyle() { StrokeWidth=2 } });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>This property allows you to customize labels appearance using user-defined CSS</b></td>
<td>
<b>Property</b>:<i>`Labels.CssClass`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { CssClass= "hoverText" });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>Enables or disables the default behaviors of the label</b></td>
<td>
<b>Property</b>:<i>`Labels.Constraints`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { Constraints = LabelConstraints.Resizable });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Constraints`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Constraints = AnnotationConstraints.InheritReadOnly });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the fill color of the text area</b></td>
<td>
<b>Property</b>:<i>`Labels.FillColor`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { FillColor= "green" });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Style.Fill`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Style = new DiagramTextStyle() { Fill = "white" } });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the font color of the text</b></td>
<td>
<b>Property</b>:<i>`Labels.FontColor`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() {  FontColor="blue" });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Style.Color`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Style = new DiagramTextStyle() { Color = "black" } });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the font family of the text</b></td>
<td>
<b>Property</b>:<i>`Labels.FontFamily`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { FontFamily= "segoe UI" });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Style.FontFamily`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Style = new DiagramTextStyle() { FontFamily = "segoe UI" } });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the height of the label</b></td>
<td>
<b>Property</b>:<i>`Labels.Height`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { Height = 100 });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Height`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Height = 10 });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the horizontal alignment of the label</b></td>
<td>
<b>Property</b>:<i>`Labels.HorizontalAlignment`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { HorizontalAlignment=HorizontalAlignment.Right });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.HorizontalAlignment`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { HorizontalAlignment = HorizontalAlignment.Center });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>To set the margin of the label</b></td>
<td>
<b>Property</b>:<i>`Labels.Margin`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { Margin=new LabelMargin() { Left=5} });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Margin`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Margin = new DiagramMargin() { Bottom = 15 } });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Defines whether the label is editable or not</b></td>
<td>
<b>Property</b>:<i>`Labels.ReadOnly`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { ReadOnly=true });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Constraints`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Constraints = AnnotationConstraints.ReadOnly });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Sets the id of svg/html templates. Applicable, if the node’s label is HTML or native</b></td>
<td>
<b>Property</b>:<i>`Labels.TemplateId`</i>
<br>
<br>
<code>

    <script id="SvgEllipse" type="text/x-jsrender">
            <svg xmlns="http://www.w3.Org/2000/svg"
                xmlns:xlink="http://www.w3.Org/1999/xlink">
                <circle cx="10" cy="6" r="5"
                        style="stroke:#006600; fill:#00cc00" />
            </svg>
    </script>

</code>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { TemplateId= "SvgEllipse" });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines how to align the text inside the label</b></td>
<td>
<b>Property</b>:<i>`Labels.TextAlign`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { TextAlign=TextAlign.Left });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Style.TextAlign`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Style = new DiagramTextStyle() { TextAlign = TextAlign.Left } });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Enables or disables the visibility of the label</b></td>
<td>
<b>Property</b>:<i>`Labels.Visible`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { Visible=false });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Visibility`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").Nodes(ViewBag.Nodes).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramNodeAnnotation> annotation = new List<DiagramNodeAnnotation>();
    annotation.Add(new DiagramNodeAnnotation() { Visibility = false });
    List<DiagramNode> nodes = new List<DiagramNode>();
    nodes.Add(new DiagramNode() { Annotations = annotation });
    ViewBag.Nodes = nodes;

</code></td>
</tr>

<tr>
<td><b>Gets whether the label is currently being edited or not</b></td>
<td>
<b>Property</b>:<i>`Labels.Mode`</i>
<br>
<br>
<code>

    @{
        Collection Labels = new Collection();
        Labels.Add(new Label() { Mode = LabelEditMode.View });
        Html.EJ().Diagram("diagram").Nodes(n => n.Add(new Node() { Labels = Labels })).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
</table>

## PageSettings

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Defines the size and appearance of diagram page</b></td>
<td>
<b>Property</b>:<i>`PageSettings.AutoScrollBorder`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").PageSettings(p=>p.AutoScrollBorder(new AutoScrollBorder() { Left=50, Top=50, Bottom=50, Right=50})).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Sets whether multiple pages can be created to fit all nodes and connectors</b></td>
<td>
<b>Property</b>:<i>`PageSettings.MultiplePage`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").PageSettings(p=>p.MultiplePage(false)).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`PageSettings.MultiplePage`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").PageSettings(new DiagramPageSettings() { MultiplePage= true  }).Render()

</code></td>
</tr>

<tr>
<td><b>Defines the background color of diagram pages</b></td>
<td>
<b>Property</b>:<i>`PageSettings.PageBackgroundColor`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").PageSettings(p=>p.PageBackground("Grey")).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`PageSettings.Background.Color`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").PageSettings(new DiagramPageSettings() { Background = new DiagramBackground() {Color="red" }  }).Render()

</code></td>
</tr>

<tr>
<td><b>Defines the scrollable area of diagram. Applicable, if the scroll limit is “limited”</b></td>
<td>
<b>Property</b>:<i>`PageSettings.ScrollableArea`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").PageSettings(p=>p.ScrollableArea(new ScrollableArea() { Height=300, Width=300, X=0, Y= 0})).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`ScrollSettings.ScrollableArea`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").ScrollSettings(new DiagramScrollSettings() { ScrollableArea = "getScrollableArea" }).Render()

</code>
<code>

    <script>
        function getScrollableArea() {
            var scrollableArea = { X = 0, Y = 0, Width = 300, Height = 300 };
            return scrollableArea;
        }
    </script>

</code></td>
</tr>

<tr>
<td><b>Defines the draggable region of diagram elements</b></td>
<td>
<b>Property</b>:<i>`PageSettings.BoundaryConstraints`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.PageSettings = new PageSettings()
    {
        BoundaryConstraints = BoundaryConstraints.Diagram
    };
    ViewData["diagramModel"] = Model;

</code>
<td>
<b>Property</b>:<i>`PageSettings.BoundaryConstraints`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").PageSettings(new DiagramPageSettings() { BoundaryConstraints= BoundaryConstraints.Diagram  }).Render()

</code></td>
</tr>
</table>

## ScrollSettings

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Defines the zoom value, zoom factor, scroll status and view port size of the diagram</b></td>
<td>
<b>Property</b>:<i>`ScrollSettings.HorizontalOffset`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.ScrollSettings = new ScrollSettings()
    {
        HorizontalOffset = 300
    };
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Property</b>:<i>`ScrollSettings.HorizontalOffset`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").ScrollSettings(new DiagramScrollSettings() { HorizontalOffset = 300 }).Render()

</code></td>
</tr>

<tr>
<td><b>Allows to extend the scrollable region that is based on the scroll limit</b></td>
<td>
<b>Property</b>:<i>`ScrollSettings.Padding`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.ScrollSettings = new ScrollSettings()
    {
        Padding = { Left = 25, Bottom = 25, Right = 25, Top = 25 }
    };
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Allows to read the maximum zoom value of scroller</b></td>
<td><b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`ScrollSettings.MaxZoom`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").ScrollSettings(new DiagramScrollSettings() { MaxZoom = 2.5  }).Render()

</code></td>
</tr>

 <tr>
<td><b>Allows to read the maximum zoom value of scroller</b></td>
<td><b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`ScrollSettings.AutoScrollBorder`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").ScrollSettings(new DiagramScrollSettings() { MaxZoom = 2.5  }).Render()

</code></td>
</tr>

<tr>
<td><b>Enables/Disables the autoscroll option</b></td>
<td><b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`ScrollSettings.CanAutoScroll`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").ScrollSettings(new DiagramScrollSettings() { CanAutoScroll = true }).Render()

</code></td>
</tr>

<tr>
<td><b>Defines the scrollable area of diagram</b></td>
<td><b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`ScrollSettings.ScrollableArea`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").ScrollSettings(new DiagramScrollSettings() { ScrollableArea = "getScrollableArea" }).Render()

</code>
<code>

    <script>
        function getScrollableArea() {
            var scrollableArea = { X = 0, Y = 0, Width = 300, Height = 300 };
            return scrollableArea;
        }
    </script>

</code></td>
</tr>
</table>

## SnapSettings

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Enables or disables snapping nodes/connectors to objects</b></td>
<td>
<b>Property</b>:<i>`SnapSettings.EnableSnapToObject`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").SnapSettings(s=>s.EnableSnapToObject(true)).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines the appearance of horizontal gridlines</b></td>
<td>
<b>Property</b>:<i>`SnapSettings.HorizontalGridLines`</i>
<br>
<br>
<code>

    @{
        decimal lineInterval = { 1, 14, 0.5F, 14.5F};
        Html.EJ().Diagram("diagram").SnapSettings(s=>s.HorizontalGridLines(h=>h.LinesInterval(lineInterval))).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`SnapSettings.HorizontalGridlines`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").SnapSettings(ViewBag.SnapSettings).Render()

</code>
<b>[Model]</b>
<code>

    double[] intervals = { 0.95, 9.05, 0.2, 9.75 };
    DiagramSnapSettings snapSettings = new DiagramSnapSettings();
    snapSettings.HorizontalGridlines = new DiagramGridlines() {
        LineIntervals = intervals
    };
    ViewBag.SnapSettings = snapSettings;

</code></td>
</tr>

<tr>
<td><b>Defines the appearance of vertical gridlines</b></td>
<td>
<b>Property</b>:<i>`SnapSettings.VerticalGridLines`</i>
<br>
<br>
<code>

    @{
        decimal lineInterval = { 1, 14, 0.5F, 14.5F};
        Html.EJ().Diagram("diagram").SnapSettings(s=>s.VerticalGridLines(v=> v.LinesInterval(lineInterval))).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`SnapSettings.VerticalGridLines`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").SnapSettings(ViewBag.SnapSettings).Render()

</code>
<b>[Model]</b>
<code>

    double[] intervals = { 0.95, 9.05, 0.2, 9.75 };
    DiagramSnapSettings snapSettings = new DiagramSnapSettings();
    snapSettings.VerticalGridLines = new DiagramGridlines() {
        LineIntervals = intervals
    };
    ViewBag.SnapSettings = snapSettings;

</code></td>
</tr>

<tr>
<td><b>Defines the angle by which the object needs to be snapped</b></td>
<td>
<b>Property</b>:<i>`SnapSettings.SnapAngle`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").SnapSettings(s=>s.SnapAngle(5)).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`SnapSettings.SnapAngle`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").SnapSettings(ViewBag.SnapSettings).Render()

</code>
<b>[Model]</b>
<code>

    DiagramSnapSettings snapSettings = new DiagramSnapSettings();
    snapSettings.SnapAngle = 5;
    ViewBag.SnapSettings = snapSettings;

</code></td>
</tr>

<tr>
<td><b>Sets the minimum distance between the selected object and the nearest object</b></td>
<td>
<b>Property</b>:<i>`SnapSettings.SnapObjectDistance`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").SnapSettings(s=>s.SnapObjectDistance(5)).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`SnapSettings.SnapObjectDistance`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").SnapSettings(ViewBag.SnapSettings).Render()

</code>
<b>[Model]</b>
<code>

    DiagramSnapSettings snapSettings = new DiagramSnapSettings();
    snapSettings.SnapObjectDistance = 5;
    ViewBag.SnapSettings = snapSettings;

</code></td>
</tr>

<tr>
<td><b>Defines and sets the snapConstraints</b></td>
<td>
<b>Property</b>:<i>`SnapSettings.SnapConstraints`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").SnapSettings(s=>s.SnapConstraints(SnapConstraints.ShowLines)).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`SnapSettings.Constraints`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").SnapSettings(ViewBag.SnapSettings).Render()

</code>
<b>[Model]</b>
<code>

    DiagramSnapSettings snapSettings = new DiagramSnapSettings();
    snapSettings.Constraints = SnapConstraints.ShowLines;
    ViewBag.SnapSettings = snapSettings;

</code></td>
</tr>
</table>

## ZoomFactor

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Sets the factor by which we can zoom in or zoom out</b></td>
<td>
<b>Property</b>:<i>`ZoomFactor`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").ZoomFactor(1).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`ZoomFactor`</i>
<br>
<br>
<code>

    var zoomIn = { type: 'ZoomIn', zoomFactor: 0.5 };
    diagram.ZoomTo(zoomIn);

</code>
</td>
</tr>
</table>

## Tool

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Enables/Disables the interactive behaviors of diagram</b></td>
<td>
<b>Property</b>:<i>`Tool`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Tool(Tool.ZoomPan).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Tool`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Tool(DiagramTools.ZoomPan).Render()

</code></td>
</tr>
</table>

## ShowTooltip

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Enables or disables tooltip of diagram</b></td>
<td>
<b>Property</b>:<i>`ShowTooltip`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Height("500px").Width("500px").ShowTooltip(true).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Constraints`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Constraints(DiagramConstraints.Default | DiagramConstraints.Tooltip).Render()

</code></td>
</tr>
</table>

## SelectedItems

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>A read only collection of the selected items</b></td>
<td>
<b>Property</b>:<i>`SelectedItems.Children`</i>
<br>
<code>

    var diagram = $("#diagramcontent").EjDiagram("instance");
    for(var i =0; i< diagram.Model.SelectedItems.Children; i++){
        //Do your actions here
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Controls the visibility of selector</b></td>
<td>
<b>Property</b>:<i>`SelectedItems.Constraints`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").SelectedItems(new SelectedItems() { Constraints = SelectorConstraints.UserHandles } } }).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`SelectedItems.Constraints`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").SelectedItems(new DiagramSelector() { Constraints = SelectorConstraints.UserHandle}).Render()

</code></td>
</tr>

<tr>
<td><b>Sets the angle to rotate the selected items</b></td>
<td>
<b>Property</b>:<i>`SelectedItems.Tooltip`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").SelectedItems(new SelectedItems() { Tooltip = new Tooltip() { Alignment = { Vertical = VerticalAlignment.Top } } }).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>A collection of frequently used commands that will be added around the selector</b></td>
<td>
<b>Property</b>:<i>`SelectedItems.UserHandles`</i>
<br>
<br>
<code>

    var userHandle= [];
    var cloneHandle = ej.Datavisualization.Diagram.UserHandle();
    userHandle.Push(cloneHandle);
            var diagram = $("#DiagramContent").EjDiagram("instance");
    $("#diagramcontent").EjDiagram({
        selectedItems: {
            userHandles:userHandle
            }
        });

</code>
</td>
<td>
<b>Property</b>:<i>`SelectedItems.UserHandles`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").SelectedItems(ViewBag.Selector).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramUserHandle> userHandle = new List<DiagramUserHandle>();
    userHandle.Add(new DiagramUserHandle()
    {
        Name = "clone",
        PathData = 'M 60.3,18 H 27.5 c -3,0-5.5,2.4-5.5,5.5 v 38.2 h 5.5 V 23.5 h 32.7 V 18 z M 68.5,28.9 h -30 c -3,0-5.5,2.4-5.5,5.5 v 38.2 c 0,3,2.4,5.5,5.5,5.5 h 30 c 3,0,5.5-2.4,5.5-5.5 V 34.4 C 73.9,31.4,71.5,28.9,68.5,28.9 z M 68.5,72.5 h -30 V 34.4 h 30 V 72.5 z',
    });

    DiagramSelector selector = new DiagramSelector();
    selector.UserHandles = userHandle;
    ViewBag.Selector = selector;

</code></td>
</tr>

<tr>
<td><b>Sets the horizontal alignment of the user handle</b></td>
<td>
<b>Property</b>:<i>`SelectedItems.UserHandles.HorizontalAlignment`</i>
<br>
<br>
<code>

    var userHandle = [];
    var cloneHandle = ej.Datavisualization.Diagram.UserHandle();
    cloneHandle = {name : "cloneHandle",
    pathData : "M 4.6350084,4.8909971 L 4.6350084,9.3649971 9.5480137,9.3649971 9.5480137,4.8909971 z M 3.0000062,2.8189973 L 11.184016,2.8189973 11.184016,10.999997 3.0000062,10.999997 z M 0,0 L 7.3649998,0 7.3649998,1.4020001 1.4029988,1.4020001 1.4029988,8.0660002 0,8.0660002 0,1.4020001 0,0.70300276 z",
    visible : "true",
    backgroundColor : "#4D4D4D",
    offset : ej.Datavisualization.Diagram.Point(0, 0),
    position :" middleLeft"
    margin : { left: 5 },
    pathColor : "white",
    horizontalAlignment : ej.Datavisualization.Diagram.HorizontalAlignment.Right,
    verticalAlignment : ej.Datavisualization.Diagram.VerticalAlignment.Top,
    borderColor : "red",
    borderWidth : 3,
    size : 20};
    userHandle.Push(cloneHandle);
    $("#diagramcontent").EjDiagram({
    selectedItems: {
    userHandles:userHandle
    }
    });

</code>

</td>
<td>
<b>Property</b>:<i>`SelectedItems.UserHandles.HorizontalAlignment`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").SelectedItems(ViewBag.Selector).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramUserHandle> userHandle = new List<DiagramUserHandle>();
    userHandle.Add(new DiagramUserHandle()
    {
        HorizontalAlignment = HorizontalAlignment.Auto
    });

    DiagramSelector selector = new DiagramSelector();
    selector.UserHandles = userHandle;
    ViewBag.Selector = selector;

</code></td>
</tr>

<tr>
<td><b>Defines the interactive behaviors of the user handle
</b></td>
<td>
<b>Property</b>:<i>`SelectedItems.UserHandles.Tool`</i>
<br>
<br>
<code>

    var CloneTool = (function(base) {
        ej.Datavisualization.Diagram.Extend(CloneTool, base);
        function CloneTool(name) {
            base.Call(this, name);
            this.SingleAction = true;
            this.ClonedNodes = [];
            this.Cursor = "pointer";
        }
        CloneTool.Prototype.Mouseup = function(event) {
            this.Diagram.Copy();
            this.Diagram.Paste();
        }
    }
    return CloneTool;
    });
    (ej.Datavisualization.Diagram.ToolBase);
    var userHandle = [];
    var cloneHandle = ej.Datavisualization.Diagram.UserHandle();
    cloneHandle.Name = "cloneHandle";
    cloneHandle.PathData = "M 4.6350084,4.8909971 L 4.6350084,9.3649971 9.5480137,9.3649971 9.5480137,4.8909971 z M 3.0000062,2.8189973 L 11.184016,2.8189973 11.184016,10.999997 3.0000062,10.999997 z M 0,0 L 7.3649998,0 7.3649998,1.4020001 1.4029988,1.4020001 1.4029988,8.0660002 0,8.0660002 0,1.4020001 0,0.70300276 z";
    cloneHandle.Tool = new CloneTool(cloneHandle.Name);;
    userHandle.Push(cloneHandle);
    $("#diagramcontent").EjDiagram({
    selectedItems: {
    userHandles: userHandle
    }
    });

</code>

</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Defines whether the user handle should be added, when more than one element is selected
</b></td>
<td>
<b>Property</b>:<i>`SelectedItems.UserHandles.EnableMultiSelection`</i>
<br>
<br>
<code>

    var userHandle = [];
    var cloneHandle = ej.Datavisualization.Diagram.UserHandle();
    cloneHandle.Name = "cloneHandle";
    cloneHandle.EnableMultiSelection = true;
    userHandle.Push(cloneHandle);
    $("#diagramcontent").EjDiagram({
    selectedItems: {
    userHandles: userHandle
    }
    });

</code>

</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Sets the horizontal alignment of the user handle</b></td>
<td>
<b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`SelectedItems.UserHandles.Displacement`</i>
<br>
<br>
<b>[View]</b>
<code>

    @Html.EJS().Diagram("container").SelectedItems(ViewBag.Selector).Render()

</code>
<b>[Model]</b>
<code>

    List<DiagramUserHandle> userHandle = new List<DiagramUserHandle>();
    userHandle.Add(new DiagramUserHandle()
    {
        Displacement = 30
    });
    DiagramSelector selector = new DiagramSelector();
    selector.UserHandles = userHandle;
    ViewBag.Selector = selector;

</code></td>
</tr>
</table>

## SerializationSettings

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>Defines whether the default diagram properties can be serialized or not</b></td>
<td>
<b>Property</b>:<i>`SerializationSettings.PreventDefaultValues`</i>
<br>
<br>
<b>[View]</b>

<code>

    @Html.EJ().Diagram("diagram", ViewData["diagramModel"] as DiagramProperties);

</code>
<b>[Model]</b>

<code>

    DiagramProperties Model = new DiagramProperties();
    Model.SerializationSettings = new SerializationSettings() {
        PreventDefaultValues = true
    };
    ViewData["diagramModel"] = Model;

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>
</table>

## Tooltip

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>behavior</b></td>
<td><b>API in Essential JS 1</b></td>
<td><b>API in Essential JS 2</b></td>
</tr>

<tr>
<td><b>An object that defines the description, appearance and alignments of tooltip</b></td>
<td>
<b>Property</b>:<i>`Tooltip`</i>
<br>
<br>
<code>

    <script type="text/x-jsrender" id="mouseovertooltip">
    <div style="background-color: #F08080; color: white; white-space: nowrap; height: 20px">
            <span style="padding: 5px;">  </span>
    </div>
    </script>

</code>
<code>

    @{
        Html.EJ().Diagram("diagram").Tooltip(new Diagram.Tooltip() { TemplateId= "mouseOverTooltip" }).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Tooltip`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Constraints(DiagramConstraints.Default | DiagramConstraints.Tooltip).Tooltip(new DiagramDiagramTooltip() { Content = "Diagram"}).Render()

</code></td>
</tr>

<tr>
<td><b>Defines the alignment of tooltip</b></td>
<td>
<b>Property</b>:<i>`Tooltip.Alignment`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Tooltip(new Diagram.Tooltip() { Alignment= new Diagram.Alignment() { Horizontal=HorizontalAlignment.Left}  }).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>Sets the margin of the tooltip</b></td>
<td>
<b>Property</b>:<i>`Tooltip.Margin`</i>
<br>
<br>
<code>

    @{
        Html.EJ().Diagram("diagram").Tooltip(new Diagram.Tooltip() {  Margin= new Margin() { Left=5, Bottom=5, Right=5, Top=5}  }).Render();
    }

</code>
</td>
<td>
<b>Not applicable</b></td>
</tr>

<tr>
<td><b>Sets the svg/html template to be bound with tooltip</b></td>
<td>
<b>Property</b>:<i>`Tooltip.TemplateId`</i>
<br>
<br>
<code>

    <script type="text/x-jsrender" id="mouseovertooltip">
    <div style="background-color: #F08080; color: white; white-space: nowrap; height: 20px">
            <span style="padding: 5px;">  </span>
    </div>
    </script>

<code>
</code>

    @{
        Html.EJ().Diagram("diagram").Tooltip(new Diagram.Tooltip() { TemplateId= "mouseOverTooltip"  }).Render();
    }

</code>
</td>
<td>
<b>Property</b>:<i>`Tooltip.Content`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Tooltip(new DiagramDiagramTooltip() { Content = "Diagram"}).Render()

</code></td>
</tr>

<tr>
<td><b>Defines if the Tooltip has tip pointer or not</b></td>
<td><b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`Tooltip.ShowTipPointer`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Tooltip(new DiagramDiagramTooltip() { ShowTipPointer = true }).Render()

</code></td>
</tr>

<tr>
<td><b>Defines the position of the Tooltip</b></td>
<td><b>Not applicable</b>
</td>
<td>
<b>Property</b>:<i>`Tooltip.Position`</i>
<br>
<br>
<code>

    @Html.EJS().Diagram("container").Tooltip(new DiagramDiagramTooltip() { Position = "TopLeft" }).Render()

</code></td>
</tr>
</table>
