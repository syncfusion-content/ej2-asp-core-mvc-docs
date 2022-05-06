---
layout: post
title: Getting Started with ##Platform_Name## Rich Text Editor Control | Syncfusion
description: Checkout and learn about getting started with ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started with ASP.NET MVC Rich Text Editor Control

This section briefly explains about how to include [ASP.NET MVC Rich Text Editor](https://www.syncfusion.com/aspnet-mvc-ui-controls/wysiwyg-rich-text-editor) control in your ASP.NET MVC application using Visual Studio.

## Prerequisites

[System requirements for ASP.NET MVC controls](https://ej2.syncfusion.com/aspnetmvc/documentation/system-requirements)

## Create ASP.NET MVC application with HTML helper

* [Create a Project using Microsoft Templates](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-6.0&tabs=visual-studio)

* [Create a Project using Syncfusion ASP.NET MVC Extension](https://ej2.syncfusion.com/aspnetmvc/documentation/getting-started/project-template)

## Install ASP.NET MVC package in the application

Syncfusion ASP.NET MVC controls are available in [nuget.org.](https://www.nuget.org/packages?q=syncfusion.EJ2) Refer to [NuGet packages topic](https://ej2.syncfusion.com/aspnetmvc/documentation/nuget-packages) to learn more about installing NuGet packages in various OS environments. To add ASP.NET MVC controls in the application, open the NuGet package manager in Visual Studio (Tools → NuGet Package Manager → Manage NuGet Packages for Solution), search for [Syncfusion.EJ2.MVC5](https://www.nuget.org/packages/Syncfusion.EJ2.MVC5) and then install it.

> The Syncfusion.EJ2.MVC5 NuGet package has dependencies, [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON serialization and [Syncfusion.Licensing](https://www.nuget.org/packages/Syncfusion.Licensing/) for validating Syncfusion license key.

> If you create ASP.NET MVC application with MVC4 package, search for [Syncfusion.EJ2.MVC4](https://www.nuget.org/packages/Syncfusion.EJ2.MVC4) and then install it. 

## Add namespace

Add **Syncfusion.EJ2** namespace reference in `Web.config` under `Views` folder.

```
<namespaces>
    <add namespace="Syncfusion.EJ2"/>
</namespaces>
```

## Add style sheet

Checkout the [Themes topic](https://ej2.syncfusion.com/aspnetmvc/documentation/appearance/theme) to learn different ways (CDN, NPM package, and [CRG](https://ej2.syncfusion.com/aspnetmvc/documentation/common/custom-resource-generator)) to refer styles in ASP.NET MVC application, and to have the expected appearance for Syncfusion ASP.NET MVC controls. Here, the theme is referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls styles -->
    <link rel="stylesheet" href="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/fluent.css" />
</head>

{% endhighlight %}
{% endtabs %}

## Add script reference

In this getting started walk-through, the required scripts are referred using CDN inside the `<head>` of `~/Views/Shared/_Layout.cshtml` file as follows,

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<head>
    ...
    <!-- Syncfusion ASP.NET MVC controls scripts -->
    <script src="https://cdn.syncfusion.com/ej2/{{ site.ej2version }}/dist/ej2.min.js"></script>
</head>

{% endhighlight %}
{% endtabs %}

## Register Syncfusion Script Manager

Open `~/Views/Shared/_Layout.cshtml` page and register the script manager `EJS().ScriptManager()` at the end of `<body>` in the ASP.NET MVC application as follows. 

{% tabs %}
{% highlight c# tabtitle="~/_Layout.cshtml" %}

<body>
...
    <!-- Syncfusion ASP.NET MVC Script Manager -->
    @Html.EJS().ScriptManager()
</body>

{% endhighlight %}
{% endtabs %}

## Add ASP.NET MVC Rich Text Editor control

Now, add the Syncfusion ASP.NET MVC Rich Text Editor control in `~/Views/Home/Index.cshtml` page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/default/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/default/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

Press <kbd>Ctrl</kbd>+<kbd>F5</kbd> (Windows) or <kbd>⌘</kbd>+<kbd>F5</kbd> (macOS) to run the app. Then, the Syncfusion ASP.NET MVC Rich Text Editor control will be rendered in the default web browser.

![ASP.NET MVC Rich Text Editor Control](images/richtexteditor-control.png)

### Initialize from iframe element

Initialize the Rich Text Editor on `<div>` element as shown below and set the enable field of [`IframeSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_IframeSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorIFrameSettings_) property as true to render the Rich Text Editor content in an `<iframe>` and its isolated from the rest of the page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/iframe/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/iframe/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/iframe/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Rich Text Editor with IFrame Element](images/richtexteditor-iframe-element.png)

## Configure the Toolbar

Configure the toolbar with the tools using items field of the [`ToolbarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditorBuilder.html#Syncfusion_EJ2_RichTextEditor_RichTextEditorBuilder_ToolbarSettings_Syncfusion_EJ2_RichTextEditor_RichTextEditorToolbarSettings_) property as your application requires.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/toolbar/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/toolbar/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/toolbar/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public ActionResult Index()
{
    List<string> tools = new List<string>() {
        "Bold", "Italic", "Underline", "StrikeThrough",
        "FontName", "FontSize", "FontColor", "BackgroundColor",
        "LowerCase", "UpperCase", "|",
        "Formats", "Alignments", "OrderedList", "UnorderedList",
        "Outdent", "Indent", "|",
        "CreateLink", "Image", "CreateTable", "|", "ClearFormat", "Print",
        "SourceCode", "FullScreen", "|", "Undo", "Redo"
    };
    return View(tools);
}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET Rich Text Editor with Toolbar](images/richtexteditor-with-toolbar.png)

> `|` and `-` can insert a vertical and horizontal separator lines in the toolbar.

## Insert Images and Links

The `Image` module inserts an image into Rich Text Editor’s content area, and the `Link` module links external resources such as website URLs, to selected text in the Rich Text Editor’s content, respectively.

The link inject module adds a link icon to the toolbar and the image inject module adds an image icon to the toolbar.

Specifies the items to be rendered in quick toolbar based on the target element such image, link and text element. The quick toolbar opens to customize the element by clicking the target element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/image/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/image/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/image/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public ActionResult Index()
{
    ViewBag.image = new[] {
        "Replace", "Align", "Caption", "Remove", "InsertLink", "OpenImageLink", "-",
        "EditImageLink", "RemoveImageLink", "Display", "AltText", "Dimension"
    };
    List<string> tools = new List<string>() {
        "Bold", "Italic", "Underline", "StrikeThrough",
        "FontName", "FontSize", "FontColor", "BackgroundColor",
        "LowerCase", "UpperCase", "|",
        "Formats", "Alignments", "OrderedList", "UnorderedList",
        "Outdent", "Indent", "|",
        "CreateLink", "Image", "CreateTable", "|", "ClearFormat", "Print",
        "SourceCode", "FullScreen", "|", "Undo", "Redo"
    };
    return View(tools);
}
{% endhighlight %}
{% endtabs %}
{% endif %}

![ASP.NET MVC Rich Text Editor with Image](images/richtexteditor-with-image.png)

## Send formatted content using XmlHttpRequest

The Html string of the Rich Text Editor can be passed from View to the Controller through the `XMLHttpRequest` `Post` action. The HTML value binds to the corresponding mapped controller, and you can access it in the Post action parameter.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/rtevalue/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="MvcController.cs" %}
{% include code-snippet/rich-text-editor/basic/rtevalue/mvcController.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/rtevalue/razor %}
{% endhighlight %}
{% endtabs %}
{% endif %}



## Retrieve the Formatted Content

To retrieve the editor contents, use [`value`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_Value) property of Rich Text Editor.

```javascript
  var rteValue = this.rteObj.value;
```

Or, you can use the public method, `getHtml` to retrieve the Rich Text Editor content.

```javascript
  var rteValue = this.rteObj.getHtml();
```

To fetch the Rich Text Editor's text content, use `getText` method of Rich Text Editor.

```javascript
  var rteValue = this.rteObj.getText();
```

## Retrieve the number of characters

To get the maximum number of characters in the Rich Text Editor's content, use `getCharCount`

```typescript
  let rteCount = this.rteObj.getCharCount();
```

The final output will be displayed as follows

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/link/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/basic/link/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/basic/link/razor %}
{% endhighlight %}
{% highlight c# tabtitle="HomeController.cs" %}
public ActionResult Index()
{
    List<string> tools = new List<string>() {
        "Bold", "Italic", "Underline", "StrikeThrough",
        "FontName", "FontSize", "FontColor", "BackgroundColor",
        "LowerCase", "UpperCase", "|",
        "Formats", "Alignments", "OrderedList", "UnorderedList",
        "Outdent", "Indent", "|",
        "CreateLink", "Image", "CreateTable", "|", "ClearFormat", "Print",
        "SourceCode", "FullScreen", "|", "Undo", "Redo"
    };
    return View(tools);
}
{% endhighlight %}
{% endtabs %}
{% endif %}



> You can refer to our [ASP.NET MVC Rich Text Editor](https://www.syncfusion.com/aspnet-mvc-ui-controls/wysiwyg-rich-text-editor) feature tour page for its groundbreaking feature representations. You can also explore our [ASP.NET MVC Rich Text Editor example](https://ej2.syncfusion.com/aspnetmvc/RichTextEditor/DefaultFunctionalities#/material) that shows how to render the rich text editor tools.

## See also

* [Real time example using Rich Text Editor](https://ej2.syncfusion.com/aspnetmvc/RichTextEditor/Forums#/bootstrap5)
* [How to insert Emoticons](https://ej2.syncfusion.com/aspnetmvc/RichTextEditor/InsertEmoticons#/material)
* [How to change the editor type](./formation/)
* [How to render the iframe](./iframe/)
* [How to render the toolbar in inline mode](./inline-mode/)