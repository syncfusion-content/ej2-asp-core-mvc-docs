---
layout: post
title: Command Column Editing in ##Platform_Name## Grid Component
description: Learn here all about Command Column Editing in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Command Column Editing
publishingplatform: ##Platform_Name##
documentation: ug
---

# Command column editing in ASP.NET MVC Grid component

The command column editing feature allows you to add CRUD (Create, Read, Update, Delete) action buttons in a column for performing operations on individual rows.This feature is commonly used when you need to enable inline editing, deletion, or saving of row changes directly within the grid. 

To enable command column editing, you can utilize the `Column.Commands` property. By defining this property, you can specify the command buttons to be displayed in the command column, such as Edit, Delete, Save, and Cancel.

The available built-in command buttons are: 

| Command Button | Actions |
|----------------|---------|
| Edit | Edit the current row.|
| Delete | Delete the current row.|
| Save | Update the edited row.|
| Cancel | Cancel the edited state. |

Here's an example that demonstrates how to add CRUD action buttons in a column using the `Commands` column property : 

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/commandcolumn/razor %}
{% endhighlight %}
{% highlight c# tabtitle="commandcolumn.cs" %}
{% include code-snippet/grid/edit/commandcolumn/commandcolumn.cs %}
{% endhighlight %}
{% endtabs %}

![Command column editing](../images/editing/edit-command.gif)

## Custom command column

The custom command column feature in the Grid component allows you to add custom command buttons in a column to perform specific actions on individual rows. This feature is particularly useful when you need to provide customized functionality for editing, deleting, or performing any other operation on a row.

To add custom command buttons in a column, you can utilize the `Column.Commands` property. Furthermore, you can define the actions associated with these custom buttons using the [CommandClick](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_CommandClick) event.

Here's an example that demonstrates how to add custom command buttons using the `Commands` property and customize the button click behavior to display grid details in a dialog using the `CommandClick` event:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/customcommand/razor %}
{% endhighlight %}
{% highlight c# tabtitle="customcommand.cs" %}
{% include code-snippet/grid/edit/customcommand/customcommand.cs %}
{% endhighlight %}
{% endtabs %}

![Custom command column](../images/editing/edit-custom.png)