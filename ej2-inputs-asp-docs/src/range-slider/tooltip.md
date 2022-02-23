---
title: "Slider Tooltip"
component: "Slider"
description: "Slider displays the currently selected slider value using tooltip before or after of slider bar."
---

# Tooltip

The Slider displays the tooltip to indicate the current value by clicking the Slider bar or drag
the Slider handle. The Tooltip position can be customized by using the `placement` property. Also decides the tooltip display mode on a page, i.e., on hovering, focusing, or clicking on the Slider handle and it always remains/displays on the page.

{% aspTab template="slider/tooltip", sourceFiles="HomeController.cs" %}

{% endaspTab %}

![ASP .NET Core - Slider - Tooltip](./images/slider-tooltip.png)

## Buttons

The Slider value can be changed by using the Increase and Decrease buttons. In Range Slider, by
default the first handle value will be changed while clicking the button. Change the handle focus and
press the button to change the last focused handle value.

> After enabling the slider buttons if the 'Tab' key is pressed, the focus goes to the handle
and not to the button.

{% aspTab template="slider/buttons", sourceFiles="HomeController.cs" %}

{% endaspTab %}

![ASP .NET Core - Slider - Buttons](./images/slider-buttons.png)