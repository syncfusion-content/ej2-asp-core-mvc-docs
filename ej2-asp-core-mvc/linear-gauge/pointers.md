---
layout: post
title: Welcome to Syncfusion Essential ##Platform_Name##
description: Learn here all about Pointers of Syncfusion Essential ##Platform_Name## widgets based on HTML5 and jQuery.
platform: ej2-asp-core-mvc
control: Pointers
publishingplatform: ##Platform_Name##
documentation: ug
---

# Pointers

Pointers are used to indicate values on the axis. Value of the pointer can be modified using the [`value`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~Value.html) property.

{% aspTab template="lineargauge/pointers/pointers", sourceFiles="pointers.cs" %}

{% endaspTab %}

## Types of pointer

The Linear Gauge supports the following two types of pointers:

* Bar
* Marker

You can choose any one of the pointer by using [`type`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~Type.html) property.

## Marker Pointer

A marker pointer is a shape, that can be placed to mark the pointer value in the linear gauge.

<b>Types of marker shapes</b>

The following marker types are available in linear gauge. You can change the marker shape using [`markerType`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~MarkerType.html) property in [`pointer`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer.html) options. The available marker types are,

* Circle
* Rectangle
* Triangle
* InvertedTriangle
* Diamond

You can also use image instead of rendering shape as pointer. It can be achieved by using [`markerType`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~MarkerType.html) property as `Image` set image path to ['imageUrl'](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~ImageUrl.html) in [`pointer`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer.html).

{% aspTab template="lineargauge/pointers/marker-pointer", sourceFiles="marker-pointer.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD036 -->

**Marker Pointer Customization**

The marker can be customized by using the following properties.

* [`height`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~Height.html) - Specifies pointer height
* [`width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~Width.html) - Specifies pointer width
* [`color`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~Color.html) - Specifies pointer color
* [`placement`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~Placement.html) - Specifies pointer placement position, available placement options are 'Near', 'Far', 'Center' and 'None'
* [`offset`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~Offset.html) - Specifies offset value from it default position.
* [`animationDuration`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~AnimationDuration.html) - Specifies pointer animation duration
* [`border`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~Border.html) - Specifies pointer border color and width

{% aspTab template="lineargauge/pointers/marker-pointer-customization", sourceFiles="marker-pointer-customization.cs" %}

{% endaspTab %}

## Bar Pointer

Bar pointer is used to track the axis value and it will render depending upon the container type. Bar pointer starts from the beginning of the gauge and ends at the pointer value.

{% aspTab template="lineargauge/pointers/bar-pointer", sourceFiles="bar-pointer.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD036 -->

**Bar pointer customization**

The bar pointer can be customized using following properties.

* [`width`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~Width.html) - Specifies bar pointer width
* [`color`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~Color.html) - Specifies bar pointer color
* [`offset`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~Offset.html) - Helps to move the bar pointer from its default position.
* [`border`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~Border.html) - Specifies bar pointer border width and color
* [`placement`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~Placement.html) property is not supported for bar pointer.

{% aspTab template="lineargauge/pointers/bar-pointer-customization", sourceFiles="bar-pointer-customization.cs" %}

{% endaspTab %}

## Pointer placement

You can placement the marker pointer in any of the following locations using [`placement`] property.

* Far
* Near
* Center
* None

{% aspTab template="lineargauge/pointers/pointer_placement", sourceFiles="pointer-placement.cs" %}

{% endaspTab %}

## Multiple Pointers

In addition to the default pointer, you can add n number of pointer to an axis.

{% aspTab template="lineargauge/pointers/multiple-pointers", sourceFiles="multiple-pointers.cs" %}

{% endaspTab %}

## Pointer Animation

Pointer will animate on loading the gauge. This can be handled by using
[`animationDuration`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~AnimationDuration.html) property. You need to specify the duration of the animation in milliseconds.

{% aspTab template="lineargauge/pointers/pointer-animation", sourceFiles="pointer-animation.cs" %}

{% endaspTab %}