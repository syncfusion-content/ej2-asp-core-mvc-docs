---
title: "Drop-down list How to detect value change"
component: "DropDownList"
description: "This section explains on how to detect whether the value change happened by manual or programmatic in drop-down list control."
---

# Detect whether the value change happened by manual or programmatic

You can check about whether value change happened by manual or programmatic by
using [change](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.DropDowns.DropDownList~Change.html) event argument that argument name is `isInteracted`.

The following example demonstrate, how to check whether value change happened by manual or programmatic.

{% aspTab template="dropdownlist/how-to/detectchange", sourceFiles="detectchange.cs,Employees.cs" %}

{% endaspTab %}