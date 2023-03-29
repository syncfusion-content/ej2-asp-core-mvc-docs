---
layout: post
title: Tooltip in ##Platform_Name## Progress Bar Component
description: Learn here all about Tooltip in Syncfusion ##Platform_Name## Progress Bar component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---


# Tooltip

The tooltip for the progress bar is used to represent the progress value. During the initial load, it can be enabled by using the [`Enable`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ProgressBar.ProgressBarTooltipSettings.html#Syncfusion_EJ2_ProgressBar_ProgressBarTooltipSettings_Enable) property. The [`ShowTooltipOnHover`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ProgressBar.ProgressBarTooltipSettings.html#Syncfusion_EJ2_ProgressBar_ProgressBarTooltipSettings_ShowTooltipOnHover) property can show the tooltip on mouseover.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/types/tooltip1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/types/tooltip1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Tooltip.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Format

By default, the tooltip shows information about progress. In addition to that, show more information in the tooltip using the [`Format`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ProgressBar.ProgressBarTooltipSettings.html#Syncfusion_EJ2_ProgressBar_ProgressBarTooltipSettings_Format) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/types/tooltip2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/types/tooltip2/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Format.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Customization

The [`Fill`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ProgressBar.ProgressBarTooltipSettings.html#Syncfusion_EJ2_ProgressBar_ProgressBarTooltipSettings_Fill) and [`Border`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ProgressBar.ProgressBarTooltipSettings.html#Syncfusion_EJ2_ProgressBar_ProgressBarTooltipSettings_Border) properties are used to customize the background color and border of the tooltip respectively. The [`TextStyle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.ProgressBar.ProgressBarTooltipSettings.html#Syncfusion_EJ2_ProgressBar_ProgressBarTooltipSettings_TextStyle) property in the tooltip is used to customize the font of the tooltip text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/types/tooltip3/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/types/tooltip3/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Customization.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}