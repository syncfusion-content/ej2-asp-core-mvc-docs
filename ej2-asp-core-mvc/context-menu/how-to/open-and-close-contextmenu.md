---
layout: post
title: Open And Close Contextmenu in ##Platform_Name## Context Menu Component
description: Learn here all about Open And Close Contextmenu in Syncfusion ##Platform_Name## Context Menu component and more.
platform: ej2-asp-core-mvc
control: Open And Close Contextmenu
publishingplatform: ##Platform_Name##
documentation: ug
---

# Open and close ContextMenu

Open and close the ContextMenu manually whenever required by using the open and close methods. In the following sample, to open the ContextMenu at specified position the [`open`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu~OnOpen.html) method is used with `X` and `Y` coordinates
and to close ContextMenu [`close`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu~OnClose.html) method can be used.

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


