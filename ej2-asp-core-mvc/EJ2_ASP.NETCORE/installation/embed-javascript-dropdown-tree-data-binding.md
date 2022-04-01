---
layout: post
title: Data binding in JavaScript Dropdown Tree control
description: Learn here all about Data binding in JavaScript Dropdown Tree control
platform: ej2-asp-core-mvc
control: Data binding in JavaScript Dropdown Tree control
publishingplatform: ##Platform_Name##
documentation: ug
---

# Data binding in JavaScript Dropdown Tree control

<style>
.previewsample { border-style: groove; border-width: 0.5px; border-color: #e8e8e8; width: 900px; height: 400px; background:url(https://d2g29cya9iq7ip.cloudfront.net/documentation/images/left-toc-waiting.gif) center center no-repeat;}
</style>

The Dropdown Tree control provides an option to load the data either from local data sources or from remote data services. This can be done through dataSource property that is a member of the fields property. The dataSource property supports array of JavaScript objects and DataManager. It also supports different kinds of data services such as OData, OData V4, Web API, URL, and JSON with the help of DataManager adaptors.

Dropdown Tree has load on demand (Lazy load) option. It reduces the bandwidth size when consuming the huge data. By default, the loadOnDemand is set to false. By enabling this property, it loads first level items initially, and when parent item is expanded, loads the child items based on the parentValue/child member.

## Local data

To bind local data to the Dropdown Tree, you can assign a JavaScript object array to the dataSource property.

The Dropdown Tree control requires three fields (Value, text, and parentValue) to render local data source. When mapper fields are not specified, it takes the default values as the mapping fields. Local data source can also be provided as an instance of the DataManager. It supports two kinds of local data binding methods.

## Hierarchical data

Dropdown Tree can be populated with the hierarchical data source that contains nested array of JSON objects. You can directly map the hierarchical data and the field members with corresponding key values from the hierarchical data to the fields property.

In the following example, code, name, and countries columns from the hierarchical data have been mapped to value, text, and child fields, respectively.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownTree } from '@syncfusion/ej2-dropdowns';

//define the nested array of JSON objects
let continents: { [key: string]: Object; }[] = [
{
    code: 'AF', name: 'Africa', countries: [
        { code: 'NGA', name: 'Nigeria' },
        { code: 'EGY', name: 'Egypt' },
        { code: 'ZAF', name: 'South Africa' }
    ]
},
{
    code: 'AS', name: 'Asia', expanded: true, countries: [
        { code: 'CHN', name: 'China' },
        { code: 'IND', name: 'India', selected: true },
        { code: 'JPN', name: 'Japan' }
    ]
},
{
    code: 'EU', name: 'Europe', countries: [
        { code: 'DNK', name: 'Denmark' },
        { code: 'FIN', name: 'Finland' },
        { code: 'AUT', name: 'Austria' }
    ]
},
{
    code: 'NA', name: 'North America', countries: [
        { code: 'USA', name: 'United States of America' },
        { code: 'CUB', name: 'Cuba' },
        { code: 'MEX', name: 'Mexico' }
    ]
},
{
    code: 'SA', name: 'South America', countries: [
        { code: 'BRA', name: 'Brazil' },
        { code: 'COL', name: 'Colombia' },
        { code: 'ARG', name: 'Argentina' }
    ]
},
{
    code: 'OC', name: 'Oceania', countries: [
        { code: 'AUS', name: 'Australia' },
        { code: 'NZL', name: 'New Zealand' },
        { code: 'WSM', name: 'Samoa' }
    ]
},
{
    code: 'AN', name: 'Antarctica', countries: [
        { code: 'BVT', name: 'Bouvet Island' },
        { code: 'ATF', name: 'French Southern Lands' }
    ]
},
];


let DropDownTreeObj: DropDownTree = new DropDownTree({
fields: { dataSource: continents, value: 'code', text: 'name', child: 'countries' }
});
DropDownTreeObj.appendTo('#ddltreeelement');
{% endhighlight %}

