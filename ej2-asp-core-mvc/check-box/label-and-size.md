---
layout: post
title: Label And Size in ##Platform_Name## Check Box Control | Syncfusion
description: Learn here all about Label And Size in Syncfusion ##Platform_Name## Check Box control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Label And Size
publishingplatform: ##Platform_Name##
documentation: ug
---


# Label and Size in Check Box Control

This section explains the different sizes and labels.

## Label

The CheckBox caption can be defined by using the [label](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.CheckBox.html#Syncfusion_EJ2_Buttons_CheckBox_Label) property. This reduces the manual addition of label for CheckBox. You can customize the label position before or after the CheckBox through the [labelPosition](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.CheckBox.html#Syncfusion_EJ2_Buttons_CheckBox_LabelPosition) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/check-box/label/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/check-box/label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label.cs" %}
{% include code-snippet/check-box/label/label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Size

The different CheckBox sizes available are default and small. To reduce the size of default CheckBox to small, set the [cssClass](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.CheckBox.html#Syncfusion_EJ2_Buttons_CheckBox_CssClass) property to `e-small`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/check-box/size/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/check-box/size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/check-box/size/size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/CheckBox/CheckBoxUGSample).

## See also

* [CheckBox customization](./how-to/customized-checkbox)