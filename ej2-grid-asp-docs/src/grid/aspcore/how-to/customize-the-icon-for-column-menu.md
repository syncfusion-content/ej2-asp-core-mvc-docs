---
title: "Customize the icon for column menu"
component: "Grid"
description: "Learn how to customize the icon for column menu."
---

# Customize the icon for column menu

You can customize the column menu icon by overriding the default grid class **.e-icons.e-columnmenu** with a custom property **content** as mentioned below,

```css

.e-grid .e-columnheader .e-icons.e-columnmenu::before {
      content: "\e969";
}

```

In the below sample, grid is rendered with a customized column menu icon.

{% aspTab template="grid/how-to/custom-column-menu-icon", sourceFiles="column-icon.cs" %}

{% endaspTab %}
