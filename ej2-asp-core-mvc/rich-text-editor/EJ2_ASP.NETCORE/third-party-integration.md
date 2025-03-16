---
layout: post
title: Third Party Integration in ##Platform_Name## Rich Text Editor Control
description: Learn here all about Third Party Integration in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Third Party Integration
publishingplatform: ##Platform_Name##
documentation: ug
---

# Third party integration in ##Platform_Name## Rich text editor Control

The Rich Text Editor can be integrated with third-party to suite the application scenario.

## CodeMirror Integration

RichTextEditor comes with a basic HTML source editor through the view-source property. CodeMirror plugin can be used to highlight the syntax of HTML. CodeMirror plugin for Rich Text Editor makes editing of HTML source code with a pleasant experience.

Import necessary CSS and JS files of CodeMirror to the HTML page.

Required JS files of code mirror.

```html
 <script src="scripts/CodeMirror/codemirror.js" type="text/javascript"></script>
 <script src="scripts/CodeMirror/javascript.js" type="text/javascript"></script>
 <script src="scripts/CodeMirror/css.js" type="text/javascript"></script>
 <script src="scripts/CodeMirror/htmlmixed.js" type="text/javascript"></script>

```

Required CSS file of code mirror

```html
 <link href="scripts/CodeMirror/codemirror.min.css" rel="stylesheet" />

```

Add a custom icon for HTML source editor in the toolbar of Rich Text Editor using the template option of [toolbarSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings), define the code mirror plugins, and then pass the Rich Text Editor content as argument in the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ActionComplete) event.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/code-mirror/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/code-mirror/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/code-mirror/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/code-mirror/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## At.js Integration

Rich Text Editor can easily be integrated with [`At.js`](https://github.com/ichord/At.js) library. To display the autocomplete list, type ‘@’.

Include `At.JS` style.

```html

 <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/at.js/1.4.0/css/jquery.atwho.min.css">

```

Include At.JS javascript.

```html

<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/at.js/1.4.0/js/jquery.atwho.min.js"></script>

```

Define the `At.js` configuration

N> In below configuration, email id of employees list - email id of employees from the data source.

```typescript

var config = {
    at: "@",
    data: [email id of employees list],
    displayTpl: '<li>${name} <small>${email}</small></li>',
    limit: 200
  }

```

Populate the employee’s email id from local or remote data and set the result to the data of `At.js` configuration.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/at-integration/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/at-integration/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/at-integration/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/at-integration/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Embedly Integration

This can be achieved by binding the [actionComplete](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ActionComplete) event to the toolbar items in the [toolbarSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings) property. In the event handler, create an element and add the appropriate class. The below script is have to add in the sample to embed the content,

Include `embedly` javascript.

```html

<script src="https://cdn.embedly.com/widgets/platform.js" charset="UTF-8"></script>

```

The above script is added to the page.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/embed-ly/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/embed-ly/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/embed-ly/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/embed-ly/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}