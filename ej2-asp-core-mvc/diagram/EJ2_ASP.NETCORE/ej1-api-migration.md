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
<td><b>Defines how to align the background image over the diagram area</b></td>
<td><b>Property</b>:<i>`BackgroundImage.Alignment`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-background-image alignment="XMidYMid"></e-background-image>
    </ej-diagram>

</code>
</td>
<td><b>Property</b>:<i>`Background.Align`</i>
<code>

    <ejs-diagram>
        <e-diagram-pagesettings>
            <e-pagesettings-background align="XMidYMid"></e-pagesettings-background>
        </e-diagram-pagesettings>
    </ejs-diagram>

</code>
</td>
</tr>
<tr>
<td><b>Defines how the background image should be scaled/stretched</b></td>
<td><b>Property</b>:<i>`BackgroundImage.Scale`</i>
<code>

    <ej-diagram>
        <e-background-image scale="Meet"></e-background-image>
    </ej-diagram>

</code>
</td>
<td><b>Property</b>:<i>`Background.Align`</i>
<code>

    <ejs-diagram>
        <e-diagram-pagesettings>
            <e-pagesettings-background scale="Meet"></e-pagesettings-background>
        </e-diagram-pagesettings>
    </ejs-diagram>

</code>
</td>
</tr>
<tr>
<td><b>Sets the source path of the background image</b></td>
<td><b>Property</b>:<i>`BackgroundImage.Source`</i>
<code>

    <ej-diagram>
        <e-background-image source="../images/Employee/Artboard 13.Png"></e-background-image>
    </ej-diagram>

</code>
</td>
<td><b>Property</b>:<i>`Background.Source`</i>
<code>

    <ejs-diagram>
        <e-diagram-pagesettings>
            <e-pagesettings-background source="../images/Employee/Artboard 13.Png"></e-pagesettings-background>
        </e-diagram-pagesettings>
    </ejs-diagram>

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

    <ej-diagram bridge-direction="Bottom"></ej-diagram>

</code>
</td>

<td><b>Property</b>:<i>`BridgeDirection`</i>
<code>

    <ejs-diagram  bridgeDirection="Bottom"></ejs-diagram>

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
<code>

    <ej-diagram>
        <e-command-manager>
            <e-commands>
                <e-command can-execute="canExecute" execute="execute">
                    <e-gesture key="C" key-modifiers="Shift"></e-gesture>
                </e-command>
            </e-commands>
        </e-command-manager>
    </ej-diagram>

</code>
<code>

    <script>
        function canExecute(args) {
            var diagram = $("#diagram").ejDiagram("instance");
            return diagram.model.selectedItems.children.length;
        }
        function execute(args) {
            var diagram = $("#diagram").ejDiagram("instance");
            diagram.copy();
            diagram.paste();
        }
    </script>

</code>
</td>
<td>
<b>Property</b>:<i>`CommandManager.Commands`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram commandManager="@ViewBag.commands"></ejs-diagram>

</code>
<code>

    <script>

        function canExecute() {
            var diagram = document.getElementById("diagram").ej2_instances[0];
            if (diagram.selectedItems.nodes.length > 0 || diagram.selectedItems.connectors.length > 0) {
                return true;
            }
            return false;
        }

        function execute() {
            var diagram = document.getElementById("diagram").ej2_instances[0];
            diagram.copy();
            diagram.paste();
        }

    </script>

</code>
<b>[Model]</b>
<code>

    List<DiagramCommand> commands = new List<DiagramCommand>();
    commands.Add(new DiagramCommand() { CanExecute = "canExecute", Execute = "execute", Gesture = new DiagramKeyGesture() { Key = Keys.C, KeyModifiers = KeyModifiers.Shift }, Name = "clone", Parameter = "node" });
    ViewBag.commands = commands;

</code></td>

</tr>
<tr>
<td><b>Defines any additional parameters that are required at runtime</b></td>
<td>
<b>Property</b>:<i>`CommandManager.Commands.Parameter`</i>
<code>

    <ej-diagram>
        <e-command-manager>
            <e-commands>
                <e-command can-execute="canExecute" execute="execute" parameter="node">
                    <e-gesture key="C" key-modifiers="Shift"></e-gesture>
                </e-command>
            </e-commands>
        </e-command-manager>
    </ej-diagram>

</code>
<code>

    <script>
        function canExecute(args) {
            var diagram = $("#diagram").ejDiagram("instance");
            return diagram.model.selectedItems.children.length;
        }
        function execute(args) {
            var diagram = $("#DiagramContent").ejDiagram("instance");
            diagram.copy();
            diagram.paste();
        }
    </script>

</code>
</td>
<td>
<b>Property</b>:<i>`CommandManager.Commands.Parameter`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram commandManager="@ViewBag.commands"></ejs-diagram>

</code>
<code>

    <script>

        function canExecute() {
            var diagram = document.getElementById("diagram").ej2_instances[0];
            if (diagram.selectedItems.nodes.length > 0 || diagram.selectedItems.connectors.length > 0) {
                return true;
            }
            return false;
        }

        function execute() {
            var diagram = document.getElementById("diagram").ej2_instances[0];
            diagram.copy();
            diagram.paste();
        }

    </script>

</code>
<b>[Model]</b>
<code>

    List<DiagramCommand> commands = new List<DiagramCommand>();
    commands.Add(new DiagramCommand() { CanExecute = "canExecute", Execute = "execute", Gesture = new DiagramKeyGesture() { Key = Keys.C, KeyModifiers = KeyModifiers.Shift }, Name = "clone", Parameter = "node" });
    ViewBag.commands = commands;

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
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector add-info="@ViewBag.addInfo"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
<b>[Model]</b>
<code>

    Dictionary<string, object> addInfo = new Dictionary<string, object>();
    addInfo.Add("Description", "Bidirectional Flow");
    ViewBag.addInfo = addInfo;

</code>
</td>
<td>
<b>Property</b>:<i>`Connectors.AddInfo`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector addInfo="@ViewBag.addInfo"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code>
<b>[Model]</b>
<code>

    Dictionary<string, object> addInfo = new Dictionary<string, object>();
    addInfo.Add("Description", "Bidirectional Flow");
    ViewBag.addInfo = addInfo;

</code></td>

</tr>

<tr>
<td><b>Defines the bridgeSpace of connector</b></td>
<td>
<b>Property</b>:<i>`Connector.BridgeSpace`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector bridge-space="15"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Connectors.BridgeSpace`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector bridgeSpace="5"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Enables or disables the behaviors of connectors</b></td>
<td>
<b>Property</b>:<i>`Connector.Constraints`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector constraints="Bridging"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Connector.Constraints`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector constraints="Bridging"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the radius of the rounded corner</b></td>
<td>
<b>Property</b>:<i>`Connector.CornerRadius`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector corner-radius="5"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Connector.CornerRadius`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector cornerRadius="5"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector css-class="hoverConnector"></e-connector>
        </e-connectors>
    </ej-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector horizontal-align="Left"></e-connector>
        </e-connectors>
    </ej-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-labels>
                    <e-diagram-label text="label"></e-diagram-label>
                </e-labels>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Connector.Annotations`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-connectorannotations>
                    <e-connector-connectorannotation content="annotation"></e-connector-connectorannotation>
                </e-connector-connectorannotations>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>
<tr>
<td><b>Stroke color of the connector</b></td>
<td>
<b>Property</b>:<i>`Connector.LineColor`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector line-color="bllue"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Connector.Style.StrokeColor`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-style strokeColor="blue" opacity="5" strokeDashArray="2,2" strokeWidth="2"></e-connector-style>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector line-dash-array="2,2"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Connector.Style.StrokeDashArray`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-style strokeDashArray="2,2"></e-connector-style>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>
<tr>
<td><b>Sets the width of the line</b></td>
<td>
<b>Property</b>:<i>`Connector.LineWidth`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector line-width="2"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Connector.Style.StrokeWidth`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-style strokeWidth="2"></e-connector-style>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector line-hit-padding="15"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Connectors.HitPadding`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector hitPadding="15">
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>
<tr>
<td><b>Sets a unique name for the connector</b></td>
<td>
<b>Property</b>:<i>`Connector.Name`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector name="connector"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.Id`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector id="connector"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>
<tr>
<td><b>Defines the transparency of the connector</b></td>
<td>
<b>Property</b>:<i>`Connector.Opacity`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector opacity="0.5"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.Style.Opacity`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-style opacity="5"></e-connector-style>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>
<tr>
<td><b>Sets the parent name of the connector.</b></td>
<td>
<b>Property</b>:<i>`Connector.Parent`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector parent="parent"></e-connector>
        </e-connectors>
    </ej-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-segments>
                    <e-segment type="Orthogonal"></e-segment>
                </e-segments>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connector.Segments`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector segments="@ViewBag.segments"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code>
<b>[Model]</b>
<code>

    List<Segment> segments = new List<Segment>();
    segments.Add(new Segment() { Type = Segments.Orthogonal });
    ViewBag.segments = segments;

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-segments>
                    <e-segment direction="bottom"></e-segment>
                </e-segments>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.Segments.Direction`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector segments="@ViewBag.segments"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code>
<b>[Model]</b>
<code>

    List<Segment> segments = new List<Segment>();
    segments.Add(new Segment() { Direction = "Bottom" });
    ViewBag.segments = segments;

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-segments>
                    <e-segment length="50"></e-segment>
                </e-segments>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.Segments.Length`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector segments="@ViewBag.segments"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code>
<b>[Model]</b>
<code>

    List<Segment> segments = new List<Segment>();
    segments.Add(new Segment() { Length = 30 });
    ViewBag.segments = segments;

</code></td>

</tr>

<tr>
<td><b>Describes the end point of bezier/straight segment</b></td>
<td>
<b>Property</b>:<i>`Connector.Segments.Point`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-segments>
                    <e-segment>
                        <e-point x="75" y="150"></e-point>
                    </e-segment>
                </e-segments>
            </e-connector>
        </e-connectors>
    </ej-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-segments>
                    <e-segment type="Orthogonal">
                        <e-point1 x="75" y="150"></e-point1>
                    </e-segment>
                </e-segments>
            </e-connector>
        </e-connectors>
    </ej-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-segments>
                    <e-segment type="Orthogonal">
                        <e-point2 x="75" y="150"></e-point2>
                    </e-segment>
                </e-segments>
            </e-connector>
        </e-connectors>
    </ej-diagram>

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
<b>Property</b>:<i>`Connectors.Segments.Type`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-segments>
                    <e-segment type="Orthogonal"></e-segment>
                </e-segments>
            </e-connector>
        </e-connectors>
    </ej-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-segments>
                    <e-segment>
                        <e-vector1 angle="60" distance="0"></e-vector1>
                    </e-segment>
                </e-segments>
            </e-connector>
        </e-connectors>
    </ej-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-segments>
                    <e-segment>
                        <e-vector2 angle="60" distance="0"></e-vector2>
                    </e-segment>
                </e-segments>
            </e-connector>
        </e-connectors>
    </ej-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-shape type="BPMN"></e-shape>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Connectors.Shape.Type`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-shape type="Bpmn"></e-connector-shape>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-source-decorator shape="Arrow"></e-source-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-sourcedecorator shape="Arrow"></e-connector-sourcedecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the border color of the source decorator</b></td>
