---
layout: post
title: Clipboard in ##Platform_Name## Spreadsheet Component
description: Learn here all about Clipboard in Syncfusion ##Platform_Name## Spreadsheet component and more.
platform: ej2-asp-core-mvc
control: Clipboard
publishingplatform: ##Platform_Name##
documentation: ug
---


# Clipboard

The Spreadsheet provides support for the clipboard operations (cut, copy, and paste). Clipboard operations can be enabled or disabled by setting the [`enableClipboard`](../api/spreadsheet/#enableclipboard) property in Spreadsheet.

> By default, the `enableClipboard` property is true.

## Cut

It is used to cut the data from selected range of cells, rows or columns in a spreadsheet and make it available in the clipboard.

**User Interface**:

Cut can be done in one of the following ways.

* Using Cut button in the Ribbon’s HOME tab to perform cut operation.
* Using Cut option in the Context Menu.
* Using `Ctrl + X` | `Command + X` keyboard shortcut.
* Using the [`cut`](../api/spreadsheet/#cut) method.

## Copy

It is used to copy the data from selected range of cells, rows or columns in a spreadsheet and make it available in the clipboard.

**User Interface**:

Copy can be done in one of the following ways.

* Using Copy button in the Ribbon’s HOME tab to perform copy operation.
* Using Copy option in the Context Menu.
* Using `Ctrl + C` | `Command + C` keyboard shortcut.
* Using the [`copy`](../api/spreadsheet/#copy) method.

## Paste

It is used to paste the clipboard data to the selected range, rows or columns. You have the following options in Paste,

* `Paste Special` - You can paste the values with formatting.
* `Paste` - You can paste only the values without formatting.

It also performs for external clipboard operation. If you perform cut and paste, clipboard data will be cleared, whereas in copy and paste the clipboard contents will be maintained. If you perform paste inside the copied range, the clipboard data will be cleared.

**User Interface**:

Paste can be done in one of the following ways.

* Using Paste button in the Ribbon’s HOME tab to perform paste operation.
* Using Paste option in the Context Menu.
* Using `Ctrl + V` | `Command + V` keyboard shortcut.
* Using the [`paste`](../api/spreadsheet/#paste) method.

> If you use the Keyboard shortcut key for cut (`Ctrl + X`) | copy (`Ctrl + C`) from other sources, you should use `Ctrl + V` shortcut while pasting into the spreadsheet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/clipboard/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ClipboardController.cs" %}
{% include code-snippet/spreadsheet/clipboard/clipboardController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/clipboard/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ClipboardController.cs" %}
{% include code-snippet/spreadsheet/clipboard/clipboardController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Prevent the paste functionality

The following example shows, how to prevent the paste action in spreadsheet. In [`actionBegin`](../api/spreadsheet/#actionbegin) event, you can set `cancel` argument as false in paste request type.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/prevent-paste/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ClipboardController.cs" %}
{% include code-snippet/spreadsheet/prevent-paste/clipboardController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/prevent-paste/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ClipboardController.cs" %}
{% include code-snippet/spreadsheet/prevent-paste/clipboardController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limitations

* External clipboard is not fully supported while copying data from another source and pasting into a spreadsheet, it only works with basic supports (Values, Number, cell, and Text formatting).
* If you copy =SUM(A2,B2) and paste, the formula reference will change depending on the pasted cell address but we don't have support for nested formula(formula reference will be same).
* Clipboard is not supported with conditional formatting (values only pasting).
* We have limitation while copying the whole sheet data and pasting it into another sheet.