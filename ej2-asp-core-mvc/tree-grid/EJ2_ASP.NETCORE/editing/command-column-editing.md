---
layout: post
title: Command Column Editing in ##Platform_Name## Tree Grid Component | Syncfusion
description: Learn here all about Command Column Editing in Syncfusion ##Platform_Name## Tree Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Command Column Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Command Column Editing in ##Platform_Name## Tree Grid Component

The command column provides an option to add CRUD action buttons in a column. This can be defined by the [`commands`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Commands.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper.

The available built-in command buttons are:

| Command Button | Actions |
|----------------|---------|
| Edit | Edit the current row.|
| Delete | Delete the current row.|
| Save | Update the edited row.|
| Cancel | Cancel the edited state. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/command-columns/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Commandcolumn.cs" %}
{% include code-snippet/tree-grid/editing/command-columns/commandcolumn.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/command-columns/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Commandcolumn.cs" %}
{% include code-snippet/tree-grid/editing/command-columns/commandcolumn.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom command

 The custom command buttons can be added in a column by using the [`commands`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn~Commands.html) property of [`e-treegrid-column`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGridColumn.html) tag helper and the action for the custom buttons can be defined in the **Click** event of an Button Option.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/custom-command/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customcommand.cs" %}
{% include code-snippet/tree-grid/editing/custom-command/customcommand.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/editing/custom-command/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customcommand.cs" %}
{% include code-snippet/tree-grid/editing/custom-command/customcommand.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our  [`ASP.NET Core Tree Grid`](https://www.syncfusion.com/aspnet-core-ui-controls/tree-grid) feature tour page for its groundbreaking feature representations. You can also explore our ASP.NET Core Tree Grid example [`ASP.NET Core Tree Grid example`](https://ej2.syncfusion.com/aspnetcore/TreeGrid/Overview#/material) to knows how to present and manipulate data.