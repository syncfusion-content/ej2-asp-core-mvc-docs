---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Clipboard of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Clipboard
publishingplatform: ##Platform_Name##
documentation: ug
---

<kbd>Ctrl + C</kbd> |Copy selected rows or cells data into clipboard.
<kbd>Ctrl + Shift + H</kbd> |Copy selected rows or cells data with header into clipboard.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="key" %}
{% include_relative code-snippet/clipboard/key/local.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="key" %}
{% include_relative code-snippet/clipboard/key/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="key" %}
{% include_relative code-snippet/clipboard/key/local.cs %}
{% endhighlight %}
{% highlight razor tabtitle="key" %}
{% include_relative code-snippet/clipboard/key/razor %}
{% endhighlight %}
{% endtabs %}



## Copy to clipboard by external buttons

To copy selected rows or cells data into the clipboard with help of toolbar buttons, you need to define the [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event and invoke the [`copy`](https://ej2.syncfusion.com/documentation/api/grid/#copy) method.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="clipboard" %}
{% include_relative code-snippet/clipboard/clipboard/local.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="clipboard" %}
{% include_relative code-snippet/clipboard/clipboard/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="clipboard" %}
{% include_relative code-snippet/clipboard/clipboard/local.cs %}
{% endhighlight %}
{% highlight razor tabtitle="clipboard" %}
{% include_relative code-snippet/clipboard/clipboard/razor %}
{% endhighlight %}
{% endtabs %}



## AutoFill

AutoFill Feature allows you to copy the data of selected cells and paste it to another cells by just dragging the autofill icon of the selected cells up to required cells. This feature is enabled by defining [`EnableAutoFill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableAutoFill) property as true.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="autofill" %}
{% include_relative code-snippet/clipboard/autofill/autofill.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="autofill" %}
{% include_relative code-snippet/clipboard/autofill/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="autofill" %}
{% include_relative code-snippet/clipboard/autofill/autofill.cs %}
{% endhighlight %}
{% highlight razor tabtitle="autofill" %}
{% include_relative code-snippet/clipboard/autofill/razor %}
{% endhighlight %}
{% endtabs %}



> If [`EnableAutoFill`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnableAutoFill) is set to true, then the autofill icon will be displayed on cell selection to copy cells.
> It requires the selection [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Mode) to be **Cell**,  [`CellSelectionMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_CellSelectionMode) to be **Box** and also Batch Editing should be enabled.

### Limitations of AutoFill

* Since the string values are not parsed to number and date type, so when the selected string type cells are dragged to number type cells then it will display as **NaN**. For date type cells, when the selected string type cells are dragged to date type cells then it will display as an **empty cell**.
* Linear series and the sequential data generations are not supported in this autofill feature.

## Paste

You can able to copy the content of a cell or a group of cells by selecting the cells and pressing <kbd>Ctrl + C</kbd> shortcut key and paste it to another set of cells by selecting the cells and pressing <kbd>Ctrl + V</kbd> shortcut key.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="paste" %}
{% include_relative code-snippet/clipboard/paste/paste.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="paste" %}
{% include_relative code-snippet/clipboard/paste/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="paste" %}
{% include_relative code-snippet/clipboard/paste/paste.cs %}
{% endhighlight %}
{% highlight razor tabtitle="paste" %}
{% include_relative code-snippet/clipboard/paste/razor %}
{% endhighlight %}
{% endtabs %}



> To perform paste functionality, it requires the selection [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_Mode) to be **Cell**,  [`CellSelectionMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridSelectionSettings.html#Syncfusion_EJ2_Grids_GridSelectionSettings_CellSelectionMode) to be **Box** and also Batch Editing should be enabled.

### Limitations of Paste Functionality

* Since the string values are not parsed to number and date type, so when the copied string type cells are pasted to number type cells then it will display as **NaN**. For date type cells, when the copied string format cells are pasted to date type cells then it will display as an **empty cell**.