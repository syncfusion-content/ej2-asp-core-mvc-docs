---
title: "Globalization"
component: "In-place Editor"
description: "Learn how to apply localization (l10n), internationalization (i18n), and right-to-left (RTL) format in the Syncfusion ASP.NET MVC In-place Editor control."
---

# Globalization

## Localization

Localization library allows you to localize the default text content of the In-place Editor to different cultures using the [`Locale`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Locale) property. In-place Editor following keys will be localize based on culture.

| Locale key | en-US (default) |
|------|------|
| save | Close |
| cancel | Cancel |
| loadingText | Loading... |
| editIcon | Click to edit |
| editAreaClick | Click to edit |
| editAreaDoubleClick | Double click to edit |

To load translation object in an application use `load` function of `L10n` class. In the following sample, `French` culture is set to In-place Editor and change the tooltip text.

{% aspTab template="in-place-editor/editable", sourceFiles="controller.cs" %}

{% endaspTab %}

The output will be as follows.

![editable](./images/editable.png)

## Right to left

Specifies the direction of the In-place Editor control using the [`EnableRtl`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_EnableRtl) property. For writing systems that require it like Arabic, Hebrew, etc., the direction can be switched to right-to-left.

> It will not change based on the locale property.

{% aspTab template="in-place-editor/default", sourceFiles="controller.cs" %}

{% endaspTab %}

The output will be as follows.

![default](./images/default.PNG)

## Format

Formatting is a way of representing the value in different format. You can format the following mentioned controls with its `format` property, when it passed through the In-place Editor [`Model`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Model) property.

* DatePicker
* DateRangePicker
* DateTimePicker
* NumericTextBox
* Slider
* TimePicker

{% aspTab template="in-place-editor/format", sourceFiles="controller.cs" %}

{% endaspTab %}

The output will be as follows.

![format](./images/format.PNG)