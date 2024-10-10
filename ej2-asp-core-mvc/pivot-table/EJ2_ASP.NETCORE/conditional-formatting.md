---
layout: post
title: Conditional Formatting in ##Platform_Name## Pivot Table Component | Syncfusion
description: Learn here all about Conditional Formatting in Syncfusion ##Platform_Name## Pivot Table component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Conditional Formatting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Conditional Formatting

Allows end user to change the appearance of the pivot table value cells with its background color, font color, font family, and font size based on specific conditions.

The conditional formatting can be applied at runtime through the built-in dialog, invoked from the toolbar. To do so, set [allowConditionalFormatting](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowConditionalFormatting) and [showToolbar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowToolbar) properties in [ejs-pivotview](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) tag to **true**. Also, include the item **ConditionalFormatting** within the [toolbar](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Toolbar) property in [ejs-pivotview](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html) tag. End user can now see the "Conditional Formatting" icon in toolbar UI automatically, which on clicking will invoke the formatting dialog to perform necessary operations.

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
![output](images/toolbar_cformatting.png "Conditional formatting icon in toolbar")
<br/>
<br/>
![output](images/toolbar_cformatting_dialog.png "Adding new conditional format")
<br/>
<br/>
![output](images/toolbar_cformatting_dialog_apply.png "Setting conditional format criteria")
<br/>
<br/>
![output](images/toolbar_cformatting_grid.png "Resultant pivot table on applied conditional format")

Conditional formatting can also be included in the pivot table through code-behind using the [e-conditionalformatsettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html) tag. The required properties to apply a new conditional formatting are,

* [applyGrandTotals](https://ej2.syncfusion.com/documentation/api/pivotview/conditionalFormatSettingsModel/#applygrandtotals): This boolean property allows you to restrict conditional formatting for grand totals in the row and column axes. By default, this property is set to true.
* [measure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Measure): Specifies the value field name for which style will be applied.
* [conditions](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Conditions): Defines the operator type used for conditional formatting, such as equals, greater than, less than, etc.
* [value1](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Value1): Specifies the starting value for the conditional formatting.
* [value2](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Value2): Specifies the ending value for the conditional formatting range. This property is applicable only for conditions like **Between** and **NotBetween**.
* [style](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html): Specifies the custom styling applied to the cell.

The available style properties in [e-field-style](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html) tag, to set in value cells are:

* [backgroundColor](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html#Syncfusion_EJ2_PivotView_PivotViewStyle_BackgroundColor): It allows to set the background color to the value cell in the pivot table.
* [color](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html#Syncfusion_EJ2_PivotView_PivotViewStyle_Color): It allows to set the font color to the value cell in the pivot table.
* [fontFamily](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html#Syncfusion_EJ2_PivotView_PivotViewStyle_FontFamily): It allows to set the font family to the value cell in the pivot table.
* [fontSize](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html#Syncfusion_EJ2_PivotView_PivotViewStyle_FontSize): It allows to set the font size to the value cell in the pivot table.

Meanwhile, user can also view conditional formatting dialog in UI by invoking `showConditionalFormattingDialog` method on an external button click which is shown in the below code sample.

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

Allows end user to apply conditional formatting commonly for all value fields just by ignoring the [measure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Measure) property and setting rest of the properties in [e-conditionalformatsettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html) tag.

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

Allows end user to apply conditional formatting to a specific value field by setting the [measure](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Measure) property with specific value field name in [e-conditionalformatsettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html) tag.

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

You can apply conditional formatting for specific row or column using [label](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Label) option in the pivot table. It can be configured using the [e-conditionalformatsettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html) tag through code behind, during initial rendering. The required settings are:

* [label](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Label): Specifies the header name to apply conditions for row or column.
* [conditions](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Conditions): Defines the operator type used for conditional formatting, such as equals, greater than, less than, etc.
* [value1](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Value1): Specifies the starting value for the conditional formatting.
* [value2](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Value2): Specifies the ending value for the conditional formatting range. This property is applicable only for conditions like **Between** and **NotBetween**.
* [style](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html): Specifies the custom styling applied to the cell.

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

The event `conditionalFormatting` is triggered initially while clicking the “ADD CONDITION” button inside the conditional formatting dialog in-order to fill user specific condition instead of default condition at runtime. To use this event, `allowConditionalFormatting` property in PivotView must be set to **true**. It has following parameters -

* `applyGrandTotals` - Allows to apply conditional formatting to the grand totals of row and column axis in the pivot table.
* `conditions` - Allows you to choose the operator type such as equals, greater than, less than, etc. for conditional formatting.
* `label` - Allows to set the header text of a specific row/column field to apply conditional formatting.
* `measure` - Allows to set the value field name to apply conditional formatting.
* `style` - Allows to set the custom styles for the formatting applied values in the pivot table.
* `value1` - Allows you to set the start value for applying conditional formatting.
* `value2` - Allows you to set the end value for applying conditional formatting. This property is applicable only for conditions like **Between** and **NotBetween**.

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



