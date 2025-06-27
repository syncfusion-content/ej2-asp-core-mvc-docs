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

You can specify the width and height for the Block Editor control using the `width` and `height` properties.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Width("100%").Height("80vh").Render()
</div>

// Or with specific pixel values
<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").Width("800px").Height("500px").Render()
</div>

```

## Setting readonly mode

You can utilize the `readonly` property to control whether the editor is in read-only mode. When set to `true`, users cannot edit the content but can still view it.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").ReadOnly(true).Render()
</div>

```

## Customization using CSS Class

You can use the `cssClass` property to customize the appearance of the Block Editor control.

```cshtml

<div id='blockeditor-container'>
    @Html.EJS().BlockEditor("block-editor").CssClass("custom-editor-theme").Width("600px").Height("400px").Render()
</div>

```

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/appearance/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Appearance.cs" %}
{% include code-snippet/block-editor/appearance/appearance.cs %}
{% endhighlight %}
{% endtabs %}

![Appearance](images/appearance.png)
