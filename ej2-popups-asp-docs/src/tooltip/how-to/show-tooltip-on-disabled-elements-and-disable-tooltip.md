# Show Tooltip on disabled elements and disable tooltip

By default, Tooltips will not be displayed on disabled elements. However, it is possible to enable this behavior by following the steps below.

1. Add a disabled element like the `button` element into a div whose display style is set to `inline-block`.
2. Set the pointer event as `none` for the disabled element (button) through CSS.
3. Now, initialize the Tooltip for outer div element that holds the disabled button element.

{% aspTab template="tooltip/tooltip-disabed", sourceFiles="disabled.cs" %}

{% endaspTab %}
