# User Interaction

## Tooltip

<!-- markdownlint-disable MD036 -->

Linear gauge will display the details about the pointer value through [tooltip](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings.html), when the mouse is moved over the pointer. By default, tooltip will not be visible and you can enable the tooltip by setting [`enable`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings~Enable.html) property to true.

{% aspTab template="lineargauge/user-interactions/tooltip", sourceFiles="tooltip.cs" %}

{% endaspTab %}

<!-- markdownlint-disable MD013 -->

**Format the Tooltip**

<!-- markdownlint-disable MD013 -->

By default, tooltip will show the pointer value only. In addition to that, you can show more information in tooltip. For example, the format `${value}` shows pointer value with currency symbol.

{% aspTab template="lineargauge/user-interactions/tooltip-format", sourceFiles="tooltip-format.cs" %}

{% endaspTab %}

**Tooltip Template**

Any HTML elements can be displayed in the tooltip by using the [`template`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings~Template.html) property of the tooltip. You can use the {value} as placeholders in the HTML element to display the pointer values of the corresponding axis.

{% aspTab template="lineargauge/user-interactions/tooltip-template", sourceFiles="tooltip-template.cs" %}

{% endaspTab %}

**Customize the Appearance of Tooltip**

* [`fill`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings~Fill.html) - Specifies fill color for tooltip
* [`border`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings~Border.html) - Specifies tooltip border width and color
* [`textStyle`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugeTooltipSettings~TextStyle.html) - Specifies the tooltip text style, such as color, font family, font style and font weight

{% aspTab template="lineargauge/user-interactions/tooltip-appearance", sourceFiles="tooltip-appearance.cs" %}

{% endaspTab %}

## Pointer Drag

You can drag and drop either marker or bar pointer over the desired axis value using [`enableDrag`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer~EnableDrag.html) property in the [`pointer`](https://help.syncfusion.com/cr/cref_files/aspnetcore-js2/Syncfusion.EJ2~Syncfusion.EJ2.LinearGauge.LinearGaugePointer.html).

{% aspTab template="lineargauge/user-interactions/pointer-drag", sourceFiles="pointer-drag.cs" %}

{% endaspTab %}