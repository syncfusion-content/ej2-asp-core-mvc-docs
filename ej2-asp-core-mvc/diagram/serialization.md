---
layout: post
title: Serialization in ##Platform_Name## Diagram Control | Syncfusion
description: Learn here all about Serialization in Syncfusion ##Platform_Name## Diagram component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Serialization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Serialization in Diagram Control

**Serialization** is the process of saving and loading for state persistence of the diagram.

## Save

The diagram is serialized as string while saving. The client-side method, [`saveDiagram`](../api/diagram#saveDiagram) helps to serialize the diagram as a string.

```javascript
var diagramElement = document.getElementById('element');
var diagram = diagramElement.ej2_instances[0];
var saveData;
//returns serialized string of the Diagram
saveData = diagram.saveDiagram();
```

This string can be converted to JSON data and stored for future use.

```javascript
//Saves the string in to local storage
localStorage.setItem('fileName', saveData);
saveData = localStorage.getItem('fileName');
```

Diagram can also be saved as raster or vector image files. For more information about saving the diagram as images, refer to `Print and Export`.

## Load

Diagram is loaded from the serialized string data by client-side method, [`loadDiagram`](../api/diagram#loadDiagram).

```javascript
var diagramElement = document.getElementById('element');
var diagram = diagramElement.ej2_instances[0];

//Loads the Diagram from saved json data
diagram.loadDiagram(saveData);

```

N> Before loading a new diagram, existing diagram is cleared.

## Prevent Default Values

The [`preventDefaults`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Diagrams.DiagramSerializationSettings.html#Syncfusion_EJ2_Diagrams_DiagramSerializationSettings_PreventDefaults) property of serializationSettings is used to simplifying the saved JSON object without adding the default properties that are presented in the diagram.

```typescript
var diagram: Diagram = new Diagram({
 serializationSettings: { preventDefaults: true },
});
```