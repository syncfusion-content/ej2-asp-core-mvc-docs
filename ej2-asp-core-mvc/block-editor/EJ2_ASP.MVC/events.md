---
layout: post
title: Events in ASP.NET MVC Block Editor Control | Syncfusion
description: Checkout and learn about Events with Syncfusion Essential ASP.NET MVC BlockEditor control, its elements, and more details.
platform: ej2-asp-core-mvc
control: BlockEditor
publishingplatform: ASP.NET MVC
documentation: ug
---

# Events in ASP.NET MVC Block Editor control

The Block Editor control provides a comprehensive set of events that allow you to monitor and respond to various user interactions and editor state changes. These events enable you to implement custom behaviors, validation, logging, and integration with other systems.

## Created

The [Created](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_Created) event is triggered when the Block Editor control is successfully initialized and ready for use. This event is useful for performing setup operations or initializing additional features after the editor is created.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("created").Render()
</div>

<script>
    function created() {
        // You may initialize custom plugins or features
    }
</script>

```

## BlockChanged

The `BlockChanged` event is triggered whenever the editor blocks are changed. This includes block additions, deletions, or any structural modifications to the document. Its event handler receives details about the changes.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").BlockChanged("handleBlockChange").Render()
</div>

<script>
    function handleBlockChange() {
        // You may initialize custom plugins or features
    }
</script>

```

## SelectionChanged

The [SelectionChanged](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_SelectionChanged) event is triggered when the user's text selection changes within the editor. This can be useful for updating UI elements based on the current selection.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").SelectionChanged("selectionChanged").Render()
</div>

<script>
    function selectionChanged(args) {
        // You can update formatting toolbar based on selection
    }
</script>

```

## BlockDragStart

The [BlockDragStart](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_BlockDragStart) event is triggered at the beginning of a block drag operation, providing information about the blocks being dragged and their initial position.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").BlockDragStart("blockDragStart").Render()
</div>

<script>
    function blockDragStart(args) {
        // You may cancel the drag operation for certain block types
        // or trigger custom actions when a block drag operation starts
    }
</script>

```

## BlockDragging

The `BlockDragging` event is triggered during a drag operation, providing information about the blocks being dragged and their current position.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").BlockDragging("blockDrag").Render()
</div>

<script>
    function blockDrag(args) {
        // You may trigger custom actions during a block drag operation based on the current position
    }
</script>

```

## BlockDropped

The `BlockDropped` event is triggered when blocks are successfully dropped at their destination during a drag-and-drop operation.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").BlockDropped("blockDrop").Render()
</div>

<script>
    function blockDrop(args) {
        // You may trigger custom actions when blocks are dropped
    }
</script>

```

## Focus

The [Focus](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_Focus) event is triggered when the editor gains focus. This is useful for updating UI states and managing editor interactions.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Focus("focus").Render()
</div>

<script>
    function focus(args) {
        // Custom actions when the editor gains focus
    }
</script>

```

## Blur

The [Blur](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_Blur) event is triggered when the editor loses focus. This is commonly used for auto-saving content or hiding UI elements.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Blur("blur").Render()
</div>

<script>
    function blur(args) {
        // Custom actions when the editor loses focus
    }
</script>

```

## BeforePasteCleanup

The `BeforePasteCleanup` event is triggered before content is pasted into the editor. This event allows you to modify or cancel the paste operation.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").BeforePasteCleanup("beforePaste").Render()
</div>

<script>
    function beforePaste(args) {
        // You may cancel paste if content contains restricted elements
    }
</script>

```

## AfterPasteCleanup

The `AfterPasteCleanup` event is triggered after content has been successfully pasted into the editor. This is useful for post-processing pasted content or updating related UI elements.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").AfterPasteCleanup("afterPaste").Render()
</div>

<script>
    function afterPaste(args) {
        // Process pasted content or update UI
    }
</script>

```
