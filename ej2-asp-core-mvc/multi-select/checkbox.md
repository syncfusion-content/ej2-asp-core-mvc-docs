---
layout: post
title: Checkbox in ##Platform_Name## Multi Select Component
description: Learn here all about Checkbox in Syncfusion ##Platform_Name## Multi Select component and more.
platform: ej2-asp-core-mvc
control: Checkbox
publishingplatform: ##Platform_Name##
documentation: ug
---


# CheckBox

The MultiSelect has built-in support to select multiple values through checkbox,
when [mode](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~Mode.html) property set as `CheckBox`.

To use checkbox, inject the `CheckBoxSelection` module in the MultiSelect.

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



## Select All

The MultiSelect control has in-built support to select the all list items using `Select All` options in the header.

When the [showSelectAll](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~ShowSelectAll.html) property is set to true, by default Select All text will show.
You can customize the name attribute of the Select All option by using
[selectAllText](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~SelectAllText.html).

For the unSelect All option, by default unSelect All text will show.
You can customize the name attribute of the unSelect All option by using
`unSelectAllText`.

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



## Selection Limit

Defines the limit of the selected items using [maximumSelectionLength](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~MaximumSelectionLength.html).

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



## Selection Reordering

Using [enableSelectionOrder](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~EnableSelectionOrder.html) to Reorder the selected items in popup visibility state.

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



## See Also

* [How to bind the data](./data-binding/)
* [How to filter the bound data](./filtering/)
* [How to add custom value to the MultiSelect](./custom-value/)
* [How to render checkbox in grouping to the MultiSelect](./grouping/#grouping-with-checkbox).
