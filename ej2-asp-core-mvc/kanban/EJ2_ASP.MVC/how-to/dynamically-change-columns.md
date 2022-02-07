---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Dynamically Change Columns of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Dynamically Change Columns
publishingplatform: ##Platform_Name##
documentation: ug
---


# Change Kanban columns dynamically

You can dynamically change the Kanban columns by using the [`columns`](../../api/kanban#columns) property.

In the below sample, you can dynamically change the [`allowToggle`](../../api/kanban/columnsModel/#allowtoggle) property at the particular column when you click on the button. You can also change the initially created columns to the new Kanban columns by using the [`columns`](../../api/kanban#columns) property when you click on the button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% endhighlight %}
{% highlight c# tabtitle="code-snippet/kanban/cards/dynamic-columns/datasource.cs" %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% endhighlight %}
{% highlight c# tabtitle="code-snippet/kanban/cards/dynamic-columns/datasource.cs" %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/dynamic-columns.PNG)