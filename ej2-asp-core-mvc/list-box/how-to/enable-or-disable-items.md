---
layout: post
title: How to enable or disable items in ##Platform_Name## ListBox | Syncfusion
description: Disable individual Syncfusion ##Platform_Name## ListBox items using the disabled or disabledItems fields and conditionally toggle user interaction per item.
platform: ej2-asp-core-mvc
control: Enable Or Disable Items
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to enable or disable items in ##Platform_Name## ListBox

To enable or disable items in the list box, [`enableItems`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ListBox~EnableItems.html) method can be used. In the following example, the `Bugatti Veyron Super Sport` and `SSC Ultimate Aero` items are disabled by default and by clicking `Enable Items` buttons, the disabled items will be enabled.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listbox/enable-items/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Enableitem.cs" %}
{% include code-snippet/listbox/enable-items/enableitem.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listbox/enable-items/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Enableitem.cs" %}
{% include code-snippet/listbox/enable-items/enableitem.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

