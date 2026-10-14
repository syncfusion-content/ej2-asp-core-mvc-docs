---
layout: post
title: Checkbox in ##Platform_Name## MultiSelect | Syncfusion
description: Enable Syncfusion ##Platform_Name## MultiSelect checkbox selection by setting mode to CheckBox and configuring showSelectAll, change, or selecting events.
platform: ej2-asp-core-mvc
control: Checkbox
publishingplatform: ##Platform_Name##
documentation: ug
---


# Checkbox in ##Platform_Name## MultiSelect

The MultiSelect has built-in support to select multiple values through a checkbox when the [mode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_Mode) property is set to `CheckBox`.

To use the checkbox selection, inject the `CheckBoxSelection` module into the MultiSelect.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/checkbox/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GameList.cs" %}
{% include code-snippet/multiselect/checkbox/default/GameList.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/checkbox/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GameList.cs" %}
{% include code-snippet/multiselect/checkbox/default/GameList.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Select all

The MultiSelect control has built-in support to select all list items using a **Select All** option in the header.

When the [showSelectAll](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_ShowSelectAll) property is set to true, the **Select All** text is shown by default. You can customize the text of the **Select All** option by using [selectAllText](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_SelectAllText).

For the **Unselect All** option, the default text is **Unselect All**. You can customize the text of the **Unselect All** option by using `unSelectAllText`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/checkbox/selectall/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GameList.cs" %}
{% include code-snippet/multiselect/checkbox/selectall/GameList.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/checkbox/selectall/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GameList.cs" %}
{% include code-snippet/multiselect/checkbox/selectall/GameList.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Selection limit

Defines the upper limit of the selected items using [maximumSelectionLength](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_MaximumSelectionLength).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/checkbox/limits/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GameList.cs" %}
{% include code-snippet/multiselect/checkbox/limits/GameList.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/checkbox/limits/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GameList.cs" %}
{% include code-snippet/multiselect/checkbox/limits/GameList.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Selection reordering

Use [enableSelectionOrder](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.MultiSelect.html#Syncfusion_EJ2_DropDowns_MultiSelect_EnableSelectionOrder) to reorder the selected items in popup visibility state.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/checkbox/reorder/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Gamelist.cs" %}
{% include code-snippet/multiselect/checkbox/reorder/gamelist.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/multiselect/checkbox/reorder/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Gamelist.cs" %}
{% include code-snippet/multiselect/checkbox/reorder/gamelist.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See also

* [How to bind the data](./data-binding)
* [How to filter the bound data](./filtering)
* [How to add a custom value to the MultiSelect](./custom-value)
* [How to render checkbox grouping in the MultiSelect](./grouping#grouping-with-checkbox)
