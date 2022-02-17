---
layout: post
title: Data Binding in ##Platform_Name## List Box Component
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## List Box component and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Binding

The ListBox loads the data either from local data sources or remote data services using the [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~DataSource.html) property. It supports
the data type of `array` or `DataManager`.

| Fields | Type | Description |
|------|------|-------------|
| [`text`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBoxFieldSettings~Text.html) |  `string` | Specifies the display text of each list item. |
| [`value`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBoxFieldSettings~Value.html) |  `string` | Specifies the hidden data value mapped to each list item that should contain a unique value. |
| [`groupBy`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBoxFieldSettings~GroupBy.html) |  `string` | Specifies the category under which the list item has to be grouped. |
| [`iconCss`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBoxFieldSettings~IconCss.html) |  `string` | Specifies the iconCss class that needs to be mapped. |
| [`htmlAttributes`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBoxFieldSettings~HtmlAttributes.html) |  `string` | Allows additional attributes to configure the elements in various ways to meet the criteria. |

> When binding complex data to the ListBox, fields should be mapped correctly. Otherwise, the selected item remains undefined.

## Local Data

Local data can be represented by the following ways as described below.

### Array of string

The ListBox has support to load array of primitive data such as strings or numbers. Here, both value and text field acts as same.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/data-binding/string-array/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Databinding.cs" %}
{% include code-snippet/listbox/data-binding/string-array/databinding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/data-binding/string-array/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Databinding.cs" %}
{% include code-snippet/listbox/data-binding/string-array/databinding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Array of object

The ListBox can generate its list items through an array of object data. For this, the appropriate columns should be mapped to the [`fields`](../api/list-box/#fields) property.

In the following example, `id` and `sports` column from complex data have been mapped to the `value` field and `text` field, respectively.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/data-binding/array-object/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Databinding.cs" %}
{% include code-snippet/listbox/data-binding/array-object/databinding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/data-binding/array-object/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Databinding.cs" %}
{% include code-snippet/listbox/data-binding/array-object/databinding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Array of complex object

The ListBox can generate its list items through an array of complex data. For this, the appropriate columns should be mapped to the [`fields`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~Fields.html) property.

In the following example, `Sports.Name` column from complex data have been mapped to the `text` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/data-binding/complex-object/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Databinding.cs" %}
{% include code-snippet/listbox/data-binding/complex-object/databinding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/data-binding/complex-object/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Databinding.cs" %}
{% include code-snippet/listbox/data-binding/complex-object/databinding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Remote Data

The ListBox supports retrieval of data from remote data services with the help of [`DataManager`](https://ej2.syncfusion.com/documentation/data/getting-started/) component. The [`query`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~Query.html) property is used to fetch
data from the database and bind it to the ListBox.

The following sample displays the employee names from Employee table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/data-binding/remote-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Databinding.cs" %}
{% include code-snippet/listbox/data-binding/remote-data/databinding.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/data-binding/remote-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Databinding.cs" %}
{% include code-snippet/listbox/data-binding/remote-data/databinding.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

