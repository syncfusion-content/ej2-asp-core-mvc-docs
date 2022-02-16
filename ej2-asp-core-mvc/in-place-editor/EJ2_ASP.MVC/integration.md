---
layout: post
title: Integration in ##Platform_Name## In Place Editor Component
description: Learn here all about Integration in Syncfusion ##Platform_Name## In Place Editor component and more.
platform: ej2-asp-core-mvc
control: Integration
publishingplatform: ##Platform_Name##
documentation: ug
---


# Integrate HTML5 controls (Template)

The In-place Editor supports adding HTML5 input controls using the [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Template) property. The `Template` property can be given as either a `string` or a `query selector`.

## As a string

The HTML element tag can be given as a string for the [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Template) property. Here, the input is rendered as an HTML template.

```typescript
template: "<div><input type='text' id='name'></input></div>"

```

## As a selector

The [`Template`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Template) property also allows getting template content through query `selector`. Here, the input wrapper element ‘ID’ attribute is specified in the template.

```typescript
template: "#date"

```

Template mode, the [`Value`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_Value) property not handled by the In-place Editor control. So, before sending a value to the server, you need to modify at [`ActionBegin`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_ActionBegin) event, otherwise, an empty string will pass. In the following template sample, before submitting a data to the server, event argument and `Value` property content updated in the `ActionBegin` event handler.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/html-template/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/html-template/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/html-template/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/html-template/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![html-template](./images/html-template.PNG)