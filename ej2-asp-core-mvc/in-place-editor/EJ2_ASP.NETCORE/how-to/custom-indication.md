---
layout: post
title: Add custom indication in InplaceEditor | Syncfusion
description: Show a visual cue on Syncfusion ##Platform_Name## InplaceEditor unsaved values by highlighting elements through the actionSuccess event when the submit fails.
platform: ej2-asp-core-mvc
control: Custom Indication
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to add custom indication in ##Platform_Name## InplaceEditor

You can add custom indication to unsaved input value by using the [`actionSuccess`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_ActionSuccess) event, when data not submitted to the server.

In this sample, the `actionSuccess` event configured and the [`url`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Url) property not included. Then submit button clicked, the current editor value saved into input and data sending to server action prevented due to the `url` property not configured.

But `actionSuccess` event will trigger the handler function with `null` argument values. In handler function data property [`primaryKey`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_PrimaryKey) value checked, whether it empty or not. If it is empty custom class, added in the `e-value-wrapper` element to customize its styles.

N> To send input value to local, set the `url` property as empty.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/custom-indication/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/custom-indication/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/custom-indication/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/custom-indication/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![custom-indication](../../in-place-editor/images/custom-indication.PNG)