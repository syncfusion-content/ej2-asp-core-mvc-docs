---
layout: post
title: ##Platform_Name## Grid Keyboard Shortcuts | Syncfusion
description: Learn how to perform ##Platform_Name## Data Grid actions using keyboard shortcuts and custom keydown events to streamline navigation and editing.
platform: ej2-asp-core-mvc
control: Perform Grid Actions By Keyboard Short Cut Keys
publishingplatform: ##Platform_Name##
documentation: ug
---


# Keyboard Shortcuts for Grid Actions in ##Platform_Name## Data Grid

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


