---
layout: post
title: Emoji Picker in ##Platform_Name## RichTextEditor | Syncfusion
description: Learn about Emoji Picker in Syncfusion ##Platform_Name## RichTextEditor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Emoji Picker
publishingplatform: ##Platform_Name##
documentation: ug
---

# Emoji Picker

An emoji picker is a tool that allows users to add emojis or emoticons to their text easily. Typically, it is a small window or panel that displays a variety of emojis arranged in different categories, such as smileys, animals, food, and so on. Users can select the desired emoji by clicking on it or by typing its name in a search bar.

## Enabling the toolbar option and custom emojis.

Add the `EmojiPicker` tool to the toolbar of the RichTextEditor by utilizing the `ToolbarSettings` [Items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) property.

By default, a predefined set of emojis is configured. However, you can customize these icons according to your needs. To achieve this, utilize the [EmojiPickerSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_EmojiPickerSettings) property.

The following code example shows how to customize icons in the emoji picker.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/emoji-picker-customize/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/emoji-picker-customize/controller.cs %}
{% endhighlight %}
{% endtabs %}

Additionally, you have the option to customize the icons of toolbar items using the `IconCss` and `Code` properties. The `IconCSS` property allows you to define a custom CSS class for the toolbar item icon, while the `Code` property enables you to specify the Unicode character code for the icon.

When both `IconCSS` and `Code` properties are provided, the `IconCSS` property takes precedence in determining the appearance of the toolbar item icon.

Additionally, you have the option to enhance the user experience by implementing a filtering feature for efficiently managing a large dataset of emojis. By setting the [ShowSearchBox](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorEmojiSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorEmojiSettings_ShowSearchBox) property to true (which is the default value), users will be able to utilize a search box to filter the displayed emojis according to their preferences.

The following code example shows how to add the emoji picker tool in the RichTextEditor.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/emoji-picker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/emoji-picker/controller.cs %}
{% endhighlight %}
{% endtabs %}


## Using the shortcut key to open the emoji picker

Quickly access the emoji picker by pressing the colon (:) key while typing a word prefix in an editor, allowing instant emoji selection and display. Moreover, continue typing in the editor after the colon (:) to filter and refine your search for the desired emojis.

![Rich Text Editor Emoji Picker](./images/emoji-picker-shorcut.png)

## Navigating and selecting emojis using the keyboard

The emoji picker popup offers keyboard navigation options, allowing you to move the emoji focus from one emoji to another. The following keys are used for navigation:

`Arrow keys`: Use the arrow keys (up, down, left, right) to move the emoji focus in the corresponding direction.

`Enter`: Press Enter key to select the currently focused emoji.

`Escape`: Press Escape to close the emoji picker popup without selecting an emoji.
