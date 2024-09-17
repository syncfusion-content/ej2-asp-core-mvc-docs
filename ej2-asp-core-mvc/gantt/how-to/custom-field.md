---
layout: post
title: Custom Field in ##Platform_Name## Gantt Component
description: Learn here all about Custom Field in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Custom Field
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add Custom Fields in the General Tab in Add/Edit Dialog

Generally in Gantt, Custom fields are displayed in the Custom Tab of the Add/Edit dialogs. However, they can be included in the General Tab of Add/Edit Dialog Box using `actionBegin` and `actionComplete` events. These events are used to append the custom field to the dialog box. The following code snippets demonstrate the solution.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/customfield/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customfield.cs" %}
{% include code-snippet/gantt/how-to/customfield/customfield.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/customfield/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customfield.cs" %}
{% include code-snippet/gantt/how-to/customfield/customfield.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

# Managing Custom Field Visibility in Gantt Charts

In Gantt charts, custom fields offer a valuable way to include additional data for tasks, providing a more comprehensive view of your project. Typically, these custom fields are visible in both the Custom tab of the Add/Edit dialogs and as columns within the grid. However, there might be instances where you want to control the visibility of these custom fields, particularly on the chart side and in the grid side. This documentation will guide you on how to achieve this through different methods.

## Hiding Custom Fields in the Grid

To hide custom fields from the grid while still enabling editing, you can set the custom column's `visibility` to `false`. This will ensure that the field is not displayed as a column in the Gantt chart's grid, allowing users to focus on essential task-related information.

```cssharp
col.Field("Custom").Visible(false).Add();

```

## Dynamically Managing Custom Field Visibility on the Chart Side

The `actionBegin` and `actionComplete` events can be employed to manipulate custom field visibility during interactions with the chart. Specifically, the actionBegin event is triggered before opening the Edit dialog, while the actionComplete event is triggered after the dialog is opened.

Using the actionBegin Event

```javascript
function actionBegin(args) {
    var ganttObj = document.getElementById("Gantt").ej2_instances[0];
    if (args.requestType === 'beforeOpenEditDialog') {
        ganttObj.columnByField["Custom"].visible = true;
    }
}

```

This code snippet demonstrates how to use the actionBegin event to make the custom field visible when the Edit dialog is about to open.

Using the actionComplete Event

```javascript
function actionComplete(args) {
    var ganttObj = document.getElementById("Gantt").ej2_instances[0];
    if (args.requestType === 'openEditDialog') {
        ganttObj.columnByField["Custom"].visible = false;
    }
}

```

Here, the actionComplete event is employed to hide the custom field after the Edit dialog is opened.

By implementing these event-based approaches, you can seamlessly control the visibility of custom fields in both the grid and the chart side of the Gantt chart. This empowers you to tailor the information presented to users, creating a more focused and efficient project management experience.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/customfield-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/gantt/how-to/customfield-cs2/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/customfield-cs2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/gantt/how-to/customfield-cs2/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
