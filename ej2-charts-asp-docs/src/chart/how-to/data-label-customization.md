---
title: " Chart How To | ASP.NET MVC "

component: "Chart"

description: "How to section explains knowledge base samples and howto access different types properties and events of the chart."
---

<!-- markdownlint-disable MD036 -->

# Customize the background color of data label template from webservice

Bind the text and interior information for a point from dataSource. To change the background color in the datalabel template, use `${point.text}`. You have to bind the property from dataSource to name in the data label options to use point.text.

Follow the given steps to customize the  background color of data label template from webservice, which includes colors:

**Step 1**:

Get the data from webservice, which also includes color attribute to bind the name in the data label options to use point.text in the data label template.

To get data from web service, use any adaptor webApi or Url adaptor in the data manager, and then bind the data manager to the `dataSource` property in the series options.

```html
@Html.EJS().Chart("container").Series(
           series =>
           {
               series.Type(Syncfusion.EJ2.Charts.ChartSeriesType.Line).Width(2).
               XName("Year").YName("yValue").DataSource("dataManager").
               Query("query").Add();
           }).PrimaryXAxis(
                px => px.ValueType(Syncfusion.EJ2.Charts.ValueType.DateTime).
                      EdgeLabelPlacement(Syncfusion.EJ2.Charts.EdgeLabelPlacement.Shift)
            ).Render()

<script>
    var dataManager = new ej.data.DataManager({
        url: 'http://localhost:54290/api/Values',
        adaptor: new ej.data.WebApiAdaptor
    });
    var query = new ej.data.Query();
</script>
```

```cs
// get the data from here
public object Get()
        {
            List<EmployeeModel> revenue = new List<EmployeeModel>();
            revenue.Add(new EmployeeModel() { Year = "2018-06-13T00:00:00", yValue = 30, color = "red" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-14T00:00:00", yValue = 20, color = "blue" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-15T00:00:00", yValue = 15, color = "green" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-16T00:00:00", yValue = 30, color = "orange" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-17T00:00:00", yValue = 60, color = "skyblue" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-18T00:00:00", yValue = 10, color = "red" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-19T00:00:00", yValue = 70, color = "yellow" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-20T00:00:00", yValue = 50, color = "pink" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-21T00:00:00", yValue = 88, color = "green" });
            revenue.Add(new EmployeeModel() { Year = "2018-06-22T00:00:00", yValue = 35, color = "blue" });

            return new { Items = revenue, Count = revenue.Count() };
}

public class EmployeeModel
{
    public string Year { get; set; }
    public double yValue { get; set; }
    public string color { get; set; }
}
```

**Step 2**:

<!-- markdownlint-disable MD033 -->
Initialize the data label template <div> as demonstrated in the following html page.

```html
<script id="index" type="text/x-template">
    <div id='templateWrap' style="background-color: ${point.text}; border-radius: 3px;">
        <img src="http://icons.iconarchive.com/icons/icons8/ios7/256/Astrology-Air-Element-icon.png" style="height: 25px;width: 25px" title="Air">
        <div class='des' style="color:black; font-family:Roboto; font-style: normal; font-size:16px;padding-right:6px">
            <span style="color:white;">${point.y}</span>
        </div>
    </div>
</script>
```

**Step 3**:

To show the data label template, set the element id to the `template` property in data label.

```html
 @Html.EJS().Chart("container").Series(
           series =>
           {
               series.Type(Syncfusion.EJ2.Charts.ChartSeriesType.Line).Width(2).
               XName("Year").YName("yValue").DataSource("dataManager").
               Query("query").Marker(mark => mark.Visible(true).DataLabel(dl => dl.Visible(true).
               Position(Syncfusion.EJ2.Charts.LabelPosition.Top).Name("color").Template("#index"))).Add();
           }).PrimaryXAxis(
                px => px.ValueType(Syncfusion.EJ2.Charts.ValueType.DateTime).
                      EdgeLabelPlacement(Syncfusion.EJ2.Charts.EdgeLabelPlacement.Shift)
            ).PrimaryYAxis(
                py => py.RangePadding(Syncfusion.EJ2.Charts.ChartRangePadding.None).
                      Interval(20).Minimum(0).Maximum(100)
            ).Render()
```

{% aspTab template="chart/how-to/data-label-template", sourceFiles="template.cs" %}

{% endaspTab %}

**Sample reference**

Sample for how to customize the background color of data label is available in [`chart sample`](http://www.syncfusion.com/downloads/support/directtrac/general/ze/chartsample1860216677).
