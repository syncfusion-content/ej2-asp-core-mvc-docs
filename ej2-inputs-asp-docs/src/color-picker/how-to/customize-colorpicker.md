# Customize ColorPicker

## Custom palette

By default, the Palette will be rendered with default colors. To load custom colors in the palette, specify the colors in the [`presetColors`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_PresetColors) property. To customize the color palette, add a custom class to palette tiles using [`beforeTileRender`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_BeforeTileRender) event.

The following sample demonstrates the above functionalities.

{% aspTab template="color-picker/custom-palette", sourceFiles="custom-palette.cs" %}

{% endaspTab %}

## Hide input area from picker

By default, the input area will be rendered in ColorPicker. To hide the input area from it, add `e-hide-value` class to ColorPicker using the [`cssClass`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_CssClass) property.

In the following sample, the ColorPicker is rendered without input area.

{% aspTab template="color-picker/hide-input", sourceFiles="hide-input.cs" %}

{% endaspTab %}

## Custom handle

Color picker handle shape and UI can be customized. Here, we have customized the handle as `svg icon`. The same way you can customize the handle based on your requirement.

The following sample show the customized color picker handle.

{% aspTab template="color-picker/custom-handle", sourceFiles="custom-handle.cs" %}

{% endaspTab %}

## Custom primary button

By default, the applied color will be updated in primary button of the color picker. You can customize that as `icon`.

In the following sample, the `picker` icon is added to primary button and using [`change`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Inputs.ColorPicker.html#Syncfusion_EJ2_Inputs_ColorPicker_Change) event the selected color will be updated in bottom portion of the icon.

{% aspTab template="color-picker/icon", sourceFiles="icon.cs" %}

{% endaspTab %}

>> The Essential JS 2 provides a set of icons that can be loaded by applying `e-icons` class name to the element. You can also use third party icon to customize the primary button.

## Display hex code in input

The color picker input element can be showcased in the place of primary button. The applied color hex code will be updated in the primary button input.

The following sample shows the color picker with input.

{% aspTab template="color-picker/input", sourceFiles="input.cs" %}

{% endaspTab %}

## Custom UI

The color picker UI can be customized in all possible ways. The following sample shows the excel like UI customization with help of SplitButton and Dialog component. In that by clicking the more colors option from color palette, the dialog contains color picker will open.

{% aspTab template="color-picker/excel-ui", sourceFiles="excel-ui.cs" %}

{% endaspTab %}
