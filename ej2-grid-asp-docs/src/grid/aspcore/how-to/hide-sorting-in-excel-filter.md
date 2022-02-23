---
title: "Hide sorting options on excel filter Dialog"
component: "Grid"
description: "Learn how to hide sorting options in excel filter Dialog."
---

# Hide sorting options on excel filter Dialog

You can hide the sorting options on the excel filter dialog by setting display as none for the following classes.

```css
    .e-excel-ascending,
    .e-excel-descending,
    .e-separator.e-excel-separator {
    display: none;
    }
```

{% aspTab template="grid/how-to/disable-sorting-excel", sourceFiles="disable-sorting-excel.cs" %}

{% endaspTab %}
