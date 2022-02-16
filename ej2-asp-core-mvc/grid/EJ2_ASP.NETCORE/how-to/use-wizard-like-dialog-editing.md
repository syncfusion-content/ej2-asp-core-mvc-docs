---
layout: post
title: Use Wizard Like Dialog Editing in ##Platform_Name## Grid Component
description: Learn here all about Use Wizard Like Dialog Editing in Syncfusion ##Platform_Name## Grid component and more.
platform: ej2-asp-core-mvc
control: Use Wizard Like Dialog Editing
publishingplatform: ##Platform_Name##
documentation: ug
---


# Use Wizard like Dialog Editing

Wizard helps you create intuitive step-by-step forms to fill. You can achieve the wizard like editing by using the dialog template feature. It support your own editing template by defining [`mode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Mode) as **Dialog** and [`template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.GridEditSettings.html#Syncfusion_EJ2_Grids_GridEditSettings_Template) as SCRIPT element ID or HTML string which holds the template.

The following example demonstrate the wizard like editing in the grid with the obtrusive Validation.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/wizardediting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/wizardediting/dialog.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/wizardediting/dialog.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/edit/wizardediting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/wizardediting/dialog.cs %}
{% endhighlight %}
{% highlight c# tabtitle="Dialog.cs" %}
{% include code-snippet/grid/edit/wizardediting/dialog.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


