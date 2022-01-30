---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Exporting Selected Data of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Exporting Selected Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# Exporting the Selected Records

You can export the selected records data by passing it to `exportProperties.dataSource` Property in the `toolbarClick` event.

In the below exporting demo, We can get the selected records using `getSelectedRecords` method and pass the selected data to `PdfExport` or `excelExport` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="tagHelper" %}
{% include code-snippet/grid/how-to/export-selected-data/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="selected-data" %}
{% include code-snippet/grid/how-to/export-selected-data/selected-data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="razor" %}
{% include code-snippet/grid/how-to/export-selected-data/razor %}
{% endhighlight %}
{% highlight c# tabtitle="selected-data" %}
{% include code-snippet/grid/how-to/export-selected-data/selected-data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

