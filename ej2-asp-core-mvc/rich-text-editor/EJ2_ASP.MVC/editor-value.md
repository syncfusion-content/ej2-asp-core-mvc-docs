---
layout: post
title: Editor value in ##Platform_Name## Rich Text Editor Control | Syncfusion
description: Learn here all about Editor value in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Editor value
publishingplatform: ##Platform_Name##
documentation: ug
---

# Editor value in ##Platform_Name## Rich Text Editor Control

## Get and Set Value

**Setting Values**

You can set the initial content of the Rich Text Editor using the `value` property. There are two methods to accomplish this:

* Using the [Value](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_Value) property directly.

* Using the [ValueTemplate](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ValueTemplate) property allows you to customize the content of the Rich Text Editor.

**Retrieving Values**

To retrieve the editor contents, use the value property of Rich Text Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/retrieve-value/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/retrieve-value/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/retrieve-value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/retrieve-value/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Auto save

The auto-save option in the Rich Text Editor allows the content to be automatically saved during idle periods after you have typed. Once this option is enabled, the editor will save the content based on the [SaveInterval](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_SaveInterval) property's value, which is specified in milliseconds.

The change event will be triggered if the content has been modified since the last saved state, ensuring consistent tracking of changes without manual intervention.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/save-interval/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/save-interval/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/save-interval/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/save-interval/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Programmatic Content Access 

You can use the `GetHtml` public method to retrieve the Rich Text Editor content.

```cs
  var editorValue = document.getElementById("defaultRTE").ej2_instances[0].GetHtml();

```

To fetch the Rich Text Editor's text content, use `GetText` method.

```cs
  var editorValue = document.getElementById("defaultRTE").ej2_instances[0].GetText();

```

## Encoded Editor Value

The [EnableHtmlEncode](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_EnableHtmlEncode) property in the Rich Text Editor specifies whether the source code is displayed in an encoded format. Additionally, the [Value](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_Value) property also returns the content in an encoded format. This feature is particularly useful when you want to ensure that HTML content is displayed safely without being interpreted by the browser.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/encoded-editor-value/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/encoded-editor-value/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/encoded-editor-value/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/encoded-editor-value/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Styling Editor Content

By default, the content styles of the Rich Text Editor are not included when retrieving the HTML value from the editor. This can result in the styles not being applied when using the HTML content outside of the editor. To ensure that the styles are correctly applied, you can copy and use the following styles directly in your application: These styles are used in the UI elements of the Rich Text Editor.

N> Make sure to add a CSS class ‘e-rte-content’ to the content container.

