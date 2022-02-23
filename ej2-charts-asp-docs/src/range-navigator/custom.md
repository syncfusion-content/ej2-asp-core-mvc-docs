---
title: " RangeNavigator Customization | ASP.NET MVC "

component: "RangeNavigator"

description: "Range navigator can be customized using the navigatorBorder, navigatorStyleSettings, seleced or unselected region color properties."
---

# Customization

## Navigator appearance

The Range Selector can be customized by using the `navigatorStyleSettings`. The `selectedRegionColor` property is used to specify the color for the selected region, whereas the `unselectedRegionColor` property is used to specify the color for the unselected region.

{% aspTab template="range-navigator/custom/appearance", sourceFiles="appearance.cs" %}

{% endaspTab %}

![Range Selector appearance](images/custom/appearance.png)

## Thumb

The thumb property allows to customize the border, fill color, size, and type of thumb. Thumbs can be of two shapes: **Circle** and **Rectangle**.

{% aspTab template="range-navigator/custom/thumb", sourceFiles="thumb.cs" %}

{% endaspTab %}

![Thumb](images/custom/thumb.png)

## Border customization

Using the `navigatorBorder`, the `width` and `color` of the Range Selector border can be customized.

{% aspTab template="range-navigator/custom/border", sourceFiles="border.cs" %}

{% endaspTab %}

![Range Selector Border](images/custom/border.png)

## Deferred update

If the `enableDeferredUpdate` property is set to **true**, then the changed event will be triggered after dragging the slider. If the `enableDeferredUpdate` is **false**, then the changed event will be triggered when dragging the slider. By default,
the `enableDeferredUpdate` is set to **false**.

{% aspTab template="range-navigator/custom/defer", sourceFiles="defer.cs" %}

{% endaspTab %}

## Allow snapping

The `allowSnapping` property toggles the placement of the slider exactly to the left or on the nearest interval.

{% aspTab template="range-navigator/custom/snap", sourceFiles="snap.cs" %}

{% endaspTab %}

## Animation

The speed of the animation can be controlled using the `animationDuration` property. The default value of the `animationDuration` property is **500** milliseconds.

{% aspTab template="range-navigator/custom/animation", sourceFiles="animation.cs" %}

{% endaspTab %}

## See Also

* [Grid and Tick Lines](./grid-tick/)
* [Labels](./labels/)