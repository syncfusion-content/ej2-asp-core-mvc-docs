---
layout: post
title: Animation in ##Platform_Name## Common Component
description: Learn here all about Animation in Syncfusion ##Platform_Name## Common component and more.
platform: ej2-asp-core-mvc
control: Animation
publishingplatform: ##Platform_Name##
documentation: ug
---

# Animation

The **Animation** library is used to perform animation effects on HTML elements by running sequence of frames.

## Animating a HTML Element

The `animate` method of `Animation` library can be used to animate the HTML elements. This method can also take additional `AnimationModel`. Refer the below code snippet to animate a multiple DOM element.

```typescript

import {Animation} from '@syncfusion/ej2-base';
let animation: Animation = new Animation({ duration: 5000 });
animation.animate('#element1', { name: 'FadeOut' });
animation.animate('#element2', { name: 'ZoomOut' });
```