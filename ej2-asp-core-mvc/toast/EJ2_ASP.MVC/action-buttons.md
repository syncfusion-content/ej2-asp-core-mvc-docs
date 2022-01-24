---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Action Buttons of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Action Buttons
publishingplatform: ##Platform_Name##
documentation: ug
---


# Action Buttons

You can include action buttons to the toast control by adding the [`Buttons`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Notifications.Toast.html#Syncfusion_EJ2_Notifications_Toast_Buttons) property. The collection of Syncfusion ASP.NET MVC button models can be bound to the `model` property inside the `Buttons` property. You can also include the click event callback function for each button.

{% aspTab template="toast/actionButton", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![Toast control with action buttons support](./images/toast-action.PNG)

## See Also

* [How to add dynamic template](./how-to/add-dynamic-template/)