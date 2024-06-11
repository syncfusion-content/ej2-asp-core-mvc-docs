---
layout: post
title: Separate Connector in ##Platform_Name## Query Builder Component | Syncfusion
description: Learn here all about Separate Connector in Syncfusion ##Platform_Name## Query Builder component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Separate Connector
documentation: ug
domainurl: ##DomainURL##
---


# Separate Connector in ##Platform_Name## Query builder control

The Query Builder provides the functionality to integrate standalone connectors between rules or groups within the same group. This allows for greater flexibility, as users can connect rules or groups using different connectors, enhancing the complexity and precision of query construction. You can use `EnableSeparateConnector` to perform separate connector functionality.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/separate-connector/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/separate-connector/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/separate-connector/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/separate-connector/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![Query builder Sample](images/separate-connector.png)
