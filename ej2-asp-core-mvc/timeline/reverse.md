---
layout: post
title: Reverse in ##Platform_Name## Timeline Control | Syncfusion
description: Checkout and learn about Reverse in Syncfusion ##Platform_Name## Timeline control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Reverse
publishingplatform: ##Platform_Name##
documentation: ug
---

# Reverse in ##Platform_Name## Timeline control

You can display the Timeline items in reverse order, for different alignments by using the `reverse` property which provides adaptability and improves user interaction.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/timeline/reverse/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/reverse/reverse.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/timeline/reverse/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Separator.cs" %}
{% include code-snippet/timeline/reverse/reverse.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Reverse](images/reverse.png)
