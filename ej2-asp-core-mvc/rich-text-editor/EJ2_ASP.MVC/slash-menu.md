---
layout: post
title: Slash Menu in ##Platform_Name## Rich Text Editor Component | Syncfusion
description: Learn here all about Slash Menu in Syncfusion ##Platform_Name## Rich Text Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Slash Menu
publishingplatform: ##Platform_Name##
documentation: ug
---


# Slash Menu in the ##Platform_Name## Rich Text Editor component

The Slash Menu in the Rich Text Editor provides users with an efficient way to apply formatting, insert elements, and execute custom commands by simply typing the "/" character. This feature enhances the user experience by offering quick access to common editing actions within the editor.

## Enabling the Slash Menu

To enable the Slash Menu, set the `Enable` property within [`SlashMenuSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorSlashMenuSettings.html) to `true`. By default, this feature is disabled. Once enabled, the Slash Menu will appear when the user types the "/" character in the editor.

## Configuring the Slash Menu Items

The slashMenuSettings property allows customization of the `Items` displayed in the Slash Menu. By defining the [`Items`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorSlashMenuSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorSlashMenuSettings_Items) property, a list of available commands can be provided for users to choose from when they type a slash (/) in the Rich Text Editor.

This list can include various formatting options such as paragraph and heading levels. Here’s an code snippet of configuring the Slash Menu items:

```
ViewBag.SlashMenuSettings = new Syncfusion.EJ2.RichTextEditor.RichTextEditorSlashMenuSettings
{
    Enable = true,
    Items = new object[] { "Paragraph", "Heading 1", "Heading 2", "Heading 3" },
};
```

## Customizing the Popup Width and Height

The size of the Slash Menu popup can be customized using the [`PopupWidth`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorSlashMenuSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorSlashMenuSettings_PopupWidth) and [`PopupHeight`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorSlashMenuSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorSlashMenuSettings_PopupHeight) properties within slashMenuSettings. Adjusting these values allows for control over the dimensions of the menu. 

Below is an code snippet showing how to customize both the width and height of the popup:

```
ViewBag.SlashMenuSettings = new Syncfusion.EJ2.RichTextEditor.RichTextEditorSlashMenuSettings
{
    Enable = true,
    Items = new object[] { "Paragraph", "Heading 1", "Heading 2", "Heading 3" },
    PopupHeight = "300px",
    PopupWidth = "250px"
};
```

## Adding Custom Slash Menu Items

Custom items can be added by defining the items property inside slashMenuSettings. This property accepts either a string of predefined items or an array of objects representing custom menu items.

Each custom item object can include the following properties:

| Property    | Description                                           |
|-------------|-------------------------------------------------------|
| text        | The label of the menu item.                           |
| command     | The action to be executed when the item is clicked.   |
| type        | Groups related items in the Slash Menu.               |
| iconCss     | Specifies the CSS class for the item's icon.          |
| description | Provides a short description for the item.            |


The following code demonstrates how to set up the Custom Slash Menu item in the Rich Text Editor to insert meeting notes and signature:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/slashmenu/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/slashmenu/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/slashmenu/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/slashmenu/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}