---
layout: post
title: Hide Sorting In Excel Filter in ##Platform_Name## Grid Component
description: Learn here all about Hide Sorting In Excel Filter in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Hide Sorting In Excel Filter
publishingplatform: ##Platform_Name##
documentation: ug
---


# Hide sorting options on excel filter Dialog

You can hide the sorting options on the excel filter dialog by setting display as none for the following classes.

```css
    .e-excel-ascending,
    .e-excel-descending,
    .e-separator.e-excel-separator {
    display: none;
    }
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/disable-sorting-excel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disable-sorting-excel.cs" %}
{% include code-snippet/grid/how-to/disable-sorting-excel/disable-sorting-excel.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/disable-sorting-excel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disable-sorting-excel.cs" %}
{% include code-snippet/grid/how-to/disable-sorting-excel/disable-sorting-excel.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


