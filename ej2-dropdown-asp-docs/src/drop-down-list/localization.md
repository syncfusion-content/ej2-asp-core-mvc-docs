---
title: "Drop-down list Localization"
component: "DropDownList"
description: "This section explains the localization support of the Syncfusion ASP.NET drop-down list control."
---

# Localization

The Localization library allows you to localize static text content of the
[noRecordsTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~NoRecordsTemplate.html)
 and [actionFailureTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~ActionFailureTemplate.html)
&nbsp;properties according to the culture currently assigned to the DropDownList.

| Locale key | en-US (default)
|------|------
| noRecordsTemplate |  No records found
| actionFailureTemplate | The request failed

## Loading translations

To load translation object to your application, use load function of the **L10n** class.

In the following sample, French culture is set to the DropDownList and no data is loaded. Hence, the [noRecordsTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~NoRecordsTemplate.html) property displays its text in French culture initially, and if the sample is run offline, the [actionFailureTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~ActionFailureTemplate.html) property displays its text appropriately.

{% aspTab template="dropdownlist/localization", sourceFiles="localization.cs" %}

{% endaspTab %}

## See Also

* [Accessibility](./accessibility/)
* [How to bind the data to the combobox](./data-binding/)