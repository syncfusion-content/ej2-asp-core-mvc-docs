---
layout: post
title: How to configure cascading ##Platform_Name## DropDownList | Syncfusion
description: Configure cascading Syncfusion ##Platform_Name## DropDownList where child list data loads based on the parent selection using the change event handler.
platform: ej2-asp-core-mvc
control: Cascading
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to configure cascading ##Platform_Name## DropDownList

The cascading DropDownList is a series of DropDownLists, where the selection in one DropDownList determines the available options in the next. This is configured using the [change](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Change) event of the parent DropDownList. Within that change event handler, data is loaded into the child DropDownList based on the selected value of the parent DropDownList.

The following example shows the cascade behavior of country, state, and city DropDownList. Here, the [dataBind](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_DataBound) method is used to reflect the property changes immediately to the DropDownList.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/cascading/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Country.cs" %}
{% include code-snippet/dropdownlist/how-to/cascading/Country.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Cascading.cs" %}
{% include code-snippet/dropdownlist/how-to/cascading/Cascading.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/cascading/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Country.cs" %}
{% include code-snippet/dropdownlist/how-to/cascading/Country.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Cascading.cs" %}
{% include code-snippet/dropdownlist/how-to/cascading/Cascading.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

