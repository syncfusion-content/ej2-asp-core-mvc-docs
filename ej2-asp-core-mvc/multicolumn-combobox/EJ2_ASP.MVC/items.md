---
layout: post
title: Items in ##Platform_Name## MultiColumn Combobox Control | Syncfusion
description: Checkout and learn about Items in Syncfusion ##Platform_Name## MultiColumn Combobox control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Items in ##Platform_Name## MultiColumn Combobox control

## Setting text

You can use [Text](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Text) property to set the display text of the selected item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Text.cs" %}
{% include code-snippet/multicolumn-combobox/items/text/text.cs %}
{% endhighlight %}
{% endtabs %}

![Text](images/text.png)

## Setting value

You can use [Value](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Value) property to set the value of the selected item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Value.cs" %}
{% include code-snippet/multicolumn-combobox/items/value/value.cs %}
{% endhighlight %}
{% endtabs %}

![Value](images/value.png)

## Setting index

You can use [Index](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Index) property to set the index of the selected item.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/index/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cs" %}
{% include code-snippet/multicolumn-combobox/items/index/index.cs %}
{% endhighlight %}
{% endtabs %}

![Index](images/index.png)

## Adding query

The [Query](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Query) property is used to accept the external query, which will execute along with the data processing.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/query/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Query.cs" %}
{% include code-snippet/multicolumn-combobox/items/query/query.cs %}
{% endhighlight %}
{% endtabs %}

![Query](images/query.png)

## Adding placeholder

You can use the [Placeholder](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Placeholder) property to set a short hint that describes the expected value in the multicolumn combobox control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/placeholder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Placeholder.cs" %}
{% include code-snippet/multicolumn-combobox/items/placeholder/placeholder.cs %}
{% endhighlight %}
{% endtabs %}

![Placeholder](images/placeholder.png)

## Setting the floatlabel type

You can use the [FloatLabelType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_FloatLabelType) property to display a floating label above the input element. This will work when a placeholder is used.

You can change the `FloatLabelType` type to [Never](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.FloatLabelType.html#Syncfusion_EJ2_MultiColumnComboBox_FloatLabelType_Never), [Always](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.FloatLabelType.html#Syncfusion_EJ2_MultiColumnComboBox_FloatLabelType_Always), [Auto](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.FloatLabelType.html#Syncfusion_EJ2_MultiColumnComboBox_FloatLabelType_Auto).

* Never: The label will never float in the input when the placeholder is available.
* Always: The floating label will always float above the input.
* Auto: The floating label will float above the input after focusing or entering a value in the input.

The following example shows the `FloatLabelType` with `Auto`

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/floatlabel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Floatlabel.cs" %}
{% include code-snippet/multicolumn-combobox/items/floatlabel/floatlabel.cs %}
{% endhighlight %}
{% endtabs %}

![Floatlabel](images/floatlabel.png)

## Adding html attributes

You can use the [HtmlAttributes](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_HtmlAttributes) property to add HTML attributes to the multicolumn combobox.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/htmlattribute/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Htmlattribute.cs" %}
{% include code-snippet/multicolumn-combobox/items/htmlattribute/htmlattribute.cs %}
{% endhighlight %}
{% endtabs %}

## Setting width

You can use the [Width](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Width) property to set the width of the control. By default, the width is determined by the width of its parent container.
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Width.cs" %}
{% include code-snippet/multicolumn-combobox/items/width/width.cs %}
{% endhighlight %}
{% endtabs %}

## Setting popup width

You can use the [PopupWidth](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_PopupWidth) property to set the width of the popup list. By default, the popup width is determined by the width of the control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/popupwidth/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PopupWidth.cs" %}
{% include code-snippet/multicolumn-combobox/items/popupwidth/popupwidth.cs %}
{% endhighlight %}
{% endtabs %}

![Popup width](images/popupwidth.png)

## Setting popup height

You can use the [PopupHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_PopupHeight) property to set the height of the popup list. By default, the value is `300px`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/popupHeight/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PopupHeight.cs" %}
{% include code-snippet/multicolumn-combobox/items/popupHeight/popupHeight.cs %}
{% endhighlight %}
{% endtabs %}

![Popup height](images/popupheight.png)

## Adding clear button

The [ShowClearButton](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_ShowClearButton) property is used to specify whether to show or hide the clear button. By default, its value is `false`. When the clear button is clicked, the value, text and index properties are reset to null.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/showclearbutton/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ShowClearButton.cs" %}
{% include code-snippet/multicolumn-combobox/items/showclearbutton/showclearbutton.cs %}
{% endhighlight %}
{% endtabs %}

![Show clear button](images/showclearbutton.png)

## CssClass

You can use the [CssClass](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_CssClass) property to customize the multicolumn combobox control.

## Disabled

The [Disabled](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Disabled) property is used to disable the multicolumn combobox. By default, its value is `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/multicolumn-combobox/items/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

## Setting read only

You can use [Readonly](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Readonly) property to disable the user interactions in the multicolumn combobox control.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/readonly/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ReadOnly.cs" %}
{% include code-snippet/multicolumn-combobox/items/readonly/readonly.cs %}
{% endhighlight %}
{% endtabs %}

## Configure grid settings

You can use the [GridSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_GridSettings) properties to configure the columns in the popup content. You can customize the gridSettings by using `GridSettings`, which provides options such as [GridLines](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBoxGridSettings.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBoxGridSettings_GridLines), [RowHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBoxGridSettings.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBoxGridSettings_RowHeight) and [EnableAltRow](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBoxGridSettings.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBoxGridSettings_EnableAltRow).

### Setting grid lines

You can use [GridLines](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBoxGridSettings.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBoxGridSettings_GridLines) property to set the mode of the gridlines. You can set [Horizontal](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.GridLine.html#Syncfusion_EJ2_MultiColumnComboBox_GridLine_Horizontal), [Vertical](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.GridLine.html#Syncfusion_EJ2_MultiColumnComboBox_GridLine_Vertical), [Default](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.GridLine.html#Syncfusion_EJ2_MultiColumnComboBox_GridLine_Default), [None](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.GridLine.html#Syncfusion_EJ2_MultiColumnComboBox_GridLine_None) and [Both](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.GridLine.html#Syncfusion_EJ2_MultiColumnComboBox_GridLine_Both).

* Both: Displays both horizontal and vertical grid lines.
* None: No grid lines are displayed.
* Horizontal: Displays the horizontal grid lines only.
* Vertical: Displays the vertical grid lines only.
* Default: Displays grid lines based on the theme.

In the following examples, gridLines is set with `Horizontal`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/gridline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gridline.cs" %}
{% include code-snippet/multicolumn-combobox/items/gridline/gridline.cs %}
{% endhighlight %}
{% endtabs %}

![GridLines](images/gridline.png)

### Setting row height

You can use [RowHeight](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBoxGridSettings.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBoxGridSettings_RowHeight) property to set the height of the rows in the popup content.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/rowheight/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RowHeight.cs" %}
{% include code-snippet/multicolumn-combobox/items/rowheight/rowheight.cs %}
{% endhighlight %}
{% endtabs %}

![RowHeight](images/rowheight.png)

### Setting alternate rows

You can use the [EnableAltRow](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBoxGridSettings.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBoxGridSettings_EnableAltRow) property to enable the alternate row styles in the multicolumn combobox. If enabled, it will add the `e-altrow` CSS class to the list of items in the popup.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/altrow/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Altrow.cs" %}
{% include code-snippet/multicolumn-combobox/items/altrow/altrow.cs %}
{% endhighlight %}
{% endtabs %}

![Alternate Rows](images/altrow.png)