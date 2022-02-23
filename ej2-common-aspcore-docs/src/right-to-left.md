# Right-To-Left

Right To Left (RTL) can be enabled for Essential JS 2 components by calling `enableRtl` with
`true`. This will render all the Essential JS 2 components in right to left direction. Find the code snippet
for this below.

```html
<script>
    // Enables Right to left alignment for all controls
    ej.base.enableRtl(true);
</script>
```

## Enable RTL to individual component

To control a component’s direction individually you can directly set the component’s `enableRtl` property as true. For illustration, we have enabled RTL for Button component in following code snippet.

{% aspTab template="common/rtl" %}

{% endaspTab %}