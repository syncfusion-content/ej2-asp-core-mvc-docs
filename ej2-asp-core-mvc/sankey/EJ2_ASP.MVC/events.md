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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/load-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Load-event.cs" %}
{% include code-snippet/sankey/events/load-event/load-event.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/load-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Load-event.cs" %}
{% include code-snippet/sankey/events/load-event/load-event.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

### Loaded Event

The `loaded` event triggers after the Sankey Chart is completely rendered and ready for interaction. Use this event to initialize calculations, perform analytics, or trigger dependent components:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/loaded-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Loaded-event.cs" %}
{% include code-snippet/sankey/events/loaded-event/loaded-event.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/loaded-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Loaded-event.cs" %}
{% include code-snippet/sankey/events/loaded-event/loaded-event.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Interaction Events

### Node Interaction Events

Handle node click and hover events to respond to user actions and provide interactive feedback:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/node-interaction-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Node-interaction-event.cs" %}
{% include code-snippet/sankey/events/node-interaction-event/node-interaction-event.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/node-interaction-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Node-interaction-event.cs" %}
{% include code-snippet/sankey/events/node-interaction-event/node-interaction-event.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Link Interaction Events

Handle link click and hover events:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/link-interaction-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Link-interaction-event.cs" %}
{% include code-snippet/sankey/events/link-interaction-event/link-interaction-event.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/link-interaction-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Link-interaction-event.cs" %}
{% include code-snippet/sankey/events/link-interaction-event/link-interaction-event.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Rendering Events

Use rendering events to customize elements dynamically based on data values, conditions, or business logic. This is the most powerful approach for data-driven styling.

### Node Rendering Event

The `nodeRendering` event triggers before each node is rendered, allowing dynamic node customization:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/node-rendering-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Node-rendering-event.cs" %}
{% include code-snippet/sankey/events/node-rendering-event/node-rendering-event.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/node-rendering-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Node-rendering-event.cs" %}
{% include code-snippet/sankey/events/node-rendering-event/node-rendering-event.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

### Link Rendering Event

The `linkRendering` event triggers before each link is rendered, allowing dynamic link customization:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/link-rendering-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Link-rendering-event.cs" %}
{% include code-snippet/sankey/events/link-rendering-event/link-rendering-event.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/link-rendering-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Link-rendering-event.cs" %}
{% include code-snippet/sankey/events/link-rendering-event/link-rendering-event.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

### Label Rendering Event

The `labelRendering` event triggers before each label is rendered, allowing dynamic label customization:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/label-rendering-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label-rendering-event.cs" %}
{% include code-snippet/sankey/events/label-rendering-event/label-rendering-event.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/label-rendering-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label-rendering-event.cs" %}
{% include code-snippet/sankey/events/label-rendering-event/label-rendering-event.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

### Legend Item Rendering Event

The `legendItemRendering` event triggers before a legend item is rendered, allowing custom legend item styling:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/legend-item-rendering-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-item-rendering-event.cs" %}
{% include code-snippet/sankey/events/legend-item-rendering-event/legend-item-rendering-event.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/legend-item-rendering-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Legend-item-rendering-event.cs" %}
{% include code-snippet/sankey/events/legend-item-rendering-event/legend-item-rendering-event.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Size Changed Event

Respond when the chart size changes (e.g., window resize):

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/size-changed-event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size-changed-event.cs" %}
{% include code-snippet/sankey/events/size-changed-event/size-changed-event.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/size-changed-event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size-changed-event.cs" %}
{% include code-snippet/sankey/events/size-changed-event/size-changed-event.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

## Complete Event Handler Example

Combine multiple events for comprehensive handling:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/complete-event-handler/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Complete-event-handler.cs" %}
{% include code-snippet/sankey/events/complete-event-handler/complete-event-handler.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sankey/events/complete-event-handler/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Complete-event-handler.cs" %}
{% include code-snippet/sankey/events/complete-event-handler/complete-event-handler.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}
