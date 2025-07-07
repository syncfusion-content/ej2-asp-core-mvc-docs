---
layout: post
title: Undo redo in ##Platform_Name## Block Editor Control | Syncfusion
description: Checkout and learn about undo redo with Syncfusion Essential ##Platform_Name## BlockEditor control, its elements, and more details.
platform: ej2-asp-core-mvc
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Undo redo in ##Platform_Name## Block Editor control

The undo/redo feature in Block Editor enables users to revert or reapply changes made to the content, offering a safety net for edits and enhancing the overall editing experience.

## Keyboard shortcuts

| Action | Windows | Mac | Description |
|------------|--------------|---------|-----------------|
| Undo       | Ctrl + Z     | ⌘ + Z   | Reverts the last action. |
| Redo       | Ctrl + Y     | ⌘ + Y | Reapplies the last undone action. |

## Configuring Undo/Redo stack

Block Editor allows up to `30` Undo/Redo actions by default. You can modify the number of undo/redo steps using the [UndoRedoStack](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_UndoRedoStack) property.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/undo-redo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="UndoRedo.cs" %}
{% include code-snippet/block-editor/undo-redo/undoredo.cs %}
{% endhighlight %}
{% endtabs %}

![Undo Redo](images/undo-redo.png)
