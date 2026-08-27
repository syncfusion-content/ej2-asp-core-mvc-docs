---
layout: post
title: Value Binding in ##Platform_Name## DropDownList | Syncfusion
description: Bind Syncfusion ##Platform_Name## DropDownList to primitive or complex objects using value, text, and fields with two-way binding.
platform: ej2-asp-core-mvc
control: Value Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Value Binding in ##Platform_Name## DropDownList

Value binding in the DropDownList control allows you to associate data values with each list item. This facilitates managing and retrieving selected values efficiently. The DropDownList component provides flexibility in binding both primitive data types and complex objects.

## Primitive data types

The DropDownList control provides flexible binding capabilities for primitive data types like strings and numbers. You can effortlessly bind local primitive data arrays, fetch and bind data from remote sources, and even perform custom data binding to suit specific requirements. Bind the value of primitive data to the [value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Value) property of the DropDownList.

Primitive data types include:

* String
* Number
* Boolean
* Null

The following sample shows an example of preselecting values for primitive data type

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/primitive/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofstrings.cs" %}
{% include code-snippet/dropdownlist/primitive/primitive.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/primitive/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofstrings.cs" %}
{% include code-snippet/dropdownlist/primitive/primitive.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Object data types

In the DropDownList control, object binding allows you to bind to a dataset of objects. When [`AllowObjectBinding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_AllowObjectBinding) is enabled, the value of the control will be an object of the same type as the selected item in the [Value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Value) property. This feature seamlessly binds arrays of objects, whether sourced locally or retrieved from remote endpoints.

The following sample shows an example of preselecting values for object data type

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/object/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Vegetables.cs" %}
{% include code-snippet/dropdownlist/object/object.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/object/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Vegetables.cs" %}
{% include code-snippet/dropdownlist/object/object.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

