---
layout: post
title: Value Binding in ##Platform_Name## Auto Complete Control | Syncfusion
description: Learn here all about Value Binding in Syncfusion ##Platform_Name## Auto Complete control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Value Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Value binding in AutoComplete Component

Value binding in the AutoComplete control allows you to associate data values with each list item. This facilitates managing and retrieving selected values efficiently. The AutoComplete component provides flexibility in binding both primitive data types and complex objects.

## Primitive Data Types

The AutoComplete control provides flexible binding capabilities for primitive data types like strings and numbers. You can effortlessly bind local primitive data arrays, fetch and bind data from remote sources, and even custom data binding to suit specific requirements. Bind the value of primitive data to the [value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_Value) property of the AutoComplete.

Primitive data types include:

* String
* Number
* Boolean
* Null

The following sample shows the example for preselect values for primitive data type

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/primitive/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/primitive/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofstrings.cs" %}
{% include code-snippet/autocomplete/primitive/primitive.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Object Data Types

In the AutoComplete control, object binding allows you to bind to a dataset of objects. When [`allowObjectBinding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_AllowObjectBinding) is enabled, the value of the control will be an object of the same type as the selected item in the [value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_Value) property. This feature seamlessly binds arrays of objects, whether sourced locally, retrieved from remote endpoints, or customized to suit specific application needs.

The following sample shows the example for preselect values for object data type

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/object/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class Record
{
    public string ID { get; set; }
    public string Text { get; set; }
    public List<Record> RecordList { set; get; }
    public List<Record> RecordModelList()
    {
        return Enumerable.Range(1, 150).Select(i => new Record()
        {
            ID = i.ToString(),
            Text = "Item " + i,
        }).ToList();
    }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/object/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Arrayofobjects.cs" %}
{% include code-snippet/autocomplete/object/object.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
