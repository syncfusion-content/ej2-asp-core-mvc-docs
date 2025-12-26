---
layout: post
title: Clipboard Cleanup in ##Platform_Name## Syncfusion Rich Text Editor Control
description: Learn here all about Clipboard Cleanup in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Clipboard Cleanup
publishingplatform: ##Platform_Name##
documentation: ug
---

# Clipboard Cleanup in ##Platform_Name## Rich Text Editor Control

The Rich Text Editor supports automatic cleanup of clipboard content during copy (`Ctrl + C`) and cut (`Ctrl + X`) operations. When this feature is enabled, unwanted inline styles are automatically removed from the clipboard content while preserving important structural elements such as tables, lists, and images. You can enable this behavior using the [enableClipboardCleanup](https://help.syncfusion.com/cr/aspnetcore-js2/syncfusion.ej2.richtexteditor.richtexteditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_EnableClipboardCleanup) property.

When `enableClipboardCleanup` is set to `true`, copy and cut operations are intercepted to remove unwanted inline styles. When set to `false` the browser’s default copy and cut behavior applies.

> For a cleaner editing experience, `enableClipboardCleanup` is `true` by default.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/clipboard-cleanup/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/clipboard-cleanup/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/clipboard-cleanup/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/clipboard-cleanup/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Customizing Copied/Cut Content

You can use the [beforeClipboardWrite](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_BeforeClipboardWrite) event, which fires before content is written to the clipboard during copy or cut operations. This event lets you to modify the HTML and plain-text representations of the content and also determine whether the action is a copy or a cut.

In this example, the `beforeClipboardWrite` event is used to customize the selected content only during a copy operation, while the cut operation remains unaffected. To observe this behavior, try copying any text within the Rich Text Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/clipboard-cleanup-customize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/clipboard-cleanup-customize/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/clipboard-cleanup-customize/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/clipboard-cleanup-customize/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Best Practices & Troubleshooting

### Best Practices

- Use `beforeClipboardWrite` sparingly — heavy processing can slightly delay `Ctrl+C`.

### Common Issues

- “Event not firing” → Make sure you’re using the correct event name `beforeClipboardWrite` (camelCase in Core).

