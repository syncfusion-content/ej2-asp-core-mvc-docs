---
layout: post
title: Third Party Integration in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Third Party Integration in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: Third Party Integration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Third party Integration

The Rich Text Editor can be integrated with third-party to suite the application scenario.

## Code-Mirror Integration

Rich Text Editor comes with a basic HTML source editor through view-source property. [`Code mirror`](https://codemirror.net/) plugin can be used to highlight the syntax of HTML. CodeMirror plugin for Rich Text Editor makes editing of HTML source code with a pleasant experience.

Import necessary CSS and JS files of CodeMirror to the HTML page.

Required JS files of code mirror.

```html
 <script src="scripts/CodeMirror/codemirror.js" type="text/javascript"></script>
 <script src="scripts/CodeMirror/javascript.js" type="text/javascript"></script>
 <script src="scripts/CodeMirror/css.js" type="text/javascript"></script>
 <script src="scripts/CodeMirror/htmlmixed.js" type="text/javascript"></script>

```

Required CSS file of code mirror.

```html
 <link href="scripts/CodeMirror/codemirror.min.css" rel="stylesheet" />

```

Add a custom icon for HTML source editor in the toolbar of Rich Text Editor using template option of [`ToolbarSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ToolbarSettings) and define the code mirror plugins, and then pass the Rich Text Editor content as argument in [`ActionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ActionComplete) event.

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

> In below configuration, email id of employees list - email id of employees from the data source.

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



## Embed.ly Integration

Rich Text Editor easily integrate with [`Embed.ly`](https://embed.ly/) which is probably the best service when it comes to embed the rich content such as Twitter, Facebook, Instagram and lots of other publishing platform embeds.

```html

<script src="https://cdn.embedly.com/widgets/platform.js" charset="UTF-8"></script>

```

In the following sample, the `Embed.ly` class `embedly-card` has been added to `<a>` tag in [`ActionComplete`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ActionComplete) event.

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

