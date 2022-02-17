---
layout: post
title: Grid Print in ##Platform_Name## Grid Component
description: Learn here all about Grid Print in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Grid Print
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add a title to the header when using Grid print function

You can add your title in the header through an [`beforePrint`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Grids.Grid~beforePrint.html) event. With the help of this event you can add your title element as you want.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/titleprint/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Titleprint.cs" %}
{% include code-snippet/grid/how-to/titleprint/titleprint.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/titleprint/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Titleprint.cs" %}
{% include code-snippet/grid/how-to/titleprint/titleprint.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

