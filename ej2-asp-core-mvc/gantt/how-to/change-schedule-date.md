---
layout: post
title: Change Schedule Date in ##Platform_Name## Gantt Component
description: Learn here all about Change Schedule Date in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Change Schedule Date
publishingplatform: ##Platform_Name##
documentation: ug
---

# Change schedule start and end dates

In the Gantt control, you can change the schedule start and end dates by clicking the custom button programmatically using the `updateProjectDates` method. You can pass the start and end dates as method arguments to the `updateProjectDates` method. You can also pass the Boolean value as an additional parameter, which is used to round-off the schedule start and end dates displayed in Gantt timeline.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/changeScheduleDates/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ChangeScheduleDates.cs" %}
{% include code-snippet/gantt/how-to/changeScheduleDates/changeScheduleDates.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/changeScheduleDates/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ChangeScheduleDates.cs" %}
{% include code-snippet/gantt/how-to/changeScheduleDates/changeScheduleDates.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

