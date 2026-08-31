---
layout: post
title: Disabled Items in ##Platform_Name## MultiSelect | Syncfusion
description: Disable individual Syncfusion ##Platform_Name## MultiSelect items by mapping the disabled field on dataSource items through the fields.disabled property.
platform: ej2-asp-core-mvc
control: Disabled Items
publishingplatform: ##Platform_Name##
documentation: ug
---


# Disabled Items in ##Platform_Name## MultiSelect

The MultiSelect supports putting individual items in an enabled or disabled state for specific scenarios. The disabled category of each list item can be mapped through the [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelectFieldSettings.html#Syncfusion_EJ2_DropDowns_MultiSelectFieldSettings_Disabled) field in the data table. Once an item is disabled, it cannot be selected as a value for the control. To configure the disabled item columns, use the `fields.disabled` property.

In the following sample, states are grouped by their disabled category using the `disabled` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/disabled-items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class DisableStatusData
{
    public string Status { get; set; }
    public bool State { get; set; }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/disabled-items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DisabledItem.cs" %}
{% include code-snippet/multiselect/disabled-items/disabled-items.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Disable item method

Use the `disableItem` method to dynamically change the disabled state of a specific item. Only one item can be disabled per call. To disable multiple items, iterate this method over the items list or array. The disabled state in the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_DataSource) is updated when an item is disabled through this method. If a selected item is disabled dynamically, its selection is cleared.

| Parameter | Type | Description |
|------|------|------|
| itemHTMLLIElement |  <code>HTMLLIElement</code> |  It accepts the HTML Li element of the item to be removed.  |
| itemValue | <code>string</code> \| <code>number</code> \| <code>boolean</code> \| <code>object</code> | It accepts the string, number, boolean and object type value of the item to be removed. |
| itemIndex | <code>number</code> | It accepts the index of the item to be removed. |

## Enabled

To disable the entire control, set the [enabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_Enabled) property to `false`.

![Disabled MultiSelect control](./images/multiselect-disable.png)