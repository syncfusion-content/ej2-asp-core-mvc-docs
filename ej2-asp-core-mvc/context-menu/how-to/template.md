---
layout: post
title: How to use a template in ##Platform_Name## Context Menu | Syncfusion
description: Customize Syncfusion ##Platform_Name## Context Menu submenu items with a custom template, such as a table layout, via the beforeItemRender event.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to use a template in ##Platform_Name## Context Menu

## Table in Sub ContextMenu

Menu items of the ContextMenu can be customized according to the requirement. This section explains how to customize a table template in a submenu item.

This can be achieved by appending a table layout during the rendering of each `li` element by using the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_BeforeItemRender) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/table/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Table.cs" %}
{% include code-snippet/context-menu/howto/table/table.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/table/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Table.cs" %}
{% include code-snippet/context-menu/howto/table/table.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



### UI controls in ContextMenu

UI controls can also be placed inside each `li` element of the ContextMenu.

In the following example, a CheckBox control is placed inside each `li` element by creating a CheckBox control in the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_BeforeItemRender) event and appending it into the `li` element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/ui-components/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Uicomponents.cs" %}
{% include code-snippet/context-menu/howto/ui-components/uicomponents.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/ui-components/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Uicomponents.cs" %}
{% include code-snippet/context-menu/howto/ui-components/uicomponents.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


