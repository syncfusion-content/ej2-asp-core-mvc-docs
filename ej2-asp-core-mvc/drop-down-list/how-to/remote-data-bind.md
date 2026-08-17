---
layout: post
title: How to count remote data bound to ##Platform_Name## DropDownList | Syncfusion
description: Get Syncfusion ##Platform_Name## DropDownList total item count from the actionComplete event result before rendering, and via getItems after rendering.
platform: ej2-asp-core-mvc
control: Remote Data Bind
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to count remote data bound to ##Platform_Name## DropDownList

Before control rendering, you can get the total items count by using [actionComplete](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_ActionComplete) event with its result arguments. After rendering this control, you can get the total items count by using `getItems` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/totalcount/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Totalcount.cs" %}
{% include code-snippet/dropdownlist/how-to/totalcount/totalcount.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/totalcount/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Totalcount.cs" %}
{% include code-snippet/dropdownlist/how-to/totalcount/totalcount.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

