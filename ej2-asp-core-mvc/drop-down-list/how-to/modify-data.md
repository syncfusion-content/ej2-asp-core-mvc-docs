---
layout: post
title: How to modify remote data in ##Platform_Name## DropDownList | Syncfusion
description: Modify Syncfusion ##Platform_Name## DropDownList remote data by hooking into the actionComplete event and adjusting the result array before display.
platform: ej2-asp-core-mvc
control: Modify Data
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to modify remote data in ##Platform_Name## DropDownList

When binding the remote data source, use the [actionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_ActionComplete) event to modify the result data before it is passed to the DropDownList.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/modifydata/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Modifydata.cs" %}
{% include code-snippet/dropdownlist/how-to/modifydata/modifydata.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/modifydata/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Modifydata.cs" %}
{% include code-snippet/dropdownlist/how-to/modifydata/modifydata.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

