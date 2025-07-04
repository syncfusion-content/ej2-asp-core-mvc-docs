---
layout: post
title: Paste Clean-up in ##Platform_Name## Block Editor control | Syncfusion
description: Checkout and learn about paste clean-up with Syncfusion Essential ##Platform_Name## BlockEditor control, its elements, and more details.
platform: ej2-javascript
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
domainurl: ##DomainURL##
---

# Paste Clean-up in ##Platform_Name## Block Editor control

The Block Editor control provides robust paste clean-up functionalities to ensure that pasted content integrates seamlessly and maintains consistency with the editor's styling and structure. This helps in removing unwanted formatting, scripts, or elements often copied from external sources like web pages or word processors.

You can configure the paste settings using the [e-blockeditor-pastesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.PasteSettings.html) tag helper in the Block Editor control. This property allows you to define various options to control how content is pasted into the editor.

## Configuring allowed styles

The [allowedStyles](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.PasteSettings.html#Syncfusion_EJ2_BlockEditor_PasteSettings_AllowedStyles) property in the [e-blockeditor-pastesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.PasteSettings.html) tag helper allows you to define which CSS styles are permitted when content is pasted into the editor. Any style not included in this list will be stripped from the pasted content. This ensures that only desired visual attributes are preserved, maintaining a clean and consistent look.

By default, following styles are allowed:

['font-weight', 'font-style', 'text-decoration', 'text-transform'].

In the below example, only `font-weight` and `font-style` styles will be retained from the pasted content. All other inline styles will be removed.

```cshtml

@{
    var allowedStyles = new string[] { "font-weight", "font-style" };
}
<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor">
        <e-blockeditor-pastesettings  allowedStyles="@allowedStyles"></e-blockeditor-pastesettings>
    </ejs-blockeditor>
</div>

```

## Setting denied tags

The [deniedTags](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.PasteSettings.html#Syncfusion_EJ2_BlockEditor_PasteSettings_DeniedTags) property in [e-blockeditor-pastesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.PasteSettings.html) tag helper enables you to specify HTML tags that should be completely removed from the pasted content. This is particularly useful for stripping out potentially problematic or irrelevant tags, such as `script` tags, `iframe`s, or any other elements you don't want to allow in the editor. By default, the [deniedTags](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.PasteSettings.html#Syncfusion_EJ2_BlockEditor_PasteSettings_DeniedTags) property is an empty array, meaning no tags are removed by default.

In the below example, any `<script>` or `<iframe>` tags found in the pasted content will be removed, preventing unwanted behavior or styling issues.

```cshtml

@{
    var deniedTags = new string[] { "script", "iframe" };
}
<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor">
        <e-blockeditor-pastesettings  deniedTags="@deniedTags"></e-blockeditor-pastesettings>
    </ejs-blockeditor>
</div>

```

Below example demonstrates the usage of paste settings that allows only specific styles and also removes the specific tags from the pasted content.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/paste-cleanup/allowedStyle/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="AllowedStyle.cs" %}
{% include code-snippet/block-editor/paste-cleanup/allowedStyle/allowedstyle.cs %}
{% endhighlight %}
{% endtabs %}

![Allowed Styles](images/allowedStyles.png)

## Disable Keep format

By default, the editor attempts to keep the formatting of the pasted content (e.g., bold, italics, links). You can disable this behavior by setting the [keepFormat](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.PasteSettings.html#Syncfusion_EJ2_BlockEditor_PasteSettings_KeepFormat) property to `false` in [e-blockeditor-pastesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.PasteSettings.html) tag helper. When disabled, the editor will primarily paste the content as plain text regardless of [allowedStyles](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.PasteSettings.html#Syncfusion_EJ2_BlockEditor_PasteSettings_AllowedStyles).

```cshtml

<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor">
        <e-blockeditor-pastesettings  keepFormat="false"></e-blockeditor-pastesettings>
    </ejs-blockeditor>
</div>

```

## Allowing plain text

To paste content purely as plain text, stripping all HTML tags and inline styles, you can set the [plainText](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.PasteSettings.html#Syncfusion_EJ2_BlockEditor_PasteSettings_PlainText) property to `true` in [e-blockeditor-pastesettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.PasteSettings.html) tag helper. This ensures that only the raw textual content is inserted into the editor, making it ideal for maintaining strict content consistency. By default, the [plainText](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.PasteSettings.html#Syncfusion_EJ2_BlockEditor_PasteSettings_PlainText) property is set to `false`.

```cshtml

<div id='blockeditor-container'>
    <ejs-blockeditor id="block-editor">
        <e-blockeditor-pastesettings  plainText="true"></e-blockeditor-pastesettings>
    </ejs-blockeditor>
</div>

```

Below example demonstrates the usage of paste settings that disables the keep format and allows plain text.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/paste-cleanup/plainText/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Text.cs" %}
{% include code-snippet/block-editor/paste-cleanup/plainText/plaintext.cs %}
{% endhighlight %}
{% endtabs %}

![Plain Text](images/plainText.png)

### Events

The following events are available when pasting content into the editor.

|Name|Args|Description|
|---|---|---|
|[beforePaste](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_BeforePaste)|BeforePasteEventArgs|Triggers before the content is pasted into the editor.|
|[afterPaste](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_AfterPaste)|AfterPasteEventArgs|Triggers after the content is pasted into the editor.|
