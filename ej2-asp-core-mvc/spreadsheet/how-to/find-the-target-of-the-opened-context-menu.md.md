---
layout: post
title: Find the target of the opened context menu in ##Platform_Name## Spreadsheet Control | Syncfusion
description: Learn here all about how to find the target of the opened context menu in Syncfusion ##Platform_Name## Spreadsheet component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Spreadsheet
publishingplatform: ##Platform_Name##
documentation: ug
---

## Find the target of the opened context menu in ##Platform_Name## Spreadsheet control

In the [`contextMenuBeforeOpen`](https://ej2.syncfusion.com/react/documentation/api/spreadsheet/#contextmenubeforeopen) event, you can check whether the args.event.target element is closer to the particular parent element using its class name.

| Context menu name | Class name |
|-------|---------|
| Column header context menu | .e-colhdr-table |
| Row header context menu | .e-rowhdr-table |
| Cell context menu | .e-sheet-content |
| Footer context menu | .e-toolbar-item |


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/find-target-context-menu/tagHelper %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/spreadsheet/find-target-context-menu/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}
