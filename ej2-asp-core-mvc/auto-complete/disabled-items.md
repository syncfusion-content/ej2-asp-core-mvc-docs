---
layout: post
title: Disabled Items in ##Platform_Name## AutoComplete | Syncfusion
description: Learn here all about Disabled Items in Syncfusion ##Platform_Name## AutoComplete control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Disabled Items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Disabled Items in ##Platform_Name## AutoComplete

The AutoComplete provides options to disable individual list items for specific scenarios. The category of each list item can be mapped through the [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoCompleteFieldSettings.html#Syncfusion_EJ2_DropDowns_AutoCompleteFieldSettings_Disabled) field in the data table. Once an item is disabled, it cannot be selected as a value for the component. To configure the disabled item columns, use the `fields.disabled` property.

In the following sample, items are marked as enabled or disabled based on the `State` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/disabled-items/tagHelper %}
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
{% include code-snippet/autocomplete/disabled-items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DisabledItem.cs" %}
{% include code-snippet/autocomplete/disabled-items/disabled-items.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Disable item method

The [disableItem](https://ej2.syncfusion.com/documentation/api/auto-complete/index-default#disableitem) method can be used to dynamically change the disabled state of a specific item. Only one item can be disabled in a single call. To disable multiple items, iterate this method over the items list or array. The disabled field state will be updated in the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_DataSource) when the item is disabled using this method. If the selected item is disabled dynamically, the selection will be cleared.

| Parameter | Type | Description |
|------|------|------|
| itemHTMLLIElement | `HTMLLIElement` | It accepts the HTML LI element of the item to be disabled. |
| itemValue | `string` \| `number` \| `boolean` \| `object` | It accepts the string, number, boolean, or object value of the item to be disabled. |
| itemIndex | `number` | It accepts the index of the item to be disabled. |

## Disable the entire component

To disable the entire component, set the [enabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_Enabled) property to `false`.

![Disabled AutoComplete Component](./images/autocomplete-disable.png)