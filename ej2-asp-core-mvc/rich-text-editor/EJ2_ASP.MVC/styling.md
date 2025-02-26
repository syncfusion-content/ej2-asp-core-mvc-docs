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

The following table lists the default font name and width of the [`FontFamily`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontFamily) dropdown and the available list of font names.

| Default Key | Default Value |
|----------------|--------------------------------------|
| default | null |
|width | 72px|
| items | { text: 'Default', value: '' },{ text: 'Segoe UI', value: 'Segoe UI' },{ text: 'Arial', value: 'Arial,Helvetica,sans-serif' },{ text: 'Courier New', value: 'Courier New,Courier,monospace' },{ text: 'Georgia', value: 'Georgia,serif' },{ text: 'Impact', value: 'Impact,Charcoal,sans-serif' },{ text: 'Lucida Console', value: 'Lucida Console,Monaco,monospace' },{ text: 'Tahoma', value: 'Tahoma,Geneva,sans-serif' },{ text: 'Times New Roman', value: 'Times New Roman,Times,serif' },{ text: 'Trebuchet MS', value: 'Trebuchet MS,Helvetica,sans-serif' },{ text: 'Verdana', value: 'Verdana,Geneva,sans-serif' }|

### FontSize DropDowns

The following table lists the default font size and width of the [`FontSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontSize) dropdown and the available list of font sizes.

| Default Key | Default Value |
|----------------|---------|
| default | null |
| width | 60px.|
| items | { text: 'Default', value: '' },{ text: '8 pt', value: '8pt' },{ text: '10 pt', value: '10pt' },{ text: '12 pt', value: '12pt' },{ text: '14 pt', value: '14pt' },{ text: '18 pt', value: '18pt' },{ text: '24 pt', value: '24pt' },{ text: '36 pt', value: '36pt' }.|

The below sample demonstrate the option to add the font name and font size tools to the toolbar as well as modify the default `width` of the tools.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/styling/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/styling/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/styling/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/styling/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom Fonts and Size

The Rich Text Editor provides custom fonts and sizes with the existing list.

If you want to add additional font names and font sizes to font drop-down, pass the font information as JSON data to the items field of [`FontSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontSize) and [`FontFamily`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontFamily) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-style/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-style/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-style/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-style/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Font and background color

If you want to apply font color or background color for a selected content of Rich Text Editor you can use font color and background color tools.

The Rich Text Editor provides customs font color and background color with the existing list through the `colorCode` field of [`FontColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_FontColor) and [`BackgroundColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_BackgroundColor).

`FontColor` and `BackgroundColor` property has two mode `Picker` and `Palette`. Palette mode has predefined set of `colorCode` and in picker mode, we have provided with more colors. Through `modeSwitcher`, you can switch between these two options.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-font/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-font/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-font/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-font/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Editor content styles

By default, the content styles of the Rich Text Editor are not returned when retrieving HTML value from the editor. So, the styles are not applied when using HTML values outside of the editor. To get the styles to the Rich Text Editor’s content for your application, copy and use the styles listed below directly in your application. They are used in the UI elements of the Rich Text Editor.

N> Make sure to add a CSS class ‘e-rte-content’ to the content container.

