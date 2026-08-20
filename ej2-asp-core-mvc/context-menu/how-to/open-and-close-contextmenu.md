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

ContextMenu can be opened and closed programmatically whenever required by using the open and close methods.

In the following example, the ContextMenu is opened using the `open` method at the specified position using `top` and `left`. Also, ContextMenu is closed using `close` method on ContextMenu item click or document click.

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


