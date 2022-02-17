---
layout: post
title: Row Template in ##Platform_Name## Grid Component
description: Learn here all about Row Template in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Row Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Row Template

The **rowTemplate** has an option to customise the look and behavior of the grid rows. The [`rowTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowTemplate) property accepts either
the **template** string or HTML element ID.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Row-template.cs" %}
{% include code-snippet/grid/row/row-template/row-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/row/row-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Row-template.cs" %}
{% include code-snippet/grid/row/row-template/row-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



>The [`rowTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_RowTemplate) property accepts only the TR element.