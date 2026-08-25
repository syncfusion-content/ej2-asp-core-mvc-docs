---
layout: post
title: Render dialog with utility functions in ##Platform_Name## | Syncfusion
description: Render Syncfusion ##Platform_Name## Dialog alert and confirm dialogs with minimal code using built-in utility functions and configurable options.
platform: ej2-asp-core-mvc
control: Render A Dialog Using Utility Functions
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to render a Dialog with utility functions in ##Platform_Name## Dialog

The Dialog control provides built-in utility functions to render the alert and confirm dialogs with the minimal code. The following options are used as an argument on calling the utility functions:

| Options   | Description |
|-----------|-------------|
| title | Specifies the title of the dialog like the [`header`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Header) property. |
| content | Specifies the value that can be displayed in the dialog's content area like the [`content`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Content) property. |
| isModal | Specifies the Boolean value whether the dialog can be displayed as modal or non-modal. For more details, refer to the [`isModal`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_IsModal) property. |
| position | Specifies the position at which the alert or confirm dialog is rendered within the document. For more details, refer to the [`position`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_Position) property { X: ‘center’, Y: ‘center’}|
| okButton | Configures the `OK` button. Accepts a [`ButtonModel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html) object containing button properties and a click event. `okButton: { icon: 'prefix icon for the button', cssClass: 'custom CSS class for the button', click: 'function for OK button click', text: 'OK' // <- Default value is 'OK' }` |
| cancelButton | Configures the `Cancel` button. Accepts a [`ButtonModel`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html) object containing button properties and a click event. `cancelButton: { icon: 'prefix icon for the button', cssClass: 'custom CSS class for the button', click: 'function for Cancel button click', text: 'Cancel' // <- Default value is 'Cancel' }` |
| isDraggable | Specifies the value whether the alert or confirm dialog can be dragged by the user. |
| showCloseIcon | Specifies whether to show the close icon in the Dialog control. |
| closeOnEscape | Specifies whether the dialog can be closed by pressing the ESC key. |
| cssClass | Specifies the CSS class name that can be appended to the dialog. |
| zIndex | Specifies the order of the dialog, that is displayed in front of or behind another component. |
| open | Specifies the event that is triggered after the dialog is opened. |
| close | Specifies the event that is triggered after the dialog is closed. |

## Alert dialog

An alert dialog box is used to display warning like messages to the users. Use the following code to render a simple alert dialog in an application.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dialog-utility-alert/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dialog-utility-alert/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dialog-utility-alert/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dialog-utility-alert/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Render an alert dialog with options

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dialog-utility-alert1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dialog-utility-alert1/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dialog-utility-alert1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dialog-utility-alert1/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Confirm dialog

A confirm dialog displays a specified message along with `OK` and `Cancel` button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dialog-utility-confirm/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dialog-utility-confirm/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dialog-utility-confirm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dialog-utility-confirm/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

### Render a confirmation dialog with options

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dialog-utility-confirm1/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dialog-utility-confirm1/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dialog-utility-confirm1/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dialog-utility-confirm1/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

## Close utility dialog

When rendering an Alert and Confirmation dialog through utility methods, you can close the dialog using the following ways.

* By pressing the escape key if the [closeOnEscape](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_CloseOnEscape) property is enabled.
* By clicking the close button if the [showCloseIcon](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Popups.Dialog.html#Syncfusion_EJ2_Popups_Dialog_ShowCloseIcon) property is enabled.

You can also manually close the Dialogs by creating an instance to the dialog and call the "hide" method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dialog-utility-hide/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dialog-utility-hide/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/dialog/how-to/dialog-utility-hide/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/dialog/how-to/dialog-utility-hide/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

