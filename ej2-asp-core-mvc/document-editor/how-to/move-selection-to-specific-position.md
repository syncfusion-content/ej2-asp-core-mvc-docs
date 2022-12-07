---
layout: post
title: Move the selection to specific position in ##Platform_Name## Document Editor Component
description: Learn how to move the selection to specific position in Document from the ##Platform_Name## Document Editor Component
platform: ej2-asp-core-mvc
control: Move The Selection To Specific Position
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to move the selection to specific position in Document Editor component

Using `select` API in selection module, You can set cursor position to anywhere in the document.

## Selects content based on start and end hierarchical index

Hierarchical index will be in below format.

`sectionIndex;blockIndex;offset`

The following code snippet illustrate how to select using hierarchical index.

```typescript
// Selection will occur between provided start and end offset
this.documentEdContainerIns.documentEditor.editor.insertText("Welcome");
// The below code will select the letters “We” from inserted text “Welcome”
this.documentEdContainerIns.documentEditor.selection.select("0;0;0", "0;0;2");
```

The following table illustrates about Hierarchical index in detail.

| Element |Hierarchical Format | Explanation |
|-----------------|-------------|----|
|Move selection to Paragraph |sectionIndex;blockIndex;offset <br>**Ex:** 0;0;0|It moves the cursor to the start of paragraph.|
|Move selection to Table|sectionIndex;tableIndex;rowIndex;cellIndex;blockIndex;offset <br>**Ex:** 0;0;0;0;1;0|It moves the cursor to the second paragraph which is inside first row and cell of table.|
|Move selection to header|pageIndex;H;sectionIndex;blockIndex;offset<br>**Ex:** 1;H;0;0;0|It moves cursor to the header in second page.|
|Move selection to Footer|pageIndex;F;sectionIndex;blockIndex;offset<br>**Ex:** 1;F;0;0;0|It moves cursor to the footer in second page.|

## Get the selection start and end hierarchical index

Using [`startOffset`], you can get start hierarchical index which denotes the start index of current selection.
Similarly, using [`endOffset`], you can get end hierarchical index which denotes the end index of current selection.

The following code snippet illustrate how to get the selection start and end offset on selection changes in document.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/select/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="select.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/select/razor %}
{% endhighlight %}
{% highlight c# tabtitle="select.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}


## Selects the content based on left and top position

Here, you can specify the [`selection settings`] to select the content based on left and top position.

x denotes the left position and y denotes the top position and extend denotes whether to extend or update selection.

Check below code sample for reference.

```typescript
this.container.documentEditor.selection.select({ x: 188.4814208984375 , y: 662.00005, extend: true });
```