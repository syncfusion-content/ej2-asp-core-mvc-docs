---
layout: post
title: Templates in JavaScript DropDownList control
description: Learn here all about Templates in JavaScript DropDownList control
platform: ej2-asp-core-mvc
control: Templates in JavaScript DropDownList control
publishingplatform: ##Platform_Name##
documentation: ug
---

# Templates in JavaScript DropDownList control

<style>
.previewsample { border-style: groove; border-width: 0.5px; border-color: #e8e8e8; width: 900px; height: 400px; }
</style>

The DropDownList has been provided with several options to customize each list item, group title, selected value, header, and footer elements. It uses the Essential JS 2 Template engine to compile and render the elements properly.

## Item template

The content of each list item within the DropDownList can be customized with the help of itemTemplate property.

In the following sample, each list item is split into two columns to display relevant data’s.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownList } from '@syncfusion/ej2-dropdowns';
//import data manager related classes
import { Query, DataManager, ODataV4Adaptor } from '@syncfusion/ej2-data';

//initiates the component
let DropDownListObject: DropDownList = new DropDownList({
    //bind the data manager instance to dataSource property
    dataSource: new DataManager({
            url: 'https://services.odata.org/V4/Northwind/Northwind.svc/',
            adaptor: new ODataV4Adaptor,
            crossDomain: true
    }),
    //bind the Query instance to query property
    query: new Query().from('Employees').select(['FirstName', 'City','EmployeeID']).take(6),
    //map the appropriate columns to fields property
    fields: { text: 'FirstName', value: 'EmployeeID' },
    //set the placeholder to DropDownList input
    placeholder:"Select an employee",
    //sort the resulted items
    sortOrder: 'Ascending',
    //set the value to itemTemplate property
    itemTemplate:"<span><span class='name'>${FirstName}</span><span class ='city'>${City}</span></span>"

});

//render the component
DropDownListObject.appendTo('#ddlelement');
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
    <link href="//cdn.syncfusion.com/ej2/ej2-dropdowns/styles/material.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="systemjs.config.js"></script>
</head>

<body>
    <div id='loader'>LOADING....</div>
    <div id='container' style="margin:0 auto; width:250px;">
        <input type="text" id='ddlelement' />
    </div>
</body>

</html>
{% endhighlight %}

{% highlight css tabtitle="style.css" %}

#container {
    visibility: hidden;
}

#loader {
  color: #008cff;
  height: 40px;
  width: 30%;
  position: absolute;
  top: 45%;
  left: 45%;
}
.city{
    right: 15px;
    position: absolute;
}
{% endhighlight %}
{% endtabs %}

**Preview**

<iframe class="previewsample" data-src="https://ej2.syncfusion.com/documentation/samples/dropdownlist/item-template-cs1/index.html" loading="lazy"></iframe>

## Value template

The currently selected value that is displayed by default on the DropDownList input element can be customized using the valueTemplate property.

In the following sample, the selected value is displayed as a combined text of both FirstName and City in the DropDownList input, which is separated by a hyphen.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownList } from '@syncfusion/ej2-dropdowns';
//import data manager related classes
import { Query, DataManager, ODataV4Adaptor } from '@syncfusion/ej2-data';

//initiates the component
let DropDownListObject: DropDownList = new DropDownList({
    //bind the data manager instance to dataSource property
    dataSource: new DataManager({
            url: 'https://services.odata.org/V4/Northwind/Northwind.svc/',
            adaptor: new ODataV4Adaptor,
            crossDomain: true
    }),
    //bind the Query instance to query property
    query: new Query().from('Employees').select(['FirstName', 'City','EmployeeID']).take(6),
    //map the appropriate columns to fields property
    fields: { text: 'FirstName', value: 'EmployeeID' },
    //set the placeholder to DropDownList input
    placeholder:"Select an employee",
    //sort the resulted items
    sortOrder: 'Ascending',
    //set the template value to itemTemplate property
    itemTemplate:"<span><span>${FirstName}</span><span class ='city'>${City}</span></span>",
    //set the value to valueTemplate property
    valueTemplate:"<span>${FirstName} - ${City}</span>"
});

