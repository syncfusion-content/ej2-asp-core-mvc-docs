---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Update Value of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Update Value
publishingplatform: ##Platform_Name##
documentation: ug
---


# Capture ctrl+s to update the value

To achieve this, we need to bind the `keydown` event to the Rich Text Editor content and capture the `ctrl + s` key press using its `keyCode`.
In the `keydown` event handler, the `updateValue` method is called to update the [`value`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_Value) property and then we can save the content in the required database using the same.

{% aspTab template="rich-text-editor/how-to/save", sourceFiles="controller.cs" %}

{% endaspTab %}
