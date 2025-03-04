---
layout: post
title: Text Alignments in ##Platform_Name## Rich Text Editor control
description: Learn here all about Text Alignments in Syncfusion ##Platform_Name## Rich Text Editor control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Text Alignments
publishingplatform: ##Platform_Name##
documentation: ug
---

# Text Alignments in the ##Platform_Name## Rich Text Editor Control

The Rich Text Editor offers various text alignment options, including left, center, right, and justify. To utilize these alignment options, add the Alignments item to the items property in the toolbarSettings.

> **Important Note:** Text alignment is applied to the entire block element containing the cursor or selected text, not just to the selected text itself. When you apply an alignment, it affects the whole paragraph or block, even if you've only selected a portion of the text.

Here are the available alignment options:

* Align Left:
To left-align your text, place the cursor in the desired paragraph or select any text within it, then click the `Align Left` icon in the toolbar. This will align the entire paragraph with the left margin.

* Align Center:
To center-align your text, place the cursor in the desired paragraph or select any text within it, then click the `Align Center` icon in the toolbar. This will center the entire paragraph within its container.

* Align Right:
To right-align your text, place the cursor in the desired paragraph or select any text within it, then click the `Align Right` icon in the toolbar. This will align the entire paragraph with the right margin.

* Align Justify:
To fully justify your text, place the cursor in the desired paragraph or select any text within it, then click the `Align Justify` icon in the toolbar. This will distribute the entire paragraph evenly across the line, aligning it with both the left and right margins.

Please refer to the sample and code snippets below to add these alignment options in the Rich Text Editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/text-alignments/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/text-alignments/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/rich-text-editor/text-alignments/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/rich-text-editor/text-alignments/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}
