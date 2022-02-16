---
layout: post
title: Clipboard in ##Platform_Name## Document Editor Component
description: Learn here all about Clipboard in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Clipboard
publishingplatform: ##Platform_Name##
documentation: ug
---


# Clipboard

Document editor takes advantage of system clipboard and allows you to copy or move a portion of the document into it in HTML format, so that it can be pasted in any application that supports clipboard.

## Copy

Copy a portion of document to system clipboard using built-in context menu of document editor. You can also do it programmatically using the following sample code.

```typescript
documentEditor.selection.copy();
```

## Cut

Cut a portion of document to system clipboard using built-in context menu of document editor. You can also do it programmatically using the following sample code.

```typescript
documentEditor.editor.cut();
```

## Paste

Due to limitations, you can paste contents from system clipboard as plain text in document editor only using the ‘CTRL + V’ keyboard shortcut.

## Local paste

Document editor expose API to enable local paste within the control. On enabling this, the following is performed:
* Selected contents will be stored to an internal clipboard in addition to system clipboard.
* Clipboard paste will be overridden, and internally stored data that has formatted text will be pasted.
Refer to the following sample code.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/clipboard/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Clipboard.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/clipboard/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Clipboard.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



By default, **enableLocalPaste** is false.
When local paste is enabled for a document editor instance, you can paste contents programmatically if the internal clipboard has stored data during last copy operation. Refer to the following sample code.

```typescript
documentEditor.editor.pasteLocal();
```

### EnableLocalPaste behaviour

|**EnableLocalPaste** |**Paste behavior details**|
|--------------------------|----------------------|
|True |Allows to paste content that is copied from the same Document editor component alone and prevents pasting content from system clipboard. Hence the content copied from outside Document editor component can’t be pasted.<br>Browser limitation of pasting from system clipboard using API and context menu options, will be resolved. So, you can copy and paste content within the Document editor component using API and context menu options too.|
|False|Allows to paste content from system clipboard. Hence the content copied from both the Document editor component and outside can be pasted.<br>Browser limitation of pasting from system clipboard using API and context menu options, will remain as a limitation.|

 
> Keyboard shortcut for pasting will work properly in both cases. Copying content from Document editor component and pasting outside will work properly in both cases.

## Paste with formatting

Document Editor provides support to paste the system clipboard data with formatting. To enable clipboard paste with formatting options, set the `EnableLocalPaste` property in Document Editor to false and use this .NET Standard library [`Syncfusion.EJ2.WordEditor.AspNet.Core`](<https://www.nuget.org/packages/Syncfusion.EJ2.WordEditor.AspNet.Core/>) by the web API service implementation. This library helps you to paste the system clipboard data with formatting.

You can paste your system clipboard data in the following ways:
* **Keep Source Formatting** This option retains the character styles and direct formatting applied to the copied text. Direct formatting includes characteristics such as font size, italics, or other formatting that is not included in the paragraph style.
* **Match Destination Formatting** This option discards most of the formatting applied directly to the copied text, but it retains the formatting applied for emphasis, such as bold and italic when it is applied to only a portion of the selection. The text takes on the style characteristics of the paragraph where it is pasted. The text also takes on any direct formatting or character style properties of text that immediately precedes the cursor when the text is pasted.
* **Text Only** This option discards all formatting and non-text elements such as pictures or tables. The text takes on the style characteristics of the paragraph where it is pasted and takes on any direct formatting or character style properties of text that immediately precedes the cursor when the text is pasted. Graphical elements are discarded and tables are converted to a series of paragraphs.

This paste option appears as follows.

![Image](images/paste.png)

## See Also

* [Keyboard shortcuts](../../document-editor/keyboard-shortcut/)