//render the component
DropDownListObject.appendTo('#ddlelement');
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
    <link href="//cdn.syncfusion.com/ej2/ej2-dropdowns/styles/material.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="systemjs.config.js"></script>
</head>

<body>
    <div id='loader'>LOADING....</div>
    <div id='container' style="margin:0 auto; width:250px;">
        <input type="text" id='ddlelement' />
    </div>
</body>

</html>
{% endhighlight %}

{% highlight css tabtitle="style.css" %}

#container {
    visibility: hidden;
}

#loader {
  color: #008cff;
  height: 40px;
  width: 30%;
  position: absolute;
  top: 45%;
  left: 45%;
}
.city{
    right: 15px;
    position: absolute;
}
{% endhighlight %}
{% endtabs %}

**Preview**

<iframe class="previewsample" data-src="https://ej2.syncfusion.com/documentation/samples/dropdownlist/item-template-cs2/index.html" loading="lazy"></iframe>

## Group template

The group header title under which appropriate sub-items are categorized can also be customize with the help of groupTemplate property. This template is common for both inline and floating group header template.

In the following sample, employees are grouped according to their city.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownList } from '@syncfusion/ej2-dropdowns';
//import data manager related classes
import { Query, Predicate , DataManager, ODataV4Adaptor } from '@syncfusion/ej2-data';

// form  predicate to fetch the grouped data
let groupPredicate = new Predicate('City', 'equal','london').or('City','equal','seattle');

//initiates the component
let DropDownListObject: DropDownList = new DropDownList({
    //bind the data manager instance to dataSource property
    dataSource: new DataManager({
            url: 'https://services.odata.org/V4/Northwind/Northwind.svc/',
            adaptor: new ODataV4Adaptor,
            crossDomain: true
    }),
    //bind the Query instance to query property
    query: new Query().from('Employees').select(['FirstName', 'City','EmployeeID']).take(5)
    .where(groupPredicate),
    //map the appropriate columns to fields property
    fields: { text: 'FirstName', value: 'EmployeeID', groupBy:'City' },
    //set the placeholder to DropDownList input
    placeholder:"Select an employee",
    //sort the resulted items
    sortOrder: 'Ascending',
    //set the value to groupTemplate
    groupTemplate:"<strong>${City}</strong>"
});

//render the component
DropDownListObject.appendTo('#ddlelement');
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
    <link href="//cdn.syncfusion.com/ej2/ej2-dropdowns/styles/material.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="systemjs.config.js"></script>
</head>

<body>
    <div id='loader'>LOADING....</div>
    <div id='container' style="margin:0 auto; width:250px;">
        <input type="text" id='ddlelement' />
    </div>
</body>

</html>
{% endhighlight %}

{% highlight css tabtitle="style.css" %}

#container {
    visibility: hidden;
}

#loader {
  color: #008cff;
  height: 40px;
  width: 30%;
  position: absolute;
  top: 45%;
  left: 45%;
}
.city{
    right: 15px;
    position: absolute;
}
{% endhighlight %}
{% endtabs %}

**Preview**

<iframe class="previewsample" data-src="https://ej2.syncfusion.com/documentation/samples/dropdownlist/item-template-cs3/index.html" loading="lazy"></iframe>

## Header template

The header element is shown statically at the top of the popup list items within the DropDownList, and any custom element can be placed as a header element using the headerTemplate property.

In the following sample, the list items and its headers are designed and displayed as two columns similar to multiple columns of the grid.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownList } from '@syncfusion/ej2-dropdowns';
//import data manager related classes
import { Query, DataManager, ODataV4Adaptor } from '@syncfusion/ej2-data';

