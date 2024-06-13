---
layout: post
title: Grouping in ##Platform_Name## MultiColumn Combobox Control | Syncfusion
description: Checkout and learn about Grouping in Syncfusion ##Platform_Name## MultiColumn Combobox control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Grouping
publishingplatform: ##Platform_Name##
documentation: ug
---

# Grouping in ##Platform_Name## MultiColumn Combobox control

The MultiColumn ComboBox supports wrapping nested elements into a group based on different categories by using the [GroupBy](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBoxFieldSettings.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBoxFieldSettings_GroupBy) property. The category of each list item can be mapped through the groupBy  field in the data table. The group header are displayed as fixed headers. The fixed group header content is updated dynamically on scrolling the popup list with its category value.

In the following sample, countries are grouped according on its category using `GroupBy` field.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/grouping/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouping.cs" %}
{% include code-snippet/multicolumn-combobox/grouping/grouping.cs %}
{% endhighlight %}
{% endtabs %}

![Grouping](images/grouping.png)