---
layout: post
title: Maintain Zoom To Fit in ##Platform_Name## Gantt Component
description: Learn here all about how to maintain zoom to fit in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Maintain Zoom To Fit
publishingplatform: ##Platform_Name##
documentation: ug
---


# Maintain zoomToFit

The timeline in the Gantt control is refreshed when you make edit actions or change the dataSource dynamically. The timeline is refreshed when the zoomToFit toolbar item is clicked and editing operations or dynamically changing dataSource are done. As a result, the timeline will no longer be appropriate for the project.

## Maintain zoomToFit after edit actions

The `zoomToFit` is maintained after editing actions (cell edit, dialog edit, taskbar edit) by using `fitToProject` method in `actionComplete` and `taskbarEdited` event.

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

The `zoomToFit` can be maintained after changing the dataSource dynamically, by calling `fitToProject` method in dataBound event.

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

