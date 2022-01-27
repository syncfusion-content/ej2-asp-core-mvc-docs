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

To customize default values of pager dropdown, you need to define in [`PageSizes`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridPageSettings.html#Syncfusion_EJ2_Grids_GridPageSettings_PageSizes) property as array of strings.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="pagerdropdown" %}
{% include_relative code-snippet/how-to/pagerdropdown/pagerdropdown.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="pagerdropdown" %}
{% include_relative code-snippet/how-to/pagerdropdown/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="pagerdropdown" %}
{% include_relative code-snippet/how-to/pagerdropdown/pagerdropdown.cs %}
{% endhighlight %}
{% highlight razor tabtitle="pagerdropdown" %}
{% include_relative code-snippet/how-to/pagerdropdown/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}


