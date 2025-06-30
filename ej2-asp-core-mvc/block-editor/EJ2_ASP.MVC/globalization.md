---
layout: post
title: Globalization in ##Platform_Name## Block Editor Control | Syncfusion
description: Checkout and learn about Globalization with Syncfusion Essential ##Platform_Name## BlockEditor control, its elements, and more details.
platform: ej2-asp-core-mvc
control: Block Editor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Globalization in ##Platform_Name## Block Editor control

## Localization

The Block Editor can be localized to any culture by defining the text of the Block Editor in the corresponding culture. The default locale of the Block Editor is `en` (English). The following table represents the default text of the Block Editor in `en` culture.

|KEY|Text|
|----|----|
|`paragraph`|Write something or '/' for commands.|
|`heading1`|Heading 1|
|`heading2`|Heading 2|
|`heading3`|Heading 3|
|`heading4`|Heading 4|
|`toggleParagraph`|Toggle Paragraph|
|`toggleHeading1`|Toggle Heading 1|
|`toggleHeading2`|Toggle Heading 2|
|`toggleHeading3`|Toggle Heading 3|
|`toggleHeading4`|Toggle Heading 4|
|`bulletList`|Add item|
|`numberedList`|Add item|
|`checkList`|Todo|
|`callout`|Write a callout|
|`addIconTooltip`|Click to insert below|
|`dragIconTooltipActionMenu`|Click to open|
|`dragIconTooltip`|(Hold to drag)|
|`insertLink`|Insert Link|
|`linkText`|Text|
|`linkTextPlaceholder`|Link text|
|`linkUrl`|URL|
|`linkUrlPlaceholder`|https://example.com|
|`linkTitle`|Title|
|`linkTitlePlaceholder`|Link title|
|`linkOpenInNewWindow`|Open in new window|
|`linkInsert`|Insert|
|`linkRemove`|Remove|
|`linkCancel`|Cancel|
|`codeCopyTooltip`|Copy code|

The below example shows adding the German culture locale(`de-DE`)

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/globalization/locale/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Locale.cs" %}
{% include code-snippet/block-editor/globalization/locale/locale.cs %}
{% endhighlight %}
{% endtabs %}

![Locale](images/locale.png)

## RTL

RTL provides an option to switch the text direction and layout of the Block Editor control from right to left by setting the `enableRtl` property to `true`.

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/block-editor/globalization/rtl/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Rtl.cs" %}
{% include code-snippet/block-editor/globalization/rtl/rtl.cs %}
{% endhighlight %}
{% endtabs %}

![RTL](images/rtl.png)
