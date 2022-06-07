---
layout: post
title: Data Annotation in ##Platform_Name## Grid Component
description: Learn here all about Data Annotation in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Data Annotation in ASP.NET Core DataGrid Component

Data Annotations help you to define rules to the model classes or properties to perform data validation and display suitable messages to the end users.

The Data Annotation can be enabled by setting the `TValue` property of the Grid which maps data annotations to the corresponding DataGrid Column property.

> The Grid Properties has more priority than the Data Annotation. For Instance, if the DisplayName Attribute is set to a Field in the Grid Model class and set the different value to the respective Grid Columns property HeaderText, the value of the HeaderText property will be considered and shown in the Grid header.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-annotation/annotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/grid/data-annotation/annotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-annotation/annotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/grid/data-annotation/annotation/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


