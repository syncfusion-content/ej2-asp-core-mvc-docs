---
layout: post
title: Enter Key in ##Platform_Name## Rich Text Editor Control
description: Learn here all about Enter Key in Syncfusion ##Platform_Name## Rich Text Editor Control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Enter Key
publishingplatform: ##Platform_Name##
documentation: ug
---

# Enter key Configuration in ##Platform_Name## Rich Text Editor Control

Rich Text Editor allows you to customize the behavior of the Enter key and Shift+Enter key combinations. This feature provides flexibility in formatting and structuring content within the editor.

**Available Options**

The enterKey property accepts the following values:

* `P` (default)
* `DIV`
* `BR`

The shiftEnterKey property accepts the following values:

* `BR` (default)
* `P`
* `DIV`

## Enter key Customization

By default, pressing the Enter key in the Rich Text Editor creates a new `<p>` tag. You can customize this behavior using the [enterKey](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_EnterKey) property.

When you customize the Enter key, the editor will create the specified tag when the Enter key is pressed. This configuration also affects the default content structure of the Rich Text Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/enter-key/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/enter-key/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/enter-key/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/enter-key/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Shift+Enter key Customization

By default, pressing Shift+Enter in the Rich Text Editor inserts a `<br>` tag. You can customize this behavior using the [shiftEnterKey](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ShiftEnterKey) property.

When you customize the Shift+Enter key, the editor will create the specified tag when the key combination is pressed. This configuration also affects the default content structure of the Rich Text Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/shift-enter-key/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/shift-enter-key/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/shift-enter-key/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/shift-enter-key/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Preventing Enter Key Manipulation

In some cases, you may want to prevent the default Enter key behavior entirely. The Rich Text Editor allows you to intercept and prevent the default action of the Enter key at the editor level by handling the [actionBegin](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ActionBegin) event. To ensure that the default behavior is also suppressed at the browser level, you need to call the `preventDefault()` method on the event object within the event handler. This approach allows for precise control over the editor's behavior in response to the Enter key press, facilitating the implementation of custom functionality.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/prevent-enter-key/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/prevent-enter-key/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/prevent-enter-key/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/prevent-enter-key/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}