---
layout: post
title: Open dialog on context menu item click | Syncfusion
description: Open a Syncfusion Dialog from the select event of the ##Platform_Name## Context Menu when the user clicks an item such as Save As to confirm a save.
platform: ej2-asp-core-mvc
control: Open A Dialog On Contextmenu Item Click
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to open dialog on item click in ##Platform_Name## Context Menu

This section explains how to open a dialog on ContextMenu item click. This can be achieved by opening the dialog in the [`select`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_Select) event of the ContextMenu.

In the following sample, a Dialog opens when the user clicks the `Save As...` item:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Dialogbutton-core.cs" %}
{% include code-snippet/context-menu/howto/dialog/dialogbutton-core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Dialogbutton-core.cs" %}
{% include code-snippet/context-menu/howto/dialog/dialogbutton-core.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


