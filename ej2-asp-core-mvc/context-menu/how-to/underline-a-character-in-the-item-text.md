---
layout: post
title: Underline A Character In The Item Text in ##Platform_Name## Context Menu Component
description: Learn here all about Underline A Character In The Item Text in Syncfusion ##Platform_Name## Context Menu component and more.
platform: ej2-asp-core-mvc
control: Underline A Character In The Item Text
publishingplatform: ##Platform_Name##
documentation: ug
---

# Underline a character in the item text

To underline a particular character in a text, it can be handled in [`beforeItemRender`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/aspnetcore/Syncfusion.EJ2~Syncfusion.EJ2.Navigations.ContextMenu~BeforeItemRender.html)
event by adding `<u>` tag in between the text and given as innerHTML in `li` rendering.

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


