---
title: "Combo box Localization"
component: "ComboBox"
description: "This section explains the localization support of the Syncfusion ASP.NET combo box control."
---

# Localization

The Localization library allows you to localize static text content of the
[noRecordsTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~NoRecordsTemplate.html)
 and [actionFailureTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~ActionFailureTemplate.html) properties according to the culture currently assigned to the ComboBox.

| Locale key | en-US (default)
|------|------
| noRecordsTemplate |  No records found
| actionFailureTemplate | The request failed

## Loading translations

To load translation object to your application, use `load` function of **L10n** class.

In the following sample, French culture is set to the ComboBox and no data is loaded. Hence, the [noRecordsTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~NoRecordsTemplate.html) property displays its text in French culture initially, and if the sample is run offline, the [actionFailureTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.ComboBox~ActionFailureTemplate.html) property displays its text appropriately.

{% aspTab template="combobox/localization", sourceFiles="localization.cs" %}

{% endaspTab %}

## See Also

* [Accessibility](./accessibility/)
* [How to bind the data to the combobox](./data-binding/)