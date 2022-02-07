---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Display Mode of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Display Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Display Options

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



> The default view in the desktop mode is Horizontal.
> The default view in the mobile mode is Vertical.