```css

.e-rte-content p {
  margin: 0 0 10px;
  margin-bottom: 10px;
}

.e-rte-content li {
  margin-bottom: 10px;
}

.e-rte-content h1 {
  font-size: 2.17em;
  font-weight: 400;
  line-height: 1;
  margin: 10px 0;
}

.e-rte-content h2 {
  font-size: 1.74em;
  font-weight: 400;
  margin: 10px 0;
}

.e-rte-content h3 {
  font-size: 1.31em;
  font-weight: 400;
  margin: 10px 0;
}

.e-rte-content h4 {
  font-size: 1em;
  font-weight: 400;
  margin: 0;
}

.e-rte-content h5 {
  font-size: 00.8em;
  font-weight: 400;
  margin: 0;
}

.e-rte-content h6 {
  font-size: 00.65em;
  font-weight: 400;
  margin: 0;
}

.e-rte-content blockquote {
  margin: 10px 0;
  margin-left: 0;
  padding-left: 5px;
}

.e-rte-content pre {
  background-color: inherit;
  border: 0;
  border-radius: 0;
  color: #333;
  font-size: inherit;
  line-height: inherit;
  margin: 0 0 10px;
  overflow: visible;
  padding: 0;
  white-space: pre-wrap;
  word-break: inherit;
  word-wrap: break-word;
}

.e-rte-content strong, .e-rte-content b {
  font-weight: 700;
}

.e-rte-content a {
  text-decoration: none;
  -webkit-user-select: auto;
  -ms-user-select: auto;
  user-select: auto;
}

.e-rte-content a:hover {
  text-decoration: underline;
}

.e-rte-content h3 + h4,
.e-rte-content h4 + h5,
.e-rte-content h5 + h6 {
  margin-top: 00.6em;
}

.e-rte-content .e-rte-table {
  border-collapse: collapse;
  empty-cells: show;
}

.e-rte-content .e-rte-table td,
.e-rte-content .e-rte-table th {
  border: 1px solid #bdbdbd;
  height: 20px;
  min-width: 20px;
  padding: 2px 5px;
  vertical-align: middle;
}

.e-rte-content .e-rte-table.e-dashed-border td,
.e-rte-content .e-rte-table.e-dashed-border th {
  border-style: dashed;
}

.e-rte-image.e-img-inline,
.e-img-caption-container.e-img-inline {
  margin-left: 5px;
  margin-right: 5px;
  display: inline-block;
  float: none;
  max-width: 100%;
  padding: 1px;
  vertical-align: bottom;
}

.e-rte-image.e-img-center,
.e-rte-image.e-img-break,
.e-img-caption-container.e-img-center,
.e-img-caption-container.e-img-break {
  cursor: pointer;
  display: block;
  float: none;
  margin: 5px auto;
  max-width: 100%;
  position: relative;
}

.e-rte-content .e-rte-image.e-img-left-wrap,
.e-rte-content .e-img-caption-container.e-img-left-wrap {
  float: left;
  margin: 5px 5px 5px 0;
}

.e-rte-content .e-rte-image.e-img-right-wrap,
.e-rte-content .e-img-caption-container.e-img-right-wrap {
  float: right;
  margin: 5px 0 5px 5px;
}

.e-rte-content .e-rte-image.e-img-left,
.e-rte-content .e-rte-image.e-img-right,
.e-rte-content .e-img-caption-container.e-img-left,
.e-rte-content .e-img-caption-container.e-img-right {
  margin-top: 5px;
  margin-bottom: 5px;
}

.e-rte-content .e-rte-image.e-img-right,
.e-rte-content .e-img-caption-container.e-img-right {
  margin-right: 0;
  margin-left: auto;
}

.e-rte-content .e-rte-image.e-img-left,
.e-rte-content .e-img-caption-container.e-img-left {
  margin-left: 0;
  margin-right: auto;
}

.e-rte-content .e-img-caption-container.e-img-left-wrap,
.e-rte-content .e-img-caption-container.e-img-left-wrap {
  display: inline-block;
}

.e-rte-content .e-img-caption-container.e-img-left,
.e-rte-content .e-img-caption-container.e-img-left {
  display: block;
}

.e-rte-content .e-img-caption-container {
  max-width: 100%;
  position: relative;
}

.e-rte-content .e-img-caption-container .e-img-caption-text {
  box-sizing: border-box;
  display: block;
  font-size: 16px;
  font-weight: 400;
  margin: auto;
  opacity: .9;
  position: relative;
  text-align: center;
  width: 100%;
}

.e-rte-content .e-img-caption-container.e-img-left-wrap .e-img-wrap img,
.e-rte-content .e-img-caption-container.e-img-right-wrap .e-img-wrap img,
.e-rte-content .e-img-caption-container.e-img-left .e-img-wrap img,
.e-rte-content .e-img-caption-container.e-img-right .e-img-wrap img,
.e-rte-content .e-img-caption-container.e-img-center .e-img-wrap img,
.e-rte-content .e-img-caption-container.e-img-break .e-img-wrap img {
  margin-bottom: 0;
}

.e-rte-content .e-img-caption-container.e-img-center,
.e-rte-content .e-img-caption-container.e-img-break {
  margin-left: auto;
  margin-right: auto;
}

.e-rte-content blockquote {
  border-left: solid 2px #333;
}

.e-rte-content a {
  color: #2e2ef1;
}

.e-rte-content .e-rte-table th {
  background-color: #e0e0e0;
}

```

## See Also

* [Implementing Prevention of cross-site scripting (XSS)](./prevent-cross-site-scripting)