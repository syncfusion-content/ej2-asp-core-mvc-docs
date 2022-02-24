---
layout: post
title: Validation in ##Platform_Name## Grid Component
description: Learn here all about Validation in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Validation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Validation

## Column validation

Column validation allows you to validate the edited or added row data and it display errors for invalid fields before saving data.
Grid uses **Form Validator** component for column validation.
You can set validation rules in [`validationRules`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html#Syncfusion_EJ2_Grids_GridColumn_ValidationRules) property of [`e-grid-column`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridColumn.html) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/columnvalid/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Columnvalid.cs" %}
{% include code-snippet/grid/edit/columnvalid/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/columnvalid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Columnvalid.cs" %}
{% include code-snippet/grid/edit/columnvalid/columnvalid.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom validation

You can define your own custom validation rules for the specific columns by using **Form Validator custom rules**.

In the below demo, custom validation applied for **CustomerID** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/customvalidation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customvalidation.cs" %}
{% include code-snippet/grid/edit/customvalidation/customvalidation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/customvalidation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customvalidation.cs" %}
{% include code-snippet/grid/edit/customvalidation/customvalidation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

