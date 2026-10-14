---
layout: post
title: How to open ImageEditor in Dialog in ##Platform_Name## | Syncfusion
description: Open Syncfusion ##Platform_Name## ImageEditor inside a Dialog by combining ej2-dialog and ej2-image-editor to edit previewed uploaded images.
platform: ej2-asp-core-mvc
control: Dialog 
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Render Image Editor in Dialog

Rendering the [Image Editor](https://www.syncfusion.com/aspnet-core-ui-controls/image-editor) in a dialog involves displaying the image editor control within a modal dialog window, allowing users to edit images in a pop-up interface. This can be useful for maintaining a clean layout and providing a focused editing experience without navigating away from the current page.

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