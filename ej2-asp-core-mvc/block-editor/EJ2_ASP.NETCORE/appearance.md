---
layout: post
title: Appearance in ##Platform_Name## Block Editor Control | Syncfusion
description: Checkout and learn about Blocks in Syncfusion Essential ##Platform_Name## Block Editor control, its elements, and more.
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
    <ejs-blockeditor id="block-editor" height="80vh" width="100%"></ejs-blockeditor>
</div>

// Or with specific pixel values
<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor" height="500px" width="800px"></ejs-blockeditor>
</div>

```

## Setting readonly mode

You can utilize the `readonly` property to control whether the editor is in read-only mode. When set to `true`, users cannot edit the content but can still view it.

```cshtml

<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor" readOnly="true"></ejs-blockeditor>
</div>

```

## Customization using CSS Class

You can use the `cssClass` property to customize the appearance of the Block Editor control.

```cshtml

<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor" height="400px" width="600px" cssClass="custom-editor-theme"></ejs-blockeditor>
</div>

<style>
/* Custom CSS for custom theme */
.custom-editor-theme {
    border: 2px solid #007acc;
    border-radius: 8px;
    box-shadow: 0 4px 12px rgba(0, 122, 204, 0.15);
}

.custom-editor-theme .e-block {
    margin-bottom: 8px;
}

.custom-editor-theme .e-block:hover {
    background-color: #b5b5b5;
    transition: ease-in-out 0.5s;
}

.custom-editor-theme .e-block [contenteditable=true]:empty::before {
    color: #6c757d;
    font-style: italic;
}
</style>

```
