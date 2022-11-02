---
layout: post
title: customization in ASP.NET CORE Predefined Dialogs | Syncfusion
description: Checkout and learn about customization in ASP.NET CORE Predefined Dialogs of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ASP.NET CORE
documentation: ug
---

# Customization of Predefined Dialogs 

## Customize action buttons

You can customize the predefined dialogs buttons by using below properties.
* `okButton` - Use this property to customize **OK** button text and appearence.
* `cancelButton` - Use this property to customize **Cancel** button text and appearence.

Use the following code snippet for **Alert.cshtml**, **Confirm.cshtml** and **Prompt.cshtml** to customize the predefined dialog action buttons.

For alert dialog , customized the default dialog button content as `Done` by using the `okButton.text` property.

For confirm dialog, customized the default dialog buttons content as `Yes` and `No` by using the `okButton.text`and `cancelButton.text` property and also customized the dialog button icons by using `okButton.icon` property.

For prompt dialog , customized the default dialog buttons content as `Connect` and `Close` by using `okButton.text` and `cancelButton.text` property.


{% tabs %}

{% highlight cshtml tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/customization/action-btn/alert/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Confirm.cshtml" %}
{% include code-snippet/predefined-dialogs/customization/action-btn/confirm/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Prompt.cshtml" %}
{% include code-snippet/predefined-dialogs/customization/action-btn/prompt/tagHelper %}
{% endhighlight %}

{% endtabs %}

**Results from the code snippet**

**Alert**

![ASP.NET CORE Predefined Dialogs Alert action buttons Dialog](./images/alert-custom-action-btn.png)

**Confirm**

![ASP.NET CORE Predefined Dialogs Confirm action buttons Dialog](./images/confirm-custom-action-btn.png)

**Prompt**

![ASP.NET CORE Predefined Dialogs Prompt action buttons Dialog](./images/prompt-custom-action-btn.png)

## Show or hide dialog close button 

When rendering the predefined dialogs through utility methods, You can close the dialog using the following ways. The default values of `closeOnEscape` and `showCloseIcon` is `false`.

* By pressing the escape key if the [closeOnEscape](https://ej2.syncfusion.com/documentation/api/dialog/#closeonescape) property is enabled.
* By clicking the close button if the [showCloseIcon](https://ej2.syncfusion.com/documentation/api/dialog/#showcloseicon) property is enabled.

You can also manually close the Dialogs by creating an instance to the dialog and call the [hide](https://ej2.syncfusion.com/documentation/api/dialog/#hide) method.

Use the following code for **alert**, **confirm** and **prompt** to demonstrates the different ways of hiding the utility dialog.


{% tabs %}

{% highlight cshtml tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/customization/show-hide-btn/alert/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Confirm.cshtml" %}
{% include code-snippet/predefined-dialogs/customization/show-hide-btn/confirm/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Prompt.cshtml" %}
{% include code-snippet/predefined-dialogs/customization/show-hide-btn/prompt/tagHelper %}
{% endhighlight %}

{% endtabs %}

**Results from the code snippet**

**Alert**

![ASP.NET CORE Predefined Dialogs Alert close icon Dialog](./images/alert-show-hide-btn.png)

**Confirm**

![ASP.NET CORE Predefined Dialogs Confirm close icon Dialog](./images/confirm-show-hide-btn.png)

**Prompt**

![ASP.NET CORE Predefined Dialogs Prompt close icon Dialog](./images/prompt-show-hide-btn.png)

## Customize dialog content

You can load custom content in predefined dialogs using the `content` property.

Use the following code to customize the dialog content to render the custom TextBox component inside the prompt dialog to get the username from the user.


{% tabs %}

{% highlight cshtml tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/customization/custom-content/tagHelper %}
{% endhighlight %}

{% endtabs %}

**Results from the code snippet**

![ASP.NET CORE Predefined Dialogs alert close icon Dialog](./images/confirm-custom-content.png)