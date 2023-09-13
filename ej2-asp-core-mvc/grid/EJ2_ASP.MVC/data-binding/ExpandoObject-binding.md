---
layout: post
title: ExpandoObject binding in Syncfusion ##Platform_Name## Grid Component
description: Learn about ExpandoObject binding in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: ExpandoObject binding
publishingplatform: ##Platform_Name##
documentation: ug
---

## ExpandoObject Binding in ASP.Net MVC Grid Component

The grid is a generic component that is firmly bound to a model type. There are cases when the model type is unknown during the compile type. In such cases, bind data to the grid as a list of the ExpandoObject.

The ExpandoObject can be bound to the data grid by assigning it to the DataSource property. The grid can also perform all kinds of supported data operations and editing in ExpandoObject.

The following code example shows how to bind ExpandoObject datasource in grid using URL adaptor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/expandoObject-Binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="expandoObject.cs" %}
{% include code-snippet/grid/data-binding/expandoObject-Binding/expandoObject.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/expandoObject-Binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="expandoObject.cs" %}
{% include code-snippet/grid/data-binding/expandoObject-Binding/expandoObject.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## ExpandoObject Complex Binding in ASP.Net MVC Grid Component

You can achieve ExpandoObject complex data binding in the data grid by using the dot(.) operator in the column.field. In the following examples, Customer.OrderDate, Customer.Freight, and Customer.ShipCountry are complex data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="expandoObject.cs" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding/expandoObject.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="expandoObject.cs" %}
{% include code-snippet/grid/data-binding/expandoObject-ComplexBinding/expandoObject.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> Perform data and CRUD operations for Complex ExpandoObject binding fields as well.

The following image represents ExpandoObject complex data binding.
![Grid with ExpandoObject Binding](images/ExpandoObject-binding.png)