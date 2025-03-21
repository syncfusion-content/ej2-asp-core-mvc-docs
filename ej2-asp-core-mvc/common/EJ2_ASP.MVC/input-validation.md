---
layout: post
title: Input Form Validation in Syncfusion ##Platform_Name## control
description: Learn here all about Input Form Validation in Syncfusion ##Platform_Name## control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Input Form Validation

The Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC UI input and editor controls can be validated by using [FormValidator](https://ej2.syncfusion.com/javascript/documentation/api/form-validator/) in client side.

## How to Validate Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC UI Controls

1.Add the `Form` component in the **Index.cshtml** page. Also, declare the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC [TextBox](../textbox/getting-started) control inside the `Form` component.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

@{
    IDictionary<string, object> firstNameAttribute = new Dictionary<string, object>()
    {
       { "name", "FirstName" }
    };
    IDictionary<string, object> lastNameAttribute = new Dictionary<string, object>()
    {
       { "name", "LastName" }
    };
}

<form id="form-element">
    <div class="form-group">
        <label for="first-name">First Name:</label>
        @Html.EJS().TextBox("firstname").Placeholder("First Name").Width("25%").HtmlAttributes(firstNameAttribute).Render()
    </div>
    <div class="form-group">
        <label for="last-name">Last Name:</label>
        @Html.EJS().TextBox("lastname").Placeholder("Last Name").Width("25%").HtmlAttributes(lastNameAttribute).Render()
    </div>
    @Html.EJS().Button("submit").Content("Submit").Render()
</form>

{% endhighlight %}
{% endtabs %}

2.The following code shows how to perform client side validation using `FormValidator` inside the script tag.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<script>
    // Sets required property in the FormValidator rules collection
    var options = {
        rules: {
            'FirstName': { required: true },
            'LastName': { required: true },
        },
    };

    // Defines FormValidator to validate the TextBox
    var formObject = new ej.inputs.FormValidator('#form-element', options);

    // Places error label outside the TextBox using the customPlacement event of FormValidator
    formObject.customPlacement = function (element, errorElement) {
        element.parentElement.parentElement.appendChild(errorElement);
    };
    // Form validates the input values using validate method of FormValidator
    document.getElementById("submit").addEventListener('click', function () {
        formObject.validate();
    });
</script>

{% endhighlight %}
{% endtabs %}

3.The `Form` validates the input values and displays the validation message on the `FormValidator` rules when submitting the form.

**Validation Failure:**

![Validation error status](images/validation-error.png)

N> TextBox control supports three types of validation styles. Refer [here](https://ej2.syncfusion.com/aspnetmvc/documentation/textbox/validation).

4.You can use the FormValidator [rules](https://ej2.syncfusion.com/javascript/documentation/api/form-validator/#rules) property to display the custom validation error message for each input control.

{% tabs %}
{% highlight c# tabtitle="CSHTML" %}

<script>
    // sets required property in the FormValidator rules collection
    var options = {
        rules: {
            'FirstName': { required: [true, "Please enter FirstName" ] },
            'LastName': { required: [true, "Please enter LastName" ] },
        },
    };
</script>

{% endhighlight %}
{% endtabs %}

![Validation message for individual input control](images/validation-message.png)

5.You can also use the [submit](https://ej2.syncfusion.com/javascript/documentation/api/form-validator/#submit) event from FromValidator to validate the form manually.

## ASP.NET MVC Form Validation Supported Controls

The following section provides the details about the Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET MVC UI controls that are supported with form validation.

* [Masked TextBox](https://ej2.syncfusion.com/aspnetmvc/documentation/maskedtextbox/how-to/perform-custom-validation-using-form-validator)
* [NumericTextBox](https://ej2.syncfusion.com/aspnetmvc/documentation/numerictextbox/how-to/perform-custom-validation-using-form-validator)
* [Range Slider](https://ej2.syncfusion.com/aspnetmvc/documentation/range-slider/how-to/form-slider-with-form-validator)
* [CheckBox](https://ej2.syncfusion.com/aspnetmvc/documentation/check-box/how-to/name-and-value-in-form-submit)
* [Radio Button](https://ej2.syncfusion.com/aspnetmvc/documentation/radio-button/how-to/name-and-value-in-form-submit)
* [Switch](https://ej2.syncfusion.com/aspnetmvc/documentation/switch/how-to/submit-name-and-value-in-form)
* [DatePicker](https://ej2.syncfusion.com/aspnetmvc/documentation/datepicker/how-to/client-side-validation)
* [TimePicker](https://ej2.syncfusion.com/aspnetmvc/documentation/timepicker/how-to/client-side-validation-using-form-validator)
* [ListBox](https://ej2.syncfusion.com/aspnetmvc/documentation/list-box/how-to/form-submit)
* [In-place Editor](https://ej2.syncfusion.com/aspnetmvc/documentation/in-place-editor/validation)
* [TextBox](https://ej2.syncfusion.com/aspnetmvc/documentation/textbox/validation)
* [RichTextEditor](https://ej2.syncfusion.com/aspnetmvc/documentation/rich-text-editor/validation)
* DateTimePicker
* Calendar
* ColorPicker
* DateRangePicker
* Auto Complete
* ComboBox
* DropDownList
* MultiSelect

## See Also

* [ASP.NET MVC Forms and Validation](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/working-with-forms?view=aspnetcore-6.0)
* [Model validation in ASP.NET MVC and Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-6.0)