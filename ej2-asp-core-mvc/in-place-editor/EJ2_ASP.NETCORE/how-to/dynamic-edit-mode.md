---
layout: post
title: Dynamic Edit Mode in ##Platform_Name## In Place Editor Component
description: Learn here all about Dynamic Edit Mode in Syncfusion ##Platform_Name## In Place Editor component and more.
platform: ej2-asp-core-mvc
control: Dynamic Edit Mode
publishingplatform: ##Platform_Name##
documentation: ug
---


# Dynamically move input to edit mode

At control initial load, if you want to open editor state without interacting In-place Editor input element, it can be achieved by configuring the [`enableEditMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_EnableEditMode) property to `true`.

In the following sample, editor opened at initial load and when toggling a checkbox, it will remove or open the editor.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/dynamic-edit/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/dynamic-edit/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/dynamic-edit/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/dynamic-edit/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![dynamic-edit](../../in-place-editor/images/dynamic-edit.PNG)