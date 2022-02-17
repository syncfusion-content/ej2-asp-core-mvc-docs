---
layout: post
title: Keyboard Support in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Keyboard Support in Syncfusion ##Platform_Name## Rich Text Editor component and more.
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
| Toolbar focus | <kbd>`alt`</kbd> + <kbd>`f10`</kbd> |
| Insert link | <kbd>`ctrl`</kbd> + <kbd>`k`</kbd> |
| Insert image | <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`i`</kbd> |
| Insert table | <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`e`</kbd> |
| Undo | <kbd>`ctrl`</kbd> + <kbd>`z`</kbd> |
| Redo | <kbd>`ctrl`</kbd> + <kbd>`y`</kbd> |
| Copy | <kbd>`ctrl`</kbd> + <kbd>`c`</kbd> |
| Cut | <kbd>`ctrl`</kbd> + <kbd>`x`</kbd> |
| Paste| <kbd>`ctrl`</kbd> + <kbd>`v`</kbd> |
| Bold| <kbd>`ctrl`</kbd> + <kbd>`b`</kbd> |
| Italic| <kbd>`ctrl`</kbd> + <kbd>`i`</kbd> |
| Underline| <kbd>`ctrl`</kbd> + <kbd>`u`</kbd> |
| Strikethrough| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`s`</kbd> |
| Uppercase| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`u`</kbd> |
| Lowercase| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`l`</kbd> |
| Superscript| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`=`</kbd> |
| Subscript| <kbd>`ctrl`</kbd> + <kbd>`=`</kbd> |
| Indents| <kbd>`ctrl`</kbd> + <kbd>`]`</kbd> |
| Outdents| <kbd>`ctrl`</kbd> + <kbd>`[`</kbd> |
| HTML source | <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`h`</kbd> |
| Fullscreen| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`f`</kbd> |
| Exit Fullscreen| <kbd>`Esc`</kbd> |
| Decrease font size| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`<`</kbd> |
| Decrease font size| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`>`</kbd> |
| Justify center| <kbd>`ctrl`</kbd> + <kbd>`e`</kbd> |
| Justify full | <kbd>`ctrl`</kbd> + <kbd>`j`</kbd> |
| Justify left | <kbd>`ctrl`</kbd> + <kbd>`l`</kbd> |
| Justify right | <kbd>`ctrl`</kbd> + <kbd>`r`</kbd> |
| Clear format | <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`r`</kbd> |
| Ordered list | <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`o`</kbd> |
| Unordered list | <kbd>`ctrl`</kbd> + <kbd>`alt`</kbd> + <kbd>`o`</kbd> |

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
| Toolbar focus|  <kbd>`alt`</kbd> + <kbd>`f10`</kbd> |
| Insert link| <kbd>`ctrl`</kbd> + <kbd>`k`</kbd> |
| Insert image| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`i`</kbd> |
| Insert table| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`e`</kbd> |
| Undo| <kbd>`ctrl`</kbd> + <kbd>`z`</kbd> |
| Redo| <kbd>`ctrl`</kbd> + <kbd>`y`</kbd> |
| Copy| <kbd>`ctrl`</kbd> + <kbd>`c`</kbd> |
| Cut| <kbd>`ctrl`</kbd> + <kbd>`x`</kbd> |
| Paste| <kbd>`ctrl`</kbd> + <kbd>`v`</kbd> |
| Bold| <kbd>`ctrl`</kbd> + <kbd>`b`</kbd> |
| Italic| <kbd>`ctrl`</kbd> + <kbd>`i`</kbd> |
| Strikethrough| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`s`</kbd> |
| Uppercase| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`u`</kbd> |
| Lowercase| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`l`</kbd> |
| Superscript| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`=`</kbd> |
| Subscript| <kbd>`ctrl`</kbd> + <kbd>`=`</kbd> |
| Fullscreen| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`f`</kbd> |
| Ordered list| <kbd>`ctrl`</kbd> + <kbd>`shift`</kbd> + <kbd>`o`</kbd> |
| Unordered list| <kbd>`ctrl`</kbd> + <kbd>`alt`</kbd> + <kbd>`o`</kbd> |

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

Customize the key config for the keyboard interaction of Rich Text Editor, using the [`keyConfig`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_KeyConfig) property.

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
