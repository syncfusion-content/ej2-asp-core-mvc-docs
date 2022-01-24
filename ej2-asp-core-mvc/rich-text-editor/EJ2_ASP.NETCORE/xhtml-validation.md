---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Xhtml Validation of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Xhtml Validation
publishingplatform: ##Platform_Name##
documentation: ug
---


# XHTML validation

The editor provides an option to validate the source content of the Rich Text Editor against the XHTML standard using the 'enableXhtml' property. When you enter or modify content in the editor, it continuously checks the XHTML source content and removes elements and attributes that are not valid.

The editor checks the following settings on validation:

## Attributes

* Must be specified in lowercase.
* Proper use of quotation marks around the attributes.
* Must be valid attributes for corresponding HTML element.
* All the required attributes must be included in the HTML element.

## HTML Elements

* Must be in lowercase.
* All opening tags must be closed.
* Allows only the valid HTML elements.
* Elements must be properly nested.
* All elements must have one root element.
* Should not use inline elements inside the block elements.

{% aspTab template="rich-text-editor/xhtml-validation", sourceFiles="controller.cs" %}

{% endaspTab %}