---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize Tab Scroll Step of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customize Tab Scroll Step
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to customize Tab scrollStep

Tab supports to customize the scrolling distance when you click the left and right side navigation icons. we can customize `ScrollStep` property for scrolling distance. Refer to the following code example.

By using Tab scrollStep property, pass a required value to customize tab scrollStep.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/tab/scrollstep/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Styles.cs" %}
{% include code-snippet/tab/scrollstep/styles.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/tab/scrollstep/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Styles.cs" %}
{% include code-snippet/tab/scrollstep/styles.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

