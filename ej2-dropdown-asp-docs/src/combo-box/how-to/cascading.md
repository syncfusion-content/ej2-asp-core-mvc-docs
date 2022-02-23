---
title: "Combo box cascading"
component: "ComboBox"
description: "This section explains cascading of the Syncfusion ASP.NET combo box control."
---

# Configure the Cascading ComboBox

The cascading ComboBox is a series of ComboBox, where the value of one ComboBox depends
upon  another's value. This can be configured by using the [change](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~Change.html) event of the parent ComboBox.
Within that change event handler, data has to be loaded to the child ComboBox based on the selected
value of the parent ComboBox.

The following example, shows the cascade behavior of country, state, and city
ComboBox. Here, the [dataBind](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBoxBuilder~DataBound.html) method is used to reflect the property changes immediately
to the ComboBox.

{% aspTab template="combobox/how-to/cascading", sourceFiles="cascading.cs,Country.cs,Cities.cs,State.cs" %}

{% endaspTab %}