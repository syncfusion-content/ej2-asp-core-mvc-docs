---
layout: post
title: Customize the Empty Record Template in Syncfusion ASP.NET MVC TreeGrid
description: Learn here all about Customize the Empty Record Template in Syncfusion ASP.NET MVC TreeGrid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customize the Empty Record Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize the Empty Record Template in ASP.NET MVC TreeGrid

The empty record template feature in the TreeGrid allows you to use custom content such as images, text, or other components, when the TreeGrid doesn't contain any records to display. This feature replaces the default message of **No records to display** typically shown in the TreeGrid.

To activate this feature, set the `EmptyRecordTemplate` property of the TreeGrid. The `EmptyRecordTemplate` property expects the HTML element or a function that returns the HTML element.

In the following example, an image and text have been rendered as a template to indicate that the TreeGrid has no data to display.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tree-grid/how-to/empty-record-template-treegrid/razor %}
{% endhighlight %}
{% highlight c# tabtitle="empty-record-template.cs" %}
{% include code-snippet/tree-grid/how-to/empty-record-template-treegrid/empty-record-template.cs %}
{% endhighlight %}
{% endtabs %}

![Empty Record Template TreeGrid](../images/empty-record.png)