---
layout: post
title: Enable Or Disable Items in ##Platform_Name## List Box Component
description: Learn here all about Enable Or Disable Items in Syncfusion ##Platform_Name## List Box component and more.
platform: ej2-asp-core-mvc
control: Enable Or Disable Items
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enable or disable items

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

