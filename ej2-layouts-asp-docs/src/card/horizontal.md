---
title: "Horizontal Card"
component: "Card"
description: "This section explains how to align the Essential JS 2 cards vertically and differentiate from horizontal layout."
---

# Horizontal Card

By default, all the card elements are aligned vertically one after the other as in the DOM. You can achieve the element to align horizontally as well by adding the class `e-card-horizontal` in the root card element.

## Stacked cards

* An horizontally aligned card can push a specific column to align vertical using `e-card-stacked` class. This will align the stacked section vertically aligned differentiating from horizontal layout.

Class   | Description
------------ | -------------
`e-card-horizontal` | To align card elements horizontally.
`e-card-stacked` | To align elements vertically within the horizontal layout.

```html
        <div tabindex="0" class="e-card e-card-horizontal">
            <img src="code1.png" alt="Sample">   --> Aligned in horizontal
            <div class="e-card-stacked">         --> Aligned in horizontal
               // Inside the element all are aligned vertical directions
            </div>
        </div>
```

{% aspTab template="card/card_horizontal", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![CSS Card Control with horizontal structure](./images/card-horizontal.PNG)