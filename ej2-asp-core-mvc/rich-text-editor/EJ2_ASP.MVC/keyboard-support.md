---
layout: post
title: Keyboard Support in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Keyboard Support in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Keyboard Support
publishingplatform: ##Platform_Name##
documentation: ug
---


# Keyboard Support

The editor has full keyboard accessibility that includes shortcuts to open and other actions with toolbar items, drop-down lists, and dialogs.

## HTML Formation Shortcut Key

You can use the following key shortcuts when the Rich Text Editor renders with HTML edit mode.

| Actions | Keyboard shortcuts |
|----------------|---------|
| Toolbar focus | <kbd>Alt</kbd> + <kbd>f10</kbd> |
| Insert link | <kbd>Ctrl</kbd> + <kbd>k</kbd> |
| Insert image | <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>i</kbd> |
| Insert audio | <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>a</kbd> |
| Insert video | <kbd>Ctrl</kbd> + <kbd>Alt</kbd> + <kbd>v</kbd> |
| Insert table | <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>e</kbd> |
| Undo | <kbd>Ctrl</kbd> + <kbd>z</kbd> |
| Redo | <kbd>Ctrl</kbd> + <kbd>y</kbd> |
| Copy | <kbd>Ctrl</kbd> + <kbd>c</kbd> |
| Cut | <kbd>Ctrl</kbd> + <kbd>x</kbd> |
| Paste| <kbd>Ctrl</kbd> + <kbd>v</kbd> |
| Bold| <kbd>Ctrl</kbd> + <kbd>b</kbd> |
| Italic| <kbd>Ctrl</kbd> + <kbd>i</kbd> |
| Underline| <kbd>Ctrl</kbd> + <kbd>u</kbd> |
| Strikethrough| <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>s</kbd> |
| Inline Code | <kbd>Ctrl</kbd> + <kbd>`</kbd> |
| Uppercase| <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>u</kbd> |
| Lowercase| <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>l</kbd> |
| Superscript| <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>=</kbd> |
| Subscript| <kbd>Ctrl</kbd> + <kbd>=</kbd> |
| Indents| <kbd>Ctrl</kbd> + <kbd>]</kbd> |
| Outdents| <kbd>Ctrl</kbd> + <kbd>[</kbd> |
| HTML source | <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>h</kbd> |
| Fullscreen| <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>f</kbd> |
| Exit Fullscreen| <kbd>Esc</kbd> |
| Justify center| <kbd>Ctrl</kbd> + <kbd>e</kbd> |
| Justify full | <kbd>Ctrl</kbd> + <kbd>j</kbd> |
| Justify left | <kbd>Ctrl</kbd> + <kbd>l</kbd> |
| Justify right | <kbd>Ctrl</kbd> + <kbd>r</kbd> |
| Clear format | <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>r</kbd> |
| Ordered list | <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>o</kbd> |
| Unordered list | <kbd>Ctrl</kbd> + <kbd>Alt</kbd> + <kbd>o</kbd> |
| Format Painter Copy| <kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>c</kbd> |
| Format Painter Paste| <kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>v</kbd> |
| Format Painter Escape | <kbd>Esc</kbd> |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/html-keyboard/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/html-keyboard/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/html-keyboard/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/html-keyboard/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Markdown Formation Shortcut Key

You can use the following key shortcuts when the Rich Text Editor renders with Markdown edit mode.

| Actions | Keyboard shortcuts |
|----------------|---------|
| Toolbar focus| <kbd>Alt</kbd> + <kbd>f10</kbd> |
| Insert link| <kbd>Ctrl</kbd> + <kbd>k</kbd> |
| Insert image| <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>i</kbd> |
| Insert table| <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>e</kbd> |
| Undo| <kbd>Ctrl</kbd> + <kbd>z</kbd> |
| Redo| <kbd>Ctrl</kbd> + <kbd>y</kbd> |
| Copy| <kbd>Ctrl</kbd> + <kbd>c</kbd> |
| Cut| <kbd>Ctrl</kbd> + <kbd>x</kbd> |
| Paste| <kbd>Ctrl</kbd> + <kbd>v</kbd> |
| Bold| <kbd>Ctrl</kbd> + <kbd>b</kbd> |
| Italic| <kbd>Ctrl</kbd> + <kbd>i</kbd> |
| Strikethrough| <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>s</kbd> |
| Uppercase| <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>u</kbd> |
| Lowercase| <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>l</kbd> |
| Superscript| <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>=</kbd> |
| Subscript| <kbd>Ctrl</kbd> + <kbd>=</kbd> |
| Fullscreen| <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>f</kbd> |
| Ordered list| <kbd>Ctrl</kbd> + <kbd>Shift</kbd> + <kbd>o</kbd> |
| Unordered list| <kbd>Ctrl</kbd> + <kbd>Alt</kbd> + <kbd>o</kbd> |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/md-keyboard/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/md-keyboard/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/md-keyboard/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/md-keyboard/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom Key Config

Customize the key config for the keyboard interaction of Rich Text Editor, using the [`KeyConfig`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_KeyConfig) property.

In the following sample, customize the bold, italic, underline toolbar action with <kbd>`ctrl`</kbd> + <kbd>`alt`</kbd> + <kbd>`b`</kbd>, <kbd>`ctrl`</kbd> + <kbd>`alt`</kbd> + <kbd>`i`</kbd> and <kbd>`ctrl`</kbd> + <kbd>`alt`</kbd> + <kbd>`u`</kbd> respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-key/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-key/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-key/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-key/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Globalization](./globalization/)
* [Accessibility](./accessibility/)
* [How to customize the saving operation](./how-to/save/)