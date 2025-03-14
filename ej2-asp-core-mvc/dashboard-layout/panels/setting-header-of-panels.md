---
layout: post
title: Setting Header Of Panels in ##Platform_Name## Dashboard Layout control
description: Learn here all about Setting Header of Panels in Syncfusion ##Platform_Name## Dashboard Layout control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Setting Header Of Panels
publishingplatform: ##Platform_Name##
documentation: ug
---


# Header and content of panels

The Dashboard Layout control is mostly used to represent the data used for monitoring or managing a process. These data or any HTML template can be placed as the [`content`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Layouts.DashboardLayoutPanel~Content.html) of a panel using the content property. Also, word or phrase that summarize the panel’s content can be added as the header on the top of each panel using the [`header`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Layouts.DashboardLayoutPanel~Header.html) property of the panel.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/content-panel/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
{% include code-snippet/dashboard-layout/content-panel/CSHTML.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/content-panel/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/dashboard-layout/content-panel/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Header and content of panels](./../images/content_panel.PNG)

## Placing components as content

In a dashboard, controls like charts, grids, maps, gauges, and more can be used to present complex data. Such controls can be placed as the panel content by assigning the corresponding control element as the `content template` of the panel.

N> You must assign the empty div element inside the content template to add the control as content and also define the .e-panel, .e-panel-container, .e-panel-header, and .e-panel-content classes while rendering the DashboardLayout control using content template.

The following sample demonstrates how to add ej2-chart controls as the [`content`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Layouts.DashboardLayoutPanel~Content.html) for each panel in the DashboardLayout control.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/placing-content/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
{% include code-snippet/dashboard-layout/placing-content/CSHTML.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/placing-content/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/dashboard-layout/placing-content/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Placing components as content](./../images/dragging_handler.PNG)

N> You can refer to our [ASP.NET Core Dashboard Layout](https://www.syncfusion.com/aspnet-core-ui-controls/dashboard-layout) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET Core Dashboard Layout example](https://ej2.syncfusion.com/aspnetcore/DashboardLayout/DefaultFunctionalities#/material) to knows how to present and manipulate data.