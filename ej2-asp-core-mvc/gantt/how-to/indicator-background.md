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

Indicators are a great way to highlight important points or events on tasks within the Syncfusion Gantt Chart. By default, these indicators have a black background color. However, the background color can be dynamically changed based on specific conditions or actions within the application.

The following code snippets demonstrate how to achieve this.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/indicator-background-color-cs1/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/indicator-background-color-cs1/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Alt text](../images/indicator-background-color.png)