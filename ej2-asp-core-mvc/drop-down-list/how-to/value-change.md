---
layout: post
title: Value Change in ##Platform_Name## Drop Down List | Syncfusion
description: Learn here all about value change in Syncfusion ##Platform_Name## Drop Down List component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Value Change
publishingplatform: ##Platform_Name##
documentation: ug
---


# Detect whether the value change happened by manual or programmatic

You can check whether the value change happened by manual or programmatic by using [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Change) event argument, that argument name is `isInteracted`.

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

