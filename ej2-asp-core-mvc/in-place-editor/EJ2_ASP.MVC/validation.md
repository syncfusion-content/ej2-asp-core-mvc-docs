---
layout: post
title: Validation in ##Platform_Name## In Place Editor Component
description: Learn here all about Validation in Syncfusion ##Platform_Name## In Place Editor component and more.
platform: ej2-asp-core-mvc
control: Validation
publishingplatform: ##Platform_Name##
documentation: ug
---


# Validation

In-place Editor control supports validation and it can be achieved by adding rules to the [`ValidationRules`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.InPlaceEditor.InPlaceEditor.html#Syncfusion_EJ2_InPlaceEditor_InPlaceEditor_ValidationRules) property, its child property `key` must be same as `name` property, otherwise validation not performed. Submitting data to the server or calling the `validate` method validation executed.

> In-place editor is not a form component and it does not support `ejs-for` because the component has embedded into many other components like calendar,textboxes,etc.

## Validation Rules

In-place Editor has following validation rules, which are used to perform validation.

| Rules | Description | Example |
|------|------|------|
| `required` | The input element must have any input values | a or 1 or - |
| `email` | The input element must have valid `email` format values | <inplace@syncfusion.com> |
| `url` | The  input element must have valid `url` format values| <http://syncfusion.com/> |
| `date` | The  input element must have valid `date` format values | 12/25/2019 |
| `dateIso` | The  input element must have valid `dateIso` format values | 2019-12-25 |
| `number` | The  input element must have valid `number` format values | 1.0 or 1 |
| `maxLength` | Input value must have less than or equal to `maxLength` character length | if `maxLength: 5`, [check] is valid and [checking] is invalid |
| `minLength` | Input value must have less than or equal to `minLength` character length | if `minLength: 5`, [testing] is valid and [test] is invalid |
| `rangeLength` | Input value must have value between `rangeLength` character length | if `rangeLength: [4,5]`, [test] is valid and [key] is invalid
| `range` | Input value must have value between `range` number | if `range: [4,5]`, [4] is valid and [6] is invalid |
| `max` | Input value must have less than or equal to `max` number | if `max: 3`, [3] is valid and [4] is invalid |
| `min` | Input value must have less than or equal to `min` number | if `min: 4`, [5] is valid and [2] is invalid |
| `regex` | Input value must have valid `regex` format | if `regex: '^[A-z]+$'`, [a] is valid and [1] is invalid |

## Step by Step validation configuration

The following steps are used to configure validation in In-place Editor.

Step 1: To perform default validation in In-place Editor the `name` property is mandatory. And the specified name must be the same as the key name.

Step 2:  The corresponding name specified in the name property should bind with the `validationRules` property. For example, in the below code snippet, the `Number`  in the name property is bind with the `maxLength`  of validationRules.  Likewise, you can bind with the in-build validation configurations in the above table.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/validation-sample/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/validation-sample/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/validation-sample/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/validation-sample/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



In the following sample, first editor value submitted without select any date, so the default error message will be displayed below the `DatePicker` element. Second editor configured with the `validating` event with the handler. In handler event `errorMessage` argument value modified and it will show below the `DatePicker` element.

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/validation/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/validation/controller.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/in-place-editor/validation/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Controller.cs" %}
{% include code-snippet/in-place-editor/validation/controller.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



The output will be as follows.

![validation](./images/validation.PNG)

* For custom validation except specifying validationRules, specify errorMessage at validating event, message will be shown when the value is `Empty`.