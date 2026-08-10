---
layout: post
title: Open A Dialog On Contextmenu Item Click in ##Platform_Name## Context Menu Component
description: Learn here all about how to open a Dialog on ContextMenu item click in Syncfusion ##Platform_Name## Context Menu component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Open A Dialog On Contextmenu Item Click
publishingplatform: ##Platform_Name##
documentation: ug
---

# Open a dialog on ContextMenu item click

This section explains about how to open a dialog on ContextMenu item click. This can be achieved by handling dialog open in [`select`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_Select) event of the ContextMenu.

In the following sample, Dialog will open while clicking `Save As...` item:

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


