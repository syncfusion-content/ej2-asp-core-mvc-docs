---
title: " Rich Text Editor XHTML validation"
component: "Rich Text Editor"
description: "This section explains the XHTML validation of Syncfusion ASP.NET MVC Rich Text Editor control."
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