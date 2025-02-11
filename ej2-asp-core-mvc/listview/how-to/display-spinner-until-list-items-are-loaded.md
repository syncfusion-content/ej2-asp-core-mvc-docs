---
layout: post
title: Display Spinner Until list items Are Loaded in ##Platform_Name## ListView Control
description: Learn here all about Display Spinner Until list items Are Loaded in Syncfusion ##Platform_Name## ListView control of syncfusion and more.
platform: ej2-asp-core-mvc
control: Display Spinner Until list items Are Loaded
publishingplatform: ##Platform_Name##
documentation: ug
---

# Display spinner until list items are loaded

The features of the ListView control such as remote data-binding take more time to fetch data from corresponding dataSource/remote URL. In this case, you can use EJ2
[Spinner](https://ej2.syncfusion.com/aspnetcore/documentation/spinner/) to enhance the appearance of the UI. This section explains how to load a spinner control to groom the appearance.

Refer to the following code sample to render the spinner control.

```typescript
    ej.popups.createSpinner({
        target: document.getElementById('spinner')
    });
    ej.popups.showSpinner(document.getElementById('spinner'));
```

Refer to the following code sample to render the ListView control.

```typescript

<!-- ListView element -->
@Html.EJS().ListView("element").DataSource(dataManger =>
{dataManger.Url("https://js.syncfusion.com/ejServices/Wcf/Northwind.svc/").CrossDomain(true);
}).Query("new ej.data.Query().from('Products').select('ProductID,ProductName').take(10)").ActionBegin("onBegin").Fields(new ListViewFieldSettings { Id = "ProductID", Text = "ProductName" }).ShowHeader(true).HeaderTitle("Product Name").Width("300").ActionComplete("oncomplete").Render()

```

Here, the data is fetched from `Northwind` Service URL; it takes a few seconds to load the data. To enhance the UI, the spinner control has been rendered initially. After the data is loaded from remote URL, the spinner control will be hidden in ListView [actionComplete](https://ej2.syncfusion.com/documentation/api/list-view/#actioncomplete) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/spinner/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/spinner/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/spinner/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/spinner/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

