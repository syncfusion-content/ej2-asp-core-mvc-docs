---
layout: post
title: Customizing the empty data source message in ##Platform_Name## Gantt Component
description: Learn here all about Customizing the empty data source message in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customizing the empty data source message
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customizing the empty data source message in Gantt

By default, the Gantt component displays the message "No records to display" when the data source is empty. However, you can customize this message using [`localization`](https://ej2.syncfusion.com/aspnetcore/documentation/gantt/global-local#localization) to provide a more meaningful message to your users.

The following code snippets demonstrate how to achieve this.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/how-to-no-records-display-cs1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="NoRecordsDisplay.cs" %}
{% include code-snippet/gantt/how-to/how-to-no-records-display-cs1/norecordsdisplay.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/how-to-no-records-display-cs1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="NoRecordsDisplay.cs" %}
{% include code-snippet/gantt/how-to/how-to-no-records-display-cs1/norecordsdisplay.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Alt text](../images/norecordsdisplay.png)