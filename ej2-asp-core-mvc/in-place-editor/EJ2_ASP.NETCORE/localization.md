---
layout: post
title: Localization in ##Platform_Name## InplaceEditor | Syncfusion
description: Localize Syncfusion ##Platform_Name## InplaceEditor default text and toolbar strings using locale values and translation objects for Arabic, German, and French cultures.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Localization in ##Platform_Name## InplaceEditor

## Localization

Localization library allows you to localize the default text content of the In-place Editor to different cultures using the [`locale`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Locale) property. In-place Editor following keys will be localize based on culture.

| Locale key | en-US (default) |
|------|------|
| save | Close |
| cancel | Cancel |
| loadingText | Loading... |
| editIcon | Click to edit |
| editAreaClick | Click to edit |
| editAreaDoubleClick | Double click to edit |

To load translation object in an application use `load` function of `L10n` class. In the following sample, `French` culture is set to In-place Editor and change the tooltip text.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/editable/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/editable/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/editable/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/editable/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![editable](./images/editable.png)

## Right to left

Specifies the direction of the In-place Editor control using the [`enableRtl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_EnableRtl) property. For writing systems that require it like Arabic, Hebrew, etc., the direction can be switched to right-to-left.

N> It will not change based on the locale property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/default/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/default/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/default/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/default/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![default](./images/default.PNG)

## Format

Formatting is a way of representing the value in different format. You can format the following mentioned controls with its `format` property, when it passed through the In-place Editor [`model`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Model) property.

* DatePicker
* DateRangePicker
* DateTimePicker
* NumericTextBox
* Slider
* TimePicker

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/format/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/format/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/format/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/format/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![format](./images/format.PNG)