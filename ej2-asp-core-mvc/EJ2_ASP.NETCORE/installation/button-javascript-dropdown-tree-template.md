---
layout: post
title: Templates in JavaScript Dropdown Tree control
description: Learn here all about Templates in JavaScript Dropdown Tree control.
platform: ej2-asp-core-mvc
control: Templates in JavaScript Dropdown Tree control
publishingplatform: ##Platform_Name##
documentation: ug
---

# Templates in JavaScript Dropdown Tree control

<style>
#preview-sample { border-style: groove; border-width: 0.5px; border-color: #e8e8e8; width: 900px; height: 400px;}
</style>

The Dropdown Tree provides support to customize each list item, header, and footer elements. It uses the Essential JS 2 Template engine to compile and render the elements properly.

## Item template

The content of each list item within the Dropdown Tree can be customized with the help of itemTemplate property.

In the following sample, the Dropdown Tree list items are customized with employee information such as name and job using the itemTemplate property.

The template expression should be provided inside the ${…} interpolation syntax.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownTree } from '@syncfusion/ej2-dropdowns';
let data: { [key: string]: Object }[] = [
    { "id": 1, "name": "Steven Buchanan",  "job": "General Manager", "hasChild": true, "expanded": true },
    { "id": 2, "pid": 1, "name": "Laura Callahan",  "job": "Product Manager", "hasChild": true },
    { "id": 3, "pid": 2, "name": "Andrew Fuller",  "job": "Team Lead", "hasChild": true },
    { "id": 4, "pid": 3, "name": "Anne Dodsworth",  "job": "Developer" },
    { "id": 10, "pid": 3, "name": "Lilly",  "job": "Developer", "status":"online" },
    { "id": 5, "pid": 1, "name": "Nancy Davolio",  "job": "Product Manager", "hasChild": true},
    { "id": 6, "pid": 5, "name": "Michael Suyama",  "job": "Team Lead", "hasChild": true },
    { "id": 7, "pid": 6, "name": "Robert King",  "job": "Developer " },
    { "id": 11, "pid": 6, "name": "Mary", "job": "Developer " },
    { "id": 9, "pid": 1, "name": "Janet Leverling",  "job": "HR" }
];
let ddtreeObj: DropDownTree = new DropDownTree({
    fields: { dataSource: data, text: 'name', value: 'id', parentValue: 'pid', hasChildren: 'hasChild' },
    itemTemplate: '#itemTemplate',
    width: '100%',
    cssClass: 'custom',
    placeholder: 'Select an employee',
    popupHeight: '250px'
});
ddtreeObj.appendTo('#template');

{% endhighlight %}

{% highlight html tabtitle="index.html" %}

<!DOCTYPE html>
<html lang="en">

<head>
    <title>Essential JS 2 DropDownTree</title>
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
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="systemjs.config.js"></script>
</head>
<body>
    <div class="stackblitz-container bootstrap5">
        <div class="col-lg-12 control-section">
            <div style="margin: 0 auto; max-width:350px;">
                <input type="text" id="template">
            </div>
        </div>      
        <script id="itemTemplate" type="text/x-template">
            <div>     
                <span class="ename">${name} - </span>
                <span class="ejob">${job}</span> 
            </div>
        </script>
    </div>      
</body>
</html>
{% endhighlight %}

{% highlight css tabtitle="style.css" %}

import { DropDownTree } from '@syncfusion/ej2-dropdowns';
let data: { [key: string]: Object }[] = [
    { "id": 1, "name": "Steven Buchanan",  "job": "General Manager", "hasChild": true, "expanded": true },
    { "id": 2, "pid": 1, "name": "Laura Callahan",  "job": "Product Manager", "hasChild": true },
    { "id": 3, "pid": 2, "name": "Andrew Fuller",  "job": "Team Lead", "hasChild": true },
    { "id": 4, "pid": 3, "name": "Anne Dodsworth",  "job": "Developer" },
    { "id": 10, "pid": 3, "name": "Lilly",  "job": "Developer", "status":"online" },
    { "id": 5, "pid": 1, "name": "Nancy Davolio",  "job": "Product Manager", "hasChild": true},
    { "id": 6, "pid": 5, "name": "Michael Suyama",  "job": "Team Lead", "hasChild": true },
    { "id": 7, "pid": 6, "name": "Robert King",  "job": "Developer " },
    { "id": 11, "pid": 6, "name": "Mary", "job": "Developer " },
    { "id": 9, "pid": 1, "name": "Janet Leverling",  "job": "HR" }
];
let ddtreeObj: DropDownTree = new DropDownTree({
    fields: { dataSource: data, text: 'name', value: 'id', parentValue: 'pid', hasChildren: 'hasChild' },
    headerTemplate: '#headerTemplate',
    width: '100%',
    cssClass: 'custom',
    placeholder: 'Select an employee',
    popupHeight: '250px'
});
ddtreeObj.appendTo('#template');
{% endhighlight %}

