---
layout: post
title: Virtualization in ##Platform_Name## AutoComplete | Syncfusion
description: Learn here all about Virtualization in Syncfusion ##Platform_Name## AutoComplete control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Virtualization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Virtualization in ##Platform_Name## AutoComplete

AutoComplete virtualization is a technique used to efficiently render extensive lists of items while minimizing the impact on performance. This method is particularly advantageous when dealing with large datasets because it ensures that only a fixed number of DOM (Document Object Model) elements are created. When scrolling through the list, existing DOM elements are reused to display relevant data instead of generating new elements for each item. This recycling process is managed internally.
 
During virtual scrolling, the data retrieved from the data source depends on the popup height and the calculation of the list item height. Enabling the [enableVirtualization](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_EnableVirtualization) option in the AutoComplete control activates this virtualization technique.
 
When fetching data from the data source, the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_ActionBegin) event is triggered before data retrieval begins. Then, the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_ActionComplete) event is triggered once the data is successfully fetched.

By default, when the `enableVirtualization` property is enabled, the `skip` and `take` properties provided by the user within the `Query` class at the initial state or during the `actionBegin` or `actionComplete` events will not be considered, since they are internally managed and calculated based on certain dimensions with respect to the popup height. For details on when a user-provided `take` value is honored, see [Customizing items count in virtualization](#customizing-items-count-in-virtualization).

## Binding local data

The AutoComplete control can generate its list items through an array of complex data. To do this, the appropriate columns should be mapped to the [fields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoComplete.html#Syncfusion_EJ2_DropDowns_AutoComplete_Fields) property. When using virtual scrolling, the list updates based on the scroll offset value, triggering a request to fetch more data from the data source. As the data is being fetched, the `actionBegin` event occurs before the data retrieval starts. Once the data retrieval is successful, the `actionComplete` event is triggered, indicating that the data fetch process is complete.

In the following example, the `text` column from complex data has been mapped to the `value` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/virtual-scroll/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class RecordData
{
    public string ID { get; set; }
    public string Text { get; set; }
    public List<RecordData> RecordList { set; get; }
    public List<RecordData> RecordModelList()
    {
        return Enumerable.Range(1, 150).Select(i => new RecordData()
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
{% include code-snippet/autocomplete/virtual-scroll/razor %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/autocomplete/virtual-scroll/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Binding remote data

The AutoComplete control supports the retrieval of data from remote data services with the help of the `DataManager` component, triggering the `actionBegin` and `actionComplete` events, and then updating the list data. During virtual scrolling, additional data is retrieved from the server, triggering the `actionBegin` and `actionComplete` events at that time as well. The remote service URL and `DataManager` configuration are defined in the markup sample below, while the C# block defines the record model used by the sample.

The following sample displays the OrderId from the `Orders` Data Service.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/virtual-scroll-remote/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class BindingRecord
{
    public string ID { get; set; }
    public string Text { get; set; }
    public List<BindingRecord> RecordList { set; get; }
    public List<BindingRecord> RecordModelList()
    {
        return Enumerable.Range(1, 150).Select(i => new BindingRecord()
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
{% include code-snippet/autocomplete/virtual-scroll-remote/razor %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/autocomplete/virtual-scroll-remote/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customizing items count in virtualization 

When the `enableVirtualization` property is enabled, the `take` property provided by the user within the Query parameter at the initial state or during the `actionBegin` event will be considered. Internally, it calculates the items that fit within the current page (i.e., probably twice the amount of the popup's height). If the user-provided `take` value is less than the minimum number of items that fit into the popup, the user-provided `take` value will not be considered.

The following sample shows the example for Customizing items count in virtualization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/virtual-scroll-items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/autocomplete/virtual-scroll-items/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/virtual-scroll-items/razor %}
{% endhighlight %} 
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/autocomplete/virtual-scroll-items/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Grouping

The AutoComplete control supports grouping with virtualization. It allows you to organize elements into groups based on different categories. Each item in the list can be classified using the [groupBy](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.AutoCompleteFieldSettings.html#Syncfusion_EJ2_DropDowns_AutoCompleteFieldSettings_GroupBy) field in the data table. After grouping, virtualization works similarly to local data binding, providing a seamless user experience. When the data source is bound to remote data, an initial request is made to retrieve all data for the purpose of grouping. Subsequently, the grouped data works in the same way as local data binding virtualization, enhancing performance and responsiveness.

The following sample shows the example for Grouping with Virtualization.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/virtual-scroll-group/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
...
public class GroupingRecord
{
    public string ID { get; set; }
    public string Text { get; set; }
    public string Group { get; set; }
    public List<GroupingRecord> RecordList { set; get; }
    public List<GroupingRecord> RecordModelList()
    {
        Random random = new Random();
        return Enumerable.Range(1, 150).Select(i => new GroupingRecord()
        {
            ID = i.ToString(),
            Text = "Item " + i,
            Group = GetRandomGroup(random),

        }).ToList();
    }
    public string GetRandomGroup(Random random)
    {
        // Generate a random number between 1 and 4 to determine the group
        int randomGroup = random.Next(1, 5);
        switch (randomGroup)
        {
            case 1:
                return "Group A";
            case 2:
                return "Group B";
            case 3:
                return "Group C";
            case 4:
                return "Group D";
            default:
                return string.Empty;
        }
    }
}
{% endhighlight %}
{% endtabs %} 

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/autocomplete/virtual-scroll-group/razor %}
{% endhighlight %}
{% highlight c# tabtitle="virtualscroll.cs" %}
{% include code-snippet/autocomplete/virtual-scroll-group/virtualscroll.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}