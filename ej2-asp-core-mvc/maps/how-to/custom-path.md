---
layout: post
title: Custom Path in Syncfusion ##Platform_Name## Maps Component
description: Learn here all about Custom Path in Syncfusion ##Platform_Name## Maps component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Custom Path
publishingplatform: ##Platform_Name##
documentation: ug
---

# Custom path map in ##Platform_Name## Maps Component

Maps component can be customized as the desired layout using the custom path map feature. Here, the Maps component has been showcased with normal geometry type shapes to represent the bus seat selection layout.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/custom-path/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-path.cs" %}
{% include code-snippet/maps/custom-path/custom-path.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/custom-path/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Custom-path.cs" %}
{% include code-snippet/maps/custom-path/custom-path.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Note: Refer the data values for custom shapes(https://www.syncfusion.com/downloads/support/directtrac/general/ze/seat902454209) here.

![Custom path map](../images/How-to/custom-path.PNG)