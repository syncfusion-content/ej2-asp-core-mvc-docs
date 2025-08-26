---
layout: post
title: Drag and drop in ##Platform_Name## Block Editor Control | Syncfusion
description: Checkout and learn about Drag and drop with Syncfusion Essential ##Platform_Name## BlockEditor control, its elements, and more details.
platform: ej2-asp-core-mvc
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Drag and drop in ##Platform_Name## Block Editor control

The drag and drop feature in Block Editor allows users to easily rearrange blocks within the editor by dragging them to different positions.

## Enable Drag and Drop

You can control drag and drop operations within Block Editor using the [EnableDragAndDrop](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_EnableDragAndDrop) property. By default, it is set to `true`.

## Dragging blocks

When drag and drop is enabled, users can rearrange blocks in the following ways:

The Block Editor supports both single and multiple block dragging. Users can drag individual blocks or select multiple blocks and drag them together to a new position.

- **Single Block Dragging**: For single block, users can hover over a block to reveal the drag handle, then click and drag to move it to a new position.

- **Multiple Block Dragging**: For multiple blocks, users first select the blocks they want to move. Once selected, users can drag the entire group to a new position.

During the drag operation, the editor provides visual cues to indicate where the blocks will be positioned when dropped. This helps users precisely place blocks where they want it.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/drag-drop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DragDrop.cs" %}
{% include code-snippet/block-editor/drag-drop/dragdrop.cs %}
{% endhighlight %}
{% endtabs %}

![Drag and Drop](images/drag-drop.png)
