---
layout: post
title: Markdown in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Markdown in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: Markdown
publishingplatform: ##Platform_Name##
documentation: ug
---


# Markdown

In Rich Text Editor, you click the toolbar buttons to format the words and the changes are visible immediately.

Markdown is not like that. When you format the word in Markdown format, you need to add Markdown syntax to the word to indicate which words and phrases should look different from each other
Rich Text Editor supports markdown editing when the [`EditorMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_EditorMode_Syncfusion_EJ2_RichTextEditor_EditorMode_) set as `Markdown` and using both *keyboard interaction* and *toolbar action*, you can apply the formatting to text.

## Supported Commands

The ASP MVC Markdown editor supports the following commands to format the markdown content:

|Commands|Syntax| Description |
|--------|------------------------------------------|------------|
| Bold | Sample content for `**`bold text`**`. | For bold, add `**` or `__` to front and back of the text. | For order list, precede each line with a number. |
| Italic | Sample content for `*`Italic text`*`. | For Italic, add `*` or `_` to front and back of the text. |
| Bold and Italics | Sample content for `***`bold and Italic text`***`. | For bold and Italics, add `***` to the front and back of the text. |
| Heading 1 | `#` Heading 1 content | For heading 1, add `#` to start of the line. |
| Heading 2 | `##` Heading 2 content | For heading 2, add `##` to start of the line. |
| Heading 3 | `###` Heading 3 content | For heading 3, add `###` to start of the line. |
| Heading 4 | `####` Heading 4 content | For heading 4, add `####` to start of the line. |
| Heading 5 | `#####` Heading 5 content | For heading 5, add `#####` to start of the line. |
| Heading 6 | `######` Heading 6 content | For heading 6, add `######` to start of the line. |
| Line Break | First line `<br>`Second line | For line break, press enter two times (or) add `<br>` in between the first and the second line. |
| Blockquotes | `>` Blockquotes text | For blockquotes, add `>` to start of the line. |
| Strike Through | Sample content for `~~`strike through text`~~`. | For strike through, add `~~` to front and back of the text. |
| Code (Single line) | \`Single line code\` | For single line code, add \` to front and back of the text. |
| Code block (Multi Line) | \`\`\`<br>Multi line code text<br>Multi line code text<br>\`\`\` | For multiple line code, add \`\`\` in the new line before and after the content. |
| Subscript | `<sub>`Subscript text`</sub>` | For subscript, add `<sub>` to the front and `</sub>` to the back of the text. |
| Superscript | `<sup>`Superscript text`</sup>` | For superscript, add `<sup>` to the front and `</sup>` to the back of the text. |
| Ordered List | `1.` First<br>`1.` Second | For ordered list, preceding one or more lines of text with `1.` |
| Unordered List | `*` First<br>`*` second | For unordered list, preceding one or more lines of text with `*`. |
| Links | **Link text without title text**<br>`[` Link text `](`URL`)`<br> **Link text with title text**<br>`[` Link text `](`URL , “title text”`)` | Create an inline link by wrapping link text in brackets `[ ]`, and then wrapping the URL as first parameter and title as second parameter in the parentheses `()`.<br>**Note:** The title text is optional, if needed it can be given manually.|
| Table | `|` Heading 1 `|` Heading 2 `|`<br>`|---------|---------|`<br>`|` Col A1 `|` Col A2 `|`<br>`|` Col B1 `|` Col B2 `|` | Create a table using the pipes and underscores as given in the syntax to create 2 x 2 table. |
| Horizontal Line | `***` (three asterix in new line)<br>(or)<br>`___` (three underscores in new line) | For horizontal line, add `***` or `___` to the start of the new line. |
| Image | `![](`URL path`)` | Create an image by wrapping the image source in parentheses `()`. |
| Image with alternate text | `![` alternate text `](`URL path`)` | Create an image with alternate text by wrapping an alternative text in brackets `[]`, and then link of the image source in parentheses `()`.<br>**Note:** When inserting the image using toolbar, the alternate text cannot be provided that needs to be given manually. |
| Escape tick marks supported | Sample text content with `**`bold and `**`not bold`**` text can be in the same line.`**` | In the syntax, the whole content is made as bold where the content `not bold` can be made as normal text by adding the bold syntax to the start and end of the respective text. Likewise you can do the same for various inline commands. |
| Escape Character | `\(`any syntax`)` | Escape any markdown syntax by prefix `\` to the syntax.<br>Example:<br>`\**`Bold text`**`|
| HTML Entities | Copyright: &copy; - `&copy;` <br>Trade mark: &trade; - `&trade;`<br>Registered: &reg; - `&reg;`<br>Ampersand: &amp; - `&amp;`<br>Less than: &lt; - `&lt;`<br>Greater than: &gt; - `&gt;` | For HTML entities, add & and ; to the front and back of the respective entities. |

> The above listed commands alone are supported in Syncfusion Markdown editor. For other unsupported commands, you can achieve using the HTML tags in Markdown editor. The foot notes, definitions, math, and check list markdown syntax are also not supported.

## Markdown to HTML

The Rich Text Editor allows you to preview markdown changes immediately using preview. The third-party library [`Marked`](https://marked.js.org/#/README.md#README.md) is used in this sample to convert markdown into HTML content.

This sample demonstrates how to preview markdown changes in Rich Text Editor. Type or edit the display text and apply format to view the preview of markdown.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/markdown/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/markdown/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/markdown/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/markdown/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Table

Rich Text Editor allows to insert Markdown table in edit panel with 2 X 2 rows and columns along with the heading.
To use table tool, add the `CreateTable` item in toolbar items.

### Insert Table

To insert the table in Rich Text Editor, click the `table` toolbar option to insert the table into Rich Text Editor content and this is the default way in all the devices.
Please refer the below sample and code snippets to add the table in Markdown editor

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/markdown-table/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/markdown-table/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/markdown-table/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/markdown-table/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Changing Table Constants

The Markdown table constants can be changed for the table heading and the column names.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/markdown-table-constants/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/markdown-table-constants/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/markdown-table-constants/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/markdown-table-constants/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [How to integrate the third party library](./third-party-integration/)
* [How to change the editor mode](./formation/#markdown-editor)