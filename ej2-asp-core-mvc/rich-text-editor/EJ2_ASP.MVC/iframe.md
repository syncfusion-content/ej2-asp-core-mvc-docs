---
layout: post
title: Iframe in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Iframe in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: Iframe
publishingplatform: ##Platform_Name##
documentation: ug
---


# Iframe

When the [`IframeSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_IframeSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorIFrameSettings_) option is enabled, the Rich Text Editor creates the iframe element as the content area on control initialization; it is used to display and editing the content. In content area, the editor displays only the body tag of a `< iframe >` document.

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



## Iframe Attributes

The editor allows you to pass an additional attribute to body tag of a < iframe > element using attributes fields of the `attributes` fields of [`IframeSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_IframeSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorIFrameSettings_) property. This property contains name/value pairs in string format. It is used to override the default appearance of the content area.

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



## Adding External CSS/Script File

The editor offers you to add external CSS file to style the `< iframe >` element. Easily change the appearance of editor’s content using an external CSS file using  `styles` field in [`IframeSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_IframeSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorIFrameSettings_) property.

Likewise, add the external script file to the `<iframe>` element using `scripts` field of `IframeSettings` to provide the additional functionalities to the Rich Text Editor.

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



## See Also

* [How to change the editor mode](./formation/#markdown-editor)