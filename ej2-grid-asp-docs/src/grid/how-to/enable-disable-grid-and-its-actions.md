---
title: "Enable/Disable Grid and its actions"
component: "Grid"
description: "Learn how to Enable/Disable Grid and its actions."
---

# Enable/Disable Grid and its actions

You can enable/disable the Grid and its actions by applying/removing corresponding CSS styles.

To enable/disable the grid and its actions, follow the given steps:

**Step 1**:

Create CSS class with custom style to override the default style of Grid.

```css
        .disablegrid {
            pointer-events: none;
            opacity: 0.4;
        }
        .wrapper {
            cursor: not-allowed;
        }

```

**Step 2**:

Add/Remove the custom CSS class to the Grid in the click event handler of Button.

```typescript
    <script>
        document.getElementById('element').onclick = function () {
            var gridInst = document.getElementById("Grid").ej2_instances[0];
            if (gridInst.element.classList.contains('disablegrid')) {
                gridInst.element.classList.remove('disablegrid');
                document.getElementById("GridParent").classList.remove('wrapper');
            }
            else {
                gridInst.element.classList.add('disablegrid');
                document.getElementById("GridParent").classList.add('wrapper');
            }
        }
    </script>

```

In the below demo, the button click will enable/disable the Grid and its actions.

{% aspTab template="grid/how-to/disablegrid", sourceFiles="disablegrid.cs" %}

{% endaspTab %}
