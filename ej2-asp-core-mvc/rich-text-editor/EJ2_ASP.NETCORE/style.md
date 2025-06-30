---
layout: post
title: Style in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Style in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Style
publishingplatform: ##Platform_Name##
documentation: ug
---

# Style Appearance Customization in the ##Platform_Name## Rich Text Editor Control

The content below outlines the CSS structure you can use to customize the appearance of the control according to your preferences.

## Customizing placeholder text

Use the following CSS to customize the default color in the Rich Text Editor's placeholder.

```CSS

.e-richtexteditor .e-rte-placeholder {
    color: blue;
    font-family: monospace;
}

```

## Customizing editor content

Use the following CSS to modify the default style of the Rich Text Editor's content area, including font properties, background, and text color.

```CSS
/* To change font family and font size */
.e-richtexteditor .e-rte-content .e-content,
.e-richtexteditor .e-source-content .e-content {
    font-size: 20px;
    font-family: Segoe ui;
}

/* To change font color and content background */
.e-richtexteditor .e-rte-content,
.e-richtexteditor .e-source-content {
    background: seashell;
    color: blue;
}
```

## Customizing editor toolbar

Use the following CSS to customize the default color in the Rich Text Editor's toolbar icon.


```CSS
/* To change font color for toolbar icon */
.e-richtexteditor .e-rte-toolbar .e-toolbar-item .e-icons,
.e-richtexteditor .e-rte-toolbar .e-toolbar-item .e-icons:active {
    color: red;
}

/* To change font color for toolbar button */
.e-toolbar .e-tbar-btn,
.e-toolbar .e-tbar-btn:active,
.e-toolbar .e-tbar-btn:hover {
    color: red;
}

/* To change font color for toolbar button in active state*/
.e-richtexteditor .e-rte-toolbar .e-toolbar-item .e-dropdown-btn.e-active .e-icons, .e-richtexteditor .e-rte-toolbar .e-toolbar-item .e-dropdown-btn.e-active .e-rte-dropdown-btn-text {
    color: red;
}

/* To change font color for expanded toolbar items */
.e-richtexteditor .e-rte-toolbar .e-toolbar-extended .e-toolbar-item .e-tbar-btn .e-icons,
.e-toolbar.e-extended-toolbar .e-toolbar-extended .e-toolbar-item .e-tbar-btn {
    color: red;
}
```

## Customizing character count display

Use the following CSS to customize the default color in the Rich Text Editor's character count.

```CSS
/* To change font color, font family, font size and opacity  */
.e-richtexteditor .e-rte-character-count {
    color: red;
    font-family: segoe ui;
    font-size: 18px;
    opacity: 00.54;
    padding-bottom: 2px;
    padding-right: 14px;
}
```

## Customizing border color

Use the following CSS to customize the border color in the Rich Text Editor's container.

```CSS

.e-richtexteditor .e-rte-container{
    border: 2px solid #454bc1;
    border-radius: 4px;
}

```

## Highlight the specific lines

Programmatically highlight a portion of the text in the editor by setting the background color. This can be achieved by applying a background style to the selected text using the Rich Text Editor's `executeCommand` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/highlight-specific-line/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/highlight-specific-line/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/highlight-specific-line/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/highlight-specific-line/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}