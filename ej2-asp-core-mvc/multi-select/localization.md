---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Localization of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Localization
publishingplatform: ##Platform_Name##
documentation: ug
---

| noRecordsTemplate |  No records found
| actionFailureTemplate | The request failed

## Loading translations

To load translation object to your application, use load function of the **L10n** class.

In the following sample, French culture is set to the MultiSelect and no data is loaded. Hence, the [noRecordsTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~NoRecordsTemplate.html) property displays its text in French culture initially, and if the sample is run offline, the [actionFailureTemplate](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.MultiSelect~ActionFailureTemplate.html) property displays its text appropriately.

{% aspTab template="multiselect/localization", sourceFiles="localization.cs" %}

{% endaspTab %}

## See Also

* [Accessibility](./accessibility/)
* [How to bind the data to the combobox](./data-binding/)