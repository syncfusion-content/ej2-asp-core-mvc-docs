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

This section explains different styles and types of the badges.

## Badge styles

The Essential JS 2 Badge has the following predefined styles that can be used with `.e-badge` class to change the appearance of a badge.

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


![Badge Styles](images/badgestyles.PNG)

## Badge types

The types of Essential JS 2 badges are as follows:

* Circle
* Pill
* Link
* Notification
* Overlap
* Dot
* Position

### Circle

The circle badge style can be applied by adding the modifier class `.e-badge-circle` to the target element.

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


![Badge Circle Type](images/circle.PNG)

### Pill

The pill badge style can be applied by adding the modifier class `.e-badge-pill` to the target element.

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


![Badge Pill Type](images/pill.PNG)

### Link

When badge modifier classes are applied to the anchor tag, the badge’s appearance will change from normal state to hover state on mouseover.

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


![Badge Link Type](images/link.PNG)

### Notification

The notification badge style can be applied by adding the modifier class `.e-badge-notification` to the target element. Notification badges are used when a content or a context needs special attention. While using the notification badge, set the parent element to `position: relative`.

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


![Badge Notification Type](images/notification.PNG)

### Dot

Dot can be applied by adding the modifier class `.e-badge-dot` to the target element. Dot badges are similar to notification badges, but in a minimalistic way. While using the dot badge, set the parent element to `position: relative`.

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


![Badge Dot Type](images/dot.PNG)

### Overlap

The overlap badge can be used with `notification` or `dot` badge, which overlaps with the target element by adding the modifier class`.e-badge-overlap`. While using the overlap badge, set the parent element to `position: relative`.

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


![Badge Overlap Type](images/overlap.PNG)

### Position

The default position of the `notification` or `dot` badge is top. But, the position can be changed to `bottom` using the modifier class `.e-badge-bottom`. For example, the bottom class modifier is used with dot badge to display the status in the avatar as shown in the following sample.

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

![Badge Position Type](images/position.PNG)

N> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/Badge/BadgeTypesSample).