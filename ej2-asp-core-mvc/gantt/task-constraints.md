---
layout: post
title: Task Constraints in Syncfusion ##Platform_Name## Gantt Component
description: Learn how to implement and manage task constraints in the Syncfusion ##Platform_Name## Gantt component to enforce scheduling rules and dependencies.
platform: ej2-asp-core-mvc
control: Constraints
publishingplatform: ##Platform_Name##
documentation: ug
---

# Task Constraints in Gantt Control

Task constraints define rules that control when a task is allowed to start or finish in the project timeline. They help ensure that tasks follow a logical sequence, align with fixed deadlines, and make efficient use of resources. Constraints also support planning for real-world limitations like material delays, team availability, or mandatory compliance dates—making your schedule more realistic and reliable.

---

## Benefits of using task constraints

Task constraints help guide the schedule of each task by applying real-world rules. They serve critical planning purposes and offer the following benefits:
- **Enforce Task Logic**: Ensure tasks follow a defined sequence, especially when one cannot begin until another ends.
- **Align with Milestones**: Anchor key tasks to fixed dates such as launches, reviews, or audits.
- **Avoid Resource Conflicts**: Prevent tasks from overlapping when they rely on the same resources or teams.
- **Support Scenario Planning**: Modify constraints to test "what-if" situations and explore how delays or accelerations affect the timeline.
- **Meet Business and Compliance Deadlines**: Guarantee that mandatory deadlines are met and ensure the schedule supports regulatory timelines.
- **Improve Planning Accuracy**: Account for real-world limitations like material availability or stakeholder input windows.

---

## Understanding task constraint types

| Constraint Type | Description | Example Use Case |
|------------------------------|-----------------------------------------------------------------------------|----------------------------------------------------------------------------------|
| **As Soon As Possible (ASAP)** | Starts the task immediately once its dependencies are cleared. | Begin development as soon as design is approved. |
| **As Late As Possible (ALAP)** | Delays the task until the last possible moment without affecting successors. | Apply polish to UI just before release to use the latest assets. |
| **Must Start On (MSO)** | Requires the task to begin on a fixed, non-negotiable date. | Partner company begins integration on July 1st per contract. |
| **Must Finish On (MFO)** | Requires the task to end on a fixed date, regardless of its dependencies. | Submit compliance documentation by March 31 due to government regulations. |
| **Start No Earlier Than (SNET)** | Prevents a task from starting before a certain date. | A campaign cannot begin until regulatory approval on August 15. |
| **Start No Later Than (SNLT)** | Requires a task to start on or before a given date. | Financial reviews must begin by September 1 to meet reporting cycles. |
| **Finish No Earlier Than (FNET)** | Ensures the task does not finish before a certain date. | Training can’t end before all participants have completed onboarding. |
| **Finish No Later Than (FNLT)** | Ensures task completion on or before a specific date. | QA testing must be done by July 25 to meet release deadlines. |

---

## Configuration and implementation

To enable and manage task constraints in the Gantt component, you need to configure specific fields under the `TaskFields` mapping. These fields tell the Gantt component which type of constraint to apply and the relevant date to enforce it.

### Step 1: Define taskFields mappings

In your Gantt component configuration, map the following fields:

{% if page.publishingplatform == "aspnet-core" %}
```cshtml
TaskFields.Id = "taskId"
TaskFields.Name = "taskName"
TaskFields.StartDate = "startDate"
TaskFields.EndDate = "endDate"
TaskFields.ConstraintType = "constraintType" // Specifies the type of constraint (e.g., 2 for MustStartOn)
TaskFields.ConstraintDate = "constraintDate" // Specifies the relevant date for the constraint
```
{% elsif page.publishingplatform == "aspnet-mvc" %}
```razor
TaskFields.Id = "taskId"
TaskFields.Name = "taskName"
TaskFields.StartDate = "startDate"
TaskFields.EndDate = "endDate"
TaskFields.ConstraintType = "constraintType" // Specifies the type of constraint (e.g., 2 for MustStartOn)
TaskFields.ConstraintDate = "constraintDate" // Specifies the relevant date for the constraint
```
{% endif %}

