---
layout: post
title: Deleting tasks in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Deleting Tasks in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Managing Tasks
publishingplatform: ##Platform_Name##
documentation: ug
---


# Deleting tasks in gantt control

A task delete option in the Gantt control can be enabled by enabling the [`EdiSettings.AllowDeleting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowDeleting) property. Tasks can be deleted by clicking the delete toolbar item or using the `deleteRow` method. You can call this method dynamically on any custom actions like button click. The following code example shows how to enable the delete option in the Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/deleteRecord/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DeleteRecord.cs" %}
{% include code-snippet/gantt/editing/deleteRecord/deleteRecord.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/deleteRecord/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DeleteRecord.cs" %}
{% include code-snippet/gantt/editing/deleteRecord/deleteRecord.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You should select any one of the rows in the Gantt control to perform task delete action.
> You should set the [`AllowDeleting`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowDeleting) value to `true` to delete the record dynamically.

## Delete confirmation message

Delete confirmation message is used to get the confirmation from users before deleting a task. This confirmation message can be enabled by setting the [`EditSettings.ShowDeleteConfirmDialog`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_ShowDeleteConfirmDialog) property to true.

The following code snippet explains how to enable the delete confirmation message in Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/deleteConfirmationDialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="DeleteConfirmationDialog.cs" %}
{% include code-snippet/gantt/editing/deleteConfirmationDialog/deleteConfirmationDialog.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/deleteConfirmationDialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="DeleteConfirmationDialog.cs" %}
{% include code-snippet/gantt/editing/deleteConfirmationDialog/deleteConfirmationDialog.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/deleteConfirmationDialog.png)