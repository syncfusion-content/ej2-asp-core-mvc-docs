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

Data Annotation helps you define rules for the model class to perform data validation and display suitable messages to end users as validation message in the edit form.

The Data Annotation can be enabled by referencing the **System.ComponentModel.DataAnnotations** namespace which maps data annotation to the corresponding DataGrid Column property.

> The DataGrid Property has more priority than the Data Annotation. For Instance, if the DisplayName Attribute is set to a Field in the DataGrid model class and the HeaderText is set to the same DataGrid column property, the value of the HeaderText property will be considered and shown in the DataGrid header.

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

## Data Annotation with Auto Generated columns

Columns are automatically generated when columns declaration is empty or undefined while rendering the Grid. All the columns in the datasource are bound as grid columns.

Data Annotation can be enabled by referencing the **System.ComponentModel.DataAnnotations** namespace which maps data annotation to the dataGrid.

The following sample demonstrates to perform Data annotation with auto generated columns.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-annotation-auto/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/grid/data-annotation-auto/annotation.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-annotation-auto/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% include code-snippet/grid/data-annotation-auto/annotation.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}