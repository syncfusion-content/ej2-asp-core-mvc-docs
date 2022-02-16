---
layout: post
title: Customize The Step Value And Hide Spin Buttons in ##Platform_Name## Numerictextbox Component
description: Learn here all about Customize The Step Value And Hide Spin Buttons in Syncfusion ##Platform_Name## Numerictextbox component and more.
platform: ej2-asp-core-mvc
control: Customize The Step Value And Hide Spin Buttons
publishingplatform: ##Platform_Name##
documentation: ug
---

# Customize the step value and hide spin buttons

The spin buttons allow you to increase or decrease the value with the predefined [step](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_Step)
value. The visibility of spin buttons can be set using the [showSpinButton](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.NumericTextBox.html#Syncfusion_EJ2_Inputs_NumericTextBox_ShowSpinButton) property.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/how-to/icons/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Icons.cs" %}
{% include code-snippet/numeric-textbox/how-to/icons/icons.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/numeric-textbox/how-to/icons/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Icons.cs" %}
{% include code-snippet/numeric-textbox/how-to/icons/icons.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



Output be like the below.

![NumericTextBox Sample](../images/icons.png)