---
layout: post
title: Moving Panels in ##Platform_Name## Dashboard Layout Component
description: Learn here all about Moving Panels in Syncfusion ##Platform_Name## Dashboard Layout component and more.
platform: ej2-asp-core-mvc
control: Moving Panels
publishingplatform: ##Platform_Name##
documentation: ug
---


# Moving of panels programatically

Other than drag and drop, it is possible to move the panels in Dashboard Layout programatically. This can be achieved using `movePanel` method. The method is invoked as follows,

```js
movePanel(id, row, col)

```

Where,
* id - ID of the panel which needs to be moved.
* row - New row position for moving the panel.
* col - New column position for moving the panel.

Each time a panel's position is changed(Programatically or through UI interaction), the Dashboard Layout's [`change`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Layouts.DashboardLayout~Change.html) event will be triggered.

The following sample demonstrates moving a panel programatically to a new position in the Dashboard Layout's [created](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Layouts.DashboardLayout~Created.html) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/moving/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/dashboard-layout/moving/HomeController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dashboard-layout/moving/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
{% include code-snippet/dashboard-layout/moving/HomeController.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![Moving of panels](./../images/moving.PNG)

> You can refer to our [ASP.NET Core Dashboard Layout](https://www.syncfusion.com/aspnet-core-ui-controls/dashboard-layout) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET Core Dashboard Layout example](https://ej2.syncfusion.com/aspnetcore/DashboardLayout/DefaultFunctionalities#/material) to knows how to present and manipulate data.