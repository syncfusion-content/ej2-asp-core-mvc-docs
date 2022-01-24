---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Show Tooltip On Disabled Elements And Disable Tooltip of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Show Tooltip On Disabled Elements And Disable Tooltip
publishingplatform: ##Platform_Name##
documentation: ug
---

# Show Tooltip on disabled elements and disable tooltip

By default, Tooltips will not be displayed on disabled elements. However, it is possible to enable this behavior by following the steps below.

1. Add a disabled element like the `button` element into a div whose display style is set to `inline-block`.
2. Set the pointer event as `none` for the disabled element (button) through CSS.
3. Now, initialize the Tooltip for outer div element that holds the disabled button element.

{% aspTab template="tooltip/tooltip-disabed", sourceFiles="disabled.cs" %}

{% endaspTab %}
