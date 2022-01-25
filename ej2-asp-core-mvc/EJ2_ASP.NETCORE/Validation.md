---
layout: post
title: Validation  | ASP.NET MVC | Syncfusion
description: Validation  
platform: ej2-asp-core-mvc
control: Common 
publishingplatform: ##Platform_Name##
documentation: ug
--- 
{% if page.publishingplatform == "aspnet-core" %}

## Validation

You can validate the Autocomplete `value` on form submission by applying `validation-rules` and `validation-message` to the Autocomplete. 

N> [jquery.validate.min](http://cdn.syncfusion.com/js/assets/external/jquery.validate.min.js) script file should be referred for validation, for more details, refer [here](http://jqueryvalidation.org/documentation).

### Validation Rules

The validation rules help you to verify the selected text by adding validation attributes to the input element. This can be set by using `validation-rules` property.

### Validation Messages 

You can set your own custom error message by using `validation-message` property. To display the error message, specify the corresponding annotation attribute followed by the message to display.

N> jQuery predefined error messages to that annotation attribute will be shown when this property is not defined. The below given example explain this behavior of `required` attribute,

When you initialize the Autocomplete widget, it creates an input hidden element which is used to store the selected items value. Hence, the validation is performed based on the value stored in this hidden element.

Required field and min value validation is demonstrated in the below given example.

{% tabs %}

{% highlight razor %}

@model ErrorViewModel

<div id="ControlRegion">
    <div class="frame">
        <div class="control">
            <form id="form1" method="post" asp-controller="Autocomplete"> 
                <ej-autocomplete ej-for="PlanoContasGerencialId" id="autocomplete" datasource="ViewBag.AutocompleteSource" watermark-text="Select Number" change="onChange" validation-rules='new Dictionary<string, object>() { { "required",true}, { "min",30} }'  validation-message='new Dictionary<string, object>() { { "required", "value required"}, { "min","Select > 30"} }'>
                    <e-autocomplete-fields text="Text" key="Value" />
                </ej-autocomplete>
                <span asp-validation-for="PlanoContasGerencialId" class="text-danger"></span><br />
                <input type="submit" value="submit" />
            </form>
        </div>
    </div>
</div>
<script>
    $.validator.setDefaults({
        ignore: [],
        errorClass: 'e-validation-error', // to get the error message on jQuery validation
        errorPlacement: function (error, element) {
            $(error).insertAfter(element.closest(".e-widget"));
        }
        // any other default options and/or rules
    });
    //If necessary, we can create custom rules as below. here method defined for min
    $.validator.addMethod("min",
        function (value, element, params) {
            if (!/Invalid|NaN/.test(value)) {
                return parseInt(value) > params;
            }
        }, 'Must be greater than 30.');

    function onChange() {
        this.element.valid();
    }

</script>

{% endhighlight  %}

{% highlight c# %}

public partial class AutocompleteController : Controller
    {

       // GET: /AutocompleteDefault/
        public ActionResult AutocompleteFeatures()
        {
            List<Data> AutocompleteData = new List<Data>();
            AutocompleteData.Add(new Data { Value = "10", Text = "10" });
            AutocompleteData.Add(new Data { Value = "20", Text = "20" });
            AutocompleteData.Add(new Data { Value = "30", Text = "30" });
            AutocompleteData.Add(new Data { Value = "40", Text = "40" });
            AutocompleteData.Add(new Data { Value = "50", Text = "50" });
            ViewBag.AutocompleteSource = AutocompleteData;
            return View();
        }
    }
    public class Data
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }

{% endhighlight  %}

{% highlight c# %}

namespace SyncfusionASPNETCoreDDL.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        [Required(ErrorMessage = "Selecione a Conta Gerencial !")]
        [Range(1, int.MaxValue, ErrorMessage = "Selecione a Conta Gerencial !")]
        [Display(Name = "Conta Gerencial")]
        public int PlanoContasGerencialId { get; set; }
    }
}

{% endhighlight  %}

{% endtabs %}

The following output is displayed as a result of the above code example.  

![](Validation_images\validation_img1.png)

{% endif %}