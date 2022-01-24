---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Add Toggle Button of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Add Toggle Button
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add Toggle Button

Toolbar supports to add a toggle Button by using the template property. Refer below steps

* By using Toolbar template property, pass required HTML String to render toggle button.

```typescript
    template='<button class="e-btn" id="media_btn"></button>'
```

* Now render the toggle Button into the targeted element in Toolbar created event handler and bind click event for it.
On clicking the toggle Button, change the required icon and content based on current active state.

{% aspTab  template="toolbar/how-to/togglebutton", sourceFiles="togglebutton.cs"%}

{% endaspTab %}