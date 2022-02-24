---
layout: post
title: Caption Template in ##Platform_Name## Grid Component
description: Learn here all about Caption Template in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core
control: Caption Template
publishingplatform: aspnet-core
documentation: ug
---


# Caption Template

You can customize the group caption by using the [`captionTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridGroupSettings.html#Syncfusion_EJ2_Grids_GridGroupSettings_CaptionTemplate) property of **e-grid-groupsettings** tag helper.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/caption-temp/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Caption-temp.cs" %}
{% include code-snippet/grid/grouping/caption-temp/caption-temp.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/grouping/caption-temp/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Caption-temp.cs" %}
{% include code-snippet/grid/grouping/caption-temp/caption-temp.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

