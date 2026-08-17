---
layout: post
title: How to add items in ##Platform_Name## DropDownList | Syncfusion
description: Insert a Syncfusion ##Platform_Name## DropDownList item at any index using the addItem method, with default insertion appending to the list end.
platform: ej2-asp-core-mvc
control: Add Item
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to add items in ##Platform_Name## DropDownList

You can add item in between based on item [index](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownList.html#Syncfusion_EJ2_DropDowns_DropDownList_Index). If you add new item without item index, item will be added as last item in list.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/additem/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GameList.cs" %}
{% include code-snippet/dropdownlist/how-to/additem/GameList.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/additem/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GameList.cs" %}
{% include code-snippet/dropdownlist/how-to/additem/GameList.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

