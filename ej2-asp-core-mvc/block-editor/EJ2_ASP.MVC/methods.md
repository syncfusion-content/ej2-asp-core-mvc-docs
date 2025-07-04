---
layout: post
title: Methods in ##Platform_Name## Block Editor Control | Syncfusion
description: Checkout and learn about Methods with Syncfusion Essential ##Platform_Name## BlockEditor control, its elements, and more details.
platform: ej2-asp-core-mvc
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Methods in ##Platform_Name## Block Editor control

The Block Editor control provides a comprehensive set of public methods that allow you to programmatically interact with and manipulate the editor content. These methods enable you to add, remove, update, and manage blocks, as well as control selection, formatting, and other editor operations.

## Block Management Methods

### Adding a block

You can add a new block to the editor at a specified position using the `addBlock` method. You can also insert the block before or after a target block.

```cs
// Add a new paragraph block after a specific block
const newBlock = {
    id: 'new-block',
    type: 'Paragraph',
    content: [
        {
            type: "Text",
            content: 'This is a newly added block'
        }
    ]
};

blockEditorObj.addBlock(newBlock, 'target-block-id', true); // true = after, false = before

```

### Removing a block

You can remove a block from the editor using the `removeBlock` method.

```cs
// Remove a block by its ID
blockEditorObj.removeBlock('block-to-remove-id');
```

### Moving a block

You can move a block from one position to another within the editor using the `moveBlock` method.

```cs
// Move a block to a new position
blockEditorObj.moveBlock('source-block-id', 'target-block-id');
```

### Updating a block

You can update the properties of an existing block using the `updateBlock` method. Only the specified properties are modified while others remain unchanged. Returns `true` if the update was successful, `false` otherwise.

```cs
// Update block properties
blockEditorObj.updateBlock('block-id', {
    isChecked: true
});
```

### Getting a block

You can retrieve a block model by its unique identifier using the `getBlock` method. Returns `null` if the block is not found.

```cs
// Get a specific block
blockEditorObj.getBlock('block-id');
```

### Getting block count

You can utilize the `getBlockCount` method to retrieve the total number of blocks in the editor.

```cs
// Get total block count
blockEditorObj.getBlockCount();
```

Below example demonstrates the usage of the above methods.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/methods/block/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Block.cs" %}
{% include code-snippet/block-editor/methods/block/block.cs %}
{% endhighlight %}
{% endtabs %}

![Block Method](images/method-block.png)

## Selection and Cursor Methods

### Setting text selection

You can set the text selection within a specific content element using start and end positions with the `setSelection` method.

```cs
// Select text from position 5 to 15 in a content element
blockEditorObj.setSelection('content-element-id', 5, 15);
```

### Setting cursor position

You can place the cursor at a specific position within a block using the `setCursorPosition` method.

```cs
// Set cursor at position 10 in a block
blockEditorObj.setCursorPosition('block-id', 10);
```

### Getting selected blocks

You can retrieve the currently selected blocks in the editor using the `getSelectedBlocks` method. Returns `null` if no blocks are selected.

```cs
// Get all selected blocks
blockEditorObj.getSelectedBlocks();
```

### Getting selection range

You can get the current selection range  in the editor using the `getRange` method. This method returns a `Range` object representing the selected text. Returns `null` if no selection is active.

```cs
// Get current selection range
blockEditorObj.getRange();
```

### Setting selection range

You can set the selection range in the editor using the `selectRange` method. This method accepts a `Range` object that defines the start and end positions of the selection within the editor.

```cs
// Create and select a custom range
blockEditorObj.selectRange(customRange);
```

### Selecting a block

You can select a specific block in the editor using the `selectBlock` method.

```cs
// Select a complete block
blockEditorObj.selectBlock('block-id');
```

### Selecting all blocks

You can select all blocks in the editor using the `selectAllBlocks` method.

```cs
// Select all content in the editor
blockEditorObj.selectAllBlocks();
```

Below example demonstrates the usage of the above methods.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/methods/selection/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Selection.cs" %}
{% include code-snippet/block-editor/methods/selection/selection.cs %}
{% endhighlight %}
{% endtabs %}

![Selection Method](images/method-selection.png)

## Focus Management Methods

### FocusIn

You can utilize the `focusIn` method to give focus to the editor. This method ensures that the editor is ready for user input.

```cs
// Focus the editor
blockEditorObj.focusIn();
```

### FocusOut

You can remove focus from the editor using the focusOut method. This method clears any active selections and makes the editor inactive for user input.

```cs
// Remove focus from the editor
blockEditorObj.focusOut();
```

## Formatting Methods

### Executing toolbar action

You can execute a built-in toolbar formatting command using the `executeToolbarAction` method. This method is used to apply formatting such as bold, italic, or color to the selected text.

```cs
// Apply bold formatting
blockEditorObj.executeToolbarAction(BuiltInToolbar.Bold);

// Apply color formatting with a specific value
blockEditorObj.executeToolbarAction(BuiltInToolbar.Color, '#ff0000');
```

### Enabling toolbar items

You can enable specific toolbar items in the inline toolbar using the `enableToolbarItems` method. This method accepts a single item or an array of items to be enabled.

```cs
// Enable specific toolbar item
blockEditorObj.enableToolbarItems('bold');

// Work with multiple items
blockEditorObj.enableToolbarItems(['bold', 'italic', 'underline']);
```

### Disabling toolbar items

You can disable specific toolbar items in the inline toolbar using the `disableToolbarItems` method. This method accepts a single item or an array of items to be disabled.

```cs
// Disable specific toolbar items
blockEditorObj.disableToolbarItems('bold');

// Work with multiple items
blockEditorObj.disableToolbarItems(['bold', 'italic', 'underline']);
```

Below example demonstrates the usage of the above methods.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/methods/formatting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/block-editor/methods/formatting/formatting.cs %}
{% endhighlight %}
{% endtabs %}

![Formatting Method](images/method-formatting.png)

## Data Export Methods

### Getting data as JSON

You can export the editor content in JSON format using the `getDataAsJson` method. This method allows you to export all blocks or a specific block.

```cs
// Get all blocks as JSON
const allBlocks = blockEditorObj.getDataAsJson();

// Get a specific block as JSON
const specificBlock = blockEditorObj.getDataAsJson('block-id');
```

### Getting data as HTML

You can export the editor content in HTML format using the `getDataAsHtml` method. This method allows you to export all blocks or a specific block.

```cs
// Get all blocks as HTML
const allBlocksHtml: string = blockEditorObj.getDataAsHtml();

// Get a specific block as HTML
const specificBlockHtml: string = blockEditorObj.getDataAsHtml('block-id');
```

### Printing editor content

You can print the editor content using the `print` method. This method opens a print dialog with the current editor content formatted for printing.

```cs
// Print the editor content
blockEditorObj.print();
```

Below example demonstrates the usage of the above methods.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/methods/data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/block-editor/methods/data/data.cs %}
{% endhighlight %}
{% endtabs %}

![Data Method](images/method-data.png)
