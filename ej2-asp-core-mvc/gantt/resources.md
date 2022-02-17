---
layout: post
title: Resources in ##Platform_Name## Gantt Component
description: Learn here all about Resources in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Resources
publishingplatform: ##Platform_Name##
documentation: ug
---


# Resources

In Gantt, the resources are represented by staff, equipment and materials etc. In Gantt control you can show or allocate the resources (human resources) for each task.

## Resource collection

The resource collection contains details about resources that are used in the project. Resources are JSON object that contains id, name, unit and group of the resources and this collection is mapped to the Gantt control using the [`resources`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Resources) property. These resource fields are mapped to the Gantt control using the [`resourceFields`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttResourceFields.html) property.

Resource fields | Description
-----|-----
[`id`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttResourceFields.html#Syncfusion_EJ2_Gantt_GanttResourceFields_Id) | This field is used to assign resources to the tasks.
[`name`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttResourceFields.html#Syncfusion_EJ2_Gantt_GanttResourceFields_Name) | This field is used to map the resource names. These names are displayed as one of Gantt columns and also can display as labels using the [`labelSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_LabelSettings) property.
[`unit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttResourceFields.html#Syncfusion_EJ2_Gantt_GanttResourceFields_Unit) | It indicates the amount of work that can be done by a resource for the task in a day.
[`group`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttResourceFields.html#Syncfusion_EJ2_Gantt_GanttResourceFields_Group) | This field is used to group the resources and the tasks assigned to that particular resource into category.

The following code snippets shows resource collection and how it assigned to Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/resources/assignResource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AssignResource.cs" %}
{% include code-snippet/gantt/resources/assignResource/assignResource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/resources/assignResource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AssignResource.cs" %}
{% include code-snippet/gantt/resources/assignResource/assignResource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Assign resource

We can assign resources for a task at initial load, using the resource id value of the resources as a collection. This collection is mapped from the dataSource to the Gantt control using the [`resourceInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFieldsBuilder.html#Syncfusion_EJ2_Gantt_GanttTaskFieldsBuilder_ResourceInfo_System_String_) property.

Resources are assigned to tasks in following ways.

### Assign resource alone

If the unit is not specified for specific resource, the amount of work done will be consider as 100% by default. In such cases, the resource unit will not be displayed in Gantt UI.

```html

GanttDataSource Child1 = new GanttDataSource()
            {
                TaskId = 2,
                TaskName = "Identify site location",
                StartDate = new DateTime(2019, 04, 02),
                Duration = 4,
                Progress = 50,
                ResourceId = new int[] { 1 },
            };

```

### Assign resource with unit

We can assign the quantity of work done by the resources for the specific task as like below code snippet.

```html

GanttDataSource Record1Child1 = new GanttDataSource()
            {
                TaskId = 2,
                TaskName = "Identify Site location",
                StartDate = new DateTime(2019, 03, 29),
                Duration = 2,
                Progress = 30,
                Work = 10,
                Resources = new List<ResourceModel>
                {
                   new ResourceModel{  ResourceId = 1, Unit = 50 }
                }
            };

```

When resource unit is defined in resource collection, the amount of work done by that particular resource will be same for all the tasks.

The following code snippet shows how to assign the resource for each task and map to Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/resources/resourceUnit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ResourceUnit.cs" %}
{% include code-snippet/gantt/resources/resourceUnit/resourceUnit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/resources/resourceUnit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ResourceUnit.cs" %}
{% include code-snippet/gantt/resources/resourceUnit/resourceUnit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/resourceUnit.png)

## Add/Edit resource collection

By using cell/ dialog edit option, we can add/remove the multiple resources for a particular task. Resource Unit can be change for a each task on resource tab in edit dialog by double click on the unit cell.

![Cell Edit](images/cellEdit-resource.png)

![Dialog Edit](images/dialogedit-resource.png)
