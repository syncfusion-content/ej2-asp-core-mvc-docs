---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about New Row Position of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: New Row Position
publishingplatform: ##Platform_Name##
documentation: ug
---


# Set new row position in Gantt

In Gantt, a new row can be added in one of the following positions: Top, Bottom, Above, Below and Child. This position can be specified through the `newRowPostion` property. We can make use of the toolbarClick event to create a context menu that specifies the position in which the new row is to be added when adding a record through toolbar click.

The following code snippets demonstrate how to achieve this.

{% aspTab template="gantt/how-to/newrowposition", sourceFiles="newrowposition.cs" %}

{% endaspTab %}