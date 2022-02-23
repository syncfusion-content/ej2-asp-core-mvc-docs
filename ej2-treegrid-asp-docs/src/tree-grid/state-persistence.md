---
title: "State Persistence"
component: "TreeGrid"
description: "Learn how to persist the TreeGrid state and model in the browser’s local storage."
---

# State Persistence

State persistence refers to the TreeGrid's state maintained in the browser's [`localStorage`](https://www.w3schools.com/html/html5_webstorage.asp#) even if the browser is refreshed or if you move to the next page within the browser.
State persistence stores treegrid’s model object in the local storage when the [`enablePersistence`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~EnablePersistence.html) is defined as true.

## Get or set localStorage value

If the [`enablePersistence`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.TreeGrid.TreeGrid~EnablePersistence.html) property is set to true, the treegrid property value is saved in the **window.localStorage** for reference. You can get/set the localStorage value by using the getItem/setItem method in the **window.localStorage**.

```typescript
//get the TreeGrid model.
var value = window.localStorage.getItem('treegridTreeGrid'); //"treegridTreeGrid" is component name + component id.
var model = JSON.parse(model);

```

```typescript
//set the TreeGrid model.
window.localStorage.setItem('treegridTreeGrid', JSON.stringify(model)); //"treegridTreeGrid" is component name + component id.

```