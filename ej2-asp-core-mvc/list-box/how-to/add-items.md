---
layout: post
title: Add Items in ##Platform_Name## List Box Component
description: Learn here all about Add Items in Syncfusion ##Platform_Name## List Box component and more.
platform: ej2-asp-core-mvc
control: Add Items
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add items to the list box

To add an item or multiple items, [`addItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~AddItems.html) method can be used. In the following example, the `Bugatti Veyron Super Sport` and `SSC Ultimate Aero` items will be added while clicking `Add Items` button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/add-items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Additem.cs" %}
{% include code-snippet/listbox/add-items/additem.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/add-items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Additem.cs" %}
{% include code-snippet/listbox/add-items/additem.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