//initiates the component
let DropDownListObject: DropDownList = new DropDownList({
    //bind the data manager instance to dataSource property
    dataSource: new DataManager({
            url: 'https://services.odata.org/V4/Northwind/Northwind.svc/',
            adaptor: new ODataV4Adaptor,
            crossDomain: true
    }),
    //bind the Query instance to query property
    query: new Query().from('Employees').select(['FirstName', 'City','EmployeeID']).take(6),
    //map the appropriate columns to fields property
    fields: { text: 'FirstName', value: 'EmployeeID' },
    //set the placeholder to DropDownList input
    placeholder:"Select an employee",
    //sort the resulted items
    sortOrder: 'Ascending',
    //set the value to header template
    headerTemplate:"<span class='head'><span class='name'>Name</span><span class='city'>City</span></span>",
    //set the value to item template
    itemTemplate:"<span class='item' ><span class='name'>${FirstName}</span><span class='city'>${City}</span></span>"

});

//render the component
DropDownListObject.appendTo('#ddlelement');
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
    <link href="//cdn.syncfusion.com/ej2/ej2-dropdowns/styles/material.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="systemjs.config.js"></script>
</head>

<body>
    <div id='loader'>LOADING....</div>
    <div id='container' style="margin:0 auto; width:250px;">
        <input type="text" id='ddlelement' />
    </div>
</body>

</html>
{% endhighlight %}

{% highlight css tabtitle="style.css" %}

#container {
  visibility: hidden;
}

#loader {
  color: #008cff;
  height: 40px;
  width: 30%;
  position: absolute;
  top: 45%;
  left: 45%;
}

.head, .item{               
    display: table;
    width:100%;
    margin:auto;				
}
.head{
    height: 40px;
    font-size:15px;
    font-weight:600;
}

.name, .city{
    display: table-cell;
    vertical-align: middle;
    width: 50%;      
}

.head .name {
   text-indent: 16px;
}

.head .city {
   text-indent: 10px;
}
{% endhighlight %}
{% endtabs %}

**Preview**

<iframe class="previewsample" data-src="https://ej2.syncfusion.com/documentation/samples/dropdownlist/header-template-cs1/index.html" loading="lazy"></iframe>

## Footer template

The DropDownList has options to show a footer element at the bottom of the list items in the popup list. Here, you can place any custom element as a footer element using the footerTemplate property.

In the following sample, footer element displays the total number of list items present in the DropDownList.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownList } from '@syncfusion/ej2-dropdowns';

let sportsData = [ "Basketball", "Cricket", "Football", "Golf"];
//initiates the component
let DropDownListObject: DropDownList = new DropDownList({
    //bind the data manager instance to dataSource property
    dataSource: sportsData ,
    //set the placeholder to DropDownList input
    placeholder:"Select a game",
    //set the value to footer template
    footerTemplate:"<span class='foot'> Total list items: "+ sportsData.length +"</span>"
});

//render the component
DropDownListObject.appendTo('#ddlelement');
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
    <link href="//cdn.syncfusion.com/ej2/ej2-dropdowns/styles/material.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="systemjs.config.js"></script>
</head>

<body>
    <div id='loader'>LOADING....</div>
    <div id='container' style="margin:0 auto; width:250px;">
        
        <input type="text" id='ddlelement' />
    </div>
</body>

</html>
{% endhighlight %}

{% highlight css tabtitle="style.css" %}

#container {
  visibility: hidden;
}

#loader {
  color: #008cff;
  height: 40px;
  width: 30%;
  position: absolute;
  top: 45%;
  left: 45%;
}

.foot{
    text-indent: 1.2em;
    display: block;
    font-size: 15px;
    line-height: 40px;
    border-top: 1px solid #e0e0e0;
}
{% endhighlight %}
{% endtabs %}

**Preview**

<iframe class="previewsample" data-src="https://ej2.syncfusion.com/documentation/samples/dropdownlist/footer-template-cs1/index.html" loading="lazy"></iframe>

## No records template

The DropDownList is provided with support to custom design the popup list content when no data is found and no matches found on search with the help of noRecordsTemplate property.

In the following sample, popup list content displays the notification of no data available.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownList } from '@syncfusion/ej2-dropdowns';

