---
layout: post
title: Disable Edit Mode in ##Platform_Name## In Place Editor Component
description: Learn here all about Disable Edit Mode in Syncfusion ##Platform_Name## In Place Editor component and more.
platform: ej2-asp-core-mvc
control: Disable Edit Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Disable the edit mode specifically

The edit mode of In-place Editor can be disabled by setting the [`disabled`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Disabled) property value to `true`. In the following sample, when check or uncheck the checkbox, In-place Editor control will disable or enable the edit mode.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/disable-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/disable-edit/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/disable-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/disable-edit/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![disable-edit](../../in-place-editor/images/disable-edit.PNG)