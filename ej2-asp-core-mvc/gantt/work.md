---
layout: post
title: Work in ##Platform_Name## Gantt Component
description: Learn here all about Work in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Work
publishingplatform: ##Platform_Name##
documentation: ug
---


# Work

The work is the total hours required to complete a task. Work can be mapped from the data source field using the property [`taskFields.work`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFieldsBuilder.html#Syncfusion_EJ2_Gantt_GanttTaskFieldsBuilder_Work_System_String_). Work can be measured in
`Hour`, `Day`, `Minute`. By default, work is measured in `Hour` and it can be changed, by using the property [`workUnit`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.WorkUnit.html).

> When the work field is mapped from the data source, the default task type will be `FixedWork`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/work/work/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Work.cs" %}
{% include code-snippet/gantt/work/work/work.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/work/work/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Work.cs" %}
{% include code-snippet/gantt/work/work/work.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/work.png)

## Task type

The work, duration and resource unit fields of a task depends upon each other and will change automatically on editing any one of these fields. But we can also set these field’s values as constant using the [`taskType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.TaskType.html) property. `FixedUnit` is the default [`taskType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.TaskType.html). The following values can be set to the [`taskType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.TaskType.html)
 property,

* `FixedDuration` - Duration task field will remain constant while updating resource unit or work field.
* `FixedWork` - Work field will remain constant while updating resource unit or duration fields.
* `FixedUnit` - Resource units will remain constant while updating duration or work field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/work/taskType/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="TaskType.cs" %}
{% include code-snippet/gantt/work/taskType/taskType.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/work/taskType/razor %}
{% endhighlight %}
{% highlight c# tabtitle="TaskType.cs" %}
{% include code-snippet/gantt/work/taskType/taskType.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Alt text](images/taskType.png)

Following table explains how the work, duration and resource unit fields will gets updated on changing any of the fields

Task Type | Changes in Duration | Changes in work | Changes in Resource Units
-----|-----|-----|-----
Fixed Duration | Work field updates | Resource unit updates| Work field updates
Fixed Work | Resource unit updates.  For manually scheduled task work will update.| Duration field updates.  For manually scheduled task resource unit updates. |Duration will update.  For manually scheduled task work field updates.
Fixed Unit | Work field updates | Duration field updates.  For manually scheduled task resource unit updates.| Duration will update.  For manually scheduled task work field updates.

> 1. Fixed Unit is the default taskType in Gantt. 2. The above calculations are not applicable for Milestones.