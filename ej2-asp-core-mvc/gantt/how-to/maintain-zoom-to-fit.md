---
layout: post
title: Maintain Zoom To Fit in ##Platform_Name## Gantt Component
description: Learn here all about Maintain Zoom To Fit in Syncfusion ##Platform_Name## Gantt component and more.
platform: ej2-asp-core-mvc
control: Maintain Zoom To Fit
publishingplatform: ##Platform_Name##
documentation: ug
---


# Maintain zoomToFit

In the Gantt control, While performing edit actions or dynamically change dataSource, the timeline gets refreshed. When zoomToFit toolbar item is clicked and perform editing actions or dynamically change dataSource, the timeline gets refreshed. So that, the timeline will not fit to the project any more.

## Maintain zoomToFit after edit actions

We can maintain `zoomToFit` after editing actions(cell edit,dialog edit,taskbar edit) by using `fitToProject` method in `actionComplete` and `taskbarEdited` event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/maintainzoomtofit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Maintainzoomtofit.cs" %}
{% include code-snippet/gantt/how-to/maintainzoomtofit/maintainzoomtofit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/maintainzoomtofit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Maintainzoomtofit.cs" %}
{% include code-snippet/gantt/how-to/maintainzoomtofit/maintainzoomtofit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Maintain zoomToFit after change dataSource dynamically

We can maintain `zoomToFit` after change dataSource dynamically, by calling `fitToProject` method in dataBound event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/maintainzoomtofitdatasource/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Maintainzoomtofitdatasource.cs" %}
{% include code-snippet/gantt/how-to/maintainzoomtofitdatasource/maintainzoomtofitdatasource.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/gantt/how-to/maintainzoomtofitdatasource/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Maintainzoomtofitdatasource.cs" %}
{% include code-snippet/gantt/how-to/maintainzoomtofitdatasource/maintainzoomtofitdatasource.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

