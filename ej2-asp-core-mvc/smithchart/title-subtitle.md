---
layout: post
title: Title Subtitle in ##Platform_Name## Smithchart Component
description: Learn here all about Title Subtitle in Syncfusion ##Platform_Name## Smithchart component and more.
platform: ej2-asp-core-mvc
control: Title Subtitle
publishingplatform: ##Platform_Name##
documentation: ug
---


# Title and Subtitle

## Enable title

Title and subtitle is used to depicts the information about the data plotted in the smithchart. You can set the title and subtitle of the smithchart using the [`text`] property in title and subtitle. By default visibility of the title as well as subtitle is enabled. You need to set simply text for title and subtitle in your sample as like below.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/title/title/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/smithchart/title/title/title.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/smithchart/title/title/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title.cs" %}
{% include code-snippet/smithchart/title/title/title.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Title trim

Both title and subtitle of the smithchart can be trimmed if it exceeds the certain length. Trimming is enabled using [`enableTrim`] for title as well as subtitle. This length can be changed using the property [`maximumWidth`]. Also [`font`], [`textAlignment`] and [`visibility`] can be customized for title as well as subtitle.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/smithchart/title/title-trim/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Title-trim.cs" %}
{% include code-snippet/smithchart/title/title-trim/title-trim.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/smithchart/title/title-trim/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Title-trim.cs" %}
{% include code-snippet/smithchart/title/title-trim/title-trim.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

