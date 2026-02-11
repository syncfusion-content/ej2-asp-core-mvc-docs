---
layout: post
title: Conditional Formatting in ASP.NET Core Syncfusion Pivot Table
description: Learn here all about Conditional Formatting in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Conditional Formatting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Conditional formatting in ASP.NET Core Pivot Table component

The conditional formatting feature enables users to customize the appearance of Pivot Table value cells by modifying background color, font color, font family, and font size based on specific conditions. This powerful visualization feature helps highlight important value cells and makes them stand out in the Pivot Table.

The conditional formatting can be applied at runtime through the built-in dialog, invoked from the toolbar. To enable this functionality, set the [`allowConditionalFormatting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowConditionalFormatting) and [`showToolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowToolbar) properties to **true**. Additionally, include the **ConditionalFormatting** item within the [`toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Toolbar) property. Users will see the "Conditional Formatting" icon in the toolbar UI automatically, which opens the formatting dialog when clicked.

> To use the conditional formatting feature, you need to inject the `ConditionalFormatting` module in Pivot Table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/conditional-formatting/tool-bar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/conditional-formatting/tool-bar/Formatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/conditional-formatting/tool-bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/conditional-formatting/tool-bar/Formatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD012 -->
![output](images/toolbar_cformatting.png)
<br/>
<br/>
![output](images/toolbar_cformatting_dialog.)
<br/>
<br/>
![output](images/toolbar_cformatting_dialog_apply.png)
<br/>
<br/>
![output](images/toolbar_cformatting_grid.png)

## Configure conditional formatting through code-behind

Conditional formatting can also be applied programmatically during component initialization using the 
Conditional formatting can also be included in the pivot table through code-behind using the [`e-conditionalformatsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html) property in the [`e-datasourcesettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewDataSourceSettings.html). This approach allows you to define formatting rules directly in the code-behind, ensuring that specific styling conditions are automatically applied when the Pivot Table loads. The required properties to apply a new conditional formatting are,

* [applyGrandTotals](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_ApplyGrandTotals): This boolean property allows you to restrict conditional formatting for grand totals in the row and column axes. By default, this property is set to **true**.
* [`measure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Measure): Specifies the value field name for which style will be applied.
* [`conditions`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Conditions): Defines the operator type used for conditional formatting, such as equals, greater than, less than, etc.
*  [`value1`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Value1): Specifies the starting value for the conditional formatting.
* [`value2`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Value2): Specifies the ending value for the conditional formatting range. This property is applicable only for conditions like **Between** and **NotBetween**.
* [`style`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html): Specifies the custom styling applied to the cell.

The [`e-field-style`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html) object includes the following properties, which you can use to customize the appearance of value cells:

* [`backgroundColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html#Syncfusion_EJ2_PivotView_PivotViewStyle_BackgroundColor): It allows to set the background color to the value cell in the Pivot Table.
* [`color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html#Syncfusion_EJ2_PivotView_PivotViewStyle_Color): It allows to set the font color to the value cell in the Pivot Table.
* [`fontFamily`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html#Syncfusion_EJ2_PivotView_PivotViewStyle_FontFamily): It allows to set the font family to the value cell in the Pivot Table.
* [`fontSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html#Syncfusion_EJ2_PivotView_PivotViewStyle_FontSize): It allows to set the font size to the value cell in the Pivot Table.

## Opening conditional formatting dialog programmatically

Users can also access the conditional formatting dialog through external UI elements by calling the `showConditionalFormattingDialog` method. In the following example, an external button is used to open the conditional formatting dialog programmatically.
{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/conditional-formatting/ui/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/conditional-formatting/ui/Formatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/conditional-formatting/ui/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/conditional-formatting/ui/Formatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/cond-format-btn.png)

![output](images/cond-format-btn2.png)

## Conditional formatting for all fields

The Pivot Table component allows you to apply conditional formatting to all value fields simultaneously. This approach ensures consistent highlighting and styling of value cells across the entire Pivot Table, removing the need to configure formatting for each value field individually.

To format all value fields together, use the 
Conditional formatting can also be included in the pivot table through code-behind using the [`e-conditionalformatsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html) property without specifying the [`measure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Measure) property. When the [`measure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Measure) property is omitted, the formatting rules are automatically applied to every value field in your Pivot Table, resulting in a uniform appearance for all value cells.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/conditional-formatting/code-behind/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/conditional-formatting/code-behind/Formatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/conditional-formatting/code-behind/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/conditional-formatting/code-behind/Formatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/cformatting_all.png)

## Conditional formatting for specific value field

To apply conditional formatting exclusively to a particular value field, set the [`measure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Measure) property with the specific value field name in 
Conditional formatting can also be included in the pivot table through code-behind using the [`e-conditionalformatsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/conditional-formatting/code-behind-specific/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/conditional-formatting/code-behind-specific/Formatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/conditional-formatting/code-behind-specific/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/conditional-formatting/code-behind-specific/Formatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/cformatting_single.png)

## Conditional formatting for specific row or column

You can apply conditional formatting for specific row or column using [`label`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Label) option in the pivot table. It can be configured using the [`e-conditionalformatsettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html) tag through code behind, during initial rendering. The required settings are:

* [`label`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Label): Specifies the header name to apply conditions for row or column.
* [`conditions`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Conditions): Specifies the operator type such as equals, greater than, less than, etc.
* [`value1`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Value1): Specifies the start value.
* [`value2`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Value2): Specifies the end value.
* [`style`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html): Specifies the style for the cell.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/conditional-formatting/label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="LabelFormatting.cs" %}
{% include code-snippet/pivot-table/conditional-formatting/label/LabelFormatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/conditional-formatting/label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LabelFormatting.cs" %}
{% include code-snippet/pivot-table/conditional-formatting/label/LabelFormatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Editing and removing existing conditional format

Editing and removing existing conditional format can be done through the UI at runtime. To do so, open the conditional formatting dialog and edit the "Value", "Condition" and "Format" options based on user requirement and click "OK". To remove a conditional format, click the "Delete" icon besides the respective condition.

![output](images/cformatting_remove.png)

## Event

### ConditionalFormatting

The `conditionalFormatting` event is triggered when the “ADD CONDITION” button is clicked in the conditional formatting dialog, enabling users to define custom conditions instead of default conditions at runtime. To utilize this event, the [`allowConditionalFormatting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowConditionalFormatting) property of the Pivot Table component must be set to **true**. This event provides the following parameters:

* `applyGrandTotals` - Allows to apply conditional formatting to the grand totals of row and column axis in the Pivot Table.
* `conditions` - Allows you to choose the operator type such as equals, greater than, less than, etc. for conditional formatting.
* `label` - Allows to set the header text of a specific row/column field to apply conditional formatting.
* `measure` - Allows to set the value field name to apply conditional formatting.
* `style` - Allows to set the custom styles for the formatting applied values in the Pivot Table.
* `value1` - Allows to set the start value for applying conditional formatting.
* `value2` - Allows to set the end value for applying conditional formatting. This property is applicable only for conditions like **Between** and **NotBetween**.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/conditional-formatting/event/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/conditional-formatting/event/Formatting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/conditional-formatting/event/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Formatting.cs" %}
{% include code-snippet/pivot-table/conditional-formatting/event/Formatting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}