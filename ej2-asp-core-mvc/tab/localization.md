---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Localization of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Localization

Localization library allows to localize the default text content of
Tab. In Tab, The close button's tooltip text alone will be localize based on culture.

| Locale key | en-US (default) |
|------|------|
| closeButtonTitle | Close |

## Loading translations

To load translation object in an application use `load` function of `L10n` class.

In the below sample, `French` culture is set to Tab and change the close button's tooltip
text.

{% aspTab template="tab/localization", sourceFiles="Localization.cs" %}

{% endaspTab %}