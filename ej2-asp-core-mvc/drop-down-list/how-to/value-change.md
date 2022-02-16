---
layout: post
title: Value Change in ##Platform_Name## Drop Down List Component
description: Learn here all about Value Change in Syncfusion ##Platform_Name## Drop Down List component and more.
platform: ej2-asp-core-mvc
control: Value Change
publishingplatform: ##Platform_Name##
documentation: ug
---


# Detect whether the value change happened by manual or programmatic

You can check about whether value change happened by manual or programmatic by
using [change](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~Change.html) event argument that argument name is `isInteracted`.

The following example demonstrate, how to check whether value change happened by manual or programmatic.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/detectchange/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Employees.cs" %}
{% include code-snippet/dropdownlist/how-to/detectchange/Employees.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/detectchange/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Employees.cs" %}
{% include code-snippet/dropdownlist/how-to/detectchange/Employees.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