{% highlight html tabtitle="index.html" %}

<!DOCTYPE html>
<html lang="en">

<head>
    <title>Essential JS 2 DropDownList</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="Typescript UI Controls" />
    <meta name="author" content="Syncfusion" />
    <link href="styles.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-base/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-buttons/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-lists/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-inputs/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-navigations/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-dropdowns/styles/material.css" rel="stylesheet" />
    <script data-src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script data-src="systemjs.config.js"></script>
</head>

<body>
    <div id='loader'>LOADING....</div>
    <div id='container' style="margin:0 auto; width:250px;">
        <input type="text" tabindex="1" id='ddltreeelement' />
    </div>
</body>

</html>
{% endhighlight %}

{% endtabs %}

**Preview**

<embed class="previewsample" data-src="https://ej2.syncfusion.com/documentation/samples/dropdowntree/data-binding/hierarchical-data-cs1/index.html" ></embed>

## Self-referential data

Dropdown Tree can be populated from the self-referential data structure that contains array of JSON objects with parentValue mapping.

You can directly assign the self-referential data and map all the field members with corresponding key values from self-referential data to the fields property.

To render the root level items, specify the parentValue as null or no need to specify the parentValue in the dataSource.

In the following example, id, pid, hasChild, and name columns from self-referential data have been mapped to value, parentValue, hasChildren, and text fields, respectively.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownTree } from '@syncfusion/ej2-dropdowns';

let localData: { [key: string]: Object }[] = [
{ id: 1, name: 'Discover Music', hasChild: true, expanded: true },
{ id: 2, pid: 1, name: 'Hot Singles' },
{ id: 3, pid: 1, name: 'Rising Artists' },
{ id: 4, pid: 1, name: 'Live Music' },
{ id: 6, pid: 1, name: 'Best of 2017 So Far' },
{ id: 7, name: 'Sales and Events', hasChild: true },
{ id: 8, pid: 7, name: '100 Albums' },
{ id: 9, pid: 7, name: 'Hip-Hop and R&B Sale' },
{ id: 10, pid: 7, name: 'CD Deals' },
{ id: 11, name: 'Categories', hasChild: true },
{ id: 12, pid: 11, name: 'Songs' },
{ id: 13, pid: 11, name: 'Bestselling Albums' },
{ id: 14, pid: 11, name: 'New Releases' },
{ id: 15, pid: 11, name: 'Bestselling Songs' },
{ id: 16, name: 'MP3 Albums', hasChild: true },
{ id: 17, pid: 16, name: 'Rock' },
{ id: 18, pid: 16, name: 'Gospel' },
{ id: 19, pid: 16, name: 'Latin Music' },
{ id: 20, pid: 16, name: 'Jazz' },
{ id: 21, name: 'More in Music', hasChild: true },
{ id: 22, pid: 21, name: 'Music Trade-In' },
{ id: 23, pid: 21, name: 'Redeem a Gift Card' },
{ id: 24, pid: 21, name: 'Band T-Shirts' },
];

let DropDownTreeObj: DropDownTree = new DropDownTree({
fields: { dataSource: localData, value: 'id', parentValue: 'pid', text: 'name', hasChildren: 'hasChild' }
});
DropDownTreeObj.appendTo('#ddltreeelement');
{% endhighlight %}

{% highlight html tabtitle="index.html" %}

<!DOCTYPE html>
<html lang="en">

<head>
    <title>Essential JS 2 DropDownList</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="Typescript UI Controls" />
    <meta name="author" content="Syncfusion" />
    <link href="styles.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-base/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-inputs/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-buttons/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-lists/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-navigations/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-dropdowns/styles/material.css" rel="stylesheet" />
    <script data-src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script data-src="systemjs.config.js"></script>
</head>

