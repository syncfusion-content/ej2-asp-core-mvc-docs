---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Name And Value In Form Submit of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Name And Value In Form Submit
publishingplatform: ##Platform_Name##
documentation: ug
---


# Name and Value in form submit

The name attribute of the CheckBox is used to group Checkboxes. When the Checkboxes are grouped in form, the checked items value attribute
will post to the server on form submit that can be retrieved through the name. The disabled and unchecked CheckBox
value will not be sent to the server on form submit.

In the following code snippet, Cricket and Hockey are in the checked state, Tennis is in disabled state and Basketball is in unchecked state.
Now, the value that is in checked state only be sent on form submit.

{% aspTab template="check-box/howto/form", sourceFiles="form.cs" %}

{% endaspTab %}