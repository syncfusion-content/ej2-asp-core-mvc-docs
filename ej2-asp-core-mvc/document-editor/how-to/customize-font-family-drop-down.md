---
layout: post
title: Customize Font Family Drop Down in ##Platform_Name## Document Editor Component
description: Learn here all about Customize Font Family Drop Down in Syncfusion ##Platform_Name## Document Editor component and more.
platform: ej2-asp-core-mvc
control: Customize Font Family Drop Down
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to customize the font family drop down in React Document Editor component

Document editor provides an options to customize the font family drop down list values using `fontfamilies` in Document editor settings. Fonts which are added in `fontFamilies` of `documentEditorSettings` will be displayed on font drop down list of text properties pane and font dialog.

Similarly, you can use `documentEditorSettings` property for DocumentEditor also.

The following example code illustrates how to change the font families in Document editor container.

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



Output will be like below:

![Font](../images/font-family.png)