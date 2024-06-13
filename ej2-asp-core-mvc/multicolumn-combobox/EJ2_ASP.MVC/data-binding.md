---
layout: post
title: Data binding in ##Platform_Name## MultiColumn Combobox Control | Syncfusion
description: Checkout and learn about Data binding in Syncfusion ##Platform_Name## MultiColumn Combobox control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Data binding in ##Platform_Name## MultiColumn Combobox control

The MultiColumn ComboBox loads the data either from local data sources or remote data services using the [DataSource](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_DataSource) property. It supports the data type of `object arrays` or `DataManager`.

The MultiColumn ComboBox also supports different kinds of data services such as OData, OData V4, and Web API, and data formats such as XML, JSON, and JSONP with the help of `DataManager` adaptors.

| Fields | Type | Description |
|------|------|-------------|
| text |  `string` | Specifies the display text of each list item. |
| value |  `number or string` | Specifies the hidden data value mapped to each list item that should contain a unique value. |
| groupBy |  `string` | Specifies the category under which the list item has to be grouped. |
| iconCss |  `string` | Specifies the icon class of each list item. |

> The fields should be mapped correctly. Otherwise, the selected item remains undefined.

## Binding local data

The local binding in the MultiColumn ComboBox allows you to connect the component to various data sources, enabling dynamic and flexible data display.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/items/text/razor %}
{% endhighlight %}
{% highlight c# tabtitle="LocalData.cs" %}
{% include code-snippet/multicolumn-combobox/items/text/text.cs %}
{% endhighlight %}
{% endtabs %}

![Text](images/text.png)

## Binding remote data

The MultiColumn ComboBox supports retrieval of data from remote data services with the help of `DataManager` component. The [Query](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.MultiColumnComboBox.MultiColumnComboBox.html#Syncfusion_EJ2_MultiColumnComboBox_MultiColumnComboBox_Query) property is used to fetch data from the database and bind it to the MultiColumn ComboBox.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multicolumn-combobox/remotedata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="RemoteData.cs" %}
{% include code-snippet/multicolumn-combobox/remotedata/remotedata.cs %}
{% endhighlight %}
{% endtabs %}

![Text](images/remotedata.png)