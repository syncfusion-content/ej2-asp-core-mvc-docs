---
layout: post
title: Partial Chart in ##Platform_Name## Chart Component
description: Learn here all about Partial Chart in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Partial Chart
publishingplatform: ##Platform_Name##
documentation: ug
---


<!-- markdownlint-disable MD036 -->

# Render chart in partial view in ajax call

You can render the charts in partial view in ajax call by calling the partial view action method in ajax.

Follow the given steps to render the charts in partial view.

**Step 1**:

Initially, render the home view page, and then call the partial view action method via ajax call in the home view page.

```html
 <div id="chartContainer">
</div>
<script>
    $.ajax({
            url: '@Url.Action("Create")',
            type: 'POST',
            dataType: 'html',
            global: false,
            success: function (response) {
                $('#chartContainer').html(response);
            }
        });
</script>
```

```cs
// partial view action method
  [HttpPost]
        public ActionResult Create()
        {
            List<ChartData> chartData = new List<ChartData>
            {
                new ChartData { xValue = 10, yValue = 21 },
                new ChartData { xValue = 20, yValue = 24 },
                new ChartData { xValue = 30, yValue = 36 },
                new ChartData { xValue = 40, yValue = 38 },
                new ChartData { xValue = 50, yValue = 54 },
                new ChartData { xValue = 60, yValue = 57 },
                new ChartData { xValue = 70, yValue = 70 },
            };
            ViewBag.dataSource = chartData;
            return PartialView("_RefreshCharts");
        }
        public class ChartData
        {
            public double xValue;
            public double yValue;
        }
```

**Step 2**:

Return the partial view page when calling partial view action method. In that partial view, refer the `scriptManager` to render the charts.

```html
<div>
    @Html.EJS().Chart("container").Series(sr =>
    {
       sr.XName("xValue").YName("yValue").Type(Syncfusion.EJ2.Charts.ChartSeriesType.Column).DataSource(ViewBag.dataSource).Add();
    }).Render();
</div>

@Html.EJS().ScriptManager()
```

**Sample reference**

Sample for how to render the charts in partial view is available in [`chart sample`](http://www.syncfusion.com/downloads/support/directtrac/general/ze/chartsample1860216677).
