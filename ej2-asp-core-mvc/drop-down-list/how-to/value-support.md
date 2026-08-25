---
layout: post
title: How to ensure unique values in ##Platform_Name## DropDownList | Syncfusion
description: Ensure unique values per Syncfusion ##Platform_Name## DropDownList item by mapping the value field to a uniquely-keyed data source property such as Id.
platform: ej2-asp-core-mvc
control: Value Support
publishingplatform: ##Platform_Name##
documentation: ug
---


# How to ensure unique values in ##Platform_Name## DropDownList

The value for each list item must be unique. To ensure uniqueness, map the [value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.DropDowns.DropDownListFieldSettings.html#Syncfusion_EJ2_DropDowns_DropDownListFieldSettings_Value) field of the DropDownList to a uniquely-keyed property on your data source (for example, an `Id` field), and avoid adding duplicate values to the data source. Duplicate values cause selection ambiguity and incorrect value binding on postback.

