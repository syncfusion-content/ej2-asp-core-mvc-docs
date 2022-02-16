---
layout: post
title: Set The Disabled State in ##Platform_Name## Radio Button Component
description: Learn here all about Set The Disabled State in Syncfusion ##Platform_Name## Radio Button component and more.
platform: ej2-asp-core-mvc
control: Set The Disabled State
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set the disabled state

RadioButton component can be enabled/disabled by giving [`disabled`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.RadioButton.html#Syncfusion_EJ2_Buttons_RadioButton_Disabled) property. To disable RadioButton component,
the `disabled` property can be set as `true`.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/radio-button/howto/disabled/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/radio-button/howto/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/radio-button/howto/disabled/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Disabled.cs" %}
{% include code-snippet/radio-button/howto/disabled/disabled.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

