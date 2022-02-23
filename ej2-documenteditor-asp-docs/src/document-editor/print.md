---
title: "Print"
component: "DocumentEditor"
description: "Learn how to print the document in ASP.NET CORE document editor and customize page size, margins, and more during print."
---

# Print

To print the document, use the `print` method from document editor instance.

Refer to the following example for showing a document and print it.

{% aspTab template="document-editor/print-sfdt", sourceFiles="document-editor.cs" %}

{% endaspTab %}

Refer to the following example for creating a document and print it.

{% aspTab template="document-editor/print", sourceFiles="document-editor.cs" %}

{% endaspTab %}

> To enable print for a document editor instance, set enablePrint as true.

## Improve print quality

Document editor provides an option to improve the print quality using [`printDevicePixelRatio`](../api/document-editor/documentEditorSettingsModel/#printdevicepixelratio) in Document editor settings. Document editor using canvas approach to render content. Then, canvas are converted to image and it process for print. Using printDevicePixelRatio API, you can increase the image quality based on your requirement.

The following example code illustrates how to improve the print quality in Document editor container.

{% aspTab template="document-editor-container/print" %}

{% endaspTab %}

>Note: By default, printDevicePixelRatio value is 1.

## Print using window object

You can print the document in document editor by passing the window instance. This is useful to implement print in third party frameworks such as electron, where the window instance will not be available. Refer to the following example.

{% aspTab template="document-editor/print-window" %}

{% endaspTab %}

## Page setup

Some of the print options cannot be configured using JavaScript. Refer to the following links to learn more about the browser page setup:

* [`Chrome`](https://support.google.com/chrome/answer/1069693?hl=en&visit_id=1-636335333734668335-3165046395&rd=1)
* [`Firefox`](https://support.mozilla.org/en-US/kb/how-print-web-pages-firefox)

However, you can customize margins, paper, and layout options by modifying the section format properties using page setup dialog

{% aspTab template="document-editor/print-dialog" %}

{% endaspTab %}

By customizing margins, papers, and layouts, the layout of the document will be changed in document editor. To modify these options during print operation, serialize the document as SFDT using the `serialize` method in document editor instance and open the SFDT data in another instance of document editor in separate window.

The following example shows how to customize layout options only for printing.

{% aspTab template="document-editor/print-doc", sourceFiles="document-editor.cs" %}

{% endaspTab %}

## See Also

* [Feature modules](../../document-editor/feature-module/)
* [Page Setup dialog](../../document-editor/dialog/#page-setup-dialog)
