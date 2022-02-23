---
title: "Localization"
component: "Dialog"
description: "Explains how to localize the static text (built-in text) content of the dialog control such as close button's tooltip text."
---

# Localization

Localization library allows to localize the default text content of
Dialog. In Dialog, The close button's tooltip text alone will be localize based on culture.

| Locale key | en-US (default)  |
|------|------|
| close |  close |

## Loading translations

To load translation object in an application use `load` function of `L10n` class.

In the below sample, `French` culture is set to Dialog and change the close button's tooltip
text.

{% aspTab template="dialog/localization", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![dialog](./images/dialog-locale.png)