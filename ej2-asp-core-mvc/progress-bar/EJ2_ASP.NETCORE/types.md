---
layout: post
title: Types in ##Platform_Name## Progress Bar Component
description: Learn here all about Types in Syncfusion ##Platform_Name## Progress Bar component and more.
platform: ej2-asp-core-mvc
control: Types
publishingplatform: ##Platform_Name##
documentation: ug
---


# Types

Visualize progress in different shapes (rectangle, circle, and semi-circle) to give a unique appearance to your app design.

## Linear

<!-- markdownlint-disable MD033 -->

Set **type** to Linear to get the linear progress bar. It also support secondary progress and different mode of progress.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/types/linear/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Linear.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/types/linear/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Linear.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Circular

Set **type** to Circular to get the circular progress bar. It also support secondary progress and different mode of progress.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/types/circular/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Circular.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/types/circular/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Circular.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

