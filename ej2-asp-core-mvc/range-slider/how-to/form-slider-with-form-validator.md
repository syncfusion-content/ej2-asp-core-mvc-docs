---
layout: post
title: Form Slider With Form Validator in ##Platform_Name## Range Slider Component
description: Learn here all about Form Slider With Form Validator in Syncfusion ##Platform_Name## Range Slider component and more.
platform: ej2-asp-core-mvc
control: Form Slider With Form Validator
publishingplatform: ##Platform_Name##
documentation: ug
---

# Form Slider with FormValidator

The Slider control can be validated using our
[FormValidator](https://ej2.syncfusion.com/documentation/form-validator/?lang=typescript). The following steps walk-through
slider validation.

* Render slider control inside a form.
* Bind [changed](https://ej2.syncfusion.com/documentation/slider/api-slider.html?lang=typescript#changed) event in the slider control to validate the slider value when the value changes.
* Initialize and render FormValidator for the form using form ID.
* Set the required property in the FormValidator [rules](https://ej2.syncfusion.com/documentation/form-validator/api-formValidator.html?lang=typescript#rules) collection. Here, the [min](https://ej2.syncfusion.com/documentation/slider/api-slider.html?lang=typescript#min) property of slider that sets the minimum value in the slider control is set, and it has hidden input as enable `validateHidden` property is set to true.

> Form validation is done either by ID or name value of the slider control. Above ID of the slider is used to validate it.

Using slider name: Render slider with name attribute. In the following code snippet, name attribute value of slider is used
for form validation.

* Validate the form using
[validate](https://ej2.syncfusion.com/documentation/form-validator/api-formValidator.html?lang=typescript#validate) method,
and it validates the slider value with the defined rules collection and returns the result. If user selects the value less than
the minimum value, form will not submit.

* Slider validation can be done during value changes in slider. Refer to the following code snippet.

```javascript

// change event handler for slider
function onChanged(args) {
  formObj.validate();
}

```

The `FormValidator` has following default validation rules, which are used to validate the Slider control.

| Rules | Description | Example |
| ------------- | ------------- | ------------- |
| `max` | Slider control must have value less than or equal to `max` number | if `max: 3`, **3** is valid and **4** is invalid |
| `min` | Slider control must have value greater than or equal to `min` number | if `min: 4`, **5** is valid and **2** is invalid |
| `regex` | Slider control must have valid value in `regex` format | if `regex: '/4/`, **4** is valid and **1** is invalid |
| `range` | Slider control must have value between `range` number | if `range: [4,5]`, **4** is valid and **6** is invalid |

{% if page.publishingplatform == "aspnet-core" %}

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/slider/form-validator/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="Form-validator.cs" %}
{% include code-snippet/slider/form-validator/form-validator.cs %}
{% endhighlight %}
{% endtabs %}

{% elsif page.publishingplatform == "aspnet-mvc" %}

{% tabs %}
{% highlight razor tabtitle="CSHTML" %}
{% include code-snippet/slider/form-validator/razor %}
{% endhighlight %}
{% highlight c# tabtitle="Form-validator.cs" %}
{% include code-snippet/slider/form-validator/form-validator.cs %}
{% endhighlight %}
{% endtabs %}
{% endif %}



![ASP .NET Core - Slider - Form Validator](../images/slider-validation.png)