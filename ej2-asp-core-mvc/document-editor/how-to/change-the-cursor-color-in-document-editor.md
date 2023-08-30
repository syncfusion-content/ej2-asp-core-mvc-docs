---
layout: post
title: How to change the cursor color in document editor using CSS ##Platform_Name## Document Editor Component
description: Learn how to change the cursor color using CSS in ##Platform_Name## Document Editor component of syncfusion and more.
platform: ej2-asp-core-mvc
control: Change The Cursor Color
publishingplatform: ##Platform_Name##
documentation: ug
---

# How to change the cursor color using CSS in Document Editor component

Document Editor default cursor color is black. The user can change the color by overriding the css property using class name. The Document editor cursor css have a class named `e-de-blink-cursor`.

Refer the below code snippet to change the cursor color to red.

```css
.e-de-blink-cursor {
border-left: 1px solid red!important;
}
```

Output will be like below:

![Change the cursor color in document editor](../images/cursor-css.png)
