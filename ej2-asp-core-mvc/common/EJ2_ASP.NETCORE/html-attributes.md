---
layout: post
title: HTML Attributes in ##Platform_Name## Control
description: Learn here all about HTML Attributes in Syncfusion ##Platform_Name## Common control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Common
publishingplatform: ##Platform_Name##
documentation: ug
---

# Default HTML Attributes and DOM Events

The Syncfusion ASP.NET Core UI controls provide the most useful [public API](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.html) for control implementation and customization. Apart from this public API, the Syncfusion ASP.NET Core UI controls can support the use of default [HTML attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes) in the root element of its control and input [DOM events](#input-dom-events) can be applied in the client side.

## Using HTML Attributes and DOM Events in the Input Element

The following is a list of Syncfusion ASP.NET Core UI Controls that use the standard HTML `input` element. You can apply the [HTML input attributes](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input) and DOM events directly to the input element used on these Syncfusion ASP.NET Core Controls.

* [AutoComplete](../autocomplete/getting-started/)
* [CheckBox](../check-box/getting-started/)
* [ComboBox](../combo-box/getting-started/)
* [DatePicker](../datepicker/getting-started/)
* [DateRangePicker](../daterangepicker/getting-started/)
* [DateTimePicker](../datetimepicker/getting-started/)
* [DropDownList](../drop-down-list/getting-started)
* [DropDownTree](../drop-down-tree/getting-started)
* [MaskedTextBox](../maskedtextbox/getting-started)
* [MultiSelect](../multi-select/getting-started)
* [NumericTextBox](../numerictextbox/getting-started/)
* [RadioButton](../radio-button/getting-started)
* [TextBox](../textbox/getting-started/)
* [TimePicker](../timepicker/getting-started/)
* [Upload](../uploader/getting-started)
* [DropDownButton](../drop-down-button/getting-started)
* [ProgressButton](../progress-button/getting-started)
* [SplitButton](../split-button/getting-started)
* [InPlaceEditor](../in-place-editor/getting-started)
* [Slider](../range-slider/getting-started)
* [Switch](../switch/getting-started)

### Available Syncfusion Properties Equivalent to HTML Attributes

The following table illustrates the HTML attributes and their equivalent Syncfusion API.

<!-- markdownlint-disable MD033 -->
<table>
<tr>
<td><b>HTML Attribute</b></td>
<td><b>Syncfusion API</b></td>
<td><b>Controls</b></td>
</tr>
<tr>
<td><a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#attr-id">id</a></td>
<td>ID</td>
<td>
<ul>
<li>All Controls</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#htmlattrdefautocomplete">autocomplete</a></td>
<td>Autocomplete</td>
<td>
<ul>
<li>TextBox</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#htmlattrdefchecked">checked</a></td>
<td>Checked</td>
<td>
<ul>
<li>CheckBox</li>
<li>RadioButton</li>
<li>Switch</li>
</ul>
</td>
</tr>
<tr>
<td rowspan="2"><a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#htmlattrdefdisabled">disabled</a></td>
<td>Disabled</td>
<td>
<ul>
<li>Button</li>
<li>CheckBox</li>
<li>ColorPicker</li>
<li>InPlaceEditor</li>
<li>RadioButton</li>
<li>DropDownButton</li>
<li>ProgressButton</li>
<li>SplitButton</li>
<li>Switch</li>
</ul>
</td>
</tr>
<tr>
<td>Enabled</td>
<td>
<ul>
<li>DatePicker</li>
<li>DateRangePicker</li>
<li>DateTimePicker</li>
<li>DropDownList</li>
<li>DropDownTree</li>
<li>ListBox</li>
<li>MaskedTextBox</li>
<li>MultiSelect</li>
<li>NumericTextBox</li>
<li>Uploader</li>
<li>TimePicker</li>
<li>Slider</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#htmlattrdefmax">max</a></td>
<td>Max</td>
<td>
<ul>
<li>DatePicker</li>
<li>DateRangePicker</li>
<li>DateTimePicker</li>
<li>NumericTextBox</li>
<li>TimePicker</li>
<li>Slider</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#htmlattrdefminlength">min</a></td>
<td>Min</td>
<td>
<ul>
<li>DatePicker</li>
<li>DateRangePicker</li>
<li>DateTimePicker</li>
<li>NumericTextBox</li>
<li>TimePicker</li>
<li>Slider</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#htmlattrdefmultiple">multiple</a></td>
<td>Multiple</td>
<td>
<ul>
<li>Upload</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#htmlattrdefplaceholder">placeholder</a></td>
<td>Placeholder</td>
<td>
<ul>
<li>Except below controls:</li>
<li>CheckBox</li>
<li>RadioButton</li>
<li>Upload</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/readonly">readonly</a></td>
<td>ReadOnly</td>
<td>
<ul>
<li>AutoComplete</li>
<li>ComboBox</li>
<li>DatePicker</li>
<li>DateRangePicker</li>
<li>DateTimePicker</li>
<li>DropDownList</li>
<li>DropDownTree</li>
<li>MaskedTextBox</li>
<li>MultiSelect</li>
<li>Slider</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#htmlattrdefstep">step</a></td>
<td>Step</td>
<td>
<ul>
<li>NumericTextBox</li>
<li>Slider</li>
<li>TimePicker</li>
<li>DateTimePicker</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#htmlattrdefvalue">value</a></td>
<td>Value</td>
<td>
<ul>
<li>Except below control:</li>
<li>Upload</li>
</ul>
</td>
</tr>
<tr>
<td><a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#htmlattrdefwidth">width</a></td>
<td>Width</td>
<td>
<ul>
<li>Except below controls:</li>
<li>CheckBox</li>
<li>RadioButton</li>
<li>Upload</li>
</ul>
</td>
</tr>
</table>
<!-- markdownlint-enable MD033 -->

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}
<ejs-textbox id="textbox" name="first-name" title="First name" autocomplete="Off"></ejs-textbox>
{% endhighlight %}
{% endtabs %}

