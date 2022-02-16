---
layout: post
title: Content in ##Platform_Name## Grid Component
description: Learn here all about Content in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Content
publishingplatform: ##Platform_Name##
documentation: ug
---

# Displaying the HTML content

The HTML tags can be displayed in the Grid header and content by enabling the [`disableHtmlEncode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_DisableHtmlEncode) property of **e-grid-column** tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/html/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/cell/html/html.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/cell/html/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Html.cs" %}
{% include code-snippet/grid/cell/html/html.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

