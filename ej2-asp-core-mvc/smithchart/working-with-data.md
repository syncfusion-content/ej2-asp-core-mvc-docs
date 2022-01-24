---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Working With Data of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Working With Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# Working with Data

Smithchart can visualise the data bound from local data. The data you bind for the smithchart, should be an array of object and that should contain the field resistance and rectangle. This should be bind to points or datasource in the smithchart.

## Data Binding

You can bind simple JSON data to smithchart using point property in series. JSON data should contain [`resistance`] and [`reactance`] fields. This JSON data should be bind to points or datasource in the smithchart. You can any number of JSON for points or datasource as per your requirement.

{% aspTab template="smithchart/data/working-with-data", sourceFiles="working-with-data.cs" %}

{% endaspTab %}