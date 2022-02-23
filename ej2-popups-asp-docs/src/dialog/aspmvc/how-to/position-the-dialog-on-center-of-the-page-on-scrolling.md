---
title: "Position the Dialog in center of the page on scrolling"
component: "Dialog"
description: "Covers customization features such as load content to the dialog from external sources, built-in alert, and confirmation model dialog."
---

# Position the Dialog in center of the page on scrolling

By default, when scroll the page/container Dialog also scrolled along with the page/container.
When a user expects to display the Dialog in the same position without scrolling achieving this in
sample level as like below. Here added 'e-fixed' class to Dialog element and prevent the scrolling.

{% aspTab template="dialog/how-to/scrolling", sourceFiles="controller.cs" %}

{% endaspTab %}