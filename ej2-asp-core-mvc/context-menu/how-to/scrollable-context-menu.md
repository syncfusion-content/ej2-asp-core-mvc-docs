---
layout: post
title: Render Scrollable Context Menu in ##Platform_Name## Context Menu Component | Syncfusion
description: Learn here all about Render Scrollable Context Menu in Syncfusion ##Platform_Name## Context Menu component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Render Scrollable Context Menu
publishingplatform: ##Platform_Name##
documentation: ug
---

# Render Scrollable Context Menu

To enable scrolling for the Context Menu, use the [enableScrolling](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu.Enablescrolling.html) property to manage the overflow behavior of menu items by enabling or disabling scroll functionality. This is especially useful when dealing with a large number of menu items that exceed the viewport height, ensuring the context menu remains accessible without affecting the page layout.

To achieve this functionality, set the `EnableScrolling` property to `true`. Additionally, use the [BeforeOpen](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu.BeforeOpen.html) event to adjust the height of the menu's parent element, ensuring the scrollable area is applied correctly.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/scroller/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="default.cs" %}
{% include code-snippet/context-menu/howto/scroller/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/scroller/razor %}
{% endhighlight %}
{% highlight c# tabtitle="default.cs" %}
{% include code-snippet/context-menu/howto/scroller/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Drop Down Button Scroller Support](images/blazor-contextmenu-scroller.png)


