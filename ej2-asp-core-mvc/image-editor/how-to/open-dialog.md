---
layout: post
title: Filter in ##Platform_Name## ImageEditor Control | Syncfusion
description: Learn here all about Filter in Syncfusion ##Platform_Name## Image editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Dialog 
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Render Image Editor in Dialog

Rendering the Image Editor in a dialog involves displaying the image editor component within a modal dialog window, allowing users to edit images in a pop-up interface. This can be useful for maintaining a clean layout and providing a focused editing experience without navigating away from the current page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/image-editor/how-to/render-image-editor-dialog/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_core.cs" %}
{% include code-snippet/image-editor/how-to/render-image-editor-dialog/HomeController_core.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/image-editor/how-to/render-image-editor-dialog/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController_mvc.cs" %}
{% include code-snippet/image-editor/how-to/render-image-editor-dialog/HomeController_mvc.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Output be like the below.

![ImageEditor Sample](../images/image-editor-ie-dialog.png)