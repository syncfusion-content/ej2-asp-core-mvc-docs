---
layout: post
title: Managing Tasks in ##Platform_Name## Gantt Component
description: Learn here all about Managing Tasks in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Managing Tasks
publishingplatform: ##Platform_Name##
documentation: ug
---


# Managing Tasks in ##Platform_Name## Gantt Component

The Gantt component has options to dynamically insert, delete, and update tasks in the project. The primary key column is necessary to manage the tasks and perform CRUD operations in Gantt. To define the primary key, set the [`Columns.IsPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_IsPrimaryKey) property to `true` in the particular column.

The following code example shows you how to enable the cell editing in Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/enableCellEditing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EnableCellEditing.cs" %}
{% include code-snippet/gantt/editing/enableCellEditing/enableCellEditing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/enableCellEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EnableCellEditing.cs" %}
{% include code-snippet/gantt/editing/enableCellEditing/enableCellEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Read-only Gantt

In Gantt, all create, update, delete operations can be disabled by set `readOnly` property as `true`. The following sample demonstrates, render Gantt chart as read only.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/readOnly/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ReadOnly.cs" %}
{% include code-snippet/gantt/editing/readOnly/readOnly.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/readOnly/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ReadOnly.cs" %}
{% include code-snippet/gantt/editing/readOnly/readOnly.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/readOnly.PNG)

![Alt text](images/readOnlyEdit.png)

## Troubleshoot: Editing works only when primary key column is defined

Editing feature requires a primary key column for CRUD operations. While defining columns in Gantt using the [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html) property, it is mandatory that any one of the columns, must be a primary column. By default, the [`id`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFieldsBuilder.html#Syncfusion_EJ2_Gantt_GanttTaskFieldsBuilder_Id_System_String_) column will be the primary key column.  If [`id`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFieldsBuilder.html#Syncfusion_EJ2_Gantt_GanttTaskFieldsBuilder_Id_System_String_) column is not defined, we need to enable [`isPrimaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_IsPrimaryKey) for any one of the columns defined in the [`columns`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html) property.

## Open new task dialog with default values

You can set default values when new task dialog opens using [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ActionBegin) event when `requestType` is `beforeOpenAddDialog`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/task-dialog-default-value/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Task-dialog-default-value.cs" %}
{% include code-snippet/gantt/editing/task-dialog-default-value/task-dialog-default-value.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/task-dialog-default-value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Task-dialog-default-value.cs" %}
{% include code-snippet/gantt/editing/task-dialog-default-value/task-dialog-default-value.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Gantt new task dialog with default values](images/task-dialog-with-default-values.png)