---
layout: post
title: dimension in ##Platform_Name## Predefined Dialogs | Syncfusion
description: Checkout and learn about Dimension in ##Platform_Name## Predefined Dialogs of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Dimension
publishingplatform: ##Platform_Name##
documentation: ug
---

# Dimension in Predefined Dialogs

Customize the predefined dialogs dimensions using the `height` and `width`properties.

By default, the predefined dialogs `width` and `height` property value is set as `auto`. Depends on the dialog content the width and height values are automatically adjust. You can specify the dimension values in both pixels and percentage format to change the default dialog width and height values.

Use the following code snippet for **Alert.cshtml**, **Confirm.cshtml** and **Prompt.cshtml** to customize the dialog dimensions.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}

{% highlight cshtml tabtitle="Alert.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/dimension/alert/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Confirm.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/dimension/confirm/tagHelper %}
{% endhighlight %}

{% highlight cshtml tabtitle="Prompt.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/dimension/prompt/tagHelper %}
{% endhighlight %}

{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

**Alert**

{% tabs %}
{% highlight razor tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/dimension/alert/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/dimension/alert/controller.cs %}
{% endhighlight %}
{% endtabs %}

**Confirm**

{% tabs %}
{% highlight razor tabtitle="Confirm.cshtml" %}
{% include code-snippet/predefined-dialogs/dimension/confirm/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/dimension/confirm/controller.cs %}
{% endhighlight %}
{% endtabs %}

**Prompt**

{% tabs %}
{% highlight razor tabtitle="Prompt.cshtml" %}
{% include code-snippet/predefined-dialogs/dimension/prompt/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/dimension/prompt/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

**Results from the code snippet**

**Alert**

![Alert dimension Dialog](../images/alert-dimension.png)

**Confirm**

![Confirm dimension Dialog](../images/confirm-dimension.png)

**Prompt**

![prompt dimension Dialog](../images/prompt-dimension.png)

## Max-width and max-height

To have a restricted max-width and max-height dialog dimension, you need to specify the max-width, max-height CSS properties for the component’s container element by using the `cssClass` property. The max-height value is calculated in source level and set to the dialog. so, need to override the max-height property.

Use the following code to customize the max-width and max-height for alert dialog:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}

{% highlight cshtml tabtitle="Alert.cshtml" %}
{% include_relative code-snippet/predefined-dialogs/dimension/alert-max-height-width/tagHelper %}
{% endhighlight %}

{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/dimension/alert-max-height-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/dimension/alert-max-height-width/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Max width and height](../images/alert-dimension-max-height-width.png)

## Min-width and min-height

To have a restricted min-width and min-height dialog dimension, you need to specify the min-width, min-height CSS properties for the component’s container element by using the cssClass property.

Use the following code to customize the min-width and min-height for alert dialog:

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}

{% highlight cshtml tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/dimension/alert-min-height-width/tagHelper %}
{% endhighlight %}

{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/dimension/alert-min-height-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/dimension/alert-min-height-width/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% endif %}

![Min width and height](../images/alert-dimension-min-height-width.png)