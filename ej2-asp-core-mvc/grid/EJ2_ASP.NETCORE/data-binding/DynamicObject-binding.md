---
layout: post
title: DynamicObject binding in Syncfusion ##Platform_Name## Grid Component
description: Learn here all about DynamicObject binding in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: DynamicObject binding
publishingplatform: ##Platform_Name##
documentation: ug
---

## DynamicObject binding in ASP.Net MVC Grid Component

Grid is a generic component which is strongly bound to a model type. There are cases when the model type is unknown during compile type. In such cases you can bound data to the grid as list of DynamicObject.

DynamicObject can be bound to datagrid by assigning to the DataSource property. Grid can also perform all kind of supported data operations and editing in DynamicObject.

N> The GetDynamicMemberNames method of DynamicObject class must be overridden and return the property names to perform data operation and editing while using DynamicObject.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject/dynamicObject.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/dynamicObject/razor %}
{% endhighlight %}
{% highlight c# tabtitle="dynamicObject.cs" %}
{% include code-snippet/grid/data-binding/dynamicObject/dynamicObject.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## DynamicObject Complex binding in ASP.Net MVC Grid Component

You can achieve DynamicObject complex data binding in the datagrid by using the dot(.) operator in the column.field. In the following examples, CustomerID.Name and ShipCountry.Country are complex data.

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

N> You can perform the Data operations and CRUD operations for Complex DynamicObject binding fields too.

The following image represents DynamicObject complex data binding,
![Grid with DynamicObject Binding](images/DynamicObject-binding.png)