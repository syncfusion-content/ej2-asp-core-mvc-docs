---
layout: post
title: Editing tasks in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Editing Tasks in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Managing Tasks
publishingplatform: ##Platform_Name##
documentation: ug
---


# Editing tasks in gantt control

The editing feature can be enabled in the Gantt control by enabling the [`EditSettings.AllowEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowEditing) and [`EditSettings.AllowTaskbarEditing`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_AllowTaskbarEditing) properties.

The following editing options are available to update the tasks in the Gantt chart:
* Cell
* Dialog
* Taskbar
* Dependency links

## Cell editing

By setting the edit mode to auto using the [`EditSettings.Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttEditSettings.html#Syncfusion_EJ2_Gantt_GanttEditSettings_Mode) property, the tasks can be edited through TreeGrid cells by double-clicking.

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



N> When the edit mode is set to `Auto`, on performing double-click action on TreeGrid side, the cells will be changed to editable mode and on performing double-click action on chart side, the edit dialog will appear for editing the task details.

![Alt text](images/enableCellEditing1.png)

double click action on TreeGrid side.

![Alt text](images/enableCellEditing2.png)

double click action on chart side.

## Dialog editing

Modify the task details through the edit dialog by setting the edit mode to `Dialog`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/enableDialogEditing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EnableDialogEditing.cs" %}
{% include code-snippet/gantt/editing/enableDialogEditing/enableDialogEditing.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/enableDialogEditing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EnableDialogEditing.cs" %}
{% include code-snippet/gantt/editing/enableDialogEditing/enableDialogEditing.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> In dialog editing mode, the edit dialog appears when performing double-click action on both TreeGrid or Gantt chart sides.

![Alt text](images/enableDialogEditing.png)

### Sections or tabs in dialog

In the Gantt dialog, you can define the required tabs or editing sections using the [`AddDialogFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AddDialogFields) and [`EditDialogFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EditDialogFields) properties. Every tab is defined using the [`Type`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.DialogFieldType.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/add-edit-dialogtab/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Add-edit-dialogtab.cs" %}
{% include code-snippet/gantt/editing/add-edit-dialogtab/add-edit-dialogtab.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/add-edit-dialogtab/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Add-edit-dialogtab.cs" %}
{% include code-snippet/gantt/editing/add-edit-dialogtab/add-edit-dialogtab.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/add-edit-dialogtab.png)

Tabs in Edit Dialog

![Alt text](images/add-dialogtab.png)

Tabs in Add Dialog

### Limiting data fields in general tab

In the Gantt dialog, you can make only specific data source fields visible for editing by using the [`AddDialogFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AddDialogFields) and [`EditDialogFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EditDialogFields) properties. The data fields are defined with `Type` and `Fields` properties.

N> You can also define the custom fields in the add/edit dialog General tab using the `Fields` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/customfields/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customfields.cs" %}
{% include code-snippet/gantt/editing/customfields/customfields.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/editing/customfields/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customfields.cs" %}
{% include code-snippet/gantt/editing/customfields/customfields.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The following screenshot show the output of above code example.

![Alt text](images/customfields.png)