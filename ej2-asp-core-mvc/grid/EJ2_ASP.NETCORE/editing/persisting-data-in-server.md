---
layout: post
title: Persisting Data in Server in ##Platform_Name## Grid Component
description: Learn here all about Persisting Data in Server in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Persisting Data in Server
publishingplatform: ##Platform_Name##
documentation: ug
---


# Persisting Data in Server

Edited data can be persisted in the database using the RESTful web services.

All the CRUD operations in the grid are done through **DataManager**. The **DataManager** has an option to bind all the CRUD related data in server-side.

> For your information, the ODataAdaptor persists data in the server as per OData protocol.

In the below section, we have explained how to get the edited data details on the server-side using the **UrlAdaptor**.

## Using URL adaptor

You can use the **UrlAdaptor** of **DataManager** when binding data source from remote data.
In the initial load of grid, data are fetched from remote data and bound to the grid using **url** property of **DataManager**.
You can map The CRUD operation in grid can be mapped to server-side Controller actions using the properties **InsertUrl**, **RemoveUrl**, **UpdateUrl**, **CrudUrl** and **BatchUrl**.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Urladaptor.cs" %}
{% include code-snippet/grid/edit/urladaptor/urladaptor.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Urladaptor.cs" %}
{% include code-snippet/grid/edit/urladaptor/urladaptor.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Also, when using the **UrlAdaptor**, you need to return the data as JSON from the controller action and the JSON object must contain a property as **result** with dataSource as its value and one more property **count** with the dataSource total records count as its value.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/grid/edit/urladaptor/data.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Data.cs" %}
{% include code-snippet/grid/edit/urladaptor/data.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Insert record

Using the **InsertUrl** property, you can specify the controller action mapping URL to perform insert operation on the server-side.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Insert.cs" %}
{% include code-snippet/grid/edit/urladaptor/insert.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Insert.cs" %}
{% include code-snippet/grid/edit/urladaptor/insert.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If you get posted data as **null** at the server side, then it might be due to the model state failure. You can check this using **ModelState.IsValid** and get the failure error details using **ModelState.Values** property.

The newly added record details are bound to the **value** parameter. Please refer to the following screenshot.

![insert](../../images/insert.jpg)

### Update record

Using the **UpdateUrl** property, the controller action mapping URL can be specified to perform save/update operation on the server-side.

The following code example describes the previous behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Update.cs" %}
{% include code-snippet/grid/edit/urladaptor/update.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Update.cs" %}
{% include code-snippet/grid/edit/urladaptor/update.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If you get posted data as **null** at the server side, then it might be due to the model state failure. You can check this using **ModelState.IsValid** and get the failure error details using **ModelState.Values** property.

The updated record details are bound to the **value** parameter. Please refer to the following screenshot.

![update](../../images/update.jpg)

### Delete record

Using the **RemoveUrl** property, the controller action mapping URL can be specified to perform delete operation on the server-side.

The following code example describes the previous behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Delete.cs" %}
{% include code-snippet/grid/edit/urladaptor/delete.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/urladaptor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Delete.cs" %}
{% include code-snippet/grid/edit/urladaptor/delete.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If you get posted data as **null** at the server side, then it might be due to the model state failure. You can check this using **ModelState.IsValid** and get the failure error details using **ModelState.Values** property.

The deleted record primary key value is bound to the **key** parameter. Please refer to the following screenshot.

![delete](../../images/delete.jpg)

### CRUD URL

Using the **CrudUrl** property, the controller action mapping URL can be specified to perform all the CRUD operation at server-side using a single method instead of specifying separate controller action method for CRUD (insert, update and delete) operations.

The action parameter of **CrudUrl** is used to get the corresponding CRUD action.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/crudurl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Crudurl.cs" %}
{% include code-snippet/grid/edit/crudurl/crudurl.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/crudurl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Crudurl.cs" %}
{% include code-snippet/grid/edit/crudurl/crudurl.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Please refer to the following screenshot to know about the action parameter.

![crudupdate](../../images/crudupdate.jpg)

> If you specify **InsertUrl** along with **CrudUrl**, then while adding **InsertUrl** only will be invoked.
> If you get posted data as **null** at the server side, then it might be due to the model state failure. You can check this using **ModelState.IsValid** and get the failure error details using **ModelState.Values** property.

### Batch URL

The **BatchUrl** property supports only for batch editing mode.
You can specify the controller action mapping URL to perform batch operation on the server-side.

The following code example describes the above behavior.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batchurl/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Batchurl.cs" %}
{% include code-snippet/grid/edit/batchurl/batchurl.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/batchurl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Batchurl.cs" %}
{% include code-snippet/grid/edit/batchurl/batchurl.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> If you get posted data as **null** at the server side, then it might be due to the model state failure. You can check this using **ModelState.IsValid** and get the failure error details using **ModelState.Values** property.

```typescript
public ActionResult BatchUpdate([FromBody]string action, List<EditableOrder> added, List<EditableOrder> changed, List<EditableOrder> deleted, int? key)
{
//Save the batch changes in database
}
```

![batch](../../images/batch.jpg)