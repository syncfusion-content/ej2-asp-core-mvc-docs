---
layout: post
title: Pane Sizing in ##Platform_Name## Splitter Component
description: Learn here all about Pane Sizing in Syncfusion ##Platform_Name## Splitter component and more.
platform: ej2-asp-core-mvc
control: Pane Sizing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Pane sizing

Splitter allows you to provide pane sizes either in pixel or percentage formats.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/panesizing/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/panesizing/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/panesizing/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/panesizing/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Pane Sizing](./images/panesizing.png)

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/panesizing-percentage/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/panesizing-percentage/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/panesizing-percentage/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/panesizing-percentage/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Pane Sizing](./images/panesizing-percentage.png)

## Auto size panes

You can render the split panes without providing the size values. It will split up the sizes automatically.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/layouts/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/layouts/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/layouts/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/layouts/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Auto size panes](./images/layouts.png)

## Fixed pane

You can render the split panes with fixed sizes. Since last pane is a flexible pane, fixed size will not be applied.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/splitter/fixed-pane/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/fixed-pane/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/splitter/fixed-pane/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/splitter/fixed-pane/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Fixed pane](./images/fixed-pane.png)