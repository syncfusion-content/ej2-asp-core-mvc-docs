---
title: "Load tab with DataSource"
component: "Tab"
description: "This example demonstrates how to bind any data object to tab Items in the Essential JS 2 Tab component."
---

# Load tab with DataSource

You can bind any data object to Tab items, by mapping it to a [header](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.TabHeader.html) and [content](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.TabTabItem~Content.html)&nbsp; property.

In the below demo, Data is fetched from an `OData` service using `DataManager`. The result data is formatted as a JSON object with `header` and `content` fields, which is set to items property of Tab.

{% aspTab template="tab/data", sourceFiles="data.cs" %}

{% endaspTab %}
