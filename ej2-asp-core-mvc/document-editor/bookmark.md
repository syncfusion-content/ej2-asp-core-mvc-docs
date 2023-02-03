---
layout: post
title: Bookmark in ##Platform_Name## Document Editor Component
description: Learn here all about Bookmark in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Bookmark
publishingplatform: ##Platform_Name##
documentation: ug
---


# Bookmarks

Bookmark is a powerful tool that helps to mark a place in the document to find again easily. You can enter many bookmarks in the document and give each one a unique name to identify easily.

Document editor provides built-in dialog to add, delete, and navigate bookmarks within the document. To add a bookmark, select a portion of text in the document. After that, jump to the location or add links to it within the document using built-in hyperlink dialog. You can also delete bookmarks from a document.

N>Bookmark names need to begin with a letter. They can include both numbers and letters, but not spaces. To separate the words, use an underscore.
N>Bookmark names starting with an underscore are called hidden bookmarks. For example, bookmarks generated for table of contents.

## Add bookmark

Using [`insertBookmark`] method, Bookmark can be added to the selected text.

```csharp
container.documentEditor.editor.insertBookmark("Bookmark1");
```

## Select Bookmark

You can select the bookmark in the document using [`selectBookmark`] method by providing Bookmark name to select as shown in the following code snippet.

```csharp
container.documentEditor.selection.selectBookmark("Bookmark1");
```

## Delete Bookmark

You can delete bookmark in the document using [`deleteBookmark`] method as shown in the following code snippet.

```csharp
container.documentEditor.editor.deleteBookmark("Bookmark1");
```

## Get Bookmark

You can get all the bookmarks in the document using [`getBookmarks`] method as shown in the following code snippet.

```csharp
container.documentEditor.selection.getBookmarks(false);
```

N> Parameter denotes is include hidden bookmarks. If false, ignore hidden bookmark.

## Bookmark Dialog

The following example shows how to open bookmark dialog in Document Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/bookmark-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/bookmark-dialog/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/bookmark-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/bookmark-dialog/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Feature modules](../document-editor/feature-module/)
* [Bookmark dialog](../document-editor/dialog/#bookmark-dialog)
