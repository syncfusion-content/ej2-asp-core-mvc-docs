---
layout: post
title: Baseline in ##Platform_Name## Gantt Component
description: Learn here all about Baseline in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Baseline
publishingplatform: ##Platform_Name##
documentation: ug
---

# BaseLine

{% if page.publishingplatform == "aspnet-core" %}

The baseline feature in the Gantt component enables comparison between original planned schedules and actual task execution timelines. This visualization provides clear insights into schedule deviations, helping assess project performance and identify areas requiring attention. Baseline functionality displays both the original planned timeline and current progress side-by-side for comprehensive project tracking.

Before implementing baseline functionality, ensure the data source includes baseline date fields and configure the [taskFields](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskFields) object with appropriate field mappings. The baseline feature requires proper field mapping to display planned versus actual timelines effectively.

**Baseline fields**:

- [baselineStartDate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_BaselineStartDate): Represents the originally planned start date of a task. This value is used to compare against the actual start date to identify schedule deviations.
- [baselineEndDate](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_BaselineEndDate): Represents the originally planned end date of a task. It is used to compare against the actual end date.
- [baselineDuration](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_BaselineDuration): Represents the total planned duration of the task. This value is critical for baseline visualization. To represent a baseline milestone, this property must be explicitly set to 0. Setting `baselineStartDate` and `baselineEndDate` to the same value without setting baselineDuration to 0 will result in a one-day baseline task, not a milestone.

## Implement baseline

To enable baseline, configure the Gantt component by setting [renderBaseline](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_RenderBaseline) to `true`, mapping `baselineStartDate`, `baselineEndDate`, and optionally `baselineDuration` in `taskFields`. To customize appearance set the [baselineColor](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_BaselineColor) property or the .`e-baseline-bar` CSS class for advanced styling.

```typescript
List<GanttDataSource> data = new List<GanttDataSource>
{
    ...

    new GanttDataSource
    {
        TaskID = 7,
        TaskName = "List materials",
        StartDate = new DateTime(2019, 4, 4),
        Duration = 3,
        Progress = 50,
        ParentID = 5,
        BaselineStartDate = new DateTime(2019, 4, 2),
        BaselineEndDate = new DateTime(2019, 4, 4),
        BaselineDuration = 2 // Regular baseline
    },
    new GanttDataSource
    {
        TaskID = 8,
        TaskName = "Estimation approval",
        StartDate = new DateTime(2019, 4, 4),
        BaselineStartDate = new DateTime(2019, 04, 02),
        Duration = 0,
        Progress = 50,
        ParentID = 5,
        BaselineDuration = 0 // Milestone baseline
    }
};
```

```cs
// Here you can customize base line color. 
<ejs-gantt id='Gantt' dataSource="ViewBag.dataSource" height="450px" renderBaseline="true" baselineColor="red" projectStartDate="03/31/2019" projectEndDate="05/31/2019">
...
</ejs-gantt>
```

```css
.e-gantt .e-gantt-chart .e-baseline-bar {
    height: 4px;
    border-radius: 2px;
    opacity: 0.9;
    background-color: #4CAF50; 
}
```

The following example demonstrates complete baseline configuration with proper field mapping:

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/baseline/baseline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Baseline.cs" %}
{% include code-snippet/gantt/baseline/baseline/baseline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The baseline feature in the Gantt component enables comparison between original planned schedules and actual task execution timelines. This visualization provides clear insights into schedule deviations, helping assess project performance and identify areas requiring attention. Baseline functionality displays both the original planned timeline and current progress side-by-side for comprehensive project tracking.

Before implementing baseline functionality, ensure the data source includes baseline date fields and configure the [taskFields](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_TaskFields) object with appropriate field mappings. The baseline feature requires proper field mapping to display planned versus actual timelines effectively.

**Baseline fields**:

- [baselineStartDate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_BaselineStartDate): Represents the originally planned start date of a task. This value is used to compare against the actual start date to identify schedule deviations.
- [baselineEndDate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_BaselineEndDate): Represents the originally planned end date of a task. It is used to compare against the actual end date.
- [baselineDuration](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.GanttTaskFields.html#Syncfusion_EJ2_Gantt_GanttTaskFields_BaselineDuration): Represents the total planned duration of the task. This value is critical for baseline visualization. To represent a baseline milestone, this property must be explicitly set to 0. Setting `baselineStartDate` and `baselineEndDate` to the same value without setting baselineDuration to 0 will result in a one-day baseline task, not a milestone.

## Implement baseline

To enable baseline, configure the Gantt component by setting [renderBaseline](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_RenderBaseline) to `true`, mapping `baselineStartDate`, `baselineEndDate`, and optionally `baselineDuration` in `taskFields`. To customize appearance set the [baselineColor](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_BaselineColor) property or the .`e-baseline-bar` CSS class for advanced styling.

```typescript
List<GanttDataSource> data = new List<GanttDataSource>
{
    ...

    new GanttDataSource
    {
        TaskID = 7,
        TaskName = "List materials",
        StartDate = new DateTime(2019, 4, 4),
        Duration = 3,
        Progress = 50,
        ParentID = 5,
        BaselineStartDate = new DateTime(2019, 4, 2),
        BaselineEndDate = new DateTime(2019, 4, 4),
        BaselineDuration = 2 // Regular baseline
    },
    new GanttDataSource
    {
        TaskID = 8,
        TaskName = "Estimation approval",
        StartDate = new DateTime(2019, 4, 4),
        BaselineStartDate = new DateTime(2019, 04, 02),
        Duration = 0,
        Progress = 50,
        ParentID = 5,
        BaselineDuration = 0 // Milestone baseline
    }
};
```

```cs
@Html.EJS().Gantt("Gantt")
    .DataSource((IEnumerable<object>)ViewBag.DataSource)
    .RenderBaseline(true)
    .BaselineColor("red") // Here you can customize base line color.    
    .Render()
```

```css
.e-gantt .e-gantt-chart .e-baseline-bar {
    height: 4px;
    border-radius: 2px;
    opacity: 0.9;
    background-color: #4CAF50; 
}
```

The following example demonstrates complete baseline configuration with proper field mapping:

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/baseline/baseline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Baseline.cs" %}
{% include code-snippet/gantt/baseline/baseline/baseline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The following screenshot shows the baseline in Gantt control.

![Baseline in Gantt Component](images/baseline.png)