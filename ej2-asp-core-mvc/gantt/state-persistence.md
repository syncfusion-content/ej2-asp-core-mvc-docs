---
layout: post
title: State Persistence in ##Platform_Name## Gantt Component
description: Learn here all about State Persistence in Syncfusion ##Platform_Name## Gantt component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: State Persistence
publishingplatform: ##Platform_Name##
documentation: ug
---


# State Persistence Feature

State persistence refers to the Gantt's state maintained in the browser's [`localStorage`](https://www.w3schools.com/html/html5_webstorage.asp#) even if the browser is refreshed or if you move to the next page within the browser.
State persistence stores gantt’s model object in the local storage when the [`enablePersistence`]([https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.Gantt.Gantt~EnablePersistence.html](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html) is defined as true.

## Get or set localStorage value

If the [`enablePersistence`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html) property is set to true, the gantt property value is saved in the **window.localStorage** for reference. You can get/set the localStorage value by using the getItem/setItem method in the **window.localStorage**.

```typescript
//get the Gantt model.
var value = window.localStorage.getItem('ganttGantt'); //"ganttGantt" is component name + component id.
var model = JSON.parse(model);

```

```typescript
//set the Gantt model.
window.localStorage.setItem('ganttGantt', JSON.stringify(model)); //"ganttGantt" is component name + component id.

```
