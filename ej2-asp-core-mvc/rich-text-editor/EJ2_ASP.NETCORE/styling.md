---
layout: post
title: Styling in ##Platform_Name## Rich Text Editor Component | Syncfusion
description: Learn all about Styling in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Styling
publishingplatform: ##Platform_Name##
documentation: ug
---


# Styling in ##Platform_Name## Rich Text Editor component

## Font Name and Font Size

By default, the Rich Text Editor initializes with the font name and font size set to "Default." This configuration means that the editor will inherit the font family and font size from its parent element in the application. If the content in the Rich Text Editor inherits its font properties from any parent element, these inherited values will appear as the default selections in the respective drop-down menus.

**Customizing font styles for text sections**

To apply a different font style to a specific section of the content:
1. Select the text that you want to customize.
2. In the editor’s toolbar, open the font name drop-down menu.
3. Choose the desired font style to apply it to the selected text.
4. Similarly, you can change the font size by selecting the desired size from the font size drop-down menu.

This will update the font style and size for the highlighted section of text, allowing customization within the content of the Rich Text Editor.

### FontName DropDowns

The following table lists the default font name and width of the [`fontFamily`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontFamily) dropdown and the available list of font names.

| Default Key | Default Value |
|----------------|--------------------------------------|
| default | null |
|width | 72px|
| items |  { text: 'Default', value: '' },{ text: 'Segoe UI', value: 'Segoe UI' },{ text: 'Arial', value: 'Arial,Helvetica,sans-serif' },{ text: 'Courier New', value: 'Courier New,Courier,monospace' },{ text: 'Georgia', value: 'Georgia,serif' },{ text: 'Impact', value: 'Impact,Charcoal,sans-serif' },{ text: 'Lucida Console', value: 'Lucida Console,Monaco,monospace' },{ text: 'Tahoma', value: 'Tahoma,Geneva,sans-serif' },{ text: 'Times New Roman', value: 'Times New Roman,Times,serif' },{ text: 'Trebuchet MS', value: 'Trebuchet MS,Helvetica,sans-serif' },{ text: 'Verdana', value: 'Verdana,Geneva,sans-serif' }|

### FontSize DropDowns

The following table lists the default font size and width of the [`fontSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontSize) dropdown and the available list of font sizes.

| Default Key | Default Value |
|----------------|---------|
| default | null|
| width | 60px.|
| items | { text: 'Default', value: '' },{ text: '8 pt', value: '8pt' },{ text: '10 pt', value: '10pt' },{ text: '12 pt', value: '12pt' },{ text: '14 pt', value: '14pt' },{ text: '18 pt', value: '18pt' },{ text: '24 pt', value: '24pt' },{ text: '36 pt', value: '36pt' }.|

The below sample demonstrate the option to add the font name and font size tools to the toolbar as well as modify the default `width` of the tools.





## Custom Fonts and Size

The Rich Text Editor provides custom fonts and sizes with the existing list.

If you want to add additional font names and font sizes to font drop-down, pass the font information as JSON data to the items field of [`fontSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontSize) and [`fontFamily`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontFamily) property.




## Font and background color

If you want to apply font color or background color for a selected content of Rich Text Editor you can use font color and background color tools.

The Rich Text Editor provides customs font color and background color with the existing list through the `colorCode` field of [`fontColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontColor) and [`backgroundColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_BackgroundColor).

fontColor and backgroundColor property has two mode `Picker` and `Palette`. Palette mode has predefined set of `colorCode` and in picker mode, we have provided with more colors. Through the `modeSwitcher`, you can switch between these two options.







## See Also

* [How to add google fonts to the font family](./how-to/add-google-fonts/)
* [How to customize the placeholder](./how-to/customize-placeholder-style/)
