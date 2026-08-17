---
layout: post
title: How to detect programmatic value change in ##Platform_Name## DropDownList | Syncfusion
description: Detect whether Syncfusion ##Platform_Name## DropDownList value change came from user interaction by checking the isInteracted flag in the change event arg.
platform: ej2-asp-core-mvc
control: Value Change
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to detect programmatic value change in ##Platform_Name## DropDownList

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

