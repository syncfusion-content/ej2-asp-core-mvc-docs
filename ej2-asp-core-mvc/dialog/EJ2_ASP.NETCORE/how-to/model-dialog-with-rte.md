---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Model Dialog With Rte of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Model Dialog With Rte
publishingplatform: ##Platform_Name##
documentation: ug
---


# Render model dialog with Rich Text Editor

This section explains how to render model dialog with the Rich Text Editor component. when you render model dialog with the Rich Text Editor component, the first row of the content will be hidden because the dialog container and its wrapper elements are styled with display as none. so, the editor’s toolbar does not get proper offset width and rendered above the edit area container. In this scenario, we could use the `refreshUI` method on the Dialog `open` event.

{% aspTab template="dialog/how-to/model-dialog-with-rte", sourceFiles="controller.cs" %}

{% endaspTab %}