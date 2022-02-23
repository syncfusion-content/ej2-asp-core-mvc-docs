---
title: "User Interactions in ASP.NET MVC Linear Gauge component | Syncfusion"

component: "Linear Gauge"

description: "Learn here all about the User Interactions feature of Syncfusion ASP.NET MVC Linear Gauge component and more."
---

# User Interaction in ASP.NET Linear Gauge

## Tooltip

<!-- markdownlint-disable MD036 -->

Linear Gauge displays the details about a pointer value through [`LinearGaugeTooltipSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html), when the mouse hovers over the pointer. To enable the tooltip, set [`Enable`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html#Syncfusion_EJ2_LinearGauge_LinearGaugeTooltipSettings_Enable) property as **true**.

{% aspTab template="lineargauge/user-interactions/tooltip", sourceFiles="" %}

{% endaspTab %}
![Linear Gauge with tooltip](../images/tooltip.png)

<!-- markdownlint-disable MD013 -->

### Tooltip format

<!-- markdownlint-disable MD013 -->

Tooltip in the Linear Gauge control can be formatted using the [`Format`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html#Syncfusion_EJ2_LinearGauge_LinearGaugeTooltipSettings_Format) property in [`LinearGaugeTooltipSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html). It is used to render the tooltip in certain format or to add a user-defined unit in the tooltip. By default, the tooltip shows the pointer value only. In addition to that, more information can be added in the tooltip. For example, the format **{value}km** shows pointer value with kilometer unit in the tooltip.

{% aspTab template="lineargauge/user-interactions/tooltip-format", sourceFiles="" %}

{% endaspTab %}

![Linear Gauge with tooltip format](../images/tooltip-formats.png)

### Tooltip Template

The HTML element can be rendered in the tooltip of the Linear Gauge using the [`Template`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html#Syncfusion_EJ2_LinearGauge_LinearGaugeTooltipSettings_Template) property in [`LinearGaugeTooltipSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html). The **${value}** can be used as placeholders in the HTML element to display the pointer values of the corresponding axis.

{% aspTab template="lineargauge/user-interactions/tooltip-template", sourceFiles="" %}

{% endaspTab %}

![Linear Gauge with tooltip template](../images/tooltip-template1.png)

### Customize the appearance of the tooltip

The tooltip can be customized using the following properties in [`LinearGaugeTooltipSettings`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html).

* [`Fill`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html#Syncfusion_EJ2_LinearGauge_LinearGaugeTooltipSettings_Fill) - To fill the color for tooltip.
* [`EnableAnimtion`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html#Syncfusion_EJ2_LinearGauge_LinearGaugeTooltipSettings_EnableAnimation) - To enable or disable the tooltip animation.
* [`Border`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html#Syncfusion_EJ2_LinearGauge_LinearGaugeTooltipSettings_Border) - To set the border color and width of the tooltip.
* [`TextStyle`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html#Syncfusion_EJ2_LinearGauge_LinearGaugeTooltipSettings_TextStyle) - To customize the style of the text in tooltip.
* [`ShowAtMousePosition`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html#Syncfusion_EJ2_LinearGauge_LinearGaugeTooltipSettings_ShowAtMousePosition) - To show the tooltip at the mouse position.

{% aspTab template="lineargauge/user-interactions/tooltip-appearance", sourceFiles="" %}

{% endaspTab %}

![Linear Gauge with tooltip customization](../images/tooltip-custom.png)

## Positioning the tooltip

The tooltip is positioned at the **End** of the pointer. To change the position of the tooltip at the start, or center of the pointer, set the [`Position`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html#Syncfusion_EJ2_LinearGauge_LinearGaugeTooltipSettings_Position) property to **Start** or **Center**.

{% aspTab template="lineargauge/user-interactions/tooltip-position", sourceFiles="" %}

{% endaspTab %}

![Linear Gauge with tooltip position](../images/tooltip-position.png)

## Pointer Drag

To drag either marker or bar pointer to the desired axis value, set the [`EnableDrag`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugePointer.html#Syncfusion_EJ2_LinearGauge_LinearGaugePointer_EnableDrag) property as **true** in [`LinearGaugePointer`](https://help.syncfusion.com/cr/aspnetmvc-js2/Syncfusion.EJ2.LinearGauge.LinearGaugePointer.html).

{% aspTab template="lineargauge/user-interactions/pointer-drag", sourceFiles="" %}

{% endaspTab %}

![Linear Gauge with pointer drag](../images/dragging-pointr.gif)