---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize The Edit Dialog of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customize The Edit Dialog
publishingplatform: ##Platform_Name##
documentation: ug
---


# Customize the Edit Dialog

You can customize the appearance of the edit dialog in the [`actionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_ActionComplete) event based on **requestType** as **beginEdit** or **add**.

In the following example, the dialog's properties like header text, showCloseIcon, height have been changed while editing and adding the records.

Also the locale text for the **Save** and **Cancel** buttons has been changed by overriding the default locale strings.

You can refer the Grid [`Default text`](../global-local/) list for more localization.

{% if page.publishingplatform == "aspnet-core" %}
{% tabs %}
{% highlight %}
{% include_relative code-snippet/edit/customizedialog/customizedialog.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/edit/customizedialog/taghelper %}
{% endhighlight %}
{% elsif page.publishingplatform == "aspnet-mvc" %}
{% highlight %} {% include_relative code-snippet/edit/customizedialog/customizedialog.cs %}
{% endhighlight %}
{% highlight %}
{% include_relative code-snippet/edit/customizedialog/razor %}
{% endhighlight %}
{% endtabs %}


