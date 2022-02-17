---
layout: post
title: Annotation in ##Platform_Name## Progress Bar Component
description: Learn here all about Annotation in Syncfusion ##Platform_Name## Progress Bar component and more.
platform: ej2-asp-core-mvc
control: Annotation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Annotation and Label

## Annotation

In the circular progress bar, you can add any view to the center using the **Content** property in annotation.

For example, you can include add, start, or pause button to control the progress. You can also add an image that indicates the actual task in progress or add custom text that conveys how far the task is completed.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/annotation/annotation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/annotation/annotation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Annotation.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}



## Label

You can show the progress value in both linear and cicular progress bar using **ShowProgressValue** property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/annotation/label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/progress-bar/annotation/label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

