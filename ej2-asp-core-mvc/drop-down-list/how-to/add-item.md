---
layout: post
title: Add Item in ##Platform_Name## Drop Down List Component
description: Learn here all about Add Item in Syncfusion ##Platform_Name## Drop Down List component and more.
platform: ej2-asp-core-mvc
control: Add Item
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add item in between in DropDownList

You can add item in between based on item [index](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~Index.html). If you add new item without item index, item will be added as last item in list.

The following example demonstrate how to add item in between in DropDownList.

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

