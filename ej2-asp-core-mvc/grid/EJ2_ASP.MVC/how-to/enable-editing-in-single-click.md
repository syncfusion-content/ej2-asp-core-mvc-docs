---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Enable Editing In Single Click of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Enable Editing In Single Click
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enable editing in single click

## Normal Editing

You can make a row editable on a single click with **Normal** mode of editing in Grid, by using the **startEdit** and **endEdit** methods.

Bind the **mouseup** event for Grid and in the event handler call the **startEdit** and **endEdit**, based on the clicked target element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="tagHelper" %}
{% include code-snippet/grid/how-to/single-click-inline-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="single-click-normal-edit" %}
{% include code-snippet/grid/how-to/single-click-inline-edit/single-click-normal-edit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="razor" %}
{% include code-snippet/grid/how-to/single-click-inline-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="single-click-normal-edit" %}
{% include code-snippet/grid/how-to/single-click-inline-edit/single-click-normal-edit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### Open dropdown edit popup on single click

You can open the default dropdown edit popup with single click edit by focusing the dropdown element and calling the EJ2 dropdown list's **showPopup** method in the Grid's **ActionComplete** event. In this demo we have used a global flag variable in the **mouseup** event to ensure if the dropdown column is the clicked edit target.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="tagHelper" %}
{% include code-snippet/grid/how-to/open-dropdown-popup/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="open-dropdown-popup" %}
{% include code-snippet/grid/how-to/open-dropdown-popup/open-dropdown-popup.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="razor" %}
{% include code-snippet/grid/how-to/open-dropdown-popup/razor %}
{% endhighlight %}
{% highlight c# tabtitle="open-dropdown-popup" %}
{% include code-snippet/grid/how-to/open-dropdown-popup/open-dropdown-popup.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Batch Editing

You can make a cell editable on a single click with **Batch** mode of editing in Grid, by using the **editCell** method.

Bind the **mouseup** event for Grid and in the event handler call the **editCell** method, based on the clicked target element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="tagHelper" %}
{% include code-snippet/grid/how-to/single-click-batch-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="single-click-batch-edit" %}
{% include code-snippet/grid/how-to/single-click-batch-edit/single-click-batch-edit.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="razor" %}
{% include code-snippet/grid/how-to/single-click-batch-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="single-click-batch-edit" %}
{% include code-snippet/grid/how-to/single-click-batch-edit/single-click-batch-edit.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


