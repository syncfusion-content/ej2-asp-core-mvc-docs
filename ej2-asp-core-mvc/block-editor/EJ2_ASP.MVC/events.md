---
layout: post
title: Events in ##Platform_Name## Block Editor Control | Syncfusion
description: Checkout and learn about Events with Syncfusion Essential ##Platform_Name## BlockEditor control, its elements, and more details.
platform: ej2-asp-core-mvc
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Events in ##Platform_Name## Block Editor control

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

## ContentChanged

The [ContentChanged](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_ContentChanged) event is triggered whenever the content within the editor is modified. This includes content additions, deletions, or any structural modifications to the document.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("contentChanged").Render()
</div>

<script>
    function contentChanged(args) {
        // You may initialize custom plugins or features
    }
</script>

```

## SelectionChanged

The [SelectionChanged](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_SelectionChanged) event is triggered when the user's text selection changes within the editor. This can be useful for updating UI elements based on the current selection.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("selectionChanged").Render()
</div>

<script>
    function selectionChanged(args) {
        // You can update formatting toolbar based on selection
    }
</script>

```

## UndoRedoPerformed

The [UndoRedoPerformed](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_UndoRedoPerformed) event is triggered when an undo or redo operation is executed. This event provides information about the action performed and the state before and after the operation.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("undoRedoPerformed").Render()
</div>

<script>
    function undoRedoPerformed(args) {
        // You may log undo/redo actions for analytics
    }
</script>

```

## BlockAdded

The [BlockAdded](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_BlockAdded) event is triggered when a new block is added to the editor. This includes blocks added through user interaction, paste operations, or programmatic insertion.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("blockAdded").Render()
</div>

<script>
    function blockAdded(args) {
        // You may trigger custom actions when a block is added
    }
</script>

```

## BlockRemoved

The [BlockRemoved](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_BlockRemoved) event is triggered when a block is removed from the editor. This can occur through user deletion, cut operations, or programmatic removal.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("blockRemoved").Render()
</div>

<script>
    function blockRemoved(args) {
        // You may trigger custom actions when a block is removed
    }
</script>

```

## BlockMoved

The [BlockMoved](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_BlockMoved) event is triggered when blocks are moved from one position to another within the editor. This includes drag-and-drop operations, through keyboard shortcuts or programmatic block reordering.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("blockMoved").Render()
</div>

<script>
    function blockMoved(args) {
        // You may trigger custom actions when blocks are moved
    }
</script>

```

## BlockDragStart

The [BlockDragStart](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_BlockDragStart) event is triggered at the beginning of a block drag operation, providing information about the blocks being dragged and their initial position.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("blockDragStart").Render()
</div>

<script>
    function blockDragStart(args) {
        // You may cancel the drag operation for certain block types
        // or trigger custom actions when a block drag operation starts
    }
</script>

```

## BlockDrag

The [BlockDrag](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_BlockDrag) event is triggered during a drag operation, providing information about the blocks being dragged and their current position.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("blockDrag").Render()
</div>

<script>
    function blockDrag(args) {
        // You may trigger custom actions during a block drag operation based on the current position
    }
</script>

```

## BlockDrop

The [BlockDrop](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_BlockDrop) event is triggered when blocks are successfully dropped at their destination during a drag-and-drop operation.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("blockDrop").Render()
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
    @Html.EJS().BlockEditor("block-editor").Created("focus").Render()
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
    @Html.EJS().BlockEditor("block-editor").Created("blur").Render()
</div>

<script>
    function blur(args) {
        // Custom actions when the editor loses focus
    }
</script>

```

## KeyActionExecuted

The [KeyActionExecuted](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_KeyActionExecuted) event is triggered when a keyboard shortcut is executed. This provides information about the key combination used and the corresponding action performed.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("keyActionExecuted").Render()
</div>

<script>
    function keyActionExecuted(args) {
        // Custom actions when a keyboard shortcut is executed
    }
</script>

```

## BeforePaste

The [BeforePaste](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_BeforePaste) event is triggered before content is pasted into the editor. This event allows you to modify or cancel the paste operation.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("beforePaste").Render()
</div>

<script>
    function beforePaste(args) {
        // You may cancel paste if content contains restricted elements
    }
</script>

```

## AfterPaste

The [AfterPaste](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_AfterPaste) event is triggered after content has been successfully pasted into the editor. This is useful for post-processing pasted content or updating related UI elements.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Created("afterPaste").Render()
</div>

<script>
    function afterPaste(args) {
        // Process pasted content or update UI
    }
</script>

```
