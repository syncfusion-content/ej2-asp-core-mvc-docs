---
layout: post
title: Model Binding in ##Platform_Name## Query Builder | Syncfusion
description: Learn how to configure model binding in ##Platform_Name## Query Builder using the fieldModel, operatorModel, and valueModel properties.
platform: ej2-asp-core-mvc
control: Model Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Model Binding in ##Platform_Name## Query Builder

Model binding allows to bind properties for the components used in field, operator, and value columns. To implement model binding, assign [`fieldModel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.QueryBuilder.QueryBuilder.html#Syncfusion_EJ2_QueryBuilder_QueryBuilder_FieldModel), [`operatorModel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.QueryBuilder.QueryBuilder.html#Syncfusion_EJ2_QueryBuilder_QueryBuilder_OperatorModel), and [`valueModel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.QueryBuilder.QueryBuilder.html#Syncfusion_EJ2_QueryBuilder_QueryBuilder_ValueModel) properties in QueryBuilder.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/model-binding/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/model-binding/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/model-binding/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/model-binding/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

