---
layout: post
title: Xhtml Validation in ##Platform_Name## Rich Text Editor Control
description: Learn here all about Xhtml Validation in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Xhtml Validation
publishingplatform: ##Platform_Name##
documentation: ug
---

# XHTML validation in  ##Platform_Name## Rich Text Editor Control

The editor includes an [enableXhtml](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_EnableXhtml) property that allows for continuous validation of the Rich Text Editor's source content against the XHTML standard. When content is entered or modified in the editor, this feature ensures ongoing compliance by automatically removing invalid elements and attributes.

The editor checks the following settings on validation:

## Validating attributes

* **Case Sensitivity**: All attributes must be in lowercase.
* **Quotation Marks**: Proper use of quotation marks around attribute values is enforced.
* **Validity**: Only valid attributes for corresponding HTML elements are allowed.
* **Required Attributes**: All required attributes for HTML elements must be included.

## Validating HTML elements

* **Case Sensitivity**: All HTML tags must be in lowercase.
* **Proper Closing**: All opening tags must have corresponding closing tags.
* **Element Validity**: Only valid HTML elements are permitted.
* **Nesting**: Elements must be properly nested to maintain structure.
* **Root Element**: The content must have a single root element.
* **Element Hierarchy**: Inline elements cannot contain block elements.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/xhtml-validation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/xhtml-validation/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/xhtml-validation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/xhtml-validation/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Cross-Site scripting (XSS)

The Rich Text Editor allows users to edit the content with security by preventing cross-site scripting (XSS). By default, it provides built-in support to remove elements from editor content that cause XSS attacks. The editor removes the elements based on the attributes if it is possible to execute a script.

### Enable XSS validation

The [enableHtmlSanitizer](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_EnableHtmlSanitizer) property determines whether XSS prevention is active. It's set to `true` by default.

In the following sample, we removed the `script` tag and `onmouseover` attribute from the content of the Rich Text Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/cross/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/cross/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/cross/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/cross/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}


> The XSS prevention feature is only applicable when the [editorMode](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_EditorMode_Syncfusion_EJ2_RichTextEditor_EditorMode_) is set to HTML.

### Custom cross-site scripting prevention

For more precise control over XSS prevention, you can implement custom filtering logic using the [beforeSanitizeHtml](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_BeforeSanitizeHtml) event.

### Implementing custom cross-site scripting and fililtering in Rich Text Editor

1. Use the [beforeSanitizeHtml](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_BeforeSanitizeHtml) event to define custom filtering rules.
2. Utilize the `helper` function from the event argument to apply your custom filters.
3. Set the `cancel` argument to `true` if you want to override the built-in XSS prevention entirely.

The following sample demonstrates how to filter the `script` tag by value.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-cross/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-cross/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-cross/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-cross/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

You can also filter out the `e.selectors.tags` and `e.selector.attributes` in the [beforeSanitizeHtml](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_BeforeSanitizeHtml) event to control which HTML tags and attributes are allowed to appear. 

For instance, if you want to display `<iframe>`, you can manipulate the `e.selectors.tags` property in this event to selectively remove tags like `<iframe>`. This approach ensures that your application can safely display an iframe while preventing potential security risks associated with XSS vulnerabilities.

The following sample demonstrates how to filter the `iframe` tag.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/prevent-cross-site-scripting/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/prevent-cross-site-scripting/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/prevent-cross-site-scripting/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/prevent-cross-site-scripting/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}