---
title: "Scrolling"
component: "DocumentEditor"
description: "Learn scrolling and zooming can be customized in ASP.NET CORE document editor."
---

# Scrolling

The Document editor renders the document as page by page. You can scroll through the pages by mouse wheel or touch interactions. You can also scroll through the page by using ‘scrollToPage()’ method of document editor instance. Refer to the following code example.

{% aspTab template="document-editor/scrolling-page", sourceFiles="document-editor.cs" %}

{% endaspTab %}

> Calling this method brings the specified page into view but doesn’t move selection. Hence this method will work by default. That is, it works even if selection is not enabled.

In case, if you wish to move the selection to any page in document editor and bring it into view, you can use ‘goToPage()’ method of selection instance. Refer to the following code example.

{% aspTab template="document-editor/scrolling-goto-page", sourceFiles="document-editor.cs" %}

{% endaspTab %}

## Zooming

You can scale the contents in document editor ranging from 10% to 500% of the actual size. You can achieve this using mouse or touch interactions. You can also use ‘zoomFactor’ property of document editor instance. The value can be specified in a range from 0.1 to 5. Refer to the following code example.

{% aspTab template="document-editor/scrolling-zooming" %}

{% endaspTab %}

## Page Fit Type

Apart from specifying the zoom factor as value, the Document editor provides option to specify page fit options such as fit to full page or fit to page width. You can set this option using ‘fitPage’ method of document editor instance. Refer to the following code example.

{% aspTab template="document-editor/scrolling-page-fit" %}

{% endaspTab %}

## Zoom option using UI

The following code example shows how to provide zoom options in document editor.

{% aspTab template="document-editor/scrolling-status-bar", sourceFiles="document-editor.cs" %}

{% endaspTab %}