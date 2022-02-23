---
title: "ASP.NET MVC Rich Text Editor Keyboard interaction"
component: "Rich Text Editor"
description: "This section for Syncfusion ASP.NET MVC Rich Text Editor control explains keyboard accessibility that includes shortcuts to interact with the control."
---

# Keyboard Support

The editor has full keyboard accessibility that includes shortcuts to open and other actions with toolbar items, drop-down lists, and dialogs.

## HTML Formation Shortcut Key

You can use the following key shortcuts when the Rich Text Editor renders with HTML edit mode.

| Actions | Keyboard shortcuts |
|----------------|---------|
| Toolbar focus | <kbd>`alt`</kbd> + <kbd>`f10`</kbd> |
| Insert link | <kbd>`ctrl`</kbd> + <kbd>`k`</kbd> |
| Insert image | <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`i`</kbd> |
| Insert table | <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`e`</kbd> |
| Undo | <kbd>`ctrl`</kbd> + <kbd>`z`</kbd> |
| Redo | <kbd>`ctrl`</kbd> + <kbd>`y`</kbd> |
| Copy | <kbd>`ctrl`</kbd> + <kbd>`c`</kbd> |
| Cut | <kbd>`ctrl`</kbd> + <kbd>`x`</kbd> |
| Paste| <kbd>`ctrl`</kbd> + <kbd>`v`</kbd> |
| Bold| <kbd>`ctrl`</kbd> + <kbd>`b`</kbd> |
| Italic| <kbd>`ctrl`</kbd> + <kbd>`i`</kbd> |
| Underline| <kbd>`ctrl`</kbd> + <kbd>`u`</kbd> |
| Strikethrough| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`s`</kbd> |
| Uppercase| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`u`</kbd> |
| Lowercase| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`l`</kbd> |
| Superscript| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`=`</kbd> |
| Subscript| <kbd>`ctrl`</kbd> + <kbd>`=`</kbd> |
| Indents| <kbd>`ctrl`</kbd> + <kbd>`]`</kbd> |
| Outdents| <kbd>`ctrl`</kbd> + <kbd>`[`</kbd> |
| HTML source | <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`h`</kbd> |
| Fullscreen| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`f`</kbd> |
| Exit Fullscreen| <kbd>`Esc`</kbd> |
| Justify center| <kbd>`ctrl`</kbd> + <kbd>`e`</kbd> |
| Justify full | <kbd>`ctrl`</kbd> + <kbd>`j`</kbd> |
| Justify left | <kbd>`ctrl`</kbd> + <kbd>`l`</kbd> |
| Justify right | <kbd>`ctrl`</kbd> + <kbd>`r`</kbd> |
| Clear format | <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`r`</kbd> |
| Ordered list | <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`o`</kbd> |
| Unordered list | <kbd>`ctrl`</kbd> + <kbd>`alt`</kbd> + <kbd>`o`</kbd> |

{% aspTab template="rich-text-editor/html-keyboard", sourceFiles="controller.cs" %}

{% endaspTab %}

## Markdown Formation Shortcut Key

You can use the following key shortcuts when the Rich Text Editor renders with Markdown edit mode.

| Actions | Keyboard shortcuts |
|----------------|---------|
| Toolbar focus|  <kbd>`alt`</kbd> + <kbd>`f10`</kbd> |
| Insert link| <kbd>`ctrl`</kbd> + <kbd>`k`</kbd> |
| Insert image| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`i`</kbd> |
| Insert table| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`e`</kbd> |
| Undo| <kbd>`ctrl`</kbd> + <kbd>`z`</kbd> |
| Redo| <kbd>`ctrl`</kbd> + <kbd>`y`</kbd> |
| Copy| <kbd>`ctrl`</kbd> + <kbd>`c`</kbd> |
| Cut| <kbd>`ctrl`</kbd> + <kbd>`x`</kbd> |
| Paste| <kbd>`ctrl`</kbd> + <kbd>`v`</kbd> |
| Bold| <kbd>`ctrl`</kbd> + <kbd>`b`</kbd> |
| Italic| <kbd>`ctrl`</kbd> + <kbd>`i`</kbd> |
| Strikethrough| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`s`</kbd> |
| Uppercase| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`u`</kbd> |
| Lowercase| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`l`</kbd> |
| Superscript| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`=`</kbd> |
| Subscript| <kbd>`ctrl`</kbd> + <kbd>`=`</kbd> |
| Fullscreen| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`f`</kbd> |
| Ordered list| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`o`</kbd> |
| Unordered list| <kbd>`ctrl`</kbd> + <kbd>`alt`</kbd> + <kbd>`o`</kbd> |

{% aspTab template="rich-text-editor/md-keyboard", sourceFiles="controller.cs" %}

{% endaspTab %}

## Custom Key Config

Customize the key config for the keyboard interaction of Rich Text Editor, using the [`KeyConfig`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_KeyConfig) property.

In the following sample, customize the bold, italic, underline toolbar action with <kbd>`ctrl`</kbd> + <kbd>`alt`</kbd> + <kbd>`b`</kbd>, <kbd>`ctrl`</kbd> + <kbd>`alt`</kbd> + <kbd>`i`</kbd> and <kbd>`ctrl`</kbd> + <kbd>`alt`</kbd> + <kbd>`u`</kbd> respectively.

{% aspTab template="rich-text-editor/custom-key", sourceFiles="controller.cs" %}

{% endaspTab %}

## See Also

* [Globalization](./globalization/)
* [Accessibility](./accessibility/)
* [How to customize the saving operation](./how-to/save/)