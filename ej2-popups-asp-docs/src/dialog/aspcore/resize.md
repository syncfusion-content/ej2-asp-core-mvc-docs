---
title: "ASP.NET Core Dialog Resizing"
component: "Dialog"
description: "Explains about the resizeable dialog which allows changing its size dynamically."
---

# Resizing

The Dialog supports resizing feature. To resize the dialog, we have to select and resize it by using its handle (grip) or hovering on any of the edges or borders of the dialog within the sample container.

The resizable dialog can be created by setting the `EnableResize` property to true, which is used to change the size of a dialog dynamically and view its content with expanded mode. The `ResizeHandles` property can also be configured for all the which directions in which the dialog should be resized. When you configure the target property along with the `EnableResize` property, the dialog can be resized within its specified target container.

{% aspTab template="dialog/getting-started/resize", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![dialog](./images/dialog_resize.gif)