<body>
    <div id='loader'>LOADING....</div>
    <div id='container' style="margin:0 auto; width:250px;">
        <input type="text" tabindex="1" id='ddltreeelement' />
    </div>
</body>

</html>
{% endhighlight %}

{% endtabs %}

**Preview**

<embed class="previewsample" data-src="https://ej2.syncfusion.com/documentation/samples/dropdowntree/data-binding/self-referential-data-cs1/index.html" ></embed>

## Remote data

Dropdown Tree can also be populated from a remote data service with the help of the DataManager control and Query property.

It supports different kinds of data services such as OData, OData V4, Web API, URL, and JSON with the help of DataManager adaptors.

You can assign service data as an instance of DataManager to the dataSource. To interact with remote data source, you must provide the endpoint url.

The DataManager that acts as an interface between the service endpoint and the Dropdown Tree requires the following information to interact with service endpoint properly.

DataManager->url: Defines the service endpoint to fetch data.
DataManager->adaptor: Defines the adaptor option. By default, ODataAdaptor is used for remote binding.
Adaptor is responsible for processing response and request from/to the service endpoint. The @syncfusion/ej2-data package provides some pre-defined adaptors designed to interact with service endpoints. They are,

UrlAdaptor: Used to interact with remote services. This is the base adaptor for all remote based adaptors.
ODataAdaptor: Used to interact with OData endpoints.
ODataV4Adaptor: Used to interact with OData V4 endpoints.
WebApiAdaptor: Used to interact with Web API created under OData standards.
WebMethodAdaptor: Used to interact with web methods.
In the following example, ODataV4Adaptor is used to fetch data from the remote services. The EmployeeID, FirstName, and EmployeeID columns from the Employees table have been mapped to value, text, and hasChildren fields respectively for first level items.

The OrderID, EmployeeID, and ShipName columns from the orders table have been mapped to value, parentValue, and text fields respectively for second level items.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownTree } from '@syncfusion/ej2-dropdowns';
//import data manager related classes
import { Query, DataManager, ODataV4Adaptor } from '@syncfusion/ej2-data';

let data: DataManager = new DataManager({
url: 'https://services.odata.org/V4/Northwind/Northwind.svc',
adaptor: new ODataV4Adaptor,
crossDomain: true,
});
let query: Query = new Query().from('Employees').select('EmployeeID,FirstName,Title').take(5);
let query1: Query = new Query().from('Orders').select('OrderID,EmployeeID,ShipName').take(5);

let DropDownTreeObj: DropDownTree = new DropDownTree({
fields: { dataSource: data, query: query, value: 'EmployeeID', text: 'FirstName', hasChildren: 'EmployeeID', tooltip: 'Title',
    child: { dataSource: data, query: query1, value: 'OrderID', parentValue: 'EmployeeID', text: 'ShipName' }
}
});
DropDownTreeObj.appendTo('#ddltreeelement');
{% endhighlight %}

{% highlight html tabtitle="index.html" %}

<!DOCTYPE html>
<html lang="en">

<head>
    <title>Essential JS 2 DropDownList</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="Typescript UI Controls" />
    <meta name="author" content="Syncfusion" />
    <link href="styles.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-base/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-inputs/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-lists/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-buttons/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-navigations/styles/material.css" rel="stylesheet" />
    <link href="//cdn.syncfusion.com/ej2/ej2-dropdowns/styles/material.css" rel="stylesheet" />
    <script data-src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script data-src="systemjs.config.js"></script>
</head>

<body>
    <div id='loader'>LOADING....</div>
    <div id='container' style="margin:0 auto; width:250px;">
        <input type="text" tabindex="1" id='ddltreeelement' />
    </div>
</body>

</html>
{% endhighlight %}

{% endtabs %}

**Preview**

<embed class="previewsample" data-src="https://ej2.syncfusion.com/documentation/samples/dropdowntree/data-binding/remote-data-cs1/index.html" ></embed>