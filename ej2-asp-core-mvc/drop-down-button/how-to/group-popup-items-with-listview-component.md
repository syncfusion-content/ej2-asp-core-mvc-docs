---
layout: post
title: Group Popup Items With Listview Component in ##Platform_Name## Drop Down Button Component
description: Learn here all about Group Popup Items With Listview Component in Syncfusion ##Platform_Name## Drop Down Button component and more.
platform: ej2-asp-core-mvc
control: Group Popup Items With Listview Component
publishingplatform: ##Platform_Name##
documentation: ug
---


# Group popup items with ListView component

Header in popup items is possible in DropdownButton by templating entire popup with ListView.
Create ListView with id `#listview` and provide it as a
[`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.DropDownButton.html#Syncfusion_EJ2_SplitButtons_DropDownButton_Target) for DropDownButton.

In the following example, ListView element is given as `target` to DropDownButton and header
can be achieved by [`groupBy`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Lists.ListViewFieldSettings.html#Syncfusion_EJ2_Lists_ListViewFieldSettings_GroupBy) property.

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