{% endtabs %}

<button id="PreviewSampleButton1" onclick="LoadPreviewSample('https://ej2.syncfusion.com/documentation/samples/dropdowntree/item-template-cs1/index.html',this.id);">Run Preview Sample</button>
<div id="PreviewSampleHolder1"></div>

## Header template

The header element is shown statically at the top of the popup list items within the Dropdown Tree. A custom element can be placed as a header element using the headerTemplate property.

In the following sample, the header is customized with the custom element.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownTree } from '@syncfusion/ej2-dropdowns';
let data: { [key: string]: Object }[] = [
    { "id": 1, "name": "Steven Buchanan",  "job": "General Manager", "hasChild": true, "expanded": true },
    { "id": 2, "pid": 1, "name": "Laura Callahan",  "job": "Product Manager", "hasChild": true },
    { "id": 3, "pid": 2, "name": "Andrew Fuller",  "job": "Team Lead", "hasChild": true },
    { "id": 4, "pid": 3, "name": "Anne Dodsworth",  "job": "Developer" },
    { "id": 10, "pid": 3, "name": "Lilly",  "job": "Developer", "status":"online" },
    { "id": 5, "pid": 1, "name": "Nancy Davolio",  "job": "Product Manager", "hasChild": true},
    { "id": 6, "pid": 5, "name": "Michael Suyama",  "job": "Team Lead", "hasChild": true },
    { "id": 7, "pid": 6, "name": "Robert King",  "job": "Developer " },
    { "id": 11, "pid": 6, "name": "Mary", "job": "Developer " },
    { "id": 9, "pid": 1, "name": "Janet Leverling",  "job": "HR" }
];
let ddtreeObj: DropDownTree = new DropDownTree({
    fields: { dataSource: data, text: 'name', value: 'id', parentValue: 'pid', hasChildren: 'hasChild' },
    headerTemplate: '#headerTemplate',
    width: '100%',
    cssClass: 'custom',
    placeholder: 'Select an employee',
    popupHeight: '250px'
});
ddtreeObj.appendTo('#template');
{% endhighlight %}

{% highlight html tabtitle="index.html" %}

<!DOCTYPE html>
<html lang="en">

<head>
    <title>Essential JS 2 DropDownTree</title>
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
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="systemjs.config.js"></script>
</head>
<body>
    <div class="stackblitz-container bootstrap5">
        <div class="col-lg-12 control-section">
            <div style="margin: 0 auto; max-width:350px;">
                <input type="text" id="template">
            </div>
        </div>      
        <script id="headerTemplate" type="text/x-template">
            <div class="head"> Employee List </div>
        </script>
    </div>      
</body>
</html>
{% endhighlight %}

{% highlight css tabtitle="style.css" %}

.custom .head {
    height: 40px;
    line-height: 40px;
    font-size: 14px;
    margin: 0 auto;
    width: 100%;
    padding: 0 20px;
    font-weight: bold;
    border-bottom: 1px solid #e0e0e0;
}
{% endhighlight %}

{% endtabs %}

<button id="PreviewSampleButton2" onclick="LoadPreviewSample('https://ej2.syncfusion.com/documentation/samples/dropdowntree/header-template-cs1/index.html',this.id);">Run Preview Sample</button>
<div id="PreviewSampleHolder2"></div>

## Footer template

The Dropdown Tree has options to show a footer element at the bottom of the list items in the popup list. Here, you can place any custom element as a footer element using the footerTemplate property.

