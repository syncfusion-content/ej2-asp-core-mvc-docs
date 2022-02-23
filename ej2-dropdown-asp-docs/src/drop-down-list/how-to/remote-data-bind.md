---
title: "Drop-down list How to get total count"
component: "DropDownList"
description: "This section explains on how to get the total count of list items of the Syncfusion ASP.NET drop-down list control."
---

# Get the total count of data when remote data bind with DropDownList

Before control rendering, you can get the total items count by using [actionComplete](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~ActionComplete.html) event with its result arguments.
After rendering this control, you can get the total items count by using `getItems` method.

The following example demonstrate how to get the total items count.

{% aspTab template="dropdownlist/how-to/totalcount", sourceFiles="totalcount.cs" %}

{% endaspTab %}