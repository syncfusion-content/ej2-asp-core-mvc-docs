---
title: "Slider Limits"
component: "Slider"
description: "Slider control supports limits feature that restricts thumb movement in min & max values and also supports interval dragging between range values."
---

# Movement Limits and Drag Interval

The slider limits restrict the slider thumb between a particular range. This is used if higher or lower value affects the process
or product where the slider is being used.

The following are the six options in the slider's limits object. Each API in the limits object is optional.

* ``enabled``: Enables the limits in the Slider.
* ``minStart``: Sets the minimum limit for the first handle.
* ``minEnd``: Sets the maximum limit for the first handle.
* ``maxStart``: Sets the minimum limit for the second handle.
* ``maxEnd``: Sets the maximum limit for the second handle.
* ``startHandleFixed``: Locks the first handle.
* ``endHandleFixed``: Locks the second handle.

## Default and MinRange Slider limits

There is only one handle in the Default and MinRange Slider, so ``minStart``, ``minEnd``, and ``startHandleFixed`` options can be used.
When the limits are enabled in the Slider, the limited area becomes darken. So you can differentiate the allowed and restricted area.
Refer to the following snippet to enable the limits in the Slider.

{% aspTab template="slider/default-limits", sourceFiles="default-limits.cs" %}

{% endaspTab %}

![ASP .NET Core - Slider - Limits](./images/slider-limits.png)

## Range Slider limits

In the range slider, both handles can be restricted and locked from the limit's object. In this sample, the first handle is limited between
10 and 40, and the second handle is limited between 60 and 90.

{% aspTab template="slider/range-limits", sourceFiles="range-limits.cs" %}

{% endaspTab %}

![ASP .NET Core - Slider - Range Slider Limits](./images/range-slider-limits.png)

## Handle lock

The movement of slider handles can be locked by enabling the ``startHandleFixed`` and ``endHandleFixed`` properties in the limit's object.
In this sample, the movement of both slider handles has been locked.

{% aspTab template="slider/handle-lock", sourceFiles="handle-lock.cs" %}

{% endaspTab %}

![ASP .NET Core - Slider - Handle Lock](./images/handle-lock.png)