<td>
<b>Property</b>:<i>`Connector.SourceDecorator.BorderColor`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-source-decorator border-color="red"></e-source-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator.Style.StrokeColor`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-sourcedecorator>
                    <e-decorator-style strokeColor="red"></e-decorator-style>
                </e-connector-sourcedecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>
<tr>
<td><b>Sets the border width of the decorator</b></td>
<td>
<b>Property</b>:<i>`Connector.SourceDecorator.BorderWidth`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-source-decorator border-width="2"></e-source-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator.Style.StrokeWidth`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-sourcedecorator>
                    <e-decorator-style strokeWidth="2"></e-decorator-style>
                </e-connector-sourcedecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-source-decorator css-class="classname"></e-source-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-source-decorator fill-color="red"></e-source-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator.Style.Fill`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-sourcedecorator>
                    <e-decorator-style fill="red"></e-decorator-style>
                </e-connector-sourcedecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>
<tr>
<td><b>Sets the height of the source decorator</b></td>
<td>
<b>Property</b>:<i>`Connector.SourceDecorator.Height`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-source-decorator height="10"></e-source-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator.Height`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-sourcedecorator height="10"></e-connector-sourcedecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-source-decorator shape="Path"  path-data="M 376.892,225.284L 371.279,211.95L 376.892,198.617L 350.225,211.95L 376.892,225.284 Z"></e-source-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator.PathData`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-sourcedecorator shape="Path" pathData="M 376.892,225.284L 371.279,211.95L 376.892,198.617L 350.225,211.95L 376.892,225.284 Z"></e-connector-sourcedecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-source-decorator shape="Arrow"></e-source-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator.Shape`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-sourcedecorator shape="Arrow"></e-decorator-style>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-source-decorator width="10"></e-source-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceDecorator.Width`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-sourcedecorator width="10"></e-connector-sourcedecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector source-node="source"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourceID`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector sourceID="source"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the space to be left between the source node and the source point of a connector</b></td>
<td>
<b>Property</b>:<i>`Connector.SourcePadding`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector source-padding="2"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.HitPadding`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector hitPadding="20"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector >
                <e-source-point x="100" y="100"></e-source-point>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourcePoint`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-sourcepoint x="100" y="100"></e-connector-sourcepoint>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector source-port="sourceport"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.SourcePortID`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector sourcePortID="sourceport"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-target-decorator shape="Arrow"></e-target-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-targetdecorator shape="Arrow"></e-connector-targetdecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the border color of the target decorator</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetDecorator.BorderColor`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-target-decorator border-color="red"></e-target-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator.Style.StrokeColor`</i>
<br>
<br>
<code>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-targetdecorator>
                    <e-decorator-style strokeColor="red"></e-decorator-style>
                </e-connector-targetdecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>
<tr>
<td><b>Sets the border width of the decorator</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetDecorator.BorderWidth`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-target-decorator border-width="2"></e-target-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator.Style.StrokeWidth`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-targetdecorator>
                    <e-decorator-style strokeWidth="2"></e-decorator-style>
                </e-connector-targetdecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-target-decorator css-class="classname"></e-target-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-target-decorator fill-color="red"></e-target-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator.Style.Fill`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-targetdecorator>
                    <e-decorator-style fill="red"></e-decorator-style>
                </e-connector-targetdecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>
<tr>
<td><b>Sets the height of the target decorator</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetDecorator.Height`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-target-decorator height="10"></e-target-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator.Height`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-targetdecorator height="10"></e-connector-targetdecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-target-decorator shape="Path" path-data="M 376.892,225.284L 371.279,211.95L 376.892,198.617L 350.225,211.95L 376.892,225.284 Z"></e-target-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator.PathData`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-targetdecorator shape="Path" pathData="M 376.892,225.284L 371.279,211.95L 376.892,198.617L 350.225,211.95L 376.892,225.284 Z"></e-connector-targetdecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-target-decorator shape="Arrow"></e-target-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator.Shape`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-targetdecorator shape="Arrow"></e-connector-targetdecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-target-decorator width="10"></e-target-decorator>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetDecorator.Width`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-targetdecorator width="10"></e-connector-targetdecorator>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector target-node="target"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetID`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector targetID="target"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

</code></td>

</tr>
<tr>
<td><b>Defines the space to be left between the target node and the target point of a connector</b></td>
<td>
<b>Property</b>:<i>`Connector.TargetPadding`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-connectors>
            <e-connector target-padding="2"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.HitPadding`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector hitPadding="20"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector>
                <e-target-point x="200" y="200"></e-target-point>
            </e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetPoint`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-targetpoint x="200" y="200"></e-connector-targetpoint>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector target-port="targetport"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.TargetPortID`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector targetPortID="targetport"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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
<b>[View]</b>
<code>

    <script type="text/x-jsrender" id="mouseovertooltip"><br>
        <div style="background-color: #F08080; color: white; white-space: nowrap; height: 20px"><br>
            <span style="padding: 5px;">  </span><br>
        </div><br>
    </script>

<br>

    <ej-diagram>
        <e-connectors>
            <e-connector tooltip="@ViewBag.toolTip"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
<b>[Model]</b>
<code>

    Tooltip tooltip = new Tooltip() { TemplateId = "mouseOverTooltip"};
    ViewBag.tooltip = tooltip;

</code>
</td><td>
<b>Property</b>:<i>`Connectors.Tooltip`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector>
                <e-connector-tooltip content="connector"></e-connector-tooltip>
            </e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector vertical-align="Center"></e-connector>
        </e-connectors>
    </ej-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector visible="true"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.Visible`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector visible="true"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram>
        <e-connectors>
            <e-connector z-order="3"></e-connector>
        </e-connectors>
    </ej-diagram>

</code>
</td><td>
<b>Property</b>:<i>`Connectors.ZIndex`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-connectors>
            <e-diagram-connector zIndex="3"></e-diagram-connector>
        </e-diagram-connectors>
    </ejs-diagram>

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

    <ej-diagram context-menu="@ViewBag.contextMenu"></ej-diagram>

</code>
<b>[Model]</b>

<code>

    List<ContextMenuItem> items = new List<ContextMenuItem>();
    items.Add(new ContextMenuItem() { Name = "HyperLink" });
    DiagramContextMenu contextMenu = new DiagramContextMenu()
    {
        Items = items
    };
    ViewBag.contextMenu = contextMenu;

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Items`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram contextMenuSettings="@ViewBag.contextMenuSettings"></ejs-diagram>

</code>
<b>[Model]</b>
<code>

    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Text = "delete" });
    DiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        Items = "menuItems"
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

    <ej-diagram context-menu="@ViewBag.contextMenu"></ej-diagram>

</code>
<b>[Model]</b>

<code>

    List<ContextMenuItem> items = new List<ContextMenuItem>();
    items.Add(new ContextMenuItem() { Text = "text" });
    DiagramContextMenu contextMenu = new DiagramContextMenu()
    {
        Items = items
    };
    ViewBag.contextMenu = contextMenu;

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Items.Text`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram contextMenuSettings="@ViewBag.contextMenuSettings"></ejs-diagram>

</code>
<b>[Model]</b>
<code>

    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Text = "text" });
    DiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        Items = "menuItems"
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

    <ej-diagram context-menu="@ViewBag.contextMenu"></ej-diagram>

</code>
<b>[Model]</b>

<code>

    List<ContextMenuItem> items = new List<ContextMenuItem>();
    items.Add(new ContextMenuItem() { Name = "HyperLink" });
    DiagramContextMenu contextMenu = new DiagramContextMenu()
    {
        Items = items
    };
    ViewBag.contextMenu = contextMenu;

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Items.Id`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram contextMenuSettings="@ViewBag.contextMenuSettings"></ejs-diagram>

</code>
<b>[Model]</b>
<code>

    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Id = "id" });
    DiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        Items = "menuItems"
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

    <ej-diagram context-menu="@ViewBag.contextMenu"></ej-diagram>

</code>
<b>[Model]</b>

<code>

    List<ContextMenuItem> items = new List<ContextMenuItem>();
    items.Add(new ContextMenuItem() { ImageUrl = "Images/zoomIn.Png" });
    DiagramContextMenu contextMenu = new DiagramContextMenu()
    {
        Items = items
    };
    ViewBag.contextMenu = contextMenu;

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Items.Url`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram contextMenuSettings="@ViewBag.contextMenuSettings"></ejs-diagram>

</code>
<b>[Model]</b>
<code>

    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { Url = "Images/zoomIn.Png" });
    DiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        Items = "menuItems"
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

    <ej-diagram context-menu="@ViewBag.contextMenu"></ej-diagram>

</code>
<b>[Model]</b>

<code>

    List<ContextMenuItem> items = new List<ContextMenuItem>();
    items.Add(new ContextMenuItem() { CssClass = "menu" });
    DiagramContextMenu contextMenu = new DiagramContextMenu()
    {
        Items = items
    };
    ViewBag.contextMenu = contextMenu;

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Items.IconCss`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram contextMenuSettings="@ViewBag.contextMenuSettings"></ejs-diagram>

</code>
<b>[Model]</b>
<code>

    List<ContextMenuItem> menuItems = new List<ContextMenuItem>();
    menuItems.Add(new ContextMenuItem() { IconCss = "e-copy" });
    DiagramContextMenuSettings contextMenuSettings = new DiagramContextMenuSettings()
    {
        Items = "menuItems"
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

    <ej-diagram context-menu="@ViewBag.contextMenu"></ej-diagram>

</code>
<b>[Model]</b>

<code>

    List<ContextMenuItem> subItems = new List<ContextMenuItem>();
    subItems.Add(new ContextMenuItem() { Name = "HyperLink" });
    List<ContextMenuItem> items = new List<ContextMenuItem>();
    items.Add(new ContextMenuItem() { SubItems = subItems });
    DiagramContextMenu contextMenu = new DiagramContextMenu()
    {
        Items = items
    };
    ViewBag.contextMenu = contextMenu;

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Items.Items`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram contextMenuSettings="@ViewBag.contextMenuSettings"></ejs-diagram>

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
<code>

    <ej-diagram >
        <e-context-menu show-custom-menu-items-only="true"></e-context-menu>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.ShowCustomMenuOnly`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-contextmenusettings showCustomMenuOnly="true"></e-diagram-contextmenusettings>
    </ejs-diagram>

</code>
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

    <ejs-diagram contextMenuSettings="@ViewBag.contextMenuSettings"></ejs-diagram>

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

    <ejs-diagram contextMenuSettings="@ViewBag.contextMenuSettings"></ejs-diagram>

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
<code>

    <ejs-diagram contextMenuSettings="@ViewBag.contextMenuSettings">
        <e-diagram-contextmenusettings show="true"></e-diagram-contextmenusettings>
    </ejs-diagram>

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
<td><b>Sets the unique id of the data source items</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.Id`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-datasource-settings  id="id"></e-datasource-settings>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`DataSourceSettings.Id`</i>
<br>
<br>

    <ejs-diagram>
        <e-diagram-datasourcesettings id="id"></e-diagram-datasourcesettings>
    </ejs-diagram>

</code></td>

</tr>
<tr>
<td><b>Defines the parent id of the data source item</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.Parent`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-datasource-settings parent="parent"></e-datasource-settings>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`DataSourceSettings.ParentId`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-datasourcesettings parentId="parentId"></e-diagram-datasourcesettings>
    </ejs-diagram>

</code></td>

</tr>
<tr>
<td><b>Describes query to retrieve a set of data from the specified datasource</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.Query`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-datasource-settings query="datasource query"></e-datasource-settings>
    </ej-diagram>

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
<code>

    <ej-diagram>
        <e-datasource-settings root="E1"></e-datasource-settings>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`DataSourceSettings.Root`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-datasourcesettings root="E1"></e-diagram-datasourcesettings>
    </ejs-diagram>

</code></td>

