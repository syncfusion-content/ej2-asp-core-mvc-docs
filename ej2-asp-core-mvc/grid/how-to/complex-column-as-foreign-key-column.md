---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Complex Column As Foreign Key Column of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Complex Column As Foreign Key Column
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set complex column as Foreignkey column

The following example shows how to set the complex column as foreign key column.

In the following example, `Employee.EmployeeID` is a complex column and also declared as a foreign column which shows `FirstName` column from foreign data.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="foreignkey" %}
{% include_relative code-snippet/columns/foreignkey/foreignkey.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="tagHelpers" %}
{% include_relative code-snippet/columns/foreignkey/tagHelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="foreignkey" %}
{% include_relative code-snippet/columns/foreignkey/foreignkey.cs %}
{% endhighlight %}
{% highlight razor tabtitle="razor" %}
{% include_relative code-snippet/columns/foreignkey/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}


