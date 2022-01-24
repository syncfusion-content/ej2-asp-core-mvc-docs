---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Selected Field of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Selected Field
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set preselected items through fields

You can use a boolean field(for ex:"isSelected") of MultiSelect dataSource to set preselected items through fields during initial rendering. You can use `itemCreated` event of fields to push items with **isSelected** field set to true and these values will be selected through [dataBound](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~DataBound.html) event of MultiSelect. Pass empty string of array initially to load the control with preselected values.

In the following sample, selected values are mapped through **isSelected** field.

{% aspTab template="multiselect/how-to/selected", sourceFiles="selected.cs,country.cs" %}

{% endaspTab %}
