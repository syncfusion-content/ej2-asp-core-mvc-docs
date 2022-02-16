---
layout: post
title: Use Dynamic Templates In Listview Based On Device in ##Platform_Name## Listview Component
description: Learn here all about Use Dynamic Templates In Listview Based On Device in Syncfusion ##Platform_Name## Listview component and more.
platform: ej2-asp-core-mvc
control: Use Dynamic Templates In Listview Based On Device
publishingplatform: ##Platform_Name##
documentation: ug
---

# Use Dynamic templates in ListView based on device

The Syncfusion Essential JS2 components are desktop and mobile-friendly. So, you can use Syncfusion components in
both modes. The component templates are not always fixed. Applications may need to load various templates depending
upon the device.

## Integration

In the ListView component, template support is being used. In some cases, the component wrapper is always responsive
across all devices, but the template contents are dynamically changed with unspecified (sample side) dimensions. CSS
customization is also needed in sample-side to align template content responsively in both mobile and desktop modes. Here,
two templates have been loaded for mobile and desktop modes. To check the device mode, a
`browser module` has been imported from
the [ej2-base](https://ej2.syncfusion.com/documentation/api/base/overview/) package.

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

