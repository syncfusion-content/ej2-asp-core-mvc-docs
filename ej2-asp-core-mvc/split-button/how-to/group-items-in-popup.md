---
layout: post
title: Group Items in Popup in ##Platform_Name## Split Button | Syncfusion
description: Learn how to group items in the Syncfusion ##Platform_Name## Split Button popup by using a ListView as the target and organizing items into groups.
platform: ej2-asp-core-mvc
control: Group Items In Popup
publishingplatform: ##Platform_Name##
documentation: ug
---


# Group Items in Popup in ##Platform_Name## Split Button

Grouped items are possible in SplitButton by templating entire popup with ListView. Check ListView [`grouping`](https://ej2.syncfusion.com/aspnetmvc/documentation/listview/grouping) and create such items. Create ListView with id `listview` and provide element of the ListView as target of SplitButton to render it in popup area.

In this following example, ListView is created and its element is set as [`target`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_Target) for SplitButton.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/split-button/listview/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Listview.cs" %}
{% include code-snippet/split-button/listview/demo/listview.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/split-button/listview/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Listview.cs" %}
{% include code-snippet/split-button/listview/demo/listview.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

