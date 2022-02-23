---
title: "Load accordion with DataSource"
component: "Accordion"
description: "This example demonstrates how to bind any data object to accordion items in the Essential JS 2 Accordion component."
---

# Load accordion with DataSource

You can bind any data object to Accordion items, by mapping it to [header](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.AccordionAccordionItem~Header.html) and [content](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.AccordionAccordionItem~Content.html)&nbsp; property.

In the below demo, Data is fetched from an `OData` service using `DataManager`. The result data is formatted as a JSON object with `header` and `content` fields, which is set to items property of Accordion.

{% aspTab template="accordion/how-to/datasource", sourceFiles="datasource.cs" %}

{% endaspTab %}