---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Custom Field of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Custom Field
publishingplatform: ##Platform_Name##
documentation: ug
---


# Add Custom Fields in the General Tab in Add/Edit Dialog

Generally in Gantt, Custom fields are displayed in the Custom Tab of the Add/Edit dialogs. However, they can be included in the General Tab of Add/Edit Dialog Box using `actionBegin` and `actionComplete` events. These events are used to append the custom field to the dialog box. The following code snippets demonstrate the solution.

{% aspTab template="gantt/how-to/customfield", sourceFiles="customfield.cs" %}

{% endaspTab %}