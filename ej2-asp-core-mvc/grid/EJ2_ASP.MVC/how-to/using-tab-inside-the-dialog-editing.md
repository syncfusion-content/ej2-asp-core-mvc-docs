---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Using Tab Inside The Dialog Editing of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Using Tab Inside The Dialog Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Using Tab Inside the Dialog Editing

You can use [`tab`](../../../tab/index.html) component inside dialog edit UI using dialog template feature. The dialog template feature can be enabled by defining [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) property of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **Dialog** and [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Template) as SCRIPT element ID or HTML string which holds the template.

The following example demonstrate the usage of tab control inside the dialog template.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight c# tabtitle="*" %}
{% include_relative code-snippet/edit/tabediting/*.cs %}
{% endhighlight %}
{% highlight cshtml tabtitle="tagHelpers" %}
{% include_relative code-snippet/edit/tabediting/tagHelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight c# tabtitle="*" %}
{% include_relative code-snippet/edit/tabediting/*.cs %}
{% endhighlight %}
{% highlight razor tabtitle="razor" %}
{% include_relative code-snippet/edit/tabediting/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}


