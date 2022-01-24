---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Getting Started of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

This section briefly explains how to include simple **Kanban** control in your ASP.NET MVC application. You can refer to [ASP.NET MVC Getting Started documentation](../getting-started/) page for system requirements, and configure common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed,
you also have to include the license key in your projects.
Please refer to this [`link`](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET MVC application to use our controls.

## Adding Kanban control to the application

* Add the Kanban control in view page to render our Syncfusion controls.

{% aspTab template="kanban/getting-started/default", sourceFiles="controller.cs" %}

{% endaspTab %}

### Initialize the Kanban

* Kanban control can be rendered with the help of `@Html.EJS().Kanban` tag helper. Add the below code to your `index.cshtml` page which is present under `Views/Home` folder, where the Kanban is initialized.

## Run the application

After successful compilation of your application, simply press `F5` to run the application.

The below example shows the Kanban.

{% aspTab template="kanban/getting-started/default", sourceFiles="controller.cs" %}

{% endaspTab %}

The output will display the empty Kanban.

![kanban](./images/default.PNG)

## Populating cards

To populate the empty Kanban with cards, define the list or remote data using the `DataSource` property. To define `DataSource`, the mandatory fields in the list should be relevant to `KeyField`. In the following example, you can see the cards defined with default fields such as ID, Summary, and Status.

{% aspTab template="kanban/getting-started/populating-cards", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/populating-cards.PNG)

## Enable swimlane

`Swimlane` can be enabled by mapping the tags `SwimlaneSettings.KeyField` to appropriate column name in dataSource. This enables the grouping of the cards based on the mapped column values.

{% aspTab template="kanban/getting-started/enable-swimlane", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/enable-swimlane.PNG)