These mappings ensure that each task can interpret and apply its constraints correctly based on your data source.

### Step 2: Provide constraint data

In your project data source, ensure that each task includes values for the [`ConstraintType`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.TaskFieldsModel.html#Syncfusion_EJ2_Gantt_TaskFieldsModel_ConstraintType) and [`ConstraintDate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.TaskFieldsModel.html#Syncfusion_EJ2_Gantt_TaskFieldsModel_ConstraintDate) fields if constraints need to be applied.

#### Example data format:

```json
{
    "taskId": 1,
    "taskName": "Design Approval",
    "startDate": new DateTime(2025, 7, 1),
    "endDate": new DateTime(2025, 7, 2),
    "constraintType": 2,
    "constraintDate": new DateTime(2025, 7, 1)
}
```

This task is constrained to must start on July 1, 2025.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/task-scheduling/task-constraints-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Constraints.cs" %}
{% include code-snippet/gantt/task-scheduling/task-constraints-cs1/constraints.cs %}
{% endhighlight %}
{% endtabs %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/task-scheduling/task-constraints-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Constraints.cs" %}
{% include code-snippet/gantt/task-scheduling/task-constraints-cs1/constraints.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Managing scheduling conflicts due to constraint violations

When scheduling changes conflict with applied constraints, the Gantt component shows a violation popup to alert users. This validation applies specifically to strict constraint types:
- MustStartOn
- MustFinishOn
- StartNoLaterThan
- FinishNoLaterThan

#### Programmatic conflict management

You can intercept constraint violations using the `ActionBegin` event. When the event’s `RequestType` is `"ValidateTaskViolation"`, set specific flags in `args.ValidateMode` to determine how conflicts are handled.

##### Supported flags

| Flag | Description |
|-----------------------------|--------------------------------------------------------------|
| RespectMustStartOn | If true, silently rejects violations of MustStartOn. |
| RespectMustFinishOn | If true, silently cancels changes violating MustFinishOn. |
| RespectStartNoLaterThan | If true, blocks updates violating StartNoLaterThan. |
| RespectFinishNoLaterThan | If true, blocks changes violating FinishNoLaterThan. |

> **Defaults**: All flags default to `false`, meaning violations show a popup. Setting a flag to `true` enables silent

 enforcement (i.e., the user’s update is canceled without interruption).

#### Example setup

{% if page.publishingplatform == "aspnet-core" %}
```cshtml
ActionBegin="ActionBeginHandler"
```
```c#
public void ActionBeginHandler(Syncfusion.EJ2.Gantt.GanttActionEventArgs args)
{
    if (args.RequestType == "ValidateTaskViolation")
    {
        args.ValidateMode = new
        {
            RespectMustStartOn = true,
            RespectMustFinishOn = true,
            RespectStartNoLaterThan = true,
            RespectFinishNoLaterThan = true
        };
    }
}
```
{% elsif page.publishingplatform == "aspnet-mvc" %}
```razor
ActionBegin="ActionBeginHandler"
```
```c#
public void ActionBeginHandler(Syncfusion.EJ2.Gantt.GanttActionEventArgs args)
{
    if (args.RequestType == "ValidateTaskViolation")
    {
        args.ValidateMode = new
        {
            RespectMustStartOn = true,
            RespectMustFinishOn = true,
            RespectStartNoLaterThan = true,
            RespectFinishNoLaterThan = true
        };
    }
}
```
{% endif %}

In the following example, we have **disabled the `MustStartOn` violation popup** by setting `RespectMustStartOn` to `true`.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/task-scheduling/task-constraints-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ConstraintsPopup.cs" %}
{% include code-snippet/gantt/task-scheduling/task-constraints-cs2/constraintsPopup.cs %}
{% endhighlight %}
{% endtabs %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/task-scheduling/task-constraints-cs2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ConstraintsPopup.cs" %}
{% include code-snippet/gantt/task-scheduling/task-constraints-cs2/constraintsPopup.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
