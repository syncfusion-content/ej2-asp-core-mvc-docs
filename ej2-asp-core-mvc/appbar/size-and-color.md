---
layout: post
title: Size and Color with ##Platform_Name## AppBar Control | Syncfusion
description: Check out and learn about Size and Color with the ##Platform_Name## AppBar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Size and Color
publishingplatform: ##Platform_Name##
documentation: ug
---

# Size and Color with ##Platform_Name## AppBar Control

## Size

The size of the AppBar can be set using the mode property. The available types of the AppBar are as follows:

* Regular AppBar
* Prominent AppBar
* Dense AppBar

### Regular AppBar

This mode is the default one in which the AppBar is displayed with the default height.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/size-and-color/regular/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Regular.cs" %}
{% include code-snippet/appbar/size-and-color/regular/regular.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/size-and-color/regular/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Regular.cs" %}
{% include code-snippet/appbar/size-and-color/regular/regular.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Regular Size](images/regular_appbar.png)

### Prominent AppBar

This height mode can be set to the AppBar by setting `Prominent` to the mode property. The prominent AppBar is displayed with a longer height and can be used for larger titles, images, or texts. It is also longer than the regular AppBar. In the following example, we have customized the prominent text using align-self and white-space CSS properties. You can change the prominent AppBar height if larger titles, images, or texts are used.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/size-and-color/prominent/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Prominent.cs" %}
{% include code-snippet/appbar/size-and-color/prominent/prominent.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/size-and-color/prominent/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Prominent.cs" %}
{% include code-snippet/appbar/size-and-color/prominent/prominent.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Prominent Size](images/prominent_appbar.png)

### Dense AppBar

This height mode can be set to the AppBar by setting `Dense` to the mode property. Dense AppBar is displayed with shorter height which is denser to accommodate all the AppBar content.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/size-and-color/dense/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dense.cs" %}
{% include code-snippet/appbar/size-and-color/dense/dense.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/size-and-color/dense/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dense.cs" %}
{% include code-snippet/appbar/size-and-color/dense/dense.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Dense Size](images/dense_appbar.png)

## Color

The background and font colors can be set using the color mode property. The available types of background color for the AppBar are as follows:

* Light AppBar
* Dark AppBar
* Primary AppBar
* Inherit AppBar

### Light AppBar

This color mode is the default one in which the AppBar can be displayed with a light background and its corresponding font color.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/size-and-color/light/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Light.cs" %}
{% include code-snippet/appbar/size-and-color/light/light.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/size-and-color/light/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Light.cs" %}
{% include code-snippet/appbar/size-and-color/light/light.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Light Color](images/light_appbar.png)

### Dark AppBar

This color mode can be set to the AppBar by setting `Dark` to the property color mode. A dark AppBar can be displayed with a dark background and its corresponding font color.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/size-and-color/dark/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dark.cs" %}
{% include code-snippet/appbar/size-and-color/dark/dark.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/size-and-color/dark/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dark.cs" %}
{% include code-snippet/appbar/size-and-color/dark/dark.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Dark Color](images/dark_appbar.png)

### Primary AppBar

This color mode can be set to the AppBar by setting `Primary` to the property color mode. The primary AppBar can be displayed with primary colors.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/size-and-color/primary/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Primary.cs" %}
{% include code-snippet/appbar/size-and-color/primary/primary.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/size-and-color/primary/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Primary.cs" %}
{% include code-snippet/appbar/size-and-color/primary/primary.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Primary Color](images/primary_appbar.png)

### Inherit AppBar

This color mode can be set to the AppBar by setting `Inherit` to the property color mode. The AppBar inherits the background and font color from its parent element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/appbar/size-and-color/inherit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Inherit.cs" %}
{% include code-snippet/appbar/size-and-color/inherit/inherit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/appbar/size-and-color/inherit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Inherit.cs" %}
{% include code-snippet/appbar/size-and-color/inherit/inherit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![AppBar with Inherit Color](images/inherit_appbar.png)
