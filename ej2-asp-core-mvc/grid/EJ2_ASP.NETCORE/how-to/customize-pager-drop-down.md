---
layout: post
title: Customize Pager Drop Down in ##Platform_Name## Grid Component
description: Learn here all about Customize Pager Drop Down in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Customize Pager Drop Down
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize Pager DropDown

To customize default values of pager dropdown, you need to define [`pageSizes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSizes) as array of strings.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/pagerdropdown/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pagerdropdown.cs" %}
{% include code-snippet/grid/how-to/pagerdropdown/pagerdropdown.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/pagerdropdown/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pagerdropdown.cs" %}
{% include code-snippet/grid/how-to/pagerdropdown/pagerdropdown.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


