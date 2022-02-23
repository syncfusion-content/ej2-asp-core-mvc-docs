---
title: "Render a ASP.NET MVC Dialog using utility functions"
component: "Dialog"
description: "Covers customization features such as load content to the dialog from external sources, built-in alert, and confirmation model dialog."
---

# Render a Dialog using utility functions

The Dialog control provides built-in utility functions to render the alert and confirm dialogs with the minimal code.
The following options are used as an argument on calling the utility functions:

| Options   | Description |
|-----------|-------------|
| title | Specifies the title of dialog like the [`header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Header) property.|
| content | Specifies the value that can be displayed in dialog's content area like the [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Content) property. |
| isModal | Specifies the Boolean value whether the dialog can be displayed as modal or non-modal. For more details, refer to the [`isModal`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_IsModal) property.|
| position | Specifies the value where the alert or confirm dialog is positioned within the document. For more details, refer to the [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Position) property { X: ‘center’, Y: ‘center’}|
| okButton | Configures the `OK button` that contains button properties with the click events. `okButton:{ icon:'prefix icon to the button', cssClass:'custom class to the button', click: 'action for OK button click', text: 'Yes' // <-- Default value is 'OK' }`|
| cancelButton | Configures the `Cancel button` that contains button properties with the click events. `cancelButton:{ icon:'prefix icon to the button', cssClass:'custom class to the button', click: 'action for ‘Cancel’ button click', text: 'No' // <-- Default value is 'Cancel'}`|
|isDraggable|Specifies the value whether the alert or confirm dialog can be dragged by the user.|
| showCloseIcon | When set to true, the close icon is shown in the Dialog control. |
|closeOnEscape|When set to true, you can close the dialog by pressing ESC key.|
| cssClass | Specifies the CSS class name that can be appended to the dialog.|
| zIndex | Specifies the order of the dialog, that is displayed in front or behind of another component.|
| open | Event which is triggered after the dialog is opened.|
| close | Event which is triggered after the dialog is closed.|
| animationSettings |Specifies the animation settings of the dialog component. |

## Alert dialog

An alert dialog box is used to display warning like messages to the users. Use the following code to render a simple alert dialog in an application.

{% aspTab template="dialog/how-to/dialog-utility-alert", sourceFiles="controller.cs" %}

{% endaspTab %}

### Render an alert dialog with options

{% aspTab template="dialog/how-to/dialog-utility-alert1", sourceFiles="controller.cs" %}

{% endaspTab %}

## Confirm dialog

A confirm dialog displays a specified message along with ‘OK’ and ‘Cancel’ button.

{% aspTab template="dialog/how-to/dialog-utility-confirm", sourceFiles="controller.cs" %}

{% endaspTab %}

### Render a confirmation dialog with options

{% aspTab template="dialog/how-to/dialog-utility-confirm1", sourceFiles="controller.cs" %}

{% endaspTab %}

## Close utility dialog

When rendering an Alert and Confirmation dialog through utility methods, You can close the dialog using the following ways.

* By pressing the escape key if the [closeOnEscape](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.Popups.Dialog~CloseOnEscape.html) property is enabled.
* By clicking the close button if the [showCloseIcon](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2~Syncfusion.EJ2.Popups.Dialog~ShowCloseIcon.html) property is enabled.

You can also manually close the Dialogs by creating an instance to the dialog and call the "hide" method.

Below sample demonstrates the different ways of hiding the utility dialog.

{% aspTab template="dialog/how-to/dialog-utility-hide", sourceFiles="controller.cs" %}

{% endaspTab %}