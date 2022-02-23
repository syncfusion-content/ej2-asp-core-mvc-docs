---
title: "CSS Structure"
component: "Diagram"
description: "CSS Structure is used to customize the style in diagram component"
---

# CSS Structure

## Customizing the connector end point handle

Use the following CSS to customize the connector end point handle.

```scss

.e-diagram-endpoint-handle {
    fill: red;
    stroke: green;
   }

```

## Customizing the connector end point handle when connected

Use the following CSS to customize the connector end point handle when connected.

```scss

.e-diagram-endpoint-handle.e-connected {
    fill: red;
    stroke: green;
   }

```

## Customizing the connector end point handle when disabled

Use the following CSS to customize the connector end point handle when disabled.

```scss

.e-diagram-endpoint-handle.e-disabled {
    fill: red;
    opacity: 1;
    stroke: green;
   }

```

## Customizing the bezier connector handle

Use the following CSS to customize the bezier handle properties.

```scss

.e-diagram-bezier-handle {
    fill: red;
    stroke: green;
  }

```

## Customizing the bezier connector line

Use the following CSS to customize the bezier line properties.

```scss

.e-diagram-bezier-line {
    stroke: black;
  }

```

## Customizing the resize handle

Use the following CSS to customize the resize handle.

```scss

.e-diagram-resize-handle {
    fill: white;
    opacity: 1;
    stroke: white;
  }
```

## Customizing the selector pivot line

Use the following CSS to customize the line between the selector and rotate handle.

```scss

 .e-diagram-pivot-line {
    stroke: red;
  }

```

## Customizing the selector border

Use the following CSS to customize the selector border.

```scss

.e-diagram-border {
    stroke: red;
  }

```

## Customizing the rotate handle

Use the following CSS to customize the rotate handle properties.

```scss

.e-diagram-rotate-handle {
    fill: red;
    stroke: green;
  }

```

## Customizing the symbolpalette while hovering

Use the following CSS to customize the symbolpalette while hovering.

```scss

.e-symbolpalette .e-symbol-hover:hover {
    background: red;
  }

```

## Customizing the symbolpalette when selected

Use the following CSS to customize the symbolpalette when selected.

```scss

.e-symbolpalette .e-symbol-selected {
    background: white;
  }

```

## Customizing the ruler

Use the following CSS to customize the ruler properties.

```scss

.e-diagram .e-ruler {
    background-color: red;
    font-size: 13px;
  }

```

## Customizing the ruler overlap

Use the following CSS to ruler overlap properties.

```scss

.e-diagram .e-ruler-overlap {
    background-color: red;
  }

```

## Customizing the text edit

Use the following CSS to customize the text edit properties.

```scss

 .e-diagram .e-diagram-text-edit {
    background: white;
    border-color: red;
    border-style: dashed;
    border-width: 1px;
    box-sizing: content-box;
    color: black;
    min-width: 50px;
  }

```

## Customizing the text edit on selection

Use the following CSS to customize the text edit on selection properties.

```scss

 .e-diagram-text-edit::selection {
    background: red;
    color: green;
  }

```
