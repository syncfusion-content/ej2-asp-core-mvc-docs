---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Passing Parameter To Server Exporting of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Passing Parameter To Server Exporting
publishingplatform: ##Platform_Name##
documentation: ug
---


# Passing additional parameters to the server when Exporting

You can pass the additional parameter in the [`Query`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_Query) property by invoking **addParams** method. In the [`ToolbarClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ToolbarClick) event, you can define params as key and value pair so it will receive at the server side when exporting.

In the below example, we have passed **recordcount** as **12** using **addParams** method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight c# tabtitle="additional-parameter" %}
{% include_relative code-snippet/how-to/passing-params-exporting/additional-parameter.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="tagHelpers" %}
{% include_relative code-snippet/how-to/passing-params-exporting/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight c# tabtitle="additional-parameter" %}
{% include_relative code-snippet/how-to/passing-params-exporting/additional-parameter.cs %}
{% endhighlight %}
{% highlight razor tabtitle="razor" %}
{% include_relative code-snippet/how-to/passing-params-exporting/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

