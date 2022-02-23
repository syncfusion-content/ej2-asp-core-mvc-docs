---
title: "Drop-down list How to clear the list item"
component: "DropDownList"
description: "This section explains on how to clear the selected items of the Syncfusion ASP.NET drop-down list control."
---

# Clear the selected item in DropDownList

You can clear the selected item in the below two different ways.

By clicking on the `clear icon` which is shown in DropDownList element, you can clear the selected item in
DropDownList through **interaction**. By using [showClearButton](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~ShowClearButton.html) property, you can enable the clear icon in DropDownList element.

Through **programmatic** you can set `null` value to anyone of the index, text or value property to clear the selected item in DropDownList.

The following example demonstrate about how to clear the selected item in DropDownList.

{% aspTab template="dropdownlist/how-to/clear-selected-item", sourceFiles="clearselection.cs" %}

{% endaspTab %}