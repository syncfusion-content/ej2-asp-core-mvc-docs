---
layout: post
title: Refer Custom Font in ##Platform_Name## Document Editor Component
description: Learn here to Refer Custom Font in Document from the Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS2 and more.
platform: ej2-asp-core-mvc
control: Refer Custom Font
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to Refer Custom Font in ##Platform_Name## Document Editor

## To Refer a External Custom Font

Syncfusion<sup style="font-size:70%">&reg;</sup> Document Editor renders text by drawing on a canvas, which requires the system-installed fonts for proper display. If a font is unavailable on the system, the document is rendered using a default font.

To use an external font for rendering, you need to include the desired font by referencing it from a local path.

>**Note :** The external font must be referenced before the document loads. Because the document editor won't apply the external font to the existing opened document in the editor and Adding an external font only reflects in rendering. It will not reflect the same referred external font in the exported document (like .docx). So, adding an external font is only for rendering purposes.

### **How to use the external font by referencing it from a local path**

You can use the external font by referencing it from a local path. Please download the font from the provided [URL](https://www.onlinewebfonts.com/download/8e84296a186f1941f28261b7dc98a78b) and reference it locally.

Using `setCustomFonts` method, external font can be referred.


```csharp
container.documentEditor.setCustomFonts([
	{
	   fontFamily: 'Poppins',
	   src: "url('https://db.onlinewebfonts.com/t/2f86dc938a55788d3416b876b43a116a.ttf')",
	 },
	{
	   fontFamily: 'Poppins Medium',
	   src: "url('https://db.onlinewebfonts.com/t/0c28006f19928dfd146027cfd7024ca0.ttf')",
	 },
	]);
```
