---
layout: post
title: Use Case Scenarios in ##Platform_Name## Menu Component
description: Learn here all about Use Case Scenarios in Syncfusion ##Platform_Name## Menu component and more.
platform: ej2-asp-core-mvc
control: Use Case Scenarios
publishingplatform: ##Platform_Name##
documentation: ug
---


# Use case scenarios

## Scrollable menu

The menu component supports horizontal and vertical scrolling to render large menus and submenus in an adaptive way. This can be achieved by enabling the [`enableScrolling`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.Menu~EnableScrolling.html) property and by restricting the corresponding menu/submenu size.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/use-cases/scrollable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Scrollable.cs" %}
{% include code-snippet/menu/use-cases/scrollable/Scrollable.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/use-cases/scrollable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Scrollable.cs" %}
{% include code-snippet/menu/use-cases/scrollable/Scrollable.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Menu in toolbar

The following example demonstrates how to integrate Menu with Toolbar component.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/use-cases/toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ToolBar.cs" %}
{% include code-snippet/menu/use-cases/toolbar/ToolBar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/use-cases/toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ToolBar.cs" %}
{% include code-snippet/menu/use-cases/toolbar/ToolBar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Hamburger menu

The following example demonstrates the use case of menu with Accordion component integrated in SideBar.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/use-cases/sidebar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="SideBar.cs" %}
{% include code-snippet/menu/use-cases/sidebar/SideBar.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/use-cases/sidebar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="SideBar.cs" %}
{% include code-snippet/menu/use-cases/sidebar/SideBar.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Mobile view

The following example demonstrates the use case of Menu in Mobile mode by using ListView component with hamburger.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/menu/use-cases/listview/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ListView.cs" %}
{% include code-snippet/menu/use-cases/listview/ListView.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/menu/use-cases/listview/razor %}
{% endhighlight %}
{% highlight c# tabtitle="ListView.cs" %}
{% include code-snippet/menu/use-cases/listview/ListView.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


