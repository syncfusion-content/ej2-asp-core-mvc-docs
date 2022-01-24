---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Horizontal of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Horizontal
publishingplatform: ##Platform_Name##
documentation: ug
---

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