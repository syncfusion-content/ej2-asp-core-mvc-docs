---
title: "Drop-down list cascading preselect value"
component: "DropDownList"
description: "This section explains on how to preselect value from model with cascading fuctionality in Syncfusion ASP.NET drop-down list control."
---

# Preselect value from model in Cascading DropDownList

The cascading DropDownList is a series of DropDownList, where the value of one DropDownList depends
upon  another's value. Values can be preselected in these DropDownList from model. Use the dataManager to perform the filtering operation on the JSON data for cascading through create event.

The following example, shows how to preselect value from model in cascade DropDownList.

{% aspTab template="dropdownlist/how-to/cascading-preselect", sourceFiles="cascading.cs,State.cs,Country.cs" %}

{% endaspTab %}