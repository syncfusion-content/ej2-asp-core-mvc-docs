---
layout: post
title: Customize Font Family Drop Down in ##Platform_Name## Document Editor Component
description: Learn here all about how to customize font family drop down in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customize Font Family Drop Down
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to customize the font family drop down in React Document Editor component

Document editor provides options to customize the font family drop down list values using `fontfamilies` in Document editor settings. Fonts which are added in `fontFamilies` of [`documentEditorSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html#Syncfusion_EJ2_DocumentEditor_DocumentEditor_DocumentEditorSettings) will be displayed on font drop down list of text properties pane and font dialog.

Similarly, you can use [`documentEditorSettings`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DocumentEditor.DocumentEditor.html#Syncfusion_EJ2_DocumentEditor_DocumentEditor_DocumentEditorSettings) property for DocumentEditor also.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/font-family/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Font-family.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/font-family/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Font-family.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

![Font](../images/font-family.png)