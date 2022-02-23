---
title: " Chart How To | ASP.NET MVC "

component: "Chart"

description: "How to section explains knowledge base samples and howto access different types properties and events of the chart."
---

<!-- markdownlint-disable MD036 -->

# How To

The following section explains how to customize various aspects of the chart.

## Bind data to chart on ajax request

You can bind data to chart on ajax request using the following steps:

**Step 1:**

Create a http post action method to return data for ajax call in a controller page. The following GetServerData() method will return a JSON data string.

```cs
[HttpPost]
        public ActionResult GetServerData()
        {
            List<LineChart> data1 = new List<LineChart>();
            data1.Add(new LineChart("India", 1));
            data1.Add(new LineChart("USA", 5));
            data1.Add(new LineChart("USSR", 10));
            data1.Add(new LineChart("Chinaa", 12));
            data1.Add(new LineChart("Japan", 8));
            return Json(data1);
        }

        public class LineChart
        {
            public LineChart(string name, double cnt)
            {
                this.x = name;
                this.y = cnt;
            }
            public string x { get; set; }
            public double y { get; set; }
        }
```

**Step 2:**

Make a simple chart with series.

```html
@using Syncfusion.EJ2;
@using EJ2MVCSamples.Controllers;

<div class="col-md-8">
        @Html.EJS().Chart("container").PrimaryXAxis(px => px.Title("Years").ValueType(Syncfusion.EJ2.Charts.ValueType.Category)).Series(series =>
                       {
                           series.Type(Syncfusion.EJ2.Charts.ChartSeriesType.Column).Add();
                       }
        ).Render()
</div>
```

**Step 3:**

Make ajax call to the GetServerData() action method in chart load event to get JSON data, and then assign the data to the chart series using the `dataSource` property and mapping the field name to `xName` and `yName` properties of the series.

```html
@using Syncfusion.EJ2;
@using EJ2MVCSamples.Controllers;

<div class="col-md-8">
        @Html.EJS().Chart("container").PrimaryXAxis(px => px.Title("Years").ValueType(Syncfusion.EJ2.Charts.ValueType.Category)).Series(series =>
                       {
                           series.Type(Syncfusion.EJ2.Charts.ChartSeriesType.Column).Add();
                       }
        ).Load("chartLoad").Render()
</div>
<script>
    var chartLoad = function (args) {
        $.ajax({
            type: "POST",
            url: '@Url.Action("GetServerData","Home")',
            async: false,
            success: function (data) {
                args.chart.series[0].dataSource = data;
                args.chart.series[0].xName = "x";
                args.chart.series[0].yName = "y";
            }
        });
    }
</script>
```

{% aspTab template="chart/how-to/ajax-data", sourceFiles="ajax-data.cs" %}

{% endaspTab %}

**Sample reference**

Sample for how to get data from ajax call is available in [`chart sample`](http://www.syncfusion.com/downloads/support/directtrac/general/ze/samples1051291506).
