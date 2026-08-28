---
layout: post
title: Popup Resize in ##Platform_Name## MultiSelect | Syncfusion
description: Allow users to resize the Syncfusion ##Platform_Name## MultiSelect popup dynamically by enabling the allowResize property and persisting dimensions across sessions.
platform: ej2-asp-core-mvc
control: Resizing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Popup resize in ##Platform_Name## MultiSelect

You can dynamically adjust the size of the popup in the MultiSelect control by using the [allowResize](https://help.syncfusion.com/cr/aspnetmvc-js2/syncfusion.ej2.dropdowns.multiselect.html#Syncfusion_EJ2_DropDowns_MultiSelect_AllowResize) property. When enabled, users can resize the popup, improving visibility and control, and the resized dimensions are retained across sessions for a consistent user experience.

The following sample illustrates the implementation of the popup resize feature.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/multiselect/popup-resize/tagHelper %}
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
{% include code-snippet/multiselect/popup-resize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PopupResize.cs" %}
{% include code-snippet/multiselect/popup-resize/popup-resize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Resizing the popup in the MultiSelect control](images/multiselect-resize.gif){:width="600"}