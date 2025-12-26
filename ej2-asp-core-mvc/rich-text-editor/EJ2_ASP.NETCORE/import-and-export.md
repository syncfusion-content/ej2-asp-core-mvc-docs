---
layout: post
title: Import/Export in ##Platform_Name## Rich Text Editor Control | Syncfusion
description: Learn here all about Import/Export in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Import/Export
publishingplatform: ##Platform_Name##
documentation: ug
---

# Content Import/Export in ##Platform_Name## Rich Text Editor Control

## Importing content from Microsoft Word

The Rich Text Editor provides functionality to import content directly from Microsoft Word documents, preserving the original formatting and structure. This feature ensures a smooth transition of content from Word to the editor, maintaining elements such as headings, lists, tables, and text styles.

To integrate an `ImportWord` option into the Rich Text Editor toolbar, you can add it as a custom toolbar [items](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) using the items property in toolbarSettings.

The following example illustrates how to set up the `ImportWord` in the Rich Text Editor to facilitate content importation from Word documents:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/import/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/import/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/import/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/import/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Secure importing with authentication

The Rich Text Editor provides functionality to import Word documents with authentication for secure importing.

The [wordImporting](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorWordImporting.html) event provides [UploadingEventArgs](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.inputs.uploader.html) for secure Word file import. Use `currentRequest` to add authentication headers and `customFormData` to include extra parameters in the POST body along with the uploaded file. On the server, read headers and form data from the request to validate and process the import securely.

The following example demonstrates how to configure `wordImporting` for secure importing:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/secureimport/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/secureimport/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/secureimport/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/secureimport/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Exporting content to PDF and Microsoft Word

The Rich Text Editor's export functionality allows users to convert their edited content into PDF or Word documents with a single click, preserving all text styles, images, tables, and other formatting elements.

You can add `ExportWord` and `ExportPdf` tools to the Rich Text Editor toolbar using the toolbarSettings [items](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

The following example demonstrates how to configure the `ExportWord` and `ExportPdf` tools in the Rich Text Editor, facilitating the export of content into Word or PDF documents:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/export/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/export/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/export/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/export/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Secure exporting with authentication

The Rich Text Editor provides functionality to export Word or PDF documents with authentication for secure exporting.

The [documentExporting](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorDocumentExporting.html) event provides `ExportingEventArgs` for secure export of Word or PDF files. Use `exportType` to identify the format, `currentRequest` to add authentication headers, and `customFormData` to send extra parameters in the POST body. On the server, read headers and custom data to validate and process the export securely.

The following example demonstrates how to configure `documentExporting` for secure exporting:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/secureexport/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/secureexport/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/secureexport/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/secureexport/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}