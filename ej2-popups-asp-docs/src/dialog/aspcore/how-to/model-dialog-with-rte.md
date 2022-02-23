---
title: "Render model dialog with Rich Text Editor"
component: "Dialog"
description: "This section for Syncfusion ASP.NET Core Dialog control explains about, how to Render the model dialog with Rich Text Editor."
---

# Render model dialog with Rich Text Editor

This section explains how to render model dialog with the Rich Text Editor component. when you render model dialog with the Rich Text Editor component, the first row of the content will be hidden because the dialog container and its wrapper elements are styled with display as none. so, the editor’s toolbar does not get proper offset width and rendered above the edit area container. In this scenario, we could use the `refreshUI` method on the Dialog `open` event.

{% aspTab template="dialog/how-to/model-dialog-with-rte", sourceFiles="controller.cs" %}

{% endaspTab %}