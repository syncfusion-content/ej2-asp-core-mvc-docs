---
layout: post
title: How to show ##Platform_Name## DropDownList items with icons | Syncfusion
description: Render Syncfusion ##Platform_Name## DropDownList list items with iconCss that creates a styled span inside each item using the mapped CSS class name.
platform: ej2-asp-core-mvc
control: Icons Support
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to show ##Platform_Name## DropDownList items with icons

You can render **icons** to the list items by mapping the [iconCss](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.DropDowns.DropDownListFieldSettings.html#Syncfusion_EJ2_DropDowns_DropDownListFieldSettings_IconCss) field. This `iconCss` field creates a span element within the list item using the mapped class name, allowing it to be styled as needed.

In the following sample, icon classes are mapped via the `iconCss` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dropdownlist/how-to/icons/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SocialMedia.cs" %}
{% include code-snippet/dropdownlist/how-to/icons/SocialMedia.cs %}
{% endhighlight %}
{% highlight c# tabtitle="icons.cs" %}
{% include code-snippet/dropdownlist/how-to/icons/icons.cs %}
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
{% highlight c# tabtitle="icons.cs" %}
{% include code-snippet/dropdownlist/how-to/icons/icons.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

