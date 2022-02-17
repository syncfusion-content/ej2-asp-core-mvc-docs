---
layout: post
title: Code Behind in ##Platform_Name## Circular Gauge Component
description: Learn here all about Code Behind in Syncfusion ##Platform_Name## Circular Gauge component and more.
platform: ej2-asp-core-mvc
control: Code Behind
publishingplatform: ##Platform_Name##
documentation: ug
---

# How To

<!-- markdownlint-disable MD036 -->

## Get data from database for circular gauge and render gauge from code behind

<!-- markdownlint-disable MD033 -->
Circular gauge can be rendered from the code behind by initializing the required properties in controller and passing them through ViewData to client-side. You can get the data from the database by creating a data table and accessing the data table values to gauge pointers value.

To get the data from data base and render the gauge from code behind, follow the given steps:

**Step 1**:

<!-- markdownlint-disable MD031 -->
Initialize the required properties in controller and get data from database, create a new data collection that contains minimum, maximum, and value attributes from the data base data, and then assign the data to the minimum, maximum, and pointer values of gauge.

```cs
 public ActionResult Index()
        {
            //Initialize the chart model
            CircularGauge gaugeModel = new CircularGauge();
            // Add the required properties for chart using the following method
            InitializeGauge(gaugeModel);
            // Store the chart model
            ViewData["GaugeModel"] = gaugeModel;
            return View();
        }
        private void InitializeGauge(CircularGauge gaugeModel)
        {
            // Create a data base data table
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("MaxStock");
            dt.Columns.Add("FreeStock");
            dt.Columns.Add("AvailableStock");
            dt.Rows.Add(new Object[] { "T13", 10000, 5000, 8230 });

            // Create  a new data collection from data base table
            GaugeData gauges = new GaugeData();
            foreach (DataRow row in dt.Rows)
            {
                gauges.Minimum = Convert.ToDouble(row["FreeStock"]);
                gauges.Maximum = Convert.ToDouble(row["MaxStock"]);
                gauges.Value = Convert.ToDouble(row["AvailableStock"]);
            }

            CircularGaugePointer pointer = new CircularGaugePointer();
            pointer.Value = gauges.Value;

            CircularGaugeAxis axis = new CircularGaugeAxis();
            axis.Pointers = new List<CircularGaugePointer>();
            axis.Minimum = gauges.Minimum;
            axis.Maximum = gauges.Maximum;
            axis.Pointers.Add(pointer);

            gaugeModel.Axes = new List<CircularGaugeAxis>();
            gaugeModel.Axes.Add(axis);
        }
```

**Step 2**:

Bind the gauge properties passed via ViewData from the controller at client-side as demonstrated in the following code sample.

```html
   @Html.EJS().CircularGauge("container", (Syncfusion.EJ2.CircularGauge.CircularGauge)ViewData["GaugeModel"]).Render();
```

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/how-to/database/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Database.cs" %}
{% include code-snippet/circulargauge/how-to/database/database.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/how-to/database/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Database.cs" %}
{% include code-snippet/circulargauge/how-to/database/database.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Sample reference**

[`circulargauge sample`](https://github.com/SyncfusionExamples/How-to-get-data-for-circular-gauge-from-database-and-render-gauge-from-code-behind).

**Screenshot**

![Screenshot for your reference](../images/database.png)