</tr>
<tr>
<td><b>Describes the name of the table on which the specified query has to be executed</b></td>
<td>
<b>Property</b>:<i>`DataSourceSettings.TableName`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-datasource-settings table-name="datasource table name"></e-datasource-settings>
    </ej-diagram>

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

    <ej-diagram>
        <e-datasource-settings crud-action="@ViewBag.crudAction"></e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    CRUDAction crudAction = new CRUDAction()
    {
        Read = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/GetNodes"
    };
    ViewBag.crudAction = crudAction;

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

    <ej-diagram>
        <e-datasource-settings crud-action="@ViewBag.crudAction"></e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    CRUDAction crudAction = new CRUDAction()
    {
        Create = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/AddNodes"
    };
    ViewBag.crudAction = crudAction;

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

    <ej-diagram>
        <e-datasource-settings crud-action="@ViewBag.crudAction"></e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    CRUDAction crudAction = new CRUDAction()
    {
        Update = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/UpdateNodes"
    };
    ViewBag.crudAction = crudAction;

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

    <ej-diagram>
        <e-datasource-settings crud-action="@ViewBag.crudAction"></e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    CRUDAction crudAction = new CRUDAction()
    {
        Destroy = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/DeleteNodes"
    };
    ViewBag.crudAction = crudAction;

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

    <ej-diagram>
        <e-datasource-settings crud-action="@ViewBag.crudAction"></e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    CRUDAction crudAction = new CRUDAction()
    {
        Read = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/GetNodes"
    };
    ViewBag.crudAction = crudAction;

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

    <ej-diagram>
        <e-datasource-settings custom-fields="@ViewBag.customFeilds"></e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    List<string> customFields = new List<string>();
    customFields.Add("Description");
    customFields.Add("Color");
    ViewBag.customFields = customFields;

</code>
</td>
<td>
<b>Property</b>:<i>`DataSourceSettings.Data`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram>
        <e-diagram-datasourcesettings data="@ViewBag.data"></e-diagram-datasourcesettings>
    </ejs-diagram>

</code>
<b>[Model]</b>
<code>

    List<string> data = new List<string>();
    data.Add("Description");
    data.Add("Color");
    ViewBag.data = data;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        DataSource = DiagramContext.HierarchicalDetails.ToList(),
        SourceNode = "sourceNode",
        TargetNode = "targetNode"
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        DataSource = DiagramContext.HierarchicalDetails.ToList()
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        Id = "Id"
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        SourceNode = "sourceNode"
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        TargetNode = "targetNode"
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        SourcePointX = "200"
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        SourcePointY = "200"
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        TargetPointX ="100"
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        TargetPointY = "100"
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    CRUDAction crudAction = new CRUDAction()
    {
        Read = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/GetNodes"
    };

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        CrudAction = crudAction
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    CRUDAction crudAction = new CRUDAction()
    {
        Create = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/AddNodes"
    };

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        CrudAction = crudAction
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    CRUDAction crudAction = new CRUDAction()
    {
        Update = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/UpdateNodes"
    };

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        CrudAction = crudAction
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    CRUDAction crudAction = new CRUDAction()
    {
        Destroy = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/DeleteNodes"
    };

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        CrudAction = crudAction
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    CRUDAction crudAction = new CRUDAction()
    {
        Read = "http://js.Syncfusion.Com/demos/ejservices/api/Diagram/GetNodes"
    };

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        CrudAction = crudAction
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-datasource-settings connection-DataSource="@ViewBag.connectionDataSourceSettings">
        </e-datasource-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    List<string> customFields = new List<string>();
    customFields.Add("Description");
    customFields.Add("Color");

    ConnectionDataSourceSettings connectionDataSourceSettings = new ConnectionDataSourceSettings()
    {
        CustomFields = customFields
    };
    ViewBag.connectionDataSourceSettings = connectionDataSourceSettings;

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

    <ej-diagram>
        <e-default-settings>
            <e-node border-color="black"></e-node>
        </e-default-settings>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`GetNodeDefaults`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram getNodeDefaults="@ViewBag.getNodeDefaults"></ejs-diagram>

</code>
<code>

    function getNodeDefaults(obj, diagram) {
        obj.Shape = { type: 'Basic' };
    }

</code>
<b>[Model]</b>

<code>

    ViewBag.getNodeDefaults = getNodeDefaults;

</code></td>

</tr>

<tr>
<td><b>Initializes the default connector properties</b></td>
<td>
<b>Property</b>:<i>`DefaultSettings.Connector`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-default-settings>
            <e-connector constraints="Default &~ ConnectorConstraints.InheritTooltip"></e-connector>
        </e-default-settings>
    </ej-diagram>

</code>
</code>
</td>
<td>
<b>Property</b>:<i>`GetConnectorDefaults`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram getConnectorDefaults="@ViewBag.getConnectorDefaults"></ejs-diagram>

</code>
<code>

    function getConnectorDefaults(obj, diagram) {
        obj.Type = 'Bezier';
    }

</code>
<b>[Model]</b>

<code>

    ViewBag.getConnectorDefaults = getConnectorDefaults;

</code></td>

</tr>

<tr>
<td><b>Initializes the default properties of groups</b></td>
<td>
<b>Property</b>:<i>`DefaultSettings.Group`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-default-settings>
            <e-group border-color="red"></e-group>
        </e-default-settings>
    </ej-diagram>

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

    <ej-diagram create="@ViewBag.create"></ej-diagram>

</code>
<code>

    <script>
        function create(args) {
            var diagram = $("#diagram").ejDiagram("instance");
            diagram.model.drawType = { type: "node" };
        }
    </script>

</code>
<b>[Model]</b>
<code>

    ViewBag.create = "create";

</code>
</td>
<td>
<b>Property</b>:<i>`DrawingObject`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram created="@ViewBag.created"></ejs-diagram>

</code>
<code>

    function created() {
        diagram = document.getElementById("diagram").ej2_instances[0];
        diagram.drawingObject = { shape: { type: 'Basic', shape: 'Rectangle' } };
        diagram.dataBind();
    }

</code>
<b>[Model]</b>

<code>

    ViewBag.created = created;

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

    <ej-diagram enable-auto-scroll="true"></ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`CanAutoScroll`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-scrollsettings canAutoScroll="true"></e-diagram-scrollsettings>
    </ejs-diagram>

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

    <ej-diagram enable-context-menu="true"></ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`ContextMenuSettings.Show`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-contextmenusettings show="true"></e-diagram-contextmenusettings>
    </ejs-diagram>

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
<b>[View]</b>
<code>

    <ejs-diagram getCustomCursor="@ViewBag.getCustomCursor"></ejs-diagram>

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

</code>
<b>[Model]</b>

<code>

    ViewBag.getCustomCursor = "getCustomCursor";

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

    <ejs-diagram getCustomProperty="@ViewBag.getCustomProperty"></ejs-diagram>

</code>
<code>

    function getCustomProperty(key: string) {
        if (key === 'nodes') {
            return ['description'];
            }
        return null;
    }

</code>
<b>[Model]</b>

<code>

    ViewBag.getCustomProperty = "getCustomProperty";

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

    <ejs-diagram getCustomTool="@ViewBag.getTool"></ejs-diagram>

<code>
</code>

    function getTool(action) {
        var tool;
        if (action === 'userHandle') {
            tool = new CloneTool(diagram.CommandHandler, true);
        }
        return tool;
    }

</code>
<b>[Model]</b>

