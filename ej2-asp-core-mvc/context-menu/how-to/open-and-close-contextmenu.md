---
layout: post
title: Open And Close Contextmenu in ##Platform_Name## Context Menu Component
description: Learn here all about how to open and close ContextMenu in Syncfusion ##Platform_Name## Context Menu component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Open And Close Contextmenu
publishingplatform: ##Platform_Name##
documentation: ug
---

# Open and close ContextMenu

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


