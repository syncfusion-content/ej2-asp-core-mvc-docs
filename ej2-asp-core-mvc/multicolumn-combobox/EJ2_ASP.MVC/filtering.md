---
layout: post
title: Filtering in ##Platform_Name## MultiColumn ComboBox | Syncfusion
description: Implement filtering in the Syncfusion ##Platform_Name## MultiColumn ComboBox to enable users to search and filter items using various filter types.
platform: ej2-asp-core-mvc
control: Filtering
publishingplatform: ##Platform_Name##
documentation: ug
---

# Filtering in ##Platform_Name## MultiColumn ComboBox

The MultiColumn ComboBox has built-in support to filter the data items, which allows users to filter the list of items based on their input. The filter operation starts as soon as you start typing characters in the component. The filtering can be disabled by setting the [AllowFiltering](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_AllowFiltering) to `false`. By default the value is `true`.

## Change the filter type

You can change the filter type by using the [FilterType](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_FilterType) property. The `FilterType` supports filtering options such as [StartsWith](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.FilterType.html#Syncfusion_EJ2_MultiColumnComboBox_FilterType_StartsWith), [EndsWith](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.FilterType.html#Syncfusion_EJ2_MultiColumnComboBox_FilterType_EndsWith) and [Contains](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.FilterType.html#Syncfusion_EJ2_MultiColumnComboBox_FilterType_Contains).

In the following example, data filtering is done with `EndsWith` type.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/filtering/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Filtering.cs" %}
{% include code-snippet/multicolumn-combobox/filtering/filtering.cs %}
{% endhighlight %}
{% endtabs %}

![Filtering](images/filtering.png)