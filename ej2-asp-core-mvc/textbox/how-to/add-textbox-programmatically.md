---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Add Textbox Programmatically of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Add Textbox Programmatically
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add TextBox programmatically

* Create a TypeScript file and import the `Input` modules
from `ej2-inputs` library as shown below.

```typescript
import {Input} from '@syncfusion/ej2-inputs';
```

* Pass the `HTML Input` element as parameter to the `createInput` method.

* You can also add the `icons` on the input by passing `buttons` property value with the class
name `e-input-group-icon` as parameter to the `createInput` method.

{% aspTab template="textbox/how-to/textbox", sourceFiles="textbox.cs" %}

{% endaspTab %}