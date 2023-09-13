---
layout: post
title: Dynamically change indicator background color in ##Platform_Name## Gantt Component
description: Learn here all about Dynamically change indicator background color in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Indicator background color
publishingplatform: ##Platform_Name##
documentation: ug
---


# Dynamically change indicator background color in Gantt component

In a Syncfusion Gantt chart, indicators are a great way to highlight important points or events on your tasks. By default, these indicators have a black background color. However, you might want to dynamically change their background color based on certain conditions or user actions.

Here, we'll show you how to dynamically change the background color of indicators using a button click in a Syncfusion Gantt chart.

```js
document.getElementById('indicator').addEventListener('click', function (args) 
{
    var node = document.querySelectorAll('.e-indicator-span');
    node.forEach((box) => 
	{
		box.children[0].style.color = 'red';
    });
}

```

The following code snippets demonstrate how to achieve this.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/indicator-background-color-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Indicator.cs" %}
{% include code-snippet/gantt/how-to/indicator-background-color-cs1/Indicator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/indicator-background-color-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Indicator.cs" %}
{% include code-snippet/gantt/how-to/indicator-background-color-cs1/Indicator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Alt text](../images/indicator-background-color.png)