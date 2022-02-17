---
layout: post
title: Show Spinner While Exporting in ##Platform_Name## Grid Component
description: Learn here all about Show Spinner While Exporting in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Show Spinner While Exporting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Show Spinner on Grid when Exporting

You can show/ hide spinner component while exporting the grid using `showSpinner`/ `hideSpinner` methods. You can use `toolbarClick` event to show spinner before exporting and hide a spinner in the `pdfExportComplete` or `excelExportComplete` event after the exporting.

In the `toolbarClick` event, based on the parameter `args.item.id` as `Grid_pdfexport` or `Grid_excelexport` we can call the `showSpinner` method from grid instance.

In the `pdfExportComplete` or `excelExportComplete` event, We can call the `hideSpinner` method.

In the below demo, we have rendered the default spinner component when exporting the grid.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/show-spinner-while-exporting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Show-spinner.cs" %}
{% include code-snippet/grid/how-to/show-spinner-while-exporting/show-spinner.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/show-spinner-while-exporting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Show-spinner.cs" %}
{% include code-snippet/grid/how-to/show-spinner-while-exporting/show-spinner.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

