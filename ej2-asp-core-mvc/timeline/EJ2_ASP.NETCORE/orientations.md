---
layout: post
title: Orientations in ##Platform_Name## Timeline | Syncfusion
description: Display Syncfusion ##Platform_Name## Timeline items in horizontal or vertical direction by setting the `orientation` property.
platform: ej2-asp-core-mvc
control: Orientations
publishingplatform: ##Platform_Name##
documentation: ug
---

# Orientations in ##Platform_Name## Timeline

The Timeline control supports the display of items in both horizontal and vertical direction by using the [orientation](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Timeline.html#Syncfusion_EJ2_Layouts_Timeline_Orientation) property.

## Vertical

You can display the items one below the other vertically by setting the [orientation](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Timeline.html#Syncfusion_EJ2_Layouts_Timeline_Orientation) property to `Vertical`. By default, the items are displayed in vertical orientation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/orientations/vertical/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/orientations/vertical/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/orientations/vertical/vertical.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Vertical](images/vertical.png)

## Horizontal

In horizontal orientation, the items are displayed in a side-by-side manner by setting the [orientation](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Layouts.Timeline.html#Syncfusion_EJ2_Layouts_Timeline_Orientation) property to `Horizontal`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/orientations/horizontal/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/orientations/horizontal/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/orientations/horizontal/horizontal.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Horizontal](images/horizontal.png)
