---
layout: post
title: Editor Menus in ##Platform_Name## Block Editor Control | Syncfusion
description: Checkout and learn about Editor Menus with Syncfusion Essential ##Platform_Name## BlockEditor control, its elements, and more details.
platform: ej2-asp-core-mvc
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Editor Menus in ##Platform_Name## Block Editor control

The Block Editor control provides several interactive menus to enhance content creation and editing. These menus offer quick access to various commands and formatting options.

## Slash command menu

The Slash Command menu allows users to quickly insert or transform blocks by typing `/` followed by a command. This provides an efficient, keyboard-driven way to interact with the editor.

### Built-in items

The Slash Command menu comes with a set of pre-defined commands for all block types:

-   **Headings(Level 1 to 4)**: to insert respective heading blocks.
-   **Lists(Bullet, Numbered, Checklist)**: for different list types.
-   **Paragraph**: for standard text blocks.
-   **Image**: for media insertion.
-   **Toggle**: for collapsible content.
-   **Callout**: for highlighting important information.
-   **Utility(Divider, Quote, Code)**: for other utility blocks.

### Customize Slash command menu

You can utilize the `e-blockeditor-commandmenusettings` tag helper on the Block Editor control to customize the Slash Command menu to include your own custom commands and other modifications.

#### Show or hide tooltip

By default, the tooltip is displayed when the user hovers over the command item. You can show or hide the tooltip using the `enableTooltip` property on the `e-blockeditor-commandmenusettings` tag helper.

### Events

The following events are available in the Slash Command menu.

|Name|Args|Description|
|---|---|---|
|`open`|CommandMenuOpenEventArgs|Triggers when the command menu is opened.|
|`close`|CommandMenuCloseEventArgs|Triggers when the command menu is closed.|
|`queryFiltering`|CommandQueryFilteringEventArgs|Triggers when the user types to filter the command menu items.|
|`itemClicked`|CommandItemClickedEventArgs|Triggers when the user clicks on a command menu item.|

Below example demonstrates the customization of the Slash Command menu.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/editor-menus/slash-command/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SlashCommand.cs" %}
{% include code-snippet/block-editor/editor-menus/slash-command/slashCommand.cs %}
{% endhighlight %}
{% endtabs %}

![Slash Command](images/editor-slashcommand.png)

## Context menu

The Context menu appears when a user right-clicks within a specific block. It provides context-aware actions relevant to the clicked block or content.

### Built-in items

The Context menu offers different built-in options:

-  **Undo/Redo**: Undo and redo actions.
-  **Cut/Copy/Paste**: Standard clipboard actions.
-  **Indent**: Increase or decrease the indent level of the selected block.
-  **Link**: Add or edit a hyperlink.

### Customize Context menu

You can utilize the `e-blockeditor-contextmenusettings` tag helper on the Block Editor to customize the Context menu to add specific actions or modify existing ones based on the application needs.

### Events

The following events are available in the Context menu.

|Name|Args|Description|
|---|---|---|
|`beforeOpen`|ContextMenuBeforeOpenEventArgs|Triggers before the context menu opens.|
|`open`|ContextMenuOpenEventArgs|Triggers when the context menu is opened.|
|`beforeClose`|ContextMenuBeforeCloseEventArgs|Triggers before the context menu closes.|
|`close`|ContextMenuCloseEventArgs|Triggers when the context menu is closed.|
|`itemClick`|ContextMenuItemClickEventArgs|Triggers when a context menu item is clicked.|

Below example demonstrates the customization of the Context menu.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/editor-menus/context-menu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ContextMenu.cs" %}
{% include code-snippet/block-editor/editor-menus/context-menu/contextMenu.cs %}
{% endhighlight %}
{% endtabs %}

![Context Menu](images/editor-contextmenu.png)

## Block action menu

The Block Action menu typically appears next to a block when you hover over it and click on the drag handle icon, offering quick actions specific to that block.

### Built-in items

The Block Action menu provides convenient actions for managing individual blocks:

-   **Duplicate**: Create a copy of the current block.
-   **Delete**: Remove the block from the editor.
-   **Move Up**: Move the block one level up in the hierarchy.
-   **Move Down**: Move the block one level down in the hierarchy.

### Customize Block action menu

You can utilize the `e-blockeditor-blockactionmenusettings` tag helper on the block editor to customize the Block action menu to include block-specific commands relevant to your application. This allows for highly tailored user experiences.

#### Show or hide tooltip

By default, the tooltip is displayed when the user hovers over the action item. You can show or hide the tooltip using the `enableTooltip` property on the block action menu settings.

### Events

The following events are available in the Block action menu.

|Name|Args|Description|
|---|---|---|
|`open`|Block actionMenuOpenEventArgs|Triggers when the block action menu is opened.|
|`close`|Block actionMenuCloseEventArgs|Triggers when the block action menu is closed.|
|`itemClick`|Block actionMenuItemClickEventArgs|Triggers when a block action menu item is clicked.|

Below example demonstrates the customization of the Block action menu.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/editor-menus/block-action/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="BlockAction.cs" %}
{% include code-snippet/block-editor/editor-menus/block-action/blockAction.cs %}
{% endhighlight %}
{% endtabs %}

![Block Action](images/editor-blockaction.png)

## Inline Toolbar

The Inline Toolbar appears when a text is selected in the editor, providing quick access to common text formatting actions that apply to the inline content.

### Built-in items

The Inline Toolbar includes below built-in formatting options:

-   **Text Styles**: Bold, Italic, Underline, Strikethrough.
-   **Superscript/Subscript**: For mathematical or scientific notations.
-   **Case Conversion**: Uppercase, Lowercase.
-   **Text Color**: Change text color.
-   **Background Color**: Change background color.

### Customize Inline Toolbar

You can utilize the `e-blockeditor-inlinetoolbarsettings` tag helper on the Block Editor to customize the Inline Toolbar to add or remove formatting options based on your application's needs.

#### Show or hide tooltip

By default, the tooltip is displayed when the user hovers over the toolbar item. You can show or hide the tooltip using the `enableTooltip` property on the inline toolbar settings.

### Events

The following events are available in the Inline Toolbar.

|Name|Args|Description|
|---|---|---|
|`open`|ToolbarOpenEventArgs|Triggers when the inline toolbar is opened.|
|`close`|ToolbarCloseEventArgs|Triggers when the inline toolbar is closed.|
|`itemClicked`|ToolbarItemClickedEventArgs|Triggers when the user clicks on an inline toolbar item.|

Below example demonstrates the customization of the Inline Toolbar.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/editor-menus/inline-toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="InlineToolbar.cs" %}
{% include code-snippet/block-editor/editor-menus/inline-toolbar/inlineToolbar.cs %}
{% endhighlight %}
{% endtabs %}
