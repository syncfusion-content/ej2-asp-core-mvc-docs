# Customize Slider Thumb

Slider appearance can be customized through CSS. By overriding the slider CSS classes, you can customize the thumb. By default,
slider has unique class `e-handle` for slider thumb. You can override the following class as per your requirement. Here, in the
sample, the slider thumb has been customized to square, circle, oval shapes, and background image has also been customized.

```css
.e-control.e-slider .e-handle {
    background-image: url('https://ej2.syncfusion.com/demos/src/slider/images/thumb.png');
    background-color: transparent;
    height: 25px;
    width: 25px;
}
#square_slider.e-control.e-slider .e-handle {
    border-radius: 0%;
    background-color: #f9920b;
    border: 0;
}
#circle_slider.e-control.e-slider .e-handle {
    border-radius: 50%;
    background-color: #f9920b;
    border: 0;
}
#oval_slider.e-control.e-slider .e-handle {
    height: 25px;
    width: 8px;
    top: 3px;
    border-radius: 15px;
    background-color: #f9920b;
}
```

{% aspTab template="slider/custom-thumb", sourceFiles="custom-thumb.cs" %}

{% endaspTab %}

![ASP .NET Core - Slider - Thumb Customization](../images/thumb-customization.png)