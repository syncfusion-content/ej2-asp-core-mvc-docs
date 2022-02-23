---
title: "Drop-down list cascading"
component: "DropDownList"
description: "This section explains on how to acheive cascading fuctionality in Syncfusion ASP.NET drop-down list control."
---

# Configure the Cascading DropDownList

The cascading DropDownList is a series of DropDownList, where the value of one DropDownList depends
upon  another's value. This can be configured by using the [change](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~Change.html) event of the parent DropDownList.
Within that change event handler, data has to be loaded to the child DropDownList based on the selected
value of the parent DropDownList.

The following example, shows the cascade behavior of country, state, and city
DropDownList. Here, the [dataBind](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownListBuilder~DataBound.html) method is used to reflect the property changes immediately
to the DropDownList.

{% aspTab template="dropdownlist/how-to/cascading", sourceFiles="cascading.cs,Cities.cs,State.cs,Country.cs" %}

{% endaspTab %}