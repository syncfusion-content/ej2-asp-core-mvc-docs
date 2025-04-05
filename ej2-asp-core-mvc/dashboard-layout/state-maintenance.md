---
layout: post
title: State Maintenance in ##Platform_Name## Dashboard Layout control | Syncfusion
description: Learn here all about State Maintenance in Syncfusion ##Platform_Name## Dashboard Layout control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: State Maintenance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Panel state maintenance

The current layout structure of the Dashboard Layout control can be obtained and saved to construct another dashboard with same panel structure using the `serialize` public method of the control. This method returns the control's current panel setting which can be used to construct a dashboard with the same layout settings.

The following sample demonstrates how to save and restore the state of the panels using the serialize method. Click Save to store the panel's settings and click Restore to restore the previously saved panel settings.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/state-maintenance/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/dashboard-layout/state-maintenance/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/state-maintenance/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/dashboard-layout/state-maintenance/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![State maintenance](./images/state_maintenance.PNG)

## State Persistence in Dashboard Layout control

State persistence allows the Dashboard Layout control to retain the panel positions (`row`, `col`), width (`sizeX`), and height (`sizeY`) values in the browser's [localStorage](https://www.w3schools.com/html/html5_webstorage.asp) for state maintenance, even if the browser is refreshed or if you navigate to another page within the browser. This feature is controlled through the `enablePersistence` property, which is set to `false` by default. When set to `true`, the panel positions and sizes of the Dashboard Layout control will be retained even after refreshing the page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/persistence/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="CSHTML.cs" %}
{% include code-snippet/dashboard-layout/persistence/CSHTML.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/persistence/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/dashboard-layout/persistence/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

N> You can refer to our [ASP.NET Core Dashboard Layout](https://www.syncfusion.com/aspnet-core-ui-controls/dashboard-layout) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET Core Dashboard Layout example](https://ej2.syncfusion.com/aspnetcore/DashboardLayout/DefaultFunctionalities#/material) to know how to present and manipulate data.