In the following sample, the footer element displays the total number of employees present in the Dropdown Tree.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownTree } from '@syncfusion/ej2-dropdowns';
let data: { [key: string]: Object }[] = [
    { "id": 1, "name": "Steven Buchanan",  "job": "General Manager", "hasChild": true, "expanded": true },
    { "id": 2, "pid": 1, "name": "Laura Callahan",  "job": "Product Manager", "hasChild": true },
    { "id": 3, "pid": 2, "name": "Andrew Fuller",  "job": "Team Lead", "hasChild": true },
    { "id": 4, "pid": 3, "name": "Anne Dodsworth",  "job": "Developer" },
    { "id": 10, "pid": 3, "name": "Lilly",  "job": "Developer", "status":"online" },
    { "id": 5, "pid": 1, "name": "Nancy Davolio",  "job": "Product Manager", "hasChild": true},
    { "id": 6, "pid": 5, "name": "Michael Suyama",  "job": "Team Lead", "hasChild": true },
    { "id": 7, "pid": 6, "name": "Robert King",  "job": "Developer " },
    { "id": 11, "pid": 6, "name": "Mary", "job": "Developer " },
    { "id": 9, "pid": 1, "name": "Janet Leverling",  "job": "HR" }
];
let ddtreeObj: DropDownTree = new DropDownTree({  
    fields: { dataSource: data, text: 'name', value: 'id', parentValue: 'pid', hasChildren: 'hasChild' },
    footerTemplate:"<span class='foot'> Total number of employees: "+ data.length +"</span>",
    width: '100%',
    cssClass: 'custom',
    placeholder: 'Select an employee',
    popupHeight: '250px'
});
ddtreeObj.appendTo('#template');
{% endhighlight %}

{% highlight html tabtitle="index.html" %}

<!DOCTYPE html>
<html lang="en">

<head>
    <title>Essential JS 2 DropDownTree</title>
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
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="systemjs.config.js"></script>
</head>
<body>
    <div class="stackblitz-container bootstrap5">
        <div class="col-lg-12 control-section">
            <div style="margin: 0 auto; max-width:350px;">
                <input type="text" id="template">
            </div>
        </div> 
    </div>       
</body>
</html>
{% endhighlight %}

{% highlight css tabtitle="style.css" %}

.custom .foot{
    height: 40px;
    line-height: 40px;
    font-size: 14px;
    margin: 0 auto;
    width: 100%;
    padding: 0 20px;
    font-weight: bold;
}
.custom .e-ddt-footer{
    border-top: 1px solid #e0e0e0;
}
{% endhighlight %}

{% endtabs %}

<button id="PreviewSampleButton3" onclick="LoadPreviewSample('https://ej2.syncfusion.com/documentation/samples/dropdowntree/footer-template-cs1/index.html',this.id);">Run Preview Sample</button>
<div id="PreviewSampleHolder3"></div>
## No records template

The Dropdown Tree is supports to display custom design in the popup list content using the noRecordsTemplate property when no matches found on search.

In the following sample, popup list content displays the notification of no data available.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownTree } from '@syncfusion/ej2-dropdowns';
let data: { [key: string]: Object }[] = [ ];
let ddtreeObj: DropDownTree = new DropDownTree({
    fields: { dataSource: data, text: 'name', value: 'id', parentValue: 'pid', hasChildren: 'hasChild' },
    noRecordsTemplate:"<span class='norecord'> NO DATA AVAILABLE</span>",
    width: '100%',
    placeholder: 'Select an employee',
    popupHeight: '250px'
});
ddtreeObj.appendTo('#template');
{% endhighlight %}

{% highlight html tabtitle="index.html" %}

<!DOCTYPE html>
<html lang="en">

<head>
    <title>Essential JS 2 DropDownTree</title>
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
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="systemjs.config.js"></script>
</head>
<body>
    <div class="stackblitz-container bootstrap5">
        <div class="col-lg-12 control-section">
            <div style="margin: 0 auto; max-width:350px;">
                <input type="text" id="template">
            </div>
        </div>   
    </div>   
</body>
</html>
{% endhighlight %}

{% highlight css tabtitle="style.css" %}

.custom .foot{
    height: 40px;
    line-height: 40px;
    font-size: 14px;
    margin: 0 auto;
    width: 100%;
    padding: 0 20px;
    font-weight: bold;
}
.custom .e-ddt-footer{
    border-top: 1px solid #e0e0e0;
}
{% endhighlight %}
{% endtabs %}

<button id="PreviewSampleButton4" onclick="LoadPreviewSample('https://ej2.syncfusion.com/documentation/samples/dropdowntree/norecords-template-cs1/index.html',this.id);">Run Preview Sample</button>
<div id="PreviewSampleHolder4"></div>
## Action failure template

The Dropdown Tree provides an option to custom design the popup list content using actionFailureTemplate property, when the data fetch request fails at the remote server.

