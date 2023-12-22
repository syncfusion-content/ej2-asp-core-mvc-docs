---
layout: post
title: Methods in Syncfusion ##Platform_Name## Maps Component
description: Learn here all about methods in the Syncfusion ##Platform_Name## Maps component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Maps
publishingplatform: ##Platform_Name##
documentation: ug
---

# Methods in ##Platform_Name## Maps component

## Methods

This section explains the methods used in the Maps component.

## getMinMaxLatitudeLongitude

The `getMinMaxLatitudeLongitude` method returns the minimum and maximum latitude and longitude values of the Maps visible area. This method returns a `IMinMaxLatitudeLongitude` object that contains the Maps minimum and maximum latitude and longitude coordinates.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/maps/methods/getMinMaxLatitudeLongitude/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="GetMinMax.cs" %}
{% include code-snippet/maps/methods/getMinMaxLatitudeLongitude/getMinMaxLatitudeLongitude.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/maps/methods/getMinMaxLatitudeLongitude/razor %}
{% endhighlight %}
{% highlight c# tabtitle="GetMinMax.cs" %}
{% include code-snippet/maps/methods/getMinMaxLatitudeLongitude/getMinMaxLatitudeLongitude.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![getMinMaxLatitudeLongitude method](./images/Methods/getMinMaxLatitudeLongitude-method.PNG)
