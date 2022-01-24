---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Orientation of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Orientation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Orientation

This section explains about modifying the position and modes of Tab header.

It allows placing the header section inside the Tab component at different positions by using the  `headerPlacement` property. The available positions are as follows:

* **Top**: Tab header items can be arranged horizontally, and their content can be placed after the header.
* **Bottom**: Tab header items can be arranged horizontally, and their content can be placed before the header.
* **Left**: Tab header items can be arranged vertically, and their content can be placed after the header.
* **Right**: Tab header items can be arranged vertically, and their content can be placed before the header.

It is also adaptable to the available space when the tab items exceed the view space. You can customize the modes by using `overflowMode` property. The available modes are as follows:

* Scrollable
* Popup

{% aspTab template="tab/orientation-tab", sourceFiles="orientation.cs" %}

{% endaspTab %}

Output be like the below.

![Tab vertical support](./images/vertical.PNG)
