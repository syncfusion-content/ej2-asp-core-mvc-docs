---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Pane Content of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Pane Content
publishingplatform: ##Platform_Name##
documentation: ug
---


# Pane content

This section explains how to provide plain text content or HTML markup or integrate other Syncfusion ASP.NET Core UI controls as content of splitter.

## HTML Markup

Splitter is a layout based container control. You can render the pane contents from existing HTML markups. Converting HTML markup as splitter pane is easy way to add the panes content dynamically.

{% aspTab template="splitter/htmlmarkup", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![HTML markup](./images/htmlmarkup.png)

## Syncfusion ASP.NET Core UI controls

You can render any Syncfusion ASP.NET Core UI controls along with their native and control events within splitter as pane content.

You can refer [Accordion within splitter](https://ej2.syncfusion.com/aspnetcore/Splitter/AccordionMenu#/material/material) and [Listview within splitter](https://ej2.syncfusion.com/aspnetcore/Splitter/DetailsView#/material) samples.

## Plain content

You can add the plain text as a pane contents using either inner HTML or [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Splitter.html#Syncfusion_EJ2_Layouts_Splitter_PaneSettings) API

{% aspTab template="splitter/plain-content", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Plain content](./images/plain-content.png)

## Pane content using selector

You can set HTML element as pane content, using the query selectors such as ID or CSS class selectors.

The following code demonstrates how to fetch an element from the document and load it to pane using its ID.

{% aspTab template="splitter/selector-content", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Selector content](./images/selector-content.png)