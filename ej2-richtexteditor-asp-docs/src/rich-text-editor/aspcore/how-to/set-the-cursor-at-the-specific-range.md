---
title: "Rich Text Editor How To set the cursor position"
component: "Rich Text Editor"
description: "This section for Syncfusion ASP.NET Rich Text Editor control explains on how to set the cursor postion at the specific range."
---

# Set the cursor at the specific range

This can be achieved by using `setRange` method in the Rich Text Editor using `NodeSelection` instance. In this below sample, we have passed the text node (specific location in Rich Text Editor content) in `setStart` method and passed the range in `setRange` method of Rich Text Editor.

{% aspTab template="rich-text-editor/how-to/cursor", sourceFiles="controller.cs" %}

{% endaspTab %}