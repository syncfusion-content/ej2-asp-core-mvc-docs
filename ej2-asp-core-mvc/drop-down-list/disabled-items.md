---
layout: post
title: Disabled Items in ##Platform_Name## DropDownList | Syncfusion
description: Disable individual Syncfusion ##Platform_Name## DropDownList items by mapping the disabled field on dataSource items through the fields.disabled property.
platform: ej2-asp-core-mvc
control: Disabled Items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Disabled Items in ##Platform_Name## DropDownList

The DropDownList provides options for individual items to be either in an enabled or disabled state for specific scenarios. The category of each list item can be mapped through the [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownListFieldSettings.html#Syncfusion_EJ2_DropDowns_DropDownListFieldSettings_Disabled) field in the data table. Once an item is disabled, it cannot be selected as a value for the component. To configure the disabled item columns, use the `fields.disabled` property.

In the following sample, states are marked as enabled or disabled based on the `State` field

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/disabled-items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DisabledItem.cs" %}
{% include code-snippet/dropdownlist/disabled-items/disabled-items.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/disabled-items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DisabledItem.cs" %}
{% include code-snippet/dropdownlist/disabled-items/disabled-items.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Disable Item Method

The [disableItem](https://ej2.syncfusion.com/documentation/api/drop-down-list/index-default#disableitem) method can be used to handle dynamically change the disable state of a specific item. Only one item can be disabled in this method. To disable multiple items, this method can be iterated with the items list or array. The disabled field state will be updated in the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_DataSource), when the item is disabled using this method. If the selected item is disabled dynamically, then the selection will be cleared.

| Parameter | Type | Description |
|------|------|------|
| itemHTMLLIElement |  <code>HTMLLIElement</code> |  It accepts the HTML Li element of the item to be disabled.  |
| itemValue | <code>string</code> \| <code>number</code> \| <code>boolean</code> \| <code>object</code> | It accepts the string, number, boolean and object type value of the item to be disabled. |
| itemIndex | <code>number</code> | It accepts the index of the item to be disabled. |

## Enabled

To disable the entire component, to set the [enabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Enabled) property to false.

![Disabled DropDownList Component](./images/dropdownlist-disable.png)