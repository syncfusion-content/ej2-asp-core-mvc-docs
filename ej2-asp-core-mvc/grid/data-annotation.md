---
layout: post
title: Data Annotation in ##Platform_Name## Grid Component
description: Learn here all about Data Annotation in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Data Annotation in Grid Component

Data Annotations help you to define rules to the model classes or properties to perform data validation and display suitable messages to end users.

The Data Annotation can be enabled by referencing the **System.ComponentModel.DataAnnotations** namespace which maps data annotations to the corresponding DataGrid Column property.

> The DataGrid Property has more priority than the Data Annotation. For Instance, if the DisplayName Attribute is set to a Field in the DataGrid Model class and the HeaderText is set to the same DataGrid column property, the value of the HeaderText property will be considered and shown in the DataGrid header.

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