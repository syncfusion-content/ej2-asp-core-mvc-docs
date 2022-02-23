---
title: "Types"
component: "Spinner"
description: "This example demonstrates how to change the type of the Spinner component based on theme."
---

# Change the type of the Spinner

By default, the Spinner is loaded in the applicable Essential JS 2 component based on the theme imported into the page. Based on the theme, the type is set to the Spinner.
The available types are:
* Material
* Fabric
* Bootstrap

You can change the Essential JS 2 component spinner type by passing the type of the spinner as parameter to the `setSpinner` method like as below.

```typescript
// Specify the type of the Spinner to be displayed

setSpinner({ type: 'Bootstrap'});
```

> After Essential JS 2 component creation only, you can change the Essential JS 2 component spinner type.

{% aspTab template="spinner/type", sourceFiles="type.cs" %}

{% endaspTab %}