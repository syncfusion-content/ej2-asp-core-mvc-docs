---
layout: post
title: Task Dependency in ##Platform_Name## Gantt Component
description: Learn here all about Task Dependency in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Task Dependency
publishingplatform: ##Platform_Name##
documentation: ug
---


# Task Dependencies

Task dependency or task relationship can be established between two tasks in Gantt. This dependency affects the project schedule. If you change the predecessor of a task, it will affect the successor task, which will affect the next task, and so on.

## Task relationship types

Task relationships are categorized into four types based on the start and finish dates of the task.

### Start to Start (SS)

You cannot start a task until the dependent task also starts.

![Alt text](images/ss.png)

### Start to Finish (SF)

You cannot finish a task until the dependent task is started.

![Alt text](images/sf.png)

### Finish to Start (FS)

You cannot start a task until the dependent task is completed.

![Alt text](images/fs.png)

### Finish to Finish (FF)

You cannot finish a task until the dependent task is completed.

![Alt text](images/ff.png)

## Define task relationship

Task relationship is defined in the data source as a string value, and this value is mapped to the Gantt control by using the [`TaskFields.Dependency`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_Dependency) property. The following code example demonstrates how to enable the predecessor in the Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/predecessor/enableDependency/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="EnableDependency.cs" %}
{% include code-snippet/gantt/predecessor/enableDependency/enableDependency.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/predecessor/enableDependency/razor %}
{% endhighlight %}
{% highlight c# tabtitle="EnableDependency.cs" %}
{% include code-snippet/gantt/predecessor/enableDependency/enableDependency.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The following screenshot displays the output of the above code.

![Alt text](images/enableDependency.png)

## Predecessor offset with duration units

In the Gantt control, the predecessor offset can be defined with the following duration units:

* Day
* Hour
* Minute

You can define an offset with various offset duration units for predecessors by using the following code example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/predecessor/predecessorWithOffset/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="PredecessorWithOffset.cs" %}
{% include code-snippet/gantt/predecessor/predecessorWithOffset/predecessorWithOffset.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/predecessor/predecessorWithOffset/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PredecessorWithOffset.cs" %}
{% include code-snippet/gantt/predecessor/predecessorWithOffset/predecessorWithOffset.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The following screen shot depicts the duration unit support in the predecessor offset.

![Alt text](images/predecessorWithOffset.png)

## Validate predecessor links on editing

In Gantt, task relationship link can be broken by editing the start date, end date and duration value of task. When the task relationship broken on any edit action. This can be handled in Gantt in two ways.
* Using actionBegin event
* Using predecessor validation dialog

### Using actionBegin event

When the task relationship link is broken on any edit action, then the [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ActionBegin) event will be triggered with `requestType` argument as `validateLinkedTask`. You can validate the editing action within the actionBegin event using the `validateMode` event argument. The `validateMode` event argument has the following properties:

Argument |Default value |Description
-----|-----|-----
args.validateMode.respectLink | false | In this validation mode, the predecessor links get high priority. With this mode enabled, when the successor task is moved before the predecessor task’s end date, the editing will be reverted, and dates will be validated based on the dependency links.
args.validateMode.removeLink | false | In this validation mode, the taskbar editing gets high priority. For inappropriate task dates, the dependency links will be removed and tasks will be moved to the edited date.
args.validateMode.preserveLinkWithEditing | true | In this validation mode, the taskbar editing will be considered along with the dependency links. This relationship will be maintained by updating the offset value of predecessors.

By default, the `preserveLinkWithEditing` validation mode will be enabled, so the predecessors are updated with offset values.

The following sample explains enabling the `respectLink` validation mode while editing the linked tasks in the [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ActionBegin) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/predecessor/validatePredecessorLinks/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ValidatePredecessorLinks.cs" %}
{% include code-snippet/gantt/predecessor/validatePredecessorLinks/validatePredecessorLinks.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/predecessor/validatePredecessorLinks/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ValidatePredecessorLinks.cs" %}
{% include code-snippet/gantt/predecessor/validatePredecessorLinks/validatePredecessorLinks.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Using validation dialog

When disabling all the validation modes in the [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ActionBegin) event, a validation pop-up will be displayed prompting users to select the validation mode to validate taskbar editing.

This validation pop-up will display different options based on the successor task’s start date after editing.

If you move the successor task that starts after the predecessor task’s end date, then a dialog will be rendered with the following options:

* Cancel, Keep the existing link.
* Remove the link and move the task to start on edited date.
* Move the task to start on edited date and keep the link.

If you move the successor task that starts before the predecessor task’s end date, then a dialog will be rendered with the following options:

* Cancel, Keep the existing link.
* Remove the link and move the task to start on edited date.

The following code example shows how to enable the predecessor validation dialog in Gantt.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/predecessor/validateWithDialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ValidateWithDialog.cs" %}
{% include code-snippet/gantt/predecessor/validateWithDialog/validateWithDialog.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/predecessor/validateWithDialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ValidateWithDialog.cs" %}
{% include code-snippet/gantt/predecessor/validateWithDialog/validateWithDialog.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



In this case, if the user dragging action violated the predecessor type then the following dialog will be rendered to perform operation.

![Alt text](images/validateWithDialog.png)