---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Open Event Editor Manually of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Open Event Editor Manually
publishingplatform: ##Platform_Name##
documentation: ug
---

# Open Editor Window Manually

## Open Editor Window externally

Scheduler allows the user to manually open the event editor on specific time or on certain events using `openEditor` method. To open the editor on specific range of time, user need to pass the cell details as first argument and **Add** as second argument whereas to open it on event pass that event detail and **Save** as arguments. In the following code example, on clicking the respective button will open the respective editor window manually.

{% aspTab template="schedule/how-to/event-editor", sourceFiles="data.cs"  %}

{% endaspTab %}

## Open editor window on single click

By default, Scheduler Editor window will open when double clicking the cells or appointments. You can also open the editor window with single click by using `openEditor` method in `eventClick` and `cellClick` events of scheduler and setting false to `showQuickInfo`. The following example shows how to open editor window on single click of cells and appointments.

{% aspTab template="schedule/how-to/single-click-editor", sourceFiles="data.cs"  %}

{% endaspTab %}
