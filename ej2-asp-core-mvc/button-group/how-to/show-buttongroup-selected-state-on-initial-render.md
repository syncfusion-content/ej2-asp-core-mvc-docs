---
layout: post
title: Buttongroup Selection in ##Platform_Name## Button Group | Syncfusion
description: Learn here all about Show Buttongroup selected state on Initial Render in Syncfusion ##Platform_Name## Button Group control of syncfusion and more.
platform: ej2-asp-core-mvc
control: Show Buttongroup Selected State On Initial Render
publishingplatform: ##Platform_Name##
documentation: ug
---


# Show ButtonGroup selected state on initial render

To show selected state on initial render, `checked` property should be added to the corresponding input element.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/button-group/select/demo/tagHelper %}
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

> [View Sample in GitHub](https://github.com/SyncfusionExamples/ASP-NET-Core-UG-Examples/tree/main/ButtonGroup/ButtonGroupHowToSample).