The textbox will be rendered with the following output.

{% tabs %}
{% highlight c# tabtitle="DOM" %}
<span class="...">
    <input id="textbox" class="..." name="first-name" type="text" autocomplete="off" title="First name" minlength="15" ... />
</span>
{% endhighlight %}
{% endtabs %}

In some cases, you may need to add HTML attributes to the root/container element of the above input-based controls. For this, you can use [HtmlAttributes](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Buttons.Button.html#Syncfusion_EJ2_Buttons_Button_HtmlAttributes) Syncfusion API to add HTML attributes to the root/container element.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}
@{
    IDictionary<string, object> customAttribute = new Dictionary<string, object>()
    {
       { "style", "background:aliceblue;" },
    };
}
<ejs-textbox id="first" htmlAttributes="customAttribute"></ejs-textbox>
{% endhighlight %}
{% endtabs %}

The textbox will be rendered with the following output.

{% tabs %}
{% highlight c# tabtitle="DOM" %}
<span class="..." style="background: aliceblue;" ....>
    <input id="first" .... />
</span>
{% endhighlight %}
{% endtabs %}

## Input DOM Events

The Syncfusion ASP.NET Core UI control supports binding the native DOM events on the input element.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}
<div class="alert "></div>

<ejs-textbox id="first"></ejs-textbox>

<script>
    var input = document.querySelector('.alert');
    document.getElementById("first").addEventListener("focus", function () {
        input.innerHTML = "Focus event is triggered on the TextBox.";
        input.classList.add('alert-info');
    });

    document.getElementById("first").addEventListener("blur", function () {
        input.innerHTML = "Focusout event is triggered on the TextBox.";
        input.classList.add('alert-info');
    });
</script>
{% endhighlight %}
{% endtabs %}
