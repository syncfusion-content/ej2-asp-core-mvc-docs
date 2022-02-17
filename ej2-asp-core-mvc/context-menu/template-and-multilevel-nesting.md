---
layout: post
title: Template And Multilevel Nesting in ##Platform_Name## Context Menu Component
description: Learn here all about Template And Multilevel Nesting in Syncfusion ##Platform_Name## Context Menu component and more.
platform: ej2-asp-core-mvc
control: Template And Multilevel Nesting
publishingplatform: ##Platform_Name##
documentation: ug
---

# Template and Multilevel nesting

## Template

The ContextMenu items can be customized by using the [`Render`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu~BeforeItemRender.html)
event. The item render event triggers while rendering each menu item. The event argument will be used to identify the menu
item and customize it based on the requirement. In the following sample, the menu item is rendered with keycode for specified action in ContextMenu using the template. Here, the keycode is specified for Save as,
View page source, and Inspect in the right side corner of the menu items by adding span element in the [`beforeItemRender`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu~BeforeItemRender.html) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/context-menu/template/template.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Template.cs" %}
{% include code-snippet/context-menu/template/template.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Multilevel nesting

The Multiple level nesting supports in ContextMenu. It can be achieved by mapping the [`items`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem~Items.html)
property inside the parent [`menuItems`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenuItem.html). In the below sample, three level nesting of ContextMenu is provided.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/nesting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Nesting.cs" %}
{% include code-snippet/context-menu/nesting/nesting.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/nesting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Nesting.cs" %}
{% include code-snippet/context-menu/nesting/nesting.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## See Also

* [Populate menu items with data source](./how-to#data-binding)