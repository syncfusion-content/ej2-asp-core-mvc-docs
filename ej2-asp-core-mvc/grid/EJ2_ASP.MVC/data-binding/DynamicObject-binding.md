---
layout: post
title: DynamicObject binding in Syncfusion ##Platform_Name## Grid Component
description: Learn about DynamicObject binding in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: DynamicObject binding
publishingplatform: ##Platform_Name##
documentation: ug
---

## DynamicObject Binding in ASP.Net MVC Grid Component

The grid is a generic component that is firmly bound to a model type. There are cases when the model type is unknown during the compile type. In such cases, bind data to the grid as a list of DynamicObject.

A DynamicObject can be bound to a data grid by assigning it to the DataSource property. The grid can also perform all kinds of supported data operations and editing in DynamicObject.

N> You must override the [GetDynamicMemberNames](https://learn.microsoft.com/en-us/dotnet/api/system.dynamic.dynamicobject.getdynamicmembernames?view=netcore-3.1) method of the DynamicObject class and return the property names to perform data operation and editing while using DynamicObject.

The following code example shows how to bind DynamicObject datasource in grid using URL adaptor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject-Binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject-Binding/dynamicObject.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject-Binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject-Binding/dynamicObject.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## DynamicObject Complex Binding in ASP.Net MVC Grid Component

You can achieve DynamicObject complex data binding in the data grid by using the dot(.) operator in the `column.field`. In the following examples, Customer.OrderDate, Customer.Freight, and Customer.ShipCountry are complex data.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding/dynamicObject.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject-ComplexBinding/dynamicObject.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N>Perform data and CRUD operations for complex DynamicObject binding fields as well.

The following image represents DynamicObject complex data binding.
![Grid with DynamicObject Binding](images/DynamicObject-binding.png)
