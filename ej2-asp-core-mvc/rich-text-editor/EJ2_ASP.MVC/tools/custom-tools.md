---
layout: post
title: Custom Toolbar in ##Platform_Name## Rich Text Editor Control | Syncfusion
description: Learn here all about Custom Toolbar in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Custom Toolbar
publishingplatform: ##Platform_Name##
documentation: ug
---

# Custom Toolbar Items in the ##Platform_Name## Rich Text Editor Control

To quickly get started with the ASP.NET MVC Rich Text Editor with a custom toolbar, watch this video:

{% youtube "youtube:https://www.youtube.com/watch?v=AnHsErOlU1A"%}

The Rich Text Editor allows you to configure your own commands to its toolbar using the [toolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings) property. The command can be plain text, icon, or HTML template. The order and the group can also be defined where the command should be included. Bind the action to the command by getting its instance.

This sample shows how to add your own commands to the toolbar of the Rich Text Editor. The “Ω” command is added to insert special characters in the editor. By clicking the “Ω” command, it will show the special characters list, and then choose the character to be inserted in the editor.

The following code snippet illustrates custom tool with tooltip text which will be included in [items](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorToolbarSettings.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_Items) field of the [toolbarSettings](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings) property.


```csharp

    var tools = new {
        tooltipText = "Insert Symbol",
            template = "<button class='e-tbar-btn e-btn' tabindex='-1' id='custom_tbar'  style='width:100%'><div class='e-tbar-btn-text rtecustomtool' style='font-weight: 500;'> &#937;</div></button>"
    };
    ViewBag.items = new object[] { "Bold", "Italic", "Underline", "|", "Formats", "Alignments", "OrderedList",
        "UnorderedList", "|", "CreateLink", "Image", "|", "SourceCode", tools
        , "|", "Undo", "Redo"
    };

```

The Rich Text Editor provides options to customize tool functionalities. Use the `undo` property to enable or disable the undo function for specific tools. Additionally, the click property lets you configure and bind the onclick event of a tool to a specific method.

This sample demonstrates how to add a custom "Ω" icon to the toolbar. Clicking on this icon opens a dialog where you can insert special characters into the editor. It also shows how to enable undo and redo functionalities.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-tool/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-tool/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/custom-tool/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/custom-tool/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

> When rendering any control for the custom toolbar, like a dropdown, the focus may be lost, causing it to render outside the Rich Text Editor and triggering a blur event. This can interfere with proper functionalities like cursor focus. To prevent this issue, it is recommended to assign the `e-rte-elements` class to the control rendered in the custom toolbar.

## Enabling and disabling toolbar items

You can use the `enableToolbarItem` and `disableToolbarItem` methods to control the state of toolbar items. This methods takes a single item or an array of [items](#available-toolbar-items) as parameter.

>You can add the command name `Custom` to disable the custom toolbar items on source code view and other quick toolbar operations.