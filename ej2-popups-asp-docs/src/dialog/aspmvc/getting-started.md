---
title: "ASP.NET MVC Dialog Getting Started"
component: "Dialog"
description: "Helps to get started with the dialog control along with its key features such as modal dialog, positioning, and draggable."
---

# Getting Started

 This section briefly explains about how to include a simple Dialog in your ASP.NET MVC application. You can refer [ASP.NET MVC Getting Started documentation](../getting-started) page for introduction part of the system requirements and configure the common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed,
you also have to include the license key in your projects.
Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET MVC application to use our components.

## Initialize the Dialog

* Dialog control can be rendered with the help of `@Html.EJS().Dialog` tag helper. Add the below code to your `index.cshtml` page which is present under `Views/Home` folder, where the Dialog is initialized.

## Adding component to the Application

* Now open your view page to render Dialog control.

```cs

@Html.EJS().Dialog("dialog").Content("This is a dialog").Target("#container").Width("250px").Render()

```

## Run the application

 After successful compilation of your application, simply press `F5` to run the application.

The below example shows the Dialog.

{% aspTab template="dialog/getting-started/getting-started", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![dialog](./images/dialog-getting.png)

> In the dialog control, max-height is calculated based on the dialog target element height. If the target property is not configured, the document.body is considered as a target. Therefore, to show a dialog in proper height, you need to add min-height to the target element.

## Modal Dialog

A [`modal`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_IsModal) shows an overlay behind the Dialog. So, the user
should interact the Dialog compulsory before interacting with the remaining content in an
application.

While the user clicks the overlay, the action can be handled through the
[`OverlayClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_OverlayClick) event. In the below sample, the
Dialog close action is performed while clicking on the overlay.

> When the modal dialog is opened, the Dialog's target scrolling will be disabled. The scrolling
will be enabled again once close the Dialog.

{% aspTab template="dialog/getting-started/modal", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![dialog](./images/modal-dialog-getting.png)

>In the dialog control, If the dialog is rendered based on the body, then the dialog get the height is based on its body element height. If the height of the dialog is larger than the body height, then the dialog's height will not be set. For this scenario, we can set the CSS style for the html and body to get the dialog height.

```css

html, body {
   height: 100%;
}

```

## Enable header

The Dialog header can be enabled by adding the header content as text or HTML content through the
[`Header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Header) property.

{% aspTab template="dialog/getting-started/enable-header", sourceFiles="controller.cs" %}

{% endaspTab %}

## Enable footer

The Dialog provides built-in support to render the `buttons` on the footer (for ex: `OK` or
`Cancel` buttons). Each Dialog button allows the user to perform any action while clicking on it.

The primary button will be focused automatically on open the Dialog, and add the [`Click`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.DialogDialogButton.html#Syncfusion_EJ2_Popups_DialogDialogButton_Click)
event to handle the actions

> When the Dialog initialize with more than one primary buttons, the first primary button gets focus on open the Dialog.

The below sample render with button and its click event.

{% aspTab template="dialog/getting-started/enable-footer", sourceFiles="controller.cs" %}

{% endaspTab %}

## Draggable

The Dialog supports to [drag](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_AllowDragging) within its target
container by grabbing the Dialog header, which allows the user to reposition the
Dialog dynamically.

> The Dialog can be draggable only when the Dialog header is enabled.
From `16.2.x` version, enabled draggable support for modal dialog also.

{% aspTab template="dialog/getting-started/draggable", sourceFiles="controller.cs" %}

{% endaspTab %}

## Positioning

The Dialog position can be set through the [`Position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Position) property by
providing X and Y coordinates. The Dialog can be positioned inside the target container based on
the given X and Y values.

For example <!-- markdownlint-disable MD033 --> <code>position:{ X:'center', Y:'center' }</code>
the possible values

* for X is: left, center, right (or) any offset value
* for Y is: top, center, bottom (or) any offset value

The below sample demonstrates the different Dialog positions.

{% aspTab template="dialog/getting-started/positioning", sourceFiles="controller.cs" %}

{% endaspTab %}

## See Also

* [Real time example using Dialog](https://ej2.syncfusion.com/aspnetmvc/Grid/DialogEditing#/bootstrap5)
* [Load dialog content using AJAX](./how-to/load-dialog-content-using-ajax)
* [How to position the dialog on center of the page on scrolling](./how-to/position-the-dialog-on-center-of-the-page-on-scrolling)
* [Prevent closing of modal dialog](./how-to/prevent-closing-of-modal-dialog)
* [Close dialog while click on outside of dialog](./how-to/close-dialog-while-click-on-outside-of-dialog)
* [How to make a reusable alert and confirm dialog](./how-to/render-a-dialog-using-utility-functions)
