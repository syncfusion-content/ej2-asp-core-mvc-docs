---
layout: post
title: Import Export in ##Platform_Name## Query Builder Component
description: Learn here all about Import Export in Syncfusion ##Platform_Name## Query Builder component and more.
platform: ej2-asp-core-mvc
control: Import Export
publishingplatform: ##Platform_Name##
documentation: ug
---


# Importing

Importing allows you to view or edit the predefined conditions. You can import the conditions by using methods and initial rendering.

## Initial Rendering

To apply conditions initially, you can define the `Rule`. Here, you can import structured JSON object by defining the `Rule` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/getting-started/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/getting-started/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Post Rendering

### Import from JSON

You can set the conditions from structured JSON object through the `setRules` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/import-export/import-json/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/import-export/import-json/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/import-export/import-json/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/import-export/import-json/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Import From SQL

You can set the conditions from SQL query through the `setRulesFromSql` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/import-export/import-sql/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/import-export/import-sql/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/import-export/import-sql/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/import-export/import-sql/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Exporting

Exporting allows you to save or maintain the created conditions through the Query Builder. You can export the defined conditions by the following ways.

### JSON Export

You can export the defined conditions to structured JSON object through the `getRules` method.

### SQL Support

You can export the defined conditions to SQL query through the `getRulesFromSQL` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/import-export/export-sql/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/import-export/export-sql/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/import-export/export-sql/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/import-export/export-sql/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

