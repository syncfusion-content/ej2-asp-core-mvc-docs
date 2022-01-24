---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Customize Tab Content Height of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Customize Tab Content Height
publishingplatform: ##Platform_Name##
documentation: ug
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