In the following sample, when the data fetch request fails, the Dropdown Tree displays the notification.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownTree } from '@syncfusion/ej2-dropdowns';
import { Query, DataManager, ODataV4Adaptor } from '@syncfusion/ej2-data';
let data: DataManager = new DataManager({
    url: 'https://services.odata.org/V4/Northwind/Northwind.svs',
    adaptor: new ODataV4Adaptor,
    crossDomain: true,
});
let query: Query = new Query().from('Employees').select('EmployeeID,FirstName,Title').take(5);
let query1: Query = new Query().from('Orders').select('OrderID,EmployeeID,ShipName').take(5);
let ddTreeObj: DropDownTree = new DropDownTree({
    fields: {
        dataSource: data, query: query, value: 'EmployeeID', text: 'FirstName', hasChildren: 'EmployeeID',
        child: { dataSource: data, query: query1, value: 'OrderID', parentValue: 'EmployeeID', text: 'ShipName' }
    },
    width: '100%',
    actionFailureTemplate:"<span class='action-failure'> Data fetch request fails</span>",
    placeholder: 'Select an employee',
    popupHeight: '250px'
});
ddTreeObj.appendTo('#template');
{% endhighlight %}

{% highlight html tabtitle="index.html" %}

<!DOCTYPE html>
<html lang="en">

<head>
    <title>Essential JS 2 DropDownTree</title>
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
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="systemjs.config.js"></script>
</head>
<body>
    <div class="stackblitz-container bootstrap5">
        <div class="col-lg-12 control-section">
            <div style="margin: 0 auto; max-width:350px;">
                <input type="text" id="template">
            </div>
        </div>
    </div>
</body>
</html>
{% endhighlight %}

{% highlight css tabtitle="style.css" %}

.custom .foot{
    height: 40px;
    line-height: 40px;
    font-size: 14px;
    margin: 0 auto;
    width: 100%;
    padding: 0 20px;
    font-weight: bold;
}
.custom .e-ddt-footer{
    border-top: 1px solid #e0e0e0;
}
{% endhighlight %}
{% endtabs %}

<button id="PreviewSampleButton5" onclick="LoadPreviewSample('https://ej2.syncfusion.com/documentation/samples/dropdowntree/actionfailure-template-cs1/index.html',this.id);">Run Preview Sample</button>
<div id="PreviewSampleHolder5"></div>
## Custom template to show selected items in input

In Dropdown Tree, while selecting more than one items via checkbox or multi selection support, all the selected items will be displayed in the input. Instead of displaying all the selected item text, the custom template can be displayed by setting the the mode property as Custom and customTemplate property.

When the mode property is set as Custom, the Dropdown Tree displays the default template value (${value.length} item(s) selected) like 1 item(s) selected or 2 item(s) selected. The default template can be customized by setting customTemplate property.

In the following sample, the Dropdown Tree is rendered with default value of the customTemplate property like “1 item(s) selected or 2 item(s) selected”.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownTree } from '@syncfusion/ej2-dropdowns';
let data: { [key: string]: Object }[] = [
    { "id": 1, "name": "Steven Buchanan",  "job": "General Manager", "hasChild": true, "expanded": true },
    { "id": 2, "pid": 1, "name": "Laura Callahan",  "job": "Product Manager", "hasChild": true },
    { "id": 3, "pid": 2, "name": "Andrew Fuller",  "job": "Team Lead", "hasChild": true },
    { "id": 4, "pid": 3, "name": "Anne Dodsworth",  "job": "Developer" },
    { "id": 10, "pid": 3, "name": "Lilly",  "job": "Developer", "status":"online" },
    { "id": 5, "pid": 1, "name": "Nancy Davolio",  "job": "Product Manager", "hasChild": true},
    { "id": 6, "pid": 5, "name": "Michael Suyama",  "job": "Team Lead", "hasChild": true },
    { "id": 7, "pid": 6, "name": "Robert King",  "job": "Developer " },
    { "id": 11, "pid": 6, "name": "Mary", "job": "Developer " },
    { "id": 9, "pid": 1, "name": "Janet Leverling",  "job": "HR" }
];
let checkList: DropDownTree = new DropDownTree({
    fields: { dataSource: data, text: 'name', value: 'id', parentValue: 'pid', hasChildren: 'hasChild' },
    placeholder: 'Select items',
    popupHeight: '200px',
    mode: 'Custom',
    showCheckBox: true,
    treeSettings: { autoCheck: true }
});
checkList.appendTo('#checkbox');
{% endhighlight %}

