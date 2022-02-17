---
layout: post
title: Show Tooltip On Disabled Elements And Disable Tooltip in ##Platform_Name## Tooltip Component
description: Learn here all about Show Tooltip On Disabled Elements And Disable Tooltip in Syncfusion ##Platform_Name## Tooltip component and more.
platform: ej2-asp-core-mvc
control: Show Tooltip On Disabled Elements And Disable Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show Tooltip on disabled elements and disable tooltip

By default, Tooltips will not be displayed on disabled elements. However, it is possible to enable this behavior by following the steps below.

1. Add a disabled element like the `button` element into a div whose display style is set to `inline-block`.
2. Set the pointer event as `none` for the disabled element (button) through CSS.
3. Now, initialize the Tooltip for outer div element that holds the disabled button element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tooltip/tooltip-disabed/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/tooltip/tooltip-disabed/disabled.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tooltip/tooltip-disabed/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/tooltip/tooltip-disabed/disabled.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


