---
layout: post
title: States in ##Platform_Name## Progress Bar Component
description: Learn here all about States in Syncfusion ##Platform_Name## Progress Bar component and more.
platform: ej2-asp-core-mvc
control: States
publishingplatform: ##Platform_Name##
documentation: ug
---


# States

Visualize progress in different states.

## Determinate

<!-- markdownlint-disable MD033 -->

This is the default state. You can use it when the progress estimation is known.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/modes/determinate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Determinate.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/modes/determinate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Determinate.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Indeterminate

By enabling the **isIndeterminate** property, the state of the progress bar can be changed to indeterminate when the progress cannot be estimated or is not being calculated. It can be combined with determinate mode to know that the application is estimating progress before the actual progress starts.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/modes/indeterminate/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Indeterminate.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/modes/indeterminate/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Indeterminate.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Buffer

<!-- markdownlint-disable MD033 -->
You can use a secondary progress indicator when the primary progress depends on the secondary progress. This will allow users to visualize both primary and secondary progress simultaneously.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/modes/buffer/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Buffer.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/modes/buffer/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Buffer.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

