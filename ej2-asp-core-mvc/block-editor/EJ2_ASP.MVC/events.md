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

The `created` event is triggered when the Block Editor control is successfully initialized and ready for use. This event is useful for performing setup operations or initializing additional features after the editor is created.

## ContentChanged

The `contentChanged` event is triggered whenever the content within the editor is modified. This includes content additions, deletions, or any structural modifications to the document.

## SelectionChanged

The `selectionChanged` event is triggered when the user's text selection changes within the editor. This can be useful for updating UI elements based on the current selection.

## UndoRedoPerformed

The `undoRedoPerformed` event is triggered when an undo or redo operation is executed. This event provides information about the action performed and the state before and after the operation.

## BlockAdded

The `blockAdded` event is triggered when a new block is added to the editor. This includes blocks added through user interaction, paste operations, or programmatic insertion.

## BlockRemoved

The `blockRemoved` event is triggered when a block is removed from the editor. This can occur through user deletion, cut operations, or programmatic removal.

## BlockMoved

The `blockMoved` event is triggered when blocks are moved from one position to another within the editor. This includes drag-and-drop operations, through keyboard shortcuts or programmatic block reordering.

## BlockDragStart

The `blockDragStart` event is triggered at the beginning of a block drag operation, providing information about the blocks being dragged and their initial position.

## BlockDrag

The `blockDrag` event is triggered during a drag operation, providing information about the blocks being dragged and their current position.

## BlockDrop

The `blockDrop` event is triggered when blocks are successfully dropped at their destination during a drag-and-drop operation.

## Focus

The `focus` event is triggered when the editor gains focus. This is useful for updating UI states and managing editor interactions.

## Blur

The `blur` event is triggered when the editor loses focus. This is commonly used for auto-saving content or hiding UI elements.

## KeyActionExecuted

The `keyActionExecuted` event is triggered when a keyboard shortcut is executed. This provides information about the key combination used and the corresponding action performed.

## BeforePaste

The `beforePaste` event is triggered before content is pasted into the editor. This event allows you to modify or cancel the paste operation.

## AfterPaste

The `afterPaste` event is triggered after content has been successfully pasted into the editor. This is useful for post-processing pasted content or updating related UI elements.
