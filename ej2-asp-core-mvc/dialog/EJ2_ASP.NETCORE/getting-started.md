---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Getting Started of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Getting Started
publishingplatform: ##Platform_Name##
documentation: ug
---


# Getting Started

 This section briefly explains about how to include a simple Dialog in your ASP.NET Core application. You can refer [ASP.NET Core Getting Started documentation](../getting-started) page for introduction part part of the system requirements and configure the common specifications.

> Starting with v16.2.0.x, if you reference Syncfusion assemblies from trial setup or from the NuGet feed,
you also have to include the license key in your projects.
Please refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key) to know about registering Syncfusion license key in your ASP.NET Core application to use our components.

## Adding Dialog control to the Application

* Now open your view page to render Dialog control.

{% aspTab  template="dialog/getting-started/data", sourceFiles="controller.cs"%}

{% endaspTab %}

## Initialize the Dialog

* Dialog component can be rendered with the help of `ejs-dialog` tag helper. Add the below code to your `index.cshtml` page which is present under `Views/Home` folder, where the Dialog is initialized.

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
[`overlayClick`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_OverlayClick) event. In the below sample, the
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
[`header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Header) property.

{% aspTab template="dialog/getting-started/enable-header", sourceFiles="controller.cs" %}

{% endaspTab %}

## Enable footer

The Dialog provides built-in support to render the `buttons` on the footer (for ex: `OK` or
`Cancel` buttons). Each Dialog button allows the user to perform any action while clicking on it.

The primary button will be focused automatically on open the Dialog, and add the [`click`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.DialogDialogButton.html#Syncfusion_EJ2_Popups_DialogDialogButton_Click)
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

The Dialog can be positioned using the [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Position) property by providing the X and Y co-ordinates. It can be positioned inside the target of the container or `<body>` of the element based on the given X and Y values.

for X is: left, center, right (or) any offset value
for Y is: top, center, bottom (or) any offset value

The below example demonstrates the different Dialog positions.

{% aspTab template="dialog/getting-started/positioning", sourceFiles="controller.cs" %}

{% endaspTab %}

## See Also

* [Load dialog content using AJAX](./how-to/load-dialog-content-using-ajax)
* [How to position the dialog on center of the page on scrolling](./how-to/position-the-dialog-on-center-of-the-page-on-scrolling)
* [Prevent closing of modal dialog](./how-to/prevent-closing-of-modal-dialog)
* [Close dialog while click on outside of dialog](./how-to/close-dialog-while-click-on-outside-of-dialog)
* [How to make a reusable alert and confirm dialog](./how-to/render-a-dialog-using-utility-functions)
