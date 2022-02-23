---
title: "Underline a character in a text"
component: "SplitButton"
description: "SplitButton how to section, group popup items using list view component, dialog open on popup item click."
---

# Underline a character in a text

To underline a particular character in a text, it can be handled in [`beforeItemRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.SplitButtons.SplitButton.html#Syncfusion_EJ2_SplitButtons_SplitButton_BeforeItemRender) event by
adding `<u>` tag in between the text and given as innerHTML in `li` rendering.

In the following example, `C` is underlined in the text `Copy`:

{% aspTab template="split-button/underline/demo", sourceFiles="underline.cs" %}

{% endaspTab %}