{% highlight html tabtitle="index.html" %}

<!DOCTYPE html>
<html lang="en">

<head>
    <title>Essential JS 2 DropDownTree</title>
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
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="systemjs.config.js"></script>
</head>
<body>
    <div class="stackblitz-container bootstrap5">
        <div class="col-lg-12 control-section">
            <div style="margin: 0 auto; max-width:350px;">
                <input type="text" id="checkbox">
            </div>
        </div>
    </div>       
</body>
</html>
{% endhighlight %}

{% highlight css tabtitle="style.css" %}

.custom .foot{
    height: 40px;
    line-height: 40px;
    font-size: 14px;
    margin: 0 auto;
    width: 100%;
    padding: 0 20px;
    font-weight: bold;
}
.custom .e-ddt-footer{
    border-top: 1px solid #e0e0e0;
}
{% endhighlight %}
{% endtabs %}

<button id="PreviewSampleButton6" onclick="LoadPreviewSample('https://ej2.syncfusion.com/documentation/samples/dropdowntree/custom-template-mode-cs1/index.html',this.id);">Run Preview Sample</button>
<div id="PreviewSampleHolder6"></div>
In the following sample, the Dropdown Tree is rendered with custom value of the customTemplate property like Selected items count: 2.

**Source**

{% tabs %}
{% highlight ts tabtitle="app.ts" %}

import { DropDownTree } from '@syncfusion/ej2-dropdowns';
let data: { [key: string]: Object }[] = [
    { "id": 1, "name": "Steven Buchanan",  "job": "General Manager", "hasChild": true, "expanded": true },
    { "id": 2, "pid": 1, "name": "Laura Callahan",  "job": "Product Manager", "hasChild": true },
    { "id": 3, "pid": 2, "name": "Andrew Fuller",  "job": "Team Lead", "hasChild": true },
    { "id": 4, "pid": 3, "name": "Anne Dodsworth",  "job": "Developer" },
    { "id": 10, "pid": 3, "name": "Lilly",  "job": "Developer", "status":"online" },
    { "id": 5, "pid": 1, "name": "Nancy Davolio",  "job": "Product Manager", "hasChild": true},
    { "id": 6, "pid": 5, "name": "Michael Suyama",  "job": "Team Lead", "hasChild": true },
    { "id": 7, "pid": 6, "name": "Robert King",  "job": "Developer " },
    { "id": 11, "pid": 6, "name": "Mary", "job": "Developer " },
    { "id": 9, "pid": 1, "name": "Janet Leverling",  "job": "HR" }
];
let checkList: DropDownTree = new DropDownTree({
    fields: { dataSource: data, text: 'name', value: 'id', parentValue: 'pid', hasChildren: 'hasChild' },
    placeholder: 'Select items',
    popupHeight: '200px',
    mode: 'Custom',
    customTemplate: "Selected items count: ${value.length}",
    showCheckBox: true,
    treeSettings: { autoCheck: true }
});
checkList.appendTo('#checkbox');
{% endhighlight %}

{% highlight html tabtitle="index.html" %}

<!DOCTYPE html>
<html lang="en">

<head>
    <title>Essential JS 2 DropDownTree</title>
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
    <script src="https://cdnjs.cloudflare.com/ajax/libs/systemjs/0.19.38/system.js"></script>
    <script src="systemjs.config.js"></script>
</head>
<body>
    <div class="stackblitz-container bootstrap5">
        <div class="col-lg-12 control-section">
            <div style="margin: 0 auto; max-width:350px;">
                <input type="text" id="checkbox">
            </div>
        </div>
    </div>   
</body>
</html>
{% endhighlight %}

{% highlight css tabtitle="style.css" %}

.custom .foot{
    height: 40px;
    line-height: 40px;
    font-size: 14px;
    margin: 0 auto;
    width: 100%;
    padding: 0 20px;
    font-weight: bold;
}
.custom .e-ddt-footer{
    border-top: 1px solid #e0e0e0;
}
{% endhighlight %}
{% endtabs %}

<button id="PreviewSampleButton7" onclick="LoadPreviewSample('https://ej2.syncfusion.com/documentation/samples/dropdowntree/custom-template-cs1/index.html',this.id);">Run Preview Sample</button>
<div id="PreviewSampleHolder7"></div>