//initiates the component
let DropDownListObject: DropDownList = new DropDownList({
    //bind the data manager instance to dataSource property
    dataSource: [],
    //set the placeholder to DropDownList input
    placeholder:"Select an item",
    //set the value to noRecords template
    noRecordsTemplate:"<span class='norecord'> NO DATA AVAILABLE</span>"
});

//render the component
DropDownListObject.appendTo('#ddlelement');
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
    <link href="//cdn.syncfusion.com/ej2/ej2-dropdowns/styles/material.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="systemjs.config.js"></script>
</head>

<body>
    <div id='loader'>LOADING....</div>
    <div id='container' style="margin:0 auto; width:250px;">
        <input type="text" tabindex="1" id='ddlelement' />
    </div>
</body>

</html>
{% endhighlight %}

{% highlight css tabtitle="style.css" %}

#container {
  visibility: hidden;
}

#loader {
  color: #008cff;
  height: 40px;
  width: 30%;
  position: absolute;
  top: 45%;
  left: 45%;
}
.norecord:before{
    content: 'e7c3';
    font-family: 'e-icons';
    font-size: 18px;
    margin-left: -25px;
    margin-top: -3px;
    position: absolute;
}

.action-failure:before{
    content: 'e7c4';
    font-family: 'e-icons';
    font-size: 18px;
    margin-top: -4px;
    position: absolute;
    margin-left: -25px;
}
{% endhighlight %}
{% endtabs %}

**Preview**

<iframe class="previewsample" data-src="https://ej2.syncfusion.com/documentation/samples/dropdownlist/norecords-template-cs1/index.html" loading="lazy"></iframe>

## Action failure template

There is also an option to custom design the popup list content when the data fetch request fails at the remote server. This can be achieved using the actionFailureTemplate property.

In the following sample, when the data fetch request fails, the DropDownList displays the notification.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownList } from '@syncfusion/ej2-dropdowns';
//import data manager related classes
import { Query, DataManager, ODataV4Adaptor } from '@syncfusion/ej2-data';

//initiates the component
let DropDownListObject: DropDownList = new DropDownList({
    //bind the data manager instance to dataSource property
    dataSource: new DataManager({
            // Here, use the wrong url to display the action failure template
            url: 'https://services.odata.org/V4/Northwind/Northwind.svcs/',
            adaptor: new ODataV4Adaptor,
            crossDomain: true
    }),
    //bind the Query instance to query property
    query: new Query().from('Employees').select(['FirstName']).take(6),
    //map the appropriate columns to fields property
    fields: { text: 'FirstName', value: 'EmployeeID' },
    //set the placeholder to DropDownList input
    placeholder:"Select an employee",
    //set the value to action failure template
    actionFailureTemplate:"<span class='action-failure'> Data fetch get fails</span>"

});

//render the component
DropDownListObject.appendTo('#ddlelement');
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
    <link href="//cdn.syncfusion.com/ej2/ej2-dropdowns/styles/material.css" rel="stylesheet" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="systemjs.config.js"></script>
</head>

<body>
    <div id='loader'>LOADING....</div>
    <div id='container' style="margin:0 auto; width:250px;">
        <input type="text" tabindex="1" id='ddlelement' />
    </div>
</body>

</html>
{% endhighlight %}

{% highlight css tabtitle="style.css" %}

#container {
  visibility: hidden;
}

#loader {
  color: #008cff;
  height: 40px;
  width: 30%;
  position: absolute;
  top: 45%;
  left: 45%;
}
.norecord:before{
    content: 'e7c3';
    font-family: 'e-icons';
    font-size: 18px;
    margin-left: -25px;
    margin-top: -3px;
    position: absolute;
}

.action-failure:before{
    content: 'e7c4';
    font-family: 'e-icons';
    font-size: 18px;
    margin-top: -4px;
    position: absolute;
    margin-left: -25px;
}
{% endhighlight %}
{% endtabs %}

**Preview**

<iframe class="previewsample" data-src="https://ej2.syncfusion.com/documentation/samples/dropdownlist/norecords-template-cs2/index.html" loading="lazy"></iframe>
