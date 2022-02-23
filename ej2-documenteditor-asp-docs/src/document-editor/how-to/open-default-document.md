---
title: "How to"
component: "DocumentEditor"
description: "Learn how to open a default document when DocumentEditor is opened."
---

# How to open a default document in DocumentEditor when initialized

In this article, we are going to see how to open a default document when DocumentEditor & DocumentEditorContainer is initialized.

## Opening a default document in DocumentEditor

Using `open` method in Document editor allows us to open the Document in sfdt format. To open the document by default, call the open method in the `created` event of Document editor which gets triggered once the control is created.

The following example illustrates how to open the sfdt format document in Document editor by default.

{% aspTab template="document-editor/open-default-document", sourceFiles="document-editor.cs" %}

{% endaspTab %}

## Opening a default document in DocumentEditorContainer

To open the document by default, call the open method in the `created` event of Document editor container which gets triggered once the control is created.

The following example illustrates how to open the sfdt format document in Document editor container by default.

{% aspTab template="document-editor-container/open-default-document", sourceFiles="document-editor.cs" %}

{% endaspTab %}