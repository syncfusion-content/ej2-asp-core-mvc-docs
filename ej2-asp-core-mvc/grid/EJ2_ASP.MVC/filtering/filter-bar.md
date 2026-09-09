---
layout: post
title: ##Platform_Name## Grid Filter Bar | Syncfusion
description: Learn how to use Filter Bar in ##Platform_Name## Data Grid with expression operators, configurable modes, column settings, templates, and status display.
platform: ej2-asp-core-mvc
control: Filter Bar
publishingplatform: ##Platform_Name##
documentation: ug
---

# Filter Bar in ASP.NET MVC Data Grid

The filter bar feature provides a row of input fields directly below the grid headers, enabling column-based data filtering. Each column displays an input field where filter criteria can be entered, and filtering can be applied depending on the configured filter mode to show matching results.

## Enable filter bar

To activate the filter bar, set the [AllowFiltering](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.grids.grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) to `true`.

**Filter bar expressions:**

Filter expressions are operators that define the comparison between entered values and data in the Data Grid. The available operators depend on the column data type.

| Expression | Example | Description | Column Type |
|------------|---------|-------------|-------------|
| = | =value | Matches values exactly equal to the entered value | Number |
| != | !=value | Matches values not equal to the entered value | Number |
| > | >value | Matches values greater than the entered value | Number |
| < | <value | Matches values less than the entered value | Number |
| >= | >=value | Matches values greater than or equal to the entered value | Number |
| <= | <=value | Matches values less than or equal to the entered value | Number |
| * | *value | Matches values that start with the entered text | String |
| % | %value | Matches values that end with the entered text | String |
| N/A | N/A | Always uses equal operator for Date columns | Date |
| N/A | N/A | Always uses equal operator for Boolean columns | Boolean |

The following example demonstrates basic filter bar activation in the grid:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filter-bar.cs" %}
{% include code-snippet/grid/filtering/filter-bar/filter-bar.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/filterbar.png)

> To enable or dynamically switch the filter type, you must set the [FilterSettings.Type](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Type) as `FilterBar`.

## Filter bar modes

The Data Grid filter bar operates in two distinct modes that determine when filtering actions are triggered. These modes support different interaction patterns based on application requirements and performance considerations.

**onEnter Mode:**

When [FilterSettings.Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Mode) is set to `onEnter`, the filter bar captures filter criteria but delays filtering execution until the <kbd>Enter</kbd> key is pressed. This mode is beneficial when:

- Complex filter criteria need to be entered without triggering multiple filtering operations.
- Large datasets are involved where immediate filtering may cause performance issues.
- Filter criteria need to be reviewed and confirmed before applying changes.

**Immediate Mode:**

When [FilterSettings.Mode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_Mode) is set to `Immediate`, the filter bar applies filtering as filter criteria are typed or modified. This mode provides:

- Real-time filtering feedback and immediate result previews.
- A responsive search experience for quick data lookups.
- Instant visual confirmation of filter effects.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-bar-mode/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filter-bar.cs" %}
{% include code-snippet/grid/filtering/filter-bar-mode/filter-bar.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/filterbarmode.gif)

## Display filter status in pager

The [ShowFilterBarStatus](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_ShowFilterBarStatus) property displays the current filter criteria in the grid pager area. This provides a clear summary of active filters without examining each column's filter bar input.

**When to use**: Enable this option for complex multi-column filters to maintain awareness of all active filtering criteria. This is particularly useful when filters are applied across columns that are scrolled out of view.

The following example shows filter status display in the pager:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/display-filter-text-pager/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filter-bar.cs" %}
{% include code-snippet/grid/filtering/display-filter-text-pager/filter-bar.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/filterbar-status.png)

## Show or hide filter operators in the filter bar

The [ShowFilterBarOperator](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_ShowFilterBarOperator) property displays a dropdown in each filter bar cell, allowing the filter operator to be changed directly in the UI. By default, string columns use the `startswith` operator, but this can be changed to `contains`, `endswith`, `equal`, etc.

To display the operator dropdown in filter bar cells, set the [ShowFilterBarOperator](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridFilterSettings.html#Syncfusion_EJ2_Grids_GridFilterSettings_ShowFilterBarOperator) property of the `FilterSettings` configuration to `true`. By default, this property is set to `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/show-hide-filter-bar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filter-bar.cs" %}
{% include code-snippet/grid/filtering/show-hide-filter-bar/filter-bar.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/filterbar-show-hide-cell.png)

## Prevent filtering for particular column

The Data Grid can prevent filtering for a specific column by using the [AllowFiltering](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_AllowFiltering) property of the [Column](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumns.html) object and setting it to `false`.

Here's an example that demonstrates how to remove the filter bar for the "Customer ID" column in Data Grid:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-bar-particular/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filter-bar.cs" %}
{% include code-snippet/grid/filtering/filter-bar-particular/filter-bar.cs %}
{% endhighlight %}
{% endtabs %}

## Hide filter bar for template column

Template columns can be used to render images, action buttons, or other custom components that are inherently non-filterable. To completely hide the filter bar input for a template column, use the [FilterTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_FilterTemplate) property with an empty element.

The following example demonstrates hiding the filter bar for a template column:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/hide-filter-bar-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filter-bar.cs" %}
{% include code-snippet/grid/filtering/hide-filter-bar-template/filter-bar.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/filterbar-hide-template.png)

## Filter bar template with custom component

The [FilterBarTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_FilterBarTemplate) property replaces the default text input with a custom component in the filter bar. This allows using specialized input controls like date pickers, dropdowns, or numeric inputs that provide a better filtering experience for specific data types.

Custom filter bar templates are particularly useful when:
- The default text input does not provide optimal interaction for specific data types.
- Specialized filtering controls are required for complex data structures.
- Application design requires consistent component usage across the interface.
- Guided input through dropdown selections or date pickers is required.

To implement a custom filter bar template, define the `FilterBarTemplate` property within the column configuration:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/filtering/filter-bar-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="filter-bar.cs" %}
{% include code-snippet/grid/filtering/filter-bar-template/filter-bar.cs %}
{% endhighlight %}
{% endtabs %}

![Filter bar](../images/filtering/filterbar-template.png)


## See also

* [How to perform filter by using Wildcard and LIKE operator filter](./filtering#wildcard-and-like-filters)