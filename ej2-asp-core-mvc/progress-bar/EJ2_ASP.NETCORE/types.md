---
layout: post
title: Types in ##Platform_Name## Progress Bar Control | Syncfusion
description: Learn here all about Types in Syncfusion ##Platform_Name## Progress Bar control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Types
publishingplatform: ##Platform_Name##
documentation: ug
---

# Progress Bar types in ##Platform_Name## ProgressBar Control

Change the type of the Progress Bar by setting the `type` attribute on the `<ejs-progressbar>` tag helper. The default is `Linear`; the supported values are `Linear` and `Circular`.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/getting-started/default/tagHelper %}
{% endhighlight %}
{% endtabs %}

![ASP.NET Core Progress Bar Control](images/default.png)

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-Getting-Started-Examples/tree/main/ProgressBar/ASP.NET%20Core%20Tag%20Helper%20Examples).

## Linear

<!-- markdownlint-disable MD033 -->

Set **type** to Linear to get the linear progress bar. It also support secondary progress and different mode of progress.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/types/linear/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/types/linear/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Circular

Set **type** to Circular to get the circular progress bar. It also support secondary progress and different mode of progress.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/types/circular/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/types/circular/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

