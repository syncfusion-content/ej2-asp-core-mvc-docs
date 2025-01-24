---
layout: post
title: Customize Color Picker in Syncfusion  ##Platform_Name## Document Editor Component
description: Learn here all about how to customize color picker in Syncfusion ##Platform_Name## Document Editor component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Customize Color Picker
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to customize the color picker in Document Editor component

Document editor provides an options to customize the color picker using `colorPickerSettings` in Document editor settings. The color picker offers customization options for default appearance, by allowing selection between Picker or Palette mode, for font and border colors."

Similarly, you can use `documentEditorSettings` property for DocumentEditor also.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/customize-color-picker/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="customize-color-picker.cs" %}
{% endhighlight %}{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/document-editor-container/customize-color-picker/razor %}
{% endhighlight %}
{% highlight c# tabtitle="customize-color-picker.cs" %}
{% endhighlight %}{% endtabs %}
{% endif %}

The following table illustrates all the possible properties for the color picker.

| Property | Behaviour |
|---|---|
| columns | It is used to render the ColorPicker palette with specified columns. Defaults to 10 |
| disabled | It is used to enable / disable ColorPicker component. If it is disabled the ColorPicker popup won’t open. Defaults to false |
| mode | It is used to render the ColorPicker with the specified mode. Defaults to ‘Picker’ |
| modeSwitcher | It is used to show / hide the mode switcher button of ColorPicker component. Defaults to true |
| showButtons | It is used to show / hide the control buttons (apply / cancel) of ColorPicker component. Defaults to true |


>**Note**: According to the Word document specifications, it is not possible to modify the predefined highlight colors.