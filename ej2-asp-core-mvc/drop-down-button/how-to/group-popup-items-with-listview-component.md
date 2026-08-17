---
layout: post
title: How to group popup items with ListView in ##Platform_Name## DropDownButton | Syncfusion
description: Group Syncfusion ##Platform_Name## DropDownButton popup items by templating the popup with ListView and using the groupBy field for category headers.
platform: ej2-asp-core-mvc
control: Group Popup Items With Listview Component
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to group popup items with ListView in ##Platform_Name## DropDownButton

Header in popup items is possible in DropdownButton by templating entire popup with ListView. Create ListView with id `#listview` and provide it as a [`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_Target) for DropDownButton.

In the following example, ListView element is given as `target` to DropDownButton and header can be achieved by [`groupBy`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Lists.ListViewFieldSettings.html#Syncfusion_EJ2_Lists_ListViewFieldSettings_GroupBy) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/listview/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Listview.cs" %}
{% include code-snippet/dropdownbutton/listview/listview.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownbutton/listview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Listview.cs" %}
{% include code-snippet/dropdownbutton/listview/listview.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

