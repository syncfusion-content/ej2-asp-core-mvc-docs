---
layout: post
title: Resizing in ##Platform_Name## ComboBox Control | Syncfusion
description: Learn here all about Popup Resizing in Syncfusion ##Platform_Name## ComboBox control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Resizing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Resizing in ##Platform_Name## ComboBox Control

You can dynamically adjust the size of the popup in the ComboBox component by using the [AllowResize](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.dropdowns.combobox.html#Syncfusion_EJ2_DropDowns_ComboBox_AllowResize) property. When enabled, users can resize the popup, improving visibility and control, with the resized dimensions being retained across sessions for a consistent user experience.

The following sample illustrates the implementation of the Popup Resize feature.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/combobox/popup-resize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
public class PopupResizeData
{
    public string Status { get; set; }
    public bool State { get; set; }
}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/combobox/popup-resize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PopupResize.cs" %}
{% include code-snippet/combobox/popup-resize/popup-resize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Resizing in ComboBox Component](./images/combobox-resize.gif)