```css

.e-rte-content p {
  margin: 0 0 10px;
  margin-bottom: 10px;
}

.e-rte-content li {
  margin-bottom: 10px;
}

.e-rte-content h1 {
  font-size: 2.17em;
  font-weight: 400;
  line-height: 1;
  margin: 10px 0;
}

.e-rte-content h2 {
  font-size: 1.74em;
  font-weight: 400;
  margin: 10px 0;
}

.e-rte-content h3 {
  font-size: 1.31em;
  font-weight: 400;
  margin: 10px 0;
}

.e-rte-content h4 {
  font-size: 1em;
  font-weight: 400;
  margin: 0;
}

.e-rte-content h5 {
  font-size: 00.8em;
  font-weight: 400;
  margin: 0;
}

.e-rte-content h6 {
  font-size: 00.65em;
  font-weight: 400;
  margin: 0;
}

.e-rte-content blockquote {
  margin: 10px 0;
  margin-left: 0;
  padding-left: 5px;
}

.e-rte-content pre {
  background-color: inherit;
  border: 0;
  border-radius: 0;
  color: #333;
  font-size: inherit;
  line-height: inherit;
  margin: 0 0 10px;
  overflow: visible;
  padding: 0;
  white-space: pre-wrap;
  word-break: inherit;
  word-wrap: break-word;
}

.e-rte-content strong, .e-rte-content b {
  font-weight: 700;
}

.e-rte-content a {
  text-decoration: none;
  -webkit-user-select: auto;
  -ms-user-select: auto;
  user-select: auto;
}

.e-rte-content a:hover {
  text-decoration: underline;
}

.e-rte-content h3 + h4,
.e-rte-content h4 + h5,
.e-rte-content h5 + h6 {
  margin-top: 00.6em;
}

.e-rte-content .e-rte-image.e-imgbreak {
  border: 0;
  cursor: pointer;
  display: block;
  float: none;
  margin: 5px auto;
  max-width: 100%;
  position: relative;
}

.e-rte-content .e-rte-image {
  border: 0;
  cursor: pointer;
  display: block;
  float: none;
  margin: auto;
  max-width: 100%;
  position: relative;
}

.e-rte-content .e-rte-image.e-imginline {
  display: inline-block;
  float: none;
  margin-left: 5px;
  margin-right: 5px;
  max-width: calc(100% - (2 * 5px));
  vertical-align: bottom;
}

.e-rte-content .e-rte-image.e-imgcenter {
  cursor: pointer;
  display: block;
  float: none;
  margin: 5px auto;
  max-width: 100%;
  position: relative;
}

.e-rte-content .e-rte-image.e-imgleft {
  float: left;
  margin: 0 5px 0 0;
  text-align: left;
}

.e-rte-content .e-rte-image.e-imgright {
  float: right;
  margin: 0 0 0 5px;
  text-align: right;
}

.e-rte-content .e-rte-img-caption {
  display: inline-block;
  margin: 5px auto;
  max-width: 100%;
  position: relative;
}

.e-rte-content .e-rte-img-caption.e-caption-inline {
  display: inline-block;
  margin: 5px auto;
  margin-left: 5px;
  margin-right: 5px;
  max-width: calc(100% - (2 * 5px));
  position: relative;
  text-align: center;
  vertical-align: bottom;
}

.e-rte-content .e-rte-img-caption.e-imgcenter {
  display: block;
}

.e-rte-content .e-rte-img-caption .e-rte-image.e-imgright,
.e-rte-content .e-rte-img-caption .e-rte-image.e-imgleft {
  float: none;
  margin: 0;
}

.e-rte-content .e-rte-table {
  border-collapse: collapse;
  empty-cells: show;
}

.e-rte-content .e-rte-table td,
.e-rte-content .e-rte-table th {
  border: 1px solid #bdbdbd;
  height: 20px;
  min-width: 20px;
  padding: 2px 5px;
  vertical-align: middle;
}

.e-rte-content .e-rte-table.e-dashed-border td,
.e-rte-content .e-rte-table.e-dashed-border th {
  border-style: dashed;
}

.e-rte-content .e-rte-img-caption .e-img-inner {
  box-sizing: border-box;
  display: block;
  font-size: 16px;
  font-weight: initial;
  margin: auto;
  opacity: .9;
  position: relative;
  text-align: center;
  width: 100%;
}

.e-rte-content .e-rte-img-caption .e-img-wrap {
  display: inline-block;
  margin: auto;
  padding: 0;
  width: 100%;
}

.e-rte-content blockquote {
  border-left: solid 2px #333;
}

.e-rte-content a {
  color: #2e2ef1;
}

.e-rte-content .e-rte-table th {
  background-color: #e0e0e0;
}

```

## See Also

* [How to add google fonts to the font family](./how-to/add-google-fonts)
* [How to customize the placeholder](./how-to/customize-placeholder-style)