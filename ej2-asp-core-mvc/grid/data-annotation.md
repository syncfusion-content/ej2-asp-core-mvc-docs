---
layout: post
title: ##Platform_Name## Grid Data Annotation | Syncfusion
description: Learn how to use data annotations in ##Platform_Name## Data Grid to enable model validation, display attributes, and custom validation messages.
platform: ej2-asp-core-mvc
control: Data Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Data Annotation in ##Platform_Name## Data Grid

Data Annotation helps you define rules for the model class to perform data validation and display suitable messages to end users as validation message in the edit form.

The Data Annotation can be enabled by referencing the **System.ComponentModel.DataAnnotations** namespace which maps data annotation to the corresponding DataGrid Column property.

N> The DataGrid Property has more priority than the Data Annotation. For Instance, if the DisplayName Attribute is set to a Field in the DataGrid model class and the HeaderText is set to the same DataGrid column property, the value of the HeaderText property will be considered and shown in the DataGrid header.

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

