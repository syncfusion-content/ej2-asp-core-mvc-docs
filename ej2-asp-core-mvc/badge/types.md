---
layout: post
title: Types in ##Platform_Name## Badge Control | Syncfusion
description: Learn here all about types in Syncfusion ##Platform_Name## Badge control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Types
publishingplatform: ##Platform_Name##
documentation: ug
---

# Types in ##Platform_Name## Badge Control

This section explains different styles and types of the Badges.

## Badge styles

The Essential<sup style="font-size:70%">&reg;</sup> JS 2 Badge has the following predefined styles that can be used with `.e-badge` class to change the appearance of a Badge.

| Class Name | Description |
|------------|-------------|
| e-badge-primary   | Represents a primary notification. |
| e-badge-secondary | Represents a secondary notification. |
| e-badge-success   | Represents a positive notification. |
| e-badge-danger    | Represents a negative notification. |
| e-badge-warning   | Represents notification with caution. |
| e-badge-info      | Represents an informative notification. |
| e-badge-light     | Represents notification in light variant. |
| e-badge-dark      | Represents notification in dark variant. |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/types/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/types/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/types/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Badge Styles](images/badgestyles.png)

## Badge types

The types of Essential<sup style="font-size:70%">&reg;</sup> JS 2 Badges are as follows:

* Circle
* Pill
* Link
* Notification
* Overlap
* Dot
* Position

### Circle

The circle Badge style can be applied by adding the modifier class `.e-badge-circle` to the target element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/circle/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/circle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/circle/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Badge Circle Type](images/circle.png)

### Pill

The pill Badge style can be applied by adding the modifier class `.e-badge-pill` to the target element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/pill/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/pill/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/pill/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Badge Pill Type](images/pill.png)

### Link

When Badge modifier classes are applied to the anchor tag, the Badge’s appearance will change from normal state to hover state on mouseover.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/link/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/link/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/link/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Badge Link Type](images/link.png)

### Notification

The notification Badge style can be applied by adding the modifier class `.e-badge-notification` to the target element. Notification Badges are used when a content or a context needs special attention. While using the notification Badge, set the parent element to `position: relative`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/notification/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/notification/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/notification/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Badge Notification Type](images/notification.png)

### Dot

Dot can be applied by adding the modifier class `.e-badge-dot` to the target element. Dot Badges are similar to notification Badges, but in a minimalistic way. While using the dot Badge, set the parent element to `position: relative`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/dot/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/dot/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/dot/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Badge Dot Type](images/dot.png)

### Overlap

The overlap Badge can be used with `notification` or `dot` Badge, which overlaps with the target element by adding the modifier class`.e-badge-overlap`. While using the overlap Badge, set the parent element to `position: relative`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/overlap/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/overlap/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/overlap/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


![Badge Overlap Type](images/overlap.png)

### Position

The default position of the `notification` or `dot` Badge is top. But, the position can be changed to `bottom` using the modifier class `.e-badge-bottom`. For example, the bottom class modifier is used with dot Badge to display the status in the avatar as shown in the following sample.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/badge/position/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/badge/position/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/badge/position/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Badge Position Type](images/position.png)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Badge/BadgeTypesSample).