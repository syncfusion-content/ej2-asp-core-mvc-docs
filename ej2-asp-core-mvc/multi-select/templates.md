---
layout: post
title: Templates in ##Platform_Name## MultiSelect | Syncfusion
description: Customize ##Platform_Name## MultiSelect Dropdown list items, group headers, selected value, header, footer, and summary tag using template engine support.
platform: ej2-asp-core-mvc
control: Templates
publishingplatform: ##Platform_Name##
documentation: ug
---


# Templates in ##Platform_Name## MultiSelect

The MultiSelect provides several options to customize each list item, group title, selected value, header, and footer element. It uses the Essential<sup style="font-size:70%">&reg;</sup> JS 2 `Template engine` to compile and render the elements properly.

## Item template

The content of each list item within the MultiSelect can be customized with the [itemTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_ItemTemplate) property.

In the following sample, each list item is split into two columns to display relevant data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/itemtemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Itemtemplate.cs" %}
{% include code-snippet/multiselect/templates/itemtemplate/itemtemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/itemtemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Itemtemplate.cs" %}
{% include code-snippet/multiselect/templates/itemtemplate/itemtemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Value template

The currently selected value that is displayed by default on the MultiSelect input element can be customized using the [valueTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_ValueTemplate) property.

In the following sample, the selected value is displayed as a combined text of both `FirstName` and `City` in the MultiSelect input, which is separated by a hyphen.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/valuetemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Valuetemplate.cs" %}
{% include code-snippet/multiselect/templates/valuetemplate/valuetemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/valuetemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Valuetemplate.cs" %}
{% include code-snippet/multiselect/templates/valuetemplate/valuetemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Group template

The group header title under which sub-items are categorized can be customized with the [groupTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_GroupTemplate) property. This template is common for both inline and floating group header templates.

In the following sample, employees are grouped by their city.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/grouptemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Grouptemplate.cs" %}
{% include code-snippet/multiselect/templates/grouptemplate/grouptemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/grouptemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Grouptemplate.cs" %}
{% include code-snippet/multiselect/templates/grouptemplate/grouptemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Header template

The header element is shown statically at the top of the popup list items within the MultiSelect. Any custom element can be placed as a header element using the [headerTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_HeaderTemplate) property.

In the following sample, the list items and their headers are designed and displayed as two columns, similar to multiple columns of a grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/headertemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/multiselect/templates/headertemplate/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/headertemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Headertemplate.cs" %}
{% include code-snippet/multiselect/templates/headertemplate/headertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Footer template

The MultiSelect supports showing a footer element at the bottom of the list items in the popup. You can place any custom element as a footer element using the [footerTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_FooterTemplate) property.

In the following sample, the footer element displays the total number of list items present in the MultiSelect.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/footertemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Footertemplate.cs" %}
{% include code-snippet/multiselect/templates/footertemplate/footertemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/footertemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Footertemplate.cs" %}
{% include code-snippet/multiselect/templates/footertemplate/footertemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## No records template

The MultiSelect supports customizing the popup list content when no data is found and when no matches are found on search, through the [noRecordsTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_NoRecordsTemplate) property.

In the following sample, the popup list content displays a notification that no data is available.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/norecordstemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Norecordstemplate.cs" %}
{% include code-snippet/multiselect/templates/norecordstemplate/norecordstemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/norecordstemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Norecordstemplate.cs" %}
{% include code-snippet/multiselect/templates/norecordstemplate/norecordstemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Action failure template

You can also customize the popup list content when the data fetch request fails at the remote server. This can be done with the [actionFailureTemplate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_ActionFailureTemplate) property.

In the following sample, when the data fetch request fails, the MultiSelect displays a notification.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/actionfailuretemplate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Actionfailuretemplate.cs" %}
{% include code-snippet/multiselect/templates/actionfailuretemplate/actionfailuretemplate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/actionfailuretemplate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Actionfailuretemplate.cs" %}
{% include code-snippet/multiselect/templates/actionfailuretemplate/actionfailuretemplate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Summary Tag Template

The Summary Tag Template feature displays selected items as a formatted summary text in the input field instead of listing all selections individually. This is especially useful in CheckBox mode when working with large datasets and using the SelectAll option, as it significantly improves performance.

The [summaryTagCount](../api/multi-select#summarytagcount) property sets a threshold—when the number of selected items exceeds this threshold, the [summaryTagTemplate](../api/multi-select#summarytagtemplate) displays a custom formatted text instead of individual items.

### Template Placeholder Properties

The following properties are available for use in the summary template placeholders:

| Placeholder | Description |
|-------------|-------------|
| `${selectedCount}` | Total count of currently selected items |
| `${totalCount}` | Total number of items in the data source |

In the following sample, the Summary Tag Template displays the count of selected items when the threshold is exceeded.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/summary-tag-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Summarytagtemplate.cs" %}
{% include code-snippet/multiselect/templates/summary-tag-template/summarytagtemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Records.cs" %}
{% include code-snippet/multiselect/templates/summary-tag-template/records.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/templates/summary-tag-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Summarytagtemplate.cs" %}
{% include code-snippet/multiselect/templates/summary-tag-template/summarytagtemplate.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Records.cs" %}
{% include code-snippet/multiselect/templates/summary-tag-template/records.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> **Limitation:** The Summary Tag Template feature only works in CheckBox mode because it has a built-in SelectAll option for bulk selection, which triggers the need for performance optimization. Other modes (Default, Box, Delimiter) don't support SelectAll and use different display formats, making template-based formatting unnecessary.

> **Note:** When you set a threshold value and preselected items exceed it, the summary template displays formatted text instead of individual items. If `summaryTagTemplate` and `summaryTagCount` are not provided, the Summary Tag Template feature is automatically enabled when records or preselected items exceed 1000, displaying a default summary format for better performance.


## See also

* [How to bind the data](https://ej2.syncfusion.com/aspnetmvc/documentation/multi-select/data-binding)
* [How to group the data using a header](https://ej2.syncfusion.com/aspnetmvc/documentation/multi-select/grouping)
* [How to customize the options in MultiSelect](https://ej2.syncfusion.com/aspnetmvc/documentation/multi-select/chip-customization)