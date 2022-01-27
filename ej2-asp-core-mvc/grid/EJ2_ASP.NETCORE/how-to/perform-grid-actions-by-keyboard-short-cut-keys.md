---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Perform Grid Actions By Keyboard Short Cut Keys of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Perform Grid Actions By Keyboard Short Cut Keys
publishingplatform: ##Platform_Name##
documentation: ug
---


# Perform Grid actions by keyboard shortcut keys

Using keyboard shortcuts, Grid performs navigation and actions.

In addition, You can also perform grid actions with custom keyboard shortcuts. This operation has to be achieved outside of the grid with the help of **keydown** event.

The following example demonstrates on **Adding** a new row when **Enter** key is pressed in the grid.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="*" %}
{% include_relative code-snippet/edit/keyboard-actions/*.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="tagHelpers" %}
{% include_relative code-snippet/edit/keyboard-actions/tagHelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="*" %}
{% include_relative code-snippet/edit/keyboard-actions/*.cs %}
{% endhighlight %}
{% highlight razor tabtitle="razor" %}
{% include_relative code-snippet/edit/keyboard-actions/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}


