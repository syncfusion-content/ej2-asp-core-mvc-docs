---
layout: post
title: How to underline item text in ##Platform_Name## Context Menu | Syncfusion
description: Underline a specific character in Syncfusion ##Platform_Name## Context Menu item text by wrapping it in a `<u>` tag inside the beforeItemRender event.
platform: ej2-asp-core-mvc
control: Underline A Character In The Item Text
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to underline item text in ##Platform_Name## Context Menu

To underline a particular character in the item text, handle the [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Navigations.ContextMenu.html#Syncfusion_EJ2_Navigations_ContextMenu_BeforeItemRender) event by wrapping the target character in a `<u>` tag and setting the resulting string as the `innerHTML` of the `li` element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/underline/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Underline.cs" %}
{% include code-snippet/context-menu/howto/underline/underline.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/context-menu/howto/underline/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Underline.cs" %}
{% include code-snippet/context-menu/howto/underline/underline.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


