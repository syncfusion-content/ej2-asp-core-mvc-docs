---
layout: post
title: Types in ##Platform_Name## Chips Control | Syncfusion
description: Learn here all about Types in Syncfusion ##Platform_Name## Chips control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Types
publishingplatform: ##Platform_Name##
documentation: ug
---

# Types in Chips Control

The ChipList control has the following types.

* Input Chips
* Choice Chips
* Filter Chips
* Action Chips

## Input Chips

Input Chips holds information in compact form. It converts user input into Chips.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/input/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/input/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/input/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Input Chips Control](images/input-chip.png)

## Choice Chips

{% if page.publishingplatform == "aspnet-core" %}

Choice Chips allows to select a single Chips from the set of ChipList/ChipCollection. It can be enabled by setting the [`selection`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_Selection) property to `Single`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/choice/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Choice Chips allows to select a single Chips from the set of ChipList/ChipCollection. It can be enabled by setting the [`selection`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_Selection) property to `Single`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/choice/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/choice/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Choice Chips Control](images/choice-chip.png)

## Filter Chips

{% if page.publishingplatform == "aspnet-core" %}

Filter Chips allows to select a multiple Chips from the set of ChipList/ChipCollection. It can be enabled by setting the [`selection`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_Selection) property to `Multiple`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/filter/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Filter Chips allows to select a multiple Chips from the set of ChipList/ChipCollection. It can be enabled by setting the [`selection`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_Selection) property to `Multiple`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/filter/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/filter/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Filter Chips Control](images/filter-chip.png)

## Action Chips

{% if page.publishingplatform == "aspnet-core" %}

The Action Chips triggers the event like [`click`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_Click) or [`delete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_Delete), which helps doing action based on the event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/action/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

The Action Chips triggers the event like [`click`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_Click) or [`delete`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_Delete), which helps doing action based on the event.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/action/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/action/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Actions Chips Control](images/action-chip.png)

### Deletable Chips

{% if page.publishingplatform == "aspnet-core" %}

Deletable Chips allows to delete a Chips from ChipList/ChipCollection. It can be enabled by setting the [`enableDelete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_EnableDelete) property to `true`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/chips/delete/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

Deletable Chips allows to delete a Chips from ChipList/ChipCollection. It can be enabled by setting the [`enableDelete`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.Buttons.ChipList.html#Syncfusion_EJ2_Buttons_ChipList_EnableDelete) property to `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/chips/delete/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/chips/delete/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Deletable Chips Control](images/deletable-chip.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Chips/ChipsSample).