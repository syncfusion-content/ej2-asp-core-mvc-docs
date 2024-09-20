---
layout: post
title: Disabled Items in ASP.NET Core Mention control | Syncfusion
description: Learn here all about di the datasource in Syncfusion ASP.NET Core Mention control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Disabled Items
publishingplatform: ##Platform_Name##
documentation: ug
---

# Disabled Items in Mention Control

The Mention provides options for individual items to be either in an enabled or disabled state for specific scenarios. The category of each list item can be mapped through the [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MentionFieldSettings.html#Syncfusion_EJ2_DropDowns_MentionFieldSettings_Disabled) field in the data table. Once an item is disabled, it cannot be selected as a value for the component. To configure the disabled item columns, use the `fields.disabled` property.

In the following sample, State are grouped according on its category using `disabled` field.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/mention/disabled-items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/mention/disabled-items/DisableStatusData.cs %}
{% endhighlight %}
{% endtabs %}

## Disable Item Method

The disableItem method can be used to handle dynamic changing in disable state of a specific item. Only one item can be disabled in this method. To disable multiple items, this method can be iterated with the items list or array. The disabled field state will to be updated in the [dataSource](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.dropdowns.mention.html#Syncfusion_EJ2_DropDowns_Mention_DataSource), when the item is disabled using this method.

| Parameter | Type | Description |
|------|------|------|
| itemHTMLLIElement |  <code>HTMLLIElement</code> |  It accepts the HTML Li element of the item to be removed.  |
| itemValue | <code>string</code> \| <code>number</code> \| <code>boolean</code> \| <code>object</code> | It accepts the string, number, boolean and object type value of the item to be removed. |
| itemIndex | <code>number</code> | It accepts the index of the item to be removed. |