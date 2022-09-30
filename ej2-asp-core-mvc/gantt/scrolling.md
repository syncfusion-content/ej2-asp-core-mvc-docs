---
layout: post
title: Scrolling Feature in Syncfusion ##Platform_Name## Gantt Component
description: Learn here all about Scrolling in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Scrolling
publishingplatform: ##Platform_Name##
documentation: ug
---


# Scrolling in Gantt Control

The scrollbar will be displayed in the gantt when content exceeds the element [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Width) or [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Height). The vertical and horizontal scrollbars will be displayed based on the following criteria:

* The vertical scrollbar appears when the total height of rows present in the gantt exceeds its element height.
* The horizontal scrollbar appears when the sum of columns width exceeds the grid pane size.
* The [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Height) and [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Width) are used to set the gantt height and width, respectively.

> The default value for [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Height) and [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Width) is `auto`.

## Set width and height

To specify the [`width`](../api/gantt/#width) and [`height`](../api/gantt/#height) of the scroller in the pixel, set the pixel value to a number.

The following code example shows how to set height and width in the Gantt control:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/scrolling/width-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Width-height.cs" %}
{% include code-snippet/gantt/scrolling/width-height/width-height.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/scrolling/width-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Width-height.cs" %}
{% include code-snippet/gantt/scrolling/width-height/width-height.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Responsive with the parent container

Specify the [`width`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Width) and [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Height) as `100%` to make the gantt element fill its parent container.
Setting the [`height`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_Height) to `100%` requires the gantt parent element to have explicit height.

The following code example shows how to set height and width in the Gantt control:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/scrolling/responsive/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Responsive.cs" %}
{% include code-snippet/gantt/scrolling/responsive/responsive.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/scrolling/responsive/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Responsive.cs" %}
{% include code-snippet/gantt/scrolling/responsive/responsive.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Scroll To Date method

In the Gantt control, When We use the [`scrollToDate`](https://ej2.syncfusion.com/documentation/api/gantt/#scrolltodate) method, it will scroll the timeline horizontally to the date that we specified in the method's argument.

The following code examples show how the scroll To Date method works in Gantt:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/scrollToDate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="scrollToDate.cs" %}
{% include code-snippet/gantt/how-to/scrollToDate/scrollToDate.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/scrollToDate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="scrollToDate.cs" %}
{% include code-snippet/gantt/how-to/scrollToDate/scrollToDate.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


## Set the vertical scroll position

In the Gantt control, you can set the vertical scroller position dynamically by clicking the custom button using the `setScrollTop` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/setScrollTop/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SetScrollTop.cs" %}
{% include code-snippet/gantt/how-to/setScrollTop/setScrollTop.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/setScrollTop/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SetScrollTop.cs" %}
{% include code-snippet/gantt/how-to/setScrollTop/setScrollTop.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

