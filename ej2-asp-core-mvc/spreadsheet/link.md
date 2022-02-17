---
layout: post
title: Link in ##Platform_Name## Spreadsheet Component
description: Learn here all about Link in Syncfusion ##Platform_Name## Spreadsheet component and more.
platform: ej2-asp-core-mvc
control: Link
publishingplatform: ##Platform_Name##
documentation: ug
---


# Hyperlink

Hyperlink is used to navigate to web links or cell reference within the sheet or to other sheets in Spreadsheet. You can use the [`allowHyperlink`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Spreadsheet.Spreadsheet.html#Syncfusion_EJ2_Spreadsheet_Spreadsheet_AllowHyperlink) property to enable or disable hyperlink functionality.

> * The default value for `allowHyperlink` property is `true`.

## Insert Link

You can insert a hyperlink in a worksheet cell for quick access to related information.

**User Interface**:

In the active spreadsheet, click the cell where you want to create a hyperlink. Insert hyperlink can be done by any of the following ways:
* Select the INSERT tab in the Ribbon toolbar and choose the `Link` item.
* Right-click the cell and then click Hyperlink item in the context menu, or you can press Ctrl+K.
* Use the `addHyperlink()` method programmatically.

## Edit Hyperlink

You can change an existing hyperlink in your workbook by changing its destination or the text that is used to represent it.

**User Interface**:

In the active spreadsheet, Select the cell that contains the hyperlink that you want to change. Editing the hyperlink while opening the dialog can be done by any one of the following ways:

* Select the INSERT tab in the Ribbon toolbar and choose the `Link` item.
* Right-click the cell and then click Edit Hyperlink item in the context menu, or you can press Ctrl+K.

In the Edit Link dialog box, make the changes that you want, and click UPDATE.

## Remove Hyperlink

Performing this operation remove a single hyperlink without losing the display text.

**User Interface**:

In the active spreadsheet, click the cell where you want to remove a hyperlink. remove hyperlink can be done by any of the following ways:
* Right-click the cell and then click Remove Hyperlink item in the context menu.
* Use the `removeHyperlink()` method programmatically.

## How to change target attribute

There is an event named `beforeHyperlinkClick` which triggers only on clicking hyperlink. You can customize where to open the hyperlink by using the `target` property in the arguments of that event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/link/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HyperlinkController.cs" %}
{% include code-snippet/spreadsheet/link/hyperlinkController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/link/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HyperlinkController.cs" %}
{% include code-snippet/spreadsheet/link/hyperlinkController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Limitations

* Inserting hyperlink not supported for multiple ranges.

## See Also

* [Sorting](./sort)
* [Filtering](./filter)
* [Undo Redo](./undo-redo)
