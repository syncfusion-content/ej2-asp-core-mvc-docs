---
layout: post
title: Marker Type in ##Platform_Name## Maps Component
description: Learn here all about Marker Type in Syncfusion ##Platform_Name## Maps component and more.
platform: ej2-asp-core-mvc
control: Marker Type
publishingplatform: ##Platform_Name##
documentation: ug
---

# Marker types

## Add different types of markers

Different marker objects can be added to the Maps component using the marker settings. To update different marker settings in Maps, please follow the given steps.

**Step 1**:

Initialize the Maps control with marker settings. Here, a marker has been added with specified latitude and longitude of California by using the `DataSource` property. To customize the shape of the marker using the `Shape` property and change the border color and width of the marker using the `Border` property as mentioned in the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/marker-type/marker1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker1.cs" %}
{% include code-snippet/maps/marker-type/marker1/marker1.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/marker-type/marker1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker1.cs" %}
{% include code-snippet/maps/marker-type/marker1/marker1.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Marker type](../images/How-to/marker.PNG)

**Step 2**:

Customize the above option for n number of markers as mentioned in the following example.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/marker-type/marker2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Marker2.cs" %}
{% include code-snippet/maps/marker-type/marker2/marker2.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/marker-type/marker2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Marker2.cs" %}
{% include code-snippet/maps/marker-type/marker2/marker2.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![Marker type](../images/How-to/marker-type.PNG)