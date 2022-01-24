---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Create Nested Dialog of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Create Nested Dialog
publishingplatform: ##Platform_Name##
documentation: ug
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