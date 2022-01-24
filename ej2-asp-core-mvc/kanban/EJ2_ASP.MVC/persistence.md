---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Persistence of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Persistence
publishingplatform: ##Platform_Name##
documentation: ug
---


# State Persistence

State persistence refers to the Kanban state maintained in the browser's [`LocalStorage`](https://www.w3schools.com/html/html5_webstorage.asp#) even if the browser is refreshed or if you move to the next page within the browser.

State persistence stores Kanban datasource, column or swimlane expand/collapse state in the local storage when the `EnablePersistence` is defined as true.

{% aspTab template="kanban/persistence", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}
