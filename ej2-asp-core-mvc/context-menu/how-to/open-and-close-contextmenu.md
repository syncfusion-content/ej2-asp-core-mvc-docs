---
layout: post
title: How to open and close ##Platform_Name## Context Menu | Syncfusion
description: Open and close the Syncfusion ##Platform_Name## Context Menu programmatically with the open and close methods at any top/left position.
platform: ej2-asp-core-mvc
control: Open And Close Contextmenu
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to open and close ##Platform_Name## Context Menu

The ContextMenu can be opened and closed programmatically whenever required by using the [`open`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_Open_System_Double_System_Double_System_Double_) and [`close`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_Close) methods.

In the following example, the ContextMenu is opened using the `open` method at the specified position using the `left` and `top` arguments (`open(60, 20)`). The ContextMenu closes automatically on item click or document click.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/open-close/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Openclose.cs" %}
{% include code-snippet/context-menu/howto/open-close/openclose.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/open-close/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Openclose.cs" %}
{% include code-snippet/context-menu/howto/open-close/openclose.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


