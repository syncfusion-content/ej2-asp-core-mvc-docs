---
layout: post
title: ##Platform_Name## Grid Empty Record Template | Syncfusion
description: Learn how to customize the empty record template in ##Platform_Name## Data Grid to display custom messages, images, or actions when no data is available.
platform: ej2-asp-core-mvc
control: Customize the Empty Record Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Empty Record Template in ASP.NET MVC Data Grid

The empty record template feature in the Syncfusion ASP.NET MVC Grid allows you to use custom content such as images, text, or other components, when the Grid doesn't contain any records to display. This feature replaces the default message of 'No records to display' typically shown in the Grid.

To activate this feature, set the `EmptyRecordTemplate` property of the Grid. The `EmptyRecordTemplate` property expects the HTML element or a function that returns the HTML element.

In the following example, an image and text have been rendered as a template to indicate that the Grid has no data to display.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/empty-record-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="empty-record-template.cs" %}
{% include code-snippet/grid/how-to/empty-record-template/empty-record-template.cs %}
{% endhighlight %}
{% endtabs %}

![Empty Record Template](../images/customer-loop.png)