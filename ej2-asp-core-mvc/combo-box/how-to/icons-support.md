---
layout: post
title: How to show icons support in ##Platform_Name## ComboBox | Syncfusion
description: Map CSS class names to the iconCss field in Syncfusion ##Platform_Name## ComboBox to render icons alongside each list item.
platform: ej2-asp-core-mvc
control: Icons Support
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to show icons support in ##Platform_Name## ComboBox

You can render **icons** to the list items by mapping the [iconCss](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.ComboBoxFieldSettings.html#Syncfusion_EJ2_DropDowns_ComboBoxFieldSettings_IconCss) &nbsp;field. This `iconCss` field create a span in the list item with mapped class name to allow styling as per your need.

In the following sample, icon classes are mapped with `iconCss` field.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/how-to/icons/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class SocialMedia
{
    public string Class { get; set; }
    public string SocialMediaName { get; set; }
    public string Id { get; set; }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/how-to/icons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SocialMedia.cs" %}
{% include code-snippet/combobox/how-to/icons/SocialMedia.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ComboBox/ComboBoxHowToSample).