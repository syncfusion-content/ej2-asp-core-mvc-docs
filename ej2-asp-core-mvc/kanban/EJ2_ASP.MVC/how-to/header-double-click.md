---
layout: post
title: Header Double Click in ##Platform_Name## Kanban Component
description: Learn here all about Header Double Click in Syncfusion ##Platform_Name## Kanban component and more.
platform: ej2-asp-core-mvc
control: Header Double Click
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add header double click

You can bind the header double click event by using the [`dataBound`](../../api/kanban#dataBound) event at the initial rendering. You can get the column header text when you double click on the headers.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/kanban/how-to/header-double-click/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/how-to/header-double-click/datasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/kanban/how-to/header-double-click/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Datasource.cs" %}
{% include code-snippet/kanban/how-to/header-double-click/datasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![kanban](./images/header-double-click.PNG)