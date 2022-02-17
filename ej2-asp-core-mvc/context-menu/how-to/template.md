---
layout: post
title: Template in ##Platform_Name## Context Menu Component
description: Learn here all about Template in Syncfusion ##Platform_Name## Context Menu component and more.
platform: ej2-asp-core-mvc
control: Template
publishingplatform: ##Platform_Name##
documentation: ug
---

# Template

## Table in Sub ContextMenu

Menu items of the ContextMenu can be customized according to the requirement. The section explains about how to customize table template
in sub menu item.

This can be achieved by appending table layout while `li` rendering by using [`beforeItemRender`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu~BeforeItemRender.html) event.

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



### UI Components in ContextMenu

UI components can also be placed inside the each `li` element of ContextMenu.

In the following example, CheckBox component is placed inside each `li` element and this can be achieved by creating
CheckBox component in [`beforeItemRender`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu~BeforeItemRender.html) event and appending it into the `li` element.

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


