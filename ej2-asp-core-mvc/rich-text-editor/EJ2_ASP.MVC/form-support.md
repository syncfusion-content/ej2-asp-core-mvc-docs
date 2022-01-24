---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Form Support of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Form Support
publishingplatform: ##Platform_Name##
documentation: ug
---


# Form support

This below sample demonstrate how to get the Rich Text Editor value in button click.

## Render the Rich Text Editor

Render the Rich Text Editor in form as below.

```html

<form id="myForm" class="form-vertical">
<div class="form-group">
@Html.EJS().RichTextEditor("defaultRTE").MaxLength(100).Render()
<div id="dateError" style="padding-top: 10px"></div>
</div>
<div style="text-align: center">
<button id="validateSubmit" class="samplebtn e-control e-btn" type="submit" data-ripple="true">Submit</button>
<button id="resetbtn" class="samplebtn e-control e-btn" type="reset" data-ripple="true">Reset</button>
</div>
</form>

```

## Obtain the Value

Upon submitting the form, `getValue` method will be triggered. Through the `FormData` class, Rich Text Editor value obtained as below.

{% aspTab template="rich-text-editor/form-sample", sourceFiles="controller.cs" %}

{% endaspTab %}

## See Also

* [How to integrate the third party library](./third-party-integration/)
* [How to validate the value](./validation/)