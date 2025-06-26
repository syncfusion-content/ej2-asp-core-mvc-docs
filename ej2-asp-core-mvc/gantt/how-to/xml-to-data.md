---
layout: post
title: Import Microsoft Project XML into ##Platform_Name## Gantt Component| Syncfusion
description: Learn here to import microsoft project XML into Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Xml to data
publishingplatform: ##Platform_Name##
documentation: ug
---

# Import Microsoft Project XML into Gantt Chart

In this guide, we'll explore how to import task data from an XML file into a Gantt Chart. This example assumes you have an XML file conforming to the Microsoft Project XML schema, containing task-related information.

## Steps

* Add a file upload component to your application using Syncfusion's `Uploader` component. This allows users to upload XML files easily.
* Implement the `Selected` method in the Uploader. This method reads the uploaded XML file, converts it into a list of GanttDataSource objects, and updates the Gantt Chart's data source.
* Use the xmlToJson method to parse the XML content and convert it into JSON format.
* Implement additional utility methods, such as `transformGanttData`, to handle specific data transformations required for the Gantt Chart.
* Ensure that your Gantt Chart component is initialized with the appropriate task fields and edit settings.

With these steps, you'll be able to seamlessly import task data from XML files and display it in the Gantt Chart.

The following code snippet demonstrates how to import a Microsoft Project XML file into the Gantt Chart control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/xmlToData/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="xmlToData.cs" %}
{% include code-snippet/gantt/how-to/xmlToData/xmlToData.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/xmlToData/razor %}
{% endhighlight %}
{% highlight c# tabtitle="xmlToData.cs" %}
{% include code-snippet/gantt/how-to/xmlToData/xmlToData.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

