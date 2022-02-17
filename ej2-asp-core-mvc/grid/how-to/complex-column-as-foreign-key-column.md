---
layout: post
title: Complex Column As Foreign Key Column in ##Platform_Name## Grid Component
description: Learn here all about Complex Column As Foreign Key Column in Syncfusion ##Platform_Name## Grid component and more.
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
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/foreignkey/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Foreignkey.cs" %}
{% include code-snippet/grid/columns/foreignkey/foreignkey.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/columns/foreignkey/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Foreignkey.cs" %}
{% include code-snippet/grid/columns/foreignkey/foreignkey.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


