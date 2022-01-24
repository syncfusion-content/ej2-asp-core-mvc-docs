---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Add Google Fonts of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Add Google Fonts
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add Google fonts

To use web fonts in Rich Text Editor, it is not needed for the web fonts to be present in local machine. To add the web fonts to Rich Text Editor, we need to refer the web font links and add the font names in the [`fontFamily`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontFamily) property.

{% aspTab template="rich-text-editor/how-to/google-webfonts", sourceFiles="controller.cs" %}

{% endaspTab %}

The below font style links are referred in the page.

```typescript

<link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto">
<link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Great+Vibes">

```

> In the above sample, you can see that we have added two Google web fonts (`Roboto` and `Great vibes`) to `Rich Text Editor`.
