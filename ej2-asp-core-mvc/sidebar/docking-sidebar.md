---
layout: post
title: Docking Sidebar in ##Platform_Name## Sidebar Component
description: Learn here all about Docking Sidebar in Syncfusion ##Platform_Name## Sidebar component and more.
platform: ej2-asp-core-mvc
control: Docking Sidebar
publishingplatform: ##Platform_Name##
documentation: ug
---


# Dock

Dock state of the Sidebar reserves some space on the page that always remains in a visible state when the Sidebar is collapsed. It is used to show the short term of a content like icons alone instead of lengthy text. To achieve this , set [`EnableDock`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~EnableDock.html) as true along with required [`DockSize`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~DockSize.html).

In the following sample, the list item has icon with text representation. On dock state only the icon listed out to interact. It can be achieved by using [`EnableDock`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Sidebar~EnableDock.html) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/sidebar/docking-sidebar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dock.cs" %}
{% include code-snippet/sidebar/docking-sidebar/dock.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/sidebar/docking-sidebar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dock.cs" %}
{% include code-snippet/sidebar/docking-sidebar/dock.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



In Collapsed state,the output be like the below

![Sidebar Sample](./images/dock.png)

In Expanded state, the output be like the below

![Sidebar Sample](./images/dock_expanded.png)

## See Also

* [How to add sidebar navigation](./how-to/layout-page-sidebar-with-treeview)
