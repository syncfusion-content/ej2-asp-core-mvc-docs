---
layout: post
title: Character count in ##Platform_Name## Rich Text Editor Control
description: Learn here all about Character count in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Character count
publishingplatform: ##Platform_Name##
documentation: ug
---

# Character Count in ##Platform_Name## Rich Text Editor Control

The Character Count feature in the Rich Text Editor allows you to track and display the number of characters entered in the editor. This feature is particularly useful when you need to limit the content length or provide visual feedback to users about their input.

## How to Enable Character Count

To enable the character count feature, set the [showCharCount](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ShowCharCount) property to `true`. By default, this property is set to `false`.

When enabled, the character count is displayed at the bottom right corner of the editor.

## Understanding Character Count Color Indicators

The character count color will be modified based on the characters in the Rich Text Editor.

| Status | Description |
|----------------|---------|
| normal | The character count color remains black until 70% of the maxLength count is reached.|
| warning | When the character count reaches 70% of the maxLength, the color changes to orange, indicating that the maximum limit is approaching.|
| error |Once the character count hits 90% of the maxLength, the color turns red, signaling that the limit is nearly reached.|

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/character-count/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/character-count/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/character-count/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/character-count/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Setting Maximum Character Limit

You can restrict the number of characters entered in the editor by setting the [maxLength](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_MaxLength) property to a specific numeric value. When set, the maximum allowable character count is displayed alongside the current count at the bottom right of the editor.

If `maxLength` is not set, there is no limit to the character count in the editor.

## Retrieving Character Count Programmatically

You can programmatically get the current character count in the editor using the `getCharCount` public method.

```cs

  var editorCount = richTextEditorInstance.GetCharCount();

```

## See Also

* [How to Customize Character Count and Styles in Rich Text Editor](./style#customizing-character-count-display)