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

## Text

You can use [text](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Text) property to set the display text of the selected item.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/text/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text.cs" %}
{% include code-snippet/multicolumn-combobox/items/text/text.cs %}
{% endhighlight %}
{% endtabs %}

![Text](images/text.png)

## Value

You can use [value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Value) property to set the value of the selected item.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/value/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Value.cs" %}
{% include code-snippet/multicolumn-combobox/items/value/value.cs %}
{% endhighlight %}
{% endtabs %}

![Value](images/value.png)

## Index

You can use [index](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Index) property to set the index of the selected item.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/index/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Index.cs" %}
{% include code-snippet/multicolumn-combobox/items/index/index.cs %}
{% endhighlight %}
{% endtabs %}

![Index](images/index.png)

## Query

The [Query](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Query) property is used to accept the external query, which will execute along with the data processing.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/query/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Query.cs" %}
{% include code-snippet/multicolumn-combobox/items/query/query.cs %}
{% endhighlight %}
{% endtabs %}

![Query](images/query.png)

## Allow filtering

The [allowFiltering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_AllowFiltering) property enables the filtering functionality, allowing users to filter the list of items based on their input. To activate this feature, set `allowFiltering` to true, as its default value is true.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/allow-filtering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AllowFiltering.cs" %}
{% include code-snippet/multicolumn-combobox/items/allow-filtering/allow-filtering.cs %}
{% endhighlight %}
{% endtabs %}

![Allow filtering](images/filtering.png)

## Allow sorting

The [allowSorting](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_AllowSorting) property is used to specify whether sorting is allowed. By default its value is true.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/allow-sorting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AllowSorting.cs" %}
{% include code-snippet/multicolumn-combobox/items/allow-sorting/allow-sorting.cs %}
{% endhighlight %}
{% endtabs %}

![Allow sorting](images/sorting.png)

## Placeholder

You can use the [placeholder](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Placeholder) property to set a short hint that describes the expected value of the multicolumn combobox component.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/placeholder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Placeholder.cs" %}
{% include code-snippet/multicolumn-combobox/items/placeholder/placeholder.cs %}
{% endhighlight %}
{% endtabs %}

![Placeholder](images/placeholder.png)

## Floatlabel type

You can use the [floatLabelType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_FloatLabelType) property to display a floating label above the input element. This will work when a placeholder is used.

You can change the `floatLabelType` type to [Never](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.FloatLabelType.html#Syncfusion_EJ2_MultiColumnComboBox_FloatLabelType_Never), [Always](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.FloatLabelType.html#Syncfusion_EJ2_MultiColumnComboBox_FloatLabelType_Always), [Auto](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.FloatLabelType.html#Syncfusion_EJ2_MultiColumnComboBox_FloatLabelType_Auto).

* Never: The label will never float in the input when the placeholder is available.
* Always: The floating label will always float above the input.
* Auto: The floating label will float above the input after focusing or entering a value in the input.

The following example shows the `floatLabelType` with `Auto`

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/floatlabel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Floatlabel.cs" %}
{% include code-snippet/multicolumn-combobox/items/floatlabel/floatlabel.cs %}
{% endhighlight %}
{% endtabs %}

![Floatlabel](images/floatlabel.png)

## Adding html attributes

You can use the [htmlAttributes](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_HtmlAttributes) property to add HTML attributes to the MultiColumn Combobox.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/htmlattribute/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Htmlattribute.cs" %}
{% include code-snippet/multicolumn-combobox/items/htmlattribute/htmlattribute.cs %}
{% endhighlight %}
{% endtabs %}

## Adding width

You can use the [width](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Width) property to set the width of the component. By default, the component's width is set based on the width of its parent container.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/width/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Width.cs" %}
{% include code-snippet/multicolumn-combobox/items/width/width.cs %}
{% endhighlight %}
{% endtabs %}

## Popup width

You can use the [popupWidth](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_PopupWidth) property to set the width of the popup list. By default, the popup width set based on the width of the component.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/popupwidth/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PopupWidth.cs" %}
{% include code-snippet/multicolumn-combobox/items/popupwidth/popupwidth.cs %}
{% endhighlight %}
{% endtabs %}

![Popup width](images/popupwidth.png)

## Popup height

You can use the [popupHeight](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_PopupHeight) property to set the height of the popup list. By default, the value is 300px.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/popupHeight/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PopupHeight.cs" %}
{% include code-snippet/multicolumn-combobox/items/popupHeight/popupHeight.cs %}
{% endhighlight %}
{% endtabs %}

![Popup height](images/popupheight.png)

## Show clear button

The [showClearButton](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_ShowClearButton) property is used to specify whether to show or hide the clear button. By default, its value is false. When the clear button is clicked, the value, text, and index properties are reset to null.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/showclearbutton/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ShowClearButton.cs" %}
{% include code-snippet/multicolumn-combobox/items/showclearbutton/showclearbutton.cs %}
{% endhighlight %}
{% endtabs %}

![Show clear button](images/showclearbutton.png)

## Enable virtualization

You can set the [enableVirtualization](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_EnableVirtualization) property to true to enable virtual scrolling.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/virtualization/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Virtualization.cs" %}
{% include code-snippet/multicolumn-combobox/items/virtualization/virtualization.cs %}
{% endhighlight %}
{% endtabs %}

## Css class

You can use the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_CssClass) property to customize the MultiColumn Combobox.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/cssclass/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CssClass.cs" %}
{% include code-snippet/multicolumn-combobox/items/cssclass/cssclass.cs %}
{% endhighlight %}
{% endtabs %}

## Disabled

The [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Disabled) property is used to specify whether the component is disabled. By default, its value is false.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/disabled/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/multicolumn-combobox/items/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

## Read only

You can use [readonly](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Readonly) property to disable the user interactions of the component.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/readonly/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ReadOnly.cs" %}
{% include code-snippet/multicolumn-combobox/items/readonly/readonly.cs %}
{% endhighlight %}
{% endtabs %}