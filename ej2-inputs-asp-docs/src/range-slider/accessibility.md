---
title: "Slider Accessibility"
component: "Slider"
description: "Slider control has accessibility support to help access the features via keyboard, on-screen readers, or other assistive technology devices."
---

# Accessibility

The Slider is characterized with complete ARIA Accessibility support that helps to access by on-screen readers and other assistive technology devices. This control is designed with the reference of guidelines document given in the [WAI ARAI Accessibility Practices](https://www.w3.org/TR/wai-aria-practices/#slider).

The Slider control uses the Slider role and the following ARIA properties for its element based on the state.

| **Properties** | **Functionalities** |
| --- | --- |
| `aria-valuenow` | It Indicates the current value of the slider. |
| `aria-valuetext`| Returns the current text of the slider. |
| `aria-valuemin` | It Indicates the Minimum value of the slider. |
| `aria-valuemax` | It Indicates the Maximum value of the slider. |
| `aria-orientation` | It Indicates the Slider Orientation. |
| `aria-label` | Slider left and right button label text (increment and decrement). |
| `aria-labelledby` | It indicates the name of the Slider. |

## Keyboard interaction

The Keyboard interaction of the Slider control is designed based on the [WAI-ARIA Practices](https://www.w3.org/TR/wai-aria-practices/#slider) described for Slider. Users can use the following shortcut keys to interact with the Slider.

| **Keyboard shortcuts** | **Actions** |
| --- | --- |
| <kbd>Right Arrow</kbd> <kbd>Up Arrow</kbd> | Increase the Slider value.|
| <kbd>Left Arrow</kbd> <kbd>Down Arrow</kbd> | Decrease the Slider value. |
| <kbd>Home</kbd> | Moves to the start value (for Range Slider when the second thumb is focused and the Home key is pressed, it moves to the first thumb value). |
| <kbd>End</kbd> | Moves to the end value (for Range Slider when the first thumb is focused and the End key is pressed, it moves to the second thumb value). |
| <kbd>Page Up</kbd> | Increases the Slider by `largeStep` value. |
| <kbd>Page Down</kbd> | Decreases the Slider by `largeStep` value. |

{% aspTab template="slider/accessbility", sourceFiles="accessbility.cs" %}

{% endaspTab %}

![ASP .NET Core - Slider - Accessibility](./images/slider-accessibility.png)