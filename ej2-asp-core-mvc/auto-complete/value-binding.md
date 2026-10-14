---
layout: post
title: Value Binding in ##Platform_Name## AutoComplete | Syncfusion
description: Learn here all about Value Binding in Syncfusion ##Platform_Name## AutoComplete control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Value Binding
publishingplatform: ##Platform_Name##
documentation: ug
---

# Value Binding in ##Platform_Name## AutoComplete

Value binding in the AutoComplete control allows you to associate data values with each list item. This facilitates managing and retrieving selected values efficiently. The AutoComplete control provides flexibility in binding both primitive data types and object data types.

## Primitive data types

The AutoComplete control provides flexible binding capabilities for primitive data types such as strings, numbers, and booleans. You can bind local primitive data arrays, fetch and bind data from remote sources, and customize data binding to suit specific requirements. Bind the primitive value to the [value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_Value) property of the AutoComplete.

Primitive data types include:

* String
* Number
* Boolean
* Null

The following sample shows how to preselect a value for a primitive data type.

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


## Object data types

In the AutoComplete control, object binding allows you to bind to a dataset of objects. When [`allowObjectBinding`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_AllowObjectBinding) is enabled, the value of the control will be an object of the same type as the selected item. Map the object's fields using the [fields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_Fields) property so the control can resolve the value member.

This feature seamlessly binds arrays of objects, whether sourced locally, retrieved from remote endpoints, or customized to suit specific application needs.

The following sample shows how to preselect a value for an object data type.

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
