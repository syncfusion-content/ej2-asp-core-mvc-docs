---
layout: post
title: customization in ##Platform_Name## Predefined Dialogs Control
description: Checkout and learn about customization in ##Platform_Name## Predefined Dialogs of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Customization
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customization of Predefined Dialogs 

## Customize action buttons

You can customize the predefined dialogs buttons by using below properties.
* `okButton` - Use this property to customize **OK** button text and appearence.
* `cancelButton` - Use this property to customize **Cancel** button text and appearence.

Use the following code snippet for **alert.cshtml**, **confirm.cshtml** and **prompt.cshtml** to customize the predefined dialog action buttons.

For alert dialog , customized the default dialog button content as `Okay` by using the `okButton.text` property.

For confirm dialog, customized the default dialog buttons content as `Yes` and `No` by using the `okButton.text`and `cancelButton.text` property and also customized the dialog button icons by using `okButton.icon` property.

For prompt dialog , customized the default dialog buttons content as `Connect` and `Close` by using `okButton.text` and `cancelButton.text` property.

{% tabs %}

{% highlight razor tabtitle="alert.razor" %}
{% include_relative code-snippet/alert-action-button.razor %}
{% endhighlight %}

{% highlight razor tabtitle="confirm.razor" %}
{% include_relative code-snippet/confirm-action-button.razor %}
{% endhighlight %}

{% highlight razor tabtitle="prompt.razor" %}
{% include_relative code-snippet/prompt-action-button.razor %}
{% endhighlight %}

{% endtabs %}

**Results from the code snippet**

**Alert**

![Alert action buttons Dialog](./images/blazor-alert-action-button.png)

**Confirm**

![Confirm action buttons Dialog](./images/blazor-confirm-action-button.png)

**Prompt**

![Prompt action buttons Dialog](./images/blazor-prompt-action-button.png)

## Show or hide dialog close button 

You can show or hide close button in dialog using the `showCloseIcon` property.The default value is `false`.

Use the following code snippet for **alert.cshtml**, **confirm.cshtml** and **prompt.cshtml** to customize the show or hide dialog close button.

{% tabs %}

{% highlight razor tabtitle="alert.razor" %}
{% include_relative code-snippet/alert-close-button.razor %}
{% endhighlight %}

{% highlight razor tabtitle="confirm.razor" %}
{% include_relative code-snippet/confirm-close-button.razor %}
{% endhighlight %}

{% highlight razor tabtitle="prompt.razor" %}
{% include_relative code-snippet/prompt-close-button.razor %}
{% endhighlight %}

{% endtabs %}

**Results from the code snippet**

**Alert**

![Alert close icon Dialog](./images/blazor-alert-close-button.png)

**Confirm**

![Confirm close icon Dialog](./images/blazor-confirm-close-button.png)

**Prompt**

![Prompt close icon Dialog](./images/blazor-prompt-close-button.png)

### Customize dialog content

You can load custom content in predefined dialogs using the `content` property. 

Use the following code to customize the dialog content to render the custom TextBox component inside the prompt dialog to get the username from the user.

{% tabs %}
{% highlight razor %}

{% include_relative code-snippet/customize-dialog.razor %}

{% endhighlight %}
{% endtabs %}

![Customize Prompt Dialog](./images/blazor-customize-dialog.png)
