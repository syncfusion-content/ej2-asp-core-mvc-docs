---
layout: post
title: Fullscreen Mode in ##Platform_Name## Rich Text Editor Control | Syncfusion
description: Learn here all about Fullscreen Mode in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Fullscreen Mode
publishingplatform: ##Platform_Name##
documentation: ug
---

# Fullscreen Mode in ##Platform_Name## Rich Text Editor 

The Fullscreen mode allows the Rich Text Editor to expand and occupy the entire browser viewport. This provides a distraction-free editing experience and more space to work with content and toolbar features.

You can enable fullscreen mode using the FullScreen icon toolbar button. Once activated, the editor transitions into fullscreen view, hiding other page elements and maximizing the editing area.

## How it works

Click the fullscreen icon in the toolbar to toggle fullscreen mode. When enabled, the editor:

- Expands to fill the entire browser window.
- Adjusts its layout to optimize space for content and tools.
- Can be exited by clicking the same icon again or pressing the `Esc` key.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/fullscreen/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/fullscreen/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/fullscreen/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/fullscreen/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}