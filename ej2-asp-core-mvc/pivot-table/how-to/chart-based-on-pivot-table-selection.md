---
layout: post
title: Chart Based On Pivot Table Selection in ##Platform_Name## Pivot Table Component
description: Learn here all about Chart Based On Pivot Table Selection in Syncfusion ##Platform_Name## Pivot Table component and more.
platform: ej2-asp-core-mvc
control: Chart Based On Pivot Table Selection
publishingplatform: ##Platform_Name##
documentation: ug
---

# Render chart control based on cell selection

The cell selection support is enabled using the `allowSelection` property and its type and mode are configured using the `selectionSettings` property. The `cellSelected` event gets fired on every selection operation performed in the pivot table. This event returns the selected cell informations, like row header name, column header name, measure name, and value. Based on this information, the `chart` control will be plotted.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/chart/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Popup.cs" %}
{% include code-snippet/pivot-table/field-list/chart/Popup.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/pivot-table/field-list/chart/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Popup.cs" %}
{% include code-snippet/pivot-table/field-list/chart/Popup.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![output](images/chart-selection.png)