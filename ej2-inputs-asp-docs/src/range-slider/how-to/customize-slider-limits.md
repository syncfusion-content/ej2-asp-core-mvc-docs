# Customize Slider Limits

Slider appearance can be customized via CSS. By overriding the slider CSS classes, the slider limit bar can be customized.
Here, the limit bar is customized with different background color. By default, the slider has class `e-limits` for limits bar.
You can override the class with our own color values as given in the following code snippet.

```css
.e-slider-container.e-horizontal .e-limits {
    background-color: rgba(69, 100, 233, 0.46);
}
```

{% aspTab template="slider/custom-limits", sourceFiles="custom-limits.cs" %}

{% endaspTab %}

![ASP .NET Core - Slider - Limit Customization](../images/limit-customization.png)