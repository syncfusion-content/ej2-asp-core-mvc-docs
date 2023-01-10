---
layout: post
title: Validation in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Validation in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Validation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Validation in ##Platform_Name## Tree Grid Component

## Column validation

Column validation allows you to validate the edited or added row data and it display errors for invalid fields before saving data. TreeGrid uses **Form Validator** component for column validation. You can set validation rules by defining the [`validationRules`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~ValidationRules.html) in [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/validation-rules/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ValidationRule.cs" %}
{% include code-snippet/tree-grid/editing/validation-rules/validationRule.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/validation-rules/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ValidationRule.cs" %}
{% include code-snippet/tree-grid/editing/validation-rules/validationRule.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom validation

You can define your own custom validation rules for the specific columns by using **Form Validator custom rules**.

In the below demo, custom validation applied for **Priority** column.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/custom-validation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ValidationRule.cs" %}
{% include code-snippet/tree-grid/editing/custom-validation/validationRule.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/custom-validation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ValidationRule.cs" %}
{% include code-snippet/tree-grid/editing/custom-validation/validationRule.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.