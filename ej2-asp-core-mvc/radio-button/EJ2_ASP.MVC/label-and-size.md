---
layout: post
title: Label And Size in ##Platform_Name## Radio Button Component | Syncfusion
description: Learn here all about Label And Size in Syncfusion ##Platform_Name## Radio Button component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Label And Size
publishingplatform: ##Platform_Name##
documentation: ug
---


# Label and Size in Radio Button Component

This section explains the different sizes and labels.

## Label

RadioButton caption can be defined by using the [`Label`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.RadioButton.html#Syncfusion_EJ2_Buttons_RadioButton_Label) property.

This reduces the manual addition of label for RadioButton. You can customize the label position before or after the RadioButton through the [`LabelPosition`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.RadioButton.html#Syncfusion_EJ2_Buttons_RadioButton_LabelPosition) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/radio-button/label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Label.cs" %}
{% include code-snippet/radio-button/label/label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/radio-button/label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Label.cs" %}
{% include code-snippet/radio-button/label/label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Radio Button Label and Size](images/radiobutton-label.png)

## Size

The different RadioButton sizes available are default and small. To reduce the size of the default RadioButton to small, set the [`CssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.RadioButton.html#Syncfusion_EJ2_Buttons_RadioButton_CssClass) property to `e-small`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/radio-button/size/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/radio-button/size/size.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/radio-button/size/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Size.cs" %}
{% include code-snippet/radio-button/size/size.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

![Radio Button Size](images/radiobutton-size.png)

## See Also

* [How to customize the RadioButton appearance](./how-to/customize-radiobutton-appearance)