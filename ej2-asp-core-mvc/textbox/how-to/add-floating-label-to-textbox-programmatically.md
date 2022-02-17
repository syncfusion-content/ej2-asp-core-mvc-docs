---
layout: post
title: Add Floating Label To Textbox Programmatically in ##Platform_Name## Textbox Component
description: Learn here all about Add Floating Label To Textbox Programmatically in Syncfusion ##Platform_Name## Textbox component and more.
platform: ej2-asp-core-mvc
control: Add Floating Label To Textbox Programmatically
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add floating label to TextBox programmatically

The `Floating Label TextBox` floats label above the TextBox after focusing, or entering a value in the TextBox.

Floating label supports the types of actions as given below.

Type     | Description
------------ | -------------
  Auto       | The floating label will float above the input after focusing, or entering a value in the input.
  Always     | The floating label will always float above the input.
  Never      | By default, never float the label in the input when the placeholder is available.

* Create a TypeScript file and import the `Input` modules from `ej2-inputs` library as shown below.

```typescript
import {Input} from '@syncfusion/ej2-inputs';
```

* Pass the `HTML Input` element and [floatLabelType](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.TextBox.html#Syncfusion_EJ2_Inputs_TextBox_FloatLabelType) property as `Auto` to the `createInput` method.

* Set the `placeholder` value to the input element via `element attribute` or pass the parameter to the `createInput` method.

The `watermark label` will be updated based on the specified `placeholder` value of the `Floating Label TextBox`.

* You can add the `icons` on the input by passing `buttons` property value with the
class name `e-input-group-icon` as parameter to the `createInput` method.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/floating-label/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Floating-label.cs" %}
{% include code-snippet/textbox/how-to/floating-label/floating-label.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/textbox/how-to/floating-label/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Floating-label.cs" %}
{% include code-snippet/textbox/how-to/floating-label/floating-label.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}

