---
layout: post
title: Cross-Site scripting in ##Platform_Name## Block Editor | Syncfusion
description: Checkout and learn about Cross-Site scripting with Syncfusion Essential ##Platform_Name## BlockEditor control, its elements, and more details.
platform: ej2-asp-core-mvc
control: BlockEditor
publishingplatform: ##Platform_Name##
documentation: ug
---

# Cross-Site scripting(XSS) prevention in ##Platform_Name## Block Editor control

The Block Editor control allows users to edit the content with security by preventing cross-site scripting (XSS). By default, it provides built-in support to remove elements from editor content that cause XSS attacks. The editor removes the elements based on the attributes if it is possible to execute a script.

## Enabling XSS prevention

The [enableHtmlSanitizer](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.BlockEditor.BlockEditor.html#Syncfusion_EJ2_BlockEditor_BlockEditor_EnableHtmlSanitizer), enabled by default, activates XSS prevention. When active, the editor automatically removes elements like `<script>` and attributes like `onmouseover` from the content.
The following example shows XSS prevention removing a `<script>` tag and `onmouseover` attribute:
