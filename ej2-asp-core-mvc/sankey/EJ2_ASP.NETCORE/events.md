<!-- Converted from: sankey/EJ2_ASP.MVC/events.md -->

---
layout: post
title: Events in ##Platform_Name## Sankey Chart Component
description: Learn here all about Events in Syncfusion ##Platform_Name## Sankey Chart component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Events
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in React Sankey Chart component

The Sankey Chart provides comprehensive events that allow you to customize behavior, respond to user interactions, and hook into the chart lifecycle. These events enable advanced customization scenarios including data transformation, analytics tracking, and dynamic UI updates.

This guide covers lifecycle events, rendering events, interaction events, and export/print events.

## Event List

| Event | Description |
|-------|-------------|
| load | Triggers before the Sankey loads. Allows customization before rendering. |
| loaded | Triggers after the Sankey is fully loaded and rendered. |
| legendItemRendering | Triggers before a legend item is rendered. Allows customization of legend items. |
| labelRendering | Triggers before a label is rendered. Allows customization of label text and style. |
| nodeRendering | Triggers before a node is rendered. Allows customization of node appearance. |
| linkRendering | Triggers before a link is rendered. Allows customization of link appearance. |
| tooltipRendering | Triggers before a tooltip is rendered. Allows customization of tooltip content. |
| nodeClick | Triggers when a node is clicked. |
| nodeEnter | Triggers when the mouse enters a node area. |
| nodeLeave | Triggers when the mouse leaves a node area. |
| linkClick | Triggers when a link is clicked. |
| linkEnter | Triggers when the mouse enters a link area. |
| linkLeave | Triggers when the mouse leaves a link area. |
| sizeChanged | Triggers when the chart size changes. |
| beforeExport | Triggers before the export process starts. |
| afterExport | Triggers after the export process completes. |
| exportCompleted | Triggers when export is completed. |
| beforePrint | Triggers before the print process starts. |

## Lifecycle Events

### Load Event

The `load` event triggers before the Sankey Chart begins rendering. Use this event to customize configuration, apply themes, or prepare data before the chart loads:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/load-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Load-event.cs" %}
{% include code-snippet/sankey/events/load-event/load-event.cs %}
{% endhighlight %}
{% endtabs %}

### Loaded Event

The `loaded` event triggers after the Sankey Chart is completely rendered and ready for interaction. Use this event to initialize calculations, perform analytics, or trigger dependent components:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/loaded-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Loaded-event.cs" %}
{% include code-snippet/sankey/events/loaded-event/loaded-event.cs %}
{% endhighlight %}
{% endtabs %}

## Interaction Events

... (content preserved)
