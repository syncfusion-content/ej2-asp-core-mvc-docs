---
layout: post
title: Gauge User Interaction in ##Platform_Name## Circular Gauge Component
description: Learn here all about Gauge User Interaction in Syncfusion ##Platform_Name## Circular Gauge component and more.
platform: ej2-asp-core-mvc
control: Gauge User Interaction
publishingplatform: ##Platform_Name##
documentation: ug
---

# User Interaction

## Tooltip for pointers

Circular gauge will displays the pointer details through [tooltip](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTooltipSettings.html),
when the mouse is moved over the pointer.

<!-- markdownlint-disable MD036 -->

**Enable Tooltip**

By default, tooltip is not visible. Enable the tooltip by setting
[`enable`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTooltipSettings.html#Syncfusion_EJ2_CircularGauge_CircularGaugeTooltipSettings_Enable) property to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-user-interaction/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/circulargauge/gauge-user-interaction/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-user-interaction/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/circulargauge/gauge-user-interaction/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Template**

Any HTML elements can be displayed in the tooltip by using the
[`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGaugeTooltipSettings.html#Syncfusion_EJ2_CircularGauge_CircularGaugeTooltipSettings_Template) property of the tooltip.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-user-interaction/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/circulargauge/gauge-user-interaction/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-user-interaction/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/circulargauge/gauge-user-interaction/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Tooltip for ranges

Circular gauge displays the information about the ranges through tooltip when hovering the mouse over the ranges. You can enable this feature by setting the type property of tooltip to ‘Range’ in the array collection.

**Tooltip customization for ranges**

To customize the range tooltip, use the `rangeSettings` property in tooltip. The following options are available to customize the range tooltip:

* `fill` - Specifies the range tooltip fill color.
* `textStyle` - Specifies the range tooltip text style.
* `format` - Specifies the range content format.
* `template` - Specifies the custom template for tooltip.
* `enableAnimation` - Animates as it moves from one point to another.
* `border` - Specifies the tooltip border.
* `showMouseAtPosition` - Displays the position of the tooltip on the cursor position.

## Tooltip for annotations

Circular gauge displays the information about the annotations through tooltip when hovering the mouse over the annotation. You can enable this feature by setting the type property of tooltip to ‘Annotation’ in the array collection.

**Tooltip customization for annotations**

To customize the annotation tooltip, use the `annotationSettings` property in tooltip. The following options are available to customize the annotation tooltip:

* `fill` - Specifies the annotation tooltip fill color.
* `textStyle` - Specifies the annotation tooltip text style.
* `format` - Specifies the annotation content format.
* `template` - Specifies the tooltip content with custom template.
* `enableAnimation` - Animates as it moves from one point to another.
* `border` - Specifies the tooltip border.

The following code example shows the tooltip for the pointers, ranges and annotations.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-user-interaction/range-annotation-tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Range-annotation-tooltip.cs" %}
{% include code-snippet/circulargauge/gauge-user-interaction/range-annotation-tooltip/range-annotation-tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-user-interaction/range-annotation-tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Range-annotation-tooltip.cs" %}
{% include code-snippet/circulargauge/gauge-user-interaction/range-annotation-tooltip/range-annotation-tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Pointer Drag

Pointers can be dragged over the axis value. This can be achieved by clicking and dragging the pointer. To enable or disable the pointer drag, you can use
[`enablePointerDrag`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.CircularGauge.CircularGauge.html#Syncfusion_EJ2_CircularGauge_CircularGauge_EnablePointerDrag) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-user-interaction/pointer-drag/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pointer-drag.cs" %}
{% include code-snippet/circulargauge/gauge-user-interaction/pointer-drag/pointer-drag.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/circulargauge/gauge-user-interaction/pointer-drag/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pointer-drag.cs" %}
{% include code-snippet/circulargauge/gauge-user-interaction/pointer-drag/pointer-drag.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

