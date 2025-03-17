---
layout: post
title: Insert Images in ##Platform_Name## Markdown Editor Control | Syncfusion
description: Checkout and learn about Insert Images in ##Platform_Name## Markdown Editor control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Insert Images
publishingplatform: ##Platform_Name##
documentation: ug
---

# Insert Images in ##Platform_Name## Markdown Editor Control

The Markdown Editor allows users to insert images using the toolbar. This feature enables embedding images from online sources into the editor content.

Follow these steps to add an image in the Markdown editor:

1. Click the **Insert Image** icon in the toolbar.
2. Enter the **URL** of the image from an online source.
3. Click the **Insert** button in the image dialog.

The image will be added to the editor content at the cursor position.

The following example demonstrates how to enable image insertion in the Syncfusion ASP.NET Core Markdown Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/markdown-image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/markdown-image/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/markdown-editor/markdown-image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/markdown-editor/markdown-image/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}