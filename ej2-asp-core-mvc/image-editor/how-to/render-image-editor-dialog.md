---
layout: post
title: Render Image Editor in dialog in ##Platform_Name## ImageEditor Control | Syncfusion
description: Learn here all about Render Image Editor in dialog in Syncfusion ##Platform_Name## ImageEditor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Render Image Editor in dialog
publishingplatform: ##Platform_Name##
documentation: ug
---

# Render Image Editor in Dialog

Image Editor is rendered within a dialog and opens an image by passing its URL path to the `open` method of the Image Editor control.

The following operations are supported in the Image Editor:

* Selection : Multiple selection options are available. The selection region can be a square or circle, customized to various aspect ratios, and customized by dragging and resizing.
* Crop : The image can be cropped based on the selection.
* Rotate : The image can be rotated both clockwise and anticlockwise by 90 degrees.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/how-to/render-image-editor-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/how-to/render-image-editor-dialog/HomeController_core.cs.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/how-to/render-image-editor-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/how-to/render-image-editor-dialog/HomeController_mvc.cs.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](../images/image-editor.jpg)