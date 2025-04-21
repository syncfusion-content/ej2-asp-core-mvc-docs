---
layout: post
title: Iframe in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Iframe in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Iframe
publishingplatform: ##Platform_Name##
documentation: ug
---

# IFrame Editing Mode in ##Platform_Name## Rich Text Editor Control

The iframe editor in the Rich Text Editor control provides an isolated environment for content editing. It uses an iframe element to create a separate document, ensuring better compatibility and separation from the parent page's styles and scripts. In this mode, the editor displays only the body tag of the iframe, offering a clean and isolated workspace for content creation.

## Configuring the Iframe editor

To enable the iframe editor, you can use the [iframeSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_IframeSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorIFrameSettings_) property. When this option is enabled, the Rich Text Editor creates an iframe element as the content area during initialization.

Here's an example of how to enable the iframe editor:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/iframe/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/iframe/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/iframe/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/iframe/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customizing IFrame attributes

You can add custom attributes to the body tag of the iframe using the attributes field of the [iframeSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_IframeSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorIFrameSettings_) property. This property accepts name/value pairs in string format, enabling you to override the default appearance of the content area.


{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/iframe-attributes/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/iframe-attributes/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/iframe-attributes/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/iframe-attributes/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Integrating external CSS and scripts

The Rich Text Editor allows you to apply an external CSS file to style the iframe element. This can be done using the `styles` field in the iframeSettings property. By including an external CSS file, you can easily change the appearance of the editor’s content to meet your specific requirements.

Likewise, add the external script file to the `< iframe >` element using the `scripts` field of iframeSettings to provide the additional functionalities to the RichTextEditor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/external-css/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/external-css/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/external-css/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/external-css/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> You can also explore our [iframe in ASP.NET Core Rich Text Editor example](https://ej2.syncfusion.com/aspnetcore/richtexteditor/iframe#/tailwind3) that shows how to render the iframe in Angular Rich Text Editor.

## See also

* [Implementing Inline Editing](./inline-editing)
* [Using the Markdown Editor](https://ej2.syncfusion.com/aspnetcore/documentation/markdown-editor/getting-started)
