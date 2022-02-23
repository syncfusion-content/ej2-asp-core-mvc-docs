---
title: "Add TextBox programmatically"
component: "Textbox"
description: "Covers customization of the text box component such as a rounded corner, disabled, read-only state, background color, and font color."
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