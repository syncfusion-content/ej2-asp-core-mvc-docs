---
title: "Rich Text Editor How To capture ctrl+s"
component: "Rich Text Editor"
description: "This section for Syncfusion ASP.NET Rich Text Editor control explains how to capture the ctrl+s to update the value."
---

# Capture ctrl+s to update the value

To achieve this, we need to bind the `keydown` event to the Rich Text Editor content and capture the `ctrl + s` key press using its `keyCode`.
In the `keydown` event handler, the `updateValue` method is called to update the [`Value`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_Value) property and then we can save the content in the required database using the same.

{% aspTab template="rich-text-editor/how-to/save", sourceFiles="controller.cs" %}

{% endaspTab %}
