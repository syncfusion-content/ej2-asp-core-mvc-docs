---
title: "Rich Text Editor How To Section"
component: "Rich Text Editor"
description: "This section for Syncfusion ASP.NET Rich Text Editor control explains the addition of Google web fonts to the `fontFamily`."
---

# Add Google fonts

To use web fonts in Rich Text Editor, it is not needed for the web fonts to be present in local machine. To add the web fonts to Rich Text Editor, we need to refer the web font links and add the font names in the [`FontFamily`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontFamily) property.

{% aspTab template="rich-text-editor/how-to/google-webfonts", sourceFiles="controller.cs" %}

{% endaspTab %}

The below font style links are referred in the page.

```typescript

<link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Roboto">
<link rel="stylesheet" href="http://fonts.googleapis.com/css?family=Great+Vibes">

```

> In the above sample, you can see that we have added two Google web fonts (`Roboto` and `Great vibes`) to `Rich Text Editor`.
