---
layout: post
title: Value Binding in ##Platform_Name## Combo Box Control | Syncfusion
description: Learn here all about Value Binding in Syncfusion ##Platform_Name## Combo Box control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Value Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Value binding in ComboBox Component

Value binding in the ComboBox control allows you to associate data values with each list item. This facilitates managing and retrieving selected values efficiently. The ComboBox component provides flexibility in binding both primitive data types and complex objects.

## Primitive Data Types

The ComboBox control provides flexible binding capabilities for primitive data types like strings and numbers. You can effortlessly bind local primitive data arrays, fetch and bind data from remote sources, and even custom data binding to suit specific requirements. Bind the value of primitive data to the [value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.ComboBox.html#Syncfusion_EJ2_DropDowns_ComboBox_Value) property of the ComboBox.

Primitive data types include:

* String
* Number
* Boolean
* Null

The following sample shows the example for preselect values for primitive data type

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/primitive/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/primitive/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofstrings.cs" %}
{% include code-snippet/combobox/primitive/primitive.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Object Data Types

In the ComboBox control, object binding allows you to bind to a dataset of objects. When [`allowObjectBinding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.ComboBox.html#Syncfusion_EJ2_DropDowns_ComboBox_AllowObjectBinding) is enabled, the value of the control will be an object of the same type as the selected item in the [value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.ComboBox.html#Syncfusion_EJ2_DropDowns_ComboBox_Value) property. This feature seamlessly binds arrays of objects, whether sourced locally, retrieved from remote endpoints, or customized to suit specific application needs.

The following sample shows the example for preselect values for object data type

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/object/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/object/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofobjects.cs" %}
{% include code-snippet/combobox/object/object.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

