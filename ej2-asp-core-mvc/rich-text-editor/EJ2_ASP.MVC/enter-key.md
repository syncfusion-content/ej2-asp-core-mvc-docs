---
layout: post
title: Enter Key in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Enter Key in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: Enter Key
publishingplatform: ##Platform_Name##
documentation: ug
---


# Enter and Shift-Enter Key's Customization

Rich Text Editor allows to customize the tag that is inserted when pressing the enter key and shift + enter key in the Rich Text Editor.

## Enter key customization

By default, the `<p>` tag will be created while pressing the enter key. The enter key can be customized by using the [`EnterKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_EnterKey) property, where the possible tags that can be used to customize are `<p>`, `<div>`, and `<br>`.

When the enter key is customized with any of the possible values, pressing the enter key in the editor will create a new tag that is configured. Also, when the enter key is configured the default value of the Rich Text Editor will also change respectively with the configured values.

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



## Shift-Enter key customization

By default, the `<br>` tag will be created while pressing the shift + enter key. The shift + enter key can be customized by using the [`ShiftEnterKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.RichTextEditor.RichTextEditor.html#Syncfusion_EJ2_RichTextEditor_RichTextEditor_ShiftEnterKey) property where the possible tags that can be used to customize are `<br>`, `<p>`, `<div>`.  

When the shift + enter key is customized with any of the possible values, pressing the shift + enter key in the editor will create a new tag that is configured. Also, when the shift + enter key is configured the default value of the Rich Text Editor will change respectively with the configured values.

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

