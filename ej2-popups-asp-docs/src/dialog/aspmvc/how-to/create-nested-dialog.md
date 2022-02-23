---
title: "Create nested Dialog"
component: "Dialog"
description: "Covers customization features such as load content to the dialog from external sources, built-in alert, and confirmation model dialog."
---

# Create nested Dialog

A Dialog can be nested within another Dialog. The below sample contains parent and child Dialog (inner Dialog).

**Step 1**:

Create two div elements with id `#dialog` and `#innerDialog`.

**Step 2**:

Initialize the Dialog as mentioned in the below sample.

**Step 3**:

Set the inner Dialog target as `#dialog`.

{% aspTab template="dialog/how-to/nested-dialog", sourceFiles="controller.cs" %}

{% endaspTab %}

Output be like the below.

![dialog](../images/dialog-nested.png)