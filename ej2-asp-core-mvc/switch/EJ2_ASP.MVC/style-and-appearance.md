---
layout: post
title: Style And Appearance in ##Platform_Name## Switch Component
description: Learn here all about Style And Appearance in Syncfusion ##Platform_Name## Switch component and more.
platform: ej2-asp-core-mvc
control: Style And Appearance
publishingplatform: ##Platform_Name##
documentation: ug
---


# Styles and Appearances

To modify the Switch appearance, you need to override the default CSS of Switch component. Please find the list of CSS classes and its corresponding section in Switch. Also, you have an option to create your own custom theme for the controls using our [`Theme Studio`](https://ej2.syncfusion.com/themestudio/?theme=material).

CSS Class | Purpose of Class
-----|-----
|.e-switch-wrapper .e-switch-inner|To customize the line of the switch in off mode
|.e-switch-wrapper .e-switch-handle|To customize the handle of the switch in off mode
|.e-switch-wrapper:not(.e-switch-disabled):hover .e-switch-handle:not(.e-switch-active)|To customize the handle of the switch in off mode when hover
|.e-switch-wrapper:not(.e-switch-disabled):hover .e-switch-inner:not(.e-switch-active)|To customize the line of the switch in off mode when hover
|.e-switch-wrapper .e-switch-handle.e-switch-active|To customize the handle of the switch in on mode
|.e-switch-wrapper .e-switch-on|To customize the line of the switch in on mode
|.e-switch-wrapper:hover .e-switch-handle.e-switch-active|To customize the handle of the switch in on mode when hover
|.e-switch-wrapper:hover .e-switch-inner.e-switch-active .e-switch-on|To customize the line of the switch in on mode when hover
