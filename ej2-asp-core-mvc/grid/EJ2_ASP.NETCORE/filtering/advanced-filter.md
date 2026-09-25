---
layout: post
title: ##Platform_Name## Grid Advanced Filter | Syncfusion
description: Learn how to use Advanced Filter in ##Platform_Name## Data Grid with Query Builder, multiple conditions, and logical operators.
platform: ej2-asp-core-mvc
control: Advanced Filter
publishingplatform: ##Platform_Name##
documentation: ug
---

# Advanced Filtering in ASP.NET Core Data Grid

The Syncfusion<sup style="font-size:70%">&reg;</sup> Grid component provides advanced filtering functionality through the Query Builder interface, which enables the definition of complex filtering conditions with multiple criteria and logical operators.

## Enable advanced filtering

Advanced filtering is enabled by setting the `allowAdvancedFiltering` property to `true`. This adds an **Filter** button to the toolbar, which opens the Query Builder dialog for creating advanced filter conditions.

To use advanced filtering, inject the [AdvancedFilter](../../api/grid/advancedfilter) module into the Grid along with the other required modules.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/advanced-filter-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="excelfilter.cs" %}
{% include code-snippet/grid/filtering/advanced-filter-cs1/advancedfilter.cs %}
{% endhighlight %}
{% endtabs %}

## Initial filter

Initial filter conditions can be set and applied automatically when the Grid loads. The `advancedFilterSettings` property with `queryBuilderSettings` is used to define the initial rule.

The following example demonstrates setting initial advanced filter conditions during Grid initialization, displaying only tickets with a priority of **High** and a status other than **Done**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/advanced-filter-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="excelfilter.cs" %}
{% include code-snippet/grid/filtering/advanced-filter-cs2/advancedfilter.cs %}
{% endhighlight %}
{% endtabs %}

> By default, hidden columns are not included in the advanced filter builder. Setting `advancedFilterSettings.includeHiddenColumns` to `true` displays hidden columns in the Query Builder, enabling filter conditions to be created using their values.

## Events

The Advanced Filter feature provides four events for customizing the dialog and filter operations.

1. The [advancedFilterOpen](../../api/grid#advancedfilteropen) event is triggered when the Advanced Filter dialog opens. The event arguments provide access to the dialog and Query Builder instances.
2. The [advancedFilterClose](../../api/grid#advancedfilterclose) event is triggered when the Advanced Filter dialog closes. Set the `cancel` property to `true` to prevent the dialog from closing.
3. The [advancedFilterActionBegin](../../api/grid#advancedfilteractionbegin) event is triggered before a filter is applied or cleared. Set the `cancel` property to `true` to prevent the operation. The event arguments include the filter rule, dialog instance, and Query Builder instance.
4. The [advancedFilterActionComplete](../../api/grid#advancedfilteractioncomplete) event is triggered after a filter is applied or cleared. Set the `cancel` property to `true` to keep the Advanced Filter dialog open after the operation.

## Methods

The Advanced Filter feature provides the following methods for controlling the dialog and managing filter rules programmatically:

1. The [openAdvancedFilterDialog](../../api/grid#openadvancedfilterdialog) method opens the Advanced Filter dialog.
2. The [closeAdvancedFilterDialog](../../api/grid#closeadvancedfilterdialog) method closes the Advanced Filter dialog.
3. The [applyAdvancedFilter](../../api/grid#applyadvancedfilter) method applies the specified filter rule to the Grid.
4. The [getPredicateFromRule](../../api/grid#getpredicatefromrule) method converts a filter rule into a query predicate.
5. The [clearAdvancedFilter](../../api/grid#clearadvancedfilter) method clears the applied Advanced Filter and restores the original data view.
6. The [getAdvancedFilter](../../api/grid#getadvancedfilter) method retrieves the currently configured filter rule.
7. The [setAdvancedFilter](../../api/grid#setadvancedfilter) method sets the specified rule as the current rule configuration in the Advanced Filter Query Builder.
8. The [isAdvancedFilterApplied](../../api/grid#isadvancedfilterapplied) method checks whether an Advanced Filter is currently applied.

The following example demonstrates how to use these methods to open and close the dialog, apply and clear a rule, set and retrieve the current rule, convert a rule to a predicate, and check whether filtering is applied.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/advanced-filter-cs3/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="excelfilter.cs" %}
{% include code-snippet/grid/filtering/advanced-filter-cs3/advancedfilter.cs %}
{% endhighlight %}
{% endtabs %}
