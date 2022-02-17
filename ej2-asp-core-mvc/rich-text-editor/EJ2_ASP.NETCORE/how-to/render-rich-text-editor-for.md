---
layout: post
title: Render Rich Text Editor For in ##Platform_Name## Rich Text Editor Component
description: Learn here all about Render Rich Text Editor For in Syncfusion ##Platform_Name## Rich Text Editor component and more.
platform: ej2-asp-core-mvc
control: Render Rich Text Editor For
publishingplatform: ##Platform_Name##
documentation: ug
---


# Render the RichTextEditorFor control

The RichTextEditorFor control can be rendered by passing values from the controller.  The formatted Rich Text Editor value is retrieved when submitting the form using the post method.

In the following sample, the RichTextEditorFor control is rendered.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/rtefor/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/how-to/rtefor/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/how-to/rtefor/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/how-to/rtefor/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![RichTextEditorFor](../../rich-text-editor/images/rteFor.PNG)