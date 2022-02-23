---
title: "Multiselect How to"
component: "MultiSelect"
description: "This section demonstrates how to set preselected items through fields the Syncfusion ASP.NET multiselect control."
---

# Set preselected items through fields

You can use a boolean field(for ex:"isSelected") of MultiSelect dataSource to set preselected items through fields during initial rendering. You can use `itemCreated` event of fields to push items with **isSelected** field set to true and these values will be selected through [dataBound](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~DataBound.html) event of MultiSelect. Pass empty string of array initially to load the control with preselected values.

In the following sample, selected values are mapped through **isSelected** field.

{% aspTab template="multiselect/how-to/selected", sourceFiles="selected.cs,country.cs" %}

{% endaspTab %}
