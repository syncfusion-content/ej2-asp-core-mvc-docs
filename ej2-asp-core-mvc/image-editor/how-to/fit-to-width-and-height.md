---
layout: post
title: Fit to Width and Height in ##Platform_Name## Image editor | Syncfusion
description: Learn here all about Fit to Width and Height in Syncfusion ##Platform_Name## ImageEditor component of Syncfusion Essential JS 2 and more.
platform:  ej2-asp-core-mvc
control: Fit to Width and Height
publishingplatform: ##Platform_Name##
documentation: ug
---

# Fit Image to Editor Width and Height

The Image Editor's `zoom` method to fit an image to the editor by width or height. Programmatically increase the zoom level until the image dimension matches the editor container's width or height. 

This example demonstrates scenarios that include buttons for fitting the image to its width (Fit Width) or height (Fit Height).

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/how-to/fit-to-width-and-height/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/how-to/fit-to-width-and-height/default.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/how-to/fit-to-width-and-height/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Default.cs" %}
{% include code-snippet/image-editor/how-to/fit-to-width-and-height/default.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](../images/image-editor-fit-to-width-and-height.jpg)