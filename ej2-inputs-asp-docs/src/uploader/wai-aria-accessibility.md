---
title: "wai-aria-accessibility"
component: "Uploader"
description: "Describes the accessibility standard of the file upload control such as WAI-ARIA attributes, keyboard interaction, theming, etc."
---

# Accessibility

The uploader control characterized with complete ARIA accessibility support that helps to be accessible by on-screen readers and other assistive technology devices.

## Keyboard interaction

The following are the standard keys that works on uploader control:

| **Keyboard shortcuts** | **Actions** |
| --- | --- |
| <kbd>Tab</kbd> | Moves focus to next element. |
| <kbd>Shift + Tab</kbd> | Moves focus to previous element. |
| <kbd>Enter</kbd> | Triggers corresponding action to the button element. |
| <kbd>Esc</kbd> | Closes the file browser dialog alone and cancels the upload on drop the file. |

{% aspTab template="uploader/keyboard", sourceFiles="keyboard.cs,index.css" %}

{% endaspTab %}