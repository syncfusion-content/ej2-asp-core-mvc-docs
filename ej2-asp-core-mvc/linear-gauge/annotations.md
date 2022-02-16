---
layout: post
title: Annotations in ##Platform_Name## Linear Gauge Component
description: Learn here all about Annotations in Syncfusion ##Platform_Name## Linear Gauge component and more.
platform: ej2-asp-core-mvc
control: Annotations
publishingplatform: ##Platform_Name##
documentation: ug
---

# Annotations

<!-- markdownlint-disable MD013 -->

Annotations are used to mark the specific area of interest in the gauge area with texts, shapes or images. You can add any number of annotations to the gauge.

## Annotation

By using the [`content`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~Content.html) property of [`annotation`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation.html) object, you can either specify the id of the element or specify the code to create a new element, that needs to be displayed in the gauge area.

<!-- markdownlint-disable MD036 -->

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/annotations/annotations/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotations.cs" %}
{% include code-snippet/lineargauge/annotations/annotations/annotations.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/annotations/annotations/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotations.cs" %}
{% include code-snippet/lineargauge/annotations/annotations/annotations.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Annotation Customization

You can customize the annotation using following properties.

* [`zIndex`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~ZIndex.html) - When annotation overlaps with another element, you can use this property to bring annotation to the front or back.
* [`horizontalAlignment`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~HorizontalAlignment.html) - To move annotation horizontally. Possible values are "Center", "Far", "Near", "None"
* [`verticalAlignment`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~VerticalAlignment.html) - To move annotation vertically. Possible values are "Center", "Far", "Near", "None"
* [`x`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~X.html) and [`y`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~Y.html) - To move annotation to the specified location.

**Changing the z-order**

You can change the z-order of the annotation element by using the [`zIndex`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~ZIndex.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/annotations/z-order/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Z-order.cs" %}
{% include code-snippet/lineargauge/annotations/z-order/z-order.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/annotations/z-order/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Z-order.cs" %}
{% include code-snippet/lineargauge/annotations/z-order/z-order.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Positioning the Annotation**

You can place the annotation anywhere in gauge area by specifying pixel values to the [`x`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~X.html) and [`y`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~Y.html) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/annotations/animation-position/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation-position.cs" %}
{% include code-snippet/lineargauge/annotations/animation-position/animation-position.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/annotations/animation-position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation-position.cs" %}
{% include code-snippet/lineargauge/annotations/animation-position/animation-position.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD036 -->

**Alignment of Annotation**

You can align the annotation using [`horizontalAlignment`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~HorizontalAlignment.html)and [`verticalAlignment`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeAnnotation~VerticalAlignment.html) properties.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/annotations/animation-alignment/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Animation-alignment.cs" %}
{% include code-snippet/lineargauge/annotations/animation-alignment/animation-alignment.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/annotations/animation-alignment/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Animation-alignment.cs" %}
{% include code-snippet/lineargauge/annotations/animation-alignment/animation-alignment.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multiple Annotations

You can add multiple annotations to the gauge as demonstrated below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/annotations/multiple-annotations/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-annotations.cs" %}
{% include code-snippet/lineargauge/annotations/multiple-annotations/multiple-annotations.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/annotations/multiple-annotations/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Multiple-annotations.cs" %}
{% include code-snippet/lineargauge/annotations/multiple-annotations/multiple-annotations.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

