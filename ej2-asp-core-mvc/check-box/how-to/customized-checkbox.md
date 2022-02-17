---
layout: post
title: Customized Checkbox in ##Platform_Name## Check Box Component
description: Learn here all about Customized Checkbox in Syncfusion ##Platform_Name## Check Box component and more.
platform: ej2-asp-core-mvc
control: Customized Checkbox
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customized CheckBox

## Customize CheckBox Appearance

You can customize the appearance of the CheckBox component using the CSS rules.
Define own CSS rules according to your requirement and assign the class name to the
[`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.CheckBox.html#Syncfusion_EJ2_Buttons_CheckBox_CssClass) property.

The background and border color of the CheckBox is customized through the custom classes to create primary, success, warning, and danger info type of checkbox.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/check-box/howto/custom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/check-box/howto/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/check-box/howto/custom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom.cs" %}
{% include code-snippet/check-box/howto/custom/custom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Customize width and height

The height and width of the CheckBox component can be customized by setting `height` and `width` property.

The following section explains about how to customize the height and width of the CheckBox component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/check-box/howto/custom-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customheight.cs" %}
{% include code-snippet/check-box/howto/custom-height/customheight.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/check-box/howto/custom-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customheight.cs" %}
{% include code-snippet/check-box/howto/custom-height/customheight.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom Frame

CheckBox frame can be customized as per the requirement by adding CSS rules.

In the following example, to-do list is displayed with round checkbox by changing
`border-radius` as `100%` by adding `e-custom` class.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/check-box/howto/custom-size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customsize.cs" %}
{% include code-snippet/check-box/howto/custom-size/customsize.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/check-box/howto/custom-size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customsize.cs" %}
{% include code-snippet/check-box/howto/custom-size/customsize.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Custom Check Icon

CheckBox check icon can be customized as per the requirement by adding CSS rules.

In the following example, the check icon can be customized by changing check icon content, background and
border color in focus and hovered states by adding `e-checkicon` class.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/check-box/howto/custom-icon/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customicon.cs" %}
{% include code-snippet/check-box/howto/custom-icon/customicon.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/check-box/howto/custom-icon/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customicon.cs" %}
{% include code-snippet/check-box/howto/custom-icon/customicon.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

