---
title: "Accordion How To sections"
component: "Accordion"
description: "This section explains how to set the nested accordion, load content through AJAX, custom animation, to keep single pane always open, etc."
---

# How-To

## Set the nested Accordion

Accordion supports to render `nested` level of Accordion by using content property. You can give nested Accordion content inside the parent Accordion content property by using `id` of nested element.

{% aspTab template="accordion/how-to/nested", sourceFiles="nested.cs" %}

{% endaspTab %}

Output be like the below.

![Accordion Control with nested structure](./images/nested.PNG)

## Load content through Ajax

Accordion supports to load external contents through `AJAX` library. Refer the below steps.

* Import the `Ajax` module from `ej2-base` and initialize with URL path.

* Get data from the Ajax Success event to initialize Accordion with retrieved external path data.

{% aspTab template="accordion/how-to/ajax", sourceFiles="ajax.cs" %}

{% endaspTab %}

## To keep single pane open always

By default, all Accordion panels are collapsible. You can customize the Accordion to keep one panel as expanded state always. This is applicable for `Single` expand mode.

{% aspTab template="accordion/how-to/openalways", sourceFiles="openalways.cs" %}

{% endaspTab %}

## Load accordion with DataSource

You can bind any data object to Accordion items, by mapping it to [header](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.AccordionAccordionItem~Header.html) and [content](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.AccordionAccordionItem~Content.html)&nbsp; property.

In the below demo, Data is fetched from an `OData` service using `DataManager`. The result data is formatted as a JSON object with `header` and `content` fields, which is set to items property of Accordion.

{% aspTab template="accordion/how-to/datasource", sourceFiles="datasource.cs" %}

{% endaspTab %}