<code>

    ViewBag.getTool = "getTool";

    public class CloneTool extends ToolBase {
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

    <ej-diagram height="500px"></ej-diagram>

</code>
<code>
</td>
<td>
<b>Property</b>:<i>`Height`</i>
<br>
<br>
<code>

    <ejs-diagram height="500px"></ejs-diagram>

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
        var diagram = $("#diagram").ejDiagram("instance");
        var entry = { object: node, prevState: node.employeeData };
        diagram.model.historyManager.push(entry);
        var value = { role: "New role" };
        node.employeeData = value;
        if(diagram.model.historyManager.canPop(entry)){
            diagram.model.historyManager.pop();
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
        var diagram = $("#diagram").ejDiagram("instance");
        var group = diagram.model.selectedItems;
        diagram.model.historyManager.startGroupAction();
        for (var i = 0; i < group.children.length; i++) {
            var option = {};
            var item = group.children[i];
            // Updates the fillColor for all the child elements.
            option.fillColor = args.style.backgroundColor;
            diagram.UpdateNode(item.Name, option);
        }
        diagram.model.historyManager.closeGroupAction();
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
        objects.Push(diagram.nodes[0], diagram.nodes[1], diagram.Connectors[0]);
        diagram.historyList.startGroupAction();
        diagram.distribute('Top', objects);
        diagram.distribute('Bottom', objects);
        diagram.distribute('BottomToTop', objects);
        diagram.historyList.endGroupAction();
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
        diagram.model.historyManager.pop();
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
        var diagram = $("#diagram").ejDiagram("instance");
        var entry = { object: node, prevState: node.employeeData };
        diagram.model.historyManager.push(entry);
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
        var object = diagram.nodes[0];
        object['description'] = (document.getElementById('custom') as HTMLSelectElement).value;
        var entry = { undoObject: object };
        diagram.historyList.Push(entry);
        diagram.dataBind();
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

    <ej-diagram>
        <e-history-manager redo="@ViewBag.customUndoRedo"></e-history-manager>
    </ej-diagram>

</code>
<code>

    function customUndoRedo(args) {
        var diagram = $("#diagram").ejDiagram("instance");
        var node = args.object;
        var currentState = node.employeeData;
        node.employeeData = args.PrevState;
        args.PrevState = currentState;
    }

</code>
<b>[Model]</b>
<code>

    ViewBag.customUndoRedo = "customUndoRedo";

</code>
</td>
<td>
<b>Property</b>:<i>`HistoryList.Redo`</i>
<br>
<br>
<code>

    <script>
        var diagram = document.getElementById("container").ej2_instances[0];
        var node1 = diagram.nodes[0];
        node1['customName'] = 'customNode';
        entry = {
            undoObject: node1
        };
        diagram.historyList.push(entry);
        diagram.historyList.undo = function(args: HistoryEntry) {
            args.redoObject = cloneObject(args.undoObject) as NodeModel;
            args.undoObject['customName'] = 'customNodeChange';
        }
        diagram.historyList.redo = function(args: HistoryEntry) {
            var current = cloneObject(args.undoObject) as NodeModel;
            args.undoObject['customName'] = args.redoObject['customName'];
            args.redoObject = current;
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
        var diagram = $("#diagram").ejDiagram("instance");
        diagram.model.historyManager.redoStack();
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
        diagram.appendTo('#diagram');
        diagram.historyList.redoStack();
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
        var diagram = $("#diagram").ejDiagram("instance");
        diagram.model.historyManager.stackLimit();
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
        var diagram = $("#diagram").ejDiagram("instance");
        var group = diagram.model.selectedItems
        diagram.model.historyManager.startGroupAction();
        for (var i = 0; i < group.children.length; i++) {
            var option = {};
            var item = group.children[i];
            option.fillColor = args.style.backgroundColor;
            diagram.UpdateNode(item.Name, option);
        }
        diagram.model.historyManager.closeGroupAction();
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
        objects.Push(diagram.nodes[0], diagram.nodes[1], diagram.Connectors[0]);
        diagram.historyList.startGroupAction();
        diagram.distribute('Top', objects);
        diagram.distribute('Bottom', objects);
        diagram.distribute('BottomToTop', objects);
        diagram.historyList.endGroupAction();
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
<b>[View]</b>
<code>

    <ej-diagram>
        <e-history-manager undo="@ViewBag.customUndoRedo"></e-history-manager>
    </ej-diagram>

</code>
<code>

    <script>
        function customUndoRedo(args) {
            var diagram = $("#diagram").ejDiagram("instance");
            var node = args.Object;
            var currentState = node.employeeData;
            node.employeeData = args.PrevState;
            args.PrevState = currentState;
        }
    </script>

</code>
<b>[Model]</b>
<code>

    ViewBag.customUndoRedo = "customUndoRedo";

</code>
</td>
<td>
<b>Property</b>:<i>`HistoryList.Undo`</i>
<br>
<br>
<code>

    <script>
        var diagram = document.getElementById("container").ej2_instances[0];
        diagram.historyList.push(entry);
        diagram.historyList.undo = function(args: HistoryEntry) {
            args.redoObject = cloneObject(args.undoObject) as NodeModel;
            args.undoObject['customName'] = 'customNodeChange';
        }
        diagram.historyList.redo = function(args: HistoryEntry) {
            var current = cloneObject(args.undoObject) as NodeModel;
            args.undoObject['customName'] = args.redoObject['customName'];
            args.redoObject = current;
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
        var diagram = $("#diagram").ejDiagram("instance");
        diagram.model.historyManager.undoStack();
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
        diagram.historyList.undoStack();
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
        diagram.historyList.currentEntry();
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
        diagram.historyList.canUndo = true;
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
        diagram.historyList.canRedo = true;
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

    var diagram = $("#diagram").ejDiagram("instance");
    diagram.model.historyManager.canLog();

</code>
</td></td>
<td>
<b>Property</b>:<i>`HistoryList.CanLog`</i>
<br>
<br>
<code>

    <script>
        var diagram = document.getElementById("container").ej2_instances[0];
        diagram.historyList.canLog = function (entry: HistoryEntry) {
                entry.cancel = true;
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
<b>[View]</b>
<code>

    <ej-diagram>
        <e-layout bounds="@ViewBag.getBounds"></e-layout>
    </ej-diagram>

</code>
<code>

    <script>
        function getBounds() {
            var bounds = { X = 10, Y = 10, Width = 100, Height = 100 };
            return bounds;
        }
    </script>

</code>
<b>[Model]</b>

<code>

    ViewBag.getBounds = "getBounds";

</code></td>

<td>
<b>Property</b>:<i>`Layout.Bounds`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram>
        <e-diagram-layout bounds="@ViewBag.getBounds"></e-diagram-layout>
    </ejs-diagram>

</code>
<code>

    <script>
        function getBounds() {
            var bounds = { X = 10, Y = 10, Width = 100, Height = 100 };
            return bounds;
        }
    </script>

</code>
<b>[Model]</b>

<code>

    ViewBag.getBounds = "getBounds";

</code></td>

</tr>

<tr>
<td><b>Defines the fixed node with reference to which, the layout will be arranged and fixed node will not be repositioned</b></td>
<td>
<b>Property</b>:<i>`Layout.FixedNode`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-layout fixed-node="nodeName"></e-layout>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.FixedNode`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-layout fixedNode="nodeId"></e-diagram-layout>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Customizes the orientation of trees/sub trees</b></td>
<td>
<b>Property</b>:<i>`Layout.GetLayoutInfo`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-layout getLayoutInfo="@ViewBag.getLayoutInfo"></e-layout>
    </ej-diagram>

</code>
<code>

    <script>
        function getLayoutInfo(diagram, node, options) {
            options.Orientation = "vertical";
            options.Type = "left"; offset = 10;
        };
    </script>

</code>
<b>[Model]</b>

<code>

    ViewBag.getLayoutInfo = "getLayoutInfo";

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.GetLayoutInfo`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram>
        <e-diagram-layout getLayoutInfo="@ViewBag.getLayoutInfo"></e-diagram-layout>
    </ejs-diagram>

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
<b>[Model]</b>

<code>

    ViewBag.getLayoutInfo = "getLayoutInfo";

</code></td>

</tr>

<tr>
<td><b>Defines a method to customize the segments based on source and target nodes</b></td>
<td>
<b>Property</b>:<i>`Layout.GetConnectorSegments`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-layout getConnectorSegments="@ViewBag.getConnectorSegments"></e-layout>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    ViewBag.getConnectorSegments = "getConnectorSegments";

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.ConnectorSegments`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-layout connectorSegments="Default"></e-diagram-layout>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the space to be horizontally left between nodes</b></td>
<td>
<b>Property</b>:<i>`Layout.HorizontalSpacing`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-layout horizontal-spacing="50"></e-layout>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.HorizontalSpacing`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-layout horizontalSpacing="50"></e-diagram-layout>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the space to be left between layout bounds and layout</b></td>
<td>
<b>Property</b>:<i>`Layout.Margin`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-layout >
            <e-margin left="15" bottom="15" right="15" top="15"></e-margin>
        </e-layout>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.Margin`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-layout>
            <e-layout-margin bottom="15" left="15" right="15" top="15"></e-layout-margin>
        </e-diagram-layout>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines how to horizontally align the layout within the layout bounds</b></td>
<td>
<b>Property</b>:<i>`Layout.HorizontalAlignment`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-layout horizontal-alignment="Left"></e-layout>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.HorizontalAlignment`</i>
<br>
<br>
<code>
<code>

    <ejs-diagram>
        <e-diagram-layout horizontalAlignment="Left"></e-diagram-layout>
    </ejs-diagram>

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

    <ej-diagram>
        <e-layout vertical-alignment="Bottom"></e-layout>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.VerticalAlignment`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-layout verticalAlignment="Bottom"></e-diagram-layout>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the orientation/direction to arrange the diagram elements</b></td>
<td>
<b>Property</b>:<i>`Layout.Orientation`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-layout orientation="TopToBottom"></e-layout>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.Orientation`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-layout orientation="TopToBottom"></e-diagram-layout>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the type of the layout based on which the elements will be arranged</b></td>
<td>
<b>Property</b>:<i>`Layout.Type`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-layout type="OrganizationalChart"></e-layout>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.Type`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-layout type="OrganizationalChart"></e-diagram-layout>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the space to be vertically left between nodes</b></td>
<td>
<b>Property</b>:<i>`Layout.VerticalSpacing`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-layout vertical-spacing="50"></e-layout>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.VerticalSpacing`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-layout verticalSpacing="50"></e-diagram-layout>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the value is used to define the root node of the layout</b></td>
<td>
<b>Property</b>:<i>`Layout.Root`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-layout root="nodeName"></e-layout>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.Root`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-layout root="nodeId"></e-diagram-layout>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines how long edges should be, ideally. This will be the resting length for the springs</b></td>
<td>
<b>Property</b>:<i>`Layout.SpringFactor`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-layout spring-factor="0.4F"></e-layout>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.SpringFactor`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-layout springFactor="0.4"></e-diagram-layout>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines how long edges should be, ideally. This will be the resting length for the springs</b></td>
<td>
<b>Property</b>:<i>`Layout.MaxIteration`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-layout max-iteration="50"></e-layout>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.MaxIteration`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-layout maxIteration="50"></e-diagram-layout>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines how long edges should be, ideally. This will be the resting length for the springs</b></td>
<td>
<b>Property</b>:<i>`Layout.SpringLength`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-layout spring-length="80"></e-layout>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Layout.SpringLength`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-layout springLength="80"></e-diagram-layout>
    </ejs-diagram>

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

    <ejs-diagram>
        <e-diagram-layout connectionDirection="Auto"></e-diagram-layout>
    </ejs-diagram>

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

    <ejs-diagram>
        <e-diagram-layout enableAnimation="true"></e-diagram-layout>
    </ejs-diagram>

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
<b>[View]</b>
<code>

    <ejs-diagram>
        <e-diagram-layout getBranch="@ViewBag.getBranch"></e-diagram-layout>
    </ejs-diagram>

</code>
<code>

    function getBranch(node, nodes) {
        return node.Data.Branch;
    }

</code>
<b>[Model]</b>

<code>

    ViewBag.getBranch = "getBranch";

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

    <ej-diagram>
        <e-nodes>
            <e-node name="nodeName"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node id="nodeId"></e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the type of BPMN Activity. Applicable, if the node is a BPMN activity</b></td>
<td>
<b>Property</b>:<i>`Nodes.Activity`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node activity="SubProcess"></e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Activity`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-activity activity="SubProcess"></e-basicshape-activity>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>To maintain additional information about nodes</b></td>
<td>
<b>Property</b>:<i>`Nodes.AddInfo`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node addInfo="@ViewBag.addInfo"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    Dictionary<string, object> addInfo = new Dictionary<string, object>();
    addInfo.Add("Description", "Bidirectional Flow");
    ViewBag.addInfo = addInfo;

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.AddInfo`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node addInfo="@ViewBag.addInfo"></e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code>
<b>[Model]</b>
<code>

    Dictionary<string, object> addInfo = new Dictionary<string, object>();
    addInfo.Add("Description", "Bidirectional Flow");
    ViewBag.addInfo = addInfo;

</code></td>

</tr>

<tr>
<td><b>Defines the additional information of a process. It is not directly related to the message flows or sequence flows of the process</b></td>
<td>
<b>Property</b>:<i>`Nodes.Annotation`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node>
                <e-annotation text="text"></e-annotation>
            </e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Annotations`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-bpmnannotations>
                        <e-basicshape-bpmnannotation text="text"></e-basicshape-bpmnannotation>
                    </e-basicshape-bpmnannotations>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the angle between the BPMN shape and the annotation</b></td>
<td>
<b>Property</b>:<i>`Nodes.Annotation.Angle`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node>
                <e-annotation angle="-45"></e-annotation>
            </e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Annotations.Angle`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-bpmnannotations>
                        <e-basicshape-bpmnannotation angle="-45"></e-basicshape-bpmnannotation>
                    </e-basicshape-bpmnannotations>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the direction of the text annotation</b></td>
<td>
<b>Property</b>:<i>`Nodes.Annotation.Direction`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node>
                <e-annotation direction="Left"></e-annotation>
            </e-bpmn-node>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node>
                <e-annotation height="50"></e-annotation>
            </e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Annotation.Height`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-bpmnannotations>
                        <e-basicshape-bpmnannotation height="50"></e-basicshape-bpmnannotation>
                    </e-basicshape-bpmnannotations>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the distance between the BPMN shape and the annotation</b></td>
<td>
<b>Property</b>:<i>`Nodes.Annotation.Length`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node>
                <e-annotation length="150" width="50"></e-annotation>
            </e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Annotations.Length`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-bpmnannotations>
                        <e-basicshape-bpmnannotation length="150"></e-basicshape-bpmnannotation>
                    </e-basicshape-bpmnannotations>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the additional information about the flow object in a BPMN Process</b></td>
<td>
<b>Property</b>:<i>`Nodes.Annotation.Text`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node>
                <e-annotation text="text"></e-annotation>
            </e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Annotations.Text`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-bpmnannotations>
                        <e-basicshape-bpmnannotation text="text"></e-basicshape-bpmnannotation>
                    </e-basicshape-bpmnannotations>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the width of the text annotation</b></td>
<td>
<b>Property</b>:<i>`Nodes.Annotation.Width`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node>
                <e-annotation width="50"></e-annotation>
            </e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Annotations.Width`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-bpmnannotations>
                        <e-basicshape-bpmnannotation width="50"></e-basicshape-bpmnannotation>
                    </e-basicshape-bpmnannotations>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

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
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-bpmnannotations>
                        <e-basicshape-bpmnannotation id="annotationId"></e-basicshape-bpmnannotation>
                    </e-basicshape-bpmnannotations>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines whether the group can be ungrouped or not</b></td>
<td>
<b>Property</b>:<i>`Nodes.CanUngroup`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-group can-ungroup="false">
                <e-children>
                    <e-node name="node1"></e-node>
                    <e-node name="node2"></e-node>
                </e-children>
                <e-container orientation="Horizontal"></e-container>
            </e-group>
        </e-nodes>
    </ej-diagram>

</code></td>

<td>
<b>Not applicable</b>
</td>
</tr>

<tr>
<td><b>Sets the type of UML classifier</b></td>
<td>
<b>Property</b>:<i>`Nodes.Classifier`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Class"></e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Class">
                <e-class></e-class>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Class">
                <e-class name="name"></e-class>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Class">
                <e-class>
                    <e-attributes>
                        <e-attribute name="name"></e-attribute>
                    </e-attributes>
                </e-class>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Class">
                <e-class>
                    <e-attributes>
                        <e-attribute name="name"></e-attribute>
                    </e-attributes>
                </e-class>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Class">
                <e-class>
                    <e-attributes>
                        <e-attribute type="Data"></e-attribute>
                    </e-attributes>
                </e-class>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Class">
                <e-class>
                    <e-attributes>
                        <e-attribute scope="Protected"></e-attribute>
                    </e-attributes>
                </e-class>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Class">
                <e-class>
                    <e-methods>
                        <e-method name="name"></e-method>
                    </e-methods>
                </e-class>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Class">
                <e-class>
                    <e-methods>
                        <e-method name="name"></e-method>
                    </e-methods>
                </e-class>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Class">
                <e-class>
                    <e-methods>
                        <e-method parameters="@ViewBag.parameters"></e-method>
                    </e-methods>
                </e-class>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>
<code>

    Collection parameters = new Collection();
    parameters.Add(new UMLParameter() { Name = "name" });
    ViewBag.parameters = parameters;

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
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Class">
                <e-class>
                    <e-methods>
                        <e-method parameters="@ViewBag.parameters"></e-method>
                    </e-methods>
                </e-class>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>
<code>

    Collection parameters = new Collection();
    parameters.Add(new UMLParameter() { Name = "name" });
    ViewBag.parameters = parameters;

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
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Class">
                <e-class>
                    <e-methods>
                        <e-method parameters="@ViewBag.parameters"></e-method>
                    </e-methods>
                </e-class>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>
<code>

    Collection parameters = new Collection();
    parameters.Add(new UMLParameter() { Type = "String" });
    ViewBag.parameters = parameters;

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Class">
                <e-class>
                    <e-methods>
                        <e-method type="String"></e-method>
                    </e-methods>
                </e-class>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Class">
                <e-class>
                    <e-methods>
                        <e-method scope="Protected"></e-method>
                    </e-methods>
                </e-class>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node collapse-icon="@ViewBag.collapseIcon"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    DiagramIcon collapseIcon = new DiagramIcon()
    {
        Shape = IconShapes.ArrowDown
    };
    ViewBag.collapseIcon = collapseIcon;

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-collapseicon shape="ArrowUp"></e-node-collapseicon>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the border color for collapse icon of node</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.BorderColor`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node collapse-icon="@ViewBag.collapseIcon"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    DiagramIcon collapseIcon = new DiagramIcon()
    {
        BorderColor = "red"
    };
    ViewBag.collapseIcon = collapseIcon;

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.BorderColor`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-collapseicon borderColor="red"></e-node-collapseicon>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the border width for collapse icon of node</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.BorderWidth`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node collapse-icon="@ViewBag.collapseIcon"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    DiagramIcon collapseIcon = new DiagramIcon()
    {
        BorderWidth = 2
    };
    ViewBag.collapseIcon = collapseIcon;

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.BorderWidth`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-collapseicon borderWidth="2"></e-node-collapseicon>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the fill color for collapse icon of node</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.FillColor`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node collapse-icon="@ViewBag.collapseIcon"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    DiagramIcon collapseIcon = new DiagramIcon()
    {
        FillColor = "red"
    };
    ViewBag.collapseIcon = collapseIcon;

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Fill`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-collapseicon fill="red"></e-node-collapseicon>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the height for collapse icon of node</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Height`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node collapse-icon="@ViewBag.collapseIcon"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    DiagramIcon collapseIcon = new DiagramIcon()
    {
        Height = 10
    };
    ViewBag.collapseIcon = collapseIcon;

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Height`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-collapseicon height="10"></e-node-collapseicon>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the horizontal alignment of the icon</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.HorizontalAlignment`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node collapse-icon="@ViewBag.collapseIcon"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    DiagramIcon collapseIcon = new DiagramIcon()
    {
        HorizontalAlignment = HorizontalAlignment.Left
    };
    ViewBag.collapseIcon = collapseIcon;

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.HorizontalAlignment`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-collapseicon horizontalAlignment="Center"></e-node-collapseicon>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>To set the margin for the collapse icon of node</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Margin`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node collapse-icon="@ViewBag.collapseIcon"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    DiagramIcon collapseIcon = new DiagramIcon()
    {
        Margin = { Bottom = 15, Left = 15, Right = 15, Top = 15}
    };
    ViewBag.collapseIcon = collapseIcon;

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Margin`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-collapseicon>
                    <e-iconshape-margin bottom="10" left="10" right="10" top="10"></e-iconshape-margin>
                </e-node-collapseicon>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the fraction/ratio(relative to node) that defines the position of the icon</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Offset`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node collapse-icon="@ViewBag.collapseIcon"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    DiagramIcon collapseIcon = new DiagramIcon()
    {
        Offset = { X = 0.5F, Y = 0.5F }
    };
    ViewBag.collapseIcon = collapseIcon;

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Offset`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-collapseicon>
                    <e-iconshape-offset x="0" y="0.5F"></e-iconshape-offset>
                </e-node-collapseicon>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the shape of the collapsed state of the node</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Shape`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node collapse-icon="@ViewBag.collapseIcon"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    DiagramIcon collapseIcon = new DiagramIcon()
    {
        Shape = IconShapes.ArrowDown
    };
    ViewBag.collapseIcon = collapseIcon;

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.Shape`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-collapseicon horizontalAlignment="Center"></e-node-collapseicon>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the vertical alignment of the icon</b></td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.VerticalAlignment `</i>
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node collapse-icon="@ViewBag.collapseIcon"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    DiagramIcon collapseIcon = new DiagramIcon()
    {
        VerticalAlignment = VerticalAlignment.Top
    };
    ViewBag.collapseIcon = collapseIcon;

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.CollapseIcon.VerticalAlignment `</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-collapseicon verticalAlignment="Top"></e-node-collapseicon>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

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
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-collapseicon shape="Template" content="<g><path d='M90,43.841c0,24.213-19.779,43.841-44.182,43.841c-7.747,0-15.025-1.98-21.357-5.455L0,90l7.975-23.522" +
                "c-4.023-6.606-6.34-14.354-6.34-22.637C1.635,19.628,21.416,0,45.818,0C70.223,0,90,19.628,90,43.841z M45.818,6.982" +
                "c-20.484,0-37.146,16.535-37.146,36.859c0,8.065,2.629,15.534,7.076,21.61L11.107,79.14l14.275-4.537" +
                "c5.865,3.851,12.891,6.097,20.437,6.097c20.481,0,37.146-16.533,37.146-36.857S66.301,6.982,45.818,6.982z M68.129,53.938" +
                "c-0.273-0.447-0.994-0.717-2.076-1.254c-1.084-0.537-6.41-3.138-7.4-3.495c-0.993-0.358-1.717-0.538-2.438,0.537" +
                "c-0.721,1.076-2.797,3.495-3.43,4.212c-0.632,0.719-1.263,0.809-2.347,0.271c-1.082-0.537-4.571-1.673-8.708-5.333" +
                "c-3.219-2.848-5.393-6.364-6.025-7.441c-0.631-1.075-0.066-1.656,0.475-2.191c0.488-0.482,1.084-1.255,1.625-1.882" +
                "c0.543-0.628,0.723-1.075,1.082-1.793c0.363-0.717,0.182-1.344-0.09-1.883c-0.27-0.537-2.438-5.825-3.34-7.977" +
                "c-0.902-2.15-1.803-1.792-2.436-1.792c-0.631,0-1.354-0.09-2.076-0.09c-0.722,0-1.896,0.269-2.889,1.344" +
                "c-0.992,1.076-3.789,3.676-3.789,8.963c0,5.288,3.879,10.397,4.422,11.113c0.541,0.716,7.49,11.92,18.5,16.223" +
                "C58.2,65.771,58.2,64.336,60.186,64.156c1.984-0.179,6.406-2.599,7.312-5.107C68.398,56.537,68.398,54.386,68.129,53.938z'>"></e-node-collapseicon>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

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
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-collapseicon shape="Path" pathData = "M0,0 L0,100"></e-node-collapseicon>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

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
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-collapseicon cornerRadius="5"></e-node-collapseicon>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

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
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-collapseicon>
                    <e-iconshape-padding bottom="15" left="15" right="15" top="15"></e-iconshape-padding>
                </e-node-collapseicon>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the distance to be left between a node and its connections(In coming and out going connections)</b></td>
<td>
<b>Property</b>:<i>`Nodes.ConnectorPadding`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node connector-padding="5"></e-node>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node constraints="Default"></e-node>
        </e-nodes>
    </ej-diagram>

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Constraints`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node constraints="Default"></e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the orientation of the container. Applicable, if the group is a container</b></td>
<td>
<b>Property</b>:<i>`Nodes.Container.Orientation`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-group>
                <e-children>
                    <e-node name="node1"></e-node>
                    <e-node name="node2"></e-node>
                </e-children>
                <e-container orientation="Horizontal"></e-container>
            </e-group>
        </e-nodes>
    </ej-diagram>

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
<code>

    <ej-diagram>
        <e-nodes>
            <e-group>
                <e-children>
                    <e-node name="node1"></e-node>
                    <e-node name="node2"></e-node>
                </e-children>
                <e-container type="Canvas"></e-container>
            </e-group>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-basic-shape corner-radius="5"></e-basic-shape>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shapes.CornerRadius`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape cornerRadius="5"></e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code>
</tr>

<tr>
<td><b>This property allows you to customize nodes appearance using user-defined CSS</b></td>
<td>
<b>Property</b>:<i>`Nodes.CssClass`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node css-class="hoverNode"></e-node>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node>
                <e-data type="Input"></e-data>
            </e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.DataObject.Type`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-dataobject type="Input"></e-basicshape-dataobject>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines whether the BPMN data object is a collection or not</b></td>
<td>
<b>Property</b>:<i>`Nodes.Data.Collection`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node>
                <e-data collection="false"></e-data>
            </e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.DataObject.Collection`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-dataobject collection="false"></e-basicshape-dataobject>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines an Enumeration in a UML Class Diagram</b></td>
<td>
<b>Property</b>:<i>`Nodes.Enumeration`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Enumeration">
                <e-enumeration name="name"></e-enumeration>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Enumeration">
                <e-enumeration name="name"></e-enumeration>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Enumeration">
                <e-enumeration>
                    <e-members>
                        <e-member name="name"></e-member>
                    </e-members>
                </e-enumeration>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Enumeration">
                <e-enumeration>
                    <e-members>
                        <e-member name="name"></e-member>
                    </e-members>
                </e-enumeration>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node event="Intermediate"></e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Event`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-event event="Intermediate"></e-basicshape-event>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the type of the trigger</b></td>
<td>
<b>Property</b>:<i>`Nodes.Event.Trigger`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node shape="Event" trigger="None"></e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Event.Trigger`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-event event="Intermediate" trigger="None"></e-basicshape-event>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines whether the node can be automatically arranged using layout or not</b></td>
<td>
<b>Property</b>:<i>`Nodes.ExcludeFromLayout`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-layout type="HierarchicalTree"></e-layout>
        <e-nodes>
            <e-node name="node1" exclude-from-layout="true"></e-node>
            <e-node name="node2"></e-node>
            <e-node name="node3"></e-node>
        </e-nodes>
    </ej-diagram>

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.ExcludeFromLayout`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-layout type="HierarchicalTree"></e-diagram-layout>
        <e-diagram-nodes>
            <e-diagram-node id="node1" excludeFromLayout="true"></e-diagram-node>
            <e-diagram-node id="node2"></e-diagram-node>
            <e-diagram-node id="node3"></e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the fill color of the node</b></td>
<td>
<b>Property</b>:<i>`Nodes.FillColor`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node fill-color="red"></e-node>
        </e-nodes>
    </ej-diagram>

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Fill`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-style fill="red"></e-node-style>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the type of the BPMN Gateway. Applicable, if the node is a BPMN gateway</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gateway`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node shape="Gateway" gateway="Exclusive"></e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Gateway`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-gateway type="Exclusive"></e-basicshape-gateway>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the x1 value of linear gradient</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.LinearGradient.X1`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-linear-gradient x1="0"></e-linear-gradient>
            </e-node>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-linear-gradient x2="50"></e-linear-gradient>
            </e-node>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-linear-gradient y1="0"></e-linear-gradient>
            </e-node>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-linear-gradient y2="50"></e-linear-gradient>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Gradient.LinearGradient.Y2`</i>
<br>
<br>
</td>
</tr>

<tr>
<td><b>Defines the position of the outermost circle
</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.RadialGradient.Cx`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-radial-gradient cx="50"></e-radial-gradient>
            </e-node>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-radial-gradient cy="50"></e-radial-gradient>
            </e-node>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-radial-gradient fx="50"></e-radial-gradient>
            </e-node>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-radial-gradient fy="50"></e-radial-gradient>
            </e-node>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-radial-gradient>
                    <e-stops>
                        <e-stop color="white" offset="0"></e-stop>
                        <e-stop color="red" offset="50"></e-stop>
                    </e-stops>
                </e-radial-gradient>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.RadialGradient.Stops`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-style>
                    <e-textstyle-gradient type="Radial">
                        <e-gradient-stops>
                            <e-gradient-stop color="white" offset="0"></e-gradient-stop>
                            <e-gradient-stop color="red" offset="50"></e-gradient-stop>
                        </e-gradient-stops>
                    </e-textstyle-gradient>
                </e-node-style>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the color to be filled over the specified region</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.Stops.Color`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-radial-gradient>
                    <e-stops>
                        <e-stop color="white"></e-stop>
                    </e-stops>
                </e-radial-gradient>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Gradient.Stops.Color`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-style>
                    <e-textstyle-gradient type="Radial">
                        <e-gradient-stops>
                            <e-gradient-stop color="white"></e-gradient-stop>
                        </e-gradient-stops>
                    </e-textstyle-gradient>
                </e-node-style>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the position where the previous color transition ends and a new color transition starts</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.Stops.Offset`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-radial-gradient>
                    <e-stops>
                        <e-stop offset="0"></e-stop>
                    </e-stops>
                </e-radial-gradient>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Gradient.Stops.Offset`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-style>
                    <e-textstyle-gradient type="Radial">
                        <e-gradient-stops>
                            <e-gradient-stop offset="0"></e-gradient-stop>
                        </e-gradient-stops>
                    </e-textstyle-gradient>
                </e-node-style>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Describes the transparency level of the region</b></td>
<td>
<b>Property</b>:<i>`Nodes.Gradient.Stops.Opacity`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-radial-gradient>
                    <e-stops>
                        <e-stop opacity="0.5f"></e-stop>
                    </e-stops>
                </e-radial-gradient>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.Style.Gradient.Stops.Opacity`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-style>
                    <e-textstyle-gradient type="Radial">
                        <e-gradient-stops>
                            <e-gradient-stop opacity="0.5f"></e-gradient-stop>
                        </e-gradient-stops>
                    </e-textstyle-gradient>
                </e-node-style>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the header of a swimlane/lane</b></td>
<td>
<b>Property</b>:<i>`Nodes.Header`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-swim-lane>
                <e-swim-lane-header text="text"></e-swim-lane-header>
            </e-swim-lane>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node height="100"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Height`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node height="100"></e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the horizontal alignment of the node. Applicable, if the parent of the node is a container</b></td>
<td>
<b>Property</b>:<i>`Nodes.HorizontalAlign`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node horizontal-align="Left"></e-node>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Interface">
                <e-interface name="name"></e-interface>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Interface">
                <e-interface name="name"></e-interface>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Interface">
                <e-interface>
                    <e-attributes>
                        <e-attribute name="name"></e-attribute>
                    </e-attributes>
                </e-interface>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Interface">
                <e-interface>
                    <e-attributes>
                        <e-attribute name="name"></e-attribute>
                    </e-attributes>
                </e-interface>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Interface">
                <e-interface>
                    <e-attributes>
                        <e-attribute type="Data"></e-attribute>
                    </e-attributes>
                </e-interface>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Interface">
                <e-interface>
                    <e-attributes>
                        <e-attribute scope="Protected"></e-attribute>
                    </e-attributes>
                </e-interface>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Interface">
                <e-interface>
                    <e-methods>
                        <e-method name="name"></e-method>
                    </e-methods>
                </e-interface>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Interface">
                <e-interface>
                    <e-methods>
                        <e-method name="name"></e-method>
                    </e-methods>
                </e-interface>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Interface">
                <e-interface>
                    <e-methods>
                        <e-method parameters="@ViewBag.parameters"></e-method>
                    </e-methods>
                </e-interface>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>
<code>

    Collection parameters = new Collection();
    parameters.Add(new UMLParameter() { Name = "Date", Type = "String" });
    ViewBag.parameters = parameters;

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
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Interface">
                <e-interface>
                    <e-methods>
                        <e-method parameters="@ViewBag.parameters"></e-method>
                    </e-methods>
                </e-interface>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>
<code>

    Collection parameters = new Collection();
    parameters.Add(new UMLParameter() { Name = "Date" });
    ViewBag.parameters = parameters;

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
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Interface">
                <e-interface>
                    <e-methods>
                        <e-method parameters="@ViewBag.parameters"></e-method>
                    </e-methods>
                </e-interface>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>
<code>

    Collection parameters = new Collection();
    parameters.Add(new UMLParameter() { Type = "String" });
    ViewBag.parameters = parameters;

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Interface">
                <e-interface>
                    <e-methods>
                        <e-method type="String">
                        </e-method>
                    </e-methods>
                </e-interface>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-uml-classifier classifier="Interface">
                <e-interface>
                    <e-methods>
                        <e-method scope="Protected">
                        </e-method>
                    </e-methods>
                </e-interface>
            </e-uml-classifier>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node is-expanded="true"></e-node>
        </e-nodes>
    </ej-diagram>

</code>

</td>
<td>
<b>Property</b>:<i>`Nodes.IsExpanded`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node isExpanded="true"></e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the node as a swimlane</b></td>
<td>
<b>Property</b>:<i>`Nodes.IsSwimlane`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-swim-lane is-swimlane="true"></e-swim-lane>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label text="text" ></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Annotations`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation content="annotation"></e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>An array of objects where each object represents a lane. Applicable, if the node is a swimlane</b></td>
<td>
<b>Property</b>:<i>`Nodes.Lanes`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-swim-lane>
                <e-lanes>
                    <e-lane name="lane1"></e-lane>
                    <e-lane name="lane2"></e-lane>
                </e-lanes>
            </e-swim-lane>
        </e-nodes>
    </ej-diagram>

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
<code>

    <ej-diagram>
        <e-nodes>
            <e-swim-lane>
                <e-lanes>
                    <e-lane css-class="hoverLane"></e-lane>
                </e-lanes>
            </e-swim-lane>
        </e-nodes>
    </ej-diagram>

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
<code>

    <ej-diagram>
        <e-nodes>
            <e-swim-lane>
                <e-lanes>
                    <e-lane>
                        <e-lane-header text="text"></e-lane-header>
                    </e-lane>
                </e-lanes>
            </e-swim-lane>
        </e-nodes>
    </ej-diagram>

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
<code>

    <ej-diagram>
        <e-nodes>
            <e-swim-lane>
                <e-lanes>
                    <e-lane width="200"></e-lane>
                </e-lanes>
            </e-swim-lane>
        </e-nodes>
    </ej-diagram>

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
<code>

    <ej-diagram>
        <e-nodes>
            <e-swim-lane>
                <e-lanes>
                    <e-lane>
                        <e-children name="process"></e-children>
                    </e-lane>
                </e-lanes>
            </e-swim-lane>
        </e-nodes>
    </ej-diagram>

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
<code>

    <ej-diagram>
        <e-nodes>
            <e-swim-lane>
                <e-lanes>
                    <e-lane is-lane="true"></e-lane>
                </e-lanes>
            </e-swim-lane>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node margin-bottom="15" margin-left="15" margin-right="15" margin-top="15"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Margin`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-margin bottom="15" left="15" right="15" top="15"></e-node-margin>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the maximum height limit of the node</b></td>
<td>
<b>Property</b>:<i>`Nodes.MaxHeight`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node max-height="200"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.MaxHeight`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node maxHeight="200"></e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the unique identifier of the node</b></td>
<td>
<b>Property</b>:<i>`Nodes.Name`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node name="nodeName"></e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Id`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node id="nodeId"></e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the path geometry that defines the shape of a path node</b></td>
<td>
<b>Property</b>:<i>`Nodes.PathData`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-basic-shape shape="Path" path-data="M 370.9702,194.9961 L 359.5112,159.7291 L 389.5112,137.9341 L 419.5112,159.7291 L 408.0522,194.9961 L 370.9702,194.9961 z"></e-basic-shape>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Data`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Path"></e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>An array of objects, where each object represents a smaller region(phase) of a swimlane</b></td>
<td>
<b>Property</b>:<i>`Nodes.Phases`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-swim-lane>
                <e-phases>
                    <e-phase name="phase1"></e-phase>
                </e-phases>
            </e-swim-lane>
        </e-nodes>
    </ej-diagram>

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
<code>

    <ej-diagram>
        <e-nodes>
            <e-swim-lane>
                <e-phases>
                    <e-phase>
                        <e-label name="name"></e-label>
                    </e-phase>
                </e-phases>
            </e-swim-lane>
        </e-nodes>
    </ej-diagram>

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
<code>

    <ej-diagram>
        <e-nodes>
            <e-swim-lane>
                <e-phases>
                    <e-phase line-color="red"></e-phase>
                </e-phases>
            </e-swim-lane>
        </e-nodes>
    </ej-diagram>

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
<code>

    <ej-diagram>
        <e-nodes>
            <e-swim-lane>
                <e-phases>
                    <e-phase offset="150"></e-phase>
                </e-phases>
            </e-swim-lane>
        </e-nodes>
    </ej-diagram>

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
<code>

    <ej-diagram>
        <e-nodes>
            <e-swim-lane>
                <e-phases>
                    <e-phase orientation="Horizontal"></e-phase>
                </e-phases>
            </e-swim-lane>
        </e-nodes>
    </ej-diagram>

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
<code>

    <ej-diagram>
        <e-nodes>
            <e-swim-lane phase-size="150"></e-swim-lane>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-pivot x="0" y="0"></e-pivot>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Pivot`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-pivot x="0" y="0"></e-node-pivot>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines a collection of points to draw a polygon. Applicable, if the shape is a polygon</b></td>
<td>
<b>Property</b>:<i>`Nodes.Points`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-basic-shape shape="Polygon">
                <e-points>
                    <e-shape-point x="0" y="12.5F"></e-shape-point>
                    <e-shape-point x="0" y="50"></e-shape-point>
                    <e-shape-point x="50" y="50"></e-shape-point>
                    <e-shape-point x="50" y="0"></e-shape-point>
                    <e-shape-point x="12.5F" y="0"></e-shape-point>
                    <e-shape-point x="0" y="12.5F"></e-shape-point>
                </e-points>
            </e-basic-shape>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Points`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape shape="Polygon">
                    <e-basicshape-polygonpoints>
                        <e-basicshape-point x="0" y="12.5"></e-basicshape-point>
                        <e-basicshape-point x="0" y="50"></e-basicshape-point>
                        <e-basicshape-point x="50" y="50"></e-basicshape-point>
                        <e-basicshape-point x="50" y="0"></e-basicshape-point>
                        <e-basicshape-point x="12.5" y="0"></e-basicshape-point>
                        <e-basicshape-point x="0" y="12.5"></e-basicshape-point>
                    </e-basicshape-polygonpoints>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>An array of objects where each object represents a port</b></td>
<td>
<b>Property</b>:<i>`Nodes.Ports`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-ports>
                    <e-port name="portName"></e-port>
                </e-ports>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Ports`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-ports>
                    <e-node-port id="portId"></e-node-port>
                </e-node-ports>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the border color of the port</b></td>
<td>
<b>Property</b>:<i>`Nodes.Ports.BorderColor`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-ports>
                    <e-port border-color="red"></e-port>
                </e-ports>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Ports.Style.StrokeColor`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-ports>
                    <e-node-port>
                        <e-pointport-style strokeColor="red"></e-pointport-style>
                    </e-node-port>
                </e-node-ports>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-ports>
                    <e-port constraints="ConnectOnDrag"></e-port>
                </e-ports>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Ports.Constraints`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-ports>
                    <e-node-port  constraints="Draw"></e-node-port>
                </e-node-ports>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>An array of objects where each object represents a port</b></td>
<td>
<b>Property</b>:<i>`Nodes.Ports.Shape`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-ports>
                    <e-port shape="Square"></e-port>
                </e-ports>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Ports.Shape`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-ports>
                    <e-node-port shape="Square"></e-node-port>
                </e-node-ports>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

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
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-ports>
                    <e-node-port id="portId" constraints="Draw" shape="Square" verticalAlignment="Top"></e-node-port>
                </e-node-ports>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the opacity and the position of shadow</b></td>
<td>
<b>Property</b>:<i>`Nodes.Shadow`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-shadow opacity="0.5F"></e-shadow>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shadow`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shadow opacity="0.5"></e-node-shadow>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the sub process of a BPMN Activity. Applicable, if the type of the BPMN activity is sub process</b></td>
<td>
<b>Property</b>:<i>`Nodes.SubProcess`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node shape="Activity" activity="SubProcess"></e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Activity.SubProcess`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-activity activity="SubProcess"></e-basicshape-activity>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the collection of events that need to be appended with BPMN Sub-Process</b></td>
<td>
<b>Property</b>:<i>`Nodes.SubProcess.Events`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node shape="Activity" activity="SubProcess">
                <e-subProcess type="Event">
                    <e-events>
                        <e-event name="eventName"></e-event>
                    </e-events>
                </e-subProcess>
            </e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Activity.SubProcess.Events`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-activity activity="SubProcess">
                        <e-bpmnactivity-subprocess type="Event">
                            <e-bpmnsubprocess-bpmnsubevents>
                                <e-bpmnsubprocess-bpmnsubevent id="eventId"></e-bpmnsubprocess-bpmnsubevent>
                            </e-bpmnsubprocess-bpmnsubevents>
                        </e-bpmnactivity-subprocess>
                    </e-basicshape-activity>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>An array of objects where each object represents a port</b></td>
<td>
<b>Property</b>:<i>`Nodes.SubProcess.Events.Ports`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node activity="SubProcess">
                <e-subProcess events="@ViewBag.events">
                </e-subProcess>
            </e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>
<code>

    Collection labels = new Collection();
    labels.Add(new Label() { Name = "labelName" });
    Collection ports = new Collection();
    ports.Add(new Port() { Name = "portName" });
    Collection events = new Collection();
    events.Add(new BPMNEvent() { Ports = ports });
    ViewBag.events = events;

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Activity.SubProcess.Events.Ports`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-activity activity="SubProcess">
                        <e-bpmnactivity-subprocess type="Event">
                            <e-bpmnsubprocess-bpmnsubevents>
                                <e-bpmnsubprocess-bpmnsubevent id="eventId">
                                    <e-bpmnsubevent-ports>
                                        <e-bpmnsubevent-port id="portId"></e-bpmnsubevent-port>
                                    </e-bpmnsubevent-ports>
                                </e-bpmnsubprocess-bpmnsubevent>
                            </e-bpmnsubprocess-bpmnsubevents>
                        </e-bpmnactivity-subprocess>
                    </e-basicshape-activity>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>A collection of objects where each object represents a label</b></td>
<td>
<b>Property</b>:<i>`Nodes.SubProcess.Events.Labels`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node activity="SubProcess">
                <e-subProcess events="@ViewBag.events">
                </e-subProcess>
            </e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
<b>[Model]</b>
<code>

    Collection labels = new Collection();
    labels.Add(new Label() { Name = "labelName" });
    Collection events = new Collection();
    events.Add(new BPMNEvent() { Labels = labels });
    ViewBag.events = events;

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Activity.SubProcess.Events.Annotations`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-activity activity="SubProcess">
                        <e-bpmnactivity-subprocess type="Event">
                            <e-bpmnsubprocess-bpmnsubevents>
                                <e-bpmnsubprocess-bpmnsubevent id="eventId">
                                    <e-bpmnsubevent-nodeannotations>
                                        <e-bpmnsubevent-nodeannotation content="text"></e-bpmnsubevent-nodeannotation>
                                    </e-bpmnsubevent-nodeannotations>
                                </e-bpmnsubprocess-bpmnsubevent>
                            </e-bpmnsubprocess-bpmnsubevents>
                        </e-bpmnactivity-subprocess>
                    </e-basicshape-activity>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the task of the BPMN activity. Applicable, if the type of activity is set as task</b></td>
<td>
<b>Property</b>:<i>`Nodes.Task`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-bpmn-node shape="Activity" activity="Task">
                <e-task type="Service"></e-task>
            </e-bpmn-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Nodes.Shape.Activity.Task`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-shape type="Bpmn">
                    <e-basicshape-activity activity="Task">
                        <e-bpmnactivity-task type="Service"></e-bpmnactivity-task>
                    </e-basicshape-activity>
                </e-node-shape>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

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
<b>[View]</b>
<code>

    <ej-diagram node-template="@ViewBag.nodeTemplate"></ej-diagram>

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
<b>[Model]</b>
<code>

    ViewBag.nodeTemplate = nodeTemplate;

</code></td>

<td>
<b>Property</b>:<i>`SetNodeTemplate`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram setNodeTemplate="@ViewBag.setNodeTemplate"></ejs-diagram>

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

</code>
<b>[Model]</b>
<code>

    ViewBag.setNodeTemplate = "setNodeTemplate";

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
<code>

    <ej-diagram>
        <e-diagram-layers>
            <e-diagram-layer name="name"></e-diagram-layer>
        </e-diagram-layers>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Layers`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-layers>
            <e-diagram-layer id="layerId"></e-diagram-layer>
        </e-diagram-layers>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>A collection of JSON objects where each object represents a layer. Layer is a named category of diagram shapes</b></td>
<td>
<b>Property</b>:<i>`Layers.Print`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-diagram-layers>
            <e-diagram-layer print="true"></e-diagram-layer>
        </e-diagram-layers>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label text="text"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Content`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation content="content"></e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Offset for annotation content</b></td>
<td>
<b>Property</b>:<i>`Labels.Offset`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label>
                        <e-offset x="0.5F" y="0.5F"></e-offset>
                    </e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Offset`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation>
                        <e-shapeannotation-offset x="0.5" y="0.5"></e-shapeannotation-offset>
                    </e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the hyperlink for the labels</b></td>
<td>
<b>Property</b>:<i>`Labels.HyperLink`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label text="Syncfusion" hyperlink="https://www.Syncfusion.Com"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Hyperlink`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation content="Syncfusion" hyperlink="https://www.Syncfusion.Com"></e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Enables/disables the bold style</b></td>
<td>
<b>Property</b>:<i>`Labels.Bold`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label bold="true"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Style.Bold`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation>
                        <e-shapeannotation-style bold="true"></e-shapeannotation-style>
                    </e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the border color of the label</b></td>
<td>
<b>Property</b>:<i>`Labels.BorderColor`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label border-color="red"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Style.StrokeColor`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation>
                        <e-shapeannotation-style strokeColor="red"></e-shapeannotation-style>
                    </e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the border width of the label</b></td>
<td>
<b>Property</b>:<i>`Labels.BorderWidth`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label border-width="2"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Style.StrokeWidth`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation>
                        <e-shapeannotation-style strokeWidth="2"></e-shapeannotation-style>
                    </e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>This property allows you to customize labels appearance using user-defined CSS</b></td>
<td>
<b>Property</b>:<i>`Labels.CssClass`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label css-class="hoverText"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label constraints="Resizable"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Constraints`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation constraints="ReadOnly"></e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the fill color of the text area</b></td>
<td>
<b>Property</b>:<i>`Labels.FillColor`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label fill-color="white"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Style.Fill`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation>
                        <e-shapeannotation-style fill="white"></e-shapeannotation-style>
                    </e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the font color of the text</b></td>
<td>
<b>Property</b>:<i>`Labels.FontColor`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label font-color="black"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Style.Color`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation>
                        <e-shapeannotation-style color="black"></e-shapeannotation-style>
                    </e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the font family of the text</b></td>
<td>
<b>Property</b>:<i>`Labels.FontFamily`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label font-family="seugoe UI"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Style.FontFamily`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation>
                        <e-shapeannotation-style fontFamily="seugoe UI"></e-shapeannotation-style>
                    </e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the height of the label</b></td>
<td>
<b>Property</b>:<i>`Labels.Height`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label height="20"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Height`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation height="20"></e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the horizontal alignment of the label</b></td>
<td>
<b>Property</b>:<i>`Labels.HorizontalAlignment`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label horizontal-alignment="Left"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.HorizontalAlignment`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation horizontalAlignment="Left"></e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>To set the margin of the label</b></td>
<td>
<b>Property</b>:<i>`Labels.Margin`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label>
                        <e-margin bottom="15" left="15" right="15" top="15"></e-margin>
                    </e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Margin`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation>
                        <e-shapeannotation-margin bottom="15" left="15" right="15" top="15"></e-shapeannotation-margin>
                    </e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines whether the label is editable or not</b></td>
<td>
<b>Property</b>:<i>`Labels.ReadOnly`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label read-only="true"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Constraints`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation constraints="ReadOnly"></e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

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
            <circle cx="10" cy="6" r="5" style="stroke:#006600; fill:#00cc00" />
        </svg>
    </script>

</code>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label template-id="SvgEllipse"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label text-align="Left"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Style.TextAlign`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation>
                        <e-shapeannotation-style textAlign="left"></e-shapeannotation-style>
                    </e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Enables or disables the visibility of the label</b></td>
<td>
<b>Property</b>:<i>`Labels.Visible`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label visible="true"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Annotations.Visibility`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-nodes>
            <e-diagram-node>
                <e-node-nodeannotations>
                    <e-node-nodeannotation visibility="false"></e-node-nodeannotation>
                </e-node-nodeannotations>
            </e-diagram-node>
        </e-diagram-nodes>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Gets whether the label is currently being edited or not</b></td>
<td>
<b>Property</b>:<i>`Labels.Mode`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-nodes>
            <e-node>
                <e-labels>
                    <e-diagram-label mode="View"></e-diagram-label>
                </e-labels>
            </e-node>
        </e-nodes>
    </ej-diagram>

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

    <ej-diagram>
        <e-page-settings>
            <e-auto-scroll-border bottom="50" left="50" right="50" top="50"></e-auto-scroll-border>
        </e-page-settings>
    </ej-diagram>

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

    <ej-diagram>
        <e-page-settings multiple-page="true"></e-page-settings>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`PageSettings.MultiplePage`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-pagesettings multiplePage="false"></e-diagram-pagesettings>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the background color of diagram pages</b></td>
<td>
<b>Property</b>:<i>`PageSettings.PageBackgroundColor`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-page-settings page-background-color="grey"></e-page-settings>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`PageSettings.Background.Color`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-pagesettings >
            <e-pagesettings-background color="grey"></e-pagesettings-background>
        </e-diagram-pagesettings>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the scrollable area of diagram. Applicable, if the scroll limit is “limited”</b></td>
<td>
<b>Property</b>:<i>`PageSettings.scrollableArea`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-page-settings>
            <e-scrollable-area height="300" width="300" x="0" y="0"></e-scrollable-area>
        </e-page-settings>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`ScrollSettings.ScrollableArea`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram>
        <e-diagram-scrollsettings scrollableArea="@ViewBag.getScrollableArea"></e-diagram-scrollsettings>
    </ejs-diagram>

</code>
<code>

    <script>
        function getScrollableArea() {
            var scrollableArea = { X = 0, Y = 0, Width = 300, Height = 300 };
            return scrollableArea;
        }
    </script>

</code>
<b>[Model]</b>
<code>

    ViewBag.getScrollableArea = "getScrollableArea";

</code></td>

</tr>

<tr>
<td><b>Defines the draggable region of diagram elements</b></td>
<td>
<b>Property</b>:<i>`PageSettings.BoundaryConstraints`</i>
<br>
<br>

<code>

    <ej-diagram>
        <e-page-settings boundary-constraints="Diagram"></e-page-settings>
    </ej-diagram>

</code>
<td>
<b>Property</b>:<i>`PageSettings.BoundaryConstraints`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-pagesettings boundaryConstraints="Diagram"></e-diagram-pagesettings>
    </ejs-diagram>

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
<code>

    <ej-diagram>
        <e-scroll-settings horizontal-offset="300"></e-scroll-settings>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`ScrollSettings.HorizontalOffset`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-scrollsettings horizontalOffset="300"></e-diagram-scrollsettings>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Allows to extend the scrollable region that is based on the scroll limit</b></td>
<td>
<b>Property</b>:<i>`ScrollSettings.Padding`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-scroll-settings>
            <e-padding bottom="15" left="15" right="15" top="15"></e-padding>
        </e-scroll-settings>
    </ej-diagram>

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

    <ejs-diagram>
        <e-diagram-scrollsettings maxZoom="5"></e-diagram-scrollsettings>
    </ejs-diagram>

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

    <ejs-diagram>
        <e-diagram-scrollsettings canAutoScroll="true"></e-diagram-scrollsettings>
    </ejs-diagram>

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
<b>[View]</b>
<code>

    <ejs-diagram>
        <e-diagram-scrollsettings scrollableArea="@ViewBag.getScrollableArea"></e-diagram-scrollsettings>
    </ejs-diagram>

</code>
<code>

    <script>
        function getScrollableArea() {
            var scrollableArea = { X = 0, Y = 0, Width = 300, Height = 300 };
            return scrollableArea;
        }
    </script>

</code>
<b>[Model]</b>
<code>

    ViewBag.getScrollableArea = "getScrollableArea";

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

    <ej-diagram>
        <e-snap-settings enable-snap-to-object="true"></e-snap-settings>
    </ej-diagram>

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
<b>[View]</b>
<code>

    <ej-diagram>
        <e-snap-settings horizontal-gridlines="@ViewBag.gridLines"></e-snap-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    List<decimal> lineInterval = new List<decimal>();
    lineInterval.Add(1);
    lineInterval.Add(14);
    lineInterval.Add(0.5m);
    lineInterval.Add(14.5m);
    GridLines gridLines = new GridLines()
    {
        LinesInterval = lineInterval
    };
    ViewBag.gridLines = gridLines;

</code>
</td>
<td>
<b>Property</b>:<i>`SnapSettings.HorizontalGridlines`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram>
        <e-diagram-snapsettings horizontalGridlines="@ViewBag.gridLines"></e-diagram-snapsettings>
    </ejs-diagram>

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
<b>[View]</b>
<code>

    <ej-diagram>
        <e-snap-settings vertical-gridlines="@ViewBag.gridLines"></e-snap-settings>
    </ej-diagram>

</code>
<b>[Model]</b>

<code>

    List<decimal> lineInterval = new List<decimal>();
    lineInterval.Add(1);
    lineInterval.Add(14);
    lineInterval.Add(0.5m);
    lineInterval.Add(14.5m);
    GridLines gridLines = new GridLines()
    {
        LinesInterval = lineInterval
    };
    ViewBag.gridLines = gridLines;

</code>
</td>
<td>
<b>Property</b>:<i>`SnapSettings.VerticalGridLines`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram>
        <e-diagram-snapsettings verticalGridlines="@ViewBag.gridLines"></e-diagram-snapsettings>
    </ejs-diagram>

</code>
<b>[Model]</b>
<code>

    double[] lineInterval = { 0.95, 9.05, 0.2, 9.75 };
    DiagramGridlines gridlines = new DiagramGridlines()
    {
        LineIntervals = lineInterval
    };
    ViewBag.lineInterval = lineInterval;

</code></td>

</tr>

<tr>
<td><b>Defines the angle by which the object needs to be snapped</b></td>
<td>
<b>Property</b>:<i>`SnapSettings.SnapAngle`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-snap-settings snap-angle="5"></e-snap-settings>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`SnapSettings.SnapAngle`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-snapsettings snapAngle="5"></e-diagram-snapsettings>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the minimum distance between the selected object and the nearest object</b></td>
<td>
<b>Property</b>:<i>`SnapSettings.SnapObjectDistance`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-snap-settings snap-object-distance="5"></e-snap-settings>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`SnapSettings.SnapObjectDistance`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-snapsettings snapObjectDistance="5"></e-diagram-snapsettings>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines and sets the snapConstraints</b></td>
<td>
<b>Property</b>:<i>`SnapSettings.SnapConstraints`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-snap-settings snap-constraints="ShowLines"></e-snap-settings>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`SnapSettings.Constraints`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-snapsettings constraints="ShowLines"></e-diagram-snapsettings>
    </ejs-diagram>

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

    <ej-diagram zoom-factor="1"></ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`ZoomFactor`</i>
<br>
<br>
<b>[View]</b>
<code>

    <ejs-diagram created="@ViewBag.created"></ejs-diagram>

</code>
<code>

    function created() {
        diagram = document.getElementById("diagram").ej2_instances[0];
        var zoomIn = { type: 'ZoomIn', zoomFactor: 0.5 };
        diagram.ZoomTo(zoomIn);
    }

</code>
<b>[Model]</b>

<code>

    ViewBag.created = created;

</code></td>

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

    <ej-diagram tool="ZoomPan"></ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Tool`</i>
<br>
<br>
<code>

    <ejs-diagram tool="ZoomPan"></ejs-diagram>

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

    <ej-diagram show-tooltip="true"></ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Constraints`</i>
<br>
<br>
<code>

    <ejs-diagram constraints="Tooltip"></ejs-diagram>

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

    var diagram = $("#diagram").ejDiagram("instance");
    for(var i =0; i< diagram.model.selectedItems.children.length; i++){
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

    <ej-diagram>
        <e-selected-items constraints="UserHandles"></e-selected-items>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`SelectedItems.Constraints`</i>
<br>
<br>
<code>

    <ejs-diagram>
        <e-diagram-selecteditems constraints="UserHandle"></e-diagram-selecteditems>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Sets the angle to rotate the selected items</b></td>
<td>
<b>Property</b>:<i>`SelectedItems.Tooltip`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-selected-items>
            <e-tooltip>
                <e-alignment horizontal="Left" vertical="Top"></e-alignment>
            </e-tooltip>
        </e-selected-items>
    </ej-diagram>

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
<code>

    <ejs-diagram>
        <e-diagram-selecteditems>
            <e-selector-userhandles>
                <e-selector-userhandle name="clone" pathData="M 60.3,18 H 27.5 c -3,0-5.5,2.4-5.5,5.5 v 38.2 h 5.5 V 23.5 h 32.7 V 18 z M 68.5,28.9 h -30 c -3,0-5.5,2.4-5.5,5.5 v 38.2 c 0,3,2.4,5.5,5.5,5.5 h 30 c 3,0,5.5-2.4,5.5-5.5 V 34.4 C 73.9,31.4,71.5,28.9,68.5,28.9 z M 68.5,72.5 h -30 V 34.4 h 30 V 72.5 z"></e-selector-userhandle>
            </e-selector-userhandles>
        </e-diagram-selecteditems>
    </ejs-diagram>

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
<code>

    <ejs-diagram>
        <e-diagram-selecteditems>
            <e-selector-userhandles>
                <e-selector-userhandle horizontalAlignment="Left"></e-selector-userhandle>
            </e-selector-userhandles>
        </e-diagram-selecteditems>
    </ejs-diagram>

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
<code>

    <ejs-diagram>
        <e-diagram-selecteditems>
            <e-selector-userhandles>
                <e-selector-userhandle displacement="30"></e-selector-userhandle>
            </e-selector-userhandles>
        </e-diagram-selecteditems>
    </ejs-diagram>

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

    <ejs-diagram serializationSettings="@ViewBag.serializationSettings"></ejs-diagram>

</code>
<b>[Model]</b>
<code>

    SerializationSettings serializationSettings = new SerializationSettings()
    {
        PreventDefaultValues = true
    };
    ViewBag.serializationSettings = serializationSettings;

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
            <span style="padding: 5px;"></span>
        </div>
    </script>

</code>
<code>

    <ej-diagram>
        <e-tooltip template-id="mouseovertooltip"></e-tooltip>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Tooltip`</i>
<br>
<br>
<code>

    <ejs-diagram constraints="Tooltip">
        <e-diagram-tooltip content="diagram"></e-diagram-tooltip>
    </ejs-diagram>

</code></td>

</tr>

<tr>
<td><b>Defines the alignment of tooltip</b></td>
<td>
<b>Property</b>:<i>`Tooltip.Alignment`</i>
<br>
<br>
<code>

    <ej-diagram>
        <e-tooltip>
            <e-alignment horizontal="Left"></e-alignment>
        </e-tooltip>
    </ej-diagram>

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

    <ej-diagram>
        <e-tooltip>
            <e-margin bottom="15" left="15" right="15" top="15"></e-margin>
        </e-tooltip>
    </ej-diagram>

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

    <ej-diagram>
        <e-tooltip template-id="mouseovertooltip"></e-tooltip>
    </ej-diagram>

</code>
</td>
<td>
<b>Property</b>:<i>`Tooltip.Content`</i>
<br>
<br>
<code>

    <ejs-diagram constraints="Tooltip">
        <e-diagram-tooltip content="diagram"></e-diagram-tooltip>
    </ejs-diagram>

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

    <ejs-diagram constraints="Tooltip">
        <e-diagram-tooltip showTipPointer="true"></e-diagram-tooltip>
    </ejs-diagram>

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

    <ejs-diagram constraints="Tooltip">
        <e-diagram-tooltip position="TopLeft"></e-diagram-tooltip>
    </ejs-diagram>

</code></td>

</tr>
</table>
