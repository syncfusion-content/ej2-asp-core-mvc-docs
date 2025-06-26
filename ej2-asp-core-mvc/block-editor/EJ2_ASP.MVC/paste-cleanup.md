---
layout: post
title: Undo redo in ##Platform_Name## Block Editor Control | Syncfusion
description: Checkout and learn about undo redo with Syncfusion Essential ##Platform_Name## BlockEditor control, its elements, and more details.
platform: ej2-asp-core-mvc
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Paste Clean-up in ##Platform_Name## Block Editor control

The Block Editor control provides robust paste clean-up functionalities to ensure that pasted content integrates seamlessly and maintains consistency with the editor's styling and structure. This helps in removing unwanted formatting, scripts, or elements often copied from external sources like web pages or word processors.

You can configure the paste settings using the `pasteSettings` property in the Block Editor control. This property allows you to define various options to control how content is pasted into the editor.

## Configuring allowed styles

The `allowedStyles` property in the `pasteSettings` model allows you to define which CSS styles are permitted when content is pasted into the editor. Any style not included in this list will be stripped from the pasted content. This ensures that only desired visual attributes are preserved, maintaining a clean and consistent look.

By default, following styles are allowed:

['font-weight', 'font-style', 'text-decoration', 'text-transform'].

In the below example, only `font-weight` and `font-style` styles will be retained from the pasted content. All other inline styles will be removed.

## Setting denied tags

The `deniedTags` property in `pasteSettings` enables you to specify HTML tags that should be completely removed from the pasted content. This is particularly useful for stripping out potentially problematic or irrelevant tags, such as `script` tags, `iframe`s, or any other elements you don't want to allow in the editor. By default, the `deniedTags` property is an empty array, meaning no tags are removed by default.

In the below example, any `<script>` or `<iframe>` tags found in the pasted content will be removed, preventing unwanted behavior or styling issues.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/paste-cleanup/allowedStyle/razor %}
{% endhighlight %}
{% highlight c# tabtitle="AllowedStyle.cs" %}
{% include code-snippet/block-editor/paste-cleanup/allowedStyle/allowedstyle.cs %}
{% endhighlight %}
{% endtabs %}

![Allowed Style](images/allowedStyles.png)

## Disable Keep format

By default, the editor attempts to keep the formatting of the pasted content (e.g., bold, italics, links). You can disable this behavior by setting the `keepFormat` property to `false` in `pasteSettings`. When disabled, the editor will primarily paste the content as plain text regardless of `allowedStyles`.

## Allowing plain text

To paste content purely as plain text, stripping all HTML tags and inline styles, you can set the `plainText` property to `true` in `pasteSettings`. This ensures that only the raw textual content is inserted into the editor, making it ideal for maintaining strict content consistency. By default, the `plainText` property is set to `false`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/paste-cleanup/plainText/razor %}
{% endhighlight %}
{% highlight c# tabtitle="PlainText.cs" %}
{% include code-snippet/block-editor/paste-cleanup/plainText/plaintext.cs %}
{% endhighlight %}
{% endtabs %}

![Plain Text](images/plainText.png)

### Events

The following events are available when pasting content into the editor.

|Name|Args|Description|
|---|---|---|
|`beforePaste`|BeforePasteEventArgs|Triggers before the content is pasted into the editor.|
|`afterPaste`|AfterPasteEventArgs|Triggers after the content is pasted into the editor.|

Below example demonstrates how to configure above events in the editor.
