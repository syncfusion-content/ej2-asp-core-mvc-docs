---
layout: post
title: Conditional Formatting in ##Platform_Name## Pivot Table Component
description: Learn here all about Conditional Formatting in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Conditional Formatting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Conditional Formatting

Allows end user to change the appearance of the pivot table value cells with its background color, font color, font family, and font size based on specific conditions.

The conditional formatting can be applied at runtime through the built-in dialog, invoked from the toolbar. To do so, set [`AllowConditionalFormatting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_AllowConditionalFormatting) and [`ShowToolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_ShowToolbar) properties in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class to **true**. Also, include the item **ConditionalFormatting** within the [`Toolbar`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotView.html#Syncfusion_EJ2_PivotView_PivotView_Toolbar) property in [`PivotView`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotView.html) class. End user can now see the "Conditional Formatting" icon in toolbar UI automatically, which on clicking will invoke the formatting dialog to perform necessary operations.

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

Conditional formatting can also be included in the pivot table through code-behind using the [`PivotViewConditionalFormatSetting`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html) class. The required properties to apply a new conditional formatting are,

* [`Measure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Measure): Specifies the value field name for which style will be applied.
* [`Conditions`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Conditions): Specifies the operator type such as equals, greater than, less than, etc.
* [`Value1`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Value1): Specifies the start value.
* [`Value2`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Value2): Specifies the end value.
* [`PivotViewStyle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html): Specifies the style for the cell.

The available style properties in [`PivotViewStyle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html) class, to set in value cells are:

* [`BackgroundColor`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html#Syncfusion_EJ2_PivotView_PivotViewStyle_BackgroundColor): Specifies the background color.
* [`Color`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html#Syncfusion_EJ2_PivotView_PivotViewStyle_Color): Specifies the font color.
* [`FontFamily`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html#Syncfusion_EJ2_PivotView_PivotViewStyle_FontFamily): Specifies the font family.
* [`FontSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewStyle.html#Syncfusion_EJ2_PivotView_PivotViewStyle_FontSize): Specifies the font size.

Meanwhile, user can also view conditional formatting dialog in UI by invoking `ShowConditionalFormattingDialog` method on an external button click which is shown in the below code sample.

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

Allows end user to apply conditional formatting commonly for all value fields just by ignoring the [`Measure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Measure) property and setting rest of the properties in [`PivotViewConditionalFormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html) class.

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

Allows end user to apply conditional formatting to a specific value field by setting the [`Measure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html#Syncfusion_EJ2_PivotView_PivotViewConditionalFormatSetting_Measure) property with specific value field name in [`PivotViewConditionalFormatSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.PivotView.PivotViewConditionalFormatSetting.html) class.

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

## Editing and removing existing conditional format

Editing and removing existing conditional format can be done through the UI at runtime. To do so, open the conditional formatting dialog and edit the "Value", "Condition" and "Format" options based on user requirement and click "OK". To remove a conditional format, click the "Delete" icon besides the respective condition.  

![output](images/cformatting_remove.png)

## Event

### ConditionalFormatting

The event `ConditionalFormatting` is triggered initially while clicking the “ADD CONDITION” button inside the conditional formatting dialog in-order to fill user specific condition instead of default condition at runtime. To use this event, `AllowConditionalFormatting` property in PivotView must be set to **true**. It has following parameters -

* `applyGrandTotals` - boolean property, by setting this to true user can enable formatting to grand totals.
* `conditions` - condition to be filled in conditional formatting dialog.
* `label` - Label value for conditional formatting dialog.
* `measure` - measure value for the conditional formatting dialog.
* `style` - style property of the conditional formatting dialog.
* `value1` - value 1 for conditional formatting dialog.
* `value2` - value 2 for conditional formatting dialog, this is applicable only for selected conditions like **Between** and **NotBetween**.

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



## See Also

* [Apply conditional formatting for specific row or column](./how-to/apply-conditional-formatting-for-specific-row-or-column)
