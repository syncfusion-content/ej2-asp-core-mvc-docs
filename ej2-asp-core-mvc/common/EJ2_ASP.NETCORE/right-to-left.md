---
layout: post
title: Right To Left in ##Platform_Name## Component
description: Learn here all about Right To Left in Syncfusion ##Platform_Name## component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Right To Left
publishingplatform: ##Platform_Name##
documentation: ug
---

# Right-To-Left support in Syncfusion ASP.NET Core Components

The right-to-left (RTL) support can be enabled for Syncfusion ASP.NET Core components by setting `enableRtl` property to `true`. This will render all the Syncfusion ASP.NET Core components in the right-to-left direction.

## Enable RTL for all components

You can enable right to left (RTL) for all Syncfusion components used in the application by setting `enableRtl` property to `true` in the script tag. Add the below code snippet in the **_Layout.cshtml** file inside **body** tag.

{% tabs %}
{% highlight c# tabtitle="_Layout.cshtml" %}
<script>
    // Enables Right to left alignment for all controls
    ej.base.enableRtl(true);
</script>
{% endhighlight %}
{% endtabs %}

![Grid component is rendered from the right to left](images/rtl-grid.png)

## Enable RTL to individual component

To control a component’s direction individually you can directly set the component’s `enableRtl` property as true. For illustration, we have enabled RTL for Schedule component in following code snippet.

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

![Schedule component is rendered from the right-to-left](images/rightToLeft.png)
