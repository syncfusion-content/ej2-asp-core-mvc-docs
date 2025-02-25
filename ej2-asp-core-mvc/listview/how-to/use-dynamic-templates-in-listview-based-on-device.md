---
layout: post
title: Use Dynamic Templates In ListView Based On Device in ##Platform_Name## ListView Control | Syncfusion
description: Learn here all about Use Dynamic Templates In ListView Based On Device in Syncfusion ##Platform_Name## ListView control of syncfusion and more.
platform: ej2-asp-core-mvc
control: Use Dynamic Templates In ListView Based On Device
publishingplatform: ##Platform_Name##
documentation: ug
---

# Use Dynamic templates in ListView based on device

The Syncfusion<sup style="font-size:70%">&reg;</sup> Essential<sup style="font-size:70%">&reg;</sup> JS2 controls are desktop and mobile-friendly. So, you can use Syncfusion<sup style="font-size:70%">&reg;</sup> controls in both modes. The control templates are not always fixed. Applications may need to load various templates depending upon the device.

## Integration

In the ListView control, template support is being used. In some cases, the control wrapper is always responsive across all devices, but the template contents are dynamically changed with unspecified (sample side) dimensions. CSS customization is also needed in sample-side to align template content responsively in both mobile and desktop modes. Here, two templates have been loaded for mobile and desktop modes. To check the device mode, a `browser module` has been imported from the [ej2-base](https://ej2.syncfusion.com/documentation/api/base/overview/) package.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/listview/dynamic-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/dynamic-template/list.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/listview/dynamic-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="List.cs" %}
{% include code-snippet/listview/dynamic-template/list.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ListView - Dynamic Template](../images/dynamic-template.png)