---
layout: post
title: Icons Support in ##Platform_Name## Syncfusion Drop Down List Component
description: Learn here all about icons support in Syncfusion ##Platform_Name## Drop Down List component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Icons Support
publishingplatform: ##Platform_Name##
documentation: ug
---


# Show the list items with icons

You can render **icons** to the list items by mapping the [iconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownListFieldSettings.html#Syncfusion_EJ2_DropDowns_DropDownListFieldSettings_IconCss) field. This `iconCss` field creates a span in the list item with mapped class name to allow styling as per your need.

In the following sample, icon classes are mapped with `iconCss` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/icons/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SocialMedia.cs" %}
{% include code-snippet/dropdownlist/how-to/icons/SocialMedia.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/icons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SocialMedia.cs" %}
{% include code-snippet/dropdownlist/how-to/icons/SocialMedia.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

