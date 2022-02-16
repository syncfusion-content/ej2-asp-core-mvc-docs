---
layout: post
title: Using Tab Inside The Dialog Editing in ##Platform_Name## Grid Component
description: Learn here all about Using Tab Inside The Dialog Editing in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Using Tab Inside The Dialog Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Using Tab Inside the Dialog Editing

You can use [`tab`](../../tab/index.html) component inside dialog edit UI using dialog template feature. The dialog template feature can be enabled by defining [`Mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) property of [`EditSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html) as **Dialog** and [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Template) as SCRIPT element ID or HTML string which holds the template.

The following example demonstrate the usage of tab control inside the dialog template.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/tabediting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/tabediting/dialog.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/tabediting/dialog.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/tabediting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/tabediting/dialog.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/tabediting/dialog.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


