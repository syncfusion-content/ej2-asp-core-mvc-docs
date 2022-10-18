---
layout: post
title: Data Binding in ##Platform_Name## Grid Component
description: Learn here all about Data Binding in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Data Binding
publishingplatform: ##Platform_Name##
documentation: ug
---


# Data Binding

The Grid uses `DataManager`, which supports both RESTful JSON data services binding and local JavaScript object array binding. The [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property can be assigned either with the instance of `DataManager` or JavaScript object array collection.

It supports the following kinds of data binding method:
* List binding
* DataTable binding
* Remote data

## Sending additional parameters to the server

To add a custom parameter to the data request, use the `addParams` method of `Query` class. Assign the `Query` object with additional parameters to the grid [`query`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Query) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/params/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Params.cs" %}
{% include code-snippet/grid/data-binding/params/params.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/params/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Params.cs" %}
{% include code-snippet/grid/data-binding/params/params.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The parameters added using the [`Query`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Query) property will be sent along with the data request for every grid action.

## Handling HTTP error

During server interaction from the grid, some server-side exceptions may occur, and you can acquire those error messages or exception details in client-side using the [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionFailure) event.

The argument passed to the [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionFailure) event contains the error details returned from the server.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/httperror/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Httperror.cs" %}
{% include code-snippet/grid/data-binding/httperror/httperror.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/data-binding/httperror/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Httperror.cs" %}
{% include code-snippet/grid/data-binding/httperror/httperror.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> The [`actionFailure`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionFailure) event will be triggered not only for the server errors, but also when there is an exception while processing the grid actions.

## Binding with ajax

You can use Grid [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property to bind the datasource to Grid from external ajax request. In the below code we have fetched the datasource from the server with the help of ajax request and provided that to [`dataSource`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_DataSource) property by using `onSuccess` event of the ajax.

```javascript
<script type="text/javascript">
    var grid = document.getElementById('Grid').ej2_instances[0]; // Grid instance
    var ajax = new ej.base.Ajax('/Home/UrlDatasource', 'GET');
    ajax.send();
    ajax.onSuccess = function (data) {
        grid.dataSource = ej.data.DataUtil.parse.parseJson(data).result;
    };
</script>
```

> If you bind the dataSource from this way, then it acts like a local dataSource. So you cannot perform any server side crud actions.

## Troubleshoot: Grid render rows without data

In ASP.NET Core, by default the JSON results are returned in camelCase format. So grid field names are also changed in camelCase.

To avoid this problem, you need to add **DefaultContractResolver** in **Startup.cs** file.

```javascript
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc().AddJsonOptions(options =>
    {
        options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
    });
}
```

**Note:** For ASP.NET **Core  3.0 or above**, use the below code

For this we need to install **Microsoft.AspNetCore.Mvc.NewtonsoftJson** package.

```javascript
  public void ConfigureServices(IServiceCollection services)
          {
            services.AddMvc().AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });
           }
```