---
layout: post
title: Import an excel document using file uploader in ##Platform_Name## Spreadsheet Control | Syncfusion
description: Learn here all about import an excel document using file uploader in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spreadsheet
publishingplatform: ##Platform_Name##
documentation: ug
---

## Import an excel document using file uploader in ##Platform_Name## Spreadsheet control

If you explore your machine to select and upload an excel document using the file uploader, you will receive the uploaded document as a raw file in the `success` event of the file uploader. In this `success` event, you should pass the received raw file as an argument to the Spreadsheet's `open` method to see the appropriate output.

The following code example shows how to import an excel document using file uploader in spreadsheet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open-uploader/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Opencontroller.cs" %}
{% include code-snippet/spreadsheet/open-uploader/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/open-uploader/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Opencontroller.cs" %}
{% include code-snippet/spreadsheet/open-uploader/opencontroller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
