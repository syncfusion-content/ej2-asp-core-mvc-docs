---
title: "ASP.NET CORE Kanban - Getting Started"
component: "Kanban"
description: "This article demonstrates how to create a simple Kanban and configure its available features."
---

# Getting Started

This section briefly explains how to include simple **Kanban** control in your ASP.NET CORE application. You can refer to [ASP.NET CORE Getting Started documentation](../getting-started/) page for system requirements, and configure common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed,
you also have to include the license key in your projects.
Please refer to this [`link`](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET Core application to use our control.

## Adding Kanban control to the application

* Add the Kanban control in view page to render our Syncfusion controls.

{% aspTab template="kanban/getting-started/default", sourceFiles="controller.cs" %}

{% endaspTab %}

### Initialize the Kanban

* Kanban control can be rendered with the help of `ejs-kanban` tag helper. Add the below code to your `index.cshtml` page which is present under `Views/Home` folder, where the Kanban is initialized.

## Run the application

After successful compilation of your application, simply press `F5` to run the application.

The below example shows the Kanban.

{% aspTab template="kanban/getting-started/default", sourceFiles="controller.cs" %}

{% endaspTab %}

The output will display the empty Kanban.

![kanban](./images/default.PNG)

## Populating cards

To populate the empty Kanban with cards, define the list or remote data using the `dataSource` property. To define `dataSource`, the mandatory fields in the list should be relevant to `keyField`. In the following example, you can see the cards defined with default fields such as ID, Summary, and Status.

{% aspTab template="kanban/getting-started/populating-cards", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/populating-cards.PNG)

## Enable swimlane

`Swimlane` can be enabled by mapping the tags `swimlaneSettings.keyField` to appropriate column name in dataSource. This enables the grouping of the cards based on the mapped column values.

{% aspTab template="kanban/getting-started/enable-swimlane", sourceFiles="controller.cs,datasource.cs" %}

{% endaspTab %}

Output be like the below.

![kanban](./images/enable-swimlane.PNG)
