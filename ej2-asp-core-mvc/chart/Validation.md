---
layout: post
title: Validation in ##Platform_Name## Chart Component
description: Learn here all about Validation in Syncfusion ##Platform_Name## Chart component and more.
platform: ej2-asp-core-mvc
control: Validation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Validation

## jQuery Validation

To perform the jQuery validation for EJ form controls, refer to the following steps.

**Step 1:** First you need to include the [jquery.validate](http://www.nuget.org/packages/jQuery.Validation/#) (1.15.0) script in your HTML page.

**Step 2:** After adding this script file, you can validate the EJ form controls in same way as you have performed the jQuery validation for HTML form elements. But, here you have to do some little bit configuration along with that. It is discussed in the following.

If validation gets fail, you have to place the error message in proper position using the “errorPlacement” API that is available in the default settings of jQuery validation. Also, built-in “error” class will be added to the corresponding form element. Here, you have to specify a custom class with your own style using the “errorClass” API. These are the common settings for all of our EJ form controls.

And some of our EJ form controls contains the form values in hidden element for its functionality purpose and by default, these hidden elements are not validated. If you want to include the hidden elements in jQuery validation, set “[]” in “ignore” API of “$.validator.setDefaults”. Refer to the following list to find out the EJ form controls that contains the values in hidden element.

* Checkbox
* MaskEdit
* NumericTextbox
* CurrencyTextbox
* PercentageTextbox
* RTE
* Dropdownlist

Refer to the following code block to configure the above mentioned jQuery validation settings.


    {% highlight javascript %}
    
      $.validator.setDefaults({
           //to validate all fields(hidden also)
           ignore: [],
           //if we don’t set custom class, default “error” class will be added
           errorClass: 'e-validation-error',
           //it specifies the error message display position
           errorPlacement: function (error, element) {
               $(error).insertAfter(element.closest(".e-widget"));
           }
       });

    {% endhighlight %}

Up to 13.4.0.58 version, the above specified jQuery validation settings were configured in source level of EJ form controls. Since 14.1.0.41 release onwards, the above specified settings has been removed from the source and it needs to be specified in sample level to improve the customization of this validation.

The EJMVC DatePicker provides cool way to validate the value by custom rules and messages before it get processed. Enhanced APIs and built-in validation support in EJWEB DatePicker provides the quick validation in client side itself, that provides easy customization and better user experience than validating the values in server side.

{% highlight html %}

@using (Html.BeginForm())
{
    //Sets the field to be required with validation message

    @Html.EJ().DatePicker("datePicker").ValidationRules(rule => rule.AddRule("required", true)).ValidationMessage(msg => msg.AddMessage("required", "Required Date value"));

    <input type="submit" value="click here!" />

}

{% endhighlight %}