---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Grid Print of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Grid Print
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add a title to the header when using Grid print function

You can add your title in the header through an [`beforePrint`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Grids.Grid~beforePrint.html) event. With the help of this event you can add your title element as you want.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="titleprint" %}
{% include_relative code-snippet/how-to/titleprint/titleprint.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="tagHelpers" %}
{% include_relative code-snippet/how-to/titleprint/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="titleprint" %}
{% include_relative code-snippet/how-to/titleprint/titleprint.cs %}
{% endhighlight %}
{% highlight razor tabtitle="razor" %}
{% include_relative code-snippet/how-to/titleprint/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

