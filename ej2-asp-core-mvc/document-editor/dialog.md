---
layout: post
title: Dialog in ##Platform_Name## Document Editor Component
description: Learn here all about Dialog in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---


# Dialog

Documenteditor provides dialog support to major operations such as insert or edit hyperlink, formatting text, paragraph, style, list and table properties.

## Font Dialog

Font dialog allows you to modify all text properties for selected contents at once such as bold, italic, underline, font size, font color, strikethrough, subscript and superscript.

>To enable font dialog for a document editor instance, set ‘enableFontDialog’ to true.

Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/dialog/document-editor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Document-editor.cs" %}
{% include code-snippet/document-editor/dialog/document-editor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Paragraph dialog

This dialog allows modifying the paragraph formatting for selection at once such as text alignment, indentation, and spacing.

To open this dialog, refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/paragraph-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Paragraph-dialog.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/paragraph-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Paragraph-dialog.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Table dialog

This dialog allows creating and inserting a table at cursor position by specifying the required number of rows and columns.

To open this dialog, refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/table-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Table-dialog.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/table-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Table-dialog.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Bookmark dialog

This dialog allows you to perform the following operations:

* View all bookmarks.
* Navigate to a bookmark.
* Create a bookmark at current selection.
* Delete an existing bookmark.
To open this dialog, refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/bookmark-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bookmark-dialog.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/bookmark-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bookmark-dialog.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Hyperlink dialog

This dialog allows editing or inserting a hyperlink at cursor position.

To open this dialog, refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/hyperlink-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Hyperlink-dialog.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/hyperlink-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Hyperlink-dialog.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Table of contents dialog

This dialog allows creating and inserting table of contents at cursor position. If the table of contents already exists at cursor position, you can customize its properties.

To open this dialog, refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/table-of-contents-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Table-of-contents-dialog.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/table-of-contents-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Table-of-contents-dialog.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Styles Dialog

This dialog allows managing the styles in a document. It will display all the styles in the document with options to modify the properties of the existing style or create new style with the help of ‘Style dialog’. Refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/styles-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Styles-dialog.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/styles-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Styles-dialog.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Style dialog

You can directly use this dialog for modifying any existing style or add new style by providing the style name.

To open this dialog, refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/style-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Style-dialog.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/style-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Style-dialog.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## List dialog

This dialog allows creating a new list or modifying existing lists in the document.

To open this dialog, refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/list-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List-dialog.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/list-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List-dialog.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Borders and shading dialog

This dialog allows customizing the border style, border width, and background color of the table or selected cells.

To open this dialog, refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="Borders-and-shading-dialog.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Borders-and-shading-dialog.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Table options dialog

This dialog allows customizing the default cell margins and spacing between each cells of the selected table.

To open this dialog, refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/table-options-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Table-options-dialog.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/table-options-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Table-options-dialog.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Table properties dialog

This dialog allows customizing the table, row, and cell properties of the selected table.

To open this dialog, refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/table-properties-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Table-properties-dialog.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/table-properties-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Table-properties-dialog.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Page setup dialog

This dialog allows customizing margins, size, and layout options for pages of the section.

To open this dialog, refer to the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor/page-setup-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Page-setup-dialog.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor/page-setup-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Page-setup-dialog.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## See Also

* [Feature module](../../document-editor/feature-module/)
