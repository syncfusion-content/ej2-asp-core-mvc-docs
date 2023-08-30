---
layout: post
title: dimension in ASP.NET MVC Predefined Dialogs | Syncfusion
description: Checkout and learn about Dimension in ASP.NET MVC Predefined Dialogs of Syncfusion Essential JS 2 and more details.
platform: ej2-asp-core-mvc
control: Dimension
publishingplatform: ejmvc
documentation: ug
---

# Dimension in Predefined Dialogs

Customize the predefined dialogs dimensions using the `height` and `width`properties.

By default, the predefined dialogs `width` and `height` property value is set as `auto`. Depends on the dialog content the width and height values are automatically adjust. You can specify the dimension values in both pixels and percentage format to change the default dialog width and height values.

Use the following code snippet for **Alert.cshtml**, **Confirm.cshtml** and **Prompt.cshtml** to customize the dialog dimensions.

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

**Results from the code snippet**

**Alert**

![ASP.NET MVC Predefinded Dialogs alert dimension](./images/alert-dimension.png)

**Confirm**

![ASP.NET MVC Predefinded Dialogs confirm dimension](./images/confirm-dimension.png)

**Prompt**

![ASP.NET MVC Predefinded Dialogs prompt dimension](./images/prompt-dimension.png)

## Max-width and max-height

To have a restricted max-width and max-height dialog dimension, you need to specify the max-width, max-height CSS properties for the component’s container element by using the `cssClass` property. The max-height value is calculated in source level and set to the dialog. so, need to override the max-height property.

Use the following code to customize the max-width and max-height for alert dialog:

{% tabs %}
{% highlight razor tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/dimension/alert-max-height-width/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/dimension/alert-max-height-width/controller.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Predefinded Dialogs max width and height](./images/alert-dimension-max-height-width.png)

## Min-width and min-height

To have a restricted min-width and min-height dialog dimension, you need to specify the min-width, min-height CSS properties for the component’s container element by using the cssClass property.

Use the following code to customize the min-width and min-height for alert dialog:

{% tabs %}
{% highlight razor tabtitle="Alert.cshtml" %}
{% include code-snippet/predefined-dialogs/draggable/alert/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/predefined-dialogs/getting-started/confirm-dialog/controller.cs %}
{% endhighlight %}
{% endtabs %}

![ASP.NET MVC Predefinded Dialogs min width and height](./images/alert-dimension-min-height-width.png)