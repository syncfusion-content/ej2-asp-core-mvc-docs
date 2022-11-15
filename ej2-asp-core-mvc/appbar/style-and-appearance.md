---
layout: post
title: Styles and Appearances in ##Platform_Name## AppBar Control | Syncfusion
description: Check out and learn about Styles and Appearances in ##Platform_Name## AppBar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Style and Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---

# Styles and Appearances in ##Platform_Name## AppBar Control

To modify the AppBar appearance, you need to override the default CSS of the AppBar component. Find the list of CSS classes and their corresponding sections in the AppBar component. Also, you have an option to create your own custom theme for the controls using our [Theme Studio](https://ej2.syncfusion.com/themestudio/?theme=material).

|CSS Class | Purpose of Class |
|-----|----- |
|.e-appbar|To customize the appbar.|
|.e-appbar.e-prominent|To customize the prominent appbar.|
|.e-appbar.e-dense|To customize the dense appbar.|
|.e-appbar.e-light|To customize the light appbar.|
|.e-appbar.e-dark|To customize the dark appbar.|
|.e-appbar.e-primary|To customize the dark appbar.|
|.e-appbar.e-inherit|To customize the inherit appbar.|

>Note: You can change the prominent AppBar height if larger titles, images, or texts are used.

## CssClass

CssClass is used for AppBar customization based on the custom class. In the example below, the AppBar background and color are customized using the CssClass property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/style-and-appearance/cssclass/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CssClass.cs" %}
{% include code-snippet/appbar/style-and-appearance/cssclass/cssclass.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/style-and-appearance/cssclass/razor %}
{% endhighlight %}
{% highlight c# tabtitle="CssClass.cs" %}
{% include code-snippet/appbar/style-and-appearance/cssclass/cssclass.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with CssClass customization](images/cssclass_appbar.png)

## HtmlAttributes

It can be used for additional inline attributes by specifying as inline attributes or by specifying htmlAttributes directive. In the code example below, the aria-label of the AppBar is customized by specifying as attributes.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/style-and-appearance/htmlattributes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HtmlAttributes.cs" %}
{% include code-snippet/appbar/style-and-appearance/htmlattributes/htmlattributes.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/style-and-appearance/htmlattributes/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HtmlAttributes.cs" %}
{% include code-snippet/appbar/style-and-appearance/htmlattributes/htmlattributes.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}