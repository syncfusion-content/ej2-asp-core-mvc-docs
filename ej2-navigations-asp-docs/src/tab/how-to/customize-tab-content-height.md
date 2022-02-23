---
title: "Tab Content Height"
component: "Tab"
description: "This section explains how to customize the Syncfusion Essentail JS 2 Tab content height based on different needs."
---

# Customize Tab content height

You can change the Tab content height by using the `heightAdjustMode` property. By default, the Tab content `heightAdjustMode` property is set to `Content` value.

* **None**: Each tab content height is set based on the Tab height. This value is used only the tab component having the `height` property.
* **Auto**: Each tab content height will take the maximum height of all other tabs content.
* **Content**: Each tab content height is set based on their own content.
* **Fill**: Each tab content height is set based on the full height of Tabs parent element.

{% aspTab template="tab/height", sourceFiles="height.cs" %}

{% endaspTab %}

Output be like the below.

![Custom Tab content height](../images/height.PNG)