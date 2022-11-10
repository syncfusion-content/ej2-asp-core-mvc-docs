---
layout: post
title: Positioning in ##Platform_Name## AppBar Control | Syncfusion
description: Check out and learn about Positioning in the ##Platform_Name## AppBar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Position
publishingplatform: ##Platform_Name##
documentation: ug
---

# Positioning in ##Platform_Name## AppBar Control

The position of the AppBar can be set using the position and sticky property. The AppBar provides the following options for setting its position:

* Top AppBar
* Bottom AppBar
* Sticky AppBar

### Top AppBar

The top AppBar is the default one in which it positions the AppBar at the top of the content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/position/top/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Top.cs" %}
{% include code-snippet/appbar/position/top/top.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/position/top/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Top.cs" %}
{% include code-snippet/appbar/position/top/top.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Top Position](images/top_appbar.png)

### Bottom AppBar

This position can be set to the AppBar by setting `Bottom` to the position property. The bottom AppBar positions the AppBar at the bottom of the content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/position/bottom/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Bottom.cs" %}
{% include code-snippet/appbar/position/bottom/bottom.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/position/bottom/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Bottom.cs" %}
{% include code-snippet/appbar/position/bottom/bottom.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Bottom Position](images/bottom_appbar.png)

### Sticky AppBar

This position can be set to the AppBar by setting `true` to the sticky property. AppBar will be sticky while scrolling the AppBar content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/position/sticky/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Sticky.cs" %}
{% include code-snippet/appbar/position/sticky/sticky.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/position/sticky/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Sticky.cs" %}
{% include code-snippet/appbar/position/sticky/sticky.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Sticky Position](images/sticky_appbar.png)