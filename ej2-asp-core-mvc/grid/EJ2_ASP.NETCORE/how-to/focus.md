---
layout: post
title: How to move the focus to the corresponding cell while editing a row by double-clicking on a column in ##Platform_Name## Grid Component
description: Learn how to move the focus to the corresponding cell while editing a row by double-clicking on a column in inline edit mode of Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Focus
publishingplatform: ##Platform_Name##
documentation: ug
---


# Move the Focus to a Particular Cell Instead of First Cell While Editing a Row

The [`recordDoubleClick`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Grids.Grid~recordDoubleClick.html) event allows you to move the focus to the corresponding cell (the cell that you doubled-clicked to edit a row) instead of the first cell in edit form. With the help of this event, you can focus the double-clicked column in inline edit mode.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/focus/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Focus.cs" %}
{% include code-snippet/grid/how-to/focus/focus.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/grid/how-to/focus/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Focus.cs" %}
{% include code-snippet/grid/how-to/focus/focus.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

