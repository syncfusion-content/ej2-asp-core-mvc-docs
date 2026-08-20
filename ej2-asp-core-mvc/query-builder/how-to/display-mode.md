---
layout: post
title: Display Mode in ##Platform_Name## Query Builder | Syncfusion
description: Learn how to display ##Platform_Name## Query Builder in horizontal or vertical layout using the DisplayMode property.
platform: ej2-asp-core-mvc
control: Display Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Display Mode in ##Platform_Name## Query Builder

Display options allow you to view the Query Builder Vertically or Horizontally. For this, you should use the `DisplayMode` property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/query-builder/how-to/display/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/how-to/display/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/query-builder/how-to/display/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/query-builder/how-to/display/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



N> The default view in the desktop mode is Horizontal.
<br/> The default view in the mobile mode is Vertical.