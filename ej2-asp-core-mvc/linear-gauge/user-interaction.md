---
layout: post
title: User Interaction in ##Platform_Name## Linear Gauge Component
description: Learn here all about User Interaction in Syncfusion ##Platform_Name## Linear Gauge component and more.
platform: ej2-asp-core-mvc
control: User Interaction
publishingplatform: ##Platform_Name##
documentation: ug
---

# User Interaction

## Tooltip

<!-- markdownlint-disable MD036 -->

Linear gauge will display the details about the pointer value through [tooltip](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html), when the mouse is moved over the pointer. By default, tooltip will not be visible and you can enable the tooltip by setting [`enable`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings~Enable.html) property to true.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/user-interactions/tooltip/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/lineargauge/user-interactions/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/user-interactions/tooltip/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% include code-snippet/lineargauge/user-interactions/tooltip/tooltip.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



<!-- markdownlint-disable MD013 -->

**Format the Tooltip**

<!-- markdownlint-disable MD013 -->

By default, tooltip will show the pointer value only. In addition to that, you can show more information in tooltip. For example, the format `${value}` shows pointer value with currency symbol.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/user-interactions/tooltip-format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-format.cs" %}
{% include code-snippet/lineargauge/user-interactions/tooltip-format/tooltip-format.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/user-interactions/tooltip-format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-format.cs" %}
{% include code-snippet/lineargauge/user-interactions/tooltip-format/tooltip-format.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Tooltip Template**

Any HTML elements can be displayed in the tooltip by using the [`template`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings~Template.html) property of the tooltip. You can use the {value} as placeholders in the HTML element to display the pointer values of the corresponding axis.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/user-interactions/tooltip-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-template.cs" %}
{% include code-snippet/lineargauge/user-interactions/tooltip-template/tooltip-template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/user-interactions/tooltip-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-template.cs" %}
{% include code-snippet/lineargauge/user-interactions/tooltip-template/tooltip-template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



**Customize the Appearance of Tooltip**

* [`fill`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings~Fill.html) - Specifies fill color for tooltip
* [`border`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings~Border.html) - Specifies tooltip border width and color
* [`textStyle`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings~TextStyle.html) - Specifies the tooltip text style, such as color, font family, font style and font weight

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/user-interactions/tooltip-appearance/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-appearance.cs" %}
{% include code-snippet/lineargauge/user-interactions/tooltip-appearance/tooltip-appearance.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/user-interactions/tooltip-appearance/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip-appearance.cs" %}
{% include code-snippet/lineargauge/user-interactions/tooltip-appearance/tooltip-appearance.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Pointer Drag

You can drag and drop either marker or bar pointer over the desired axis value using [`enableDrag`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~EnableDrag.html) property in the [`pointer`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer.html).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/user-interactions/pointer-drag/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Pointer-drag.cs" %}
{% include code-snippet/lineargauge/user-interactions/pointer-drag/pointer-drag.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/lineargauge/user-interactions/pointer-drag/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Pointer-drag.cs" %}
{% include code-snippet/lineargauge/user-interactions/pointer-drag/pointer-drag.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

