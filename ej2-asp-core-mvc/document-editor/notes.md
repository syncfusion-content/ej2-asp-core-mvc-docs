---
layout: post
title: Notes in ##Platform_Name## Document Editor Component
description: Learn here all about notes in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Notes
publishingplatform: ##Platform_Name##
documentation: ug
---


# Insert footnote endnote

DocumentEditorContainer component provides support for inserting footnotes and endnotes through the in-built toolbar.

![Insert footnote endnote](images/note-toolbar.jpg)

The footnotes and endnotes are both ways of adding extra bits of information to your writing outside of the main text. You can use footnotes and endnotes to add side comments to your work or to place other publications like books, articles, or websites.

## Insert footnotes

Document editor exposes an API to insert footnotes at cursor position programmatically or can be inserted to the end of selected text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/footnote/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/footnote/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/footnote/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/footnote/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Insert endnotes

Document editor exposes an API to insert endnotes at cursor position programmatically or can be inserted to the end of selected text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/endnote/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/endnote/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/endnote/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/endnote/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Update or edit footnotes and endnotes

You can update or edit the footnotes and endnotes using the built-in context menu shown up by right-clicking it. The footnote endnote dialog box popup and you can customize the number format and start at.

![Update or edit footnotes and endnotes](images/notes-option.jpg)
