---
layout: post
title: Show Buttongroup Selected State On Initial Render in ##Platform_Name## Button Group Component
description: Learn here all about Show Buttongroup Selected State On Initial Render in Syncfusion ##Platform_Name## Button Group component and more.
platform: ej2-asp-core-mvc
control: Show Buttongroup Selected State On Initial Render
publishingplatform: ##Platform_Name##
documentation: ug
---


# Show ButtonGroup selected state on initial render

To show selected state on initial render, `checked` property should to added to the corresponding
input element.

The following example illustrates how to show selected state on initial render.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/select/demo/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/select/demo/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/button-group/select/demo/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/button-group/select/demo/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

