---
layout: post
title: Detect programmatic value change | Syncfusion
description: Detect whether Syncfusion ##Platform_Name## DropDownList value change came from user interaction by checking the isInteracted flag in the change event arg.
platform: ej2-asp-core-mvc
control: Value Change
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to detect programmatic value change in ##Platform_Name## DropDownList

You can determine whether a value change was caused by user interaction or programmatically by inspecting the [change](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Change) event argument. The `isInteracted` property returns `true` when the change originated from a user interaction in the UI, and `false` when it was set programmatically (for example, by assigning the `value` property). The following sample demonstrates both cases: the button triggers a programmatic change, while selecting an item in the dropdown triggers an interaction-driven change.

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

