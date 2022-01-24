---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Deploy Document Editor Component For Mobile of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Deploy Document Editor Component For Mobile
publishingplatform: ##Platform_Name##
documentation: ug
---


# Deploy Document Editor component for Mobile

## Document editor component for Mobile

At present, Document editor component is not responsive for mobile, and we haven't ensured the editing functionalities in mobile browsers. Whereas it works properly as a document viewer in mobile browsers.

Hence, it is recommended to switch the Document editor component as read-only in mobile browsers. Also, invoke `fitPage` method with `FitPageWidth` parameter in document change event, such as to display one full page by adjusting the zoom factor.

The following example code illustrates how to deploy Document Editor component for Mobile.

{% aspTab template="document-editor/mobile-view" %}

{% endaspTab %}

>Note: You can use the `restrictEditing` in DocumentEditorContainer and `isReadOnly` in DocumentEditor based on your requirement to change component to read only mode.
