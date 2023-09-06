---
layout: post
title: Show/Hide Taskbar in ##Platform_Name## Gantt Component
description: Learn here all about Show/Hide Taskbar in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Show Hide Taskbar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Dynamic Show/Hide Specific Taskbar in Gantt Chart

In a Gantt chart, all taskbars are usually displayed by default. However, you might want to provide users with the ability to dynamically show or hide specific taskbars based on certain conditions. This can be achieved using the [`queryTaskbarInfo`](https://ej2.syncfusion.com/react/documentation/api/gantt/ganttModel/#querytaskbarinfo) and [`queryCellInfo`](https://ej2.syncfusion.com/react/documentation/api/gantt/ganttModel/#querycellinfo) events. These events allow you to control the visibility of taskbars and their associated cells in the Gantt chart.

## Using the `queryTaskbarInfo` event

The `queryTaskbarInfo` event is triggered before rendering taskbars in the Gantt chart. It provides you with the ability to customize the appearance of taskbars or even hide them based on certain conditions.

```js
function queryTaskbarInfo(args) 
{
    if (switchChecked && args.data.ganttProperties.taskId == 1) 
	{
        for (var i = 0; i < args.rowElement.children[0].children.length; i++) 
		{
            args.rowElement.children[0].children[i].style.display = 'none';
        }
    }
}

```

## Using the `queryCellInfo` event

The `queryCellInfo` event allows you to customize the content of individual cells in the Gantt chart. This event can be used to hide cell content or apply special styling based on specific conditions.

```js
function queryCellInfo(args) 
{
    if (switchChecked && args.data.ganttProperties.taskId == 1) 
	{
        args.cell.innerText = '';
    }
}

```

The following code snippet shows how to show/hide the taskbar when rendering the Gantt control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/showhidetaskbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="showhidetaskbar.cs" %}
{% include code-snippet/gantt/how-to/showhidetaskbar/showhidetaskbar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/showhidetaskbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="showhidetaskbar.cs" %}
{% include code-snippet/gantt/how-to/showhidetaskbar/showhidetaskbar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}