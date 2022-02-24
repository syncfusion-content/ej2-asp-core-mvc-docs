---
layout: post
title: Get or Set Local Storage Value in ##Platform_Name## Grid Component
description: Learn here all about Get or Set Local Storage Value in Syncfusion ##Platform_Name## Grid component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core
control: Get or Set Local Storage Value
publishingplatform: aspnet-core
documentation: ug
---


# Get or Set Local Storage Value

If the [`enablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Grids.Grid.html#Syncfusion_EJ2_Grids_Grid_EnablePersistence) property is set to true, the grid property value is saved in the **window.localStorage** for reference. You can get/set the localStorage value by using the **getItem**/**setItem** method in the **window.localStorage**.

```typescript
//get the Grid model.
var value = window.localStorage.getItem('gridGrid'); //"gridGrid" is component name + component id.
var model= JSON.parse(model);

```

```typescript
//set the Grid model.
window.localStorage.setItem('gridGrid', JSON.stringify(model)); //"gridGrid" is component name + component id.

```