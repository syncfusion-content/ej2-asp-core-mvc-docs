---
layout: post
title: Right To Left in ##Platform_Name## control
description: Learn here all about Right To Left in Syncfusion ##Platform_Name## control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Right-To-Left support in Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls

The right-to-left (RTL) support can be enabled for Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls by setting `enableRtl` property to `true`. This will render all the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core controls in the right-to-left direction.

## Enable RTL for all controls

You can enable right to left (RTL) for all Syncfusion<sup style="font-size:70%">&reg;</sup> controls used in the application by setting `enableRtl` property to `true` in the script tag. Add the below code snippet in the **_Layout.cshtml** file inside **body** tag.

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}
<script>
    // Enables Right to left alignment for all controls
    ej.base.enableRtl(true);
</script>
{% endhighlight %}
{% endtabs %}

![Grid control is rendered from the right to left](images/rtl-grid.png)

## Enable RTL to individual control

To control a control’s direction individually, you can directly set the control’s `enableRtl` property as true. For illustration, RTL has been enabled for Schedule control in following code snippet.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}
<ejs-schedule id="schedule" height="550px" enableRtl="true"></ejs-schedule>
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="Rtl.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

![Schedule control is rendered from the right-to-left](images/rightToLeft.png)
