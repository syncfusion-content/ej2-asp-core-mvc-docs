---
layout: post
title: Perform Grid Actions By Keyboard Short Cut Keys in ##Platform_Name## Grid Component
description: Learn here all about Perform Grid Actions By Keyboard Short Cut Keys in Syncfusion ##Platform_Name## Grid component and more.
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
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/keyboard-actions/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Keys.cs" %}
{% include code-snippet/grid/edit/keyboard-actions/keys.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Keys.cs" %}
{% include code-snippet/grid/edit/keyboard-actions/keys.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/keyboard-actions/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Keys.cs" %}
{% include code-snippet/grid/edit/keyboard-actions/keys.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Keys.cs" %}
{% include code-snippet/grid/edit/keyboard-actions/keys.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


