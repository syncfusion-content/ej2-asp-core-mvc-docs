---
layout: post
title: How to customize scroll step in ##Platform_Name## Toolbar | Syncfusion
description: Customize the Syncfusion ##Platform_Name## Toolbar scrolling distance when clicking the left or right navigation icons by setting the `ScrollStep` property.
platform: ej2-asp-core-mvc
control: How To Customize Toolbar Scroll Step
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to customize scroll step in ##Platform_Name## Toolbar

Toolbar supports to customize the scrolling distance when you click the left and right side navigation icons. we can customize `ScrollStep` property for scrolling distance. Refer to the following code example.

By using Toolbar scrollStep property, pass a required value to customize toolbar scrollStep.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/scrollstep/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Scrollstep.cs" %}
{% include code-snippet/toolbar/how-to/scrollstep/scrollstep.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/toolbar/how-to/scrollstep/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Scrollstep.cs" %}
{% include code-snippet/toolbar/how-to/scrollstep/scrollstep.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

