---
title: "Autocomplete Localization"
component: "AutoComplete"
description: "This section explains the Localization support of Syncfusion ASP.NET autocomplete control."
---

# Localization

The Localization library allows you to localize static text content of the
`noRecordsTemplate` and `actionFailureTemplate` properties according to the culture currently assigned to the AutoComplete.

| Locale key | en-US (default)
|------|------
| noRecordsTemplate |  No Records Found
| actionFailureTemplate | The Request Failed

## Loading translations

To load translation object to your application, use load function of the **L10n** class.

In the following sample, French culture is set to the AutoComplete and no data is loaded. Hence, the
[noRecordsTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~NoRecordsTemplate.html) property displays its text in French culture initially and if the sample
is run offline, the [actionFailureTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.AutoCompleteBuilder~ActionFailureTemplate.html) property displays its text appropriately.

{% aspTab template="autocomplete/localization", sourceFiles="localization.cs" %}

{% endaspTab %}

## See Also

* [Accessibility](./accessibility/)
* [How to bind the data to the autocomplete](./data-binding/)