---
title: "Display custom ToolTip for columns in Grid"
component: "Grid"
description: "Learn how to Display custom ToolTip for columns in Grid."
---

# Display custom ToolTip for columns in Grid

To display a custom ToolTip (**EJ2 Tooltip**), you can render the Grid control inside the Tooltip component and set the target as “.e-rowcell”. The tooltip is displayed when hovering the grid cells.

Change the tooltip content for the grid cells by using the following code in the  (**beforeRender**) event.

```typescript

function beforeRender(args) {
        // event triggered before render the tooltip on target element.
        var tooltip = document.getElementById("Tooltip").ej2_instances[0]
        tooltip.content = args.target.closest("td").innerText;
}

```

{% aspTab template="grid/how-to/custom-tooltip", sourceFiles="custom-tooltip.cs" %}

{% endaspTab %}
