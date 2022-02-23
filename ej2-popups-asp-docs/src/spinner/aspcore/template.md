---
title: "Template"
component: "Spinner"
description: "This section explains how to customize the Spinner component based on different needs."
---

# Set the template to the Spinner

You can use custom templates on the Spinner instead of the default Spinner by specifying the template in the `setSpinner` method.

The following steps explains you on how to define template for Spinner.

* Pass your custom template to the `setSpinner` method like as below.

```typescript
// Specify the template content to be displayed in the Spinner

setSpinner({ template: '<div style="width:100%;height:100%" class="custom-rolling"><div></div></div>'});
```

> You should set the template to the Spinner before creating the respective Essential JS 2 component. Also,until we replace `setSpinner` template, the further Essential JS 2 component rendering is created with given template only.

* Now, render the Essential JS 2 component. It's render the Spinner with the template specified in the `setSpinner` method.

> In the below sample, we have rendered the Grid component with custom Spinner using `setSpinner` method. You have to define the styles for the template in style section.

{% aspTab template="spinner/template", sourceFiles="template.cs" %}

{% endaspTab %}