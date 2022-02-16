---
layout: post
title: Serialization in ##Platform_Name## Diagram Component
description: Learn here all about Serialization in Syncfusion ##Platform_Name## Diagram component and more.
platform: ej2-asp-core-mvc
control: Serialization
publishingplatform: ##Platform_Name##
documentation: ug
---


# Serialization

**Serialization** is the process of saving and loading for state persistence of the diagram.

## Save

The diagram is serialized as string while saving. The client-side method, [`saveDiagram`](../api/diagram#saveDiagram) helps to serialize the diagram as a string. The following code illustrates how to save the diagram.

```javascript
var diagramElement = document.getElementById('element');
var diagram = diagramElement.ej2_instances[0];
var saveData;
//returns serialized string of the Diagram
saveData = diagram.saveDiagram();

```

This string can be converted to JSON data and stored for future use. The following snippet illustrates how to save the serialized string into local storage.

```javascript
//Saves the string in to local storage
localStorage.setItem('fileName', saveData);
saveData = localStorage.getItem('fileName');

```

Diagram can also be saved as raster or vector image files. For more information about saving the diagram as images, refer to `Print and Export`.

## Load

Diagram is loaded from the serialized string data by client-side method, [`loadDiagram`](../api/diagram#loadDiagram).
The following code illustrates how to load the diagram from serialized string data.

```javascript
var diagramElement = document.getElementById('element');
var diagram = diagramElement.ej2_instances[0];

//Loads the Diagram from saved json data
diagram.loadDiagram(saveData);

```

> Before loading a new diagram, existing diagram is cleared.

## Prevent Default Values

The [`preventDefaults`](https://ej2.syncfusion.com/documentation/api/diagram/serializationSettingsModel) property of serializationSettings is used to simplifying the saved JSON object without adding the default properties that are presented in the diagram.
The following code illustrates how to simplify the JSON object.

```typescript
var diagram: Diagram = new Diagram({
 serializationSettings: { preventDefaults: true },
});