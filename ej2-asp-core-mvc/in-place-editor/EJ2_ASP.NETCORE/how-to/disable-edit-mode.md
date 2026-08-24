---
layout: post
title: Disable edit mode in InplaceEditor | Syncfusion
description: Toggle Syncfusion ##Platform_Name## InplaceEditor input on or off with a checkbox bound to the disabled property and reactive enabled state.
platform: ej2-asp-core-mvc
control: Disable Edit Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to disable the edit mode in ##Platform_Name## InplaceEditor

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