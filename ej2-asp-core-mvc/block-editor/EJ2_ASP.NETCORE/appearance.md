---
layout: post
title: Appearance in ##Platform_Name## Block Editor Control | Syncfusion
description: Checkout and learn about appearance with Syncfusion Essential ##Platform_Name## BlockEditor control, its elements, and more details.
platform: ej2-asp-core-mvc
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Appearance in ##Platform_Name## Block Editor control

The Block Editor control provides various appearance customization options to match your application's design requirements. These properties allow you to control the visual styling, layout, and overall look and feel of the editor.

## Setting width and height

You can specify the width and height for the Block Editor control using the [width](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_Width) and [height](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_Height) properties.

```cshtml

<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor" height="80vh" width="100%"></ejs-blockeditor>
</div>

// Or with specific pixel values
<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor" height="500px" width="800px"></ejs-blockeditor>
</div>

```

## Setting readonly mode

You can utilize the [readonly](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_ReadOnly) property to control whether the editor is in read-only mode. When set to `true`, users cannot edit the content but can still view it.

```cshtml

<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor" readOnly="true"></ejs-blockeditor>
</div>

```

## Customization using CSS Class

You can use the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_CssClass) property to customize the appearance of the Block Editor control.

```cshtml

<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor" height="400px" width="600px" cssClass="custom-editor-theme"></ejs-blockeditor>
</div>

```

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/appearance/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Appearance.cs" %}
{% include code-snippet/block-editor/appearance/appearance.cs %}
{% endhighlight %}
{% endtabs %}

![Appearance](images/appearance.png)
