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

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}

{% highlight cshtml tabtitle="Alert.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/customization/action-btn/alert/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Confirm.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/customization/action-btn/confirm/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Prompt.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/customization/action-btn/prompt/tagHelper %}
{% endhighlight %}

{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

**Alert**

{% tabs %}
{% highlight razor tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/customization/action-btn/alert/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/customization/action-btn/alert/controller.cs %}
{% endhighlight %}
{% endtabs %}

**Confirm**

{% tabs %}
{% highlight razor tabtitle="Confirm.cshtml" %}
{% include code-snippet/predefined-dialogs/customization/action-btn/confirm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/customization/action-btn/confirm/controller.cs %}
{% endhighlight %}
{% endtabs %}

**Prompt**

{% tabs %}
{% highlight razor tabtitle="Prompt.cshtml" %}
{% include code-snippet/predefined-dialogs/customization/action-btn/prompt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/customization/action-btn/prompt/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Results from the code snippet**

**Alert**

![Alert action buttons Dialog](../images/alert-custom-action-btn.png)

**Confirm**

![Confirm action buttons Dialog](../images/confirm-custom-action-btn.png)

**Prompt**

![Prompt action buttons Dialog](../images/prompt-custom-action-btn.png)

## Show or hide dialog close button 

You can show or hide close button in dialog using the `showCloseIcon` property.The default value is `false`.

Use the following code snippet for **Alert.cshtml**, **Confirm.cshtml** and **Prompt.cshtml** to customize the show or hide dialog close button.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}

{% highlight cshtml tabtitle="Alert.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/customization/show-hide-btn/alert/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Confirm.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/customization/show-hide-btn/confirm/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Prompt.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/customization/show-hide-btn/prompt/tagHelper %}
{% endhighlight %}

{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

**Alert**

{% tabs %}
{% highlight razor tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/customization/show-hide-btn/alert/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/customization/show-hide-btn/alert/controller.cs %}
{% endhighlight %}
{% endtabs %}

**Confirm**

{% tabs %}
{% highlight razor tabtitle="Confirm.cshtml" %}
{% include code-snippet/predefined-dialogs/customization/show-hide-btn/confirm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/customization/show-hide-btn/confirm/controller.cs %}
{% endhighlight %}
{% endtabs %}

**Prompt**

{% tabs %}
{% highlight razor tabtitle="Prompt.cshtml" %}
{% include code-snippet/predefined-dialogs/customization/show-hide-btn/prompt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/customization/show-hide-btn/prompt/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

**Results from the code snippet**

**Alert**

![Alert close icon Dialog](../images/alert-show-hide-btn.png)

**Confirm**

![Confirm close icon Dialog](../images/confirm-show-hide-btn.png)

**Prompt**

![Prompt close icon Dialog](../images/prompt-show-hide-btn.png)

