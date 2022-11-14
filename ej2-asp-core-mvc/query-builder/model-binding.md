---
layout: post
title: Model binding in ##Platform_Name## Syncfusion Query Builder Component
description: Learn here all about Model binding in Syncfusion ##Platform_Name## Query Builder component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Model Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Model Binding Support

Model binding allows to bind properties for the components used in field, operator, and value columns. To implement model binding, assign FieldModel, OperatorModel, and ValueModel properties in QueryBuilder.

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

