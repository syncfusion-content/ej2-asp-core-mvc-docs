---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Read By Default of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Read By Default
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to open a document in read only mode by default in Document Editor

In this article, we are going to see how to open a document in read only mode by default in Document Editor & Document  Editor Container.

## Opening a document in read only mode by default in Document Editor

Using `isReadOnly` property in Document editor allows us to enable/disable read only mode in the document editor.

The following example illustrates how to open the document in read-only mode by default.

{% aspTab template="document-editor/read-only" %}

{% endaspTab %}

## Opening a document in ready only mode by default in Document Editor Container

Using `restrictEditing` property in Document editor container allows us to enable/disable read only mode in the document editor.

The following example illustrates how to open the document in read only mode by default.

{% aspTab template="document-editor-container/read-only" %}

{% endaspTab %}

Note: You can use the `restrictEditing` in `DocumentEditorContainerComponent` and `isReadOnly` in `DocumentEditorComponent` based on your requirement to change component to read only mode.