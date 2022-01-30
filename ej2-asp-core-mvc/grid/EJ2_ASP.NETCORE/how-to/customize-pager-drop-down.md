---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize Pager Drop Down of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customize Pager Drop Down
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize Pager DropDown

To customize default values of pager dropdown, you need to define [`pageSizes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSizes) as array of strings.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="tagHelper" %}
{% include code-snippet/grid/how-to/pagerdropdown/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="pagerdropdown" %}
{% include code-snippet/grid/how-to/pagerdropdown/pagerdropdown.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="razor" %}
{% include code-snippet/grid/how-to/pagerdropdown/razor %}
{% endhighlight %}
{% highlight c# tabtitle="pagerdropdown" %}
{% include code-snippet/grid/how-to/pagerdropdown/pagerdropdown.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


