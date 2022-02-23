---
title: "Tab Localization"
component: "Tab"
description: "Tab localization section explains how to localize the tab based on culture and set close button's tooltip text."
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