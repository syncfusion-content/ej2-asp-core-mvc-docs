---
layout: post
title: Focus in ##Platform_Name## Grid Component
description: Learn here all about Focus in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Focus
publishingplatform: ##Platform_Name##
documentation: ug
---


# Focus the double clicked column in the edit form

You can focus the double clicked column edit form an through an [`recordDoubleClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Grids.Grid~recordDoubleClick.html) event. With the help of this event you can focus the double clicked column in inline edit mode.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/focus/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Focus.cs" %}
{% include code-snippet/grid/how-to/focus/focus.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/focus/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Focus.cs" %}
{% include code-snippet/grid/how-to/focus/focus.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

